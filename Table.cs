using Godot;
using Godot.Collections;
using System;
//using System.Collections.Generic;

public partial class Table : Node2D
{
	[Export]
	public PackedScene CardScene { get; set; }
	private HBoxContainer p1Hand;
	private HBoxContainer p2Hand;
	private GridContainer grid;
	//public List<CardResource> deckArray;
	//public Godot.Collections.Array deckArray = new Godot.Collections.Array();
	//private DeckBuilder _deckBuilder;
	private Dealer dealer;
	public Godot.Collections.Array player1Cards;
	public Godot.Collections.Array player2Cards;
	public Godot.Collections.Array player3Cards;
	public Godot.Collections.Array player4Cards;

	public override void _Ready()
	{
		dealer = GetNode<Dealer>("Dealer");
		//_deckBuilder = GetNode<DeckBuilder>("/root/DeckBuilder");
		//deckArray = _deckBuilder.createStandardDeck(true);
		//hbox = GetNode<HBoxContainer>("Control/HBoxContainer");
		grid = GetNode<GridContainer>("Control/GridContainer");
		p1Hand = GetNode<HBoxContainer>("Player1/Hand");
		p2Hand = GetNode<HBoxContainer>("Player2/Hand");

		dealCards(p1Hand, 5);
		dealCards(p2Hand, 5);

		GD.Print("Should have worked");
	}
	private void dealCards(HBoxContainer hand,int count)
	{
		var cards = dealer.drawCards(count);
		foreach (CardResource card in cards)
		{
			Card blankCard = CardScene.Instantiate<Card>();
			hand.AddChild(blankCard);
			blankCard.SetCardData(card);
			GD.Print("should be adding cards to hand");
		}
	}
}