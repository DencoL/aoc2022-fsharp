module Day3Tests

open Common
open Xunit
open Day3

[<Fact>]
let ``Part 1 Sample input`` () =
    let input = @"vJrwpWtwJgWrhcsFMMfFFhFp
jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL
PmmdzqPrVvPwwTWBwg
wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn
ttgJtRGJQctTZtZT
CrZsJsPPZsGzwwsLwLmpwMDw";

    Assert.Equal(157, solvePartOne input)

[<Fact>]
let ``Part 1 My input`` () =
    let input = InputReader.readInput 3

    Assert.Equal(8153, solvePartOne input)

[<Fact>]
let ``Part 2 Sample input`` () =
    let input = @"vJrwpWtwJgWrhcsFMMfFFhFp
jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL
PmmdzqPrVvPwwTWBwg
wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn
ttgJtRGJQctTZtZT
CrZsJsPPZsGzwwsLwLmpwMDw";

    Assert.Equal(70, solvePartTwo input)

[<Fact>]
let ``Part 2 My input`` () =
    let input = InputReader.readInput 3

    Assert.Equal(2342, solvePartTwo input)
