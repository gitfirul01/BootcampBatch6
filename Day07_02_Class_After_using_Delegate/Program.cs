//AFTER using Delegate
public delegate void MyDelegate(string message);

class UI { public void UpdateUI(string data) { Console.WriteLine($"UI updated: {data}"); } }
class Database { public void WriteToDb(string data) { Console.WriteLine($"DB writed: {data}"); } }
class File { public void WriteToFile(string data) { Console.WriteLine($"File Writed: {data}"); } }

public class GameController {
	private MyDelegate _myDel;
	public void AddSubscriber(MyDelegate add) {
		_myDel += add;
	}
	public void EndGame() {
		_myDel?.Invoke("DATA");
	}
}

static class Program {
	static void Main() {
		UI ui = new();
		Database database = new();
		File file = new();

		GameController gameController = new();
		
		gameController.AddSubscriber(ui.UpdateUI);
		gameController.AddSubscriber(database.WriteToDb);
		gameController.AddSubscriber(file.WriteToFile);

		gameController.EndGame();
	}
}