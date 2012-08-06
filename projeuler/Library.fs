namespace Euler

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
    let rec factorial x = 
        match x with 
            | 1 ->  1
            | _ when x <= 0 -> 0
            | _ -> x * factorial (x - 1) 

