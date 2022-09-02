public class Kata
{
  public static string ChromosomeCheck(string sperm)
    => (sperm == "XY")
          ? "Congratulations! You're going to have a son."
          : "Congratulations! You're going to have a daughter.";
}