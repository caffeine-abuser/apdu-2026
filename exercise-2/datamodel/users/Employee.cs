class Employee(string username) : IBaseUser
{
    public string UserName { get; set; } = username;
    public int MaxSimultaneousRentals { get; } = 5;
}