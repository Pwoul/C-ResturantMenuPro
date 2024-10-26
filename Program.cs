
using System;
using System.Collections.Generic;

class MenuItem
{
    public string Name { get; }
    public decimal Price { get; }
    public string Description { get; }
    public string Category { get; }
    public bool IsNew { get; }

    public MenuItem(string name, decimal price, string description, string category, bool isNew)
    {
        Name = name;
        Price = price;
        Description = description;
        Category = category;
        IsNew = isNew;
    }
}

class Menu
{
    private List<MenuItem> Items { get; }
    public DateTime LastUpdated { get; private set; }

    public Menu()
    {
        Items = new List<MenuItem>();
        LastUpdated = DateTime.Now; // Set the last updated time to now
    }

    public void AddMenuItem(MenuItem item)
    {
        Items.Add(item);
        LastUpdated = DateTime.Now; // Update the last updated time
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Current Menu (Last Updated: " + LastUpdated + "):");
        foreach (var item in Items)
        {
            Console.WriteLine($"- {item.Name} ({item.Category}): ${item.Price}");
            Console.WriteLine($"  Description: {item.Description}");
            Console.WriteLine($"  New: {(item.IsNew ? "Yes" : "No")}");
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        // Create a new menu
        Menu menu = new Menu();

        // Add menu items
        menu.AddMenuItem(new MenuItem("Chicken Shawarms", 12.99m, "Grilled and sliced chicken breast, crispy lettuce, pickles, tomatoes and creamy garlic sauce all wrapped in pita.", "Main course", true));
        menu.AddMenuItem(new MenuItem("Pita Bread", 3.49m, "Grilled bread with olive oil.", "Appitizer", false));
        menu.AddMenuItem(new MenuItem("Tripple Chocolate Mousse", 6.99m, "Layers of chocolate mousse, white chocolate, and cocoa crumbles.", "Dessert", true));

        // Display the menu
        menu.DisplayMenu();
    }
}
