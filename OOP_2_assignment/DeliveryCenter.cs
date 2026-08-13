public class DeliveryCenter
{
    public string CenterName { get; set; }

    private Shipment[] shipments = new Shipment[20];

    public Shipment this[int index]
    {
        get
        {
            if (index < 0 || index >= shipments.Length)
            {
                return null;
            }
            return shipments[index];
        }
        set
        {
            if (index < 0 || index >= shipments.Length)
            {
                return;
            }
            shipments[index] = value;
        }
    }

    public Shipment this[string trackingCode]
    {
        get
        {
            foreach (Shipment shipment in shipments)
            {
                if (shipment != null && shipment.TrackingCode == trackingCode)
                {
                    return shipment;
                }
            }
            return null;
        }
    }

    public bool AddShipment(Shipment shipment)
    {
        for (int i = 0; i < shipments.Length; i++)
        {
            if (shipments[i] == null)
            {
                shipments[i] = shipment;
                return true;
            }
        }
        return false;
    }

    public bool RemoveShipment(string trackingCode)
    {
        for (int i = 0; i < shipments.Length; i++)
        {
            if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
            {
                shipments[i] = null;
                return true;
            }
        }
        return false;
    }

    public void PrintAllShipments(string header)
    {
        Console.WriteLine("===========================================");
        Console.WriteLine(header);
        Console.WriteLine("===========================================");

        bool first = true;
        foreach (Shipment shipment in shipments)
        {
            if (shipment != null)
            {
                if (!first)
                {
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine();
                }
                shipment.PrintShipment();
                Console.WriteLine();
                first = false;
            }
        }
    }
}

