# Generics

```csharp

public static bool AreEqual<T>(T Value1, T Value2)
{
return Value1.Equals(Value2);
}

bool Equal = Calculator.AreEqual<int>(10,10);
bool Equal2 = Calculator.AreEqual<string>("10","10");
```

# Generic Class

```csharp

public class Calculator <T>

public static bool AreEqual(T Value1, T Value2)
{
return Value1.Equals(Value2);
}

bool Equal = Calculator<int>.AreEqual(10,10);
bool Equal2 = Calculator<string>.AreEqual("10","10");

```
