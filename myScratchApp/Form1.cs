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
        private Button stopButton;
        private Button pauseButton;
        private Button killButton;

        public Form1()
        {
            InitializeComponent();
            playButton = new Button();
            stopButton = new Button();
            pauseButton = new Button();
            killButton = new Button();

            playButton.Location = new Point(24, 24);
            playButton.Size = new Size(200, 24);
            playButton.Text = "Play";
            playButton.Click += new EventHandler(playButton_Click);

            stopButton.Location = new Point(300, 24);
            stopButton.Size = new Size(200, 24);
            stopButton.Text = "Stop";
            stopButton.Click += new EventHandler(playButton_Click);

            pauseButton.Location = new Point(600, 24);
            pauseButton.Size = new Size(200, 24);
            pauseButton.Text = "Pause";
            pauseButton.Click += new EventHandler(playButton_Click);

            killButton.Location = new Point(850, 24);
            killButton.Size = new Size(200, 24);
            killButton.Text = "Kill";
            killButton.Click += new EventHandler(playButton_Click);

            Controls.Add(playButton);
            Controls.Add(stopButton);
            Controls.Add(pauseButton);
            Controls.Add(killButton);
        }

        public void playButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }
    }
}
