function findUniq(arr) {
   var sorted = arr.sort(function(a, b){return b-a});
   var sub = [arr[0], arr[1], arr[arr.length-1]];
   if(sub[0] !== sub[1] && sub[0] !== sub[2])
     return sub[0];
   else
     return sub[2];
}