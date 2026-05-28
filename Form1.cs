using Moon_Base.Properties;

namespace Moon_Base
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string destination;

        public void Loop() //Method to perform a loop.
        {
            for (int i = 0; i < 5; i++)
            {
                MessageBox.Show("Click OK or X 5 times to be transported");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_North.Enabled = false;
        }
        private void button_North_Click(object sender, EventArgs e)
        {
            Loop();
            BackgroundImage = Resources.HQBase;
            label_Location_Name.Text = "Headquarters";
            textBox_Description.Text = "In the year 9999, the human race established a Moonbase in the 19th district of the Cutashi Astroid belt.\r\n\r\nThis is their largest base in the region.";
            textBox_Population.Text = "3,023";
            button_North.Enabled = false;
            button_East.Enabled = true;
            button_West.Enabled = true;
            button_South.Enabled = true;
        }
        private void button_East_Click(object sender, EventArgs e)
        {
            Loop();
            BackgroundImage = Resources.EastBase;
            label_Location_Name.Text = "East Base";
            textBox_Description.Text = "The East Base serves as the hospital. All of the staff are robots.";
            textBox_Population.Text = "1,250";
            button_North.Enabled = true;
            button_East.Enabled = false;
            button_West.Enabled = true;
            button_South.Enabled = true;
        }

        private void button_South_Click(object sender, EventArgs e)
        {
            Loop();
            BackgroundImage = Resources.SouthBase;
            label_Location_Name.Text = "South Base";
            textBox_Description.Text = "The South Base was attacked by aliens in the year 9900. There is only one remaining structure there now.";
            textBox_Population.Text = "200";
            button_North.Enabled = true;
            button_East.Enabled = true;
            button_West.Enabled = true;
            button_South.Enabled = false;
        }

        private void button_West_Click(object sender, EventArgs e)
        {
            Loop();
            BackgroundImage = Resources.WestBase;
            label_Location_Name.Text = "West Base";
            textBox_Description.Text = "The West Base serves as the training base for new recruits. They have to train immidiately upon arrival so they can fight off any alien attacks.";
            textBox_Population.Text = "1,380";
            button_North.Enabled = true;
            button_East.Enabled = true;
            button_West.Enabled = false;
            button_South.Enabled = true;
        }
    }
}
