public class FeatureCollection
{
    // Array of features in the collection
    public Feature[] Features { get; set; }
}

// Represents a single feature in the FeatureCollection
public class Feature
{
    // Properties of the feature
    public Properties Properties { get; set; }
}

// Represents the properties of a feature
public class Properties
{
    // Magnitude of the earthquake
    public decimal Mag { get; set; }

    // Location description of the earthquake
    public string Place { get; set; }
}
