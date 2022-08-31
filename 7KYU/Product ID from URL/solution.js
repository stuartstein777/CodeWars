function getProductId(url){
    return url.substring(url.lastIndexOf("p")+2, url.length-14);
}