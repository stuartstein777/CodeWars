function contamination(text, char){
   return (text === "" || char === "")
    ? ""
    : char.repeat(text.length); 
}