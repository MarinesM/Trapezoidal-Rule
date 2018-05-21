open System

let main() =

  //Function to integrate
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


open System

let main() =

  let f x = 
      System.Math.Sin(x)

  let rec sum (f:float -> float) (a:float) (b:float) (N:int) (iter:int) :float =
      let h = (b - a)/N
      let xi1 = a + h
      let suma = h*f(xi1)
      if (iter < N) then
          sum f a b N iter+1
      printfn "\nIterations: %d | root value: %f" iter suma
  
  let trapezoidal a b (N: int) =
      let h = (b - a)/N
      let first = h/2.0*(f(a)+f(b))
      let suma = sum f a b N 0
      let result = first + suma
      result
  
  let fromA = 0.0
  let toB = System.Math.PI
  let counter = 100.0
  let result = trapezoidal fromA toB counter
  Console.Write("Result = ")
  Console.Write(result)
main()
