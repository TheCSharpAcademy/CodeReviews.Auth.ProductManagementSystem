/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./src/**/*.{html,ts}"],
  theme: {
    extend: {
      colors: {
        "midnight-blue": "#0b2145",
        "steel-blue": "#3661a0",
        "royal-blue": "#3a82e4",
        "royal-blue-hover": "#5da0fd",
        "dark-slate-gray": "#193050",
      },
    },
  },
  plugins: [],
};
