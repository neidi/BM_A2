using EncryptionDecryption;

namespace Library.Facts;

using FluentAssertions;

public class AsymmetricEncryptorTests
{
    private const string Plaintext = "Don't tell anybody: I'm encrypted";
    private readonly AsymmetricEncryptor testee;

    public AsymmetricEncryptorTests()
    {
        this.testee = new AsymmetricEncryptor();
    }
    
    [Fact]
    private void WhenEncryptedAndDecryptedShouldBeTheSameString()
    {
        var encrypted = this.testee.Encrypt(Plaintext);
        encrypted.Should().NotBe(Plaintext, "cleartext needs to be encrypted");

        var plaintext = this.testee.Decrypt(encrypted);
        plaintext.Should().Be(Plaintext);
    }
}