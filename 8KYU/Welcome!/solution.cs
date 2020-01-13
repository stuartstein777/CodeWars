using System.Collections.Generic;
public static class Kata
{
  private static Dictionary<string, string> _greetings = new Dictionary<string, string>
    {{"english", "Welcome"},
    {"czech", "Vitejte"},
    {"danish", "Velkomst"},
    {"dutch", "Welkom"},
    {"estonian", "Tere tulemast"},
    {"finnish", "Tervetuloa"},
    {"flemish", "Welgekomen"},
    {"french", "Bienvenue"},
    {"german", "Willkommen"},
    {"irish", "Failte"},
    {"italian", "Benvenuto"},
    {"latvian", "Gaidits"},
    {"lithuanian", "Laukiamas"},
    {"polish", "Witamy"},
    {"spanish", "Bienvenido"},
    {"swedish", "Valkommen"},
    {"welsh", "Croeso"}};
    public static string Greet(string language)
      => _greetings.ContainsKey(language) 
            ? _greetings[language.ToLower()]
            : _greetings["english"];
}