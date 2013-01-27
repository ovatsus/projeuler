namespace Euler
open Library
open System

module Working = 

    // factor 
    let factorization x = 
      let primeslist = sieve x

      let rec factors acc (y:int64) (z:int64) = 
        match y%z with 
          | 0L when y = z-> z::acc
          | 0L when y <> z -> factors (z::acc) (y/z) z
          | _ -> acc

    // What is the largest prime factor of the number 600851475143 ?
    let prob3 x = x*x

        
    // What is the smallest number divisible by each of the numbers 1 to 20?
    let prob5 = 
        let primes10 = sieve 10L

    // Find the sum of all numbers which are equal to the sum of the factorial of their digits. prob 34
    let max = [3I..9I] |> List.map factorial |> List.sum 

    let combos = 
      seq {
        for k in [1I..9I] do
          yield n_choose_k_repetitions 9I k
      } |> Seq.sum
      
    