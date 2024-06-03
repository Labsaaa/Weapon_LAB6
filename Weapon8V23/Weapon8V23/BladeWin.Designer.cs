namespace Weapon8V23
{
    partial class BladeWin
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
            bladeHandCount = new NumericUpDown();
            label5 = new Label();
            bladeName = new TextBox();
            bladeWeight = new TextBox();
            bladeLength = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            setBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)bladeHandCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bladeLength).BeginInit();
            SuspendLayout();
            // 
            // bladeHandCount
            // 
            bladeHandCount.Location = new Point(166, 134);
            bladeHandCount.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            bladeHandCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            bladeHandCount.Name = "bladeHandCount";
            bladeHandCount.Size = new Size(163, 27);
            bladeHandCount.TabIndex = 29;
            bladeHandCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 134);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 28;
            label5.Text = "Hand Count";
            // 
            // bladeName
            // 
            bladeName.Location = new Point(166, 12);
            bladeName.Name = "bladeName";
            bladeName.Size = new Size(163, 27);
            bladeName.TabIndex = 27;
            bladeName.Text = "Knife";
            // 
            // bladeWeight
            // 
            bladeWeight.Location = new Point(166, 52);
            bladeWeight.Name = "bladeWeight";
            bladeWeight.Size = new Size(163, 27);
            bladeWeight.TabIndex = 26;
            bladeWeight.Text = "490";
            // 
            // bladeLength
            // 
            bladeLength.Location = new Point(166, 91);
            bladeLength.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            bladeLength.Name = "bladeLength";
            bladeLength.Size = new Size(163, 27);
            bladeLength.TabIndex = 25;
            bladeLength.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 93);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 24;
            label3.Text = "Length";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 55);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 23;
            label2.Text = "Weight";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 22;
            label1.Text = "Name";
            // 
            // setBtn
            // 
            setBtn.Location = new Point(114, 206);
            setBtn.Name = "setBtn";
            setBtn.Size = new Size(134, 48);
            setBtn.TabIndex = 30;
            setBtn.Text = "Set";
            setBtn.UseVisualStyleBackColor = true;
            setBtn.Click += onSetClick;
            // 
            // BladeWin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 266);
            Controls.Add(setBtn);
            Controls.Add(bladeHandCount);
            Controls.Add(label5);
            Controls.Add(bladeName);
            Controls.Add(bladeWeight);
            Controls.Add(bladeLength);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BladeWin";
            Text = "Blade Properties";
            Load += BladeWin_Load;
            ((System.ComponentModel.ISupportInitialize)bladeHandCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)bladeLength).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown bladeHandCount;
        private Label label5;
        private TextBox bladeName;
        private TextBox bladeWeight;
        private NumericUpDown bladeLength;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button setBtn;
    }
}