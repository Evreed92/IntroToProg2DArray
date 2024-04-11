string[] crust = ["Thin", "Hand Tossed", "Deep Dish"];
string[] size = ["Small", "Medium", "Large"];
int[] toppingPrice = [1, 2, 3];
/*Base Cost Array [row, column] = [crust, size]
 *      S   M   L
 *  T   7   8   9
 *  H   8   10  12
 *  D   11  13  15
 */

int[,] baseCost = { 
    {7, 8, 9 }, 
    {8, 10, 12 }, 
    {11, 13, 15 } 
};

//Size
string? userSize;
int sizeIndex = 0;
do
{
    Console.WriteLine("Pizza Size: (S)mall, (M)edium, (L)arge");
    userSize = Console.ReadLine().ToUpper();
} while (userSize != "S" && userSize != "M" && userSize != "L");
switch (userSize)
{
    case "S":
        sizeIndex = 0;
        break;
    case "M":
        sizeIndex = 1;
        break;
    case "L":
        sizeIndex = 2;
        break;
    default:
        break;
}


//Crust
string? userCrust;
int crustIndex = 0;
do
{
    Console.WriteLine("Pizza Crust: (T)hin, (H)and Tossed, (D)eep Dish");
    userCrust = Console.ReadLine().ToUpper();
} while (userCrust != "T" && userCrust != "H" && userCrust != "D");
switch (userCrust)
{
    case "T":
        crustIndex = 0;
        break;
    case "H":
        crustIndex = 1;
        break;
    case "D":
        crustIndex = 2;
        break;
    default:
        break;
}

//Toppings
int userToppings = 0;
do
{
    Console.WriteLine("Number of Toppings from 0 - 7");
    userToppings = Convert.ToInt32(Console.ReadLine());
} while (userToppings < 0 || userToppings > 7);


//use crust and size index on baseCost to find the pizza cost.
//multiply topping price by userToppings to get topping cost.
Console.WriteLine($"Size: {size[sizeIndex]}");
Console.WriteLine($"Crust: {crust[crustIndex]}");
Console.WriteLine($"Toppings: {userToppings}");

int total = 0;
total = baseCost[crustIndex, sizeIndex] + (toppingPrice[sizeIndex] * userToppings);

Console.WriteLine($"Cost: {total}");



