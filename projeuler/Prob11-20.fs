namespace Euler
open Library

// What is the sum of the digits of the number 2^1000?
module prob16 = 
    let result = (2I ** 1000).ToString().ToCharArray() |> maptoIntAndSum

// Find the sum of the digits in the number 100!
module prob20 = 
    let fact100 = factorial 100I
    let chararray = fact100.ToString().ToCharArray()
    let result = maptoIntAndSum chararray
