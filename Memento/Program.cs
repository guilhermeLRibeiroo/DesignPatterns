using Memento;

var originator = new Originator("Starting state");
var caretaker = new Caretaker(originator);

caretaker.Backup();
originator.ChangeState();

caretaker.Backup();
originator.ChangeState();

caretaker.Backup();
originator.ChangeState();

caretaker.Backup();
originator.ChangeState();

Console.WriteLine("Rollback:");
caretaker.Undo();

Console.WriteLine("Rollback again:");
caretaker.Undo();

caretaker.ShowHistory();