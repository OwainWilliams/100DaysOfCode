## Kicking this off again - 

### Reference Types and Value types

Value Types - Structures
* Allocated on stack
* Memory allocation done automatically
* Immediately removed when out of scope

Reference types - Classes
* You need to allocate memory
* Memory allocated on heap
* Garbage collected by CLR


``` 
namespace CSharpFundamentals
{
  class Program
  {
      var a = 10;
      var b = a;
      b++;
      
      Console.WriteLine(string.Format("a: {0}, b: {1}", a, b)); // a: 10 b: 11 - Value Type
      
      
      var array1 = new int[3]{1,2,3};
      var array2 = array1;
      
      array2[0] = 0; // Reference type. Both Array 1 and Array 2 reference the same memory location, not the value.
      
      Console.WriteLine(string.Format("array[0]: {0}, array2[0]: {1}, array1[0], array2[0]); // both values are 0. 
      
      
    }
}

``` 


Note - If a class return no value, set it to void e.g. ``` public static void ```



This is an example of reference types and value types.
``` var number ``` is a value type so when Console.WriteLine is called, the value returned is 1, the reason for this is Increment destroys the value from number when exiting the method. 

``` var person ``` however, created a new location in memory and MakeOld also references this same location. The result is age of the person is increased to 30
![alt text](img/screenshot_example.png)



# Control Flow
## Conditional Statements

If / else statements

Switch / case statements

Conditional operator: a?b:c


```
IF STATEMENTS

static void Main(string[] args)
{
  int hour = 10;

  if (hour > 0 && hour <12)
  {
    Console.WriteLine("It's morning.");
  }
  else if (hour >= 12 && hour < 18)
  {
    
    Console.WriteLine("It's afternoon.");
  }
  else
  {
    Console.WriteLine("It's evening.");
  }
}


```

```
Short IF ELSE statement

static void Main(string[] args)
{
  bool isGoldCustomer = true;

  // if goldcustomer, 19.95, else 29.95
  float price = (isGoldCustomer) ? 19.95f : 29.95f;
  Console.WriteLine(price);
}

```

