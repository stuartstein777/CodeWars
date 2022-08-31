function averageLength(xs) { 
    var avg = Math.round(xs.reduce((acc, i) => acc += i.length, 0) / xs.length);
    return xs.map(x => `${x[0]}`.repeat(avg)); 
}