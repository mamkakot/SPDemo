namespace SPDemo;

public class RoutePoint
{
    public string Name { get; set; }
    public Gln Gln { get; set; }
    
    public override string ToString()
    {
        return Name;
    }
}