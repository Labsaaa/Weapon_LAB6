namespace Weapon8V23
{
    partial class ChooseWin
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
            gunBtn = new Button();
            machinegunBtn = new Button();
            bladeBtn = new Button();
            SuspendLayout();
            // 
            // gunBtn
            // 
            gunBtn.Location = new Point(20, 20);
            gunBtn.Margin = new Padding(3, 2, 3, 2);
            gunBtn.Name = "gunBtn";
            gunBtn.Size = new Size(117, 36);
            gunBtn.TabIndex = 4;
            gunBtn.Text = "Create Gun";
            gunBtn.UseVisualStyleBackColor = true;
            gunBtn.Click += onCreateGun;
            // 
            // machinegunBtn
            // 
            machinegunBtn.Location = new Point(206, 20);
            machinegunBtn.Margin = new Padding(3, 2, 3, 2);
            machinegunBtn.Name = "machinegunBtn";
            machinegunBtn.Size = new Size(117, 36);
            machinegunBtn.TabIndex = 5;
            machinegunBtn.Text = "Create Machinegun";
            machinegunBtn.UseVisualStyleBackColor = true;
            machinegunBtn.Click += onCreateMachinegun;
            // 
            // bladeBtn
            // 
            bladeBtn.Location = new Point(110, 70);
            bladeBtn.Margin = new Padding(3, 2, 3, 2);
            bladeBtn.Name = "bladeBtn";
            bladeBtn.Size = new Size(117, 36);
            bladeBtn.TabIndex = 6;
            bladeBtn.Text = "Create Blade";
            bladeBtn.UseVisualStyleBackColor = true;
            bladeBtn.Click += onCreateBlade;
            // 
            // ChooseWin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 121);
            Controls.Add(bladeBtn);
            Controls.Add(machinegunBtn);
            Controls.Add(gunBtn);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(352, 160);
            MinimumSize = new Size(352, 160);
            Name = "ChooseWin";
            Text = "ChooseWin";
            Load += ChooseWin_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button gunBtn;
        private Button machinegunBtn;
        private Button bladeBtn;
    }
}