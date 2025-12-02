Console.Write("Number of small carpets : ");
int numCarpetsSmall = Convert.ToInt32(Console.ReadLine());
Console.Write("Number of large carpets : ");
int numCarpetsLarge = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Price per small room: $25");
Console.WriteLine("Price per large room: $35");
decimal totalCost = (numCarpetsSmall * 25) + (numCarpetsLarge * 35);
decimal tax = totalCost * 0.06m;
Console.WriteLine($" Cost : {totalCost:C}");
Console.WriteLine($" Tax : {tax:C}");
Console.WriteLine(" =========================================================");

Console.WriteLine($" Total estimate: {totalCost + tax:C}");
Console.WriteLine("This estimate is valid for 30 days");





