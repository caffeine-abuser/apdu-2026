class Projector(string name, string serviceTag, int lumens, ProjectorType type) : BaseDevice(name, serviceTag)
{
	public int Lumens { get; init; } = lumens;
	public ProjectorType Type { get; init; } = type;

	public override string ToString()
	{
		return $"a {Name} projector (st: {ServiceTag}), brightness {Lumens} lm, type {Type}";
	}
}

public enum ProjectorType
{
    DIGITAL,
    SLIDE,
    DOCUMENT_CAMERA
}