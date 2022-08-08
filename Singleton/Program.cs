using Singleton.Entities;

Console.WriteLine("If both values are equal it means two threads initialized the singleton at the same time.");

Thread process1 = new Thread(() =>
{
    TestSingleton("Process 1");
});

Thread process2 = new Thread(() =>
{
    TestSingleton("Process 2");
});

process1.Start();
process2.Start();

process1.Join();
process2.Join();

void TestSingleton(string value)
{
    var databaseSingleton = Database.GetInstance(value);
    Console.WriteLine("({0}) Value: '{1}'", value, databaseSingleton.Value);
}