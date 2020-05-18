using Xunit;

namespace BowlingKata
{
    public class BowlingGameTest
    {
        [Fact]
        public void score_shouldReturnRolledAmount()
        {
            BowlingGame game = new BowlingGame();

            game.roll(3);

            Assert.Equal(3, game.score());
        }
    }
}
