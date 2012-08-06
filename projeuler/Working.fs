namespace Euler
open Library

module Working = 

    let prob3 x = x*x

    // Find the sum of the digits in the number 100!
    let prob20 = 
        let fact100 = factorial 100

        fact100.ToString().ToCharArray() |> Array.sum