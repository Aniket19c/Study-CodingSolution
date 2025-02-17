using System;

class SnakeLadderGame
{
    static Random random = new Random();
    static int[] board = new int[101];
    static int player1Pos = 0, player2Pos = 0;
    static int player1Rolls = 0, player2Rolls = 0;

    static void Main()
    {
        InitializeBoard();
        PlayGame();
    }

    static void InitializeBoard()
    {
        
        board[3] = 22; board[5] = 8; board[11] = 26; board[20] = 29;
        board[27] = 56; board[39] = 60; board[50] = 66; board[53] = 76;
        board[63] = 81; board[70] = 92;

        board[17] = 4; board[19] = 7; board[21] = 9; board[27] = 1;
        board[54] = 34; board[62] = 18; board[64] = 60; board[87] = 24;
        board[93] = 73; board[95] = 75; board[99] = 78;
    }

    static void PlayGame()
    {
        bool player1Turn = true;
        while (player1Pos < 100 && player2Pos < 100)
        {
            if (player1Turn)
            {
                player1Rolls++;
                player1Pos = MovePlayer(player1Pos, "Player 1");
                if (player1Pos == 100) break;
            }
            else
            {
                player2Rolls++;
                player2Pos = MovePlayer(player2Pos, "Player 2");
                if (player2Pos == 100) break;
            }
            player1Turn = !player1Turn;
        }

        Console.WriteLine(player1Pos == 100 ? "Player 1 wins!" : "Player 2 wins!");
        Console.WriteLine($"Player 1 Rolls: {player1Rolls}, Player 2 Rolls: {player2Rolls}");
    }

    static int MovePlayer(int position, string player)
    {
        int diceRoll = random.Next(1, 7);
        Console.WriteLine($"{player} rolled a {diceRoll}");

        int newPosition = position + diceRoll;
        if (newPosition > 100)
        {
            Console.WriteLine($"{player} stays at {position} (needs exact roll to win)");
            return position;
        }

        if (board[newPosition] != 0)
        {
            string action = board[newPosition] > newPosition ? "Ladder!" : "Snake!";
            Console.WriteLine($"{player} encountered a {action}, moving to {board[newPosition]}");
            newPosition = board[newPosition];
        }

        Console.WriteLine($"{player} moves to {newPosition}\n");
        return newPosition;
    }
}
