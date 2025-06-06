namespace AutoText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnEscribir = new Button();
            chkHidePass = new CheckBox();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            chkEnter = new CheckBox();
            txtCombo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnEscribir
            // 
            btnEscribir.Location = new Point(117, 49);
            btnEscribir.Name = "btnEscribir";
            btnEscribir.Size = new Size(61, 23);
            btnEscribir.TabIndex = 0;
            btnEscribir.Text = "Write";
            btnEscribir.UseVisualStyleBackColor = true;
            btnEscribir.Click += BtnWrite_Click;
            // 
            // chkHidePass
            // 
            chkHidePass.AutoSize = true;
            chkHidePass.Checked = true;
            chkHidePass.CheckState = CheckState.Checked;
            chkHidePass.Location = new Point(12, 1);
            chkHidePass.Name = "chkHidePass";
            chkHidePass.Size = new Size(85, 19);
            chkHidePass.TabIndex = 3;
            chkHidePass.Text = "Hide/Show";
            chkHidePass.UseVisualStyleBackColor = true;
            chkHidePass.CheckedChanged += chkPasswordType_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 54);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 4;
            label1.Text = "Wait secs:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(75, 49);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(36, 23);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // chkEnter
            // 
            chkEnter.AutoSize = true;
            chkEnter.Location = new Point(103, 1);
            chkEnter.Name = "chkEnter";
            chkEnter.Size = new Size(75, 19);
            chkEnter.TabIndex = 7;
            chkEnter.Text = "Use enter";
            chkEnter.UseVisualStyleBackColor = true;
            // 
            // txtCombo
            // 
            txtCombo.AllowDrop = true;
            txtCombo.FormattingEnabled = true;
            txtCombo.Location = new Point(10, 20);
            txtCombo.Name = "txtCombo";
            txtCombo.Size = new Size(168, 23);
            txtCombo.TabIndex = 8;
            txtCombo.KeyDown += txtCombo_KeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(187, 79);
            Controls.Add(txtCombo);
            Controls.Add(chkEnter);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(chkHidePass);
            Controls.Add(btnEscribir);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "AutoText 1.0.4.1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEscribir;
        private CheckBox chkHidePass;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private CheckBox chkEnter;
        private ComboBox txtCombo;
    }
}
