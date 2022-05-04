Console.Title = "Vin Fletchers Shop";

Title();

Console.WriteLine("Hello welcome to my shop, I'm Vin");
Console.Write("What is your name? ");
string user = Console.ReadLine();
Console.WriteLine($"\nWelcome {user} have a look at my options for an arrow and I can make it - for the right price ");

Arrow arrow = new Arrow(ArrowHeadType.Steel, FletchingType.Plastic, 60);

ArrowHeadType arrowHead = GetArrowHead();
Console.WriteLine($"{arrowHead}");

FletchingType fletchingType = GetFletchingType();
Console.WriteLine($"{fletchingType}");

float length = GetLength();

float GetLength()
{

    float userLength;
    while(true)
    {
        Console.WriteLine("Please pick the length of your arrow - between 60 - 100cm");
        userLength = Convert.ToSingle(Console.ReadLine());
        if (userLength <= 60 && userLength >= 100)
        {
            Console.WriteLine($"{user} that value is too high please try between 60 - 100");
        }
        return userLength;
    }
}
Console.WriteLine($"{arrow.Length}");

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

//Small method intro
void Title()
{
    Console.WriteLine("^^^^ VINS ARROWS MAKER ^^^^");
    Console.WriteLine("||||                   ||||");
    Console.WriteLine("\"\"\"\"                   \"\"\"\"");
}

//Arrow class
class Arrow
{
    //values are private can't be touched
    //private ArrowHeadType _arrowHeadType;
    //private FletchingType _fletchingType;
    //private float _length;

    //constructor we will use to access the private variables
    public Arrow(ArrowHeadType arrowHeadType, FletchingType fletchingType, float length)
    {

        ArrowHeadType = arrowHeadType;
        FletchingType = fletchingType;
        Length = length;

    }

    //getter methods
    public ArrowHeadType ArrowHeadType { get; }
    public FletchingType FletchingType { get; }
    public float Length { get; }

    //parameterless constructor
    public Arrow() { }

    //float GetCost()
    //{
    //    float cost = 0;
    //    cost += 0.05 * Length();
    //}
}


//Enums
enum ArrowHeadType { Steel, Wood, Obsidian }
enum FletchingType { Plastic, TurkeyFeather, GooseFeather }