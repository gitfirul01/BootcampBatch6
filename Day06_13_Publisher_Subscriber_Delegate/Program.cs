/*
	Delegate
		- salah satu fungsi delegate adalah untuk membuat sistem pub/sub
*/

class Program {
	static void Main(){
		Publisher pub = new Publisher();
		
		Subscriber sub1 = new Subscriber();
		Subscriber2 sub2 = new Subscriber2();
		Subscriber3 sub3 = new Subscriber3();
		
		pub.AddSubscriber(sub1.Notification);	// menambahkan fungsi Notification milik sub1 ke variabel delegate pub
		pub.AddSubscriber(sub2.Notification);	// menambahkan fungsi Notification milik sub2 ke variabel delegate pub
		pub.AddSubscriber(sub3.Notification);	// menambahkan fungsi Notification milik sub3 ke variabel delegate pub
		
		pub.UploadVideo();	// tes upload video 
		
		pub.RemoveSubscriber(sub1.Notification);	// hapus subscriber
		
		pub.UploadVideo();	// tes upload video 
	}
}

class Publisher {
	public delegate void Notify(string message);	// deklarasi delegate
	private Notify subscriber;	// variabel delegate
	
	public void UploadVideo() {
		Console.WriteLine("Uploading Video...");
		Console.WriteLine("Finished");
		NotifyMySubscriber("Check my video");
	}
	public void NotifyMySubscriber(string message) {
		subscriber.Invoke(message);	// invoke delegate
	}
	public void AddSubscriber(Notify sub) {
		subscriber += sub;
	}
	public void RemoveSubscriber(Notify sub)
	{
		subscriber -= sub;
	}
}
class Subscriber {
	public void Notification(string message) {
		Console.WriteLine($"Subscriber 1 got notif : {message}");
	}
}
class Subscriber2
{
	public void Notification(string message)
	{
		Console.WriteLine($"Subscriber 2 got notif : {message}");
	}
}
class Subscriber3
{
	public void Notification(string message)
	{
		Console.WriteLine($"Subscriber 3 got notif : {message}");
	}
}