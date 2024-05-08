namespace StudentRegistrationApplication
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.LastN = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.FirstN = new System.Windows.Forms.TextBox();
            this.MiddleName = new System.Windows.Forms.Label();
            this.MiddleN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.ComboBox();
            this.Month = new System.Windows.Forms.ComboBox();
            this.Year = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Program = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Registration Form";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last name*";
            // 
            // LastN
            // 
            this.LastN.Location = new System.Drawing.Point(50, 102);
            this.LastN.Name = "LastN";
            this.LastN.Size = new System.Drawing.Size(207, 26);
            this.LastN.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(46, 141);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(90, 20);
            this.label.TabIndex = 4;
            this.label.Text = "First name*";
            this.label.Click += new System.EventHandler(this.label3_Click);
            // 
            // FirstN
            // 
            this.FirstN.Location = new System.Drawing.Point(50, 164);
            this.FirstN.Name = "FirstN";
            this.FirstN.Size = new System.Drawing.Size(207, 26);
            this.FirstN.TabIndex = 5;
            // 
            // MiddleName
            // 
            this.MiddleName.AutoSize = true;
            this.MiddleName.Location = new System.Drawing.Point(46, 207);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(105, 20);
            this.MiddleName.TabIndex = 6;
            this.MiddleName.Text = "Middle name*";
            // 
            // MiddleN
            // 
            this.MiddleN.Location = new System.Drawing.Point(50, 230);
            this.MiddleN.Name = "MiddleN";
            this.MiddleN.Size = new System.Drawing.Size(207, 26);
            this.MiddleN.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gender*";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(121, 277);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(68, 24);
            this.Male.TabIndex = 10;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(195, 275);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(87, 24);
            this.Female.TabIndex = 11;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Date of Birth*";
            // 
            // Day
            // 
            this.Day.FormattingEnabled = true;
            this.Day.Location = new System.Drawing.Point(47, 346);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(89, 28);
            this.Day.TabIndex = 13;
            this.Day.Text = "-Day-";
            // 
            // Month
            // 
            this.Month.FormattingEnabled = true;
            this.Month.Location = new System.Drawing.Point(142, 346);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(89, 28);
            this.Month.TabIndex = 14;
            this.Month.Text = "-Month-";
            // 
            // Year
            // 
            this.Year.FormattingEnabled = true;
            this.Year.Location = new System.Drawing.Point(237, 346);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(88, 28);
            this.Year.TabIndex = 15;
            this.Year.Text = "-Year-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Program to apply*";
            // 
            // Program
            // 
            this.Program.FormattingEnabled = true;
            this.Program.Location = new System.Drawing.Point(47, 413);
            this.Program.Name = "Program";
            this.Program.Size = new System.Drawing.Size(278, 28);
            this.Program.TabIndex = 17;
            this.Program.Text = "-Select Program-";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(54, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 51);
            this.button1.TabIndex = 18;
            this.button1.Text = "Register Student";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Picture.Location = new System.Drawing.Point(484, 79);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(221, 195);
            this.Picture.TabIndex = 19;
            this.Picture.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(541, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 39);
            this.button2.TabIndex = 20;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Program);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MiddleN);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.FirstN);
            this.Controls.Add(this.label);
            this.Controls.Add(this.LastN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastN;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox FirstN;
        private System.Windows.Forms.Label MiddleName;
        private System.Windows.Forms.TextBox MiddleN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Day;
        private System.Windows.Forms.ComboBox Month;
        private System.Windows.Forms.ComboBox Year;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Program;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

