Module GameLogic
    Public Sub Main()
        'Opens a new Graphics Window
        SwinGame.OpenGraphicsWindow("Battle Ships", 800, 600)

        'Load Resources
        LoadResources()

        SwinGame.PlayMusic(GameMusic("Background"))

        'Game Loop
        Do
            HandleUserInput()
            DrawScreen()
        Loop Until SwinGame.WindowCloseRequested() = True Or CurrentState = GameState.Quitting
        
        //TODO: (Stop the music) when user play the game, the sound still playing.
        SwinGame.StopMusic()

        'Free Resources and Close Audio, to end the program.
        FreeResources()
    End Sub
End Module
