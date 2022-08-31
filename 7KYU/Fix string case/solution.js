function solve(s){
    var upperCaseCount = (s.match(/[A-Z]/g) || []).length;
    return (upperCaseCount > s.length / 2)
      ? s.toUpperCase()
      : s.toLowerCase();
}