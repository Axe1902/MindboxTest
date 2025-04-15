using SquareCalculator.Core.Entities;

namespace SquareCalculator.Tests;

public class TriangleUnitTests
{
    [Fact]
    public void Triangle_RightAngled_ReturnsTrue()
    {
        var triangle = new Triangle(3, 4, 5);

        Assert.True(triangle.IsRectangular());
    }

    [Fact]
    public void Triangle_NonRightAngled_ReturnsFalse()
    {
        var triangle = new Triangle(2, 3, 4);

        Assert.False(triangle.IsRectangular());
    }
}
