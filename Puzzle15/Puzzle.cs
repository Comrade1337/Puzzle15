using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle15
{
    public partial class Puzzle : Form
    {
        const int fieldsize = 4;
        const int framesize = 400;
        Button[,] tiles = new Button[fieldsize, fieldsize];
        Size tileSize = new Size(framesize / fieldsize - 10, framesize / fieldsize - 10);

        public Puzzle()
        {
            Text = "Пятнашки";
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(framesize, framesize);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;

            for (int i = 0; i < fieldsize; i++)
            {
                for (int j = 0; j < fieldsize; j++)
                {
                    tiles[i, j] = new Button();
                    tiles[i, j].Text = $"{i * (j + 1) + j + 1}";
                    tiles[i, j].Size = tileSize;
                    tiles[i, j].Location = new Point(j * tileSize.Width, i * tileSize.Height);

                    Controls.Add(tiles[i, j]);
                }
            }
        }
    }
}
