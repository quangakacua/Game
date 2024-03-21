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

        private int CurentPlayer;
        private TextBox Playername;
        private PictureBox playermark;
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
            CurentPlayer = 0;
            changePlayer();     
        }
        #endregion
        #region MeThods
        public void DrawChessBord()
        {
            Button oldbtn = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Const.ChessBoardWidth; i++)
            {
                for (int j = 0; j < Const.ChessBoardHeight; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Const.ChessWidth,
                        Height = Const.ChessHeight,
                        Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch
                    };
                    btn.Click += Btn_Click;
                    ChessBoard.Controls.Add(btn);
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
