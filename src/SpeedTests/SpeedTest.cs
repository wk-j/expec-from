using Xunit;
using System.Linq;
using Expecto.CSharp;
using Xunit.Abstractions;

namespace SpeedTests {

    public class Lib {
        public static int ForSum(int x) {
            var sum = 0;
            for (int i = 0; i < x; i++) {
                sum += i;
            }
            return sum;
        }
        public static int LinqSum(int x) =>
            Enumerable.Range(0, x).Sum();
    }

    public class SpeedTest {
        private readonly ITestOutputHelper output;

        public SpeedTest(ITestOutputHelper output) {
            this.output = output;
        }

        [Fact]
        public void TestSum() {
            var result =
                Function.IsFasterThan(
                    () => Lib.ForSum(100),
                    () => Lib.LinqSum(100),
                    "For is fater than LINQ",
                    out var message
                );
            Assert.True(result, message);
            output.WriteLine(message);
        }
    }
}
