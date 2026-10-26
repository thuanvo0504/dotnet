using System;

namespace tính_tiền_điện
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
            this.lbllabel1 = new System.Windows.Forms.Label();
            this.lbllabel2 = new System.Windows.Forms.Label();
            this.lbllabel3 = new System.Windows.Forms.Label();
            this.lbllabel4 = new System.Windows.Forms.Label();
            this.texttenho = new System.Windows.Forms.TextBox();
            this.txtnhapsodienthangtruoc = new System.Windows.Forms.TextBox();
            this.txtnhapsodienthangnay = new System.Windows.Forms.TextBox();
            this.txtsodientieuthu = new System.Windows.Forms.TextBox();
            this.txttiendien = new System.Windows.Forms.TextBox();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.lbllabel5 = new System.Windows.Forms.Label();
            this.lbllabel6 = new System.Windows.Forms.Label();
            this.lbllabel7 = new System.Windows.Forms.Label();
            this.txttiendong = new System.Windows.Forms.TextBox();
            this.btntinhtiendien = new System.Windows.Forms.Button();
            this.btninhoadon = new System.Windows.Forms.Button();
            this.btnnhaplai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbllabel1
            // 
            this.lbllabel1.AutoSize = true;
            this.lbllabel1.Location = new System.Drawing.Point(123, 59);
            this.lbllabel1.Name = "lbllabel1";
            this.lbllabel1.Size = new System.Drawing.Size(105, 16);
            this.lbllabel1.TabIndex = 0;
            this.lbllabel1.Text = "nhập vào tên hộ ";
            this.lbllabel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbllabel2
            // 
            this.lbllabel2.AutoSize = true;
            this.lbllabel2.Location = new System.Drawing.Point(126, 120);
            this.lbllabel2.Name = "lbllabel2";
            this.lbllabel2.Size = new System.Drawing.Size(155, 16);
            this.lbllabel2.TabIndex = 1;
            this.lbllabel2.Text = "nhập số điện tháng trước ";
            // 
            // lbllabel3
            // 
            this.lbllabel3.AutoSize = true;
            this.lbllabel3.Location = new System.Drawing.Point(129, 180);
            this.lbllabel3.Name = "lbllabel3";
            this.lbllabel3.Size = new System.Drawing.Size(145, 16);
            this.lbllabel3.TabIndex = 2;
            this.lbllabel3.Text = "nhập số điện tháng này";
            // 
            // lbllabel4
            // 
            this.lbllabel4.AutoSize = true;
            this.lbllabel4.Location = new System.Drawing.Point(132, 239);
            this.lbllabel4.Name = "lbllabel4";
            this.lbllabel4.Size = new System.Drawing.Size(98, 16);
            this.lbllabel4.TabIndex = 3;
            this.lbllabel4.Text = "số điện tiêu thụ ";
            // 
            // texttenho
            // 
            this.texttenho.Location = new System.Drawing.Point(315, 52);
            this.texttenho.Name = "texttenho";
            this.texttenho.Size = new System.Drawing.Size(100, 22);
            this.texttenho.TabIndex = 4;
            // 
            // txtnhapsodienthangtruoc
            // 
            this.txtnhapsodienthangtruoc.Location = new System.Drawing.Point(315, 113);
            this.txtnhapsodienthangtruoc.Name = "txtnhapsodienthangtruoc";
            this.txtnhapsodienthangtruoc.Size = new System.Drawing.Size(100, 22);
            this.txtnhapsodienthangtruoc.TabIndex = 5;
            // 
            // txtnhapsodienthangnay
            // 
            this.txtnhapsodienthangnay.Location = new System.Drawing.Point(315, 173);
            this.txtnhapsodienthangnay.Name = "txtnhapsodienthangnay";
            this.txtnhapsodienthangnay.Size = new System.Drawing.Size(100, 22);
            this.txtnhapsodienthangnay.TabIndex = 6;
            // 
            // txtsodientieuthu
            // 
            this.txtsodientieuthu.Location = new System.Drawing.Point(315, 232);
            this.txtsodientieuthu.Name = "txtsodientieuthu";
            this.txtsodientieuthu.ReadOnly = true;
            this.txtsodientieuthu.Size = new System.Drawing.Size(100, 22);
            this.txtsodientieuthu.TabIndex = 7;
            // 
            // txttiendien
            // 
            this.txttiendien.Location = new System.Drawing.Point(315, 285);
            this.txttiendien.Name = "txttiendien";
            this.txttiendien.ReadOnly = true;
            this.txttiendien.Size = new System.Drawing.Size(100, 22);
            this.txttiendien.TabIndex = 8;
            // 
            // txtVAT
            // 
            this.txtVAT.Location = new System.Drawing.Point(315, 332);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.ReadOnly = true;
            this.txtVAT.Size = new System.Drawing.Size(100, 22);
            this.txtVAT.TabIndex = 9;
            // 
            // lbllabel5
            // 
            this.lbllabel5.AutoSize = true;
            this.lbllabel5.Location = new System.Drawing.Point(129, 285);
            this.lbllabel5.Name = "lbllabel5";
            this.lbllabel5.Size = new System.Drawing.Size(60, 16);
            this.lbllabel5.TabIndex = 10;
            this.lbllabel5.Text = "tiền điện ";
            // 
            // lbllabel6
            // 
            this.lbllabel6.AutoSize = true;
            this.lbllabel6.Location = new System.Drawing.Point(126, 332);
            this.lbllabel6.Name = "lbllabel6";
            this.lbllabel6.Size = new System.Drawing.Size(34, 16);
            this.lbllabel6.TabIndex = 11;
            this.lbllabel6.Text = "VAT";
            // 
            // lbllabel7
            // 
            this.lbllabel7.AutoSize = true;
            this.lbllabel7.Location = new System.Drawing.Point(123, 379);
            this.lbllabel7.Name = "lbllabel7";
            this.lbllabel7.Size = new System.Drawing.Size(65, 16);
            this.lbllabel7.TabIndex = 12;
            this.lbllabel7.Text = "tiền đóng ";
            // 
            // txttiendong
            // 
            this.txttiendong.Location = new System.Drawing.Point(315, 372);
            this.txttiendong.Name = "txttiendong";
            this.txttiendong.ReadOnly = true;
            this.txttiendong.Size = new System.Drawing.Size(100, 22);
            this.txttiendong.TabIndex = 15;
            // 
            // btntinhtiendien
            // 
            this.btntinhtiendien.Location = new System.Drawing.Point(696, 147);
            this.btntinhtiendien.Name = "btntinhtiendien";
            this.btntinhtiendien.Size = new System.Drawing.Size(75, 23);
            this.btntinhtiendien.TabIndex = 20;
            this.btntinhtiendien.Text = "tính tiền điện ";
            this.btntinhtiendien.UseVisualStyleBackColor = true;
            this.btntinhtiendien.Click += new System.EventHandler(this.btnTinhTienDien_Click);
            // 
            // btninhoadon
            // 
            this.btninhoadon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btninhoadon.Location = new System.Drawing.Point(696, 232);
            this.btninhoadon.Name = "btninhoadon";
            this.btninhoadon.Size = new System.Drawing.Size(75, 23);
            this.btninhoadon.TabIndex = 21;
            this.btninhoadon.Text = "in hóa đơn ";
            this.btninhoadon.UseVisualStyleBackColor = false;
            // 
            // btnnhaplai
            // 
            this.btnnhaplai.Location = new System.Drawing.Point(696, 303);
            this.btnnhaplai.Name = "btnnhaplai";
            this.btnnhaplai.Size = new System.Drawing.Size(75, 23);
            this.btnnhaplai.TabIndex = 22;
            this.btnnhaplai.Text = "nhập lại ";
            this.btnnhaplai.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1062, 773);
            this.Controls.Add(this.btnnhaplai);
            this.Controls.Add(this.btninhoadon);
            this.Controls.Add(this.btntinhtiendien);
            this.Controls.Add(this.txttiendong);
            this.Controls.Add(this.lbllabel7);
            this.Controls.Add(this.lbllabel6);
            this.Controls.Add(this.lbllabel5);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.txttiendien);
            this.Controls.Add(this.txtsodientieuthu);
            this.Controls.Add(this.txtnhapsodienthangnay);
            this.Controls.Add(this.txtnhapsodienthangtruoc);
            this.Controls.Add(this.texttenho);
            this.Controls.Add(this.lbllabel4);
            this.Controls.Add(this.lbllabel3);
            this.Controls.Add(this.lbllabel2);
            this.Controls.Add(this.lbllabel1);
            this.Name = "Form1";
            this.Text = "tính tiền điện ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private System.Windows.Forms.Label lbllabel1;
        private System.Windows.Forms.Label lbllabel2;
        private System.Windows.Forms.Label lbllabel3;
        private System.Windows.Forms.Label lbllabel4;
        private System.Windows.Forms.TextBox texttenho;
        private System.Windows.Forms.TextBox txtnhapsodienthangtruoc;
        private System.Windows.Forms.TextBox txtnhapsodienthangnay;
        private System.Windows.Forms.TextBox txtsodientieuthu;
        private System.Windows.Forms.TextBox txttiendien;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.Label lbllabel5;
        private System.Windows.Forms.Label lbllabel6;
        private System.Windows.Forms.Label lbllabel7;
        private System.Windows.Forms.TextBox txttiendong;
        private System.Windows.Forms.Button btntinhtiendien;
        private System.Windows.Forms.Button btninhoadon;
        private System.Windows.Forms.Button btnnhaplai;
    }
}

