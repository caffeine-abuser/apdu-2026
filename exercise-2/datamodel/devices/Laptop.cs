class Laptop(string name, string serviceTag, DateOnly manufactureYear) : IBaseDevice
{
    public string Name { get; init; } = name;
    public string ServiceTag { get; init; } = serviceTag;
    public int ManufactureYear { get; init; } = manufactureYear.Year;

    // laptop-specific fields; add CPU and available disk space later
}