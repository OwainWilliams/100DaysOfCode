# Type conversion

As long as no data loss happens when you convert from one data type to another then you get an error. 
If you are happy with the data loss you need to prefix the data with a target type e.g. 

## Implicit type conversion
This works when you convert one type to another and the compiler can work out the conversion.
```
byte b = 1;
int i = b;
```

## Explicit type conversion
You can't do Implicit casting when you are trying to convert from one format to another which aren't compatible e.g. string to int. 
```
int i = 1;
byte b = (byte) i;
```
You need to explicitly tell the compiler what you are trying to convert. You do this by casting.

```
string s = "1";
int i = Convert.ToInt32(s);
int j = int.Parse(s);
```
 You need to use Convert or Parse
 
 ## Handles execptions
 
 ``` 
 var number = "1234";
 byte b = Convert.ToByte(number);
 Console.WriteLine(b);
 ```
 This throws an exception because number is too big to fit in to a byte.
 
  ``` 
 try
 {
    var number = "1234";
    byte b = Convert.ToByte(number);
    Console.WriteLine(b);
 }
 catch (Exception) 
 {
    Console.WriteLine("The number could not be converted to a byte.");
 }
 ```


 # Operators
 5 types of operators. 
 Arithmetic, Comparison, Assignment, Logical, Bitwise
 
 
