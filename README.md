# C-Example
Demo repo to explain C#

```c#

using App.Potions;

public Main() {
    Health potion = new Health(25);

    Console.WriteLine(potion.Name); // -> "Health"
    Console.WriteLine(potion.Description); // -> "This is a 25hp health potion."
    Console.WriteLine(potion.Value); // -> "25"
    Console.WriteLine(potion.Use()); // -> void
}

```