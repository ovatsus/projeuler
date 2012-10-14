// Learn more about F# at http://fsharp.net
namespace Euler
open Library

// Add all the natural numbers below one thousand that are multiples of 3 or 5.
module Prob1 = 
    let all = [1 .. 999]
    let filtered = all |> List.filter (fun x -> x%3=0 || x%5=0)
    let result = List.sum filtered

// By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
module Prob2 = 
    let fibSeq = Seq.unfold (fun (a,b) -> Some( a+b, (b, a+b) ) ) (0,1)
    let fibList = fibSeq |> Seq.takeWhile (fun x -> x<4000000 ) |> Seq.toList
    let filterList = List.filter (fun x -> x%2=0) fibList
    let result = List.sum filterList

// What is the difference between the sum of the squares and the square of the sums?
module Prob6 = 
    let numbers = [1..100]   
    let square x = x*x 
    let result = (numbers |> List.sum |> square)-(numbers |> List.map square |> List.sum)

// Calculate the sum of all the primes below two million.
module Prob10 = 
    let result = sieve 2000000L |> List.sum
