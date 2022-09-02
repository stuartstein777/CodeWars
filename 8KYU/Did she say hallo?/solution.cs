using System;

public class Kata
{
    public static bool Validate_hello(string greetings)
    {
        return greetings.ToLower().IndexOf("hello") != -1 ||
                greetings.ToLower().IndexOf("ciao") != -1 ||
                greetings.ToLower().IndexOf("salut") != -1 ||
                greetings.ToLower().IndexOf("hallo") != -1 ||
                greetings.ToLower().IndexOf("hola") != -1 ||
                greetings.ToLower().IndexOf("ahoj") != -1 ||
                greetings.ToLower().IndexOf("czesc") != -1;
    }
}