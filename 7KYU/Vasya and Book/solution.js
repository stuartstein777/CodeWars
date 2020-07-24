function bookIsDay(pages, days){
  var day = 0;
  while (pages > 0) {
    pages -=days[day]
    day ++;
    if(day == 7)
      day = 0;
  }
  return day == 0 ? 7 : day;
}
