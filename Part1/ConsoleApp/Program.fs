// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"

    // data types
    let varSbyte = 4y
    let varByte = 6uy

    let varInt16 = 10s
    let varUint64 = 98741UL

    let varNativeint = 324n
    let varDecimal = 324m

    let varBigint = 123I
     
    let varChar = 'a'
    let varString = "abc"

    let varBool = true

    printfn "%A, %A, %A, %A" varSbyte varByte varInt16 varUint64
    printfn "%A, %A" varNativeint varDecimal
    printfn "%A, %A, %A, %A" varBigint varChar varString varBool

    let a = 10
    let b = 15
    let c = a + b

    printfn "%A, %A, %A" a b c

    let a : int32 = 10
    let b : int32 = 15
    let c : int32 = a + b

    printfn "%A, %A, %A" a b c

    let mutable d = 10
    printfn "%A" d
    d <- 15
    printfn "%A" d
    d <- 30
    printfn "%A" d

    let x = 20
    let y = 10
    let z = 5I

    // operators
    let add = x + y
    let sub = x - y
    let mul = x * y
    let div = x / y
    let modu = x % y
    let exp = z ** y

    printfn "%A, %A, %A, %A, %A, %A" add sub mul div modu exp

    let u = 20
    let p = 10

    let equ = u = p
    let dif = u <> p
    let grl = u > p
    let grr = u < p
    let gel = u >= p
    let ger = u <= p

    printfn "%A, %A, %A, %A, %A, %A" equ dif grl grr gel ger

    let i = true
    let o = false

    let band = i && o
    let bor = i || o
    let bnot = not (i && o)

    printfn "%A, %A, %A" band bor bnot

    let s = 20
    let d = 14

    let binaryAdn = s &&& d
    let binaryOr = s ||| d
    let binaryXor = s ^^^ d
    let binaryOnesComplement = ~~~ s
    let binaryLeftShift = s <<< 2
    let binaryRightShift = d >>> 2

    printfn "%A, %A, %A, %A, %A, %A" binaryAdn binaryOr binaryXor
        binaryOnesComplement binaryLeftShift binaryRightShift

    // control statements
    if s > 0 then printfn "S is larger then 0"

    if s = d then printfn "S == D"
    else printfn "S != D"

    if s = 0 then printfn "S == 0"
    elif s > 0 then printfn "S > 0"
    else printfn "S < 0"

    if s > 0 then 
        if d < 100 then printfn "S > 0 and D < 100"
        elif d > 100 then printfn "S > 0 and D > 100"
        else printfn "S > 0 and D == 100"
    else printfn "S <= 0"

    // loops
    for it = 0 to 15 do
        printf "%A " it
    
    printfn "\r\n"

    for it = 15 downto 0 do
        printf "%A " it

    printfn "\r\n"

    for ch in "abcdefg" do
        printf "%A " ch

    printfn "\r\n"

    let mutable it2 = 10
    while it2 > 0 do
        printf "%A " it2
        it2 <- it2 - 1

    printfn "\r\n"

    for it = 0 to 3 do
        for it2 = 3 downto 0 do
            printf "[%A-%A]" it it2

    printfn "\r\n"

    // functions
    let multiplyBy2 x = x * 2

    let res1 = multiplyBy2 8
    let res2 = multiplyBy2 10
    printfn "%A, %A" res1 res2

    let multiply x y = x * y

    let res3 = multiply 2 3
    let res4 = multiply 8 9
    printfn "%A, %A" res3 res4

    let rec fib n = if n < 2 then 1 else fib (n - 1) + fib (n - 2)

    let res5 = fib 4
    let res6 = fib 10
    printfn "%A, %A" res5 res6

    // composite functions
    let add5 x = x + 5
    let mul10 x = x * 10
    let sub3 x = x - 3

    let compositeFunction = add5 >> mul10 >> sub3

    let res7 = compositeFunction 10
    printfn "%A" res7

    // pipelining of functions
    let res8 = 10 |> add5 |> sub3 |> mul10
    printfn "%A" res8

    // option
    let returnsOption x = 
        if x > 0 then Some(x)
        else None

    let res9 = returnsOption 10
    let res10 = returnsOption -10
    printfn "%A, %A" res9 res10

    // tuples
    let res11 = ("Name", 2017, 3, 2)
    printfn "%A" res11

    let printTuple x =
        match x with
        | (name, year, month, day) -> printfn "Name: %A, Year: %A, Month: %A, Day %A" name year month day

    printTuple res11



    
    0 // return an integer exit code
