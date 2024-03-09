// Feature.cs
public class Feature
{
    public Properties Properties { get; set; }
}

// Properties.cs
public class Properties
{
    public string Place { get; set; }
    public double Mag { get; set; } // Renamed from Magnitude to match the JSON structure
}

// FeatureCollection.cs (rename if necessary)
public class FeatureCollection
{
    public Feature[] Features { get; set; }
}