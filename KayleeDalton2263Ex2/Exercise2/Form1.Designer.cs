namespace Exercise2
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
            this.txtIn = new System.Windows.Forms.TextBox();
            this.txtInLabel = new System.Windows.Forms.Label();
            this.txtInConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.isLeap = new System.Windows.Forms.Label();
            this.fibLabel = new System.Windows.Forms.Label();
            this.fibButton = new System.Windows.Forms.Button();
            this.fibSum = new System.Windows.Forms.Label();
            this.fiboSum = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.alphButton = new System.Windows.Forms.Button();
            this.btnTask4 = new System.Windows.Forms.Button();
            this.txtMultiLineOut = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.triangleBox = new System.Windows.Forms.TextBox();
            this.alphBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(325, 289);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(100, 23);
            this.txtIn.TabIndex = 0;
            this.txtIn.TextChanged += new System.EventHandler(this.txtIn_TextChanged);
            // 
            // txtInLabel
            // 
            this.txtInLabel.AutoSize = true;
            this.txtInLabel.Location = new System.Drawing.Point(264, 220);
            this.txtInLabel.Name = "txtInLabel";
            this.txtInLabel.Size = new System.Drawing.Size(59, 15);
            this.txtInLabel.TabIndex = 1;
            this.txtInLabel.Text = "Enter Year";
            // 
            // txtInConfirm
            // 
            this.txtInConfirm.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtInConfirm.ForeColor = System.Drawing.SystemColors.Window;
            this.txtInConfirm.Location = new System.Drawing.Point(248, 238);
            this.txtInConfirm.Name = "txtInConfirm";
            this.txtInConfirm.Size = new System.Drawing.Size(75, 23);
            this.txtInConfirm.TabIndex = 2;
            this.txtInConfirm.Text = "Submit";
            this.txtInConfirm.UseVisualStyleBackColor = false;
            this.txtInConfirm.Click += new System.EventHandler(this.txtInConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 3;
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(248, 264);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(37, 15);
            this.lblOut.TabIndex = 4;
            this.lblOut.Text = "Leap?";
            this.lblOut.Click += new System.EventHandler(this.label_Click);
            // 
            // isLeap
            // 
            this.isLeap.Location = new System.Drawing.Point(0, 0);
            this.isLeap.Name = "isLeap";
            this.isLeap.Size = new System.Drawing.Size(100, 23);
            this.isLeap.TabIndex = 11;
            // 
            // fibLabel
            // 
            this.fibLabel.AutoSize = true;
            this.fibLabel.Location = new System.Drawing.Point(418, 220);
            this.fibLabel.Name = "fibLabel";
            this.fibLabel.Size = new System.Drawing.Size(112, 15);
            this.fibLabel.TabIndex = 7;
            this.fibLabel.Text = "Fibonacci Sequence";
            // 
            // fibButton
            // 
            this.fibButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.fibButton.ForeColor = System.Drawing.SystemColors.Window;
            this.fibButton.Location = new System.Drawing.Point(438, 238);
            this.fibButton.Name = "fibButton";
            this.fibButton.Size = new System.Drawing.Size(75, 23);
            this.fibButton.TabIndex = 8;
            this.fibButton.Text = "Submit";
            this.fibButton.UseVisualStyleBackColor = false;
            this.fibButton.Click += new System.EventHandler(this.fibButton_Click);
            // 
            // fibSum
            // 
            this.fibSum.Location = new System.Drawing.Point(0, 0);
            this.fibSum.Name = "fibSum";
            this.fibSum.Size = new System.Drawing.Size(100, 23);
            this.fibSum.TabIndex = 10;
            // 
            // fiboSum
            // 
            this.fiboSum.AutoSize = true;
            this.fiboSum.Location = new System.Drawing.Point(473, 264);
            this.fiboSum.Name = "fiboSum";
            this.fiboSum.Size = new System.Drawing.Size(40, 15);
            this.fiboSum.TabIndex = 9;
            this.fiboSum.Text = "Sum...";
            this.fiboSum.Click += new System.EventHandler(this.fiboSum_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "First";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Second";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(507, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enter a number into the middle box. Then choose a test below to run on it by clic" +
    "king a button.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // alphButton
            // 
            this.alphButton.Location = new System.Drawing.Point(604, 191);
            this.alphButton.Name = "alphButton";
            this.alphButton.Size = new System.Drawing.Size(75, 23);
            this.alphButton.TabIndex = 14;
            this.alphButton.Text = "Alphabet";
            this.alphButton.UseVisualStyleBackColor = true;
            this.alphButton.Click += new System.EventHandler(this.alphButton_Click);
            // 
            // btnTask4
            // 
            this.btnTask4.Location = new System.Drawing.Point(343, 25);
            this.btnTask4.Name = "btnTask4";
            this.btnTask4.Size = new System.Drawing.Size(75, 23);
            this.btnTask4.TabIndex = 16;
            this.btnTask4.Text = "Square";
            this.btnTask4.UseVisualStyleBackColor = true;
            this.btnTask4.Click += new System.EventHandler(this.btnTask4_Click);
            // 
            // txtMultiLineOut
            // 
            this.txtMultiLineOut.Location = new System.Drawing.Point(431, 12);
            this.txtMultiLineOut.Name = "txtMultiLineOut";
            this.txtMultiLineOut.Size = new System.Drawing.Size(167, 141);
            this.txtMultiLineOut.TabIndex = 17;
            this.txtMultiLineOut.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "This button implements code from the word doc";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Press the button that says \"square\" to create a rectangle with text!";
            // 
            // triangleBox
            // 
            this.triangleBox.Location = new System.Drawing.Point(36, 220);
            this.triangleBox.Multiline = true;
            this.triangleBox.Name = "triangleBox";
            this.triangleBox.Size = new System.Drawing.Size(174, 163);
            this.triangleBox.TabIndex = 20;
            // 
            // alphBox
            // 
            this.alphBox.Location = new System.Drawing.Point(556, 220);
            this.alphBox.Multiline = true;
            this.alphBox.Name = "alphBox";
            this.alphBox.Size = new System.Drawing.Size(174, 163);
            this.alphBox.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.alphBox);
            this.Controls.Add(this.triangleBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMultiLineOut);
            this.Controls.Add(this.btnTask4);
            this.Controls.Add(this.alphButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fiboSum);
            this.Controls.Add(this.fibSum);
            this.Controls.Add(this.fibButton);
            this.Controls.Add(this.fibLabel);
            this.Controls.Add(this.isLeap);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInConfirm);
            this.Controls.Add(this.txtInLabel);
            this.Controls.Add(this.txtIn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtIn;
        private Label txtInLabel;
        private Button txtInConfirm;
        private Label label1;
        private Label lblOut;
        private Label isLeap;
        private Label fibLabel;
        private Button fibButton;
        private Label fibSum;
        private Label fiboSum;
        private Button button1;
        private Button button2;
        private Label label2;
        private Button alphButton;
        private Button btnTask4;
        private RichTextBox txtMultiLineOut;
        private Label label3;
        private Label label4;
        private TextBox triangleBox;
        private TextBox alphBox;
    }
}