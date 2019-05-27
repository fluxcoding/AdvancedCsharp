# Static classes


* #### Pisuvame static na site elementi. Se koristat elementi so fiksni values kako constanti koi ke bidat univerzalni
```csharp
public static class GallonsToLiters
    {
        //3.78541178
        public static double GallonToLiter(double gallon)
        {
            return gallon * 3.7854;
        }
        public static double LiterToGallon(double liter)
        {
            return liter / 3.7854;
        }}
		
double litri = 5.5;
GallonsToLiters.LiterToGallon(litri)	
```

# Extension methods

```csharp

Extension methods
//			    [ ova posocuva kon ]
//			    [ koj tip e metodot] [ ova e parametarot samo eden treba]
public static string Shorten(this string text,int length)
        {
            return text.Substring(0, length);}

string text = "Hi there, how are you?";	
Console.WriteLine(text.Shorten(8));

public static string QuiteString(this string str)
        {
            return '"' + str + '"';}
// Ne prima parametar , extension dodava na site string items 

```


# Partial classes

<p>
Koga delime klasa u poveke fajlovi
Partial methods:
Can have a method as a partial in multiple .cs files
The method must be void type and with the partial

A partial method cannot have access modifiers (public, private,…)
Ova ako delime metod so drug fajlovi
Obicnite si se normalni
</p>

