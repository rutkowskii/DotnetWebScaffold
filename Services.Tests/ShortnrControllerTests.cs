using FluentAssertions;
using Xbehave;
using MongoDB.Driver;
using Ploeh.AutoFixture;
using DotnetWebScaffold.Controllers;

namespace DotnetWebScaffold.Tests
{
    public class ShortnrControllerTests : TestsBase
    {
        private Fixture _fixture;
        private SampleApiController _sut;

        public ShortnrControllerTests()
        {
            _fixture = new Fixture();
        }

        [Scenario]
        public void Should_properly_identify_real_link_when_link_has_been_inserted()
        {
            var expectedRealLink = _fixture.Create<string>();

            "given just created controller and empty db".x(() =>
            {
                PrepareEnvironment();
            });

            "the sut should be not null".x(() =>
            {
                _sut.Should().NotBeNull();
            });
        }
        
        private void PrepareEnvironment()
        {
            _sut = ResolveInstance<SampleApiController>();
        }
    }
}
