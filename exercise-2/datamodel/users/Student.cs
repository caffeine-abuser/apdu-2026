class Student(string username, string group) : IBaseUser
{
    public string UserName { get; set; } = username;
    public int MaxSimultaneousRentals { get; } = 2;
    public string Group { get; set; } = group;
}