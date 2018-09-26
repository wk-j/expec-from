module Tests

open Expecto

[<Tests>]
let tests =
  testList "samples" [

    test "I am (should fail)" {
      "╰〳 ಠ 益 ಠೃ 〵╯" |> Expect.equal true false
    }
  ]
