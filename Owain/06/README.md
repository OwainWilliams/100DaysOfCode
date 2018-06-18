
# Non-Primitive Types
## Classes 

Object is an instance of a class. 

## Declaring classes

```
public class Person
{
   public string Name;
      public void Introduce() // Void = does not return any values
      {
         Console.WriteLine("Hi, my name is "+ Name); //Just outputs the value from string Name
      }
    }
}
```

```
public class Calculator
{
   public int Add (int a, int b)
   {
      return a+b;
   }
}
```

int = type
number = identifier

## Creating Objects

Need to allocate memory for that object, which is when we use the 'new' operator. 
e.g.

```
int number; 
var person = new Person();
person.Name = "Owain";
person.Introduce(); 

```

## Static Modifier
```
public class Calculator
{
   public static int Add (int a, int b)
   {
      return a+b;
   }
}
```

# Other stuff
* Spent the evening looking at the Umbraco Issue Track to see if there was anything I could maybe fix. Also got the latest version of the code base and got it working locally. 
* Been updaing my website with some more info about me. Working on best plan to move over the blogs from my old site. 

## Structs
Structure is similiar to classes and classes are used 99% of the time. 

```
public struct RgbColour
{
  public int Red;
  public int Green;
  public int Blue;
}
```

The difference beteeen classes and structures, minor. Structures combine related fields and methods together - use a struct if you want to define a light weight object like the above example. 

Useful for when you want to create 1000's of objects of this type (rgbColour for example) then it's more efficient to use struct. 

## Arrays
### What is an Array
A data structure to store a collection of variables of the same type. 
* Declaring Arrays
```
// Instead of doing this
int number1
int number2
int number3

// We can do this
int[] numbers = new int[3];
```


* Initialising Arrays
* Access Array Elements
```
int[] numbers = new int[3];
numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;

// OR if you know the values before hand

int[] numbers = new int[3] {1,2,3};

``` 

## Strings
* What is a String

A sequence of characters. e.g. "Hello World"

* How to create a string
```
// String literals
string firstName = "Owain";

// Or (string concatenation)
string name = firstName + " " + lastName;

// or (String format)
string name = string.Format("{0} {1}", firstName, lastName);

// or (String join)
var numbers = new int[3]{1,2,3};
string list = string.Join(",", numbers);


```
* String Elements
```
string name = "Owain";
// Get the first character in the string
char firstChar = name[0];

```
String in c# are immutable - Once you create them, you can't change them. 


* Escape characters and verbatim strings

|  Char  |    Description |
|--------|----------------|
| \n     |  New Line      |
| \t     | Tab         |
| \\\    | Backslash |
| \\' | Single Quote Mark |
| \\" | Double Quote Mark |

* Verbatim strings

```
string path = "c:\\projects\\project1\\folder1";

// Instead of all the backslashes - do this

string path = @"c:\projects\project1\folder1";


```