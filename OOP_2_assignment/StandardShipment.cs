using System;

public class StandardShipment : Shipment
{
    public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        : base(trackingCode, description, weight, deliveryFee, destination)
    {
    }

    public override void PrintShipment()
    {
        Console.WriteLine("Standard Shipment");
        Console.WriteLine();
        PrintCommonInfo();
        Console.WriteLine("Estimated Cost: " + EstimatedCost + " EGP");
    }
}