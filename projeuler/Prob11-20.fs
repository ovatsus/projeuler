namespace Euler
open Library
open System

    // Find the sum of the digits in the number 100!
module prob20 = 
    let fact100 = factorial 100I
    let chararray = fact100.ToString().ToCharArray()
    let maptoInt = Array.map(fun (x:char) -> Convert.ToInt32(x)-48) >> Array.sum
    let result = maptoInt chararray
