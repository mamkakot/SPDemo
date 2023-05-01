using System;
using System.Linq;

namespace SPDemo;

public class ETrN
{
    public ETrN(string name, DateTime deliveryDate, string senderAddress, Route route, RoutePoint routePoint)
    {
        Name = name;
        DeliveryDate = deliveryDate;
        SenderAddress = senderAddress;
        Route = route;
        RoutePoint = routePoint;
    }

    public RoutePoint RoutePoint { get; set; }
    public string Name { get; set; }
    public DateTime DeliveryDate { get; set; }

    public DateTime? RealDeliveryDate { get; set; }
    public string SenderAddress { get; set; }
    public Route Route { get; set; }

    public int ContainerCount
    {
        get
        {
            var containerQuantities = Route.RoutePoints.Find(rp => rp.Gln.Base == RoutePoint.Gln?.Base).ContainerList;
            if (containerQuantities != null)
                return Route.RoutePoints != null
                    ? containerQuantities.Count
                    : 0;
            return 0;
        }
    }
}