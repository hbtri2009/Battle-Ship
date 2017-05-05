
//using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
//using System.Data;
using System.Diagnostics;
using SwinGameSDK;

/// <summary>
/// The battle phase is handled by the DiscoveryController.
/// </summary>
static class DiscoveryController
{

	/// <summary>
	/// Handles input during the discovery phase of the game.
	/// </summary>
	/// <remarks>
	/// Escape opens the game menu. Clicking the mouse will
	/// attack a location.
	/// </remarks>
	public static void HandleDiscoveryInput()
	{
		if (SwinGame.KeyTyped(KeyCode.vk_ESCAPE)) {
			GameController.AddNewState(GameState.ViewingGameMenu);
		}

		if (SwinGame.MouseClicked(MouseButton.LeftButton)) {
			DoAttack();
		}
	}



	/// <summary>
	/// Attack the location that the mouse if over.
	/// </summary>
	private static void DoAttack()
	{
		Point2D mouse = default(Point2D);

		mouse = SwinGame.MousePosition();

		//Calculate the row/col clicked
		int row = 0;
		int col = 0;
		row = Convert.ToInt32(Math.Floor((mouse.Y - UtilityFunctions.FIELD_TOP) / (UtilityFunctions.CELL_HEIGHT + UtilityFunctions.CELL_GAP)));
		col = Convert.ToInt32(Math.Floor((mouse.X - UtilityFunctions.FIELD_LEFT) / (UtilityFunctions.CELL_WIDTH + UtilityFunctions.CELL_GAP)));

		if (row >= 0 & row < GameController.HumanPlayer.EnemyGrid.Height) {
			if (col >= 0 & col < GameController.HumanPlayer.EnemyGrid.Width) {
				GameController.Attack(row, col);
			}
		}
	}

