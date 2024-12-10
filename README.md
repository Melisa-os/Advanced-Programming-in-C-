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
