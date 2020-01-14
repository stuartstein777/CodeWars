function sortLetters(piles) {
  var justLetters = [];
  
  piles.forEach(function(x){
   x.forEach(function(y){
		if(!Number.isInteger(y)){
       justLetters.push(y.toUpperCase());
    }
   })
  });
  console.log(justLetters);
  var consonents = justLetters.filter(f => isVowel(f) === false);
  var vowels = justLetters.filter(f => isVowel(f) === true);
  return [vowels, consonents]
}

function isVowel(letter){
  if(letter === "A" || letter === "E" || letter === "I" || letter === "O" || letter === "U")
    return true;
  return false;
}