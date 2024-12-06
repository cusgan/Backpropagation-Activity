namespace Backpropagation_Activity
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnOrTrain = new Button();
            btnOrTest = new Button();
            btnOrCreate = new Button();
            tbOrResult = new TextBox();
            tbOrB = new TextBox();
            tbOrA = new TextBox();
            tabPage2 = new TabPage();
            btnAndTrain = new Button();
            btnAndTest = new Button();
            btnAndCreate = new Button();
            tbAndResult = new TextBox();
            tbAndD = new TextBox();
            tbAndC = new TextBox();
            tbAndB = new TextBox();
            tbAndA = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(652, 383);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnOrTrain);
            tabPage1.Controls.Add(btnOrTest);
            tabPage1.Controls.Add(btnOrCreate);
            tabPage1.Controls.Add(tbOrResult);
            tabPage1.Controls.Add(tbOrB);
            tabPage1.Controls.Add(tbOrA);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(644, 350);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "1. OR Gate";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnOrTrain
            // 
            btnOrTrain.Location = new Point(248, 229);
            btnOrTrain.Name = "btnOrTrain";
            btnOrTrain.Size = new Size(161, 72);
            btnOrTrain.TabIndex = 5;
            btnOrTrain.Text = "Train \r\nNeural Network";
            btnOrTrain.UseVisualStyleBackColor = true;
            btnOrTrain.Click += btnOrTrain_Click;
            // 
            // btnOrTest
            // 
            btnOrTest.Location = new Point(431, 229);
            btnOrTest.Name = "btnOrTest";
            btnOrTest.Size = new Size(161, 72);
            btnOrTest.TabIndex = 4;
            btnOrTest.Text = "Test\r\nNeural Network";
            btnOrTest.UseVisualStyleBackColor = true;
            btnOrTest.Click += btnOrTest_Click;
            // 
            // btnOrCreate
            // 
            btnOrCreate.Location = new Point(57, 229);
            btnOrCreate.Name = "btnOrCreate";
            btnOrCreate.Size = new Size(161, 72);
            btnOrCreate.TabIndex = 3;
            btnOrCreate.Text = "Create\r\nNew BPNN";
            btnOrCreate.UseVisualStyleBackColor = true;
            btnOrCreate.Click += btnOrCreate_Click;
            // 
            // tbOrResult
            // 
            tbOrResult.Location = new Point(356, 118);
            tbOrResult.Name = "tbOrResult";
            tbOrResult.Size = new Size(236, 27);
            tbOrResult.TabIndex = 2;
            // 
            // tbOrB
            // 
            tbOrB.Location = new Point(57, 150);
            tbOrB.Name = "tbOrB";
            tbOrB.Size = new Size(236, 27);
            tbOrB.TabIndex = 1;
            // 
            // tbOrA
            // 
            tbOrA.Location = new Point(57, 84);
            tbOrA.Name = "tbOrA";
            tbOrA.Size = new Size(236, 27);
            tbOrA.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnAndTrain);
            tabPage2.Controls.Add(btnAndTest);
            tabPage2.Controls.Add(btnAndCreate);
            tabPage2.Controls.Add(tbAndResult);
            tabPage2.Controls.Add(tbAndD);
            tabPage2.Controls.Add(tbAndC);
            tabPage2.Controls.Add(tbAndB);
            tabPage2.Controls.Add(tbAndA);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(644, 350);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "2. AND Gate";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAndTrain
            // 
            btnAndTrain.Location = new Point(248, 229);
            btnAndTrain.Name = "btnAndTrain";
            btnAndTrain.Size = new Size(161, 72);
            btnAndTrain.TabIndex = 8;
            btnAndTrain.Text = "Train \r\nNeural Network";
            btnAndTrain.UseVisualStyleBackColor = true;
            btnAndTrain.Click += btnAndTrain_Click;
            // 
            // btnAndTest
            // 
            btnAndTest.Location = new Point(431, 229);
            btnAndTest.Name = "btnAndTest";
            btnAndTest.Size = new Size(161, 72);
            btnAndTest.TabIndex = 7;
            btnAndTest.Text = "Test\r\nNeural Network";
            btnAndTest.UseVisualStyleBackColor = true;
            btnAndTest.Click += btnAndTest_Click;
            // 
            // btnAndCreate
            // 
            btnAndCreate.Location = new Point(57, 229);
            btnAndCreate.Name = "btnAndCreate";
            btnAndCreate.Size = new Size(161, 72);
            btnAndCreate.TabIndex = 6;
            btnAndCreate.Text = "Create\r\nNew BPNN";
            btnAndCreate.UseVisualStyleBackColor = true;
            btnAndCreate.Click += btnAndCreate_Click;
            // 
            // tbAndResult
            // 
            tbAndResult.Location = new Point(356, 118);
            tbAndResult.Name = "tbAndResult";
            tbAndResult.Size = new Size(236, 27);
            tbAndResult.TabIndex = 5;
            // 
            // tbAndD
            // 
            tbAndD.Location = new Point(57, 183);
            tbAndD.Name = "tbAndD";
            tbAndD.Size = new Size(236, 27);
            tbAndD.TabIndex = 4;
            // 
            // tbAndC
            // 
            tbAndC.Location = new Point(57, 150);
            tbAndC.Name = "tbAndC";
            tbAndC.Size = new Size(236, 27);
            tbAndC.TabIndex = 3;
            // 
            // tbAndB
            // 
            tbAndB.Location = new Point(57, 117);
            tbAndB.Name = "tbAndB";
            tbAndB.Size = new Size(236, 27);
            tbAndB.TabIndex = 2;
            // 
            // tbAndA
            // 
            tbAndA.Location = new Point(57, 84);
            tbAndA.Name = "tbAndA";
            tbAndA.Size = new Size(236, 27);
            tbAndA.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 407);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Back Propagation";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox tbOrB;
        private TextBox tbOrA;
        private TextBox tbOrResult;
        private Button btnOrTrain;
        private Button btnOrTest;
        private Button btnOrCreate;
        private TextBox tbAndResult;
        private TextBox tbAndD;
        private TextBox tbAndC;
        private TextBox tbAndB;
        private TextBox tbAndA;
        private Button btnAndTrain;
        private Button btnAndTest;
        private Button btnAndCreate;
    }
}
