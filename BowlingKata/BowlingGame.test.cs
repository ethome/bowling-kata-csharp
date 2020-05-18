using Xunit;

namespace BowlingKata
{
    public class BowlingGameTest
    {
        [Fact]
        public void Score_OneRoll_ShouldReturnRolledAmount()
        {
            BowlingGame game = new BowlingGame();

            game.Roll(3);

            Assert.Equal(3, game.Score());
        }
    }
}
