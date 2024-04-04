using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCARO
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;
        #endregion
        public Form1()
        {
            InitializeComponent();
            ChessBoard = new ChessBoardManager(pnlcheckboard,txtPlayer,picAvatarMark);
            ChessBoard.EndedGame += ChessBoard_EndedGame;

            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;

            progressTime.Step = Const.CoolDownStep;
            progressTime.Maximum = Const.CoolDownTime;

            progressTime.Value = 0;
            timerCoolDown.Interval = Const.CoolDownInterval;

            ChessBoard.DrawChessBord();


            
        }
        void EnDGame(string winnerName)
        {
            timerCoolDown.Stop();
            pnlcheckboard.Enabled = false;
            MessageBox.Show("Kết Thúc"+ winnerName + "win");
        }
        private void ChessBoard_PlayerMarked(object sender, EventArgs e)
        {
            timerCoolDown.Start();
            progressTime.Value = 0;
        }

        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EnDGame(ChessBoard.Player[1 - ChessBoard.CurentPlayer].Name);
        }

        private void timerCoolDown_Tick(object sender, EventArgs e)
        {
            progressTime.PerformStep();
            if (progressTime.Value >= progressTime.Maximum)
            {
                EnDGame(ChessBoard.Player[1 - ChessBoard.CurentPlayer].Name);
            }
        }
        void NewGame()
        {
            timerCoolDown.Stop();
            ChessBoard.DrawChessBord();
            
            progressTime.Value = 0;
        }
        void Undo()
        {

        }
        void Quit()
        {
            Application.Exit();
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void unDoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát", "thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }
    }
}
