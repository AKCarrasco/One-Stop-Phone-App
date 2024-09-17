namespace One_Stop_Phone_App
{
    partial class OneStopPhoneApp
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
            this.tradeinLabel = new System.Windows.Forms.Label();
            this.phoneComboBox = new System.Windows.Forms.ComboBox();
            this.worthLabel = new System.Windows.Forms.Label();
            this.pconditionComboBox = new System.Windows.Forms.ComboBox();
            this.transactionalListBox = new System.Windows.Forms.ListBox();
            this.confirmationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tradeinLabel
            // 
            this.tradeinLabel.AutoSize = true;
            this.tradeinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tradeinLabel.Location = new System.Drawing.Point(68, 57);
            this.tradeinLabel.Name = "tradeinLabel";
            this.tradeinLabel.Size = new System.Drawing.Size(117, 16);
            this.tradeinLabel.TabIndex = 0;
            this.tradeinLabel.Text = "Phone to Trade-in:";
            this.tradeinLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // phoneComboBox
            // 
            this.phoneComboBox.FormattingEnabled = true;
            this.phoneComboBox.Items.AddRange(new object[] {
            "Samsung",
            "Apple",
            "LG",
            "Xiaomi"});
            this.phoneComboBox.Location = new System.Drawing.Point(191, 56);
            this.phoneComboBox.Name = "phoneComboBox";
            this.phoneComboBox.Size = new System.Drawing.Size(121, 21);
            this.phoneComboBox.TabIndex = 1;
            // 
            // worthLabel
            // 
            this.worthLabel.AutoSize = true;
            this.worthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worthLabel.Location = new System.Drawing.Point(392, 59);
            this.worthLabel.Name = "worthLabel";
            this.worthLabel.Size = new System.Drawing.Size(108, 16);
            this.worthLabel.TabIndex = 2;
            this.worthLabel.Text = "Phone Condition:";
            // 
            // pconditionComboBox
            // 
            this.pconditionComboBox.FormattingEnabled = true;
            this.pconditionComboBox.Items.AddRange(new object[] {
            "Like New",
            "Used",
            "Broken"});
            this.pconditionComboBox.Location = new System.Drawing.Point(507, 59);
            this.pconditionComboBox.Name = "pconditionComboBox";
            this.pconditionComboBox.Size = new System.Drawing.Size(121, 21);
            this.pconditionComboBox.TabIndex = 3;
            // 
            // transactionalListBox
            // 
            this.transactionalListBox.FormattingEnabled = true;
            this.transactionalListBox.Location = new System.Drawing.Point(187, 161);
            this.transactionalListBox.Name = "transactionalListBox";
            this.transactionalListBox.Size = new System.Drawing.Size(398, 95);
            this.transactionalListBox.TabIndex = 4;
            this.transactionalListBox.SelectedIndexChanged += new System.EventHandler(this.transactionalListBox_SelectedIndexChanged);
            // 
            // confirmationButton
            // 
            this.confirmationButton.Location = new System.Drawing.Point(330, 132);
            this.confirmationButton.Name = "confirmationButton";
            this.confirmationButton.Size = new System.Drawing.Size(75, 23);
            this.confirmationButton.TabIndex = 5;
            this.confirmationButton.Text = "Confirm";
            this.confirmationButton.UseVisualStyleBackColor = true;
            // 
            // OneStopPhoneApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirmationButton);
            this.Controls.Add(this.transactionalListBox);
            this.Controls.Add(this.pconditionComboBox);
            this.Controls.Add(this.worthLabel);
            this.Controls.Add(this.phoneComboBox);
            this.Controls.Add(this.tradeinLabel);
            this.Name = "OneStopPhoneApp";
            this.Text = "One Stop Phone App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tradeinLabel;
        private System.Windows.Forms.ComboBox phoneComboBox;
        private System.Windows.Forms.Label worthLabel;
        private System.Windows.Forms.ComboBox pconditionComboBox;
        private System.Windows.Forms.ListBox transactionalListBox;
        private System.Windows.Forms.Button confirmationButton;
    }
}

