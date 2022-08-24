component {
    numeric function past(required numeric h, required numeric m, required numeric s) {
        return (s * 1000) + (m * 60000) + (h * 3600000)
    }
}