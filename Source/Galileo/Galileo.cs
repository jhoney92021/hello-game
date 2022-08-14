using Godot;
using System;
using Move = Logic.Enums.Move;
using Helper = Logic.Helpers.MovementDirectionsHelpers;

public class Galileo : KinematicBody2D
{
	private AnimatedSprite _animatedSprite;
	public void HandleAnimationForMovementDirections()
    {
		var movement = Helper.GetDirectionFromAction();
		switch (movement)
		{
			case Move.Up:
				_animatedSprite.Play("away_from_screen");
				break;
			case Move.UpIdle:
				_animatedSprite.Play("idle_away_from_screen");
				break;
			case Move.Right:
				_animatedSprite.FlipH = false;
				_animatedSprite.Play("walking");
				break;
			case Move.Down:			
				_animatedSprite.Play("toward_screen");
				break;
			case Move.DownIdle:			
				_animatedSprite.Play("idle");
				break;
			case Move.Left:
				_animatedSprite.FlipH = true;
				_animatedSprite.Play("walking");
				break;
			case Move.SideIdle:			
				_animatedSprite.Play("side_idle");
				break;
			default:

				break;
		}
	}

	public override void _Ready()
	{
		_animatedSprite = GetNode<AnimatedSprite>("GalileoAnimation");
	}

	public override void _Process(float _delta)
	{		
		HandleAnimationForMovementDirections();
	}
}
