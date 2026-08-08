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
            
        }
    }
}
