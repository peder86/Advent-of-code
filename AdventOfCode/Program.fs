open Expecto

// https://github.com/haf/expecto

[<Tests>]
let tests =
  testCase "My test" <| fun () ->
    Expect.equal 2 (1 + 1) "Should be equal"

[<EntryPoint>]
let main args =
  runTestsInAssembly defaultConfig args

