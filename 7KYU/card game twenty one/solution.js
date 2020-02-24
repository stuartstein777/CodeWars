let cardValues = {'A': 11, 'J': 2, 'Q': 3, 'K': 4, '2': 2,
                  '3': 3, '4': 4, '5': 5, '6': 6, '7': 7,
                  '8': 8, '9': 9, '10': 10};

function solution(card1, card2, card3) {
  let total = [card1, card2, card3].reduce((acc, c) => acc+cardValues[c.slice(0,-1)], 0);
  if(total === 21)
    return 'twenty-one';
  else if(total > 21)
    return 'more';
  else
    return 'less';
}