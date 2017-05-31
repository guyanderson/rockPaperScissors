// | Both players pick Rock | P1 Rock, P2 Rock | Tie |
// | Both players pick Scissors | P1 Rock, P2 Rock | Tie |
// | Both players pick Paper | P1 Rock, P2 Rock | Tie |


using Xunit;
namespace RockPaperScissors.Objects
{
  public class GameTest
  {
    [Fact]
// Name test:  METHOD, BEHAVIOR, OUTCOME
    public void CompareInputs_BothSame_ReturnsTie()
    {
      // ARRANGE:
      // set up fake test data
      string inputP1 = "rock";
      string inputP2 = "rock";
      // Instantiation  does not get fed data??
      Game newGame = new Game(inputP1, inputP2);
      // ACT: set _output
      newGame.CompareInputs(inputP1, inputP2);
      // ASSERT
      Assert.Equal("tie", newGame.GetOutput());
    }



  }
}
