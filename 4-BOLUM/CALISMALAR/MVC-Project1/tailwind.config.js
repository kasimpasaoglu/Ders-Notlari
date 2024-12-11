/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    './Views/**/*.cshtml', // Razor View dosyalarınız
    './wwwroot/js/**/*.js' // Statik JavaScript dosyalarınız
  ],
  theme: {
    extend: {
      colors: {
        navyBlue: "#3D5A80",
        skyBlue: "#98C1D9",
        aqua: "#E0FBFC",
        coral: "#EE6C4D",
        darkNavy: "#293241",
      },
    },
  },
  plugins: [],
}

