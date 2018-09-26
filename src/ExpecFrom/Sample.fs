module Tests

open Expecto
open System


let funA a = (a: string) = null || a.Length = 0
// let funB a = if (a: string) = null || 0u >= uint32 a.Length then true else false
let funB a = String.IsNullOrEmpty a

Console.WriteLine(funA null);
Console.WriteLine(funA "");
Console.WriteLine(funB null)
Console.WriteLine(funB "")

[<Tests>]
let tests =
  testList "samples" [
    test "A B speed" {
      let input = List.replicate 10000 "hsljiwhglsjlhjs"
      Expect.isFasterThan
        (fun () -> List.map funB input)
        (fun () -> List.map funA input)
        "B should faster than A"
    }
  ]

// f1 (0.1108 ± 0.0029 ms) is ~25% faster than f2 (0.1469 ± 0.0069 ms)