let randomNumber = Math.floor(Math.random() * 100) + 1;
let remainingGuess = 10;

const guessInput = document.getElementById('guess');
const submitButton = document.getElementById('submitGuess');
const feedback = document.getElementById('feedback');
const remainingGuessesElement = document.getElementById('remainingGuesses');
const endMessage = document.getElementById('endMessage');
const restartButton = document.getElementById('restartGame');

remainingGuessesElement.innerHTML = `Kalan Tahmin Hakki : ${remainingGuess}`

function endGame() {
    guessInput.disabled = true;
    submitButton.disabled = true;
    restartButton.style.display = 'block'; // Tekrar Dene butonunu göster
}

submitButton.addEventListener('click', () => {
    const userguess = Number(guessInput.value);

    if (!userguess || userguess < 1 || userguess > 100) {
        feedback.textContent = "Lutfen 1 ile 100 arasi bir tahmin girin.";
        feedback.classList.add('animate-fadeIn');
        console.logass()
        return;
    }
    if (userguess === randomNumber) {
        feedback.textContent = `Dogru tahmin:  ${randomNumber}`;
        endMessage.textContent = "🎉 🏆 ✨ Tebrikler!!!";
        feedback.classList.add('animate-pulse', 'animate-fadeIn');
        endMessage.classList.add('animate-fadeIn');
        endGame();
    }
    else if (userguess > randomNumber) {
        feedback.textContent = "⬇️ Daha kucuk bir sayi dene ⬇️";
    }
    else {
        feedback.textContent = "⬆️ Daha buyuk bir sayi dene ⬆️";
    }
    feedback.classList.add('animate-fadeIn');
    remainingGuess--;
    remainingGuessesElement.innerHTML = `Kalan Tahmin Hakki : ${remainingGuess}`;

    if (remainingGuess === 0) {
        feedback.textContent = `Tahmin Hakkiniz Kalmadi. Dogru sayi: ${randomNumber}`;
        feedback.classList.add('animate-pulse');
        endMessage.textContent = "😢 💔 🕳️ Kaybettiniz !!!";
        endMessage.classList.add('animate-fadeIn');
        endGame();
    }
    setTimeout(() => feedback.classList.remove('animate-fadeIn'), 500);
})

restartButton.addEventListener('click', () => {
    randomNumber = Math.floor(Math.random() * 100) + 1;
    remainingGuess = 10;

    guessInput.disabled = false;
    submitButton.disabled = false;
    restartButton.style.display = 'none'

    guessInput.value = "";
    feedback.textContent = "";
    feedback.classList.remove('animate-pulse')
    endMessage.textContent = "";
    endMessage.classList.remove('animate-fadeIn');

    remainingGuessesElement.innerHTML = `Kalan Tahmin Hakki : ${remainingGuess}`
})
