<h1> Trapezoid Rule in F# </h1>

Numerical is approximate; analytical is exact.

A numerical method is a tool used to find a numerical solution to a problem which can be difficult to solve analitically.
Mostly done by computers, this approach is a complete set of instructions that are executed in order to find a solution. With this being said,
the Trapezoidal Rule is a numerical method used to find definite integrals. The most common application for this method is to find the 
area under a function in a given set of intervals. Finding this area is tipically done using Riemann sums, but this method proves to be more exact because it uses trapezoids instead of rectangles.


![Trapezoidal Rule](https://raw.githubusercontent.com/MarinesM/Trapezoidal-Rule/master/Left.PNG)
-        Reimann sum
![Trapezoidal Rule](https://raw.githubusercontent.com/MarinesM/Trapezoidal-Rule/master/Trapezoid.PNG)
-        Trapezoidal Rule


In this case, I implemented this numerical method using F# which is a functional programming language. First, I chose the function to integrate; in this case sin(x):

`let f x = System.Math.Sin(x)`
      
The algorithm has to receive the intervals (a,b) through which it will find the area and a number (N) of trapezoids to form.
With these parameters, it can now calculate the length of each trapezoid:

`let h = (b - a)/N`

![Trapezoidal Rule](https://upload.wikimedia.org/wikipedia/commons/7/7e/Trapezium2.gif)
By <a href="https://en.wikipedia.org/wiki/User:Mkwadee" class="extiw" title="wikipedia:User:Mkwadee">Mkwadee</a> at <a href="https://en.wikipedia.org/wiki/" class="extiw" title="wikipedia:">English Wikipedia</a>, <a href="https://creativecommons.org/licenses/by-sa/3.0" title="Creative Commons Attribution-Share Alike 3.0">CC BY-SA 3.0</a>, <a href="https://commons.wikimedia.org/w/index.php?curid=54729903">Link</a>



The formula for this method is the following:
![TrapezoidalFormula](https://raw.githubusercontent.com/MarinesM/Trapezoidal-Rule/master/formula.PNG)

So, the first part of the formula in F# looks like this:
`let mutable suma = h/2.0*(f(a)+f(b))`

Then, we must iterate for the second part of the formula:
    `for i in 1 .. System.Convert.ToInt32(N) do
          let mutable xi1 = xi + h
          suma <- suma + h*f(xi1)
          xi <- xi1`

This method can be used for things like: finding how much fluid is flowing through a specific area, calculating the work needed to move an object at a certain speed, or even finding the center of mass of an object.

Overall, learning to program a numerical method has enabled me to relate mathematical concepts, that are normally just seen in class; with programming, which is something I actually use in my day to day life. Furthermore, this was also my first time working with a functional programming language such as F#; which I ended up enjoying.

Here's my complete code:
https://github.com/MarinesM/Trapezoidal-Rule
Hope you find it useful!

###References
<a href="https://www.khanacademy.org/math/ap-calculus-ab/ab-accumulation-riemann-sums/ab-midpoint-trapezoid/a/understanding-the-trapezoid-rule">Understanding the trapezoidal rule</a>
<a href="https://en.wikipedia.org/wiki/Trapezoidal_rule">Trapezoidal Rule</a>
<a href="http://www.dummies.com/education/math/calculus/how-to-approximate-area-with-the-trapezoid-rule/">How to approximate area with the trapezoid rule</a>
