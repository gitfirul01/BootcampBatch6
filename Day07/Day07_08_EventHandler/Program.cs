﻿// EventHandler
class Program {
    static void Main() {
        Youtuber pub = new Youtuber("Jokoyanto");
        Subscriber sub = new Subscriber();

        pub.eventHandler += sub.Notification;
        pub.SendNotification();
    }
}
class Youtuber {
	private string _name;
	public event EventHandler eventHandler;

	public Youtuber(string name) { _name = name; }
	
    public void SendNotification() { eventHandler?.Invoke(this, EventArgs.Empty); }
    // for the default, this.ToString() method will return type of the class (class name), 
    // so we should override the method to get the _name variable
	public override string ToString() { return _name; }
}

// class Publisher {
// 	private string _name;
// 	public event EventHandler eventHandler;
	
//  public Publisher(string name) { _name = name; }

// 	public void SendNotification() { eventHandler?.Invoke(this, EventArgs.Empty); }
// 	public override string ToString() { return _name; }
// }

class Subscriber {
	public void Notification(object sender, EventArgs e) {
		Console.WriteLine($"Called by {sender}");
	}
}