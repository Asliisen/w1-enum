namespace Enumkavrami;
class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine(Days.Sunday);
        Console.WriteLine((int)Days.Saturday);
        Console.WriteLine((int)Days.Sunday); 

        int tempature = 32;
        if(tempature <= (int)WheatherT.Cold)
            Console.WriteLine("Wait for tempature its still cold.");
        else if(tempature >= (int)WheatherT.Normal)
            Console.WriteLine("It's so warm today");
        else if(tempature >= (int)WheatherT.Normal && tempature < (int)WheatherT.VeryHot)
            Console.WriteLine("It's very hot today.Lets go!!");

    }

enum Days
{
    Monday, // index = 0
    Tuesday, // index = 1
    Wednesday, //index = 2
    Thursday, // index = 3
    Friday = 23,
    Saturday, // now this index = 24
    Sunday // index = 25
}
}   

enum WheatherT
{
    Cold = 5,
    Normal = 20,
    Hot = 25,
    VeryHot = 30
}