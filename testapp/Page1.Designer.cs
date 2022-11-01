namespace testapp
{
    partial class Page1
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

        #region Wisej Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new Wisej.Web.Panel();
            this.label2 = new Wisej.Web.Label();
            this.button1 = new Wisej.Web.Button();
            this.label1 = new Wisej.Web.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = Wisej.Web.BorderStyle.Double;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(31, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 366);
            this.panel1.TabIndex = 0;
            this.panel1.Text = "Show Page";
            this.panel1.PanelCollapsed += new System.EventHandler(this.panel1_PanelCollapsed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(457, 84);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show page 2 on Panel";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(695, 542);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Panel panel1;
        private Wisej.Web.Button button1;
        private Wisej.Web.Label label2;
        private Wisej.Web.Label label1;
    }
}
