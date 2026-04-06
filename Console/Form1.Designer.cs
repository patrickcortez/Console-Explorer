namespace Console
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
            this.tb_input1 = new System.Windows.Forms.TextBox();
            this.rtb_output = new System.Windows.Forms.RichTextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lb_path = new System.Windows.Forms.Label();
            this.rtb_log = new System.Windows.Forms.RichTextBox();
            this.dirview1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_input1
            // 
            this.tb_input1.Location = new System.Drawing.Point(70, 416);
            this.tb_input1.Name = "tb_input1";
            this.tb_input1.Size = new System.Drawing.Size(776, 22);
            this.tb_input1.TabIndex = 0;
            this.tb_input1.TextChanged += new System.EventHandler(this.tb_input1_TextChanged);
            this.tb_input1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_input1_KeyDown);
            // 
            // rtb_output
            // 
            this.rtb_output.BackColor = System.Drawing.Color.Black;
            this.rtb_output.ForeColor = System.Drawing.Color.White;
            this.rtb_output.Location = new System.Drawing.Point(70, 12);
            this.rtb_output.Name = "rtb_output";
            this.rtb_output.ReadOnly = true;
            this.rtb_output.Size = new System.Drawing.Size(776, 398);
            this.rtb_output.TabIndex = 1;
            this.rtb_output.Text = "";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(3, 416);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(61, 45);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.Text = "Enter";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lb_path
            // 
            this.lb_path.AutoSize = true;
            this.lb_path.Font = new System.Drawing.Font("Gentium Book Basic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_path.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_path.Location = new System.Drawing.Point(66, 441);
            this.lb_path.Name = "lb_path";
            this.lb_path.Size = new System.Drawing.Size(54, 20);
            this.lb_path.TabIndex = 3;
            this.lb_path.Text = "label1";
            // 
            // rtb_log
            // 
            this.rtb_log.BackColor = System.Drawing.Color.Black;
            this.rtb_log.ForeColor = System.Drawing.Color.White;
            this.rtb_log.Location = new System.Drawing.Point(3, 12);
            this.rtb_log.Name = "rtb_log";
            this.rtb_log.ReadOnly = true;
            this.rtb_log.Size = new System.Drawing.Size(61, 398);
            this.rtb_log.TabIndex = 4;
            this.rtb_log.Text = "";
            // 
            // dirview1
            // 
            this.dirview1.BackColor = System.Drawing.Color.Black;
            this.dirview1.ForeColor = System.Drawing.Color.White;
            this.dirview1.Location = new System.Drawing.Point(852, 12);
            this.dirview1.Name = "dirview1";
            this.dirview1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dirview1.Size = new System.Drawing.Size(190, 426);
            this.dirview1.TabIndex = 5;
            this.dirview1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dirview1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(883, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Directory View";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1048, 501);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dirview1);
            this.Controls.Add(this.rtb_log);
            this.Controls.Add(this.lb_path);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.rtb_output);
            this.Controls.Add(this.tb_input1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1066, 548);
            this.MinimumSize = new System.Drawing.Size(1066, 548);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Console Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.RichTextBox rtb_log;
        internal System.Windows.Forms.Label lb_path;
        internal System.Windows.Forms.RichTextBox rtb_output;
        internal System.Windows.Forms.TextBox tb_input1;
        private System.Windows.Forms.TreeView dirview1;
        private System.Windows.Forms.Label label1;
    }
}

