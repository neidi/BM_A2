namespace Library.Facts;

using FluentAssertions;

public class SymmetricEncryptorTests
{
    private const string Plaintext = "Don't tell anybody: I'm encrypted";
    private readonly SymmetricEncryptor testee;

    public SymmetricEncryptorTests()
    {
        this.testee = new SymmetricEncryptor();
    }

    [Fact]
    public void WhenEncryptedAndDecryptedShouldBeTheSameString()
    {
        var encrypted = this.testee.Encrypt(Plaintext);
        var plaintext = this.testee.Decrypt(encrypted);
        plaintext.Should().Be(Plaintext);
    }
    
    [Fact]
    public void EncryptedValueShouldBeCorrect()
    {
        var encrypted = this.testee.Encrypt(Plaintext);
        encrypted.Should().NotBe(Plaintext, "cleartext needs to be encrypted");
        encrypted.Should()
            .Be("6a51886ebbc442d4a3596820b0aadcdb147ce90d63ad6816c23685f1b88295501f7d3b00d0e9846af1e3f8d9af12e362");
    }
}