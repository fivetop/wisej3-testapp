namespace ts_page
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
            this.button1 = new Wisej.Web.Button();
            this.panel1 = new Wisej.Web.Panel();
            this.button2 = new Wisej.Web.Button();
            this.button3 = new Wisej.Web.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(33, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 430);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 27);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(245, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 27);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(695, 533);
            this.Text = "Page1";
            this.Load += new System.EventHandler(this.Page1_Load);
            this.ResumeLayout(false);

		}

        #endregion

        private Wisej.Web.Button button1;
        private Wisej.Web.Panel panel1;
        private Wisej.Web.Button button2;
        private Wisej.Web.Button button3;
    }
}

