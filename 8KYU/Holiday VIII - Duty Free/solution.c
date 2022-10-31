int duty_free(int price, int discount, int holiday_cost) {
    return floor(holiday_cost / (price * (discount / 100.0)));
}