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
		const int INTRUCTIONS_GAP = 100;
		const int INTRUCTIONS_HEADING = 40;

		UtilityFunctions.DrawBackground ();
		SwinGame.DrawText ("   High Scores   ", Color.White, GameResources.GameFont ("Courier"), INTRUCTIONS_LEFT, INTRUCTIONS_HEADING);
		SwinGame.DrawText ("   How To Play   ", Color.White, GameResources.GameFont ("Courier"), INTRUCTIONS_LEFT, INTRUCTIONS_HEADING + 2 * INTRUCTIONS_GAP);
		SwinGame.DrawText ("   1/ Select difficulty   ", Color.White, GameResources.GameFont ("Courier"), INTRUCTIONS_LEFT, INTRUCTIONS_HEADING + 3 * INTRUCTIONS_GAP);
		SwinGame.DrawText ("   2/ Place all the ships (or you can click the random button to randomly place your ships)", Color.White, GameResources.GameFont ("Courier"), INTRUCTIONS_LEFT, INTRUCTIONS_HEADING + 5 * INTRUCTIONS_GAP);
		SwinGame.DrawText ("   3/ The players take turn to fire   ", Color.White, GameResources.GameFont ("Courier"), INTRUCTIONS_LEFT, INTRUCTIONS_HEADING + 6 * INTRUCTIONS_GAP);
		SwinGame.DrawText ("      If you hit the enemy's ship you get one more shot until you miss the shot then the next turn will be the enemy's turn.   ", Color.White, GameResources.GameFont ("Courier"), INTRUCTIONS_LEFT, INTRUCTIONS_HEADING + 7 * INTRUCTIONS_GAP);
		SwinGame.DrawText ("      Each ship has different length   ", Color.White, GameResources.GameFont ("Courier"), INTRUCTIONS_LEFT, INTRUCTIONS_HEADING + 8 * INTRUCTIONS_GAP);
		SwinGame.DrawText ("      For example if the ship is 4 square long you have to hit all 4 square to sink that ship   ", Color.White, GameResources.GameFont ("Courier"), INTRUCTIONS_LEFT, INTRUCTIONS_HEADING + 9 * INTRUCTIONS_GAP);
		SwinGame.DrawText ("      The first one to sink all the enemy ships win   ", Color.White, GameResources.GameFont ("Courier"), INTRUCTIONS_LEFT, INTRUCTIONS_HEADING + 10 * INTRUCTIONS_GAP);
		SwinGame.DrawText ("   Game controller   ", Color.White, GameResources.GameFont ("Courier"), INTRUCTIONS_LEFT, INTRUCTIONS_HEADING + 12 * INTRUCTIONS_GAP);
		SwinGame.DrawText ("   M to mute the music   ", Color.White, GameResources.GameFont ("Courier"), INTRUCTIONS_LEFT, INTRUCTIONS_HEADING + 14 * INTRUCTIONS_GAP);
		SwinGame.DrawText ("   U to unmute the music   ", Color.White, GameResources.GameFont ("Courier"), INTRUCTIONS_LEFT, INTRUCTIONS_HEADING + 15 * INTRUCTIONS_GAP);
		SwinGame.DrawText ("   UP ARROW or DOWN ARROW to rotate the ship vertically   ", Color.White, GameResources.GameFont ("Courier"), INTRUCTIONS_LEFT, INTRUCTIONS_HEADING + 16 * INTRUCTIONS_GAP);
		SwinGame.DrawText ("   LEFT ARROW OR RIGHT ARROW to rotate the ship horizontally   ", Color.White, GameResources.GameFont ("Courier"), INTRUCTIONS_LEFT, INTRUCTIONS_HEADING + 17 * INTRUCTIONS_GAP);
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
