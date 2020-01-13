function remove(s,n){
  console.log(`s: ${s} -- n: ${n}`);
  for(var i = 0; i < n; i++)
    s = s.replace('!', '');
  return s;  
}