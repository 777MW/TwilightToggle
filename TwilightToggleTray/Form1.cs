namespace TwilightToggleTray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Hide the form on load
            this.Opacity = 0.0;

        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            if (contextMenuStrip1.Visible)
            {
                contextMenuStrip1.Visible = false;
            }
            else
            {
                notifyIcon1.ContextMenuStrip = contextMenuStrip1;
                //contextMenuStrip1.Visible = true;
                contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 1.0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(100, "🌙☀️ TwilightToggle", "🌙 User settings have been saved.", notifyIcon1.BalloonTipIcon);
            this.Opacity = 0.0;
        }

        private void exitTwilightToggleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}