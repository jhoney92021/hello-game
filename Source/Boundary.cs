using Godot;

public class Boundary : Area2D
{
	[Export]
	private int _bounceDirection = 1;

	public void OnAreaEntered(Area2D area)
	{
		if (area is CharacterBox characterBox)
		{
			characterBox.direction = (characterBox.direction + new Vector2(0, _bounceDirection)).Normalized();
		}
	}
}
