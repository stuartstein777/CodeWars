using System;
using System.Linq;

public class Kata
{
    public static string[][] search_names(string[][] logins)
        => logins.Where(login => login[0].EndsWith("_")).ToArray();
}