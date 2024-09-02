namespace Library.Facts;

using FluentAssertions;

public class HasherTest
{
    private Hasher testee;

    public HasherTest()
    {
        this.testee = new Hasher();
    }
    
    [Fact]
    private void ShouldGenerateSameHashForTwoStrings()
    {
        var plaintext = "myplaintext";
        var hash1 = this.testee.Hash(plaintext);
        var hash2 = this.testee.Hash(plaintext);

        hash1.Should().Be(hash2);
        hash1.Should().NotBe(plaintext);
    }
    
    [Fact]
    public void HashShouldBeCorrect()
    {
        var plaintext = "myplaintext";
        var hash = this.testee.Hash(plaintext);
        
        hash.Should().Be("8cde7860d9453f6dc628615c0da5e981882878aefbac4d34573e95a17988d73b");
    }
}