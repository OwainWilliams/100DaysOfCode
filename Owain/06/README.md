
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

