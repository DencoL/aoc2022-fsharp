module Day6Tests

open Common
open Xunit
open Day6

[<Theory>]
[<InlineData("mjqjpqmgbljsphdztnvjfqwrcgsmlb", "7")>]
[<InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz", "5")>]
[<InlineData("nppdvjthqldpwncqszvftbrmjlhg", "6")>]
[<InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", "10")>]
[<InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", "11")>]
let ``Part 1 Sample input`` (input, expectedResult) =
    Assert.Equal(expectedResult, solvePartOne input)

[<Fact>]
let ``Part 1 My input`` () =
    let input = InputReader.readInput 6

    Assert.Equal(1723, solvePartOne input)

[<Theory>]
[<InlineData("mjqjpqmgbljsphdztnvjfqwrcgsmlb", 19)>]
[<InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz", 23)>]
[<InlineData("nppdvjthqldpwncqszvftbrmjlhg", 23)>]
[<InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 29)>]
[<InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 26)>]
let ``Part 2 Sample input`` (input, expectedResult) =
    Assert.Equal(expectedResult, solvePartTwo input)

[<Fact>]
let ``Part 2 My input`` () =
    let input = InputReader.readInput 6

    Assert.Equal(3708, solvePartTwo input)
