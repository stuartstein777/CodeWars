function reverse(s){
    return s.split('').reverse().join('');
  }
  
  function esrever(s) {
    return (s == '')
      ? ''
      : (s.slice(0, -1).split(' ')
                       .reverse()
                       .map(m => reverse(m))
                       .join(' '))  + s[s.length-1];
}
  