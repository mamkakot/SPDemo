using System;
using System.Collections.Generic;

namespace SPDemo;

public class Route
{
    public string? Name { get; set; }

    public string? AutoNumber { get; set; }
    public string? AutoType { get; set; }

    public string? DriverName { get; set; }

    public DateTime RouteTime { get; set; }
    public List<RoutePoint>? RoutePoints { get; set; }
    public List<Unit>? Units { get; set; }

    public string? InstalledSeal { get; set; }
    
    public string? Status { get; set; }

    public override string? ToString()
    {
        return Name;
    }
}