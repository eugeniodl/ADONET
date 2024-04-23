using Ejemplo01;
using System.Configuration;

string sqlServerConnectionString =
    ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

IRepository<Customer> repository = 
    new CustomerRepository(sqlServerConnectionString);

var sqlServerCustomers = repository.GetAll();
Console.WriteLine("Clientes de SQL Server");
foreach (var customer in sqlServerCustomers)
    Console.WriteLine($"ID: {customer.Id}, " +
        $"Nombre: {customer.FirstName}, " +
        $"Apellido: {customer.LastName}");
