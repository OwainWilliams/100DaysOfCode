# Type conversion

As long as no data loss happens when you convert from one data type to another then you get an error. 
If you are happy with the data loss you need to prefix the data with a target type e.g. 

```
int i = 1;
byte b = (byte) i;
```

This is what is called as Casting

You can't do explicit casting when you are trying to convert from one format to another which aren't compatible e.g. string to int. 

```
string s = "1";
int i = Convert.ToInt32(s);
int j = int.Parse(s);
```
 You need to use Convert or Parse
 
 
