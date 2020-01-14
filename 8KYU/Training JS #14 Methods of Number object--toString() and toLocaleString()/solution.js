function colorOf(r,g,b){
  var rx = r.toString(16);
  if(rx.length === 1)
    rx = "0"+rx;
  var gx = g.toString(16);
  if(gx.length === 1)
    gx = "0"+gx;
  var bx = b.toString(16);
  if(bx.length === 1)
    bx = "0"+bx;

  return "#"+rx+gx+bx;
}