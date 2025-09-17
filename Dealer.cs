using Godot;
using Godot.NativeInterop;
using System;
using System.Linq;

public partial class Dealer : Node
{
	public Godot.Collections.Array deck = new Godot.Collections.Array();
	public Godot.Collections.Array discardPile = new Godot.Collections.Array();
	//private DeckBuilder _deckBuilder;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		deck = DeckBuilder.Instance.createStandardDeck(true);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	public Godot.Collections.Array drawCards(int count)
	{
		var hand = new Godot.Collections.Array();

		for (int i = 0; i < count; i++)
		{
			if (deck.Count != 0)
			{
				GD.Print("in for loop");
				GD.Print(i);
				var first = deck[0];
				hand.Add(first);
				deck.RemoveAt(0);
				GD.Print("card " + hand[0]);
			}
			else
			{
				GD.Print("deck is empty");
			}
		}
		return hand;
	}
}
