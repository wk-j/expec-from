using System;
using Expecto.CSharp;
using Xunit;
using System.Linq;

namespace ExpecFrom.Unit {
    public class UnitTest1 {

        string Go1(int x) {
            return Enumerable.Range(0, x).Sum().ToString("D10");
        }

        string Go2(int x) {
            var sum = 0;
            for (int i = 0; i < x; i++) {
                sum += i;
            }
            return sum.ToString("D10");
        }

        [Fact]
        public void Test1() {

            var result =
                Function.IsFasterThan(
                    () => Go2(100),
                    () => Go1(100),
                    "Go1 is fater",
                    out string statsMessage
                );
            Assert.True(result, statsMessage);
        }
    }
}
