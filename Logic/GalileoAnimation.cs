using Godot;
using System;
using DictionariesHelper = Logic.Dictionaries.DictionariesHelper;
using Constant = Logic.Constant.Constant;
using Move = Logic.Enums.Move;
using Helper = Logic.Helpers.MovementDirectionsHelpers;

public class GalileoAnimation : Godot.AnimatedSprite
{	
	// private const int MoveSpeed = 100;

	// All three of these change for each paddle.
	private string _left;
	private string _right;
	private string _up;
	private string _down;

	public override void _Ready()
	{
		_left = "move_left";
		_right = "move_right";
		_up = "move_up";
		_down = "move_down";
	}

	public void HandleMovementDirections(float delta)
    {
		var movement = Helper.GetDirectionFromAction();
		Vector2 position = Position; // Required so that we can modify position.y.

		switch (movement)
		{
			case Move.Up:
			case Move.Down	:
				float inputVertical = Input.GetActionStrength(_down) - Input.GetActionStrength(_up);
				// position += new Vector2(0, inputVertical * Constant.MoveSpeed * delta);
				position.y += inputVertical * Constant.MoveSpeed * delta;
				position.y = Mathf.Clamp(position.y, 16, GetViewportRect().Size.y - 16);
				Position = position;
				break;
			case Move.Right:
			case Move.Left:
				float inputHorizontal = Input.GetActionStrength(_left) - Input.GetActionStrength(_right);
				// position += new Vector2(inputHorizontal * Constant.MoveSpeed * delta, 0);
				position.x -= inputHorizontal * Constant.MoveSpeed * delta;
				position.x = Mathf.Clamp(position.x, 16, GetViewportRect().Size.x - 16);
				Position = position;
				break;
			default:
				break;
		}
	}

	public override void _Process(float delta)
	{
		HandleMovementDirections(delta);
	}
}
