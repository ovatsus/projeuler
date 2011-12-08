namespace Euler

module Prob6 = 

    let numbers = [1..100]   
    let square x = x*x 
    let total = (numbers |> List.sum |> square)-(numbers |> List.map square |> List.sum)
