using NUnit.Framework;
using System.Threading.Tasks;

namespace NextGen.Application.IntegrationTests
{
    using static Testing;

    [Category("IntegrationTests")]
    public class TestBase
    {
        [SetUp]
        public async Task TestSetUp()
        {
            await ResetState();
        }
    }
}
