abstract class BaseDevice(string name, string serviceTag)
{
    public Guid Id { get; init; } = Guid.NewGuid();
	public string Name { get; set; } = name;
	public string ServiceTag { get; init; } = serviceTag;
	public DeviceStatus Status { get; set; } = DeviceStatus.AVAILABLE;
}

enum DeviceStatus
{
    AVAILABLE,
    RENTED,
    ADMINISTRATIVELY_RESERVED,
    DECOMMISSIONED
}