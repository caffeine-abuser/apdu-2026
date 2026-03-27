class Camera(string name, string serviceTag, DateOnly manufactureYear, string resolution, CameraType type) : IBaseDevice
{
    public string Name { get; init; } = name;
    public string ServiceTag { get; init; } = serviceTag;
    public int ManufactureYear { get; init; } = manufactureYear.Year;

    // camera-specific fields; eg "480x240" for resolution
    public string Resolution { get; init; } = resolution;
    public CameraType Type = type;
}