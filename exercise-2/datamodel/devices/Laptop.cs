using System.Runtime.InteropServices;

class Laptop(string name, string serviceTag, string cpu, int availableMemory, int availableDisk, OSPlatform os) : BaseDevice(name, serviceTag)
{

	public string CPU { get; set; } = cpu;
	public int AvailableMemory { get; set; } = availableMemory;  // in gigabytes
	public int AvailableDiskSpace { get; set; } = availableDisk; // likewise
	public OSPlatform OS { get; set; } = os;

	public override string ToString()
	{
		return $"a {Name} laptop (st: {ServiceTag}), spec: {CPU}/{AvailableMemory} GB RAM/{AvailableDiskSpace}GB disk space/{OS}";
	}
}