RPSUI run = new RPSUI();
run.RPS();
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
      int computerChoice = rnd.Next(1,4);
      System.Console.WriteLine("Enter the number of your choice:\n" +
      "1. Rock\n" +
      "2. Paper\n" +
      "3. Scissors");
      string userChoiceAsString = Console.ReadLine();
      int userChoice = int.Parse(userChoiceAsString);

      Console.Clear();

      Result outcome = _repository.ComputeWinner(userChoice, computerChoice);
      System.Console.WriteLine($"{outcome.Results}\n {outcome.Winner} win(s)!\n User Score: {RPSRepository.userScore}\n Computer Score: {RPSRepository.computerScore}");
      System.Console.WriteLine("Do you want to keep playing? (y/n)");
      keepPlaying = Console.ReadLine().ToLower();
      Console.Clear();
    }
  }
}

public class RPSRepository 
{
  static public int userScore = 0;
  static public int computerScore = 0;

  public Result ComputeWinner(int userChoice, int computerChoice)
  {
    if (userChoice == computerChoice)
    {
      return new Result("It's a tie!", userScore, computerScore, "Nobody");
    } else if ( userChoice > computerChoice)
    {
      userScore++;
      string outcome = $"{(Result.RpsChoice)userChoice} beats {(Result.RpsChoice)computerChoice}";
      return new Result(outcome, userScore, computerScore, "You");
    } else 
    {
      computerScore++;
      string outcome = $"{(Result.RpsChoice)computerChoice} beats {(Result.RpsChoice)userChoice}";
      return new Result(outcome, userScore, computerScore, "The computer");
    }
  }
}

public class Result
{
  public enum RpsChoice
  {
    rock = 1,
    paper,
    scissors
  }
  public string Results { get; set; }
  public int UserScore { get; set; }
  public int ComputerScore { get; set; }
  public string Winner { get; set; }

  public Result(string results, int userScore, int computerScore, string winner)
  {
    Results = results;
    UserScore = userScore;
    ComputerScore = computerScore;
    Winner = winner;
  }
}