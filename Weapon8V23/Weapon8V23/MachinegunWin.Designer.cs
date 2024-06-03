namespace Weapon8V23
{
    partial class MachinegunWin
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
            gunCalibre = new TextBox();
            gunName = new TextBox();
            gunWeight = new TextBox();
            gunCapacity = new NumericUpDown();
            setBtn = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            gunRapidity = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)gunCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gunRapidity).BeginInit();
            SuspendLayout();
            // 
            // gunCalibre
            // 
            gunCalibre.Location = new Point(160, 131);
            gunCalibre.Name = "gunCalibre";
            gunCalibre.Size = new Size(163, 27);
            gunCalibre.TabIndex = 19;
            gunCalibre.Text = "7,62";
            // 
            // gunName
            // 
            gunName.Location = new Point(160, 12);
            gunName.Name = "gunName";
            gunName.Size = new Size(163, 27);
            gunName.TabIndex = 18;
            gunName.Text = "AK-74";
            // 
            // gunWeight
            // 
            gunWeight.Location = new Point(160, 52);
            gunWeight.Name = "gunWeight";
            gunWeight.Size = new Size(163, 27);
            gunWeight.TabIndex = 17;
            gunWeight.Text = "6400";
            // 
            // gunCapacity
            // 
            gunCapacity.Location = new Point(160, 91);
            gunCapacity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            gunCapacity.Name = "gunCapacity";
            gunCapacity.Size = new Size(163, 27);
            gunCapacity.TabIndex = 16;
            gunCapacity.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // setBtn
            // 
            setBtn.Location = new Point(106, 237);
            setBtn.Name = "setBtn";
            setBtn.Size = new Size(134, 48);
            setBtn.TabIndex = 15;
            setBtn.Text = "Set";
            setBtn.UseVisualStyleBackColor = true;
            setBtn.Click += onSetClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 134);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 14;
            label4.Text = "Calibre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 93);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 13;
            label3.Text = "Capacity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 55);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 12;
            label2.Text = "Weight";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 15);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 11;
            label1.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 178);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 20;
            label5.Text = "Rapidity";
            // 
            // gunRapidity
            // 
            gunRapidity.Location = new Point(160, 178);
            gunRapidity.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            gunRapidity.Name = "gunRapidity";
            gunRapidity.Size = new Size(163, 27);
            gunRapidity.TabIndex = 21;
            gunRapidity.Value = new decimal(new int[] { 600, 0, 0, 0 });
            // 
            // MachinegunWin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 297);
            Controls.Add(gunRapidity);
            Controls.Add(label5);
            Controls.Add(gunCalibre);
            Controls.Add(gunName);
            Controls.Add(gunWeight);
            Controls.Add(gunCapacity);
            Controls.Add(setBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(365, 344);
            MinimumSize = new Size(365, 344);
            Name = "MachinegunWin";
            Text = "Machinegun Properties";
            Load += MachinegunWin_Load;
            ((System.ComponentModel.ISupportInitialize)gunCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)gunRapidity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox gunCalibre;
        private TextBox gunName;
        private TextBox gunWeight;
        private NumericUpDown gunCapacity;
        private Button setBtn;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private NumericUpDown gunRapidity;
    }
}