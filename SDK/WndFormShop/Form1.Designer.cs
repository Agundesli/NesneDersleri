
namespace WndFormShop
{
    partial class Form1
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
            this.lstefekler = new System.Windows.Forms.ListBox();
            this.txtmsj = new System.Windows.Forms.TextBox();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.btnuygula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstefekler
            // 
            this.lstefekler.FormattingEnabled = true;
            this.lstefekler.ItemHeight = 16;
            this.lstefekler.Location = new System.Drawing.Point(58, 19);
            this.lstefekler.Name = "lstefekler";
            this.lstefekler.Size = new System.Drawing.Size(276, 308);
            this.lstefekler.TabIndex = 0;
            // 
            // txtmsj
            // 
            this.txtmsj.Location = new System.Drawing.Point(452, 32);
            this.txtmsj.Name = "txtmsj";
            this.txtmsj.Size = new System.Drawing.Size(312, 22);
            this.txtmsj.TabIndex = 1;
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(458, 81);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(46, 17);
            this.lblsonuc.TabIndex = 2;
            this.lblsonuc.Text = "label1";
            // 
            // btnuygula
            // 
            this.btnuygula.Location = new System.Drawing.Point(452, 158);
            this.btnuygula.Name = "btnuygula";
            this.btnuygula.Size = new System.Drawing.Size(135, 50);
            this.btnuygula.TabIndex = 3;
            this.btnuygula.Text = "Uygula";
            this.btnuygula.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 450);
            this.Controls.Add(this.btnuygula);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.txtmsj);
            this.Controls.Add(this.lstefekler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstefekler;
        private System.Windows.Forms.TextBox txtmsj;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.Button btnuygula;
    }
}

