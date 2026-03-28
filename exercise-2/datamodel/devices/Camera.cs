class Camera(string name, string serviceTag, int horResolution, int vertResolution) : BaseDevice(name, serviceTag)
{
    public int HorizontalResolution { get; set; } = horResolution;
    public int VerticalResolution { get; set; } = vertResolution;

    public override string ToString()
    {
        return $"a {Name} camera (st: {ServiceTag}), {HorizontalResolution}x{VerticalResolution}, currently {Status}";
    }
}