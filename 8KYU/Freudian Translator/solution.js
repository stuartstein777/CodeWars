function toFreud(str) {
return str.length === 0 
        ? ""
        : Array(str.split(' ').length).fill('sex').join(' ');
}