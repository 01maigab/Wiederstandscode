namespace Forms_Widerstand_09
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmboBox_1 = new System.Windows.Forms.ComboBox();
            this.cmboBox_2 = new System.Windows.Forms.ComboBox();
            this.cmboBox_3 = new System.Windows.Forms.ComboBox();
            this.cmboBox_4 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cmd_Berechnen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmboBox_1
            // 
            this.cmboBox_1.FormattingEnabled = true;
            this.cmboBox_1.Items.AddRange(new object[] {
            "Schwarz",
            "Braun ",
            "Rot",
            "Orange",
            "Gelb",
            "Grün",
            "Blau"});
            this.cmboBox_1.Location = new System.Drawing.Point(12, 39);
            this.cmboBox_1.Name = "cmboBox_1";
            this.cmboBox_1.Size = new System.Drawing.Size(121, 21);
            this.cmboBox_1.TabIndex = 0;
            this.cmboBox_1.SelectedIndexChanged += new System.EventHandler(this.cmboBox_1_SelectedIndexChanged);
            // 
            // cmboBox_2
            // 
            this.cmboBox_2.FormattingEnabled = true;
            this.cmboBox_2.Items.AddRange(new object[] {
            "Schwarz",
            "Braun ",
            "Rot",
            "Orange",
            "Gelb",
            "Grün",
            "Blau"});
            this.cmboBox_2.Location = new System.Drawing.Point(139, 39);
            this.cmboBox_2.Name = "cmboBox_2";
            this.cmboBox_2.Size = new System.Drawing.Size(121, 21);
            this.cmboBox_2.TabIndex = 1;
            // 
            // cmboBox_3
            // 
            this.cmboBox_3.FormattingEnabled = true;
            this.cmboBox_3.Items.AddRange(new object[] {
            "Schwarz",
            "Braun ",
            "Rot",
            "Orange",
            "Gelb",
            "Grün",
            "Blau"});
            this.cmboBox_3.Location = new System.Drawing.Point(266, 39);
            this.cmboBox_3.Name = "cmboBox_3";
            this.cmboBox_3.Size = new System.Drawing.Size(121, 21);
            this.cmboBox_3.TabIndex = 2;
            // 
            // cmboBox_4
            // 
            this.cmboBox_4.FormattingEnabled = true;
            this.cmboBox_4.Items.AddRange(new object[] {
            "Grau",
            "Gold",
            "Silver"});
            this.cmboBox_4.Location = new System.Drawing.Point(393, 39);
            this.cmboBox_4.Name = "cmboBox_4";
            this.cmboBox_4.Size = new System.Drawing.Size(121, 21);
            this.cmboBox_4.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 307);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(287, 307);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // cmd_Berechnen
            // 
            this.cmd_Berechnen.Location = new System.Drawing.Point(213, 206);
            this.cmd_Berechnen.Name = "cmd_Berechnen";
            this.cmd_Berechnen.Size = new System.Drawing.Size(125, 50);
            this.cmd_Berechnen.TabIndex = 6;
            this.cmd_Berechnen.Text = "Berechnen";
            this.cmd_Berechnen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 535);
            this.Controls.Add(this.cmd_Berechnen);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmboBox_4);
            this.Controls.Add(this.cmboBox_3);
            this.Controls.Add(this.cmboBox_2);
            this.Controls.Add(this.cmboBox_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboBox_1;
        private System.Windows.Forms.ComboBox cmboBox_2;
        private System.Windows.Forms.ComboBox cmboBox_3;
        private System.Windows.Forms.ComboBox cmboBox_4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button cmd_Berechnen;
    }
}

