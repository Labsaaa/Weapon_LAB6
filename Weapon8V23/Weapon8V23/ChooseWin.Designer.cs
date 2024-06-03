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
            gunBtn.Location = new Point(23, 27);
            gunBtn.Name = "gunBtn";
            gunBtn.Size = new Size(134, 48);
            gunBtn.TabIndex = 4;
            gunBtn.Text = "Create Gun";
            gunBtn.UseVisualStyleBackColor = true;
            gunBtn.Click += onCreateGun;
            // 
            // machinegunBtn
            // 
            machinegunBtn.Location = new Point(236, 27);
            machinegunBtn.Name = "machinegunBtn";
            machinegunBtn.Size = new Size(134, 48);
            machinegunBtn.TabIndex = 5;
            machinegunBtn.Text = "Create Machinegun";
            machinegunBtn.UseVisualStyleBackColor = true;
            machinegunBtn.Click += onCreateMachinegun;
            // 
            // bladeBtn
            // 
            bladeBtn.Location = new Point(126, 93);
            bladeBtn.Name = "bladeBtn";
            bladeBtn.Size = new Size(134, 48);
            bladeBtn.TabIndex = 6;
            bladeBtn.Text = "Create Blade";
            bladeBtn.UseVisualStyleBackColor = true;
            bladeBtn.Click += onCreateBlade;
            // 
            // ChooseWin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 153);
            Controls.Add(bladeBtn);
            Controls.Add(machinegunBtn);
            Controls.Add(gunBtn);
            MaximumSize = new Size(400, 200);
            MinimumSize = new Size(400, 200);
            Name = "ChooseWin";
            Text = "ChooseWin";
            ResumeLayout(false);
        }

        #endregion

        private Button gunBtn;
        private Button machinegunBtn;
        private Button bladeBtn;
    }
}