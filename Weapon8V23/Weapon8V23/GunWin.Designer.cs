namespace Weapon8V23
{
    partial class GunWin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            setBtn = new Button();
            gunCapacity = new NumericUpDown();
            gunWeight = new TextBox();
            gunName = new TextBox();
            gunCalibre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gunCapacity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 30);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 70);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 3;
            label2.Text = "Weight";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 108);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 4;
            label3.Text = "Capacity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 149);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 5;
            label4.Text = "Calibre";
            // 
            // setBtn
            // 
            setBtn.Location = new Point(107, 206);
            setBtn.Name = "setBtn";
            setBtn.Size = new Size(134, 48);
            setBtn.TabIndex = 6;
            setBtn.Text = "Set";
            setBtn.UseVisualStyleBackColor = true;
            setBtn.Click += onBtnSet;
            // 
            // gunCapacity
            // 
            gunCapacity.Location = new Point(166, 106);
            gunCapacity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            gunCapacity.Name = "gunCapacity";
            gunCapacity.Size = new Size(163, 27);
            gunCapacity.TabIndex = 7;
            gunCapacity.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // gunWeight
            // 
            gunWeight.Location = new Point(166, 67);
            gunWeight.Name = "gunWeight";
            gunWeight.Size = new Size(163, 27);
            gunWeight.TabIndex = 8;
            gunWeight.Text = "4300";
            // 
            // gunName
            // 
            gunName.Location = new Point(166, 27);
            gunName.Name = "gunName";
            gunName.Size = new Size(163, 27);
            gunName.TabIndex = 9;
            gunName.Text = "AK-47";
            // 
            // gunCalibre
            // 
            gunCalibre.Location = new Point(166, 146);
            gunCalibre.Name = "gunCalibre";
            gunCalibre.Size = new Size(163, 27);
            gunCalibre.TabIndex = 10;
            gunCalibre.Text = "5,45";
            // 
            // GunWin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 266);
            Controls.Add(gunCalibre);
            Controls.Add(gunName);
            Controls.Add(gunWeight);
            Controls.Add(gunCapacity);
            Controls.Add(setBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GunWin";
            Text = "Gun Properties";
            Load += GunWin_Load;
            ((System.ComponentModel.ISupportInitialize)gunCapacity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button setBtn;
        private NumericUpDown gunCapacity;
        private TextBox gunWeight;
        private TextBox gunName;
        private TextBox gunCalibre;
    }
}