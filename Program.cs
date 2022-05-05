Console.Title = "Vin Fletchers Shop";

Title();

Console.WriteLine("Hello welcome to my shop, I'm Vin");
Console.Write("What is your name? ");
string user = Console.ReadLine();
Console.WriteLine($"\nWelcome {user} have a look at my options for an arrow and I can make it - for the right price ");

Arrow arrow = new Arrow(ArrowHeadType.Steel, FletchingType.Plastic, 60);

ArrowHeadType arrowHead = GetArrowHead();
Console.WriteLine($"\n{arrowHead}");

FletchingType fletchingType = GetFletchingType();
Console.WriteLine($"\n{fletchingType}");

float length = GetLength();
Console.WriteLine($"{user} you have picked {length} that will be {LengthCost()} gold");

Console.WriteLine($"\n{user} you have chosen, {arrowHead} arrow head with a {fletchingType} fletch with a length of {length}");
Console.Write($"That will come to {totalCost()}");


float totalCost()
{
    float cost = 0;
    if(arrowHead == ArrowHeadType.Steel) { cost += 10; }
    else if (arrowHead == ArrowHeadType.Wood) { cost += 3; }
    else { cost += 5; }

    if (fletchingType == FletchingType.Plastic) { cost += 10; }
    else if (fletchingType == FletchingType.Plastic) { cost += 3; } else { cost += 5; }

    cost += length;

    return cost;
}

Console.WriteLine("stop");
Console.ReadKey();
//method to get userlength return
float GetLength()
{
    float userLength = 0;
    Console.WriteLine($"{user} please enter a length between 60 - 100");
    while (userLength < 60 || userLength > 100)
    {
        userLength = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine($"{user} that is too big ");
    }
    return userLength;
}

FletchingType GetFletchingType()
{
    while(true)
    {
        Console.WriteLine("\n 1 - Plastic \n 2 - Turkey Feathers \n 3 - Goose Feathers");
        int option = Convert.ToInt32(Console.ReadLine());
        if (option >= 1 && option <= 3)
        {
            return option switch
            {
                1 => FletchingType.Plastic,
                2 => FletchingType.TurkeyFeather,
                3 => FletchingType.GooseFeather,
                _ => FletchingType.Plastic
            };
        }
    }

}


ArrowHeadType GetArrowHead()
{
    while (true)
    {
        Console.WriteLine("\n 1 - Steel \n 2 - Wood \n 3 - Obsidian");
        int option = Convert.ToInt32(Console.ReadLine());

        if (option >= 1 && option <= 3)
        {
            return option switch
            {
                1 => ArrowHeadType.Steel,
                2 => ArrowHeadType.Wood,
                3 => ArrowHeadType.Obsidian,
                _ => ArrowHeadType.Steel
            };
        }

    }
}

//method Title that runs at the start
void Title()
{
    Console.WriteLine("^^^^ VINS ARROWS MAKER ^^^^");
    Console.WriteLine("||||                   ||||");
    Console.WriteLine("\"\"\"\"                   \"\"\"\"");
}

float LengthCost()
{
    float cost = 0;
    cost = 0.05f * length;
    return cost;
}

//Arrow class
class Arrow
{
    //values are private can't be touched
    //private ArrowHeadType _arrowHeadType;
    //private FletchingType _fletchingType;
    //private float _length;

    public static ArrowHeadType _arrowHeadType;
    public static FletchingType _fletchingType;
    static float _length;


    //constructor we will use to access the private variables
    public Arrow(ArrowHeadType arrowHeadType, FletchingType fletchingType, float length)
    {

        _arrowHeadType = arrowHeadType;
        _fletchingType = fletchingType;
        _length = length;

    }

    //getter methods
    public ArrowHeadType ArrowHeadType { get; set; }
    public FletchingType FletchingType { get; set; }
    public float Length { get; set; }

    //parameterless constructor
    public Arrow() { }

}


//Enums
enum ArrowHeadType { Steel = 10, Wood = 3, Obsidian = 5 }
enum FletchingType { Plastic = 10, TurkeyFeather = 5, GooseFeather = 3 }