class DataSource
{
    public List<IBaseUser> Users { get; set; } = new List<IBaseUser>();
    public List<IBaseDevice> Devices { get; set; } = new List<IBaseDevice>();
    public List<Rental> Rentals { get; set; } = new List<Rental>();
}