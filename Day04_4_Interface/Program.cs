/* 
    Interface
*/
void Main() {
    Human human = new Human();
    human.Kerja();
    human.Kuliah();
    human.Nikah();
    Console.WriteLine(human.SudahNikah(1));
    human.MainGame();

    IPermintaanOrtu permintaan = human;
	permintaan.Kerja();
	permintaan.Kuliah();
	permintaan.Nikah();
	Console.WriteLine(permintaan.SudahNikah(1));
	// permintaan.MainGame(); // ERROR: karena method MainGame() hanya ada di class Human
}

public interface IPermintaanOrtu {
    void Kuliah();
    void Kerja();
    void Nikah();
    bool SudahNikah(int istri);
}

// class human dengan interface IPermintaanOrtu
class Human:IPermintaanOrtu {
    // method implementation
    public void Kuliah() {
        Console.WriteLine("Kerja di Formulatrix");
    }
    public void Kerja() {
        Console.WriteLine("Kuliah BSI aja");
    }
    public void Nikah() {
        Console.WriteLine("Nikah OK");
    }
    bool SudahNikah(int istri) {
        if (istri > 0){
            return true;
        } 
        return false;
    }

    // new method
    public void MainGame() {
        Console.WriteLine("Game");
    }
}