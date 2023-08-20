public class Arithmophobia {
    static public boolean AmIAfraid(final String day, final int num) {
        return (day == "Monday" && num == 12) ||
       (day == "Tuesday" && num > 95) ||
       (day == "Wednesday" && num == 34) ||
       (day == "Thursday" && num == 0) ||
       (day == "Friday" && num % 2 == 0) ||
       (day == "Saturday" && num == 56) ||
       (day == "Sunday" && (num == 666 || num == -666));
    }
}