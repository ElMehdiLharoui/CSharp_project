
namespace MAthQuiz
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
            this.components = new System.ComponentModel.Container();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.startButton_Click = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timesRightLabel = new System.Windows.Forms.Label();
            this.timesLeftLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dividedRightLabel = new System.Windows.Forms.Label();
            this.dividedLeftLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.AutoSize = true;
            this.plusLeftLabel.Location = new System.Drawing.Point(67, 92);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(50, 20);
            this.plusLeftLabel.TabIndex = 0;
            this.plusLeftLabel.Text = "label1";
            this.plusLeftLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.AutoSize = true;
            this.plusRightLabel.Location = new System.Drawing.Point(201, 92);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(50, 20);
            this.plusRightLabel.TabIndex = 1;
            this.plusRightLabel.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(514, 92);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(150, 27);
            this.sum.TabIndex = 3;
            // 
            // startButton_Click
            // 
            this.startButton_Click.Location = new System.Drawing.Point(317, 379);
            this.startButton_Click.Name = "startButton_Click";
            this.startButton_Click.Size = new System.Drawing.Size(117, 29);
            this.startButton_Click.TabIndex = 4;
            this.startButton_Click.Text = "commencer";
            this.startButton_Click.UseVisualStyleBackColor = true;
            this.startButton_Click.Click += new System.EventHandler(this.startButton_Click_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "=";
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.AutoSize = true;
            this.minusRightLabel.Location = new System.Drawing.Point(201, 180);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(50, 20);
            this.minusRightLabel.TabIndex = 6;
            this.minusRightLabel.Text = "label2";
            this.minusRightLabel.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.AutoSize = true;
            this.minusLeftLabel.Location = new System.Drawing.Point(67, 180);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(50, 20);
            this.minusLeftLabel.TabIndex = 5;
            this.minusLeftLabel.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "=";
            // 
            // timesRightLabel
            // 
            this.timesRightLabel.AutoSize = true;
            this.timesRightLabel.Location = new System.Drawing.Point(201, 230);
            this.timesRightLabel.Name = "timesRightLabel";
            this.timesRightLabel.Size = new System.Drawing.Size(50, 20);
            this.timesRightLabel.TabIndex = 9;
            this.timesRightLabel.Text = "label2";
            // 
            // timesLeftLabel
            // 
            this.timesLeftLabel.AutoSize = true;
            this.timesLeftLabel.Location = new System.Drawing.Point(67, 230);
            this.timesLeftLabel.Name = "timesLeftLabel";
            this.timesLeftLabel.Size = new System.Drawing.Size(50, 20);
            this.timesLeftLabel.TabIndex = 8;
            this.timesLeftLabel.Text = "label1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "=";
            // 
            // dividedRightLabel
            // 
            this.dividedRightLabel.AutoSize = true;
            this.dividedRightLabel.Location = new System.Drawing.Point(201, 296);
            this.dividedRightLabel.Name = "dividedRightLabel";
            this.dividedRightLabel.Size = new System.Drawing.Size(50, 20);
            this.dividedRightLabel.TabIndex = 12;
            this.dividedRightLabel.Text = "label2";
            // 
            // dividedLeftLabel
            // 
            this.dividedLeftLabel.AutoSize = true;
            this.dividedLeftLabel.Location = new System.Drawing.Point(67, 296);
            this.dividedLeftLabel.Name = "dividedLeftLabel";
            this.dividedLeftLabel.Size = new System.Drawing.Size(50, 20);
            this.dividedLeftLabel.TabIndex = 11;
            this.dividedLeftLabel.Text = "label1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(148, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "+";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(148, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(148, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "*";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(148, 296);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 20);
            this.label14.TabIndex = 17;
            this.label14.Text = "/";
            // 
            // difference
            // 
            this.difference.Location = new System.Drawing.Point(514, 178);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(150, 27);
            this.difference.TabIndex = 18;
            // 
            // product
            // 
            this.product.Location = new System.Drawing.Point(514, 230);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(150, 27);
            this.product.TabIndex = 19;
            // 
            // quotient
            // 
            this.quotient.Location = new System.Drawing.Point(514, 296);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(150, 27);
            this.quotient.TabIndex = 20;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(317, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(58, 20);
            this.timeLabel.TabIndex = 21;
            this.timeLabel.Text = "label15";
            this.timeLabel.Click += new System.EventHandler(this.label15_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.product);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dividedRightLabel);
            this.Controls.Add(this.dividedLeftLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timesRightLabel);
            this.Controls.Add(this.timesLeftLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.startButton_Click);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.plusLeftLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.Button startButton_Click;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label timesRightLabel;
        private System.Windows.Forms.Label timesLeftLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label dividedRightLabel;
        private System.Windows.Forms.Label dividedLeftLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLabel;
    }
}

