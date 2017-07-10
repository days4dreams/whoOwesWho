namespace whoOwesWho
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
            this.joesCashLabel = new System.Windows.Forms.Label();
            this.bobsCashLabel = new System.Windows.Forms.Label();
            this.bankCashLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.joeGivesBob = new System.Windows.Forms.Button();
            this.bobGivesJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joesCashLabel
            // 
            this.joesCashLabel.AutoSize = true;
            this.joesCashLabel.Location = new System.Drawing.Point(12, 38);
            this.joesCashLabel.Name = "joesCashLabel";
            this.joesCashLabel.Size = new System.Drawing.Size(53, 13);
            this.joesCashLabel.TabIndex = 0;
            this.joesCashLabel.Text = "Joe has $";
            // 
            // bobsCashLabel
            // 
            this.bobsCashLabel.AutoSize = true;
            this.bobsCashLabel.Location = new System.Drawing.Point(12, 73);
            this.bobsCashLabel.Name = "bobsCashLabel";
            this.bobsCashLabel.Size = new System.Drawing.Size(55, 13);
            this.bobsCashLabel.TabIndex = 1;
            this.bobsCashLabel.Text = "Bob has $";
            // 
            // bankCashLabel
            // 
            this.bankCashLabel.AutoSize = true;
            this.bankCashLabel.Location = new System.Drawing.Point(12, 110);
            this.bankCashLabel.Name = "bankCashLabel";
            this.bankCashLabel.Size = new System.Drawing.Size(83, 13);
            this.bankCashLabel.TabIndex = 2;
            this.bankCashLabel.Text = "The Bank has $";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Give $10 to Joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Receive $5 from Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // joeGivesBob
            // 
            this.joeGivesBob.Location = new System.Drawing.Point(12, 187);
            this.joeGivesBob.Name = "joeGivesBob";
            this.joeGivesBob.Size = new System.Drawing.Size(100, 35);
            this.joeGivesBob.TabIndex = 5;
            this.joeGivesBob.Text = "Joe gives $10 to Bob";
            this.joeGivesBob.UseVisualStyleBackColor = true;
            this.joeGivesBob.Click += new System.EventHandler(this.joeGivesBob_Click);
            // 
            // bobGivesJoe
            // 
            this.bobGivesJoe.Location = new System.Drawing.Point(118, 187);
            this.bobGivesJoe.Name = "bobGivesJoe";
            this.bobGivesJoe.Size = new System.Drawing.Size(100, 35);
            this.bobGivesJoe.TabIndex = 6;
            this.bobGivesJoe.Text = "Bob gives $5 to Joe";
            this.bobGivesJoe.UseVisualStyleBackColor = true;
            this.bobGivesJoe.Click += new System.EventHandler(this.bobGivesJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 248);
            this.Controls.Add(this.bobGivesJoe);
            this.Controls.Add(this.joeGivesBob);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bankCashLabel);
            this.Controls.Add(this.bobsCashLabel);
            this.Controls.Add(this.joesCashLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label joesCashLabel;
        private System.Windows.Forms.Label bobsCashLabel;
        private System.Windows.Forms.Label bankCashLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button joeGivesBob;
        private System.Windows.Forms.Button bobGivesJoe;
    }
}

