module Day4

open Pair

let private countPairs (input: string) comparePairsFunc =
    input.Split "\n"
    |> Array.map (fun pairsLine -> pairsLine.Split "," |> Array.map Pair)
    |> Array.map (fun pairs ->
        match comparePairsFunc pairs[0] pairs[1] with
        | true -> 1
        | false -> 0)
    |> Array.sum

let solvePartOne input =
    countPairs input (fun firstPair secondPair ->
        firstPair.IsInsidePair secondPair || secondPair.IsInsidePair firstPair)

let solvePartTwo input =
    countPairs input (fun firstPair secondPair ->
        firstPair.OverlapsWithPair secondPair || secondPair.OverlapsWithPair firstPair)
