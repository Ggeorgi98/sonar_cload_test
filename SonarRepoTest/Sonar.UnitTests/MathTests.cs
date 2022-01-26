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
    }
}
