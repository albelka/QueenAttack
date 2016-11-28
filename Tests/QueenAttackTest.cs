using Xunit;
namespace QueenAttack.Objects
{
  public class QueenTest
  {
    [Fact]
    public void CanTakePiece_Horizontal_true()
    {
      Queen testQueen = new Queen();
      Assert.Equal(true, testQueen.CanTakePiece(0, 3));
    }
    [Fact]
    public void CanTakePiece_Vertical_true()
    {
      Queen testQueen = new Queen();
      Assert.Equal(true, testQueen.CanTakePiece(3, 0));
    }
    [Fact]
    public void CanTakePiece_Diagonal_true()
    {
      Queen testQueen = new Queen();
      Assert.Equal(true, testQueen.CanTakePiece(0, 0));
    }
  }
}
