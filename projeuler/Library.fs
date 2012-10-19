namespace Euler
open System.Numerics

module Library = 
    // newton's method sqrt
    let rec square_root x guess =
        let next_guess = guess - (guess * guess - x)/(2L * guess)
        if (abs (guess - next_guess) < 1L) then 
            next_guess
        else 
            square_root x next_guess

    // prime number sieve
    let sieve max = 
        let numbers = [2L..max]
        let sqrt_max = square_root max 10L
        let rec findprimes (primeslist:list<int64>) primes = 
            if primeslist.Head > sqrt_max  then
                primes @ primeslist
            else
                let new_primes = primeslist.Head :: primes
                let new_primeslist = List.filter (fun x -> x % primeslist.Head <> 0L) primeslist
                findprimes new_primeslist new_primes
        findprimes numbers []
    
        
    // factorial 
    let rec factorial (x:bigint) =  
        match x with 
            | _ when x = 1I ->  1I
            | _ when x <= 0I -> 0I
            | _ -> x * factorial (x - 1I) 

    
    // greatest common divisor
    let rec gcd x y = 
      match x with 
        | _ when x > y -> gcd y (x-y)
        | _ when x < y -> gcd x (y-x)
        | _ -> x 

    // least common multiple
    let lcm x y = abs (x*y)/gcd x y 

    // factor 
    let factorization x = 
      let primeslist = sieve x

      let rec factors acc (y:int64) (z:int64) = 
        match y%z with 
          | 0L when y = z-> z::acc
          | 0L when y <> z -> factors (z::acc) (y/z) z
          | _ -> acc