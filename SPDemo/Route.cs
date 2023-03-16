using System.Collections.Generic;

namespace SPDemo;

public class Route
{
    public string Name { get; set; }
    public List<RoutePoint> RoutePoints { get; set; }
    public List<Unit> Units { get; set; }
    
    public string InstalledSeal { get; set; }

    public override string ToString()
    {
        return Name;
    }
}