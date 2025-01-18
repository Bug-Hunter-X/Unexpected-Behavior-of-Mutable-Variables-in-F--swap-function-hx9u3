let swap x y =
    (y, x)

let a = 30
let b = 40
let (a, b) = swap a b
printf "%d %d" a b // This will print 40 30