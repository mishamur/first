
namespace lab5
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTang = new System.Windows.Forms.RadioButton();
            this.radioButtonCosH = new System.Windows.Forms.RadioButton();
            this.radioButtonSinxSin = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSinxSin);
            this.groupBox1.Controls.Add(this.radioButtonCosH);
            this.groupBox1.Controls.Add(this.radioButtonTang);
            this.groupBox1.Location = new System.Drawing.Point(578, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButtonTang
            // 
            this.radioButtonTang.AutoSize = true;
            this.radioButtonTang.Location = new System.Drawing.Point(17, 37);
            this.radioButtonTang.Name = "radioButtonTang";
            this.radioButtonTang.Size = new System.Drawing.Size(51, 19);
            this.radioButtonTang.TabIndex = 0;
            this.radioButtonTang.TabStop = true;
            this.radioButtonTang.Text = "Tg(x)";
            this.radioButtonTang.UseVisualStyleBackColor = true;
            // 
            // radioButtonCosH
            // 
            this.radioButtonCosH.AutoSize = true;
            this.radioButtonCosH.Location = new System.Drawing.Point(17, 73);
            this.radioButtonCosH.Name = "radioButtonCosH";
            this.radioButtonCosH.Size = new System.Drawing.Size(52, 19);
            this.radioButtonCosH.TabIndex = 1;
            this.radioButtonCosH.TabStop = true;
            this.radioButtonCosH.Text = "ch(x)";
            this.radioButtonCosH.UseVisualStyleBackColor = true;
            // 
            // radioButtonSinxSin
            // 
            this.radioButtonSinxSin.AutoSize = true;
            this.radioButtonSinxSin.Location = new System.Drawing.Point(17, 108);
            this.radioButtonSinxSin.Name = "radioButtonSinxSin";
            this.radioButtonSinxSin.Size = new System.Drawing.Size(94, 19);
            this.radioButtonSinxSin.TabIndex = 2;
            this.radioButtonSinxSin.TabStop = true;
            this.radioButtonSinxSin.Text = "sin(x) * sin(x)";
            this.radioButtonSinxSin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSinxSin;
        private System.Windows.Forms.RadioButton radioButtonCosH;
        private System.Windows.Forms.RadioButton radioButtonTang;
    }
}

