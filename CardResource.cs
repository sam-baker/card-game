using System.Numerics;
using Godot;

[GlobalClass]
public partial class CardResource : Resource
{
	public enum CardSuit
	{
		Spades = 0,
		Clubs = 1,
		Diamonds = 2,
		Hearts = 3
	}

	public enum CardRank
	{
		Ace = 0,
		Two = 1,
		Three = 2,
		Four = 3,
		Five = 4,
		Six = 5,
		Seven = 6,
		Eight = 7,
		Nine = 8,
		Ten = 9,
		Jack = 10,
		Queen = 11,
		King = 12
	}

	public enum CardExtras
	{
		BackOne,
		BackTwo,
		BackMany,
	}
	[Export]
	public CardSuit Suit { get; set; }
	[Export]
	public CardRank Rank { get; set; }
	[Export]
	public CardExtras Back { get; set; }
	private bool _faceUp = true;
	public bool faceUp
	{
		get { return _faceUp; }
		set
		{
			_faceUp = value;
			//if (_faceUp == false){}
			}
	}

	[Export]
	public Vector2I BackAtlasCoords { get; set; }
	public Vector2I AtlasCoords { get; set; }
	// [Export]
	// public int cardWidth = 18;
	// [Export]
	// public int cardHeight = 22;
	[Export]
	public Vector2I cardSize = new Vector2I(18, 22);
	[Export]
	public float cardScale = 3;
}
