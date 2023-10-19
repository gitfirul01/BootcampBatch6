// Duplicate Delegate
public delegate void Publish(string x);

class Program {
	static void Main() {
		Publisher pub = new();
		Subscriber sub = new();
		pub.AddSubscriber(sub.Notify);
		pub.AddSubscriber(sub.Notify); // duplicate delegate 
		pub.SentNotification();
		
		pub.RemoveSubscriber(sub.Notify);
		pub.SentNotification();
	}
}

class Publisher {
	private Publish _subscriber;
	public void SentNotification() {
		if(_subscriber != null) 		// periksa apakah _subscriber kosong (memiliki fungsi sama dengan '?' pada _subscriber?.Invoke())
			_subscriber.Invoke("subs");
		else{
			Console.WriteLine("Subscriber kosong");
		}
	}
	public bool AddSubscriber(Publish sub) {
		if(_subscriber is null || !_subscriber.GetInvocationList().Contains(sub))
		// jika (subscribernya kosong) atau (subscriber yang ditambahkan belum pernah ditambahkan sebelumnya)
		// _subscriber.GetInvocationList().Contains(sub): akan membongkar delegate '_subscriber' dan memeriksa apakah terdapat method 'sub' (return TRUE / FALSE)
		{
		 	_subscriber += sub;
			return true;
		}
		return false;
	}
	public void RemoveSubscriber(Publish sub) {
		_subscriber -= sub;
	}
}
class Subscriber {
	public void Notify(string message) {
		Console.WriteLine($"pesan: {message}");
	}
}