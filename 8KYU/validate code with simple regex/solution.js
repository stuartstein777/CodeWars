function validateCode (code) {
    var pattern = new RegExp('^[1-3]');
    return pattern.test(code);
}