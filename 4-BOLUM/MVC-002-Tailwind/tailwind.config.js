/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    './Views/**/*.cshtml', // Razor View dosyalarınız
    './wwwroot/js/**/*.js' // Statik JavaScript dosyalarınız
  ],
  theme: {
    extend: {},
  },
  plugins: [],
};

