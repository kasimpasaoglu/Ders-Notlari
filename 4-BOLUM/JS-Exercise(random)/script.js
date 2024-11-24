let randomNumber = Math.floor(Math.random() * 100) + 1;
let remainingGuess = 10;

const guessInput = document.getElementById('guess');
const submitButton = document.getElementById('submitGuess');
const feedback = document.getElementById('feedback');
const remainingGuessesElement = document.getElementById('remainingGuesses');
const endMessage = document.getElementById('endMessage');

remainingGuessesElement.innerHTML = remainingGuess;

submitButton.addEventListener('click', () => {
    const
})