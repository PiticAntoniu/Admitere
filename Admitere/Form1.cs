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
        Config config = new Config();
        Test inputTest = new Test();
        public mainForm()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (inputTestOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                inputTest.Load(inputTestOpenFileDialog.FileName);
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            config.Load();
            numberOfSubjectsNumericUpDown.Value = config.numberOfSubjects;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            //Config c = new Config();
            //c.Save();
            string testName = "Testul ";
            List<Test> tests = new List<Test>();
            for(int i = 1; i <= numberOfSubjectsNumericUpDown.Value; i++)
            {
                string fileNme = testName + i.ToString() + ".json";
                Test t = new Test();
                t = inputTest.Shuffle();
                MockData.Save(t, fileNme);
            }
        }

        private void numberOfSubjectsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            config.numberOfSubjects = 
                Convert.ToInt32(numberOfSubjectsNumericUpDown.Value);
            config.Save();
        }
    }
}
