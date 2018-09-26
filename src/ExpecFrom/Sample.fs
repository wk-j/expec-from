module Tests

open Expecto
open System

// let funB a = (a: string) = null ||  if 0u >= uint32 a.Length then true else false

let funA a = (a: string) = null || a.Length = 0
let funB a = String.IsNullOrEmpty a

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