	/// <summary>
	/// Draws the game during the attack phase.
	/// </summary>s
	public static void DrawDiscovery()
	{
		const int SCORES_LEFT = 172;
		const int SHOTS_TOP = 157;
		const int HITS_TOP = 206;
		const int SPLASH_TOP = 256;

		if (SwinGame.KeyDown(KeyCode.vk_c)) {
			UtilityFunctions.DrawField(GameController.HumanPlayer.EnemyGrid, GameController.ComputerPlayer, true);
		} else {
			UtilityFunctions.DrawField(GameController.HumanPlayer.EnemyGrid, GameController.ComputerPlayer, false);
		}

		UtilityFunctions.DrawSmallField(GameController.HumanPlayer.PlayerGrid, GameController.HumanPlayer);
		UtilityFunctions.DrawMessage();

		SwinGame.DrawText(GameController.HumanPlayer.Shots.ToString(), Color.White, GameResources.GameFont("Menu"), SCORES_LEFT, SHOTS_TOP);
		SwinGame.DrawText(GameController.HumanPlayer.Hits.ToString(), Color.White, GameResources.GameFont("Menu"), SCORES_LEFT, HITS_TOP);
		SwinGame.DrawText(GameController.HumanPlayer.Missed.ToString(), Color.White, GameResources.GameFont("Menu"), SCORES_LEFT, SPLASH_TOP);

		if (SwinGame.KeyDown (KeyCode.vk_r))
        {

			//RESET SCORES:
            GameController.HumanPlayer.ResetScore();
			//RESET HITS:
            int _resethits = GameController.HumanPlayer.ResetHits();
            SwinGame.DrawText(_resethits.ToString(), Color.White, GameResources.GameFont("Menu"), SCORES_LEFT, HITS_TOP);
			//RESET MISSES:
            int _resetmisses = GameController.HumanPlayer.ResetMissed();
            SwinGame.DrawText(_resetmisses.ToString(), Color.White, GameResources.GameFont("Menu"), SCORES_LEFT, SPLASH_TOP);
			//RESET SHOTS: 
            int _resetshots = GameController.HumanPlayer.ResetShots();
            SwinGame.DrawText(_resetshots.ToString(), Color.White, GameResources.GameFont("Menu"), SCORES_LEFT, SHOTS_TOP);
            //
            GameController.ComputerPlayer.ResetHits();
            GameController.ComputerPlayer.ResetShots();
            GameController.ComputerPlayer.ResetMissed();
            GameController.ComputerPlayer.ResetScore();
			//RESET SEAGRID: SeaGrid.cs
            //RESET ATTACK RESULT

        

            GameController.ComputerPlayer.PlayerGrid.ResetShipKilled();
            
            
            Tile _tile1 = new Tile(GameController.HumanPlayer.Ship(ShipName.AircraftCarrier).Row, GameController.HumanPlayer.Ship(ShipName.AircraftCarrier).Column, GameController.HumanPlayer.Ship(ShipName.AircraftCarrier));
            Tile _tile2 = new Tile(GameController.HumanPlayer.Ship(ShipName.Battleship).Row, GameController.HumanPlayer.Ship(ShipName.Battleship).Column, GameController.HumanPlayer.Ship(ShipName.Battleship));
            Tile _tile3 = new Tile(GameController.HumanPlayer.Ship(ShipName.Destroyer).Row, GameController.HumanPlayer.Ship(ShipName.Destroyer).Column, GameController.HumanPlayer.Ship(ShipName.Destroyer));
            Tile _tile4 = new Tile(GameController.HumanPlayer.Ship(ShipName.Submarine).Row, GameController.HumanPlayer.Ship(ShipName.Submarine).Column, GameController.HumanPlayer.Ship(ShipName.Submarine));
            Tile _tile5 = new Tile(GameController.HumanPlayer.Ship(ShipName.Tug).Row, GameController.HumanPlayer.Ship(ShipName.Tug).Column, GameController.HumanPlayer.Ship(ShipName.Tug));

            _tile1.ResetTileShot();
            _tile2.ResetTileShot();
            _tile3.ResetTileShot();
            _tile4.ResetTileShot();
            _tile5.ResetTileShot();

            _tile1.ResetView();
            _tile2.ResetView();
            _tile3.ResetView();
            _tile4.ResetView();
            _tile5.ResetView();


            Tile _tile6 = new Tile(GameController.ComputerPlayer.Ship(ShipName.AircraftCarrier).Row, GameController.ComputerPlayer.Ship(ShipName.AircraftCarrier).Column, GameController.ComputerPlayer.Ship(ShipName.AircraftCarrier));
            Tile _tile7 = new Tile(GameController.ComputerPlayer.Ship(ShipName.Battleship).Row, GameController.ComputerPlayer.Ship(ShipName.Battleship).Column, GameController.ComputerPlayer.Ship(ShipName.Battleship));
            Tile _tile8 = new Tile(GameController.ComputerPlayer.Ship(ShipName.Destroyer).Row, GameController.ComputerPlayer.Ship(ShipName.Destroyer).Column, GameController.ComputerPlayer.Ship(ShipName.Destroyer));
            Tile _tile9 = new Tile(GameController.ComputerPlayer.Ship(ShipName.Submarine).Row, GameController.ComputerPlayer.Ship(ShipName.Submarine).Column, GameController.ComputerPlayer.Ship(ShipName.Submarine));
            Tile _tile10 = new Tile(GameController.ComputerPlayer.Ship(ShipName.Tug).Row, GameController.ComputerPlayer.Ship(ShipName.Tug).Column, GameController.ComputerPlayer.Ship(ShipName.Tug));

            _tile6.ResetTileShot();
            _tile7.ResetTileShot();
            _tile8.ResetTileShot();
            _tile9.ResetTileShot();
            _tile10.ResetTileShot();

            _tile6.ResetView();
            _tile7.ResetView();
            _tile8.ResetView();
            _tile9.ResetView();
            _tile10.ResetView();

            GameController.HumanPlayer.Ship(ShipName.AircraftCarrier).ResetShipHits();
            GameController.HumanPlayer.Ship(ShipName.Battleship).ResetShipHits();
            GameController.HumanPlayer.Ship(ShipName.Destroyer).ResetShipHits();
            GameController.HumanPlayer.Ship(ShipName.Submarine).ResetShipHits();
            GameController.HumanPlayer.Ship(ShipName.Tug).ResetShipHits();
            GameController.ComputerPlayer.Ship(ShipName.AircraftCarrier).ResetShipHits();
            GameController.ComputerPlayer.Ship(ShipName.Battleship).ResetShipHits();
            GameController.ComputerPlayer.Ship(ShipName.Destroyer).ResetShipHits();
            GameController.ComputerPlayer.Ship(ShipName.Submarine).ResetShipHits();
            GameController.ComputerPlayer.Ship(ShipName.Tug).ResetShipHits();

            GameController.HumanPlayer.Ship(ShipName.AircraftCarrier).ResetIsDestroyeddd();
            GameController.HumanPlayer.Ship(ShipName.Battleship).ResetIsDestroyeddd();
            GameController.HumanPlayer.Ship(ShipName.Destroyer).ResetIsDestroyeddd();
            GameController.HumanPlayer.Ship(ShipName.Submarine).ResetIsDestroyeddd();
            GameController.HumanPlayer.Ship(ShipName.Tug).ResetIsDestroyeddd();
            GameController.ComputerPlayer.Ship(ShipName.AircraftCarrier).ResetIsDestroyeddd();
            GameController.ComputerPlayer.Ship(ShipName.Battleship).ResetIsDestroyeddd();
            GameController.ComputerPlayer.Ship(ShipName.Destroyer).ResetIsDestroyeddd();
            GameController.ComputerPlayer.Ship(ShipName.Submarine).ResetIsDestroyeddd();
            GameController.ComputerPlayer.Ship(ShipName.Tug).ResetIsDestroyeddd();


		}
        SeaGridAdapter _seagrid = new SeaGridAdapter(GameController.HumanPlayer.PlayerGrid);

        UtilityFunctions.DrawCustomField(_seagrid, GameController.HumanPlayer, false, false, UtilityFunctions.FIELD_LEFT, UtilityFunctions.FIELD_TOP, UtilityFunctions.FIELD_WIDTH, UtilityFunctions.FIELD_HEIGHT, UtilityFunctions.CELL_WIDTH, UtilityFunctions.CELL_HEIGHT,
UtilityFunctions.CELL_GAP);

        UtilityFunctions.DrawSmallField(_seagrid, GameController.HumanPlayer);
	}

}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
