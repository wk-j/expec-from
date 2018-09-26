using System;
using System.Linq;
using Expecto;
using Expecto.CSharp;

namespace ExpecFrom.CSharp {
    public class SpeedTests {
        [Tests]
        public static Expecto.Test abSpeed =
            Runner.TestList("Tests", new Expecto.Test[] {
                Runner.TestCase("Speed", () => {

                    var input = Enumerable.Range(0, 100_000).Select(x => x.ToString("D10"));

                    var r = Function.IsFasterThan(
                        () =>  input.Select(B).ToList(),
                        () =>  input.Select(A).ToList(),
                        "A should faster than B",
                        out var ignore
                    );
                    if (!r) throw  new Exception("not faster");
                })
        });

        static bool A(string value) => value == null || value.Length == 0;
        static bool B(string value) => (value == null || 0u >= (uint)value.Length) ? true : false;
    }
}
