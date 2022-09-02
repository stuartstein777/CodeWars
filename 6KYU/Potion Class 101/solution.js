function mixColor(c1, v1, c2, v2) {
    var totalV = v1 + v2;
    return Math.ceil(((c1 * (v1/totalV)) + (c2 * (v2/totalV))) % 255);
}
  
class Potion {  
  constructor(color, volume){
    this.color = color;
    this.volume = volume;
  }
}

Potion.prototype.mix = function (potion) {
    return new Potion([mixColor(this.color[0], this.volume, potion.color[0], potion.volume),
                       mixColor(this.color[1], this.volume, potion.color[1], potion.volume),
                       mixColor(this.color[2], this.volume, potion.color[2], potion.volume)],
                      (this.volume + potion.volume));
}