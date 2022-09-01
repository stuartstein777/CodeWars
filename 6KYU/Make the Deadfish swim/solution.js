// Return the output array, and ignore all non-op characters
function parse( data )
{
  var v = 0;
  var outputs = [];
  for(var i = 0; i < data.length; i++)
  {
    if(data[i] == 'i')
      v++;
    else if(data[i] == 'd')
      v--;
    else if(data[i] == 's')
      v *= v;
    else if(data[i] == 'o')
      outputs.push(v);
  }
  return outputs;
}
