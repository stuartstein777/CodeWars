function feast(beast, dish) {
    return dish.toLowerCase().startsWith(beast.substring(0,1).toLowerCase()) &&
           dish.toLowerCase().endsWith(beast.substring(beast.length-1).toLowerCase());
}