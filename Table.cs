using Godot;
using Godot.Collections;
using System;
//using System.Collections.Generic;

public partial class Table : Node2D
{
	//private HBoxContainer p1Hand;
	//private HBoxContainer p2Hand;
	private GridContainer grid;
	//public List<CardResource> deckArray;
	//public Godot.Collections.Array deckArray = new Godot.Collections.Array();
	//private DeckBuilder _deckBuilder;
	private Dealer dealer;
	//public Godot.Collections.Array player1Cards;
	//public Godot.Collections.Array player2Cards;
	//public Godot.Collections.Array player3Cards;
	//public Godot.Collections.Array player4Cards;
	public CanvasLayer Player1;
	public CanvasLayer Player2;

	public override void _Ready()
	{
		//create a dealer who has a deck of cards.
		dealer = GetNode<Dealer>("Dealer");
		//_deckBuilder = GetNode<DeckBuilder>("/root/DeckBuilder");
		//deckArray = _deckBuilder.createStandardDeck(true);
		//hbox = GetNode<HBoxContainer>("Control/HBoxContainer");
		grid = GetNode<GridContainer>("Control/GridContainer");
		//p1Hand = GetNode<HBoxContainer>("Player1/Hand");
		//p2Hand = GetNode<HBoxContainer>("Player2/Hand");
		Player1 = GetNode<CanvasLayer>("Player1");
		Player2 = GetNode<CanvasLayer>("Player2");

		foreach (CardResource card in dealer.deck)
		{
			card.Discarded += OnCardDiscarded;
		}

		dealer.dealCards(Player1, 5);
		dealer.dealCards(Player2, 5);
		
	}

	private void OnCardDiscarded(CardResource card)
	{
		GD.Print($"Table saw {card.Rank} of {card.Suit} was discarded");
	}


}
