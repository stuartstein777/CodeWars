function howManySmaller(arr,n){
  return (arr.map((a) => a.toFixed(2)).filter((f, i, _) => f < n)).length;  
}