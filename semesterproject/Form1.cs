using System;
using System.Windows.Forms;

namespace semesterproject
{
    public partial class Form1 : Form
    {
        int Counter;

        public Form1()
        {
            InitializeComponent();

        }

        public void Emptyspotchecker(Button butt1, Button butt2)
        {
            if (butt2.Text == "")
            {
                butt2.Text = butt1.Text;
                butt1.Text = "";

            }
        }
        public void Solutionchecker()
        {
            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3"
                && button4.Text == "4" && button5.Text == "5" && button6.Text == "6" &&
                button7.Text == "7" && button8.Text == "8" && button9.Text == "9"
                && button10.Text == "10" && button11.Text == "11" && button12.Text == "12" &&
                button13.Text == "13" && button14.Text == "14" && button15.Text == "15")
            {
                MessageBox.Show("Welldone you are a winner ", "Shuffle Game", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            Counter = Counter + 1;
            textBox1.Text = "Number of clicks" + Counter;
            textBox2.Text = Counter.ToString();

        }
        public void Shuffle()
        {
            int[] bnum = new int[16];
            int i, j, rowchecker;
            Boolean flag = false;
            i = 1;
            do
            {
                Random rnd = new Random();
                rowchecker = Convert.ToInt32((rnd.Next(0, 15)) + 1);
                for (j = 1; j <= i; j++)
                {
                    if (bnum[j] == rowchecker)
                    {
                        flag = true;
                        break;

                    }
                }
                if (flag == true)
                {
                    flag = false;
                }
                else
                {
                    bnum[i] = rowchecker;
                    i = i + 1;
                }

            }
            while (i <= 15);
            button1.Text = Convert.ToString(bnum[1]);
            button2.Text = Convert.ToString(bnum[2]);
            button3.Text = Convert.ToString(bnum[3]);
            button4.Text = Convert.ToString(bnum[4]);
            button5.Text = Convert.ToString(bnum[5]);
            button6.Text = Convert.ToString(bnum[6]);
            button7.Text = Convert.ToString(bnum[7]);
            button8.Text = Convert.ToString(bnum[8]);
            button9.Text = Convert.ToString(bnum[9]);
            button10.Text = Convert.ToString(bnum[10]);
            button11.Text = Convert.ToString(bnum[11]);
            button12.Text = Convert.ToString(bnum[12]);
            button13.Text = Convert.ToString(bnum[13]);
            button14.Text = Convert.ToString(bnum[14]);
            button15.Text = Convert.ToString(bnum[15]);
            button16.Text = "";


        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Emptyspotchecker(button1, button2);
            Emptyspotchecker(button1, button5);
            Solutionchecker();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Emptyspotchecker(button2, button1);
            Emptyspotchecker(button2, button3);
            Emptyspotchecker(button2, button6);
            Solutionchecker();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Emptyspotchecker(button3, button2);
            Emptyspotchecker(button3, button4);
            Emptyspotchecker(button3, button7);
            Solutionchecker();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Emptyspotchecker(button4, button3);
            Emptyspotchecker(button4, button8);
            Solutionchecker();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Emptyspotchecker(button5, button6);
            Emptyspotchecker(button5, button9);
            Emptyspotchecker(button5, button1);
            Solutionchecker();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Emptyspotchecker(button6, button2);
            Emptyspotchecker(button6, button5);
            Emptyspotchecker(button6, button7);
            Emptyspotchecker(button6, button10);
            Solutionchecker();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Emptyspotchecker(button7, button3);
            Emptyspotchecker(button7, button6);
            Emptyspotchecker(button7, button8);
            Emptyspotchecker(button7, button11);
            Solutionchecker();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Emptyspotchecker(button8, button4);
            Emptyspotchecker(button8, button7);
            Emptyspotchecker(button8, button12);
            Solutionchecker();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Emptyspotchecker(button9, button5);
            Emptyspotchecker(button9, button10);
            Emptyspotchecker(button9, button13);
            Solutionchecker();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Emptyspotchecker(button10, button6);
            Emptyspotchecker(button10, button9);
            Emptyspotchecker(button10, button11);
            Emptyspotchecker(button10, button14);
            Solutionchecker();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Emptyspotchecker(button11, button7);
            Emptyspotchecker(button11, button10);
            Emptyspotchecker(button11, button12);
            Emptyspotchecker(button11, button15);
            Solutionchecker();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Emptyspotchecker(button12, button8);
            Emptyspotchecker(button12, button16);
            Solutionchecker();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Emptyspotchecker(button13, button9);
            Emptyspotchecker(button13, button14);
            Solutionchecker();

        }
        
        private void button14_Click(object sender, EventArgs e)
        {
            Emptyspotchecker(button14, button10);
            Emptyspotchecker(button14, button13);
            Emptyspotchecker(button14, button15);

            Solutionchecker();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Emptyspotchecker(button15, button11);
            Emptyspotchecker(button15, button14);
            Emptyspotchecker(button15, button16);
            Solutionchecker();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Shuffle();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult iExit = MessageBox.Show("confirm if you want to exit", "shuffle Games",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            DialogResult iExit = MessageBox.Show("confirm if you want to exit", "shuffle Games",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Emptyspotchecker(button16, button12);
            Emptyspotchecker(button16, button15);
            Solutionchecker();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Shuffle();
            textBox1.Clear();
            textBox2.Clear();
            this.Refresh();
            this.Hide();
            Form1 NewGame = new Form1();
            NewGame.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button1.Text = Convert.ToString(1);
            button2.Text = Convert.ToString(2);
            button3.Text = Convert.ToString(3);
            button4.Text = Convert.ToString(4);
            button5.Text = Convert.ToString(5);
            button6.Text = Convert.ToString(6);
            button7.Text = Convert.ToString(7);
            button8.Text = Convert.ToString(8);
            button9.Text = Convert.ToString(9);
            button10.Text = Convert.ToString(10);
            button11.Text = Convert.ToString(11);
            button12.Text = Convert.ToString(12);
            button13.Text = Convert.ToString(13);
            button14.Text = Convert.ToString(14);
            button15.Text = Convert.ToString(15);
            button16.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Shuffle();
        }
    }
}
