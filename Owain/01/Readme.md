Learning from Udemy tutorial

## Variable
A name given to a storage location in memory

For local varibles, use camelCase naming

int number;

type - identifier
int number;

## Constant 
an immutable value

For constants const int MaxZoom = 5; use PascalCase

Data
const float Pi = 3.14f;

To declare a constant you use the keyword const.
Then you set the type (float) and the identifier Pi and initialise it with a value 3.14f

## Identifiers
Cannot start with a number e.g. 1route

Cannot include white space e.g. first name

Cannot be a reserved keyword e.g. int

Always use meaningful names e.g. not fn for firstName


## Naming Conventions
camelCase - integars

PascalCase - constants

strHungarianNotation - not used in c#


## Real numbers
The default datatype for real numbers is double. If you want to use decimal or float you need to declare it.

float number = 1.2f;

decimal number = 1.2m;

# Overflowing
In C# there is no default overflow checking. To check for overflowing you should use checked.

`checked
{
byte number = 255;
number = number + 1;
}`

This will thrown an exception. - Overflowing is unlikely to happen in the real world a you can prgram around it. 

# Scope

Where a variable or constant has meaning and is accessible.
If you declare a varibale within a block of code e.g. { } then that variable is accessible only within this block.
If you tried to access the variable outside of the block then it's out of scope.
