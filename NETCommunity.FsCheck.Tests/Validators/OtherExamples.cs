using FsCheck;
using FsCheck.Xunit;
using Xunit;
using Xunit.Abstractions;

namespace NETCommunity.FsCheck.Tests.Validators
{
    public class OtherExamples
    {
        private readonly ITestOutputHelper _testOutputHelper;
        public OtherExamples(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void CapturingOutput_Example()
        {
            Prop.ForAll(Arb.Default.Bool(), i => i)
                .VerboseCheckThrowOnFailure(_testOutputHelper);
        }

        [Fact]
        public void Replay_Example()
        {
            Prop.ForAll(Arb.Default.Bool(), i => i)
                .Check(new Configuration
                {
                    Replay = Random.StdGen.NewStdGen(487723102, 296400248)
                });
        }
    }
}