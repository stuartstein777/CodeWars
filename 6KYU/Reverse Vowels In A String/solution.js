function reverseVowels(str) {
    var vowelIndexes = [];
    var foundVowels = [];
    const vowels = new Set(['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U']);
    for(let i = 0; i < str.length; i++) {
       if(vowels.has(str[i])){
         vowelIndexes.push(i);
         foundVowels.push(str[i]);
       }
    }
    let res = str.split("");
    const len = foundVowels.length-1;
    for(let i = vowelIndexes.length-1; i >= 0; i--) {
      res[vowelIndexes[i]] = foundVowels[len-i];
    }
    return res.join("");
  }