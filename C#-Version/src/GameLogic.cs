
//using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
//using System.Data;
using System.Diagnostics;
using SwinGameSDK;

static class GameLogic
{
	static double currentVolume = 1.0;

	public static void Main()
	{
		//Opens a new Graphics Window
		SwinGame.OpenGraphicsWindow("Battle Ships", 800, 600);

		//Load Resources
		GameResources.LoadResources();

		SwinGame.PlayMusic(GameResources.GameMusic("Background"));

		bool isMuted = false;

		//Game Loop
		do {
			if (SwinGame.KeyTyped (KeyCode.vk_m)) {
				isMuted = !isMuted;
				if (isMuted)
					SwinGame.SetMusicVolume (0);
				else
					SwinGame.SetMusicVolume (1);
			}

			if (SwinGame.KeyTyped (KeyCode.vk_KP_PLUS)) {
				if (currentVolume < 1.0) {
					currentVolume = currentVolume + 0.1;
				}
				SwinGame.SetMusicVolume ((float)currentVolume);

			}
			if (SwinGame.KeyTyped (KeyCode.vk_KP_MINUS)) {
				if (currentVolume > 0.0) {
					currentVolume = currentVolume - 0.1;
				}
				SwinGame.SetMusicVolume ((float)currentVolume);
			}

			GameController.HandleUserInput();
			GameController.DrawScreen();
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
