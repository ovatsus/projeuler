// Learn more about F# at http://fsharp.net
namespace Euler
open Library

// What is the first term in the Fibonacci sequence to contain 1000 digits?
module Prob25 = 
  let fibonnacci = Seq.unfold(fun (a,b) -> Some( a+b, (b, a+b) )) (0I,1I)
  let result = (Seq.findIndex(fun elem -> elem.ToString().ToCharArray().Length >= 1000) fibonnacci) + 2
