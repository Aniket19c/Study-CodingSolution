using System;

class SnakeLadderGame
{
    static Random rng = new Random();
    static int[] gameBoard = new int[101];
    static int alicePosition = 0, bobPosition = 0;
    static int aliceRollCount = 0, bobRollCount = 0;

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
        bool isAliceTurn = true;
        while (alicePosition < 100 && bobPosition < 100)
        {
            if (isAliceTurn)
            {
                aliceRollCount++;
                alicePosition = MovePlayer(alicePosition, "Alice");
                if (alicePosition == 100) break;
            }
            else
            {
                bobRollCount++;
                bobPosition = MovePlayer(bobPosition, "Bob");
                if (bobPosition == 100) break;
            }
            isAliceTurn = !isAliceTurn;
        }

        Console.WriteLine(alicePosition == 100 ? "Alice wins!" : "Bob wins!");
        Console.WriteLine($"Alice Rolls: {aliceRollCount}, Bob Rolls: {bobRollCount}");
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
