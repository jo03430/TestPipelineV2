using Shouldly;
using TestPipelineV2.Domain.Settings;

namespace TestPipelineV2.Domain.Test.Settings;

public class BasicAuthenticationSettingsTests
{
    [Test]
    public void BasicAuthenticationSettingsTest()
    {
        var settings = new BasicAuthenticationSettings
        {
            Token = "abc",
            HashType = "def"
        };
        
        settings.Token.ShouldBe("abc");
        settings.HashType.ShouldBe("def");
    }
}