public class ExpressShipment : Shipment
{
    private decimal extraFee;

    public decimal ExtraFee
    {
        get { return extraFee; }
        set
        {
            if (value >= 0)
            {
                extraFee = value;
            }
        }
    }

    public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
        : base(trackingCode, description, weight, deliveryFee, destination)
    {
        ExtraFee = extraFee;
    }
    public override decimal EstimatedCost
    {
        get { return DeliveryFee + (Weight * 5) + ExtraFee; }
    }

    public override void PrintShipment()
    {
        Console.WriteLine("Express Shipment");
        Console.WriteLine();
        PrintCommonInfo();
        Console.WriteLine("Extra Fee     : " + ExtraFee + " EGP");
        Console.WriteLine("Estimated Cost: " + EstimatedCost + " EGP");
    }
}

