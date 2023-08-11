public class Hello{
  public String sayHello(String [] names, String city, String state){
    String name = String.join(" ", names);
    return "Hello, " + name + "! Welcome to " + city + ", " + state + "!";
  }
}