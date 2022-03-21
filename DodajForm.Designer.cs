
namespace Okna_dialogowe
{
    partial class DodajForm
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
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.wiekTextBox = new System.Windows.Forms.TextBox();
            this.doddawanieButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.miastoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.anulujButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imieTextBox
            // 
            this.imieTextBox.Location = new System.Drawing.Point(148, 12);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(317, 22);
            this.imieTextBox.TabIndex = 0;
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.Location = new System.Drawing.Point(148, 40);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(317, 22);
            this.nazwiskoTextBox.TabIndex = 1;
            // 
            // wiekTextBox
            // 
            this.wiekTextBox.Location = new System.Drawing.Point(148, 68);
            this.wiekTextBox.Name = "wiekTextBox";
            this.wiekTextBox.Size = new System.Drawing.Size(317, 22);
            this.wiekTextBox.TabIndex = 2;
            // 
            // doddawanieButton
            // 
            this.doddawanieButton.Location = new System.Drawing.Point(12, 149);
            this.doddawanieButton.Name = "doddawanieButton";
            this.doddawanieButton.Size = new System.Drawing.Size(160, 23);
            this.doddawanieButton.TabIndex = 3;
            this.doddawanieButton.Text = "Ok";
            this.doddawanieButton.UseVisualStyleBackColor = true;
            this.doddawanieButton.Click += new System.EventHandler(this.doddawanieButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rok urodzenia";
            // 
            // miastoTextBox
            // 
            this.miastoTextBox.Location = new System.Drawing.Point(148, 98);
            this.miastoTextBox.Name = "miastoTextBox";
            this.miastoTextBox.Size = new System.Drawing.Size(317, 22);
            this.miastoTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Miasto";
            // 
            // anulujButton
            // 
            this.anulujButton.Location = new System.Drawing.Point(305, 149);
            this.anulujButton.Name = "anulujButton";
            this.anulujButton.Size = new System.Drawing.Size(160, 23);
            this.anulujButton.TabIndex = 10;
            this.anulujButton.Text = "Anuluj";
            this.anulujButton.UseVisualStyleBackColor = true;
            this.anulujButton.Click += new System.EventHandler(this.anulujButton_Click);
            // 
            // DodajForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 184);
            this.Controls.Add(this.anulujButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.miastoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doddawanieButton);
            this.Controls.Add(this.wiekTextBox);
            this.Controls.Add(this.nazwiskoTextBox);
            this.Controls.Add(this.imieTextBox);
            this.Name = "DodajForm";
            this.Text = "DodajForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imieTextBox;
        private System.Windows.Forms.TextBox nazwiskoTextBox;
        private System.Windows.Forms.TextBox wiekTextBox;
        private System.Windows.Forms.Button doddawanieButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox miastoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button anulujButton;
    }
}