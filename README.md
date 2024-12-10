# Advanced-Programming-in-C-
**Task Description for LINQ :**  

Write a program in C# that works with a collection of countries and their populations. The program should:  

1. **Define a class** named `Country` with the following properties:  
   - `Name` (string): The name of the country.  
   - `Population` (int): The population of the country.  
2. **Create a collection** of `Country` objects, where each object represents a country with its respective population.  
3. **Sort** the collection of countries in descending order based on their population.  
4. **Display** the sorted list of countries in the format:  
   - `Country: [Country Name] Population: [Population]`  
   - The population should be displayed with thousand separators for better readability.  

**Input Data:**  
A predefined collection of countries and their populations:  
- Afghanistan: 3,465,032  
- Austria: 8,857,960  
- Brazil: 210,147,125  
- Denmark: 5,789,957  
- Russia: 144,526,636  
- China: 1,403,500,365  
- Turkey: 80,810,525  
- Serbia: 7,001,444  
- Iraq: 37,202,572  
- San Marino: 3,334  

**Output Data:**  
A sorted list of countries displayed in descending order of population, e.g.:  
```
Country: China Population: 1,403,500,365  
Country: Brazil Population: 210,147,125  
...  
Country: San Marino Population: 3,334  
```

**Task Description for PovrsinaKruga:**  

Write a program in C# that calculates the area of a circle using a lambda function. The program should:  

1. **Define a lambda function** (`Func<double, string>`) named `povrsinaKruga`, which:  
   - Takes a single parameter, `r` (the radius of the circle).  
   - Calculates the area of the circle using the formula:  
     \[
     \text{Area} = \pi \times r^2
     \]  
   - Returns a formatted string containing the calculated area.  

2. **Initialize** the radius (`poluprecnik`) with a predefined value.  
3. **Invoke** the lambda function with the given radius to calculate the area.  
4. **Display** the result in a user-friendly message.  

**Input Data:**  
- Radius (`poluprecnik`): 5.0  

**Output Data:**  
A message displaying the area of the circle, e.g.:  
`The area of the circle is 78.54.`




**Task Description for refleksija:**  

Create a project in C# that demonstrates the use of reflection to inspect and interact with a class dynamically. The project should consist of two interrelated files/programs:  

---

### **File 1: Core Reflection Program**  

1. **Create a class** named `Country` with:  
   - Properties:  
     - `Name` (string): The name of the country.  
     - `Population` (int): The population of the country.  
   - A constructor that initializes the `Name` and `Population`.  
   - A method `GetCountryInfo` that returns a formatted string with the country's name and population.  

2. **Use reflection** to:  
   - Get the `ConstructorInfo` of the `Country` class.  
   - Dynamically create an instance of the `Country` class with predefined values (`"CountryName"` and `1,000,000`).  
   - Invoke the `GetCountryInfo` method on the created instance.  

3. **Output** the result of the `GetCountryInfo` method to the console.  

---

### **File 2: Advanced Reflection Features**  

1. **Inspect a class** using a method `IspitajOsobineKlase` that performs the following:  
   - Prints the name of the class.  
   - Prints the namespace of the class.  
   - Prints the full name of the class.  
   - Prints the base type of the class.  
   - Lists all interfaces implemented by the class.  
   - Identifies if the class is abstract, sealed, or generic.  

2. **Test the inspection** by calling `IspitajOsobineKlase` on a standard .NET class (e.g., `string`).  

3. **Reuse the Country class** from the first file:  
   - Dynamically create a `Country` instance using reflection with the same values as in File 1.  
   - Invoke the `GetCountryInfo` method and display its result.  

---

### **Input Data:**  
- For `Country` creation:  
  - Name: `"CountryName"`  
  - Population: `1,000,000`  

---

### **Output Data:**  
The combined programs should produce the following:  

1. **File 1 Output:**  
```
Country CountryName has the population of 1000000.
```  

2. **File 2 Output:**  
```
Class Name: String  
Namespace: System  
Full Name: System.String  
Base Type: System.Object  
Implemented Interfaces:  
  - System.IComparable  
  - System.ICloneable  
  ... (other interfaces)  
Abstract Class: False  
Sealed Class: True  
Generic Class: False  

Country CountryName has the population of 1000000.
```  

**Note:** Replace placeholders like `{type.Name}` in the second file with appropriate string interpolation to produce the expected output.
