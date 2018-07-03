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

