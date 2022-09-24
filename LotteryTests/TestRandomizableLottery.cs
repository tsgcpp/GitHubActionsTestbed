using Lottery;
using Moq;

namespace LotteryTests
{
    public class TestRandomizableLottery
    {
        [Fact]
        public void Draw_ReturnsTrue_IfRandomizerReturnsGreaterThanTheFloor()
        {
            // Given
            const float FirstFloor = 0.5f;
            var randomizerMock = new Mock<IRandomizer>();
            var target = new RandomizableLottery(randomizerMock.Object, FirstFloor);

            // When
            randomizerMock.Setup(m => m.Random).Returns(0.51f);
            bool actual = target.Draw();

            // then
            Assert.True(actual);
        }

        [Fact]
        public void Draw_ReturnsTrue_IfRandomizerReturnsSameAsTheFloor()
        {
            // Given
            const float FirstFloor = 0.5f;
            var randomizerMock = new Mock<IRandomizer>();
            var target = new RandomizableLottery(randomizerMock.Object, FirstFloor);

            // When
            randomizerMock.Setup(m => m.Random).Returns(0.5f);
            bool actual = target.Draw();

            // then
            Assert.True(actual);
        }

        [Fact]
        public void Draw_ReturnsFalse_IfRandomizerReturnsLessThanTheFloor()
        {
            // Given
            const float FirstFloor = 0.5f;
            var randomizerMock = new Mock<IRandomizer>();
            var target = new RandomizableLottery(randomizerMock.Object, FirstFloor);

            // When
            randomizerMock.Setup(m => m.Random).Returns(0.49f);
            bool actual = target.Draw();

            // then
            Assert.False(actual);
        }
    }
}