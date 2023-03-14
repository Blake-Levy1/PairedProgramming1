public class RPSRepository
{
  static public int userScore = 0;
  static public int computerScore = 0;

  public Result ComputeWinner(int userChoice, int computerChoice)
  {
    if (Math.Abs(userChoice - computerChoice) == 2)
    {
      if (userChoice < computerChoice)
      {
        userScore++;
        string outcome = $"{(Result.RpsChoice)userChoice} beats {(Result.RpsChoice)computerChoice}";
        return new Result(outcome, userScore, computerScore, "You");
      }
      else
      {
        computerScore++;
        string outcome = $"{(Result.RpsChoice)computerChoice} beats {(Result.RpsChoice)userChoice}";
        return new Result(outcome, userScore, computerScore, "The computer");
      }
    }
    else if (userChoice == computerChoice)
    {
      return new Result("It's a tie!", userScore, computerScore, "Nobody");
    }
    else if (userChoice > computerChoice)
    {
      userScore++;
      string outcome = $"{(Result.RpsChoice)userChoice} beats {(Result.RpsChoice)computerChoice}";
      return new Result(outcome, userScore, computerScore, "You");
    }
    else
    {
      computerScore++;
      string outcome = $"{(Result.RpsChoice)computerChoice} beats {(Result.RpsChoice)userChoice}";
      return new Result(outcome, userScore, computerScore, "The computer");
    }
  }
}
