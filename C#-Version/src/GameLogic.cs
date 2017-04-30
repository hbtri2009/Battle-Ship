
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

		//Game Loop
		do {
			if (SwinGame.KeyTyped (KeyCode.vk_m)) 
  			{
 				SwinGame.SetMusicVolume (0);
			}
 			if (SwinGame.KeyTyped (KeyCode.vk_u))
 			{
 				SwinGame.SetMusicVolume(1);
  			}

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
