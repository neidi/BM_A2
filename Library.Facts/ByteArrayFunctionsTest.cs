using FluentAssertions;

namespace Library.Facts;

public class ByteArrayFunctionsTest
{
    [Fact]
    public void ShouldWriteCorrectByteArray()
    {
        // Arrange
        var byteArray = new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05, 0x89, 0xff };
        var expected = "010203040589ff";

        // Act
        var actual = ByteArrayFunctions.ByteArrayToString(byteArray);

        // Assert
        actual.Should().Be(expected);
    }
    
    [Fact]
    public void ShouldGetCorrectByteArray()
    {
        // Arrange
        var hex = "010203040589ff";
        var expected = new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05, 0x89, 0xff };

        // Act
        var actual = ByteArrayFunctions.StringToByteArray(hex);

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }
    
    [Fact]
    public void ShouldThrowWhenIsNotCorrectFormat()
    {
        // Arrange
        var hex = "010203040589f";

        // Act
        Action act = () => ByteArrayFunctions.StringToByteArray(hex);

        // Assert
        act.Should().Throw<ArgumentException>();
    }
}