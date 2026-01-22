using Godot;
using System;



public partial class Menu : Control
{
	public void OnPressed() {
		GetTree().ChangeSceneToFile("res://Scenes/Level.tscn");
		
	}
	public void SoundPressed() {
	GetTree().ChangeSceneToFile("res://Scenes/sound.tscn");
	}
}
