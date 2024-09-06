using coding_kata;

namespace coding_kata_test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Initialize_Mars_Map()
    {
        // Act
        var map = new Map();
    
        // Assert
        Assert.That(map.MapPositions, Has.Count.EqualTo(25));
    }

    [Test]
    public void Rover_Has_Default_Position()
    {
        // Act
        var rover = new Rover();

        // Assert
        Assert.That(Position.Default.x, Is.EqualTo(rover.CurrentPosition.x));
        Assert.That(Position.Default.y, Is.EqualTo(rover.CurrentPosition.y));
    }
}