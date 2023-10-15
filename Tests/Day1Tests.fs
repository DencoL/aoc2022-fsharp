module Day1Tests

open Common
open Day1
open Xunit

[<Theory>]
[<InlineData("1000\n2000\n3000\n\n4000\n\n5000\n6000\n\n7000\n8000\n9000\n\n10000", 24000)>]
[<InlineData("1000\n2000\n3000\n\n4000\n\n5000\n6000\n\n7000\n8000\n9000\n\n10000\n\n50000", 50000)>]
let ``Part 1 Sample input`` (input, expectedResult) =
    Assert.Equal(expectedResult, solvePartOne input)

[<Fact>]
let ``Part 1 My input`` () =
    let input = InputReader.readInput 1

    Assert.Equal(74198, solvePartOne input)

[<Theory>]
[<InlineData("1000\n2000\n3000\n\n4000\n\n5000\n6000\n\n7000\n8000\n9000\n\n10000", 45000)>]
let ``Part 2 Sample input`` (input, expectedResult) =
    Assert.Equal(expectedResult, solvePartTwo input)

[<Fact>]
let ``Part 2 My input`` () =
    let input = InputReader.readInput 1

    Assert.Equal(209914, solvePartTwo input)
