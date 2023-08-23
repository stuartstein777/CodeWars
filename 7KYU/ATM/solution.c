int nb_notes_needed (unsigned n)
{
  unsigned res = 0;
  
  while(n > 0) {
    if(n >= 500) {
      unsigned d = (unsigned)floor(n / 500);
      n -= 500 * d;
      res += d;
    } else if(n >= 200) {
      unsigned d = (unsigned)floor(n / 200);
      n -= 200 * d;
      res += d;
    } else if(n >= 100) {
      unsigned d = (unsigned)floor(n / 100);
      n -= 100 * d;
      res += d;
    } else if(n >= 50) {
      unsigned d = (unsigned)floor(n / 50);
      n -= 50 * d;
      res += d;
    } else if(n >= 20) {
      unsigned d = (unsigned)floor(n / 20);
      n -= 20 * d;
      res += d;
    }  else if(n >= 10) {
      unsigned d = (unsigned)floor(n / 10);
      n -= 10 * d;
      res += d;
    } else {
      return -1;
    }
  }
    
	return res;
}