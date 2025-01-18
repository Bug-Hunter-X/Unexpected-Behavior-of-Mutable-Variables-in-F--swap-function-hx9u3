let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y // this will print 20 10

// However, if you try to use this function with other variables:
let a = 30
let b = 40
swap a b // This will NOT swap a and b
printf "%d %d" a b // This will print 30 40