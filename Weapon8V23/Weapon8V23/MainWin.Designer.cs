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
            weaponList.Font = new Font("Liberation Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            weaponList.FormattingEnabled = true;
            weaponList.ItemHeight = 17;
            weaponList.Location = new Point(12, 78);
            weaponList.Name = "weaponList";
            weaponList.Size = new Size(458, 293);
            weaponList.TabIndex = 0;
            weaponList.Click += onWeaponListClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 1;
            label1.Text = "List of weapons";
            // 
            // addBtn
            // 
            addBtn.Location = new Point(12, 443);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(134, 48);
            addBtn.TabIndex = 2;
            addBtn.Text = "Add weapon";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += onAddWeapon;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(171, 443);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(134, 48);
            editBtn.TabIndex = 3;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += onEditWeapon;
            // 
            // removeBtn
            // 
            removeBtn.Location = new Point(336, 443);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(134, 48);
            removeBtn.TabIndex = 4;
            removeBtn.Text = "Remove";
            removeBtn.UseVisualStyleBackColor = true;
            removeBtn.Click += onRemoveWeapon;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 385);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 5;
            label2.Text = "Total cost";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(107, 385);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(17, 20);
            costLabel.TabIndex = 6;
            costLabel.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 55);
            label3.Name = "label3";
            label3.Size = new Size(304, 20);
            label3.TabIndex = 7;
            label3.Text = "Name                               Weight                     ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(420, 55);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 8;
            label4.Text = "Cost";
            // 
            // MainWin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 503);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(costLabel);
            Controls.Add(label2);
            Controls.Add(removeBtn);
            Controls.Add(editBtn);
            Controls.Add(addBtn);
            Controls.Add(label1);
            Controls.Add(weaponList);
            MaximumSize = new Size(500, 550);
            MinimumSize = new Size(500, 550);
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
