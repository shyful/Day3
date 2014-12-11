namespace GetdoubleValueApp
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
            this.Input = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputNumber = new System.Windows.Forms.TextBox();
            this.outputNumber = new System.Windows.Forms.TextBox();
            this.Finf_2_Times_Number = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.AutoSize = true;
            this.Input.Location = new System.Drawing.Point(43, 49);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(79, 13);
            this.Input.TabIndex = 0;
            this.Input.Text = "Insert Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output Number :";
            // 
            // inputNumber
            // 
            this.inputNumber.Location = new System.Drawing.Point(128, 46);
            this.inputNumber.Name = "inputNumber";
            this.inputNumber.Size = new System.Drawing.Size(100, 20);
            this.inputNumber.TabIndex = 2;
            // 
            // outputNumber
            // 
            this.outputNumber.Location = new System.Drawing.Point(128, 133);
            this.outputNumber.Name = "outputNumber";
            this.outputNumber.Size = new System.Drawing.Size(100, 20);
            this.outputNumber.TabIndex = 3;
            // 
            // Finf_2_Times_Number
            // 
            this.Finf_2_Times_Number.Location = new System.Drawing.Point(84, 95);
            this.Finf_2_Times_Number.Name = "Finf_2_Times_Number";
            this.Finf_2_Times_Number.Size = new System.Drawing.Size(119, 23);
            this.Finf_2_Times_Number.TabIndex = 4;
            this.Finf_2_Times_Number.Text = "Find 2 Times Number";
            this.Finf_2_Times_Number.UseVisualStyleBackColor = true;
            this.Finf_2_Times_Number.Click += new System.EventHandler(this.Finf_2_Times_Number_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Finf_2_Times_Number);
            this.Controls.Add(this.outputNumber);
            this.Controls.Add(this.inputNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputNumber;
        private System.Windows.Forms.TextBox outputNumber;
        private System.Windows.Forms.Button Finf_2_Times_Number;
    }
}

