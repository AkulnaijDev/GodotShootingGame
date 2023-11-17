using Godot;
using System;

public partial class Gun : Node2D
{
    [Export] PackedScene bullet_scn;
    [Export] public float bullet_speed = 900f;
    [Export] float bps = 5;  //quanti bullet assieme
    [Export] float bullet_damage = 30f;

    float fire_rate;
    float time_until_fire = 0f;

    public override void _Ready()
    {
        fire_rate = 1 / bps;
    }

    public override void _Process(double delta)
    {
        if (Input.IsActionJustPressed("Shoot") && time_until_fire > fire_rate) 
        {
            RigidBody2D bullet = bullet_scn.Instantiate<RigidBody2D>();
            bullet.Rotation = GlobalRotation;
            bullet.GlobalPosition= GlobalPosition;
            bullet.LinearVelocity = bullet.Transform.X * bullet_speed;

            GetTree().Root.AddChild(bullet);

            time_until_fire = 0f;
        } 
        else
        {
            time_until_fire += (float)delta;
        }
    }
}
