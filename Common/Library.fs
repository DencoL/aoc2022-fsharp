namespace Common

open System.IO

module InputReader =
    let readInput fileName =
        File.ReadAllText fileName