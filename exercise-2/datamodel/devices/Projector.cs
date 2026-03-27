class Projector(string name, string serviceTag, DateOnly manufactureYear) : IBaseDevice
{
    public string Name { get; init; } = name;
    public string ServiceTag { get; init; } = serviceTag;
    public int ManufactureYear { get; init; } = manufactureYear.Year;

    // projector-specific fields; also make type and resolution?

}