String updateLight(String current) {
  if(current == "green") {
    return "yellow";
  } else if(current == "red"){
    return "green";
  }
  return "red";
}