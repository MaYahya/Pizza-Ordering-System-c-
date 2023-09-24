using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            radioButton1.Checked = true;
            radioButton9.Checked = true;
            radioButton6.Checked = true;
            radioButton12.Checked = true;
            radioButton24.Checked = true;
            radioButton21.Checked = true;
            radioButton18.Checked = true;
            radioButton15.Checked = true;
        }
        private int panelIndex = 50;
        private int labelIndex = 50;
        private int pictureBoxIndex = 50;
        int y = 116;
        int sum = 0;
        private void panelCreate(PictureBox pic, string labelText, int price, string pizzaSize)
        {
            Panel panel = new Panel();

            // Set the properties of the Panel.
            panel.Location = new Point(860, y);
            panel.Size = new Size(500, 70);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Anchor =  AnchorStyles.Right;

            // Add the Panel to the form.
            flowLayoutPanel2.Controls.Add(panel);

            // Create a new Label for the Panel.
            Label label1 = new Label();

            // Set the properties of the Label.
            label1.Location = new Point(104, -3);
            label1.Font = new Font("Segoe UI", 18,FontStyle.Bold);
            label1.Size = new Size(139, 32);
            label1.Text = labelText;
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;

            // Add the Label to the Panel.
            panel.Controls.Add(label1);

            // Create a new Label for the Panel.
            Label label2 = new Label();

            // Set the properties of the Label.
            label2.Location = new Point(87, 44);
            label2.Size = new Size(37, 21);
            label2.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label2.Text = "Qty";

            // Add the Label to the Panel.
            panel.Controls.Add(label2);

            Label label3 = new Label();

            // Set the properties of the Label.
            label3.Location = new Point(220, 45);
            label3.AutoSize = true;
            label3.Size = new Size(53, 21);
            label3.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label3.Text = pizzaSize;

            // Add the Label to the Panel.
            panel.Controls.Add(label3);
            Label label4= new Label();
            label4.Location = new Point(141, 45);
            label4.AutoSize = true;
            label4.Size = new Size(22, 21);
            label4.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label4.Text = value.ToString();

            // Add the Label to the Panel.
            panel.Controls.Add(label4);

            Label label5= new Label();
            label5.Location = new Point(370, 21);
            label5.AutoSize = true;
            label5.Size = new Size(100,32);
            label5.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            label5.Text = (value * price).ToString() + ".00";

            // Add the Label to the Panel.
            panel.Controls.Add(label5);


            // Create a new PictureBox for the Panel.
            PictureBox pictureBox = new PictureBox();

            // Set the properties of the PictureBox.
            pictureBox.Location = new Point(5, 1);
            pictureBox.Size = new Size(72, 67);
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Image = pic.Image;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Name = "pictureBox" + (pictureBoxIndex + 11).ToString();
            pictureBox.Anchor = AnchorStyles.Left | AnchorStyles.Top;

            // Add the PictureBox to the Panel.
            panel.Controls.Add(pictureBox);

            // Increment the indexes.
            y += 69;
            panelIndex++;
            labelIndex += 5;
            pictureBoxIndex++;
            sum += (value*price);
            label24.Text = sum.ToString()+".00";
        }
        
        int value = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            value++;
            label12.Text = value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (value > 1)
            {
                value--;
            }
           
            label12.Text = value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                panelCreate(pictureBox4, "Meat Pizza", 3350, "Large");
            }
            else if (radioButton8.Checked)
            {
                panelCreate(pictureBox4, "Meat Pizza", 1850, "Medium");
            }
            else if (radioButton9.Checked)
            {
                panelCreate(pictureBox4, "Meat Pizza", 950, "Small");
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                panelCreate(pictureBox3, "Mushroom Pizza", 980, "Small");
            }
            else if (radioButton5.Checked)
            {
                panelCreate(pictureBox3, "Mushroom Pizza", 1830, "Medium");
            }
            else if (radioButton4.Checked)
            {
                panelCreate(pictureBox3, "Mushroom Pizza", 3400, "Large");
            }
        }

    
        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 2; i <= 9; i++)
            {
                Control[] controls = this.Controls.Find("panel" + i.ToString(), true);
                if (controls.Length > 0 && controls[0] is Panel)
                {
                    controls[0].Hide();
                }
            }
            shippingPanel.Show();
            label35.Text = label24.Text;
            panel11.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter your name.");
                textBox1.Focus();
                
            }
            else
            {
                int xyz = int.Parse(textBox4.Text);
                label37.Text = (xyz - sum).ToString()+".00 Rs";
                panel11.Show();
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            label24.Text = "0.00";


            // Reset the index variables
            panelIndex = 50;
            labelIndex = 50;
            pictureBoxIndex = 50;
            y = 116;
            sum = 0;
            shippingPanel.Hide();
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
            label35.Text = "0.00"; label37.Text = "0.00";
            for (int i = 2; i <= 9; i++)
            {
                Control[] controls = this.Controls.Find("panel" + i.ToString(), true);
                if (controls.Length > 0 && controls[0] is Panel)
                {
                    controls[0].Show();
                }
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "950.00 Rs";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "1850.00 Rs";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "3350.00 Rs";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (radioButton18.Checked)
            {
                panelCreate(pictureBox7, "Chicken Pizza", 1020, "Small");
            }
            else if (radioButton17.Checked)
            {
                panelCreate(pictureBox7, "Chicken Pizza", 1950, "Medium");
            }
            else if (radioButton16.Checked)
            {
                panelCreate(pictureBox7, "Chicken Pizza", 3820, "Large");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            value++;
          
            label30.Text = value.ToString();
            
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (value > 1)
            {
                value--;
            }

            label30.Text = value.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            value++;
            label29.Text = value.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (value > 1)
            {
                value--;
            }

            label29.Text = value.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            value++;
            label28.Text = value.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (value > 1)
            {
                value--;
            }

            label28.Text = value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            value++;
            label13.Text = value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (value > 1)
            {
                value--;
            }

            label13.Text = value.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            value++;
            label27.Text = value.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (value > 1)
            {
                value--;
            }

            label27.Text = value.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            value++;
            label25.Text = value.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (value > 1)
            {
                value--;
            }

            label25.Text = value.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            value++;
            label26.Text = value.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (value > 1)
            {
                value--;
            }

            label26.Text = value.ToString();
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            label10.Text = "890.00 Rs";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            label10.Text = "1710.00 Rs";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            label10.Text = "3330.00 Rs";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                panelCreate(pictureBox2, "Spinach Pizza", 910, "Small");
            }
            else if (radioButton2.Checked)
            {
                panelCreate(pictureBox2, "Spinach Pizza", 1760, "Medium");
            }
            else if (radioButton3.Checked)
            {
                panelCreate(pictureBox2, "Spinach Pizza", 3200, "Large");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "910.00 Rs";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "1760.00 Rs";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "3200.00 Rs";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton15.Checked)
            {
                panelCreate(pictureBox6, "Hawaiian Pizza", 870, "Small");
            }
            else if (radioButton14.Checked)
            {
                panelCreate(pictureBox6, "Hawaiian Pizza", 1590, "Medium");
            }
            else if (radioButton13.Checked)
            {
                panelCreate(pictureBox6, "Hawaiian Pizza", 3100, "Large");
            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            label14.Text = "870.00 Rs";
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            label14.Text = "1590.00 Rs";
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            label14.Text = "3100.00 Rs";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "1830.00 Rs";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "980.00 Rs";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "3400.00 Rs";
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            label16.Text = "3820.00 Rs";
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            label16.Text = "1950.00 Rs";
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            label16.Text = "1020.00 Rs";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (radioButton21.Checked)
            {
                panelCreate(pictureBox8, "Pepperoni  Pizza", 990, "Small");
            }
            else if (radioButton20.Checked)
            {
                panelCreate(pictureBox8, "Pepperoni Pizza", 1920, "Medium");
            }
            else if (radioButton19.Checked)
            {
                panelCreate(pictureBox8, "Pepperoni Pizza", 3510, "Large");
            }
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            label18.Text = "990.00 Rs";
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            label18.Text = "1920.00 Rs";
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            label18.Text = "3510.00 Rs";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (radioButton24.Checked)
            {
                panelCreate(pictureBox9, "Veggie  Pizza", 800, "Small");
            }
            else if (radioButton23.Checked)
            {
                panelCreate(pictureBox9, "Veggie Pizza", 1520, "Medium");
            }
            else if (radioButton22.Checked)
            {
                panelCreate(pictureBox9, "Veggie Pizza", 2900, "Large");
            }
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            label20.Text = "800.00 Rs";
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            label20.Text = "1520.00 Rs";
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            label20.Text = "2900.00 Rs";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            label24.Text = "0.00";
        }

        private void buffBtn_Click(object sender, EventArgs e)
        {
            if (radioButton12.Checked)
            {
                panelCreate(pictureBox5, "Buffalo  Pizza", 890, "Small");
            }
            else if (radioButton11.Checked)
            {
                panelCreate(pictureBox5, "Buffalo Pizza", 1710, "Medium");
            }
            else if (radioButton10.Checked)
            {
                panelCreate(pictureBox5, "Buffalo Pizza", 3330, "Large");
            }
        }
    }
}
