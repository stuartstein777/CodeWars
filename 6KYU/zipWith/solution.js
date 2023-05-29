function zipWith(fn,a0,a1) {
    const la0 = a0.length;
    const la1 = a1.length;
    
    const l = Math.min(la0, la1);
    res = [];
    
    for(i = 0; i < l; i++) {
      res.push(fn(a0[i], a1[i]));
    }
    return res;
  }