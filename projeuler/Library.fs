namespace Euler

    module Library = 
        
        let sieve (max:float) = 
            let numbers = [2.0..max]
            let primes: list<float> = []

            let rec findprimes (primeslist:list<float>) = 
                if primeslist.Head > sqrt max then
                    let primes = primes :: primeslist
                    primes
                else
                    let primes  = primes :: primeslist.Head
                    let primeslist = List.filter (fun x -> x%primeslist.Head = 0)
                    findprimes(primeslist)
                
            findprimes (numbers)
