open System

let main() =

  let f x = 
      System.Math.Sin(x)
  
  let trapezoidal a b N =
      let mutable xi = a
      let h = (b - a)/N
      let mutable suma = h/2.0*(f(a)+f(b))
      for i in 1 .. System.Convert.ToInt32(N) do
          let mutable xi1 = xi + h
          suma <- suma + h*f(xi1)
          xi <- xi1
      suma
  
  let fromA = 0.0
  let toB = System.Math.PI
  let counter = 100.0
  let result = trapezoidal fromA toB counter
  Console.Write("Result = ")
  Console.Write(result)

main()