using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myScratchApp
{
    public partial class Form1 : Form
    {
        private Button playButton;



        public Form1()
        {
            InitializeComponent();
            playButton = new Button();

            playButton.Location = new Point(24, 24);
            playButton.Size = new Size(200, 24);
            playButton.Text = "Play";
            playButton.Click += new EventHandler(playButton_Click);

            Controls.Add(playButton);
        }

        public void playButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }
    }
}
