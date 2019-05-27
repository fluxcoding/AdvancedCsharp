# Abstract


* #### Orginalnata klasa nemozeme da ja iskoristime, so nea samo zadavame place holderi na properties i metodi i posle so nasleduvanje gi naznacuvame (ima fiksni elementi-)
```csharp
[abstract class Animal]
-public abstract bool Feathers { get; set; }
- public abstract string Features();
// vo klasata so nasleduva abstract mu pravime - override
```
```csharp
class Dog : Animal
    {
        public override bool Feathers { get; set; }
        public override string Describe()
        {
            return base.Describe() + " This is a dog.";
        }

        public override string Features()
        {
            return "Can bark";
        }

        public override bool HasFeathers()
        {
            return false;
        } }

// can have Int a = 5;   
```

# Interface (dynamic)

* #### interface can be used to define what a class must do, but not how it will achieve it.Mozeme na kakov sakame nacin da gi dodeluvame propertinjata i metodite.Vo klasite so nasleduvaat mozeme da dodavame propertinja i metodi;

```csharp

public interface ICar
    {
        string MotorNumber { get; set; }
        void Refuel();
    }
    public class NormalCar : ICar
    {
        public string MotorNumber { get; set; }
        public NormalCar()
        {
            this.MotorNumber = this.MotorNumber + "-N"; // N - for normal cars
        }
        public NormalCar(string engineNumber)
        {
            this.MotorNumber = engineNumber + "-N";
        }
        public void Refuel()
        {
            Console.WriteLine("Refueling with petrol");
} 

```

```csharp
IDiscount 

void SetDiscount(double discount);
double GetPriceWithDiscount();

IPrice
double GetPrice();

Enum
Colors

public abstract class Item 

	public string Name { get; set; }
	public double Price { get; set; }
	public int Quantity { get; set; }
	public double Discount { get; set; }  

public class Part : Item, IPrice
    { 
        public double GetPrice()
        {
            return Price;
        } 
    }
```

