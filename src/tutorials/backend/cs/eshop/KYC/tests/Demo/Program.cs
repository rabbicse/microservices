// See https://aka.ms/new-console-template for more information
using Demo;
using Newtonsoft.Json;

Console.WriteLine("Hello, World!");


// Create an instance of CustomerCreatedEvent
var customerEvent = new CustomerCreatedEvent(
    Guid.NewGuid(),
    "John Doe",
    "john@example.com",
    DateTime.Now
);

// Serialize the object to JSON using Newtonsoft.Json
string json = JsonConvert.SerializeObject(customerEvent);

Console.WriteLine(json);