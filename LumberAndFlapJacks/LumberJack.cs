namespace LumberAndFlapJacks;

/// <summary>
/// Represents a lumberjack eating flapjacks
/// </summary>
/// <param name="name"></param>
class LumberJack(string name)
{
    public string? Name { get { return name; } }
    private Stack<FlapJack> flapJackStack = new Stack<FlapJack>();

    /// <summary>
    /// Takes a flapjack and adds it to the lumberjack's stack.
    /// </summary>
    /// <param name="flapJack">The flapjack to take.</param>
    public void TakeFlapJack(FlapJack flapJack)
    {
        flapJackStack.Push(flapJack);
    }

    /// <summary>
    /// Eats a flapjack in the lumberjacks stack
    /// </summary>
    public void EatFlapJacks()
    {
        Console.WriteLine($"\n{Name} is eating FlapJacks");
        
        while( flapJackStack.Count > 0 )
        {
            Console.WriteLine($"{Name} ate a {flapJackStack.Pop().ToString().ToLower()} FlapJack");
        }
    }
}
