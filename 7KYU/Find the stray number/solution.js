var isSquare = function(arr){
    return (arr.length == 0)
      ? undefined
      : arr.filter(f => {
                    var s = Math.floor(Math.sqrt(f));
                    return (s * s == f);
                  }).length == arr.length;
}