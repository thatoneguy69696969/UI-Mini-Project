using Godot;
using System;

public partial class PauseMenu : Control
{
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("escape"))
		{
			GetTree().Paused=!GetTree().Paused;
		}
	}

	public void Resume()
	{
		GetTree().Paused = false;
		
	}

	public void Pause()
	{
		GetTree().Paused = true;
	}
}
