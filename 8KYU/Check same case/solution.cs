public class Kata {
    public static int SameCase(char a, char b)
    {
        if (!char.IsLetter(a) || !char.IsLetter(b))
            return -1;

        if ((char.IsLower(a) && char.IsLower(b)) || (char.IsUpper(a) && char.IsUpper(b)))
            return 1;
        return 0;
    }
}