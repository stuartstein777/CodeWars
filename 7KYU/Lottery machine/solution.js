function lottery(str){
    var digits = str.match(/\d/g);
    return (digits === null)
      ? "One more run!"
      : digits.filter((c, i, arr) => arr.indexOf(c) === i)
              .join('');
}