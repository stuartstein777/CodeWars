function getNewNotes(salary,bills){
    return Math.floor(Math.max((salary - bills.reduce((acc, i) => acc + i, 0)) / 5, 0));
  }