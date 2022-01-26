using SonarRepoTest;
using Xunit;

namespace Sonar.UnitTests
{
    public class MathTests
    {
        [Theory]
        [InlineData(2,3,5)]
        public void AddTest(int a, int b, int expected)
        {
            var s = new SimpleMath();
            var actual = s.Add(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, -1)]
#pragma warning disable S4144 // Methods should not have identical implementations
        public void SubTest(int a, int b, int expected)
#pragma warning restore S4144 // Methods should not have identical implementations
        {
            var s = new SimpleMath();
            var actual = s.Sub(a, b);
            Assert.Equal(expected, actual);
        }
    }
}
