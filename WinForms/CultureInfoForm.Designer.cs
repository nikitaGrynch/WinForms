namespace WinForms
{
    partial class CultureInfoForm
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
            this.components = new System.ComponentModel.Container();
            this.currentTimeListBox = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // currentTimeListBox
            // 
            this.currentTimeListBox.FormattingEnabled = true;
            this.currentTimeListBox.ItemHeight = 25;
            this.currentTimeListBox.Location = new System.Drawing.Point(26, 50);
            this.currentTimeListBox.Name = "currentTimeListBox";
            this.currentTimeListBox.Size = new System.Drawing.Size(420, 304);
            this.currentTimeListBox.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CultureInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.currentTimeListBox);
            this.Name = "CultureInfoForm";
            this.Text = "CultureInfoForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox currentTimeListBox;
        private System.Windows.Forms.Timer timer1;
    }
}