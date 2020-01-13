function toTime(seconds) {
  var hours = Math.floor(seconds / 3600);
  var minutes = Math.floor((seconds - (hours * 3600)) / 60);
  return hours + " hour(s) and " + minutes + " minute(s)";
}