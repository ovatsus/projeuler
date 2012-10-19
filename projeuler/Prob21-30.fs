// Learn more about F# at http://fsharp.net
namespace Euler
open Library

// Add all the natural numbers below one thousand that are multiples of 3 or 5.
module Prob25 = 
  let fibonnacci = Seq.unfold(fun (a,b) -> Some( a+b, (b, a+b) )) (0I,1I)
  let result = (Seq.findIndex(fun elem -> elem.ToString().ToCharArray().Length >= 1000) fibonnacci) + 2
