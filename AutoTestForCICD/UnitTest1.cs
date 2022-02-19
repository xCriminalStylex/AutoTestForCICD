using System;
using Xunit;

namespace AutoTestForCICD
{
    public class TestNewFunction
    {
        [Theory]
        [InlineData(122, 12, 45, 1470, -64686)]
        
        
        
        
        [InlineData(-186592, 98, 17, -1828, -18254940)]
        [InlineData(122, 1896, 78, 23132, -1572984)]
        [InlineData(-5638, 85, 67, -4792, -158166)]
        [InlineData(68578, -452, 28, -30997, -30129340)]
        [InlineData(1257, 742, -89, -21465, -977691)]
        [InlineData(0, 98, 7, 23, -161)]
        [InlineData(6875, 0, 11, 32, -352)]
        [InlineData(-5478, -458, 45, 85, 2505099)]
        [InlineData(7458, -325, -85, 617, -2371405)]
        [InlineData(-2145, 752, -45, 547, -1588425)]
        [InlineData(0, 0, 324, 65, -21060)]
        [InlineData(0, 12, 0, 81, 0)]
        [InlineData(421, 0, 0, -98, 0)]
        [InlineData(8574, -52415, 357, -58, -449385504)]
        [InlineData(-254, -4587, 122, -96, 1176810)]
        [InlineData(-563, 5487, 522, 756, -3483813)]
        [InlineData(-658, 1485, -45, 321, -962685)]
        [InlineData(741, -2965, -295, 84, -2172285)]
        [InlineData(-598, -4526, -49, 161, 2714437)]
        public void TestRemainderByDivision(int x, int y, int z, int j, int expected)
        {
            int actual = NewFunction.MultiplicationPlusSquare(x, y, z, j);
            Assert.Equal(expected, actual);
        }
        
    }
}
