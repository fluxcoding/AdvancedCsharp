# Lambda
## RESTRICTION OPERATOR

* ### Where
```csharp
int[] firstTen = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var even = firstTen.Where(n => n % 2 == 0);

var berlinCustomers2 = customers.Where(c => c.City == "Berlin");
// Vrakja lista od customers 
```
---
## ELEMENT OPERATOR

* ### First
```csharp
//Vrakja prv item

var findAnimal = _animals.First(a => a.Name == n);

Product product_12 = products.Where(p => p.ProductID == 12).First();


```

* ### FirstOrDefault

```csharp

// Ako ne go najde vrakja default / ako nema default vrakja null
```

* ### ElementAt
```csharp

var result = words.ElementAt(1);

```

* ### Single

```csharp
// expects one and only one element in the collection.

// throws an exception when it gets no element or more than one elements in the collection.

var cust = customers.Single(c => c.CustomerID == "ALFKI");
```
* ### SingleOrDefault
```csharp
// will return default value of a data type of generic collection 
// if there is no elements in a colection or for the specified condition.
// will throw an exception if there is more than one element

var s1 = items.SingleOrDefault(s=>s == "zero");
```

* ### LastOrDefault
```csharp
// Ako go najde go vrakja stringot , ako ne prazen default

last = items.LastOrDefault(s => s == "eleven");
```

* ### Last
```csharp
// Ako ne najde pagja

```
---
## PARTITIONING OPERATOR

* ### Take
```csharp
// Gi zima prvite elementi(3)

int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var first3Nums = numbers.Take(3);

```
* ### Skip
```csharp
// get all but the first 4 elements of the array

var allButFirst4Nums = numbers.Skip(4);
```
* ### TakeWhile
```csharp
// return elements from the beginning of the array until index

var firstSmallNumbers = numbers.TakeWhile((n, index) => n >= index);

```
* ### SkipWhile
```csharp
// SkipWhile to get the elements of the array starting from the first element
// less than its position.

var laterNumbers = numbers.SkipWhile((n, index) => n >= index);

```
---
## GENERATION OPERATORS


* ### Range
```csharp
var numbers = Enumerable.Range(10, 90);

```
* ### Repeat
```csharp
 IEnumerable<string> strings = Enumerable.Repeat("I like C#", 10);

```
---
## ORDERING OPERATOR


* ### OrderBy
```csharp
var sortedProducts = products.OrderBy(p => p.ProductName);
// sorts list by product name alphabetically

string[] words = { "cherry", "apple", "blueberry" };
var sortedWords = words.OrderBy(w => w);
// sort a list of words alphabetically

```
* ### ThenBy
```csharp
// sorts by length of their name, and then alphabetically by the name itself.
var sortedDigits = digits.OrderBy(d => d.Length).ThenBy(d => d);

```
* ### OrderByDescending
```csharp
// reversed
```
* ### ThenByDescending
```csharp
// reversed
```
* ### Reverse
```csharp
// Pravi reverse na listata
```
---
## SET OPERATORS


* ### Distinct
```csharp
//Gi brise duplikat elementite

List<int> listInts = new List<int>{2,2,3,5,5}; 
uniqueFactors = listInts.Distinct();

// vrakja 2,3,5


```
* ### Union
```csharp
//gi vrakja site broevi bez duplikati

int[] numbersA = {0,2,4,5,6,8,9};
int[] numbersB = {1,3,5,7,8};

var uniqueNumbers = numbersA.Union(numbersB);

// vrakja 0,2,4,5,6,8,9,1,3,7

```
* ### Intersect
```csharp
//gi vrakja duplikatite

int[] numbersA = {0,2,4,5,6,8,9};
int[] numbersB = {1,3,5,7,8};

var uniqueNumbers = numbersA.Intersect(numbersB);

// Vrakja 5 i 8
```
* ### Except
```csharp
// Gi vrakja brojkite sto A gi ima a gi nema B

int[] A = { 0, 2, 4, 5, 6, 8, 9 };
int[] B = { 1, 3, 5, 7, 8 };

var exceptNumbers = A.Except(B);

// vrakja 0 2 4 6 9

```
---
## PROJECTION OPERATORS


