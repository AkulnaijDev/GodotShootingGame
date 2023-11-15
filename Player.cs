using Godot;
using System;

public partial class Player : CharacterBody2D
{

	[Export]
	public int Speed { get; set; } = 400;

	public void GetInput()
	{
 		LookAt(GetGlobalMousePosition());
		Vector2 inputDirection = Input.GetVector("Left", "Right", "Up", "Down");
		Velocity = inputDirection * Speed;
	}

	public override void _PhysicsProcess(double delta)
	{
		GetInput();
		MoveAndSlide();
	}
	


}
