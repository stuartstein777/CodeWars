public class Person
{
  private string _firstName;
  private string _lastName;
  private int _age;
  private string _gender;
  
  public Person(string firstName = "John",
                string lastName = "Doe",
                int age = 0,
                string gender = "Male")
  {
    _firstName = firstName;
    _lastName = lastName;
    _age = age;
    _gender = gender;
  }
  
  public string FirstName => _firstName;
  public string LastName => _lastName;
  public int Age => _age;
  public string Gender => _gender;
  
  public string SayFullName()
    => $"{_firstName} {_lastName}";
  
  public static string GreetExtraTerrestrials(string raceName)
    => $"Welcome to Planet Earth {raceName}";
}