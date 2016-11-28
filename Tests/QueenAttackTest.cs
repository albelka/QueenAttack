using Xunit;
namespace QueenAttack.Objects
{
  public class QueenTest
  {
    [Fact]
    public void CanTakePiece_Horizontal_true()
    {
      Queen testQueen = new Queen();
      Assert.Equal(true, testQueen.CanTakePiece(1, 0));
    }
    
  }
}
