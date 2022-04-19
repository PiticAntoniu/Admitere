using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admitere
{
    public partial class mainForm : Form
    {
        Config c = new Config();
        public mainForm()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            c.Load();
            numberOfSubjectsNumericUpDown.Value = c.numberOfSubjects;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            Config c = new Config();
            c.Save();
        }

        private void numberOfSubjectsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            c.numberOfSubjects = 
                Convert.ToInt32(numberOfSubjectsNumericUpDown.Value);
            c.Save();
        }
    }
}
