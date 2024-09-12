using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace qwer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Гайка");
            comboBox1.Items.Add("Двигатель");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qwe = comboBox1.SelectedItem.ToString();
            string imagePath = string.Empty;

            switch(qwe)
            {
                case "Гайка":
                    imagePath = @"C:\Users\student2\Pictures\Снимок экрана 2024-09-04 160627.png";
                    break;
                case "Двигатель":
                    imagePath = @"C:\Users\student2\Pictures\Снимок  2024-09-04 160934.png";
                    break;
            }
            if (!string.IsNullOrEmpty(imagePath))
                pictureBox1.Image = new Bitmap(imagePath);
        }
    }
}
