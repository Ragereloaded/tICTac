using System.Windows;

namespace TicTacToe2
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int player = 2;
        int error;

        private int playerHasWon;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TicTacToe()
        {

            SwitchPlayer();
        }

        private void CheckWin()
        {
            //Horizontal
            if (A100.Content == A010.Content && A100.Content == A001.Content)
            {
                if (A100.Content == "X")
                {
                    playerHasWon = 1;
                    LabelWinner.Content = "X";
                }
                else if (A100.Content == "O")
                {
                    playerHasWon = 2;
                    LabelWinner.Content = "O";
                }
            }
            else if (B100.Content == B010.Content && B100.Content == B001.Content)
            {
                if (B100.Content == "X")
                {
                    playerHasWon = 1;
                    LabelWinner.Content = "X";
                }
                else if (B100.Content == "O")
                {
                    playerHasWon = 2;
                    LabelWinner.Content = "O";
                }
            }
            else if (C100.Content == C010.Content && C100.Content == C001.Content)
            {
                if (C100.Content == "X")
                {
                    playerHasWon = 1;
                    LabelWinner.Content = "X";
                }
                else if (C100.Content == "O")
                {
                    playerHasWon = 2;
                    LabelWinner.Content = "O";
                }
            }
            //Vertical
            else if (A100.Content == B100.Content && A100.Content == C100.Content)
            {
                if (A100.Content == "X")
                {
                    playerHasWon = 1;
                    LabelWinner.Content = "X";
                }
                else if (A100.Content == "O")
                {
                    playerHasWon = 2;
                    LabelWinner.Content = "O";
                }
            }
            else if (A010.Content == B010.Content && A010.Content == C010.Content)
            {
                if (A010.Content == "X")
                {
                    playerHasWon = 1;
                    LabelWinner.Content = "X";
                }
                else if (A010.Content == "O")
                {
                    playerHasWon = 2;
                    LabelWinner.Content = "O";
                }
            }
            else if (A001.Content == B001.Content && A001.Content == C001.Content)
            {
                if (A001.Content == "X")
                {
                    playerHasWon = 1;
                    LabelWinner.Content = "X";
                }
                else if (A001.Content == "O")
                {
                    playerHasWon = 2;
                    LabelWinner.Content = "O";
                }
            }
            //Diagonal
            else if (A100.Content == B010.Content && A100.Content == C001.Content)
            {
                if (A100.Content == "X")
                {
                    playerHasWon = 1;
                    LabelWinner.Content = "X";
                }
                else if (A100.Content == "O")
                {
                    playerHasWon = 2;
                    LabelWinner.Content = "O";
                }
            }
            else if (A001.Content == B010.Content && A001.Content == C100.Content)
            {
                if (A001.Content == "X")
                {
                    playerHasWon = 1;
                    LabelWinner.Content = "X";
                }
                else if (A001.Content == "O")
                {
                    playerHasWon = 2;
                    LabelWinner.Content = "O";
                }
            }
        }

        private int SwitchPlayer()
        {

            switch (player)
            {
                case 1:
  	                player = 2;
                    return player;
                case 2:
  	                player = 1;
                    return player;
                default:
                    return error;
            }



        }

        

        //RestartButton
        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        //FieldButtons
        //A Section
        private void A100_Click(object sender, RoutedEventArgs e)
        {
            if (player == 1)
            {
                A100.Content = "X";
                TicTacToe();
            }
            if (player == 2)
            {
                A100.Content = "O";
                TicTacToe();
            }
        }

        private void A010_Click(object sender, RoutedEventArgs e)
        {
            if (player == 1)
            {
                A010.Content = "X";
                TicTacToe();
            }
            if (player == 2)
            {
                A010.Content = "O";
                TicTacToe();
            }
        }

        private void A001_Click(object sender, RoutedEventArgs e)
        {
            if (player == 1)
            {
                A001.Content = "X";
                TicTacToe();
            }
            if (player == 2)
            {
                A001.Content = "O";
                TicTacToe();
            }
        }

        //B Section
        private void B100_Click(object sender, RoutedEventArgs e)
        {
            if (player == 1)
            {
                B100.Content = "X";
                TicTacToe();
            }
            if (player == 2)
            {
                B100.Content = "O";
                TicTacToe();
            }
        }

        private void B010_Click(object sender, RoutedEventArgs e)
        {
            if (player == 1)
            {
                B010.Content = "X";
                TicTacToe();
            }
            if (player == 2)
            {
                B010.Content = "O";
                TicTacToe();
            }
        }

        private void B001_Click(object sender, RoutedEventArgs e)
        {
            if (player == 1)
            {
                B001.Content = "X";
                TicTacToe();
            }
            if (player == 2)
            {
                B001.Content = "O";
                TicTacToe();
            }
        }

        //C Section
        private void C100_Click(object sender, RoutedEventArgs e)
        {
            if (player == 1)
            {
                C100.Content = "X";
                TicTacToe();
            }
            if (player == 2)
            {
                C100.Content = "O";
                TicTacToe();
            }
        }

        private void C010_Click(object sender, RoutedEventArgs e)
        {
            if (player == 1)
            {
                C010.Content = "X";
                TicTacToe();
            }
            if (player == 2)
            {
                C010.Content = "O";
                TicTacToe();
            }
        }

        private void C001_Click(object sender, RoutedEventArgs e)
        {
            if (player == 1)
            {
                C001.Content = "X";
                TicTacToe();
            }
            if (player == 2)
            {
                C001.Content = "O";
                TicTacToe();
            }
        }











































    }
}