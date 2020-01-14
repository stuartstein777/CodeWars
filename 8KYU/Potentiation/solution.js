const power = (x,y) => (y == 0)
                         ? 1
                         : Array.from({length:y-1}).map(_ => x).reduce((acc, i) => acc*i, x)