* ### Select
```csharp
var incrNumbers = numbers.Select(n => n + 1);
// produce a sequence of ints one higher than those in an existing array of ints.

var productNames = products.Select(p=>p.ProductName);
// gi vrakja samo iminjata na produktite 

// This sample uses select to produce a sequence of the uppercase and lowercase 
//versions of each word in the original array.
string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

var upperLowerWords = words.Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() });
    foreach (var ul in upperLowerWords) {
    Console.WriteLine("Uppercase: {0}, Lowercaser: {1} ", ul.Upper, ul.Lower);
}

//This sample uses select to produce a sequence containing some properties of Products,including UnitPrice which is renamed to Price in the resulting type.

var productInfos = products.Select(p =>
new { p.ProductName, p.CategoryID, Price = p.UnitPrice });

```
* ### SelectMany
```csharp
//selektirame povekje nizi

var pairs2 = A.SelectMany(a => B, (a, b) => new { a, b })
.Where(pair => pair.a < pair.b).Select(pair => pair);

```

---
## GROUPING OPERATORS


* ### GroupBy
```csharp
// group by to partition a list of words by their first letter.
string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };
var wordGroups = words.GroupBy(g => g[0]).Select(w => new { FirstLetter = w.Key, Words = w });

foreach (var g in wordGroups) {
                Console.Write("Words with first letter {0}:", g.FirstLetter);
                foreach (var word in g.Words) {
                    Console.Write(word + " ");
                }
                Console.WriteLine();
            }

```
![Group By](https://i.gyazo.com/f0c244947f3fd289bb474b8ef4cb1b40.png)

---
## AGGREGATE OPERATORS


* ### Count
```csharp
// The Count extension method provides a way to get the number of elements in an IEnumerable collection by enumerating those elements. This is an inefficient way to get the element count of collections that store a cached field. 

```
* ### Sum
```csharp
int[] array1 = { 1, 3, 5, 7 };
int sum1 = array1.Sum();
Console.WriteLine(sum1);
// 16

```
* ### Min
```csharp


```
* ### Max
```csharp


```
* ### Average
```csharp


```
---
## QUANTIFIERS 
(vrakjaat boolean)


* ### Any
```csharp
//(Any to determine if any of the words in the array contain the substring 'ei'.)
bool iAfterE = words.Any(w => w.Contains("ei"));

```
* ### All
```csharp
//(All to determine whether an array contains only odd numbers.)

int[] numbers = { 1, 11, 3, 19, 41, 65, 19 };
bool onlyOdd = numbers.All(n => n % 2 == 1);

```

---
## MISCELLANEOUS OPERATORS


* ### Concat
```csharp
// to create one sequence that contains each array's values, one after the other.

int[] numsA = { 0, 2, 4, 5, 6, 8, 9 };
int[] numsB = { 1, 3, 5, 7, 8 };

var allNumbers = numsA.Concat(numsB);

```
* ### EqualAll
```csharp
var wordsA = new string[] { "cherry", "apple", "blueberry" };
var wordsB = new string[] { "cherry", "apple", "blueberry" };
bool match = wordsA.SequenceEqual(wordsB);

// vrakja true

```
---
## JOIN OPERATORS


* ### Join
```csharp
var q2 = customers.Join(orders,
                c => c.CustomerID,
                o => o.CustomerID,
                (c, o) => new { Customer = c.CustomerID, City = o.ShipCity, Freight = o.Freight, Employee = o.EmployeeID })
                .Where(c => c.Customer == "VINET");
            foreach (var item in q2) {
                Console.WriteLine("Customer {0}, City {1}, Freight {2}", item.Customer, item.City, item.Freight);
            }
```
![Join](https://i.gyazo.com/b4babb1044e71bd056d24d20138dcc7a.png)
