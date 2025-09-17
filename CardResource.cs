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
	[Export]
	public CardSuit Suit { get; set; }
	[Export]
	public CardRank Rank { get; set; }
	[Export]
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
