using Shouldly;
using TestPipelineV2.Domain.Settings;

namespace TestPipelineV2.Domain.Test.Settings;

public class DatabaseSettingsTests
{
    [Test]
    public void DatabaseConnectionTest() => new DatabaseSettings
    {
        DatabaseConnection1 = "abc"
    }.DatabaseConnection1.ShouldBe("abc");
}