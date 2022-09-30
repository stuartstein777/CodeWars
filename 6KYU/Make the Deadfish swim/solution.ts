/** return the output array and ignore all non-op characters */
export function parse(data: string): number[] {
    var v: number = 0;
    var outputs: number[] = [];
    for(var i:number = 0; i < data.length; i++)
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