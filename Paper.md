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


In this case, I implemented this numerical method using F# which is a functional programming language. So first, we must define the function that we want to integrate; in this case sin(x):

`let f x = System.Math.Sin(x)`
      
The algorithm has to receive the intervals (a,b) through which it will find the area and a number (N) of trapezoids to form.
With these parameters, it can now calculate the length of each trapezoid:

`let h = (b - a)/N`

![Trapezoidal Rule](https://upload.wikimedia.org/wikipedia/commons/7/7e/Trapezium2.gif)
By <a href="https://en.wikipedia.org/wiki/User:Mkwadee" class="extiw" title="wikipedia:User:Mkwadee">Mkwadee</a> at <a href="https://en.wikipedia.org/wiki/" class="extiw" title="wikipedia:">English Wikipedia</a>, <a href="https://creativecommons.org/licenses/by-sa/3.0" title="Creative Commons Attribution-Share Alike 3.0">CC BY-SA 3.0</a>, <a href="https://commons.wikimedia.org/w/index.php?curid=54729903">Link</a>
