open System

let main() =

  let rec sum_recursive (xi:float) (h:float) f (N:float) (iter:float) =
    if iter = N then
      xi
    else
      let xi_1 = xi + h*f(h*iter)
      sum_recursive xi_1 h f N (iter+1.0)

  let f x : float = 
      System.Math.Sin(x)
  
  let trapezoidal (a:float) (b:float) f (N:float) =
      let h = (b - a)/N
      let left_side = h/2.0*(f(a)+f(b))
      left_side + sum_recursive 0.0 h f N 0.0
  
  let fromA = 0.0
  let toB = System.Math.PI
  let counter = 100.0
  let result = trapezoidal fromA toB f counter
  Console.Write("Result = ")
  Console.Write(result)
main()
