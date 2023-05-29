function removeConsecutiveDuplicates(string) {
 
    const words = string.split(" ");
    
    let lastWord = words[0];
    const res = [lastWord];
    
    for(var i = 0; i < words.length; i++) {
      if(words[i] != lastWord) {
        lastWord = words[i];
        res.push(words[i]);
      }
    }
    return res.join(" ");
  }