
namespace TrueOrFalse
{
    partial class FormMain
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
            this.lblFirst = new System.Windows.Forms.Label();
            this.txtBxFirst = new System.Windows.Forms.TextBox();
            this.txtBxLast = new System.Windows.Forms.TextBox();
            this.lblLast = new System.Windows.Forms.Label();
            this.rchTxtBxInsert = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirst.Location = new System.Drawing.Point(72, 65);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(120, 38);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "First Word";
            // 
            // txtBxFirst
            // 
            this.txtBxFirst.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBxFirst.Location = new System.Drawing.Point(219, 65);
            this.txtBxFirst.Name = "txtBxFirst";
            this.txtBxFirst.Size = new System.Drawing.Size(393, 40);
            this.txtBxFirst.TabIndex = 2;
      
            // 
            // txtBxLast
            // 
            this.txtBxLast.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBxLast.Location = new System.Drawing.Point(219, 131);
            this.txtBxLast.Name = "txtBxLast";
            this.txtBxLast.Size = new System.Drawing.Size(393, 40);
            this.txtBxLast.TabIndex = 4;
   
            // 
            // lblLast
            // 
            this.lblLast.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLast.Location = new System.Drawing.Point(72, 134);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(120, 38);
            this.lblLast.TabIndex = 3;
            this.lblLast.Text = "Last Word";
            // 
            // rchTxtBxInsert
            // 
            this.rchTxtBxInsert.Location = new System.Drawing.Point(219, 208);
            this.rchTxtBxInsert.Name = "rchTxtBxInsert";
            this.rchTxtBxInsert.Size = new System.Drawing.Size(393, 168);
            this.rchTxtBxInsert.TabIndex = 5;
            this.rchTxtBxInsert.Text = "";
         
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(124, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Text";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(219, 423);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(121, 51);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(491, 423);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(121, 51);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rchTxtBxInsert);
            this.Controls.Add(this.txtBxLast);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.txtBxFirst);
            this.Controls.Add(this.lblFirst);
            this.Name = "FormMain";
            this.Text = "TrueOrFalse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.TextBox txtBxFirst;
        private System.Windows.Forms.TextBox txtBxLast;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.RichTextBox rchTxtBxInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnReset;
    }
}

