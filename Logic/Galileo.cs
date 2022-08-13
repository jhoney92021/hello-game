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
			case Move.Down	:
			case Move.Right:
				_animatedSprite.FlipH = false;
				_animatedSprite.Play("walking");
				break;
			case Move.Left:
				_animatedSprite.FlipH = true;
				_animatedSprite.Play("walking");
				break;
			default:
				_animatedSprite.Play("idle");
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