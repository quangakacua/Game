using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCARO
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;
        private List<Player> player;
        public Panel ChessBoard {
            get { return chessBoard; }
            set { chessBoard = value; }
        }

        public List<Player> Player { get => player; set => player = value; }
        public int CurentPlayer1 { get => CurentPlayer; set => CurentPlayer = value; }
        public TextBox Playername1 { get => Playername; set => Playername = value; }
        public PictureBox Playermark { get => playermark; set => playermark = value; }
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }

        public int CurentPlayer;
        private TextBox Playername;
        private PictureBox playermark;
        private List<List<Button>> matrix;

        private event EventHandler playerMarked;
        public event EventHandler PlayerMarked
        {
            add
            {
                playerMarked += value;
            }
            remove
            {
                playerMarked -= value;
            }
        }
        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }
        #endregion
        #region Initialize
        public ChessBoardManager(Panel chessBoard,TextBox Playername,PictureBox mark)
        {
            this.ChessBoard = chessBoard;
            this.Playername = Playername;
            this.Playermark = mark;

            this.Player = new List<Player>()
            {
                new Player("Player1",Image.FromFile(Application.StartupPath+"\\Resources\\asd.PNG")),
                new Player("Player2", Image.FromFile(Application.StartupPath + "\\Resources\\Capture.PNG"))
            };
             
        }
        #endregion
        #region MeThods
        public void DrawChessBord()
        {
            ChessBoard.Enabled = true;
            ChessBoard.Controls.Clear();
            CurentPlayer = 0;
            changePlayer();

            Matrix = new List<List<Button>>();
            Button oldbtn = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Const.ChessBoardWidth; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Const.ChessBoardHeight; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Const.ChessWidth,
                        Height = Const.ChessHeight,
                        Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };
                    btn.Click += Btn_Click;
                    ChessBoard.Controls.Add(btn);

                    Matrix[i].Add(btn);
                    oldbtn = btn;
                }
                oldbtn.Location = new Point(0, oldbtn.Location.Y + Const.ChessHeight);
                oldbtn.Width = 0;
                oldbtn.Height = 0;
            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackgroundImage != null)
                return;
            mark(btn);
            changePlayer();

            if (playerMarked != null)
                playerMarked(this, new EventArgs());
            if(isEndGame(btn))
            {
                EndGame();
            }
        }
        public void EndGame()
        {
            if (endedGame != null)
                endedGame(this, new EventArgs());
        }
        private bool isEndGame(Button btn)
        {
            return isEndGameNgang(btn) || isEndGameDoc(btn) || isEndGameCheoChinh(btn) || isEndGameCheophu(btn);
        }
        private Point GetChessPoint(Button btn)
        {
            
            int Toadoy = Convert.ToInt32(btn.Tag);
            int Toadox = Matrix[Toadoy].IndexOf(btn);
            Point point = new Point(Toadox,Toadoy);
            return point;
        }
        private bool isEndGameNgang(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countLeft = 0;
            for (int i = point.X;i >= 0;i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                    break;
            }
            int countRight = 0;
            for (int i = point.X+1; i < Const.ChessBoardWidth; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                    break;
            }
            return countLeft + countRight == 5;
        }
        private bool isEndGameDoc(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countDown = 0;
            for (int i = point.Y + 1; i < Const.ChessBoardHeight; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countDown++;
                }
                else
                    break;
            }
            return countTop + countDown == 5;
        }
        private bool isEndGameCheoChinh(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;
                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countDown = 0;
            for (int i = 1; i <= Const.ChessBoardWidth-point.X; i++)
            {
                if (point.Y + i >= Const.ChessBoardHeight || point.X + i >= Const.ChessBoardWidth)
                    break;
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countDown++;
                }
                else
                    break;
            }
            return countTop + countDown == 5;
        }
        private bool isEndGameCheophu(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countTop = 0;
            for (int i = 0; i <= Math.Min(point.X, Const.ChessBoardHeight - point.Y - 1); i++)
            {
                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countDown = 0;
            for (int i = 1; i <= Math.Min(Const.ChessBoardWidth - point.X - 1, point.Y); i++)
            {
                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countDown++;
                }
                else
                    break;
            }
            return countTop + countDown == 5;
        }
        private void mark(Button btn)
        {
            btn.BackgroundImage = Player[CurentPlayer].Mark;
            CurentPlayer = CurentPlayer == 1 ? 0 : 1;
        }
        private void changePlayer()
        {
            Playername.Text = Player[CurentPlayer].Name;
            Playermark.Image = Player[CurentPlayer].Mark;
        }
        #endregion
    }
}
