
//using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
//using System.Data;
using System.Diagnostics;
using SwinGameSDK;

static class GameLogic
{
	static int currentVolume;
	static float volume;
	public static void Main()
	{
		currentVolume = 1;
		//Opens a new Graphics Window
		SwinGame.OpenGraphicsWindow("Battle Ships", 800, 600);

		//Load Resources
		GameResources.LoadResources();

		SwinGame.PlayMusic(GameResources.GameMusic("Background"));

		//Game Loop
		do {
			GameController.HandleUserInput ();
			GameController.DrawScreen ();
		//Music volume controll
			if (SwinGame.KeyTyped (KeyCode.vk_m)) 
			{
				SwinGame.SetMusicVolume (0);
			}
			if (SwinGame.KeyTyped (KeyCode.vk_UP)) 
				{
				if (currentVolume < 10)
					{
						currentVolume = currentVolume + 1;
						volume = currentVolume / 10;
					}

				SwinGame.SetMusicVolume (volume);
				}
			if (SwinGame.KeyTyped (KeyCode.vk_DOWN)) 
				{
				if (currentVolume > 0)
					{
						currentVolume = currentVolume - 1;
						volume = currentVolume / 10;
					}

				SwinGame.SetMusicVolume (volume);
				}
		} while (!(SwinGame.WindowCloseRequested() == true | GameController.CurrentState == GameState.Quitting));

		SwinGame.StopMusic();

		//Free Resources and Close Audio, to end the program.
		GameResources.FreeResources();
	}
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
