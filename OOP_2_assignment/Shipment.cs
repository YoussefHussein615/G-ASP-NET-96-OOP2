using System;

public class Shipment
{
    private string trackingCode;
    private string description;
    private decimal weight;
    private decimal deliveryFee;
    private DeliveryAddress destination;

    public string TrackingCode
    {
        get { return trackingCode; }
        private set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                trackingCode = value;
            }
        }
    }

    public string Description
    {
        get { return description; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                description = value;
            }
        }
    }

    public decimal Weight
    {
        get { return weight; }
        set
        {
            if (value > 0)
            {
                weight = value;
            }
        }
    }

    public decimal DeliveryFee
    {
        get { return deliveryFee; }
        private set
        {
            if (value > 0)
            {
                deliveryFee = value;
            }
        }
    }

    public DeliveryAddress Destination
    {
        get { return destination; }
        set { destination = value; }
    }

    public virtual decimal EstimatedCost
    {
        get { return DeliveryFee + (Weight * 5); }
    }

    public Shipment(string trackingCode)
    {
        TrackingCode = trackingCode;
        Description = "Unknown";
        Weight = 1;
        DeliveryFee = 50;
        Destination = new DeliveryAddress("Unknown", "Unknown", 0);
    }

    public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
    {
        TrackingCode = trackingCode;
        Description = description;
        Weight = weight;
        DeliveryFee = deliveryFee;
        Destination = destination;
    }

    public void UpdateDeliveryFee(decimal newFee)
    {
        if (newFee > 0)
        {
            DeliveryFee = newFee;
        }
    }

    protected void PrintCommonInfo()
    {
        Console.WriteLine("Tracking Code : " + TrackingCode);
        Console.WriteLine("Description   : " + Description);
        Console.WriteLine("Weight        : " + Weight + " KG");
        Console.WriteLine("Delivery Fee  : " + DeliveryFee + " EGP");
    }

    public virtual void PrintShipment()
    {
        Console.WriteLine("Shipment");
        Console.WriteLine();
        PrintCommonInfo();
        Console.WriteLine("Estimated Cost: " + EstimatedCost + " EGP");
    }
}
