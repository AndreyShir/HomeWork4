using System;
using Xunit;

namespace Shapes.Tests
{
    public class UnitTestShapes
    {
        [Fact]
        public void BoxVolumeTest()
        {
            // Arrange - установка начальных параметров
            Box box = new Box(10);

            // Act - выполнение
            double result = box.Volume();

            // Assert - верификация
            Assert.Equal(1000.0, result, 5);

        }

        [Fact]
        public void BallVolumeTest()
        {
            var ball = new Ball(15.0);

            double vol = ball.Volume();

            Assert.Equal(14137.167, vol, 3);
        }

        [Theory]
        [InlineData(20,10)]
        public void TestShapeAddition(double containerHeight, double ballRadius)
        {
            var box = new Box(containerHeight);
            var ball = new Ball(ballRadius);

            Assert.True(box.Add(ball));
        }
    }
}
