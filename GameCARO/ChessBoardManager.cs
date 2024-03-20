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

        public Panel ChessBoard {
            get { return chessBoard; }
            set { chessBoard = value; }
        }
        #endregion
        #region Initialize
        public ChessBoardManager(Panel chessBoard)
        {
            this.ChessBoard = chessBoard;
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
                        Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y)

                    };
                    ChessBoard.Controls.Add(btn);
                    oldbtn = btn;
                }
                oldbtn.Location = new Point(0, oldbtn.Location.Y + Const.ChessHeight);
                oldbtn.Width = 0;
                oldbtn.Height = 0;
            }

        }
        #endregion
    }
}
