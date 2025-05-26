using LumberAndFlapJacks;

//All lumberjack references are in this queue
Queue<LumberJack> queue = new Queue<LumberJack>();

//The app prompts the user for the first lumberjack’s name
string? lumberJackName;
Console.WriteLine("What is their name, enter nothing to end");

while (!String.IsNullOrEmpty(lumberJackName = Console.ReadLine()))
{
    //...then asks for the number of flapjacks to give it
    Console.WriteLine("\nHow many flapjacks would they like");
    string? numberOfFlapJacks = Console.ReadLine();

    //If the user gives a valid number
    if (int.TryParse(numberOfFlapJacks, out int numberOfFlap))
    {
        LumberJack lumberJack = new LumberJack(lumberJackName);

        // ...the program calls TakeFlapjack that number of times
        for (int i = 0; i < numberOfFlap; i++)
        {
            //passing it a random Flapjack each time
            lumberJack.TakeFlapJack((FlapJack)Random.Shared.Next(0, 4));
        }

        //...and adds the Lumberjack to the Queue
        queue.Enqueue(lumberJack);
    }
    Console.WriteLine("\nEnter the name of the next lumberjack, or nothing to end: ");
}

//it uses a while loop to dequeue each Lumberjack
while(queue.Count > 0)
{
    LumberJack nextJack = queue.Dequeue();

    //calls its EatFlapjacks method to write lines to the output
    nextJack.EatFlapJacks();
}