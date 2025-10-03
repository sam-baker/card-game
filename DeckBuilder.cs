using Godot;
using System;
using System.Collections.Generic;
//using System.Runtime.InteropServices;

public partial class DeckBuilder : Node
{
	public static DeckBuilder Instance { get; private set; }
	private bool shuffle = false;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Instance = this;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	//public List<CardResource> createStandardDeck(bool shuffle = false)
	public Godot.Collections.Array createStandardDeck(bool shuffle = false)
	{
		//List<CardResource> newDeck = new List<CardResource>();
		Godot.Collections.Array newDeck = new Godot.Collections.Array();

		var suitValues = Enum.GetValues(typeof(CardResource.CardSuit));
		var rankValues = Enum.GetValues(typeof(CardResource.CardRank));

		foreach (CardResource.CardSuit suit in suitValues)
		{
			foreach (CardResource.CardRank rank in rankValues)
			{
				var card = new CardResource();
				card.Suit = suit;
				card.Rank = rank;
				card.AtlasCoords = new Vector2I((int)rank, (int)suit);
				//card.AtlasCoords = new Vector2I(4,10);
				//TODO make this not a constant later 4,10 is the card back
				card.BackAtlasCoords = new Vector2I(10, 4);
				//deckArray[3].AtlasCoords = new Vector2I((int)deckArray[3].Rank, (int)deckArray[3].Suit);
				newDeck.Add(card);
			}
		}
		if (shuffle) newDeck.Shuffle();

		return newDeck;
	}

	public Godot.Collections.Array createExtras()
	{
		Godot.Collections.Array extras = new Godot.Collections.Array();
		//var card
		return extras;
	}
}
