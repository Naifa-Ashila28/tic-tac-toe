namespace Tic_Tac_Toe_MK2
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
            label1 = new Label();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            label2 = new Label();
            lblstatus = new Label();
            btnreset = new Button();
            btnexit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Pink;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Bubble Gum", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(269, 62);
            label1.Name = "label1";
            label1.Size = new Size(320, 63);
            label1.TabIndex = 0;
            label1.Text = "TIC TAC TOE";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn1
            // 
            btn1.Location = new Point(275, 188);
            btn1.Name = "btn1";
            btn1.Size = new Size(100, 94);
            btn1.TabIndex = 1;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(383, 188);
            btn2.Name = "btn2";
            btn2.Size = new Size(100, 94);
            btn2.TabIndex = 2;
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Location = new Point(489, 188);
            btn3.Name = "btn3";
            btn3.Size = new Size(100, 94);
            btn3.TabIndex = 3;
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Location = new Point(275, 288);
            btn4.Name = "btn4";
            btn4.Size = new Size(100, 94);
            btn4.TabIndex = 4;
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Location = new Point(383, 288);
            btn5.Name = "btn5";
            btn5.Size = new Size(100, 94);
            btn5.TabIndex = 5;
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Location = new Point(489, 288);
            btn6.Name = "btn6";
            btn6.Size = new Size(100, 94);
            btn6.TabIndex = 6;
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Location = new Point(275, 388);
            btn7.Name = "btn7";
            btn7.Size = new Size(100, 94);
            btn7.TabIndex = 7;
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Location = new Point(383, 388);
            btn8.Name = "btn8";
            btn8.Size = new Size(100, 94);
            btn8.TabIndex = 8;
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Location = new Point(489, 388);
            btn9.Name = "btn9";
            btn9.Size = new Size(100, 94);
            btn9.TabIndex = 9;
            btn9.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSkyBlue;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Bubble Gum", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(43, 538);
            label2.Name = "label2";
            label2.Size = new Size(113, 32);
            label2.TabIndex = 10;
            label2.Text = "Status :";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblstatus
            // 
            lblstatus.AutoSize = true;
            lblstatus.BackColor = Color.Tomato;
            lblstatus.Font = new Font("Bubble Gum", 22F);
            lblstatus.ForeColor = SystemColors.ControlLightLight;
            lblstatus.Location = new Point(167, 524);
            lblstatus.Name = "lblstatus";
            lblstatus.Size = new Size(0, 56);
            lblstatus.TabIndex = 12;
            lblstatus.TextAlign = ContentAlignment.MiddleCenter;
            lblstatus.Click += label4_Click;
            // 
            // btnreset
            // 
            btnreset.BackColor = Color.LightPink;
            btnreset.Font = new Font("Bubble Gum", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnreset.ForeColor = SystemColors.ControlLightLight;
            btnreset.Location = new Point(157, 646);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(148, 46);
            btnreset.TabIndex = 13;
            btnreset.Text = "Reset";
            btnreset.UseVisualStyleBackColor = false;
            btnreset.Click += btnreset_Click;
            // 
            // btnexit
            // 
            btnexit.BackColor = Color.LightPink;
            btnexit.Font = new Font("Bubble Gum", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnexit.ForeColor = SystemColors.ControlLightLight;
            btnexit.Location = new Point(479, 646);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(148, 46);
            btnexit.TabIndex = 14;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(856, 720);
            Controls.Add(btnexit);
            Controls.Add(btnreset);
            Controls.Add(lblstatus);
            Controls.Add(label2);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Label label2;
        private Label lblstatus;
        private Button btnreset;
        private Button btnexit;
    }
}
