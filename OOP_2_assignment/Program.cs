namespace OOP_2_assignment
{
    internal class Program
    {

        /*
         PART 01 : THEORETICAL QUESTIONS

        Question 1

        a) Difference between a class and a struct:
           - A "CLASS" is a REFERENCE TYPE: variables hold a reference
             to an object stored on the heap. Copying a class variable copies
             the reference, so both variables point to the same object.
             Classes support inheritance, can have a parameterless "default"
             constructor removed, and objects live until garbage collected.

           - A "STRUCT" is a VALUE TYPE: variables hold the actual data directly,
             usually on the stack Copying a struct variable copies the whole value
             producing an independentcopy.
             Structs cannot inherit from another struct or class.

        b) Why classes are more suitable than structs for large applications?

           - Large applications usually need inheritance and polymorphism to
           model relationships between types shared behavior,
           Structs, being value types get copied on every assignment or method call
           which becomes expensive and error-prone for large 
           Classes also support features large systems rely on heavily, such
           as constructor chaining across a hierarchy, virtual/override
           members, and reference-based identity.

        Question 2

        a) The parent (base) class is "Shipment".
        b) The child (derived) class is "ExpressShipment".
        c) ExpressShipment inherits the TrackingCode property from Shipment.
        d) Inheritance is better than duplicating the same code in multiple
           classes because shared members are defined
           ONCE in the base class and automatically reused by every derived
           class. This avoids copy-pasted code, means a bug fix or change only
           needs to happen in one place, and lets each derived class focus only
           on what makes it different, while   still being usable anywhere a Shipment is expected


        */
        static void Main(string[] args)
        {
            DeliveryCenter center = new DeliveryCenter();

            Console.Write("Enter Delivery Center Name: ");
            center.CenterName = Console.ReadLine();
            Console.WriteLine();

            // ---- Standard Shipment ----
            Console.WriteLine("Enter Standard Shipment Data");
            Console.Write("TrackingCode: ");
            string sTrackingCode = Console.ReadLine();
            Console.Write("Description: ");
            string sDescription = Console.ReadLine();
            Console.Write("Weight in KG: ");
            decimal sWeight = decimal.Parse(Console.ReadLine());
            Console.Write("DeliveryFee: ");
            decimal sFee = decimal.Parse(Console.ReadLine());
            Console.Write("City: ");
            string sCity = Console.ReadLine();
            Console.Write("Street: ");
            string sStreet = Console.ReadLine();
            Console.Write("Building Number: ");
            int sBuilding = int.Parse(Console.ReadLine());

            DeliveryAddress sAddress = new DeliveryAddress(sCity, sStreet, sBuilding);
            StandardShipment standardShipment = new StandardShipment(sTrackingCode, sDescription, sWeight, sFee, sAddress);
            bool added1 = center.AddShipment(standardShipment);
            Console.WriteLine(added1 ? "Shipment Added Successfully." : "Delivery center is full.");
            Console.WriteLine();

            // ---- Express Shipment ----
            Console.WriteLine("Enter Express Shipment Data");
            Console.Write("TrackingCode: ");
            string eTrackingCode = Console.ReadLine();
            Console.Write("Description: ");
            string eDescription = Console.ReadLine();
            Console.Write("Weight: ");
            decimal eWeight = decimal.Parse(Console.ReadLine());
            Console.Write("DeliveryFee: ");
            decimal eFee = decimal.Parse(Console.ReadLine());
            Console.Write("City: ");
            string eCity = Console.ReadLine();
            Console.Write("Street: ");
            string eStreet = Console.ReadLine();
            Console.Write("Building Number: ");
            int eBuilding = int.Parse(Console.ReadLine());
            Console.Write("ExtraFee: ");
            decimal extraFee = decimal.Parse(Console.ReadLine());

            DeliveryAddress eAddress = new DeliveryAddress(eCity, eStreet, eBuilding);
            ExpressShipment expressShipment = new ExpressShipment(eTrackingCode, eDescription, eWeight, eFee, eAddress, extraFee);
            bool added2 = center.AddShipment(expressShipment);
            Console.WriteLine(added2 ? "Shipment Added Successfully." : "Delivery center is full.");
            Console.WriteLine();

            // ---- International Shipment ----
            Console.WriteLine("Enter International Shipment Data");
            Console.Write("TrackingCode: ");
            string iTrackingCode = Console.ReadLine();
            Console.Write("Description: ");
            string iDescription = Console.ReadLine();
            Console.Write("Weight: ");
            decimal iWeight = decimal.Parse(Console.ReadLine());
            Console.Write("DeliveryFee: ");
            decimal iFee = decimal.Parse(Console.ReadLine());
            Console.Write("City: ");
            string iCity = Console.ReadLine();
            Console.Write("Street: ");
            string iStreet = Console.ReadLine();
            Console.Write("Building Number: ");
            int iBuilding = int.Parse(Console.ReadLine());
            Console.Write("Destination Country: ");
            string destinationCountry = Console.ReadLine();
            Console.Write("Customs Fee: ");
            decimal customsFee = decimal.Parse(Console.ReadLine());

            DeliveryAddress iAddress = new DeliveryAddress(iCity, iStreet, iBuilding);
            InternationalShipment internationalShipment = new InternationalShipment(iTrackingCode, iDescription, iWeight, iFee, iAddress, destinationCountry, customsFee);
            bool added3 = center.AddShipment(internationalShipment);
            Console.WriteLine(added3 ? "Shipment Added Successfully." : "Delivery center is full.");
            Console.WriteLine();

            // ---- Print all shipments ----
            center.PrintAllShipments("Delivery Center : " + center.CenterName);

            // ---- Search by tracking code ----
            Console.Write("Enter Tracking Code to Search: ");
            string searchCode = Console.ReadLine();
            Shipment found = center[searchCode];
            if (found != null)
            {
                Console.WriteLine();
                Console.WriteLine("Shipment Found:");
                found.PrintShipment();
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }
            Console.WriteLine();

            // ---- Remove a shipment ----
            Console.Write("Enter Tracking Code to Remove: ");
            string removeCode = Console.ReadLine();
            bool removed = center.RemoveShipment(removeCode);
            Console.WriteLine();
            Console.WriteLine(removed ? "Shipment Removed Successfully." : "Shipment not found.");
            Console.WriteLine();

            // ---- Print remaining shipments ----
            center.PrintAllShipments("Remaining Shipments");
        }
    }
}
