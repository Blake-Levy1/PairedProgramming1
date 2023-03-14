public class RPSUI
{
  private RPSRepository _repository = new RPSRepository();
  public void RPS()
  {
    Console.Clear();

    string keepPlaying = "";
    System.Console.WriteLine("Lets Play rock paper scissors!");

    while (keepPlaying != "n")
    {
      Random rnd = new Random();
      int computerChoice = rnd.Next(1, 4);
      System.Console.WriteLine("Enter the number of your choice:\n" +
      "1. Rock\n" +
      "2. Paper\n" +
      "3. Scissors");
      string userChoiceAsString = Console.ReadLine();
      int userChoice = int.Parse(userChoiceAsString);
      if (userChoice > 0 && userChoice < 4)
      {
        Console.Clear();

        Result outcome = _repository.ComputeWinner(userChoice, computerChoice);
        System.Console.WriteLine($"{outcome.Results}\n {outcome.Winner} win(s)!\n User Score: {RPSRepository.userScore}\n Computer Score: {RPSRepository.computerScore}");
        System.Console.WriteLine("Do you want to keep playing? (y/n)");
        keepPlaying = Console.ReadLine().ToLower();
        Console.Clear();
      }
      else
      {
        Console.Clear();
        System.Console.WriteLine("Please select a valid number\n");
      }

    }
  }
}