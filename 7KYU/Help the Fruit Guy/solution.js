function removeRotten(bagOfFruits){
    if(bagOfFruits == null){
      return [];
    }
    return bagOfFruits.map(f => f.startsWith("rotten") ? f.substring(6).toLowerCase() : f);
  }