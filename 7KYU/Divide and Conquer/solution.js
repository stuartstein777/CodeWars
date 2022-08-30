function divCon(x){
    console.log(x);
    var numbers = x.filter(f => typeof(f) === 'number').reduce((acc, i) => acc + i, 0);
    var strNumbers = x.filter(f => typeof(f) === 'string').reduce((acc, i) => acc + Number(i), 0);
    return numbers - strNumbers;
  }