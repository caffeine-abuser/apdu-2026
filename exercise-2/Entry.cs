// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

// """deserialize""" data from """DB"""
var database = new DataSource();
var users = database.Users;
var devices = database.Devices;
var rentals = database.Rentals;

// check internal consistency; drop invalid elements


// actually accept arguments from user
// todo: add new user/device, list everything