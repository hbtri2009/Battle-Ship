//using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
//using System.Data;
using System.Diagnostics;
using System.IO;
using SwinGameSDK;

static class GameInstructionsController
{
	public static void DrawInstructions ()
	{
		const int INTRUCTIONS_LEFT = 10;
		const int INTRUCTIONS_GAP = 20;
		const int INTRUCTIONS_HEADING = 150;
		
		SwinGame.FillRectangle(Color.Black, 0, 130, 800, 400);
		SwinGame.DrawText ("Instruction", Color.White, GameResources.GameFont ("Courier"), INTRUCTIONS_LEFT, INTRUCTIONS_HEADING);
		SwinGame.DrawText ("How to play", Color.White, GameResources.GameFont ("Courier"), INTRUCTIONS_LEFT, INTRUCTIONS_HEADING + INTRUCTIONS_GAP * 2);
		SwinGame.DrawText ("1/Select difficulty", Color.White, GameResources.GameFont ("Courier"), INTRUCTIONS_LEFT, INTRUCTIONS_HEADING + INTRUCTIONS_GAP * 4);
		SwinGame.DrawText ("2/Place the ship (or you can click the random button to automatically place your ships randomly", Color.White, GameResources.GameFont ("Courier"), INTRUCTIONS_LEFT, INTRUCTIONS_HEADING + INTRUCTIONS_GAP * 5);
		SwinGame.DrawText ("3/Players take turn to shoot each other ships", Color.White, GameResources.GameFont ("Courier"), INTRUCTIONS_LEFT, INTRUCTIONS_HEADING + INTRUCTIONS_GAP * 6);
		SwinGame.DrawText ("  You get one more shot if you hit the enemy team untill you miss your shot", Color.White, GameResources.GameFont ("Courier"), INTRUCTIONS_LEFT, INTRUCTIONS_HEADING + INTRUCTIONS_GAP * 7);
		SwinGame.DrawText ("  Each ship has different length", Color.White, GameResources.GameFont ("Courier"), INTRUCTIONS_LEFT, INTRUCTIONS_HEADING + INTRUCTIONS_GAP * 8);
		SwinGame.DrawText ("  For example if the ship is 4 square long then you need to hit all 4 square to sink the ship", Color.White, GameResources.GameFont ("Courier"), INTRUCTIONS_LEFT, INTRUCTIONS_HEADING + INTRUCTIONS_GAP * 9);
		SwinGame.DrawText ("  The first one to sink all the enemy's ships win", Color.White, GameResources.GameFont ("Courier"), INTRUCTIONS_LEFT, INTRUCTIONS_HEADING + INTRUCTIONS_GAP * 10);
		SwinGame.DrawText ("Game Controller", Color.White, GameResources.GameFont ("Courier"), INTRUCTIONS_LEFT, INTRUCTIONS_HEADING + INTRUCTIONS_GAP * 12);
		SwinGame.DrawText ("M to mute the music", Color.White, GameResources.GameFont ("Courier"), INTRUCTIONS_LEFT, INTRUCTIONS_HEADING + INTRUCTIONS_GAP * 14);
		SwinGame.DrawText ("U to unmute the music", Color.White, GameResources.GameFont ("Courier"), INTRUCTIONS_LEFT, INTRUCTIONS_HEADING + INTRUCTIONS_GAP * 15);
		SwinGame.DrawText ("UP ARROW or DOWN ARROW to place your ship vertically", Color.White, GameResources.GameFont ("Courier"), INTRUCTIONS_LEFT, INTRUCTIONS_HEADING + INTRUCTIONS_GAP * 16);
		SwinGame.DrawText ("LEFT ARROW or RIGHT ARROW to place your ship horizontally ", Color.White, GameResources.GameFont ("Courier"), INTRUCTIONS_LEFT, INTRUCTIONS_HEADING + INTRUCTIONS_GAP * 17);



		SwinGame.RefreshScreen ();

	}

	public static void HandleInstructionsInput ()
	{
		if (SwinGame.MouseClicked (MouseButton.LeftButton) || SwinGame.KeyTyped (KeyCode.vk_ESCAPE) || SwinGame.KeyTyped (KeyCode.vk_RETURN)) 
		{
			GameController.EndCurrentState ();
		}
	}
}
