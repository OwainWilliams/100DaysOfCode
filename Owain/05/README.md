# Comments
## When to use comments

To explain whys, hows, constrains, etc. Not the whats.

Keep the short and sweet - not long stories
Keep them up to date

## Quiz
Q1. What would be the value of number after this line is executed?
byte number = 1000;
A. The code cannot be compiled. 
C# compiler checks the validity of the values assigned to variables based on their type.

Q2. The type long in C# is equivalent to which type in .NET framework?
A. Int64

Q3. What would be the output of this program?

byte number = 255;
number += 2;
Console.WriteLine(number);

A. Number will overflow and the result will be 1.

Q4. 	What would be the value of number2 after this code is executed?

int number1 = 257;
byte number2 = number1;

A. Cannot be compiled.
Since there is a chance for data loss during the conversion, compiler would stop the compilation.

Q5. What would be the value z?

var x = true;
var y = false;
var z = true && false;

A. False - A logical AND between true and false results in false.

Q6. What would be the value of z?

var x = true;
var y = false;
var z = true || false;

A. True - A logical OR between true and false results in true.