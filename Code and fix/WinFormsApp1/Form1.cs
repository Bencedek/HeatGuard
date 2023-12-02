namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0: //Gépüzemeltető
                    label1.Visible = true;
                    radioButton1.Visible = true;
                    numericUpDown1.Visible = false;
                    button2.Visible = false;
                    label3.Visible = false;
                    break;
                case 1: //Gyártástervező mérnök
                    label1.Visible = false;
                    radioButton1.Visible = false;
                    numericUpDown1.Visible = true;
                    button2.Visible = false;
                    label3.Visible = true;
                    break; 
                case 2: //Műszakvezető
                    label1.Visible = false;
                    radioButton1.Visible = true;
                    numericUpDown1.Visible = false;
                    button2.Visible = true;
                    label3.Visible = false;
                    break;

            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            label1.Visible = false;
            radioButton1.Visible = false;
            numericUpDown1.Visible = false;
            button2.Visible = false;
            label3.Visible = false;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            label1.Text = homerseklet.ToString();
            comboBox2.SelectedIndex = 0;
            numericUpDown1.Value = hatarertek;
            radioButton1.AutoCheck = false;
        }

        bool futagep = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if(futagep)
            {
                futagep = false;
                button1.Text = "Start";
            }
            else
            {
                futagep = true;
                button1.Text = "Stop";
            }
        }
        int homerseklet = 20;
        int hatarertek = 30;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (futagep)
            {
                homerseklet++;
            }
            else if(homerseklet>20)
            {
                homerseklet--;
            }
            label1.Text = homerseklet.ToString();
            if(homerseklet >= hatarertek)
            {
                radioButton1.Checked = true;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            hatarertek = (int)numericUpDown1.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
        }
    }
}