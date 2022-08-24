function abbrevName(name){
    var splits = name.split(" ");
    return `${splits[0][0]}.${splits[1][0]}`.toUpperCase();
}