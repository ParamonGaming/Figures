

namespace Tests
{
    public class TriangleTest
    {
        [Fact]
        public void Test1()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.isRectangular());

        }
        [Fact]
        public void Test2()
        {
            Triangle triangle = new Triangle(2, 2, 2);
            Assert.False(triangle.isRectangular());
        }
        [Fact]
        public void Test3()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.Equal(triangle.GetArea(),6);

        }
        [Fact]
        public void Test4()
        {
            Triangle triangle = new Triangle(2, 2, 2);
            Assert.Equal(triangle.GetArea(), Math.Sqrt(3));

        }
        [Fact]
        public void Test5()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.Equal(triangle.GetPerimeter(), 12);

        }
        [Fact]
        public void Test6()
        {
            Triangle triangle = new Triangle(2, 2, 2);
            Assert.Equal(triangle.GetPerimeter(), 6);

        }
    }
}