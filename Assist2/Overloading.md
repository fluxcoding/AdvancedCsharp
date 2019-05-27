# Overloading


* #### Mozeme da sobirame dva objekta so overload na + ( dolzinite na site strani )
```csharp
public static Box operator +(Box a, Box b) {
            Box c = new Box();
            c.Width = a.Width + b.Width;
            c.Height = a.Height + b.Height;
            c.Length = a.Length + b.Length;
            return c;
        }	

  //This == goes together with !=
        public static bool operator ==(Box a, Box b) {
            return (a.Width == b.Width && a.Height == b.Height && a.Length == b.Length);
        }
  //This != goes together with ==
        public static bool operator !=(Box a, Box b) {
            return (a.Width == b.Width && a.Height == b.Height && a.Length == b.Length);
        }


```