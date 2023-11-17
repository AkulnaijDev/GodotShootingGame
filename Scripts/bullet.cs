using Godot;
using System;

public partial class bullet : RigidBody2D
{
    public override void _Ready()
    {
        Timer timer = GetNode<Timer>("Timer");
        timer.Timeout += () => QueueFree();
    }
}
