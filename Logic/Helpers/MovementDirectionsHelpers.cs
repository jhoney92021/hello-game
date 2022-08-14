using Godot;
using Logic.Enums;
using System;

namespace Logic.Helpers
{	
	public static class MovementDirectionsHelpers
	{
		public static Move GetMovementDirectionsFromString(string directionString)
		{
			switch (directionString)
			{
				case "move_up":
					return Move.Up;
				case "move_down":
					return Move.Down;
				case "move_right":
					return Move.Right;
				case "move_left":
					return Move.Left;
				default:
					return Move.UnMapped;
			}
		}
	
		public static Move GetDirectionFromAction()
		{
			if (Input.IsActionPressed("move_right"))
			{
				return Move.Right;
			}
			else if (Input.IsActionPressed("move_left"))
			{
				return Move.Left;
			}
			else if (Input.IsActionPressed("move_up"))
			{
				return Move.Up;
			}
			else if (Input.IsActionJustReleased("move_up"))
			{
				return Move.UpIdle;
			}
			else if (Input.IsActionPressed("move_down"))
			{
				return Move.Down;
			}
			else if (Input.IsActionJustReleased("move_down"))
			{
				return Move.DownIdle;
			}
			else
			{
				return Move.UnMapped;
			}
		}
	}
}