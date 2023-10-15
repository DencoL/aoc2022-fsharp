module Day1

open System

let private collectCalories (input: string) =
    input.Split("\n\n")
    |> Array.map (fun caloriesGroup ->
        caloriesGroup.Split("\n", StringSplitOptions.RemoveEmptyEntries)
        |> Array.map (fun calorie -> calorie |> int)
        |> Array.sum)

let solvePartOne input = collectCalories input |> Array.max

let solvePartTwo input =
    collectCalories input |> Array.sortDescending |> Array.take 3 |> Array.sum