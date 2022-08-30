function oddRow(n) {
    const last = (n * n) + (n - 1);
    const start = last - (2 * (n - 1));
    
    var result = [];
    for(var i = start; i <= last; i+=2) {
      result.push(i);
    }
    return result;
}