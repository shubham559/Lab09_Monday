namespace Lab09_Monday
{
    partial class Week_09_Form
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
            this.CalculatorButtonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Seven_Button = new System.Windows.Forms.Button();
            this.Eight_Button = new System.Windows.Forms.Button();
            this.Nine_Button = new System.Windows.Forms.Button();
            this.Four_Button = new System.Windows.Forms.Button();
            this.Five_Button = new System.Windows.Forms.Button();
            this.Six_Button = new System.Windows.Forms.Button();
            this.One_Button = new System.Windows.Forms.Button();
            this.Two_Button = new System.Windows.Forms.Button();
            this.Three_Button = new System.Windows.Forms.Button();
            this.Zero_Button = new System.Windows.Forms.Button();
            this.Equals_Button = new System.Windows.Forms.Button();
            this.Result_label = new System.Windows.Forms.Label();
            this.CalculatorButtonTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculatorButtonTableLayoutPanel
            // 
            this.CalculatorButtonTableLayoutPanel.ColumnCount = 3;
            this.CalculatorButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CalculatorButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.CalculatorButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.Equals_Button, 2, 3);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.Zero_Button, 1, 3);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.Three_Button, 2, 2);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.Two_Button, 1, 2);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.One_Button, 0, 2);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.Six_Button, 2, 1);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.Five_Button, 1, 1);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.Nine_Button, 2, 0);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.Four_Button, 0, 1);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.Eight_Button, 1, 0);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.Seven_Button, 0, 0);
            this.CalculatorButtonTableLayoutPanel.Location = new System.Drawing.Point(7, 112);
            this.CalculatorButtonTableLayoutPanel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CalculatorButtonTableLayoutPanel.Name = "CalculatorButtonTableLayoutPanel";
            this.CalculatorButtonTableLayoutPanel.RowCount = 4;
            this.CalculatorButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalculatorButtonTableLayoutPanel.Size = new System.Drawing.Size(760, 284);
            this.CalculatorButtonTableLayoutPanel.TabIndex = 0;
            // 
            // Seven_Button
            // 
            this.Seven_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Seven_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Seven_Button.ForeColor = System.Drawing.Color.Red;
            this.Seven_Button.Location = new System.Drawing.Point(3, 3);
            this.Seven_Button.Name = "Seven_Button";
            this.Seven_Button.Size = new System.Drawing.Size(247, 65);
            this.Seven_Button.TabIndex = 0;
            this.Seven_Button.Text = "7";
            this.Seven_Button.UseVisualStyleBackColor = false;
            this.Seven_Button.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // Eight_Button
            // 
            this.Eight_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Eight_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Eight_Button.ForeColor = System.Drawing.Color.Red;
            this.Eight_Button.Location = new System.Drawing.Point(256, 3);
            this.Eight_Button.Name = "Eight_Button";
            this.Eight_Button.Size = new System.Drawing.Size(247, 65);
            this.Eight_Button.TabIndex = 1;
            this.Eight_Button.Text = "8";
            this.Eight_Button.UseVisualStyleBackColor = false;
            this.Eight_Button.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // Nine_Button
            // 
            this.Nine_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Nine_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Nine_Button.ForeColor = System.Drawing.Color.Red;
            this.Nine_Button.Location = new System.Drawing.Point(509, 3);
            this.Nine_Button.Name = "Nine_Button";
            this.Nine_Button.Size = new System.Drawing.Size(248, 65);
            this.Nine_Button.TabIndex = 2;
            this.Nine_Button.Text = "9";
            this.Nine_Button.UseVisualStyleBackColor = false;
            this.Nine_Button.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // Four_Button
            // 
            this.Four_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Four_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Four_Button.ForeColor = System.Drawing.Color.Red;
            this.Four_Button.Location = new System.Drawing.Point(3, 74);
            this.Four_Button.Name = "Four_Button";
            this.Four_Button.Size = new System.Drawing.Size(247, 65);
            this.Four_Button.TabIndex = 3;
            this.Four_Button.Text = "4";
            this.Four_Button.UseVisualStyleBackColor = false;
            this.Four_Button.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // Five_Button
            // 
            this.Five_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Five_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Five_Button.ForeColor = System.Drawing.Color.Red;
            this.Five_Button.Location = new System.Drawing.Point(256, 74);
            this.Five_Button.Name = "Five_Button";
            this.Five_Button.Size = new System.Drawing.Size(247, 65);
            this.Five_Button.TabIndex = 4;
            this.Five_Button.Text = "5";
            this.Five_Button.UseVisualStyleBackColor = false;
            this.Five_Button.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // Six_Button
            // 
            this.Six_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Six_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Six_Button.ForeColor = System.Drawing.Color.Red;
            this.Six_Button.Location = new System.Drawing.Point(509, 74);
            this.Six_Button.Name = "Six_Button";
            this.Six_Button.Size = new System.Drawing.Size(248, 65);
            this.Six_Button.TabIndex = 5;
            this.Six_Button.Text = "6";
            this.Six_Button.UseVisualStyleBackColor = false;
            this.Six_Button.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // One_Button
            // 
            this.One_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.One_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.One_Button.ForeColor = System.Drawing.Color.Red;
            this.One_Button.Location = new System.Drawing.Point(3, 145);
            this.One_Button.Name = "One_Button";
            this.One_Button.Size = new System.Drawing.Size(247, 65);
            this.One_Button.TabIndex = 6;
            this.One_Button.Text = "1";
            this.One_Button.UseVisualStyleBackColor = false;
            this.One_Button.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // Two_Button
            // 
            this.Two_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Two_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Two_Button.ForeColor = System.Drawing.Color.Red;
            this.Two_Button.Location = new System.Drawing.Point(256, 145);
            this.Two_Button.Name = "Two_Button";
            this.Two_Button.Size = new System.Drawing.Size(247, 65);
            this.Two_Button.TabIndex = 7;
            this.Two_Button.Text = "2";
            this.Two_Button.UseVisualStyleBackColor = false;
            this.Two_Button.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // Three_Button
            // 
            this.Three_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Three_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Three_Button.ForeColor = System.Drawing.Color.Red;
            this.Three_Button.Location = new System.Drawing.Point(509, 145);
            this.Three_Button.Name = "Three_Button";
            this.Three_Button.Size = new System.Drawing.Size(248, 65);
            this.Three_Button.TabIndex = 8;
            this.Three_Button.Text = "3";
            this.Three_Button.UseVisualStyleBackColor = false;
            this.Three_Button.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // Zero_Button
            // 
            this.Zero_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Zero_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Zero_Button.ForeColor = System.Drawing.Color.Red;
            this.Zero_Button.Location = new System.Drawing.Point(256, 216);
            this.Zero_Button.Name = "Zero_Button";
            this.Zero_Button.Size = new System.Drawing.Size(247, 65);
            this.Zero_Button.TabIndex = 10;
            this.Zero_Button.Text = "0";
            this.Zero_Button.UseVisualStyleBackColor = false;
            this.Zero_Button.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // Equals_Button
            // 
            this.Equals_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Equals_Button.BackColor = System.Drawing.Color.Chartreuse;
            this.Equals_Button.ForeColor = System.Drawing.Color.Red;
            this.Equals_Button.Location = new System.Drawing.Point(509, 216);
            this.Equals_Button.Name = "Equals_Button";
            this.Equals_Button.Size = new System.Drawing.Size(248, 65);
            this.Equals_Button.TabIndex = 11;
            this.Equals_Button.Text = "=";
            this.Equals_Button.UseVisualStyleBackColor = false;
            this.Equals_Button.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // Result_label
            // 
            this.Result_label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Result_label.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result_label.Location = new System.Drawing.Point(4, 58);
            this.Result_label.Name = "Result_label";
            this.Result_label.Size = new System.Drawing.Size(763, 54);
            this.Result_label.TabIndex = 12;
            this.Result_label.Text = "0";
            this.Result_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Week_09_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.CalculatorButtonTableLayoutPanel);
            this.Controls.Add(this.Result_label);
            this.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Week_09_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Week_09_Form_Load);
            this.CalculatorButtonTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CalculatorButtonTableLayoutPanel;
        private System.Windows.Forms.Button Equals_Button;
        private System.Windows.Forms.Button Zero_Button;
        private System.Windows.Forms.Button Three_Button;
        private System.Windows.Forms.Button Two_Button;
        private System.Windows.Forms.Button One_Button;
        private System.Windows.Forms.Button Six_Button;
        private System.Windows.Forms.Button Five_Button;
        private System.Windows.Forms.Button Nine_Button;
        private System.Windows.Forms.Button Four_Button;
        private System.Windows.Forms.Button Seven_Button;
        private System.Windows.Forms.Button Eight_Button;
        private System.Windows.Forms.Label Result_label;
    }
}

