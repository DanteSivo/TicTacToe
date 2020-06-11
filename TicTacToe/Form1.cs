using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        Game game = new Game();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (game.gameOver)
            {
                Console.WriteLine("Game is over");
            }
            else if (game.spaceEmpty(1))
            {
                if (game.player1Turn)
                {
                    // Place an X
                    Console.WriteLine("Player 1 placed an X in the bottom left");
                    button1.Image = Image.FromFile(@"C:\Users\Dante Sivo\source\repos\TicTacToe\TicTacToe\x-symbol.jpg");
                    game.takeSpace(1, 1);
                    game.checkPlayer1Win();
                    game.player1Turn = false; // It is now Player 2's turn
                }
                else
                {
                    // Place an O
                    Console.WriteLine("Player 2 placed an O in the bottom left");
                    button1.Image = Image.FromFile(@"C:\Users\Dante Sivo\source\repos\TicTacToe\TicTacToe\o-symbol.png");
                    game.takeSpace(2, 1);
                    game.checkPlayer2Win();
                    game.player1Turn = true; // It is now Player 1's turn
                }
            }
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (game.gameOver)
            {
                Console.WriteLine("Game is over");
            }
            else if (game.spaceEmpty(2))
            {
                if (game.player1Turn)
                {
                    // Place an X
                    Console.WriteLine("Player 1 placed an X in the bottom");
                    button2.Image = Image.FromFile(@"C:\Users\Dante Sivo\source\repos\TicTacToe\TicTacToe\x-symbol.jpg");
                    game.takeSpace(1, 2);
                    game.checkPlayer1Win();
                    game.player1Turn = false; // It is now Player 2's turn
                }
                else
                {
                    // Place an O
                    Console.WriteLine("Player 2 placed an O in the bottom");
                    button2.Image = Image.FromFile(@"C:\Users\Dante Sivo\source\repos\TicTacToe\TicTacToe\o-symbol.png");
                    game.takeSpace(2, 2);
                    game.checkPlayer2Win();
                    game.player1Turn = true; // It is now Player 1's turn
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (game.gameOver)
            {
                Console.WriteLine("Game is over");
            }
            else if (game.spaceEmpty(3))
            {
                if (game.player1Turn)
                {
                    // Place an X
                    Console.WriteLine("Player 1 placed an X in the bottom right");
                    button3.Image = Image.FromFile(@"C:\Users\Dante Sivo\source\repos\TicTacToe\TicTacToe\x-symbol.jpg");
                    game.takeSpace(1, 3);
                    game.checkPlayer1Win();
                    game.player1Turn = false; // It is now Player 2's turn
                }
                else
                {
                    // Place an O
                    Console.WriteLine("Player 2 placed an O in the bottom right");
                    button3.Image = Image.FromFile(@"C:\Users\Dante Sivo\source\repos\TicTacToe\TicTacToe\o-symbol.png");
                    game.takeSpace(2, 3);
                    game.checkPlayer2Win();
                    game.player1Turn = true; // It is now Player 1's turn
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (game.gameOver)
            {
                Console.WriteLine("Game is over");
            }
            else if (game.spaceEmpty(4))
            {
                if (game.player1Turn)
                {
                    // Place an X
                    Console.WriteLine("Player 1 placed an X in the middle left");
                    button4.Image = Image.FromFile(@"C:\Users\Dante Sivo\source\repos\TicTacToe\TicTacToe\x-symbol.jpg");
                    game.takeSpace(1, 4);
                    game.checkPlayer1Win();
                    game.player1Turn = false; // It is now Player 2's turn
                }
                else
                {
                    // Place an O
                    Console.WriteLine("Player 2 placed an O in the middle left");
                    button4.Image = Image.FromFile(@"C:\Users\Dante Sivo\source\repos\TicTacToe\TicTacToe\o-symbol.png");
                    game.takeSpace(2, 4);
                    game.checkPlayer2Win();
                    game.player1Turn = true; // It is now Player 1's turn
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (game.gameOver)
            {
                Console.WriteLine("Game is over");
            }
            else if (game.spaceEmpty(5))
            {
                if (game.player1Turn)
                {
                    // Place an X
                    Console.WriteLine("Player 1 placed an X in the center");
                    button5.Image = Image.FromFile(@"C:\Users\Dante Sivo\source\repos\TicTacToe\TicTacToe\x-symbol.jpg");
                    game.takeSpace(1, 5);
                    game.checkPlayer1Win();
                    game.player1Turn = false; // It is now Player 2's turn
                }
                else
                {
                    // Place an O
                    Console.WriteLine("Player 2 placed an O in the center");
                    button5.Image = Image.FromFile(@"C:\Users\Dante Sivo\source\repos\TicTacToe\TicTacToe\o-symbol.png");
                    game.takeSpace(2, 5);
                    game.checkPlayer2Win();
                    game.player1Turn = true; // It is now Player 1's turn
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (game.gameOver)
            {
                Console.WriteLine("Game is over");
            }
            else if (game.spaceEmpty(6))
            {
                if (game.player1Turn)
                {
                    // Place an X
                    Console.WriteLine("Player 1 placed an X in the middle right");
                    button6.Image = Image.FromFile(@"C:\Users\Dante Sivo\source\repos\TicTacToe\TicTacToe\x-symbol.jpg");
                    game.takeSpace(1, 6);
                    game.checkPlayer1Win();
                    game.player1Turn = false; // It is now Player 2's turn
                }
                else
                {
                    // Place an O
                    Console.WriteLine("Player 2 placed an O in the middle right");
                    button6.Image = Image.FromFile(@"C:\Users\Dante Sivo\source\repos\TicTacToe\TicTacToe\o-symbol.png");
                    game.takeSpace(2, 6);
                    game.checkPlayer2Win();
                    game.player1Turn = true; // It is now Player 1's turn
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (game.gameOver)
            {
                Console.WriteLine("Game is over");
            }
            else if (game.spaceEmpty(7))
            {
                if (game.player1Turn)
                {
                    // Place an X
                    Console.WriteLine("Player 1 placed an X in the upper left");
                    button7.Image = Image.FromFile(@"C:\Users\Dante Sivo\source\repos\TicTacToe\TicTacToe\x-symbol.jpg");
                    game.takeSpace(1, 7);
                    game.checkPlayer1Win();
                    game.player1Turn = false; // It is now Player 2's turn
                }
                else
                {
                    // Place an O
                    Console.WriteLine("Player 2 placed an O in the upper left");
                    button7.Image = Image.FromFile(@"C:\Users\Dante Sivo\source\repos\TicTacToe\TicTacToe\o-symbol.png");
                    game.takeSpace(2, 7);
                    game.checkPlayer2Win();
                    game.player1Turn = true; // It is now Player 1's turn
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (game.gameOver)
            {
                Console.WriteLine("Game is over");
            }
            else if (game.spaceEmpty(8))
            {
                if (game.player1Turn)
                {
                    // Place an X
                    Console.WriteLine("Player 1 placed an X in the upper middle");
                    button8.Image = Image.FromFile(@"C:\Users\Dante Sivo\source\repos\TicTacToe\TicTacToe\x-symbol.jpg");
                    game.takeSpace(1, 8);
                    game.checkPlayer1Win();
                    game.player1Turn = false; // It is now Player 2's turn
                }
                else
                {
                    // Place an O
                    Console.WriteLine("Player 2 placed an O in the upper middle");
                    button8.Image = Image.FromFile(@"C:\Users\Dante Sivo\source\repos\TicTacToe\TicTacToe\o-symbol.png");
                    game.takeSpace(2, 8);
                    game.checkPlayer2Win();
                    game.player1Turn = true; // It is now Player 1's turn
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (game.gameOver)
            {
                Console.WriteLine("Game is over");
            }
            else if (game.spaceEmpty(9))
            {
                if (game.player1Turn)
                {
                    // Place an X
                    Console.WriteLine("Player 1 placed an X in the upper right");
                    button9.Image = Image.FromFile(@"C:\Users\Dante Sivo\source\repos\TicTacToe\TicTacToe\x-symbol.jpg");
                    game.takeSpace(1, 9);
                    game.checkPlayer1Win();
                    game.player1Turn = false; // It is now Player 2's turn
                }
                else
                {
                    // Place an O
                    Console.WriteLine("Player 2 placed an O in the upper right");
                    game.takeSpace(2, 9);
                    button9.Image = Image.FromFile(@"C:\Users\Dante Sivo\source\repos\TicTacToe\TicTacToe\o-symbol.png");
                    game.checkPlayer2Win();
                    game.player1Turn = true; // It is now Player 1's turn
                }
            }
        }
    }

    public class Game
    {
        public bool player1Turn;
        private int xCount, oCount;
        public int[] xSpaces, oSpaces; // 9 possible moves over 5 and 4 turns per player
        public bool gameOver;

        public Game()
        {
            player1Turn = true;
            xCount = 0;
            oCount = 0;
            xSpaces = new int[5];
            oSpaces = new int[5];
            gameOver = false;
        }

        public void checkPlayer1Win ()
        {
            if (xCount >= 3) // Requries at least 3 spaces to win
            {
                for (int i = 0; i < xCount; i++)
                {
                    switch (xSpaces[i])
                    {
                        case 1: // Bottom Left
                            for (int j = 0; j < xCount; j++)
                            {
                                switch (xSpaces[j])
                                {
                                    case 4: // Center Left
                                        for (int k = 0; k < xCount; k++)
                                        {
                                            if (xSpaces[k] == 7)
                                            {
                                                player1Wins(new int[] { 1, 4, 7 });
                                                break;
                                            }
                                        }
                                        break;
                                    case 5: // Center
                                        for (int k = 0; k < xCount; k++)
                                        {
                                            if (xSpaces[k] == 9)
                                            {
                                                player1Wins(new int[] { 1, 5, 9 });
                                                break;
                                            }
                                        }
                                        break;
                                    case 2: // Bottom Right
                                        for (int k = 0; k < xCount; k++)
                                        {
                                            if (xSpaces[k] == 3)
                                            {
                                                player1Wins(new int[] { 1, 2, 3 });
                                                break;
                                            }
                                        }
                                        break;
                                }
                            }
                            break;
                        case 2:
                            for (int j = 0; j < xCount; j++)
                            {
                                switch (xSpaces[j])
                                {
                                    case 5: // Center
                                        for (int k = 0; k < xCount; k++)
                                        {
                                            if (xSpaces[k] == 8)
                                            {
                                                player1Wins(new int[] { 2, 5, 8 });
                                                break;
                                            }
                                        }
                                        break;
                                }
                            }
                            break;
                        case 3:
                            for (int j = 0; j < xCount; j++)
                            {
                                switch (xSpaces[j])
                                {
                                    case 4: // Center Left
                                        for (int k = 0; k < xCount; k++)
                                        {
                                            if (xSpaces[k] == 7)
                                            {
                                                player1Wins(new int[] { 1, 4, 7 });
                                                break;
                                            }
                                        }
                                        break;
                                    case 6: // Middle Right
                                        for (int k = 0; k < xCount; k++)
                                        {
                                            if (xSpaces[k] == 8)
                                            {
                                                player1Wins(new int[] { 3, 6, 8 });
                                                break;
                                            }
                                        }
                                        break;
                                }
                            }
                            break;
                        case 4:
                            for (int j = 0; j < xCount; j++)
                            {
                                switch (xSpaces[j])
                                {
                                    case 5: // Center
                                        for (int k = 0; k < xCount; k++)
                                        {
                                            if (xSpaces[k] == 6)
                                            {
                                                player1Wins(new int[] { 4, 5, 6 });
                                                break;
                                            }
                                        }
                                        break;
                                }
                            }
                            break;
                        case 7:
                            for (int j = 0; j < xCount; j++)
                            {
                                switch (xSpaces[j])
                                {
                                    case 8: // Top Center
                                        for (int k = 0; k < xCount; k++)
                                        {
                                            if (xSpaces[k] == 9)
                                            {
                                                player1Wins(new int[] { 7, 8, 9 });
                                                break;
                                            }
                                        }
                                        break;
                                }
                            }
                            break;
                    }
                }
            }
        }

        public void checkPlayer2Win ()
        {
            if (oCount >= 3) // Requries at least 3 spaces to win
            {
                for (int i = 0; i < oCount; i++)
                {
                    switch (oSpaces[i])
                    {
                        case 1: // Bottom Left
                            for (int j = 0; j < oCount; j++)
                            {
                                switch (oSpaces[j])
                                {
                                    case 4: // Center Left
                                        for (int k = 0; k < oCount; k++)
                                        {
                                            if (oSpaces[k] == 7)
                                            {
                                                player1Wins(new int[] { 1, 4, 7 });
                                                break;
                                            }
                                        }
                                        break;
                                    case 5: // Center
                                        for (int k = 0; k < oCount; k++)
                                        {
                                            if (oSpaces[k] == 9)
                                            {
                                                player1Wins(new int[] { 1, 5, 9 });
                                                break;
                                            }
                                        }
                                        break;
                                    case 2: // Bottom Right
                                        for (int k = 0; k < oCount; k++)
                                        {
                                            if (oSpaces[k] == 3)
                                            {
                                                player1Wins(new int[] { 1, 2, 3 });
                                                break;
                                            }
                                        }
                                        break;
                                }
                            }
                            break;
                        case 2:
                            for (int j = 0; j < oCount; j++)
                            {
                                switch (oSpaces[j])
                                {
                                    case 5: // Center
                                        for (int k = 0; k < oCount; k++)
                                        {
                                            if (oSpaces[k] == 8)
                                            {
                                                player1Wins(new int[] { 2, 5, 8 });
                                                break;
                                            }
                                        }
                                        break;
                                }
                            }
                            break;
                        case 3:
                            for (int j = 0; j < oCount; j++)
                            {
                                switch (xSpaces[j])
                                {
                                    case 4: // Center Left
                                        for (int k = 0; k < oCount; k++)
                                        {
                                            if (oSpaces[k] == 7)
                                            {
                                                player1Wins(new int[] { 1, 4, 7 });
                                                break;
                                            }
                                        }
                                        break;
                                    case 6: // Middle Right
                                        for (int k = 0; k < oCount; k++)
                                        {
                                            if (oSpaces[k] == 8)
                                            {
                                                player1Wins(new int[] { 3, 6, 8 });
                                                break;
                                            }
                                        }
                                        break;
                                }
                            }
                            break;
                        case 4:
                            for (int j = 0; j < oCount; j++)
                            {
                                switch (oSpaces[j])
                                {
                                    case 5: // Center
                                        for (int k = 0; k < oCount; k++)
                                        {
                                            if (oSpaces[k] == 6)
                                            {
                                                player1Wins(new int[] { 4, 5, 6 });
                                                break;
                                            }
                                        }
                                        break;
                                }
                            }
                            break;
                        case 7:
                            for (int j = 0; j < oCount; j++)
                            {
                                switch (oSpaces[j])
                                {
                                    case 8: // Top Center
                                        for (int k = 0; k < oCount; k++)
                                        {
                                            if (oSpaces[k] == 9)
                                            {
                                                player1Wins(new int[] { 7, 8, 9 });
                                                break;
                                            }
                                        }
                                        break;
                                }
                            }
                            break;
                    }
                }
            }
        }

        public void player1Wins (int[] winningSpaces)
        {
            Console.WriteLine("Player 1 Wins! Winning spaces were... " + winningSpaces[0] + " " +  winningSpaces[1] + " " + winningSpaces[2]);
            gameOver = true;
        }

        public void player2Wins (int[] winningSpaces)
        {
            Console.WriteLine("Player 2 Wins! Winning spaces were... " + winningSpaces[0] + " " + winningSpaces[1] + " " + winningSpaces[2]);
            gameOver = true;
        }

        public bool spaceEmpty(int spaceRequested)
        {
            for (int i = 0; i < xCount; i++) // Check if the space requested has been used by Player 1
            {
                if (xSpaces[i] == spaceRequested)
                {
                    Console.WriteLine("Space taken already by Player 1!");
                    return false;
                }
            }

            for (int i = 0; i < oCount; i++) // Check if the space requested has been used by Player 1
            {
                if (oSpaces[i] == spaceRequested)
                {
                    Console.WriteLine("Space taken already by Player 2!");
                    return false;
                }
            }
            return true;
        }

        public void takeSpace(int player, int space)
        {
            if (player == 1)
            {
                xSpaces[xCount] = space; xCount++;
            } else if (player == 2)
            {
                oSpaces[oCount] = space; oCount++;
            } else
            {
                Console.WriteLine("ERROR: Unkown player?!?");
            }
        }
    }
}
