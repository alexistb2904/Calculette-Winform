namespace Calculette
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
            calculator_text = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            calc_btn_clear = new Button();
            calc_btn_modulo = new Button();
            calc_change_sign = new Button();
            calc_btn_0 = new Button();
            calc_btn_3 = new Button();
            calc_btn_2 = new Button();
            calc_btn_1 = new Button();
            calc_btn_6 = new Button();
            calc_btn_5 = new Button();
            calc_btn_4 = new Button();
            calc_btn_9 = new Button();
            calc_btn_8 = new Button();
            calc_btn_7 = new Button();
            calc_dot = new Button();
            calc_btn_div = new Button();
            calc_btn_multi = new Button();
            calc_btn_minus = new Button();
            calc_btn_plus = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            calc_btn_equal = new Button();
            macos_style = new FlowLayoutPanel();
            windows_style = new FlowLayoutPanel();
            win_calculator_text = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            win_calc_racine = new Button();
            win_calc_carre = new Button();
            win_calc_btn_clear = new Button();
            win_calc_btn_modulo = new Button();
            win_calc_btn_change_sign = new Button();
            win_calc_btn_0 = new Button();
            win_calc_btn_3 = new Button();
            win_calc_btn_2 = new Button();
            win_calc_btn_1 = new Button();
            win_calc_btn_6 = new Button();
            win_calc_btn_5 = new Button();
            win_calc_btn_4 = new Button();
            win_calc_btn_9 = new Button();
            win_calc_btn_8 = new Button();
            win_calc_btn_7 = new Button();
            win_calc_btn_dot = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            win_calc_btn_delete = new Button();
            win_calc_btn_equal = new Button();
            win_calc_btn_plus = new Button();
            win_calc_btn_minus = new Button();
            win_calc_btn_multiply = new Button();
            win_calc_btn_divide = new Button();
            style_choice = new ComboBox();
            historyTextBox = new RichTextBox();
            historyCheckbox = new CheckBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            macos_style.SuspendLayout();
            windows_style.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // calculator_text
            // 
            calculator_text.BackColor = Color.FromArgb(93, 92, 90);
            calculator_text.BorderStyle = BorderStyle.FixedSingle;
            calculator_text.ForeColor = SystemColors.Control;
            calculator_text.Location = new Point(0, 0);
            calculator_text.Margin = new Padding(0);
            calculator_text.Name = "calculator_text";
            calculator_text.Size = new Size(433, 80);
            calculator_text.TabIndex = 0;
            calculator_text.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(calc_btn_clear, 0, 0);
            tableLayoutPanel1.Controls.Add(calc_btn_modulo, 2, 0);
            tableLayoutPanel1.Controls.Add(calc_change_sign, 1, 0);
            tableLayoutPanel1.Controls.Add(calc_btn_0, 0, 4);
            tableLayoutPanel1.Controls.Add(calc_btn_3, 2, 3);
            tableLayoutPanel1.Controls.Add(calc_btn_2, 1, 3);
            tableLayoutPanel1.Controls.Add(calc_btn_1, 0, 3);
            tableLayoutPanel1.Controls.Add(calc_btn_6, 2, 2);
            tableLayoutPanel1.Controls.Add(calc_btn_5, 1, 2);
            tableLayoutPanel1.Controls.Add(calc_btn_4, 0, 2);
            tableLayoutPanel1.Controls.Add(calc_btn_9, 2, 1);
            tableLayoutPanel1.Controls.Add(calc_btn_8, 1, 1);
            tableLayoutPanel1.Controls.Add(calc_btn_7, 0, 1);
            tableLayoutPanel1.Controls.Add(calc_dot, 2, 4);
            tableLayoutPanel1.Location = new Point(0, 80);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(327, 461);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // calc_btn_clear
            // 
            calc_btn_clear.BackColor = Color.FromArgb(108, 107, 105);
            calc_btn_clear.Dock = DockStyle.Fill;
            calc_btn_clear.FlatAppearance.BorderColor = Color.FromArgb(93, 92, 90);
            calc_btn_clear.FlatStyle = FlatStyle.Flat;
            calc_btn_clear.ForeColor = SystemColors.Control;
            calc_btn_clear.Location = new Point(0, 0);
            calc_btn_clear.Margin = new Padding(0);
            calc_btn_clear.Name = "calc_btn_clear";
            calc_btn_clear.Size = new Size(102, 92);
            calc_btn_clear.TabIndex = 16;
            calc_btn_clear.Text = "AC";
            calc_btn_clear.UseVisualStyleBackColor = false;
            calc_btn_clear.Click += calc_btn_clear_Click;
            // 
            // calc_btn_modulo
            // 
            calc_btn_modulo.BackColor = Color.FromArgb(108, 107, 105);
            calc_btn_modulo.Dock = DockStyle.Fill;
            calc_btn_modulo.FlatAppearance.BorderColor = Color.FromArgb(93, 92, 90);
            calc_btn_modulo.FlatStyle = FlatStyle.Flat;
            calc_btn_modulo.ForeColor = SystemColors.Control;
            calc_btn_modulo.Location = new Point(211, 0);
            calc_btn_modulo.Margin = new Padding(0);
            calc_btn_modulo.Name = "calc_btn_modulo";
            calc_btn_modulo.Size = new Size(116, 92);
            calc_btn_modulo.TabIndex = 15;
            calc_btn_modulo.Text = "%";
            calc_btn_modulo.UseVisualStyleBackColor = false;
            calc_btn_modulo.Click += calc_btn_modulo_Click;
            // 
            // calc_change_sign
            // 
            calc_change_sign.BackColor = Color.FromArgb(108, 107, 105);
            calc_change_sign.Dock = DockStyle.Fill;
            calc_change_sign.FlatAppearance.BorderColor = Color.FromArgb(93, 92, 90);
            calc_change_sign.FlatStyle = FlatStyle.Flat;
            calc_change_sign.ForeColor = SystemColors.Control;
            calc_change_sign.Location = new Point(102, 0);
            calc_change_sign.Margin = new Padding(0);
            calc_change_sign.Name = "calc_change_sign";
            calc_change_sign.Size = new Size(109, 92);
            calc_change_sign.TabIndex = 14;
            calc_change_sign.Text = "+/-";
            calc_change_sign.UseVisualStyleBackColor = false;
            calc_change_sign.Click += calc_change_sign_Click;
            // 
            // calc_btn_0
            // 
            calc_btn_0.BackColor = Color.FromArgb(132, 132, 130);
            tableLayoutPanel1.SetColumnSpan(calc_btn_0, 2);
            calc_btn_0.Dock = DockStyle.Fill;
            calc_btn_0.FlatAppearance.BorderColor = Color.FromArgb(93, 92, 90);
            calc_btn_0.FlatStyle = FlatStyle.Flat;
            calc_btn_0.ForeColor = SystemColors.Control;
            calc_btn_0.Location = new Point(0, 368);
            calc_btn_0.Margin = new Padding(0);
            calc_btn_0.Name = "calc_btn_0";
            calc_btn_0.Size = new Size(211, 93);
            calc_btn_0.TabIndex = 10;
            calc_btn_0.Text = "0";
            calc_btn_0.UseVisualStyleBackColor = false;
            calc_btn_0.Click += calc_btn_0_Click;
            // 
            // calc_btn_3
            // 
            calc_btn_3.BackColor = Color.FromArgb(132, 132, 130);
            calc_btn_3.Dock = DockStyle.Fill;
            calc_btn_3.FlatAppearance.BorderColor = Color.FromArgb(93, 92, 90);
            calc_btn_3.FlatStyle = FlatStyle.Flat;
            calc_btn_3.ForeColor = SystemColors.Control;
            calc_btn_3.Location = new Point(211, 276);
            calc_btn_3.Margin = new Padding(0);
            calc_btn_3.Name = "calc_btn_3";
            calc_btn_3.Size = new Size(116, 92);
            calc_btn_3.TabIndex = 8;
            calc_btn_3.Text = "3";
            calc_btn_3.UseVisualStyleBackColor = false;
            calc_btn_3.Click += calc_btn_3_Click;
            // 
            // calc_btn_2
            // 
            calc_btn_2.BackColor = Color.FromArgb(132, 132, 130);
            calc_btn_2.Dock = DockStyle.Fill;
            calc_btn_2.FlatAppearance.BorderColor = Color.FromArgb(93, 92, 90);
            calc_btn_2.FlatStyle = FlatStyle.Flat;
            calc_btn_2.ForeColor = SystemColors.Control;
            calc_btn_2.Location = new Point(102, 276);
            calc_btn_2.Margin = new Padding(0);
            calc_btn_2.Name = "calc_btn_2";
            calc_btn_2.Size = new Size(109, 92);
            calc_btn_2.TabIndex = 7;
            calc_btn_2.Text = "2";
            calc_btn_2.UseVisualStyleBackColor = false;
            calc_btn_2.Click += calc_btn_2_Click;
            // 
            // calc_btn_1
            // 
            calc_btn_1.BackColor = Color.FromArgb(132, 132, 130);
            calc_btn_1.Dock = DockStyle.Fill;
            calc_btn_1.FlatAppearance.BorderColor = Color.FromArgb(93, 92, 90);
            calc_btn_1.FlatStyle = FlatStyle.Flat;
            calc_btn_1.ForeColor = SystemColors.Control;
            calc_btn_1.Location = new Point(0, 276);
            calc_btn_1.Margin = new Padding(0);
            calc_btn_1.Name = "calc_btn_1";
            calc_btn_1.Size = new Size(102, 92);
            calc_btn_1.TabIndex = 6;
            calc_btn_1.Text = "1";
            calc_btn_1.UseVisualStyleBackColor = false;
            calc_btn_1.Click += calc_btn_1_Click;
            // 
            // calc_btn_6
            // 
            calc_btn_6.BackColor = Color.FromArgb(132, 132, 130);
            calc_btn_6.Dock = DockStyle.Fill;
            calc_btn_6.FlatAppearance.BorderColor = Color.FromArgb(93, 92, 90);
            calc_btn_6.FlatStyle = FlatStyle.Flat;
            calc_btn_6.ForeColor = SystemColors.Control;
            calc_btn_6.Location = new Point(211, 184);
            calc_btn_6.Margin = new Padding(0);
            calc_btn_6.Name = "calc_btn_6";
            calc_btn_6.Size = new Size(116, 92);
            calc_btn_6.TabIndex = 5;
            calc_btn_6.Text = "6";
            calc_btn_6.UseVisualStyleBackColor = false;
            calc_btn_6.Click += calc_btn_6_Click;
            // 
            // calc_btn_5
            // 
            calc_btn_5.BackColor = Color.FromArgb(132, 132, 130);
            calc_btn_5.Dock = DockStyle.Fill;
            calc_btn_5.FlatAppearance.BorderColor = Color.FromArgb(93, 92, 90);
            calc_btn_5.FlatStyle = FlatStyle.Flat;
            calc_btn_5.ForeColor = SystemColors.Control;
            calc_btn_5.Location = new Point(102, 184);
            calc_btn_5.Margin = new Padding(0);
            calc_btn_5.Name = "calc_btn_5";
            calc_btn_5.Size = new Size(109, 92);
            calc_btn_5.TabIndex = 4;
            calc_btn_5.Text = "5";
            calc_btn_5.UseVisualStyleBackColor = false;
            calc_btn_5.Click += calc_btn_5_Click;
            // 
            // calc_btn_4
            // 
            calc_btn_4.BackColor = Color.FromArgb(132, 132, 130);
            calc_btn_4.Dock = DockStyle.Fill;
            calc_btn_4.FlatAppearance.BorderColor = Color.FromArgb(93, 92, 90);
            calc_btn_4.FlatStyle = FlatStyle.Flat;
            calc_btn_4.ForeColor = SystemColors.Control;
            calc_btn_4.Location = new Point(0, 184);
            calc_btn_4.Margin = new Padding(0);
            calc_btn_4.Name = "calc_btn_4";
            calc_btn_4.Size = new Size(102, 92);
            calc_btn_4.TabIndex = 3;
            calc_btn_4.Text = "4";
            calc_btn_4.UseVisualStyleBackColor = false;
            calc_btn_4.Click += calc_btn_4_Click;
            // 
            // calc_btn_9
            // 
            calc_btn_9.BackColor = Color.FromArgb(132, 132, 130);
            calc_btn_9.Dock = DockStyle.Fill;
            calc_btn_9.FlatAppearance.BorderColor = Color.FromArgb(93, 92, 90);
            calc_btn_9.FlatStyle = FlatStyle.Flat;
            calc_btn_9.ForeColor = SystemColors.Control;
            calc_btn_9.Location = new Point(211, 92);
            calc_btn_9.Margin = new Padding(0);
            calc_btn_9.Name = "calc_btn_9";
            calc_btn_9.Size = new Size(116, 92);
            calc_btn_9.TabIndex = 2;
            calc_btn_9.Text = "9";
            calc_btn_9.UseVisualStyleBackColor = false;
            calc_btn_9.Click += calc_btn_9_Click;
            // 
            // calc_btn_8
            // 
            calc_btn_8.BackColor = Color.FromArgb(132, 132, 130);
            calc_btn_8.Dock = DockStyle.Fill;
            calc_btn_8.FlatAppearance.BorderColor = Color.FromArgb(93, 92, 90);
            calc_btn_8.FlatStyle = FlatStyle.Flat;
            calc_btn_8.ForeColor = SystemColors.Control;
            calc_btn_8.Location = new Point(102, 92);
            calc_btn_8.Margin = new Padding(0);
            calc_btn_8.Name = "calc_btn_8";
            calc_btn_8.Size = new Size(109, 92);
            calc_btn_8.TabIndex = 1;
            calc_btn_8.Text = "8";
            calc_btn_8.UseVisualStyleBackColor = false;
            calc_btn_8.Click += calc_btn_8_Click;
            // 
            // calc_btn_7
            // 
            calc_btn_7.BackColor = Color.FromArgb(132, 132, 130);
            calc_btn_7.Dock = DockStyle.Fill;
            calc_btn_7.FlatAppearance.BorderColor = Color.FromArgb(93, 92, 90);
            calc_btn_7.FlatStyle = FlatStyle.Flat;
            calc_btn_7.ForeColor = SystemColors.Control;
            calc_btn_7.Location = new Point(0, 92);
            calc_btn_7.Margin = new Padding(0);
            calc_btn_7.Name = "calc_btn_7";
            calc_btn_7.Size = new Size(102, 92);
            calc_btn_7.TabIndex = 0;
            calc_btn_7.Text = "7";
            calc_btn_7.UseVisualStyleBackColor = false;
            calc_btn_7.Click += calc_btn_7_Click;
            // 
            // calc_dot
            // 
            calc_dot.BackColor = Color.FromArgb(132, 132, 130);
            calc_dot.Dock = DockStyle.Fill;
            calc_dot.FlatAppearance.BorderColor = Color.FromArgb(93, 92, 90);
            calc_dot.FlatStyle = FlatStyle.Flat;
            calc_dot.ForeColor = SystemColors.Control;
            calc_dot.Location = new Point(211, 368);
            calc_dot.Margin = new Padding(0);
            calc_dot.Name = "calc_dot";
            calc_dot.Size = new Size(116, 93);
            calc_dot.TabIndex = 11;
            calc_dot.Text = ",";
            calc_dot.UseVisualStyleBackColor = false;
            calc_dot.Click += calc_btn_dot_Click;
            // 
            // calc_btn_div
            // 
            calc_btn_div.BackColor = Color.FromArgb(243, 163, 61);
            calc_btn_div.Dock = DockStyle.Fill;
            calc_btn_div.FlatAppearance.BorderColor = Color.FromArgb(93, 92, 90);
            calc_btn_div.FlatStyle = FlatStyle.Flat;
            calc_btn_div.ForeColor = SystemColors.Control;
            calc_btn_div.Location = new Point(0, 0);
            calc_btn_div.Margin = new Padding(0);
            calc_btn_div.Name = "calc_btn_div";
            calc_btn_div.Size = new Size(106, 92);
            calc_btn_div.TabIndex = 3;
            calc_btn_div.Text = "/";
            calc_btn_div.UseVisualStyleBackColor = false;
            calc_btn_div.Click += calc_btn_div_Click;
            // 
            // calc_btn_multi
            // 
            calc_btn_multi.BackColor = Color.FromArgb(243, 163, 61);
            calc_btn_multi.Dock = DockStyle.Fill;
            calc_btn_multi.FlatAppearance.BorderColor = Color.FromArgb(93, 92, 90);
            calc_btn_multi.FlatStyle = FlatStyle.Flat;
            calc_btn_multi.ForeColor = SystemColors.Control;
            calc_btn_multi.Location = new Point(0, 92);
            calc_btn_multi.Margin = new Padding(0);
            calc_btn_multi.Name = "calc_btn_multi";
            calc_btn_multi.Size = new Size(106, 92);
            calc_btn_multi.TabIndex = 2;
            calc_btn_multi.Text = "*";
            calc_btn_multi.UseVisualStyleBackColor = false;
            calc_btn_multi.Click += calc_btn_multi_Click;
            // 
            // calc_btn_minus
            // 
            calc_btn_minus.BackColor = Color.FromArgb(243, 163, 61);
            calc_btn_minus.Dock = DockStyle.Fill;
            calc_btn_minus.FlatAppearance.BorderColor = Color.FromArgb(93, 92, 90);
            calc_btn_minus.FlatStyle = FlatStyle.Flat;
            calc_btn_minus.ForeColor = SystemColors.Control;
            calc_btn_minus.Location = new Point(0, 184);
            calc_btn_minus.Margin = new Padding(0);
            calc_btn_minus.Name = "calc_btn_minus";
            calc_btn_minus.Size = new Size(106, 92);
            calc_btn_minus.TabIndex = 1;
            calc_btn_minus.Text = "-";
            calc_btn_minus.UseVisualStyleBackColor = false;
            calc_btn_minus.Click += calc_btn_minus_Click;
            // 
            // calc_btn_plus
            // 
            calc_btn_plus.BackColor = Color.FromArgb(243, 163, 61);
            calc_btn_plus.Dock = DockStyle.Fill;
            calc_btn_plus.FlatAppearance.BorderColor = Color.FromArgb(93, 92, 90);
            calc_btn_plus.FlatStyle = FlatStyle.Flat;
            calc_btn_plus.ForeColor = SystemColors.Control;
            calc_btn_plus.Location = new Point(0, 276);
            calc_btn_plus.Margin = new Padding(0);
            calc_btn_plus.Name = "calc_btn_plus";
            calc_btn_plus.Size = new Size(106, 92);
            calc_btn_plus.TabIndex = 0;
            calc_btn_plus.Text = "+";
            calc_btn_plus.UseVisualStyleBackColor = false;
            calc_btn_plus.Click += calc_btn_plus_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(calc_btn_equal, 0, 4);
            tableLayoutPanel2.Controls.Add(calc_btn_plus, 0, 3);
            tableLayoutPanel2.Controls.Add(calc_btn_minus, 0, 2);
            tableLayoutPanel2.Controls.Add(calc_btn_multi, 0, 1);
            tableLayoutPanel2.Controls.Add(calc_btn_div, 0, 0);
            tableLayoutPanel2.Location = new Point(327, 80);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(106, 461);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // calc_btn_equal
            // 
            calc_btn_equal.BackColor = Color.FromArgb(243, 163, 61);
            calc_btn_equal.Dock = DockStyle.Fill;
            calc_btn_equal.FlatAppearance.BorderColor = Color.FromArgb(93, 92, 90);
            calc_btn_equal.FlatStyle = FlatStyle.Flat;
            calc_btn_equal.ForeColor = SystemColors.Control;
            calc_btn_equal.Location = new Point(0, 368);
            calc_btn_equal.Margin = new Padding(0);
            calc_btn_equal.Name = "calc_btn_equal";
            calc_btn_equal.Size = new Size(106, 93);
            calc_btn_equal.TabIndex = 5;
            calc_btn_equal.Text = "=";
            calc_btn_equal.UseVisualStyleBackColor = false;
            calc_btn_equal.Click += calc_btn_equal_Click;
            // 
            // macos_style
            // 
            macos_style.BackColor = SystemColors.Control;
            macos_style.Controls.Add(calculator_text);
            macos_style.Controls.Add(tableLayoutPanel1);
            macos_style.Controls.Add(tableLayoutPanel2);
            macos_style.Location = new Point(187, 9);
            macos_style.Margin = new Padding(0);
            macos_style.Name = "macos_style";
            macos_style.Size = new Size(433, 541);
            macos_style.TabIndex = 3;
            // 
            // windows_style
            // 
            windows_style.BackColor = Color.FromArgb(32, 32, 32);
            windows_style.Controls.Add(win_calculator_text);
            windows_style.Controls.Add(tableLayoutPanel3);
            windows_style.Controls.Add(tableLayoutPanel4);
            windows_style.Location = new Point(171, 9);
            windows_style.Margin = new Padding(0);
            windows_style.Name = "windows_style";
            windows_style.Size = new Size(453, 603);
            windows_style.TabIndex = 4;
            windows_style.Visible = false;
            // 
            // win_calculator_text
            // 
            win_calculator_text.BackColor = Color.FromArgb(32, 32, 32);
            win_calculator_text.BorderStyle = BorderStyle.FixedSingle;
            win_calculator_text.ForeColor = SystemColors.Control;
            win_calculator_text.Location = new Point(0, 0);
            win_calculator_text.Margin = new Padding(0);
            win_calculator_text.Name = "win_calculator_text";
            win_calculator_text.Size = new Size(453, 80);
            win_calculator_text.TabIndex = 0;
            win_calculator_text.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(win_calc_racine, 2, 1);
            tableLayoutPanel3.Controls.Add(win_calc_carre, 0, 1);
            tableLayoutPanel3.Controls.Add(win_calc_btn_clear, 0, 1);
            tableLayoutPanel3.Controls.Add(win_calc_btn_modulo, 0, 0);
            tableLayoutPanel3.Controls.Add(win_calc_btn_change_sign, 0, 5);
            tableLayoutPanel3.Controls.Add(win_calc_btn_0, 1, 5);
            tableLayoutPanel3.Controls.Add(win_calc_btn_3, 2, 4);
            tableLayoutPanel3.Controls.Add(win_calc_btn_2, 1, 4);
            tableLayoutPanel3.Controls.Add(win_calc_btn_1, 0, 4);
            tableLayoutPanel3.Controls.Add(win_calc_btn_6, 2, 3);
            tableLayoutPanel3.Controls.Add(win_calc_btn_5, 1, 3);
            tableLayoutPanel3.Controls.Add(win_calc_btn_4, 0, 3);
            tableLayoutPanel3.Controls.Add(win_calc_btn_9, 2, 2);
            tableLayoutPanel3.Controls.Add(win_calc_btn_8, 1, 2);
            tableLayoutPanel3.Controls.Add(win_calc_btn_7, 0, 2);
            tableLayoutPanel3.Controls.Add(win_calc_btn_dot, 2, 5);
            tableLayoutPanel3.Location = new Point(0, 80);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 6;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(346, 520);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // win_calc_racine
            // 
            win_calc_racine.BackColor = Color.FromArgb(50, 50, 50);
            win_calc_racine.Dock = DockStyle.Fill;
            win_calc_racine.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            win_calc_racine.FlatStyle = FlatStyle.Flat;
            win_calc_racine.ForeColor = SystemColors.Control;
            win_calc_racine.Location = new Point(233, 89);
            win_calc_racine.Name = "win_calc_racine";
            win_calc_racine.Size = new Size(110, 80);
            win_calc_racine.TabIndex = 18;
            win_calc_racine.Text = "√x";
            win_calc_racine.UseVisualStyleBackColor = false;
            win_calc_racine.Click += win_calc_racine_Click;
            // 
            // win_calc_carre
            // 
            win_calc_carre.BackColor = Color.FromArgb(50, 50, 50);
            win_calc_carre.Dock = DockStyle.Fill;
            win_calc_carre.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            win_calc_carre.FlatStyle = FlatStyle.Flat;
            win_calc_carre.ForeColor = SystemColors.Control;
            win_calc_carre.Location = new Point(118, 89);
            win_calc_carre.Name = "win_calc_carre";
            win_calc_carre.Size = new Size(109, 80);
            win_calc_carre.TabIndex = 17;
            win_calc_carre.Text = "x²";
            win_calc_carre.UseVisualStyleBackColor = false;
            win_calc_carre.Click += win_calc_carre_Click;
            // 
            // win_calc_btn_clear
            // 
            win_calc_btn_clear.BackColor = Color.FromArgb(50, 50, 50);
            win_calc_btn_clear.Dock = DockStyle.Fill;
            win_calc_btn_clear.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            win_calc_btn_clear.FlatStyle = FlatStyle.Flat;
            win_calc_btn_clear.ForeColor = SystemColors.Control;
            win_calc_btn_clear.Location = new Point(3, 89);
            win_calc_btn_clear.Name = "win_calc_btn_clear";
            win_calc_btn_clear.Size = new Size(109, 80);
            win_calc_btn_clear.TabIndex = 16;
            win_calc_btn_clear.Text = "AC";
            win_calc_btn_clear.UseVisualStyleBackColor = false;
            win_calc_btn_clear.Click += calc_btn_clear_Click;
            // 
            // win_calc_btn_modulo
            // 
            win_calc_btn_modulo.BackColor = Color.FromArgb(50, 50, 50);
            win_calc_btn_modulo.Dock = DockStyle.Fill;
            win_calc_btn_modulo.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            win_calc_btn_modulo.FlatStyle = FlatStyle.Flat;
            win_calc_btn_modulo.ForeColor = SystemColors.Control;
            win_calc_btn_modulo.Location = new Point(3, 3);
            win_calc_btn_modulo.Name = "win_calc_btn_modulo";
            win_calc_btn_modulo.Size = new Size(109, 80);
            win_calc_btn_modulo.TabIndex = 15;
            win_calc_btn_modulo.Text = "%";
            win_calc_btn_modulo.UseVisualStyleBackColor = false;
            win_calc_btn_modulo.Click += calc_btn_modulo_Click;
            // 
            // win_calc_btn_change_sign
            // 
            win_calc_btn_change_sign.BackColor = Color.FromArgb(59, 59, 59);
            win_calc_btn_change_sign.Dock = DockStyle.Fill;
            win_calc_btn_change_sign.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            win_calc_btn_change_sign.FlatStyle = FlatStyle.Flat;
            win_calc_btn_change_sign.ForeColor = SystemColors.Control;
            win_calc_btn_change_sign.Location = new Point(3, 433);
            win_calc_btn_change_sign.Name = "win_calc_btn_change_sign";
            win_calc_btn_change_sign.Size = new Size(109, 84);
            win_calc_btn_change_sign.TabIndex = 14;
            win_calc_btn_change_sign.Text = "+/-";
            win_calc_btn_change_sign.UseVisualStyleBackColor = false;
            win_calc_btn_change_sign.Click += calc_change_sign_Click;
            // 
            // win_calc_btn_0
            // 
            win_calc_btn_0.BackColor = Color.FromArgb(59, 59, 59);
            win_calc_btn_0.Dock = DockStyle.Fill;
            win_calc_btn_0.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            win_calc_btn_0.FlatStyle = FlatStyle.Flat;
            win_calc_btn_0.ForeColor = SystemColors.Control;
            win_calc_btn_0.Location = new Point(118, 433);
            win_calc_btn_0.Name = "win_calc_btn_0";
            win_calc_btn_0.Size = new Size(109, 84);
            win_calc_btn_0.TabIndex = 10;
            win_calc_btn_0.Text = "0";
            win_calc_btn_0.UseVisualStyleBackColor = false;
            win_calc_btn_0.Click += calc_btn_0_Click;
            // 
            // win_calc_btn_3
            // 
            win_calc_btn_3.BackColor = Color.FromArgb(59, 59, 59);
            win_calc_btn_3.Dock = DockStyle.Fill;
            win_calc_btn_3.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            win_calc_btn_3.FlatStyle = FlatStyle.Flat;
            win_calc_btn_3.ForeColor = SystemColors.Control;
            win_calc_btn_3.Location = new Point(233, 347);
            win_calc_btn_3.Name = "win_calc_btn_3";
            win_calc_btn_3.Size = new Size(110, 80);
            win_calc_btn_3.TabIndex = 8;
            win_calc_btn_3.Text = "3";
            win_calc_btn_3.UseVisualStyleBackColor = false;
            win_calc_btn_3.Click += calc_btn_3_Click;
            // 
            // win_calc_btn_2
            // 
            win_calc_btn_2.BackColor = Color.FromArgb(59, 59, 59);
            win_calc_btn_2.Dock = DockStyle.Fill;
            win_calc_btn_2.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            win_calc_btn_2.FlatStyle = FlatStyle.Flat;
            win_calc_btn_2.ForeColor = SystemColors.Control;
            win_calc_btn_2.Location = new Point(118, 347);
            win_calc_btn_2.Name = "win_calc_btn_2";
            win_calc_btn_2.Size = new Size(109, 80);
            win_calc_btn_2.TabIndex = 7;
            win_calc_btn_2.Text = "2";
            win_calc_btn_2.UseVisualStyleBackColor = false;
            win_calc_btn_2.Click += calc_btn_2_Click;
            // 
            // win_calc_btn_1
            // 
            win_calc_btn_1.BackColor = Color.FromArgb(59, 59, 59);
            win_calc_btn_1.Dock = DockStyle.Fill;
            win_calc_btn_1.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            win_calc_btn_1.FlatStyle = FlatStyle.Flat;
            win_calc_btn_1.ForeColor = SystemColors.Control;
            win_calc_btn_1.Location = new Point(3, 347);
            win_calc_btn_1.Name = "win_calc_btn_1";
            win_calc_btn_1.Size = new Size(109, 80);
            win_calc_btn_1.TabIndex = 6;
            win_calc_btn_1.Text = "1";
            win_calc_btn_1.UseVisualStyleBackColor = false;
            win_calc_btn_1.Click += calc_btn_1_Click;
            // 
            // win_calc_btn_6
            // 
            win_calc_btn_6.BackColor = Color.FromArgb(59, 59, 59);
            win_calc_btn_6.Dock = DockStyle.Fill;
            win_calc_btn_6.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            win_calc_btn_6.FlatStyle = FlatStyle.Flat;
            win_calc_btn_6.ForeColor = SystemColors.Control;
            win_calc_btn_6.Location = new Point(233, 261);
            win_calc_btn_6.Name = "win_calc_btn_6";
            win_calc_btn_6.Size = new Size(110, 80);
            win_calc_btn_6.TabIndex = 5;
            win_calc_btn_6.Text = "6";
            win_calc_btn_6.UseVisualStyleBackColor = false;
            win_calc_btn_6.Click += calc_btn_6_Click;
            // 
            // win_calc_btn_5
            // 
            win_calc_btn_5.BackColor = Color.FromArgb(59, 59, 59);
            win_calc_btn_5.Dock = DockStyle.Fill;
            win_calc_btn_5.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            win_calc_btn_5.FlatStyle = FlatStyle.Flat;
            win_calc_btn_5.ForeColor = SystemColors.Control;
            win_calc_btn_5.Location = new Point(118, 261);
            win_calc_btn_5.Name = "win_calc_btn_5";
            win_calc_btn_5.Size = new Size(109, 80);
            win_calc_btn_5.TabIndex = 4;
            win_calc_btn_5.Text = "5";
            win_calc_btn_5.UseVisualStyleBackColor = false;
            win_calc_btn_5.Click += calc_btn_5_Click;
            // 
            // win_calc_btn_4
            // 
            win_calc_btn_4.BackColor = Color.FromArgb(59, 59, 59);
            win_calc_btn_4.Dock = DockStyle.Fill;
            win_calc_btn_4.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            win_calc_btn_4.FlatStyle = FlatStyle.Flat;
            win_calc_btn_4.ForeColor = SystemColors.Control;
            win_calc_btn_4.Location = new Point(3, 261);
            win_calc_btn_4.Name = "win_calc_btn_4";
            win_calc_btn_4.Size = new Size(109, 80);
            win_calc_btn_4.TabIndex = 3;
            win_calc_btn_4.Text = "4";
            win_calc_btn_4.UseVisualStyleBackColor = false;
            win_calc_btn_4.Click += calc_btn_4_Click;
            // 
            // win_calc_btn_9
            // 
            win_calc_btn_9.BackColor = Color.FromArgb(59, 59, 59);
            win_calc_btn_9.Dock = DockStyle.Fill;
            win_calc_btn_9.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            win_calc_btn_9.FlatStyle = FlatStyle.Flat;
            win_calc_btn_9.ForeColor = SystemColors.Control;
            win_calc_btn_9.Location = new Point(233, 175);
            win_calc_btn_9.Name = "win_calc_btn_9";
            win_calc_btn_9.Size = new Size(110, 80);
            win_calc_btn_9.TabIndex = 2;
            win_calc_btn_9.Text = "9";
            win_calc_btn_9.UseVisualStyleBackColor = false;
            win_calc_btn_9.Click += calc_btn_9_Click;
            // 
            // win_calc_btn_8
            // 
            win_calc_btn_8.BackColor = Color.FromArgb(59, 59, 59);
            win_calc_btn_8.Dock = DockStyle.Fill;
            win_calc_btn_8.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            win_calc_btn_8.FlatStyle = FlatStyle.Flat;
            win_calc_btn_8.ForeColor = SystemColors.Control;
            win_calc_btn_8.Location = new Point(118, 175);
            win_calc_btn_8.Name = "win_calc_btn_8";
            win_calc_btn_8.Size = new Size(109, 80);
            win_calc_btn_8.TabIndex = 1;
            win_calc_btn_8.Text = "8";
            win_calc_btn_8.UseVisualStyleBackColor = false;
            win_calc_btn_8.Click += calc_btn_8_Click;
            // 
            // win_calc_btn_7
            // 
            win_calc_btn_7.BackColor = Color.FromArgb(59, 59, 59);
            win_calc_btn_7.Dock = DockStyle.Fill;
            win_calc_btn_7.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            win_calc_btn_7.FlatStyle = FlatStyle.Flat;
            win_calc_btn_7.ForeColor = SystemColors.Control;
            win_calc_btn_7.Location = new Point(3, 175);
            win_calc_btn_7.Name = "win_calc_btn_7";
            win_calc_btn_7.Size = new Size(109, 80);
            win_calc_btn_7.TabIndex = 0;
            win_calc_btn_7.Text = "7";
            win_calc_btn_7.UseVisualStyleBackColor = false;
            win_calc_btn_7.Click += calc_btn_7_Click;
            // 
            // win_calc_btn_dot
            // 
            win_calc_btn_dot.BackColor = Color.FromArgb(59, 59, 59);
            win_calc_btn_dot.Dock = DockStyle.Fill;
            win_calc_btn_dot.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            win_calc_btn_dot.FlatStyle = FlatStyle.Flat;
            win_calc_btn_dot.ForeColor = SystemColors.Control;
            win_calc_btn_dot.Location = new Point(233, 433);
            win_calc_btn_dot.Name = "win_calc_btn_dot";
            win_calc_btn_dot.Size = new Size(110, 84);
            win_calc_btn_dot.TabIndex = 11;
            win_calc_btn_dot.Text = ",";
            win_calc_btn_dot.UseVisualStyleBackColor = false;
            win_calc_btn_dot.Click += calc_btn_dot_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(win_calc_btn_delete, 0, 0);
            tableLayoutPanel4.Controls.Add(win_calc_btn_equal, 0, 5);
            tableLayoutPanel4.Controls.Add(win_calc_btn_plus, 0, 4);
            tableLayoutPanel4.Controls.Add(win_calc_btn_minus, 0, 3);
            tableLayoutPanel4.Controls.Add(win_calc_btn_multiply, 0, 2);
            tableLayoutPanel4.Controls.Add(win_calc_btn_divide, 0, 1);
            tableLayoutPanel4.Location = new Point(346, 80);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 6;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(106, 520);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // win_calc_btn_delete
            // 
            win_calc_btn_delete.BackColor = Color.FromArgb(50, 50, 50);
            win_calc_btn_delete.Dock = DockStyle.Fill;
            win_calc_btn_delete.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            win_calc_btn_delete.FlatStyle = FlatStyle.Flat;
            win_calc_btn_delete.ForeColor = SystemColors.Control;
            win_calc_btn_delete.Location = new Point(3, 3);
            win_calc_btn_delete.Name = "win_calc_btn_delete";
            win_calc_btn_delete.Size = new Size(100, 80);
            win_calc_btn_delete.TabIndex = 6;
            win_calc_btn_delete.Text = "<-";
            win_calc_btn_delete.UseVisualStyleBackColor = false;
            win_calc_btn_delete.Click += calc_btn_remove_Click;
            // 
            // win_calc_btn_equal
            // 
            win_calc_btn_equal.BackColor = Color.FromArgb(243, 128, 100);
            win_calc_btn_equal.Dock = DockStyle.Fill;
            win_calc_btn_equal.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            win_calc_btn_equal.FlatStyle = FlatStyle.Flat;
            win_calc_btn_equal.ForeColor = SystemColors.Control;
            win_calc_btn_equal.Location = new Point(3, 433);
            win_calc_btn_equal.Name = "win_calc_btn_equal";
            win_calc_btn_equal.Size = new Size(100, 84);
            win_calc_btn_equal.TabIndex = 5;
            win_calc_btn_equal.Text = "=";
            win_calc_btn_equal.UseVisualStyleBackColor = false;
            win_calc_btn_equal.Click += calc_btn_equal_Click;
            // 
            // win_calc_btn_plus
            // 
            win_calc_btn_plus.BackColor = Color.FromArgb(50, 50, 50);
            win_calc_btn_plus.Dock = DockStyle.Fill;
            win_calc_btn_plus.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            win_calc_btn_plus.FlatStyle = FlatStyle.Flat;
            win_calc_btn_plus.ForeColor = SystemColors.Control;
            win_calc_btn_plus.Location = new Point(3, 347);
            win_calc_btn_plus.Name = "win_calc_btn_plus";
            win_calc_btn_plus.Size = new Size(100, 80);
            win_calc_btn_plus.TabIndex = 0;
            win_calc_btn_plus.Text = "+";
            win_calc_btn_plus.UseVisualStyleBackColor = false;
            win_calc_btn_plus.Click += calc_btn_plus_Click;
            // 
            // win_calc_btn_minus
            // 
            win_calc_btn_minus.BackColor = Color.FromArgb(50, 50, 50);
            win_calc_btn_minus.Dock = DockStyle.Fill;
            win_calc_btn_minus.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            win_calc_btn_minus.FlatStyle = FlatStyle.Flat;
            win_calc_btn_minus.ForeColor = SystemColors.Control;
            win_calc_btn_minus.Location = new Point(3, 261);
            win_calc_btn_minus.Name = "win_calc_btn_minus";
            win_calc_btn_minus.Size = new Size(100, 80);
            win_calc_btn_minus.TabIndex = 1;
            win_calc_btn_minus.Text = "-";
            win_calc_btn_minus.UseVisualStyleBackColor = false;
            win_calc_btn_minus.Click += calc_btn_minus_Click;
            // 
            // win_calc_btn_multiply
            // 
            win_calc_btn_multiply.BackColor = Color.FromArgb(50, 50, 50);
            win_calc_btn_multiply.Dock = DockStyle.Fill;
            win_calc_btn_multiply.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            win_calc_btn_multiply.FlatStyle = FlatStyle.Flat;
            win_calc_btn_multiply.ForeColor = SystemColors.Control;
            win_calc_btn_multiply.Location = new Point(3, 175);
            win_calc_btn_multiply.Name = "win_calc_btn_multiply";
            win_calc_btn_multiply.Size = new Size(100, 80);
            win_calc_btn_multiply.TabIndex = 2;
            win_calc_btn_multiply.Text = "*";
            win_calc_btn_multiply.UseVisualStyleBackColor = false;
            win_calc_btn_multiply.Click += calc_btn_multi_Click;
            // 
            // win_calc_btn_divide
            // 
            win_calc_btn_divide.BackColor = Color.FromArgb(50, 50, 50);
            win_calc_btn_divide.Dock = DockStyle.Fill;
            win_calc_btn_divide.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
            win_calc_btn_divide.FlatStyle = FlatStyle.Flat;
            win_calc_btn_divide.ForeColor = SystemColors.Control;
            win_calc_btn_divide.Location = new Point(3, 89);
            win_calc_btn_divide.Name = "win_calc_btn_divide";
            win_calc_btn_divide.Size = new Size(100, 80);
            win_calc_btn_divide.TabIndex = 3;
            win_calc_btn_divide.Text = "/";
            win_calc_btn_divide.UseVisualStyleBackColor = false;
            win_calc_btn_divide.Click += calc_btn_div_Click;
            // 
            // style_choice
            // 
            style_choice.FormattingEnabled = true;
            style_choice.Items.AddRange(new object[] { "MacOS", "Windows" });
            style_choice.Location = new Point(282, 639);
            style_choice.Name = "style_choice";
            style_choice.Size = new Size(242, 40);
            style_choice.TabIndex = 5;
            style_choice.Text = "MacOS";
            style_choice.SelectedIndexChanged += style_choice_SelectedIndexChanged;
            // 
            // historyTextBox
            // 
            historyTextBox.Location = new Point(663, 173);
            historyTextBox.Name = "historyTextBox";
            historyTextBox.Size = new Size(224, 439);
            historyTextBox.TabIndex = 6;
            historyTextBox.Text = "";
            historyTextBox.Visible = false;
            // 
            // historyCheckbox
            // 
            historyCheckbox.AutoSize = true;
            historyCheckbox.Location = new Point(663, 115);
            historyCheckbox.Name = "historyCheckbox";
            historyCheckbox.Size = new Size(246, 36);
            historyCheckbox.TabIndex = 7;
            historyCheckbox.Text = "Afficher Historique";
            historyCheckbox.UseVisualStyleBackColor = true;
            historyCheckbox.CheckedChanged += historyCheckbox_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(918, 691);
            Controls.Add(historyCheckbox);
            Controls.Add(historyTextBox);
            Controls.Add(style_choice);
            Controls.Add(windows_style);
            Controls.Add(macos_style);
            Name = "Form1";
            Text = "Projet Calculette";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            macos_style.ResumeLayout(false);
            windows_style.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Button calc_btn_7;
        private Button calc_btn_plus;
        private Button calc_btn_minus;
        private Button calc_btn_multi;
        private Button calc_btn_div;
        private Label calculator_text;
        private Button calc_btn_0;
        private Button calc_btn_3;
        private Button calc_btn_2;
        private Button calc_btn_1;
        private Button calc_btn_6;
        private Button calc_btn_5;
        private Button calc_btn_4;
        private Button calc_btn_9;
        private Button calc_btn_8;
        private Button calc_dot;
        private Button calc_btn_clear;
        private Button calc_btn_modulo;
        private Button calc_change_sign;
        private TableLayoutPanel tableLayoutPanel2;
        private Button calc_btn_equal;
        private FlowLayoutPanel macos_style;
        private FlowLayoutPanel windows_style;
        private Label win_calculator_text;
        private TableLayoutPanel tableLayoutPanel3;
        private Button win_calc_btn_clear;
        private Button win_calc_btn_change_sign;
        private Button win_calc_btn_0;
        private Button win_calc_btn_3;
        private Button win_calc_btn_2;
        private Button win_calc_btn_1;
        private Button win_calc_btn_6;
        private Button win_calc_btn_5;
        private Button win_calc_btn_4;
        private Button win_calc_btn_9;
        private Button win_calc_btn_8;
        private Button win_calc_btn_7;
        private Button win_calc_btn_dot;
        private TableLayoutPanel tableLayoutPanel4;
        private Button win_calc_btn_equal;
        private Button win_calc_btn_plus;
        private Button win_calc_btn_minus;
        private Button win_calc_btn_multiply;
        private Button win_calc_btn_divide;
        private ComboBox style_choice;
        private Button win_calc_btn_modulo;
        private Button win_calc_btn_delete;
        private Button win_calc_carre;
        private Button win_calc_racine;
        private RichTextBox historyTextBox;
        private CheckBox historyCheckbox;
    }
}
