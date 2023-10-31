﻿// Collection implementation

class Program {
	static void Main()
	{
		Player player1 = new();
		Dictionary<Player, Data> dictPlayers = new();
		
		dictPlayers.Add(player1, new Data(Colour.Black, 0, 100));
		
		Data result = dictPlayers[player1]; // Return Data dari DictPlayers
		foreach(Card c in result.GetCards()) {
			//...
		}
		Colour colourPlayer = result.GetColour();
		Console.WriteLine(colourPlayer);
	}
}

class Data
{
	private List<Card> _playerCards;
	private Colour _playerColour;
	private int _playerScore;
	private int _playerBet;
	
	public Data(Colour colour, int initialScore, int bet) {
		_playerCards = new();
		_playerColour = colour;
		_playerScore = initialScore;
		_playerBet = bet;
	}
	public bool AddCards(Card card){
		_playerCards.Add(card);
		return true;
	}
	public List<Card> GetCards()
	{
		return _playerCards;
	}
	public Colour GetColour() {
		return _playerColour;
	}
}

public enum Colour
{
	White,
	Black
}

class Player { 
	
}

class Card { 
	
}