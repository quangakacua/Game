namespace GameCARO
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlcheckboard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.pnlInfor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLAN = new System.Windows.Forms.TextBox();
            this.picAvatarMark = new System.Windows.Forms.PictureBox();
            this.progressTime = new System.Windows.Forms.ProgressBar();
            this.txtPlayer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timerCoolDown = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnlInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatarMark)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlcheckboard
            // 
            this.pnlcheckboard.Location = new System.Drawing.Point(12, 37);
            this.pnlcheckboard.Name = "pnlcheckboard";
            this.pnlcheckboard.Size = new System.Drawing.Size(808, 666);
            this.pnlcheckboard.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.picAvatar);
            this.panel2.Location = new System.Drawing.Point(838, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 288);
            this.panel2.TabIndex = 1;
            // 
            // picAvatar
            // 
            this.picAvatar.Image = global::GameCARO.Properties.Resources._359406731_761869939280399_7770462020478364278_n;
            this.picAvatar.Location = new System.Drawing.Point(0, 0);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(288, 288);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // pnlInfor
            // 
            this.pnlInfor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInfor.Controls.Add(this.label1);
            this.pnlInfor.Controls.Add(this.button1);
            this.pnlInfor.Controls.Add(this.txtLAN);
            this.pnlInfor.Controls.Add(this.picAvatarMark);
            this.pnlInfor.Controls.Add(this.progressTime);
            this.pnlInfor.Controls.Add(this.txtPlayer);
            this.pnlInfor.Location = new System.Drawing.Point(838, 439);
            this.pnlInfor.Name = "pnlInfor";
            this.pnlInfor.Size = new System.Drawing.Size(290, 264);
            this.pnlInfor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "5 IN LINE TO WIN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "LAN";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtLAN
            // 
            this.txtLAN.Location = new System.Drawing.Point(12, 72);
            this.txtLAN.Name = "txtLAN";
            this.txtLAN.Size = new System.Drawing.Size(139, 22);
            this.txtLAN.TabIndex = 3;
            this.txtLAN.Text = "127.0.0.1";
            // 
            // picAvatarMark
            // 
            this.picAvatarMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAvatarMark.Image = global::GameCARO.Properties.Resources._359406731_761869939280399_7770462020478364278_n;
            this.picAvatarMark.Location = new System.Drawing.Point(157, 3);
            this.picAvatarMark.Name = "picAvatarMark";
            this.picAvatarMark.Size = new System.Drawing.Size(128, 120);
            this.picAvatarMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatarMark.TabIndex = 2;
            this.picAvatarMark.TabStop = false;
            // 
            // progressTime
            // 
            this.progressTime.Location = new System.Drawing.Point(12, 43);
            this.progressTime.Name = "progressTime";
            this.progressTime.Size = new System.Drawing.Size(139, 22);
            this.progressTime.TabIndex = 1;
            // 
            // txtPlayer
            // 
            this.txtPlayer.Location = new System.Drawing.Point(12, 15);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.ReadOnly = true;
            this.txtPlayer.Size = new System.Drawing.Size(139, 22);
            this.txtPlayer.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(838, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 108);
            this.label2.TabIndex = 3;
            this.label2.Text = "CaroWorld";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerCoolDown
            // 
            this.timerCoolDown.Tick += new System.EventHandler(this.timerCoolDown_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1140, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 709);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlInfor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlcheckboard);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CaroWorld";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnlInfor.ResumeLayout(false);
            this.pnlInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatarMark)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlcheckboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Panel pnlInfor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLAN;
        private System.Windows.Forms.PictureBox picAvatarMark;
        private System.Windows.Forms.ProgressBar progressTime;
        private System.Windows.Forms.TextBox txtPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerCoolDown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}

