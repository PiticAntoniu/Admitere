namespace Admitere
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.numberOfSubjectsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSubjectsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(49, 367);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(91, 39);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(175, 367);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(92, 39);
            this.generateButton.TabIndex = 1;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // numberOfSubjectsNumericUpDown
            // 
            this.numberOfSubjectsNumericUpDown.Location = new System.Drawing.Point(295, 374);
            this.numberOfSubjectsNumericUpDown.Name = "numberOfSubjectsNumericUpDown";
            this.numberOfSubjectsNumericUpDown.Size = new System.Drawing.Size(80, 26);
            this.numberOfSubjectsNumericUpDown.TabIndex = 2;
            this.numberOfSubjectsNumericUpDown.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numberOfSubjectsNumericUpDown.ValueChanged += new System.EventHandler(this.numberOfSubjectsNumericUpDown_ValueChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numberOfSubjectsNumericUpDown);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.loadButton);
            this.Name = "mainForm";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSubjectsNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.NumericUpDown numberOfSubjectsNumericUpDown;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

