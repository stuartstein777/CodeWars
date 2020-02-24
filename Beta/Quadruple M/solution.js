function listMix(arr){
  return [max(arr), min(arr), median(arr), mean(arr)]
}

const min = (arr) => arr.sort((a, b) => a-b)[0];
const max = (arr) => arr.sort((a, b) => b-a)[0];
const mean = (arr) => Number((arr.reduce((acc, i) => i+acc, 0) / arr.length).toFixed(2));
function median(arr){
  arr.sort((a, b) => a-b);
  return (arr.length %2 === 0)
    ? Number(((arr[arr.length/2] + arr[(arr.length/2)-1])/2).toFixed(2))  
    : Number((arr[Math.floor(arr.length/2)]).toFixed(2));
}