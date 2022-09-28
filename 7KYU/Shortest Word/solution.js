function findShort(s){
    return Math.min(...s.split(' ').map(c => c.length));
}