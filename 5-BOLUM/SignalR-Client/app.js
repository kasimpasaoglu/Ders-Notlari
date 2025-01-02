// !!!!!!!!! http://wissenchatapi.runasp.net/chatHub
const connection = new signalR.HubConnectionBuilder()
    .withUrl("http://wissenchatapi.runasp.net/chatHub")
    .configureLogging(signalR.LogLevel.Information)
    .build();

async function start() {
    try {
        await connection.start();
        console.log("SignalR Connected.");
    } catch (err) {
        console.log(err);
        setTimeout(start, 5000);
    }
};

connection.onclose(async () => {
    await start();
});

// Start the connection.
start();

const colors = {
    '/gray': 'gray',
    '/black': 'black',
    '/cyan': 'cyan',
    '/green': 'green',
    '/orange': 'orange',
    '/purple': 'purple',
    '/red': 'red',
    '/lime': 'lime',
    '/yellow': 'yellow',
    '/blue': 'blue',
    '/white': 'white',
    '/deeppink': 'deeppink'
}

const commandList = document.querySelector('#commands');

Object.entries(colors).forEach(([key, value]) => {
    const button = document.createElement('button');
    const textColor = ['white', 'yellow', 'cyan', 'lime'].includes(value) ? 'text-black' : 'text-white';
    button.type = 'button';
    button.className = `py-2 duration-500 rounded-lg min-w-32 hover:scale-105 ${textColor}`;
    button.style.backgroundColor = value;
    button.textContent = key;
    button.value = key;
    button.onclick = function () { AutoCommand(this); };
    commandList.prepend(button);
})

let partyInterval = null;
connection.on("ReceiveMessage", (user, message) => {
    const now = new Date();
    const formattedTime = now.toLocaleString('en-US', {
        year: '2-digit',
        month: '2-digit',
        day: '2-digit',
        hour: '2-digit',
        minute: '2-digit',
        second: '2-digit',
        hour12: false
    });
    const msg = `[${formattedTime}] - ${user} : ${message}`;
    const body = document.body;

    if (message === '/clear') {
        const listItems = document.querySelector('#messageField');
        listItems.innerHTML = '';
    } else if (colors[message]) {
        body.style.backgroundColor = colors[message];
    } else if (message === '/party') {
        if (partyInterval) {
            clearInterval(partyInterval);
            partyInterval = null;
            body.style.backgroundColor = '';
        } else {
            const rainbowColors = ['red', 'orange', 'yellow', 'green', 'blue', 'indigo', 'violet', 'deeppink', 'white', 'black', 'cyan', 'gray', 'lime'];
            let colorIndex = 0;
            partyInterval = setInterval(() => {
                body.style.backgroundColor = rainbowColors[colorIndex];
                colorIndex = (colorIndex + 1) % rainbowColors.length;
            }, 400);
        }
    } else {
        const messageList = document.querySelector('#messageField');
        const li = document.createElement("li");
        li.textContent = msg;
        messageList.prepend(li);
    }
});

document.querySelector('#UserInput').addEventListener('keypress', async (event) => {
    if (event.key === 'Enter') {
        await SendMessage();
    }
});

document.querySelector('#Message').addEventListener('keypress', async (event) => {
    if (event.key === 'Enter') {
        await SendMessage();
    }
});

async function SendMessage() {
    const senderField = document.querySelector('#senderField');
    const user = document.getElementById("UserInput");
    const message = document.getElementById("Message");
    const responseField = document.querySelector('#responseField');

    // !!!!!!!!!  http://wissenchatapi.runasp.net/api/Chat/Send
    const response = await fetch("http://wissenchatapi.runasp.net/api/Chat/Send", {
        method: "POST",
        headers: {
            'Content-Type': "Application/json"
        },
        body: JSON.stringify({ User: user.value, Message: message.value })
    });
    if (!response.ok) {
        senderField.classList.remove('bg-slate-200');
        senderField.classList.add('bg-red-500');
        responseMsg = await response.text()
        responseField.innerHTML = responseMsg
    }
    else {
        senderField.classList.remove('bg-slate-200');
        senderField.classList.add('bg-green-500');
        responseField.innerHTML = '';
    }
    senderField.classList.add('animate-pulseFast');
    setTimeout(() => {
        senderField.classList.remove('animate-pulseFast');
        senderField.classList.replace('bg-red-500', 'bg-slate-200');
        senderField.classList.replace('bg-green-500', 'bg-slate-200');
    }, 1000);
    message.value = '';
}

function HelpBtnHandler() {
    const helpField = document.getElementById("helpField");
    const helpBtn = document.getElementById("helpBtn");

    const isVisible = helpField.style.opacity === "1";

    if (isVisible) {
        //gizle
        helpField.style.opacity = "0";
        helpField.style.zIndex = "-1";
        helpBtn.style.backgroundColor = "green";
        helpBtn.textContent = "?";
    } else {
        // goster
        helpField.style.opacity = "1";
        helpField.style.zIndex = "10";
        helpBtn.style.backgroundColor = "red";
        helpBtn.textContent = "X";
    }


    helpField.style.transition = "opacity 0.5s ease-in-out, z-index 0.5s ease-in-out";
}

function AutoCommand(button) {
    const command = button.value;
    const messageInput = document.querySelector('#Message')
    messageInput.value = command;

    SendMessage()
    HelpBtnHandler()
}

const emojiBtn = document.getElementById("emojiBtn");
const emojiPalette = document.getElementById("emojiPalette");

emojiBtn.addEventListener("click", () => {
    const isHidden = emojiPalette.style.opacity === "0" || emojiPalette.style.opacity === "";

    if (isHidden) {
        emojiPalette.style.opacity = "1";
        emojiPalette.style.zIndex = "10";
    } else {
        emojiPalette.style.opacity = "0";
        emojiPalette.style.zIndex = "-10";
    }
});

emojiPalette.addEventListener("click", (event) => {
    if (event.target.tagName === "SPAN") {
        const messageInput = document.getElementById("Message");
        messageInput.value += event.target.textContent;

        // Paleti kapat
        emojiPalette.style.opacity = "0";
        emojiPalette.style.zIndex = "-10";
    }
});

