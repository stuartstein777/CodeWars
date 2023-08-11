function alphanumeric(string){
    if(string.length == 0) {
      return false;
    }
    
    const regex = new RegExp('[^0-9A-Za-z]', 'g');
    return !regex.test(string);
}
  