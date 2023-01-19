using System;
using System.Collections.Generic;
// Simple business object. A PartId is used to identify the type of part
// but the part name can change.
public class Part : IEquatable<Part>, IComparable<Part>
{
    public  string PartName { get; set; }

    public int PartId { get; set; }

    public override int GetHashCode()
    {
        return PartId;
    }
    public override string ToString()
    {
        return "ID: " + PartId + "   Name: " + PartName;
    }
    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        Part objAsPart = obj as Part;
        if (objAsPart == null) return false;
        else return Equals(objAsPart);
    }
    public bool Equals(Part other)
    {
        if (other == null) return false;
        return (this.PartId.Equals(other.PartId));
    }
    // Should also override == and != operators.

    public int CompareTo(object obj)
    {
        if (obj == null) return 1;
        Part objAsPart = obj as Part;
        if (objAsPart == null) return 1;
        else return CompareTo(objAsPart);
    }

    public int CompareTo(Part other)
    {
        if (other == null) return 1;
        return (this.PartName.CompareTo(other.PartName));
    }
}

public class MyApp
{
    public static void Main()
    {
        // Create a list of parts.
        List<Part> parts = new List<Part>();

        // Add parts to the list.
        parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
        parts.Add(new Part() { PartName = "chain ring", PartId = 1334 });
        parts.Add(new Part() { PartName = "regular seat", PartId = 1434 });
        parts.Add(new Part() { PartName = "banana seat", PartId = 1444 });
        parts.Add(new Part() { PartName = "cassette", PartId = 1534 });
        parts.Add(new Part() { PartName = "shift lever", PartId = 1634 });

        // Write out the parts in the list. This will call the overridden ToString method
        // in the Part class.
        foreach (Part aPart in parts)
        {
            Console.WriteLine(aPart);
        }

        // Check the list for part #1734. This calls the IEquatable.Equals method
        // of the Part class, which checks the PartId for equality.
        Console.WriteLine("\nContains(\"1734\"): {0}", parts.Contains(new Part { PartId = 1734, PartName = "" }));
        //Console.WriteLine("\nContains(\"1734\"): {0}", parts.Equals(new Part { PartId = 1734, PartName = "" }));

        // Insert a new item at position 2.
        Console.WriteLine("\nInsert(2, \"1834\")");
        Console.WriteLine();
        parts.Insert(2, new Part() { PartName = "brake lever", PartId = 1834 });

        foreach (Part aPart in parts)
        {
            Console.WriteLine(aPart);
        }

        Console.WriteLine("\nParts[3]: {0}", parts[3]);

        Console.WriteLine("\nRemove(\"1534\")");

        // This will remove part 1534 even though the PartName is different,
        // because the Equals method only checks PartId for equality.
        parts.Remove(new Part() { PartId = 1534, PartName = "cogs" });

        Console.WriteLine();
        foreach (Part aPart in parts)
        {
            Console.WriteLine(aPart);
        }
        Console.WriteLine("\nRemoveAt(3)");
        // This will remove the part at index 3.
        parts.RemoveAt(3);

        Console.WriteLine();
        foreach (Part aPart in parts)
        {
            Console.WriteLine(aPart);
        }

        Console.WriteLine("\nSort");
        parts.Sort();
        Console.WriteLine();
        foreach (Part aPart in parts)
        {
            Console.WriteLine(aPart);
        }
    }
}