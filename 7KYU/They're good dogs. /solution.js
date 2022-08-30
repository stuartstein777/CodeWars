function weRateDogs(str, rating){
    var s = str.split('/');
    return s[0].slice(0, -1) + rating + "/" + s[1];
}