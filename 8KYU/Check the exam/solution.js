function checkExam(array1, array2) {
 let total = 0;
 console.log(array1);
 console.log(array2);
 for(let i = 0; i < array1.length; i++) {
   if(array2[i] === array1[i])
      total += 4;
    else if(array2[i] === "")
      total += 0;
    else
      total -= 1;
 }
 if(total < 0)
   return 0;
 return total;
}