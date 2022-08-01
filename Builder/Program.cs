using Builder;
using Builder.Builders;
using Builder.Entities;

var director = new Director();

// Sports Car
CarBuilder carBuilder = new CarBuilder();
director.ConstructSportsCar(carBuilder);
Car sportsCar = carBuilder.Build();

sportsCar.PrintInformation();

Console.Write("\n");

CarManualBuilder carManualBuilder = new CarManualBuilder();
director.ConstructSportsCar(carManualBuilder);
Manual sportsCarManual = carManualBuilder.Build();

sportsCarManual.PrintInformation();

Console.Write("\n");

// SUV
director.ConstructSUV(carBuilder);
Car suv = carBuilder.Build();

suv.PrintInformation();

Console.Write("\n");

director.ConstructSUV(carManualBuilder);
Manual suvManual = carManualBuilder.Build();

suvManual.PrintInformation();

