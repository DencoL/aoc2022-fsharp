namespace Common

open System
open System.IO

module InputReader =
    let readInput (dayNumber: int) =
        File.ReadAllText $"day{dayNumber}.txt"

module Helpers =
    let split (input: string) (splitOn: string) =
        input.Split(splitOn, StringSplitOptions.RemoveEmptyEntries)