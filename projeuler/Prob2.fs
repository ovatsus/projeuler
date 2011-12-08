namespace Euler

module Prob2 = 
    let fibSeq = Seq.unfold (fun (a,b) -> Some( a+b, (b, a+b) ) ) (0,1)
    let fibList = fibSeq |> Seq.takeWhile (fun x -> x<4000000 ) |> Seq.toList
    let filterList = List.filter (fun x -> x%2=0) fibList
    let fibSum = List.sum filterList
