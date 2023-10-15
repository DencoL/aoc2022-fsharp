module Day2Tests

open Common
open Day2
open Xunit

[<Fact>]
let ``Part 1 Sample input`` () =
    let input = @"A Y
B X
C Z"

    Assert.Equal(15, solvePartOne input)

[<Fact>]
let ``Part 1 My input`` () =
    let input = InputReader.readInput 2

    Assert.Equal(14375, solvePartOne input)

[<Fact>]
let ``Part 2 Sample input`` () =
    let input = @"A Y
B X
C Z"

    Assert.Equal(12, solvePartTwo input)

[<Fact>]
let ``Part 2 My input`` () =
    let input = InputReader.readInput 2

    Assert.Equal(10274, solvePartTwo input)
