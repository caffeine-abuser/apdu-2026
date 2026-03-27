// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

// deserialize data from DB
var database = new DataSource("Data Source=hardware-rental.sqlite");
var users = DbInterop.loadUsers();
var devices = DbInterop.loadDevices();
var rentals = DbInterop.loadRentals();

// check internal consistency; drop invalid elements


// actually accept arguments from user
// todo: add new user/device, list everything