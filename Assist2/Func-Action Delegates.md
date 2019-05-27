# Func Delegates

```csharp
//  <vlezni params  izlezen>
Func<int, int, int, long> volume = delegate (int w, int l, int h) 
{ return w * l * h; };

volume(2, 3, 4));
```

# Action Delegates

```csharp

Action<string> showAnonymousMsg = (msg) => { Console.WriteLine(msg); };
showAnonymousMsg("Hell from Action anonymous");
```

# Delegates

```csharp

// function:
public static void Hello(string strMessage)
{Console.WriteLine(strMessage);}

// delegate:
public delegate void HelloFuncDelegate(string Message);

// Creating delegate like class:
HelloFuncDelegate del = new HelloFuncDelegate(Hello);
del("Hello from Delegate");   prints Hello from Delegate
```
