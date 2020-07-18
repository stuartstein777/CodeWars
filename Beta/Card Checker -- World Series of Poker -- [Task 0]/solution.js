function checkCard(card) {
  var xs = card.split("");
  return ['♠', '♣', '♥', '♦'].indexOf(xs[1]) != -1 &&
         ['2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K', 'A'].indexOf(xs[0]) != -1;
}
