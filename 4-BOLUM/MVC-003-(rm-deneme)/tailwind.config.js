/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    './Views/**/*.cshtml', // Razor View dosyalari
    './wwwroot/js/**/*.js', // Statik JavaScript dosyalari
    './wwwroot/css/**/*.css'
  ],
  theme: {
    extend: {},
  },
  plugins: [],
}

