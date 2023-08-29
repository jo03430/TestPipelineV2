using Shouldly;
using TestPipelineV2.Domain.Entities;

namespace TestPipelineV2.Domain.Test.Entities;

public class BaseRequestTests
{
    public class TestCase : BaseRequest
    {
        
    }

    [Test]
    public void BaseRequestTest() => new TestCase {CorrelationId = "abc"}.CorrelationId.ShouldBe("abc");
}