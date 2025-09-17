using Godot;

public partial class Card : TextureRect
{
	private TextureRect _cardArt;
	public CardResource Data { get; set; }
	private bool _isDragging = false;
	private Vector2 _dragOffset = new Vector2();
	public override void _Ready()
	{
		base._Ready();
		//_cardSprite = GetNode<Sprite2D>("Sprite2D");
		_cardArt = this;
		//this.CustomMinimumSize = new Vector2(Data.cardWidth, Data.cardHeight);
	}

	public void SetCardData(CardResource data)
	{
		if (_cardArt == null)
		{
			GD.PrintErr("Missing TextureRect");
			return;
		}

		if (_cardArt.Texture is AtlasTexture atlasTexture)
		{
			atlasTexture = (AtlasTexture)atlasTexture.Duplicate();
			//Rect2 cardRegion = new Rect2(data.AtlasCoords.X * cardWidth, data.AtlasCoords.Y * cardHeight, cardWidth, cardHeight);
			Rect2 cardRegion = new Rect2(data.AtlasCoords * data.cardSize, data.cardSize);
			atlasTexture.Region = cardRegion;
			_cardArt.Texture = atlasTexture;
			//cardArt.StretchMode = StretchModeEnum.KeepAspect
			_cardArt.CustomMinimumSize = data.cardSize * new Vector2I((int)data.cardScale, (int)data.cardScale);
		}
	}

	public override void _GuiInput(InputEvent @event)
	{
		base._GuiInput(@event);
		if (@event is InputEventMouseButton mouseEvent)
		{
			if (mouseEvent.ButtonIndex == MouseButton.Left)
			{
				if (mouseEvent.Pressed)
				{
					_isDragging = true;
					_dragOffset = GetGlobalMousePosition() - GlobalPosition;
					//move card to the front when you're dragging
					GetParent().MoveChild(this, GetParent().GetChildCount() - 1);
				}
				else
				{
					_isDragging = false;
				}
			}
		}
	}

	public override void _Process(double delta)
	{
		base._Process(delta);
		if (_isDragging)
		{
			GlobalPosition = GetGlobalMousePosition() - _dragOffset;
		}
	}

}
