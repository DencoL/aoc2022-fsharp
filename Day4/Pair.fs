module Pair

type Pair(startValue: int, endValue: int) =
    struct
        member private this._start = startValue
        member private this._end = endValue

        new(input: string) =
            let pairInts = (input.Split "-" |> Array.map (fun pair -> pair |> int))

            Pair(pairInts[0], pairInts[1])

        member this.IsInsidePair (otherPair : Pair) =
            this._start >= otherPair._start && this._end <= otherPair._end

        member this.OverlapsWithPair (otherPair : Pair) =
            this._end >= otherPair._start && this._start <= otherPair._end
    end
