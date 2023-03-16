﻿using System;
using System.Collections.Generic;

namespace SPDemo;

public class Unit
{
    public string Name { get; set; }
    public List<Unit>? Units { get; set; }

    public List<ContainerQuantity>? ContainerList { get; set; }

    public override string ToString()
    {
        return Name;
    }
}