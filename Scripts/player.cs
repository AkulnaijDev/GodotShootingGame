using Godot;
using System;

public partial class player : CharacterBody2D
{
    [Export] public float speed = 300f;
    public override void _PhysicsProcess(double delta)
    {
        LookAt(GetGlobalMousePosition());

        Vector2 move_input = Input.GetVector("Left","Right","Up","Down");
        Velocity = move_input * speed;
        MoveAndSlide();
    }
}
