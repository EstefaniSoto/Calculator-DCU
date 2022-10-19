
namespace Calculator_DCU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnexit = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btndiv = new Guna.UI2.WinForms.Guna2Button();
            this.btnplus = new Guna.UI2.WinForms.Guna2Button();
            this.btnguion = new Guna.UI2.WinForms.Guna2Button();
            this.btnpercent = new Guna.UI2.WinForms.Guna2Button();
            this.btn9 = new Guna.UI2.WinForms.Guna2Button();
            this.btn6 = new Guna.UI2.WinForms.Guna2Button();
            this.btn3 = new Guna.UI2.WinForms.Guna2Button();
            this.btn8 = new Guna.UI2.WinForms.Guna2Button();
            this.btnclear = new Guna.UI2.WinForms.Guna2Button();
            this.btn7 = new Guna.UI2.WinForms.Guna2Button();
            this.btn5 = new Guna.UI2.WinForms.Guna2Button();
            this.btn4 = new Guna.UI2.WinForms.Guna2Button();
            this.btn2 = new Guna.UI2.WinForms.Guna2Button();
            this.btn1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnequal = new Guna.UI2.WinForms.Guna2Button();
            this.btn0 = new Guna.UI2.WinForms.Guna2Button();
            this.btndot = new Guna.UI2.WinForms.Guna2Button();
            this.txtresoult = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtstore = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnmult = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.ImageRotate = 0F;
            this.btnexit.Location = new System.Drawing.Point(334, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnexit.Size = new System.Drawing.Size(27, 28);
            this.btnexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnexit.TabIndex = 0;
            this.btnexit.TabStop = false;
            this.btnexit.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Digital-7 Mono", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.DarkViolet;
            this.lbl.Location = new System.Drawing.Point(2, 12);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(144, 28);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Calculadora";
            this.lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // btndiv
            // 
            this.btndiv.BackColor = System.Drawing.Color.Transparent;
            this.btndiv.BorderRadius = 15;
            this.btndiv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndiv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndiv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndiv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndiv.FillColor = System.Drawing.Color.Black;
            this.btndiv.Font = new System.Drawing.Font("LCDMono2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiv.ForeColor = System.Drawing.Color.DarkViolet;
            this.btndiv.HoverState.FillColor = System.Drawing.Color.DarkViolet;
            this.btndiv.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btndiv.Location = new System.Drawing.Point(264, 266);
            this.btndiv.Name = "btndiv";
            this.btndiv.ShadowDecoration.BorderRadius = 15;
            this.btndiv.ShadowDecoration.Color = System.Drawing.Color.DarkViolet;
            this.btndiv.ShadowDecoration.Enabled = true;
            this.btndiv.Size = new System.Drawing.Size(58, 42);
            this.btndiv.TabIndex = 2;
            this.btndiv.Text = "/";
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnplus
            // 
            this.btnplus.BackColor = System.Drawing.Color.Transparent;
            this.btnplus.BorderRadius = 15;
            this.btnplus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnplus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnplus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnplus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnplus.FillColor = System.Drawing.Color.Black;
            this.btnplus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnplus.HoverState.FillColor = System.Drawing.Color.DarkViolet;
            this.btnplus.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnplus.Location = new System.Drawing.Point(264, 380);
            this.btnplus.Name = "btnplus";
            this.btnplus.ShadowDecoration.BorderRadius = 15;
            this.btnplus.ShadowDecoration.Color = System.Drawing.Color.DarkViolet;
            this.btnplus.ShadowDecoration.Enabled = true;
            this.btnplus.Size = new System.Drawing.Size(58, 42);
            this.btnplus.TabIndex = 2;
            this.btnplus.Text = "+";
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnguion
            // 
            this.btnguion.BackColor = System.Drawing.Color.Transparent;
            this.btnguion.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnguion.BorderRadius = 15;
            this.btnguion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnguion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnguion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnguion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnguion.FillColor = System.Drawing.Color.Black;
            this.btnguion.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguion.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnguion.HoverState.FillColor = System.Drawing.Color.DarkViolet;
            this.btnguion.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnguion.Location = new System.Drawing.Point(264, 437);
            this.btnguion.Name = "btnguion";
            this.btnguion.ShadowDecoration.BorderRadius = 15;
            this.btnguion.ShadowDecoration.Color = System.Drawing.Color.DarkViolet;
            this.btnguion.ShadowDecoration.Enabled = true;
            this.btnguion.Size = new System.Drawing.Size(58, 42);
            this.btnguion.TabIndex = 2;
            this.btnguion.Text = "-";
            this.btnguion.Click += new System.EventHandler(this.btnguion_Click);
            // 
            // btnpercent
            // 
            this.btnpercent.BackColor = System.Drawing.Color.Transparent;
            this.btnpercent.BorderRadius = 15;
            this.btnpercent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnpercent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnpercent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnpercent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnpercent.FillColor = System.Drawing.Color.Black;
            this.btnpercent.Font = new System.Drawing.Font("LCDMono2", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpercent.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnpercent.HoverState.FillColor = System.Drawing.Color.DarkViolet;
            this.btnpercent.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnpercent.Location = new System.Drawing.Point(191, 266);
            this.btnpercent.Name = "btnpercent";
            this.btnpercent.ShadowDecoration.BorderRadius = 15;
            this.btnpercent.ShadowDecoration.Color = System.Drawing.Color.DarkViolet;
            this.btnpercent.ShadowDecoration.Enabled = true;
            this.btnpercent.Size = new System.Drawing.Size(58, 42);
            this.btnpercent.TabIndex = 2;
            this.btnpercent.Text = "%";
            this.btnpercent.Click += new System.EventHandler(this.btnpercent_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Transparent;
            this.btn9.BorderRadius = 15;
            this.btn9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn9.FillColor = System.Drawing.Color.Black;
            this.btn9.Font = new System.Drawing.Font("LCDMono2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.DarkViolet;
            this.btn9.HoverState.FillColor = System.Drawing.Color.DarkViolet;
            this.btn9.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn9.Location = new System.Drawing.Point(191, 323);
            this.btn9.Name = "btn9";
            this.btn9.ShadowDecoration.BorderRadius = 15;
            this.btn9.ShadowDecoration.Color = System.Drawing.Color.DarkViolet;
            this.btn9.ShadowDecoration.Enabled = true;
            this.btn9.Size = new System.Drawing.Size(58, 42);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Transparent;
            this.btn6.BorderRadius = 15;
            this.btn6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn6.FillColor = System.Drawing.Color.Black;
            this.btn6.Font = new System.Drawing.Font("LCDMono2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.DarkViolet;
            this.btn6.HoverState.FillColor = System.Drawing.Color.DarkViolet;
            this.btn6.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn6.Location = new System.Drawing.Point(191, 381);
            this.btn6.Name = "btn6";
            this.btn6.ShadowDecoration.BorderRadius = 15;
            this.btn6.ShadowDecoration.Color = System.Drawing.Color.DarkViolet;
            this.btn6.ShadowDecoration.Enabled = true;
            this.btn6.Size = new System.Drawing.Size(58, 42);
            this.btn6.TabIndex = 2;
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Transparent;
            this.btn3.BorderRadius = 15;
            this.btn3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn3.FillColor = System.Drawing.Color.Black;
            this.btn3.Font = new System.Drawing.Font("LCDMono2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.DarkViolet;
            this.btn3.HoverState.FillColor = System.Drawing.Color.DarkViolet;
            this.btn3.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn3.Location = new System.Drawing.Point(191, 438);
            this.btn3.Name = "btn3";
            this.btn3.ShadowDecoration.BorderRadius = 15;
            this.btn3.ShadowDecoration.Color = System.Drawing.Color.DarkViolet;
            this.btn3.ShadowDecoration.Enabled = true;
            this.btn3.Size = new System.Drawing.Size(58, 42);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Transparent;
            this.btn8.BorderRadius = 15;
            this.btn8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn8.FillColor = System.Drawing.Color.Black;
            this.btn8.Font = new System.Drawing.Font("LCDMono2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.DarkViolet;
            this.btn8.HoverState.FillColor = System.Drawing.Color.DarkViolet;
            this.btn8.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn8.Location = new System.Drawing.Point(118, 323);
            this.btn8.Name = "btn8";
            this.btn8.ShadowDecoration.BorderRadius = 15;
            this.btn8.ShadowDecoration.Color = System.Drawing.Color.DarkViolet;
            this.btn8.ShadowDecoration.Enabled = true;
            this.btn8.Size = new System.Drawing.Size(58, 42);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Transparent;
            this.btnclear.BorderRadius = 15;
            this.btnclear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclear.FillColor = System.Drawing.Color.Black;
            this.btnclear.Font = new System.Drawing.Font("LCDMono2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnclear.HoverState.FillColor = System.Drawing.Color.DarkViolet;
            this.btnclear.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnclear.Location = new System.Drawing.Point(44, 266);
            this.btnclear.Name = "btnclear";
            this.btnclear.ShadowDecoration.BorderRadius = 15;
            this.btnclear.ShadowDecoration.Color = System.Drawing.Color.DarkViolet;
            this.btnclear.ShadowDecoration.Enabled = true;
            this.btnclear.Size = new System.Drawing.Size(132, 42);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "C";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Transparent;
            this.btn7.BorderRadius = 15;
            this.btn7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn7.FillColor = System.Drawing.Color.Black;
            this.btn7.Font = new System.Drawing.Font("LCDMono2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.DarkViolet;
            this.btn7.HoverState.FillColor = System.Drawing.Color.DarkViolet;
            this.btn7.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn7.Location = new System.Drawing.Point(44, 323);
            this.btn7.Name = "btn7";
            this.btn7.ShadowDecoration.BorderRadius = 15;
            this.btn7.ShadowDecoration.Color = System.Drawing.Color.DarkViolet;
            this.btn7.ShadowDecoration.Enabled = true;
            this.btn7.Size = new System.Drawing.Size(58, 42);
            this.btn7.TabIndex = 2;
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Transparent;
            this.btn5.BorderRadius = 15;
            this.btn5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn5.FillColor = System.Drawing.Color.Black;
            this.btn5.Font = new System.Drawing.Font("LCDMono2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.DarkViolet;
            this.btn5.HoverState.FillColor = System.Drawing.Color.DarkViolet;
            this.btn5.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn5.Location = new System.Drawing.Point(118, 381);
            this.btn5.Name = "btn5";
            this.btn5.ShadowDecoration.BorderRadius = 15;
            this.btn5.ShadowDecoration.Color = System.Drawing.Color.DarkViolet;
            this.btn5.ShadowDecoration.Enabled = true;
            this.btn5.Size = new System.Drawing.Size(58, 42);
            this.btn5.TabIndex = 2;
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Transparent;
            this.btn4.BorderRadius = 15;
            this.btn4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn4.FillColor = System.Drawing.Color.Black;
            this.btn4.Font = new System.Drawing.Font("LCDMono2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.DarkViolet;
            this.btn4.HoverState.FillColor = System.Drawing.Color.DarkViolet;
            this.btn4.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn4.Location = new System.Drawing.Point(44, 381);
            this.btn4.Name = "btn4";
            this.btn4.ShadowDecoration.BorderRadius = 15;
            this.btn4.ShadowDecoration.Color = System.Drawing.Color.DarkViolet;
            this.btn4.ShadowDecoration.Enabled = true;
            this.btn4.Size = new System.Drawing.Size(58, 42);
            this.btn4.TabIndex = 2;
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.BorderRadius = 15;
            this.btn2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn2.FillColor = System.Drawing.Color.Black;
            this.btn2.Font = new System.Drawing.Font("LCDMono2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.DarkViolet;
            this.btn2.HoverState.FillColor = System.Drawing.Color.DarkViolet;
            this.btn2.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn2.Location = new System.Drawing.Point(118, 438);
            this.btn2.Name = "btn2";
            this.btn2.ShadowDecoration.BorderRadius = 15;
            this.btn2.ShadowDecoration.Color = System.Drawing.Color.DarkViolet;
            this.btn2.ShadowDecoration.Enabled = true;
            this.btn2.Size = new System.Drawing.Size(58, 42);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.BorderRadius = 15;
            this.btn1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn1.FillColor = System.Drawing.Color.Black;
            this.btn1.Font = new System.Drawing.Font("LCDMono2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.DarkViolet;
            this.btn1.HoverState.FillColor = System.Drawing.Color.DarkViolet;
            this.btn1.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn1.Location = new System.Drawing.Point(44, 438);
            this.btn1.Name = "btn1";
            this.btn1.ShadowDecoration.BorderRadius = 15;
            this.btn1.ShadowDecoration.Color = System.Drawing.Color.DarkViolet;
            this.btn1.ShadowDecoration.Enabled = true;
            this.btn1.Size = new System.Drawing.Size(58, 42);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnequal
            // 
            this.btnequal.BackColor = System.Drawing.Color.Transparent;
            this.btnequal.BorderRadius = 15;
            this.btnequal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnequal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnequal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnequal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnequal.FillColor = System.Drawing.Color.DarkViolet;
            this.btnequal.Font = new System.Drawing.Font("LCDMono2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnequal.ForeColor = System.Drawing.Color.Black;
            this.btnequal.HoverState.FillColor = System.Drawing.Color.DarkViolet;
            this.btnequal.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnequal.Location = new System.Drawing.Point(191, 494);
            this.btnequal.Name = "btnequal";
            this.btnequal.ShadowDecoration.BorderRadius = 15;
            this.btnequal.ShadowDecoration.Color = System.Drawing.Color.DarkViolet;
            this.btnequal.ShadowDecoration.Enabled = true;
            this.btnequal.Size = new System.Drawing.Size(131, 42);
            this.btnequal.TabIndex = 2;
            this.btnequal.Text = "=";
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Transparent;
            this.btn0.BorderRadius = 15;
            this.btn0.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn0.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn0.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn0.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn0.FillColor = System.Drawing.Color.Black;
            this.btn0.Font = new System.Drawing.Font("LCDMono2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.DarkViolet;
            this.btn0.HoverState.FillColor = System.Drawing.Color.DarkViolet;
            this.btn0.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn0.Location = new System.Drawing.Point(44, 496);
            this.btn0.Name = "btn0";
            this.btn0.ShadowDecoration.BorderRadius = 15;
            this.btn0.ShadowDecoration.Color = System.Drawing.Color.DarkViolet;
            this.btn0.ShadowDecoration.Enabled = true;
            this.btn0.Size = new System.Drawing.Size(58, 42);
            this.btn0.TabIndex = 2;
            this.btn0.Text = "0";
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btndot
            // 
            this.btndot.BackColor = System.Drawing.Color.Transparent;
            this.btndot.BorderRadius = 15;
            this.btndot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndot.FillColor = System.Drawing.Color.Black;
            this.btndot.Font = new System.Drawing.Font("LCDMono2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndot.ForeColor = System.Drawing.Color.DarkViolet;
            this.btndot.HoverState.FillColor = System.Drawing.Color.DarkViolet;
            this.btndot.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btndot.Location = new System.Drawing.Point(118, 496);
            this.btndot.Name = "btndot";
            this.btndot.ShadowDecoration.BorderRadius = 15;
            this.btndot.ShadowDecoration.Color = System.Drawing.Color.DarkViolet;
            this.btndot.ShadowDecoration.Enabled = true;
            this.btndot.Size = new System.Drawing.Size(58, 42);
            this.btndot.TabIndex = 2;
            this.btndot.Text = ".";
            this.btndot.Click += new System.EventHandler(this.btndot_Click);
            // 
            // txtresoult
            // 
            this.txtresoult.BorderColor = System.Drawing.Color.Black;
            this.txtresoult.BorderThickness = 0;
            this.txtresoult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtresoult.DefaultText = "";
            this.txtresoult.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtresoult.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtresoult.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtresoult.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtresoult.FillColor = System.Drawing.Color.Black;
            this.txtresoult.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtresoult.Font = new System.Drawing.Font("Digital-7 Mono", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresoult.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtresoult.Location = new System.Drawing.Point(44, 112);
            this.txtresoult.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtresoult.Name = "txtresoult";
            this.txtresoult.PasswordChar = '\0';
            this.txtresoult.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtresoult.PlaceholderText = "0";
            this.txtresoult.SelectedText = "";
            this.txtresoult.Size = new System.Drawing.Size(278, 53);
            this.txtresoult.TabIndex = 3;
            this.txtresoult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtstore
            // 
            this.txtstore.BorderColor = System.Drawing.Color.Black;
            this.txtstore.BorderThickness = 0;
            this.txtstore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstore.DefaultText = "";
            this.txtstore.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtstore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtstore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstore.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstore.FillColor = System.Drawing.Color.Black;
            this.txtstore.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstore.Font = new System.Drawing.Font("Digital-7 Mono", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstore.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstore.Location = new System.Drawing.Point(44, 171);
            this.txtstore.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtstore.Name = "txtstore";
            this.txtstore.PasswordChar = '\0';
            this.txtstore.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtstore.PlaceholderText = "";
            this.txtstore.SelectedText = "";
            this.txtstore.Size = new System.Drawing.Size(278, 53);
            this.txtstore.TabIndex = 3;
            this.txtstore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnmult
            // 
            this.btnmult.BackColor = System.Drawing.Color.Transparent;
            this.btnmult.BorderColor = System.Drawing.Color.DarkViolet;
            this.btnmult.BorderRadius = 15;
            this.btnmult.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmult.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmult.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmult.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmult.FillColor = System.Drawing.Color.Black;
            this.btnmult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmult.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnmult.HoverState.FillColor = System.Drawing.Color.DarkViolet;
            this.btnmult.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnmult.Location = new System.Drawing.Point(264, 323);
            this.btnmult.Name = "btnmult";
            this.btnmult.ShadowDecoration.BorderRadius = 15;
            this.btnmult.ShadowDecoration.Color = System.Drawing.Color.DarkViolet;
            this.btnmult.ShadowDecoration.Enabled = true;
            this.btnmult.Size = new System.Drawing.Size(58, 42);
            this.btnmult.TabIndex = 2;
            this.btnmult.Text = "*";
            this.btnmult.Click += new System.EventHandler(this.btnmult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(373, 577);
            this.Controls.Add(this.txtstore);
            this.Controls.Add(this.txtresoult);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btndot);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnequal);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnguion);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnpercent);
            this.Controls.Add(this.btnmult);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnexit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox btnexit;
        private System.Windows.Forms.Label lbl;
        private Guna.UI2.WinForms.Guna2Button btndiv;
        private Guna.UI2.WinForms.Guna2Button btnplus;
        private Guna.UI2.WinForms.Guna2Button btnguion;
        private Guna.UI2.WinForms.Guna2Button btnpercent;
        private Guna.UI2.WinForms.Guna2Button btn9;
        private Guna.UI2.WinForms.Guna2Button btn6;
        private Guna.UI2.WinForms.Guna2Button btn3;
        private Guna.UI2.WinForms.Guna2Button btn8;
        private Guna.UI2.WinForms.Guna2Button btnclear;
        private Guna.UI2.WinForms.Guna2Button btn7;
        private Guna.UI2.WinForms.Guna2Button btn5;
        private Guna.UI2.WinForms.Guna2Button btn4;
        private Guna.UI2.WinForms.Guna2Button btn2;
        private Guna.UI2.WinForms.Guna2Button btn1;
        private Guna.UI2.WinForms.Guna2Button btnequal;
        private Guna.UI2.WinForms.Guna2Button btn0;
        private Guna.UI2.WinForms.Guna2Button btndot;
        private Guna.UI2.WinForms.Guna2TextBox txtresoult;
        private Guna.UI2.WinForms.Guna2TextBox txtstore;
        private Guna.UI2.WinForms.Guna2Button btnmult;
    }
}

