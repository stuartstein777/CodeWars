export function capitals (word: string): number[] {
	var idxs = [];
  
  for(var i = 0; i < word.length; i++) {
    if(word[i] == word[i].toUpperCase()) {
      idxs.push(i);
    }
  }
  
  return idxs;
}