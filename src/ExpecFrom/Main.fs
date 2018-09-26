module ExpecFrom
open Expecto

[<EntryPoint>]
let main argv =
    Tests.runTestsInAssembly defaultConfig argv
