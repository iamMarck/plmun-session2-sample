using SamplePizza.Data;
using SamplePizza.Models;

using SamplePizzaContext context = new SamplePizzaContext();

Product veggieSpecial = new Product() { Name = "Veggie Special Pizza", Price = 9.99M };
context.Products.Add(veggieSpecial);

Product deluxeMeat = new Product() { Name = "Deluxe Meat Pizza", Price = 12.99M };
context.Add(deluxeMeat);

Product angels = new Product() { Name = "Angels Pizza", Price = 5.01M };
context.Add(angels);

Product shakeys = new Product() { Name = "Shakeys Pizza", Price = 1.01M };
context.Add(shakeys);

Product pizzaHut = new Product() { Name = "Pizza hut", Price = 1.01M };
context.Add(pizzaHut);


context.SaveChanges();

