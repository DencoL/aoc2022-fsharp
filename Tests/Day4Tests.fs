module Day4Tests

open Common
open Day4
open Xunit

[<Fact>]
let ``Part 1 Sample input`` () =
    let input = @"2-4,6-8
2-3,4-5
5-7,7-9
2-8,3-7
6-6,4-6
2-6,4-8"

    Assert.Equal(2, solvePartOne input)

[<Fact>]
let ``Part 1 My input`` () =
    let input = InputReader.readInput 4

    Assert.Equal(485, solvePartOne input)

[<Fact>]
let ``Part 2 Sample input`` () =
    let input = @"2-4,6-8
2-3,4-5
5-7,7-9
2-8,3-7
6-6,4-6
2-6,4-8"

    Assert.Equal(4, solvePartTwo input)

[<Fact>]
let ``Part 2 My input`` () =
    let input = InputReader.readInput 4

    Assert.Equal(857, solvePartTwo input)
