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