using Entities;

var factory = new FlyweightFactory(
        new Car { Company = "CarCompany", Model = "NiceModel2018", Color = "red" },
        new Car { Company = "CarCompany2", Model = "OKModel2020", Color = "blue" },
        new Car { Company = "CarCompany3", Model = "1998", Color = "black" },
        new Car { Company = "CarCompany4", Model = "FirstModel", Color = "white" },
        new Car { Company = "CarCompany4", Model = "SecondModel", Color = "brown" }
    );

factory.ListFlyweights();

AddCar(factory, new Car
{
    Number = "AB1234C",
    Owner = "Owner Name",
    Company = "CarCompany3",
    Model = "1998",
    Color = "black"
});

AddCar(factory, new Car
{
    Number = "AB4321C",
    Owner = "Owner Name",
    Company = "CarCompany3",
    Model = "2000",
    Color = "black"
});

factory.ListFlyweights();

void AddCar(FlyweightFactory factory, Car car)
{
    Console.WriteLine("\nAdding a car.");

    var flyweight = factory.GetFlyweight(new Car
    {
        Color = car.Color,
        Model = car.Model,
        Company = car.Company
    });

    // The client code either stores or calculates extrinsic state and
    // passes it to the flyweight's methods.
    flyweight.Operation(car);
}