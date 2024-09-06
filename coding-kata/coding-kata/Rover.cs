namespace coding_kata;

public class Rover
{
    public Rover()
    {
        CurrentPosition = Position.Default;
    }

    public Position CurrentPosition { get; set; }
    
    public static Rover Create()
    {
        return new Rover();
    }
}