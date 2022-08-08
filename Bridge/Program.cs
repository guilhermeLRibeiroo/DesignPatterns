using Bridge.Entities;


// TV + Basic Remote
Console.WriteLine("TV + Basic Remote:");
var tv = new TV();
var basicRemote = new BasicRemote(tv);

basicRemote.Power();
tv.LogStatus();

// TV + Advanced Remote
Console.WriteLine("\nTV + Advanced Remote:");
tv = new TV();
var advancedRemote = new AdvancedRemote(tv);

advancedRemote.Power();
advancedRemote.Mute();

tv.LogStatus();

// Radio + Basic Remote
Console.WriteLine("\nRadio + Basic Remote:");
var radio = new Radio();

basicRemote = new BasicRemote(radio);

basicRemote.Power();
basicRemote.ChannelUp();

radio.LogStatus();

// Radio + Advanced Remote
Console.WriteLine("\nRadio + Advanced Remote:");
radio = new Radio();

advancedRemote = new AdvancedRemote(radio);

advancedRemote.Power();
advancedRemote.Mute();

radio.LogStatus();