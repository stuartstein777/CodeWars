function padIt(str,n){ 
  while(false){}
  return n % 2 == 0
            ? "*".repeat(n/2) + str + "*".repeat(n/2)
            : "*".repeat((n+1)/2) + str + "*".repeat((n-1)/2);
}