namespace TaskManagement
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            BtnAdd = new Guna.UI2.WinForms.Guna2Button();
            txtTask = new Guna.UI2.WinForms.Guna2TextBox();
            listBox1 = new ListBox();
            BtnCompl = new Guna.UI2.WinForms.Guna2Button();
            BtnDelet = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // BtnAdd
            // 
            BtnAdd.BorderRadius = 12;
            BtnAdd.CustomizableEdges = customizableEdges1;
            BtnAdd.DisabledState.BorderColor = Color.DarkGray;
            BtnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnAdd.Font = new Font("Segoe UI", 9F);
            BtnAdd.ForeColor = Color.White;
            BtnAdd.Location = new Point(12, 66);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BtnAdd.Size = new Size(113, 37);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "ADD";
            BtnAdd.Click += BtnAdd_Click;
            // 
            // txtTask
            // 
            txtTask.CustomizableEdges = customizableEdges3;
            txtTask.DefaultText = "";
            txtTask.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTask.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTask.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTask.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTask.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTask.Font = new Font("Segoe UI", 9F);
            txtTask.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTask.Location = new Point(13, 13);
            txtTask.Margin = new Padding(4, 5, 4, 5);
            txtTask.Name = "txtTask";
            txtTask.PlaceholderText = "";
            txtTask.SelectedText = "";
            txtTask.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtTask.Size = new Size(429, 45);
            txtTask.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 184);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 254);
            listBox1.TabIndex = 2;
            // 
            // BtnCompl
            // 
            BtnCompl.BorderRadius = 12;
            BtnCompl.CustomizableEdges = customizableEdges5;
            BtnCompl.DisabledState.BorderColor = Color.DarkGray;
            BtnCompl.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnCompl.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnCompl.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnCompl.Font = new Font("Segoe UI", 9F);
            BtnCompl.ForeColor = Color.White;
            BtnCompl.Location = new Point(675, 141);
            BtnCompl.Name = "BtnCompl";
            BtnCompl.ShadowDecoration.CustomizableEdges = customizableEdges6;
            BtnCompl.Size = new Size(113, 37);
            BtnCompl.TabIndex = 3;
            BtnCompl.Text = "Comblete";
            BtnCompl.Click += BtnCompl_Click;
            // 
            // BtnDelet
            // 
            BtnDelet.BorderRadius = 12;
            BtnDelet.CustomizableEdges = customizableEdges7;
            BtnDelet.DisabledState.BorderColor = Color.DarkGray;
            BtnDelet.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnDelet.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnDelet.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnDelet.Font = new Font("Segoe UI", 9F);
            BtnDelet.ForeColor = Color.White;
            BtnDelet.Location = new Point(528, 141);
            BtnDelet.Name = "BtnDelet";
            BtnDelet.ShadowDecoration.CustomizableEdges = customizableEdges8;
            BtnDelet.Size = new Size(113, 37);
            BtnDelet.TabIndex = 4;
            BtnDelet.Text = "Delete";
            BtnDelet.Click += BtnDelet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnDelet);
            Controls.Add(BtnCompl);
            Controls.Add(listBox1);
            Controls.Add(txtTask);
            Controls.Add(BtnAdd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtTask;
        private ListBox listBox1;
        private Guna.UI2.WinForms.Guna2Button BtnCompl;
        private Guna.UI2.WinForms.Guna2Button BtnDelet;
    }
}
