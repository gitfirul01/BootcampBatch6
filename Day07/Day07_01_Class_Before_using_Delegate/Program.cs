//BEFORE
class UI { public void UpdateUI(string data) { Console.WriteLine($"UI updated: {data}"); } }
class Database { public void WriteToDb(string data) { Console.WriteLine($"DB writed: {data}"); } }
class File { public void WriteToFile(string data) { Console.WriteLine($"File Writed: {data}"); } }

class GameController {
	private UI _ui;
	private Database _db;
	private File _file;
	public GameController(UI ui, Database db, File file) {
		_ui = ui;
		_db = db;
		_file = file;
	}
	public void EndGame() {
		_ui.UpdateUI("DATA");
		_db.WriteToDb("DATA");
		_file.WriteToFile("DATA");
	}
}

static class Program {
	static void Main() {
		UI ui = new();
		Database database = new();
		File file = new();

		GameController gameController = new(ui, database, file);
		gameController.EndGame();
	}
}