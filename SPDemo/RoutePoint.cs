using System.Collections.Generic;

namespace SPDemo;

public class RoutePoint
{
    public string? Name { get; set; }
    public Gln? Gln { get; set; }
    
    public List<ContainerQuantity>? ContainerList { get; set; }
    
    public override string? ToString()
    {
        return Name;
    }
}