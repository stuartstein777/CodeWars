function isValidWalk(walk) {
    var nsew = {'w': 0, 'e': 0, 's': 0, 'n': 0}; 
    walk.forEach(x => {console.log(x); nsew[x]++;});
    return walk.length == 10 && nsew['w'] == nsew['e'] && nsew['s'] == nsew['n'];  
}