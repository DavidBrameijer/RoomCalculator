Console.WriteLine("Welcome to the Room Calculator!");

Console.WriteLine("What is the length of the room? (ft)");
decimal length = decimal.Parse(Console.ReadLine());

Console.WriteLine("What is the width of the room? (ft)");
decimal width = decimal.Parse(Console.ReadLine());

decimal perimeter = (2 * length) + (2 * width);
decimal area = length * width;

Console.WriteLine($"The perimeter of the room is {perimeter} ft.");
Console.WriteLine($"The area of the room is {area} square ft.");

if (area <= 250)
{
    Console.WriteLine("This is a small room.");
}
else if (area > 250 && area < 650)
{
    Console.WriteLine("This is a medium room.");
}
else
{
    Console.WriteLine("This is a large room.");
}

Console.WriteLine("What is the height of the room?");
decimal height = decimal.Parse(Console.ReadLine());

decimal volume = area * height;
Console.WriteLine($"The volume of the room is {volume} cubic ft.");

decimal surfaceArea = 2 * ((length * width) + (width * height) + (height * length));
Console.WriteLine($"The surface area of the room is {surfaceArea} square ft.");