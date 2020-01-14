function alienLanguage(str){
  return str.split(" ")
            .map(s => s.slice(0, s.length-1).toUpperCase() + s[s.length-1].toLowerCase())
            .join(" ");
}