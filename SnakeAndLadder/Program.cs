using System;

class SnakeLadderGame
{
    static Random rng = new Random();
    static int[] gameBoard = new int[101];
    static int p1Position = 0, p2Position = 0;
    static int p1RollCount = 0, p2RollCount = 0;

    static void Main()
    {
        SetupBoard();
        StartGame();
    }

    static void SetupBoard()
    {
        gameBoard[3] = 22; gameBoard[5] = 8; gameBoard[11] = 26; gameBoard[20] = 29;
        gameBoard[27] = 56; gameBoard[39] = 60; gameBoard[50] = 66; gameBoard[53] = 76;
        gameBoard[63] = 81; gameBoard[70] = 92;

        gameBoard[17] = 4; gameBoard[19] = 7; gameBoard[21] = 9; gameBoard[27] = 1;
        gameBoard[54] = 34; gameBoard[62] = 18; gameBoard[64] = 60; gameBoard[87] = 24;
        gameBoard[93] = 73; gameBoard[95] = 75; gameBoard[99] = 78;
    }

    static void StartGame()
    {
        bool isP1Turn = true;
        while (p1Position < 100 && p2Position < 100)
        {
            if (isP1Turn)
            {
                p1RollCount++;
                p1Position = MovePlayer(p1Position, "Player 1");
                if (p1Position == 100) break;
            }
            else
            {
                p2RollCount++;
                p2Position = MovePlayer(p2Position, "Player 2");
                if (p2Position == 100) break;
            }
            isP1Turn = !isP1Turn;
        }

        Console.WriteLine(p1Position == 100 ? "Player 1 wins!" : "Player 2 wins!");
        Console.WriteLine($"Player 1 Rolls: {p1RollCount}, Player 2 Rolls: {p2RollCount}");
    }

    static int MovePlayer(int currentPos, string playerName)
    {
        int diceRoll = rng.Next(1, 7);
        Console.WriteLine($"{playerName} rolled a {diceRoll}");

        int nextPos = currentPos + diceRoll;
        if (nextPos > 100)
        {
            Console.WriteLine($"{playerName} stays at {currentPos} (needs exact roll to win)");
            return currentPos;
        }

        if (gameBoard[nextPos] != 0)
        {
            string eventType = gameBoard[nextPos] > nextPos ? "Ladder!" : "Snake!";
            Console.WriteLine($"{playerName} encountered a {eventType}, moving to {gameBoard[nextPos]}");
            nextPos = gameBoard[nextPos];
        }

        Console.WriteLine($"{playerName} moves to {nextPos}\n");
        return nextPos;
    }
}