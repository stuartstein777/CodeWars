function isToday(date) {
  var today = new Date();
  return date.getDay() === today.getDay() &&
         date.getMonth() === today.getMonth() &&
         date.getFullYear() === today.getFullYear();
}