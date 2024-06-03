namespace Weapon8V23
{
    partial class MainWin
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
            weaponList = new ListBox();
            label1 = new Label();
            addBtn = new Button();
            editBtn = new Button();
            removeBtn = new Button();
            label2 = new Label();
            costLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // weaponList
            // 
            weaponList.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            weaponList.FormattingEnabled = true;
            weaponList.ItemHeight = 15;
            weaponList.Location = new Point(10, 58);
            weaponList.Margin = new Padding(3, 2, 3, 2);
            weaponList.Name = "weaponList";
            weaponList.Size = new Size(401, 214);
            weaponList.TabIndex = 0;
            weaponList.Click += onWeaponListClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 1;
            label1.Text = "List of weapons";
            // 
            // addBtn
            // 
            addBtn.Location = new Point(10, 332);
            addBtn.Margin = new Padding(3, 2, 3, 2);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(117, 36);
            addBtn.TabIndex = 2;
            addBtn.Text = "Add weapon";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += onAddWeapon;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(150, 332);
            editBtn.Margin = new Padding(3, 2, 3, 2);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(117, 36);
            editBtn.TabIndex = 3;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += onEditWeapon;
            // 
            // removeBtn
            // 
            removeBtn.Location = new Point(294, 332);
            removeBtn.Margin = new Padding(3, 2, 3, 2);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(117, 36);
            removeBtn.TabIndex = 4;
            removeBtn.Text = "Remove";
            removeBtn.UseVisualStyleBackColor = true;
            removeBtn.Click += onRemoveWeapon;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 289);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Total cost";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(94, 289);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(13, 15);
            costLabel.TabIndex = 6;
            costLabel.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 41);
            label3.Name = "label3";
            label3.Size = new Size(233, 15);
            label3.TabIndex = 7;
            label3.Text = "Name                               Weight                     ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(368, 41);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 8;
            label4.Text = "Cost";
            // 
            // MainWin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 383);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(costLabel);
            Controls.Add(label2);
            Controls.Add(removeBtn);
            Controls.Add(editBtn);
            Controls.Add(addBtn);
            Controls.Add(label1);
            Controls.Add(weaponList);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(440, 422);
            MinimumSize = new Size(440, 422);
            Name = "MainWin";
            Text = "Weapon calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox weaponList;
        private Label label1;
        private Button addBtn;
        private Button editBtn;
        private Button removeBtn;
        private Label label2;
        private Label costLabel;
        private Label label3;
        private Label label4;
    }
}
