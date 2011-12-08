// Learn more about F# at http://fsharp.net

namespace Euler

module Prob1 = 
    let all = [1 .. 999]
    let filtered = all |> List.filter (fun x -> x%3=0 || x%5=0)
    let count = List.sum filtered