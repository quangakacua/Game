﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCARO
{
    public class Player
    {
        private string name;

        public string Name { get { return name; } set { name = value; } }

        public Image Mark { get => mark; set => mark = value; }

        private Image mark;

        public Player(string name, Image mark)
        {
            this.name = name;
            this.Mark = mark;
        }

    }
}
