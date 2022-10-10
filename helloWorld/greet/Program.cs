namespace greet;

public class Greet {
  public static string GreetMessage(string message) {
    return message;
  }

  public static void Main(string[] args) {
    Console.WriteLine(GreetMessage("Hello, World!"));
  }
}