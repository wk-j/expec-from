using Expecto.CSharp;

namespace ExpecFrom.CSharp {

    class Program {
        static void Main(string[] args) {
            var config = Runner.DefaultConfig;
            Runner.RunTestsInAssembly(config, args);
        }
    }
}
