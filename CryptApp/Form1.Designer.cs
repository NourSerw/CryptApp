namespace CryptApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.inputText = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputCrypt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.result_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert Text here";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(29, 90);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(100, 20);
            this.inputText.TabIndex = 2;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(26, 181);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(25, 13);
            this.result.TabIndex = 3;
            this.result.Text = "Null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Insert Text here";
            // 
            // inputCrypt
            // 
            this.inputCrypt.Location = new System.Drawing.Point(213, 90);
            this.inputCrypt.Name = "inputCrypt";
            this.inputCrypt.Size = new System.Drawing.Size(100, 20);
            this.inputCrypt.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Decrypt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // result_2
            // 
            this.result_2.AutoSize = true;
            this.result_2.Location = new System.Drawing.Point(210, 181);
            this.result_2.Name = "result_2";
            this.result_2.Size = new System.Drawing.Size(25, 13);
            this.result_2.TabIndex = 7;
            this.result_2.Text = "Null";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 254);
            this.Controls.Add(this.result_2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.inputCrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CryptoFunko";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputCrypt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label result_2;
    }
}

