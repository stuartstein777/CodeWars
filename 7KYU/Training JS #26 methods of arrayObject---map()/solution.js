function isolateIt(arr) {
  return arr.map(s => s.length % 2 == 0
                        ? s.slice(0, (s.length / 2)) + "|" + s.slice(s.length/2)
                        : s.slice(0, (s.length-1) / 2) + "|" + s.slice((s.length+1)/2));
}