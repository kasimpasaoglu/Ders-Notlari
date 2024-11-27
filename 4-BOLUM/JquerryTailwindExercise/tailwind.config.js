/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["src/*.{html,js}"],
  theme: {
    colors: {
      darkBrown: '#44281d',
      lightPeach: '#e4a788',
      lemonYellow: '#f0e14a',
      limeGreen: '#97ce4c',
      pastelPink: '#e89ac7'
    },
    extend: {
      fontFamily: {
        schwifty: ['Schwifty', 'sans-serif'],
      }
    }
  },
  plugins: [],
}