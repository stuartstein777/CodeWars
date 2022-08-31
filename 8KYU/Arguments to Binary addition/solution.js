function arr2bin(arr){
    console.log(arr);
    if(arr.some((i) => Number.isNaN(i)))
      return 'NaN';
    return arr.reduce((acc, i) => acc + ((!Number.isNaN(i) && Number.isInteger(i)) ? i : 0), 0).toString(2);
}