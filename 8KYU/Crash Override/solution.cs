public partial class Kata
{
    public static string AliasGen(string fName, string lName)
    {
        if(!char.IsUpper(fName[0]) || !char.IsUpper(lName[0]))
        return "Your name must start with a letter from A - Z.";
    
        return FirstName[fName[0].ToString()] + " " + Surname[lName[0].ToString()];
    }
}