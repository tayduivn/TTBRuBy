﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using LibTTB;

namespace TTB
{
	/// <summary>
	/// Summary description for frmChonkhoa.
	/// </summary>
	public class frmChon1khoa : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown mm;
		private System.Windows.Forms.NumericUpDown yyyy;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button butOk;
		private System.Windows.Forms.Button butKetthuc;
        private LibTTB.AccessData ttb;
		private int i_nhom;
		private string s_makp,sql;
		public int i_makp;
		public string mmyy,tenkp;
		private System.Windows.Forms.ComboBox makp;
		private System.Windows.Forms.Label label3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmChon1khoa(AccessData acc,int nhom,string makp,string mmyy)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			ttb=acc;
			i_nhom=nhom;
			s_makp=makp;
			mm.Value=decimal.Parse(mmyy.Substring(0,2));
			yyyy.Value=decimal.Parse("20"+mmyy.Substring(2,2));
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmChon1khoa));
			this.label1 = new System.Windows.Forms.Label();
			this.mm = new System.Windows.Forms.NumericUpDown();
			this.yyyy = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.butOk = new System.Windows.Forms.Button();
			this.butKetthuc = new System.Windows.Forms.Button();
			this.makp = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.mm)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.yyyy)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tháng :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// mm
			// 
			this.mm.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mm.Location = new System.Drawing.Point(64, 16);
			this.mm.Maximum = new System.Decimal(new int[] {
															   12,
															   0,
															   0,
															   0});
			this.mm.Minimum = new System.Decimal(new int[] {
															   1,
															   0,
															   0,
															   0});
			this.mm.Name = "mm";
			this.mm.Size = new System.Drawing.Size(35, 22);
			this.mm.TabIndex = 1;
			this.mm.Value = new System.Decimal(new int[] {
															 1,
															 0,
															 0,
															 0});
			this.mm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mm_KeyDown);
			// 
			// yyyy
			// 
			this.yyyy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.yyyy.Location = new System.Drawing.Point(140, 16);
			this.yyyy.Maximum = new System.Decimal(new int[] {
																 3004,
																 0,
																 0,
																 0});
			this.yyyy.Minimum = new System.Decimal(new int[] {
																 2004,
																 0,
																 0,
																 0});
			this.yyyy.Name = "yyyy";
			this.yyyy.Size = new System.Drawing.Size(52, 22);
			this.yyyy.TabIndex = 3;
			this.yyyy.Value = new System.Decimal(new int[] {
															   2004,
															   0,
															   0,
															   0});
			this.yyyy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.yyyy_KeyDown);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label5.Location = new System.Drawing.Point(104, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 20);
			this.label5.TabIndex = 2;
			this.label5.Text = "Năm :";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// butOk
			// 
			this.butOk.Image = ((System.Drawing.Bitmap)(resources.GetObject("butOk.Image")));
			this.butOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butOk.Location = new System.Drawing.Point(28, 73);
			this.butOk.Name = "butOk";
			this.butOk.Size = new System.Drawing.Size(75, 28);
			this.butOk.TabIndex = 6;
			this.butOk.Text = "     Đồng ý";
			this.butOk.Click += new System.EventHandler(this.butOk_Click);
			// 
			// butKetthuc
			// 
			this.butKetthuc.Image = ((System.Drawing.Bitmap)(resources.GetObject("butKetthuc.Image")));
			this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butKetthuc.Location = new System.Drawing.Point(105, 73);
			this.butKetthuc.Name = "butKetthuc";
			this.butKetthuc.Size = new System.Drawing.Size(75, 28);
			this.butKetthuc.TabIndex = 7;
			this.butKetthuc.Text = "&Kết thúc";
			this.butKetthuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
			// 
			// makp
			// 
			this.makp.BackColor = System.Drawing.SystemColors.HighlightText;
			this.makp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.makp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.makp.Location = new System.Drawing.Point(64, 41);
			this.makp.Name = "makp";
			this.makp.Size = new System.Drawing.Size(128, 21);
			this.makp.TabIndex = 4;
			this.makp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.makp_KeyDown);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 23);
			this.label3.TabIndex = 17;
			this.label3.Text = "Khoa :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// frmChon1khoa
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(208, 119);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.makp,
																		  this.label3,
																		  this.butKetthuc,
																		  this.butOk,
																		  this.mm,
																		  this.yyyy,
																		  this.label5,
																		  this.label1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmChon1khoa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chọn khoa";
			this.Load += new System.EventHandler(this.frmChon1khoa_Load);
			((System.ComponentModel.ISupportInitialize)(this.mm)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.yyyy)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmChon1khoa_Load(object sender, System.EventArgs e)
		{
			makp.DisplayMember="TEN";
			makp.ValueMember="ID";
			sql="select * from d_duockp where nhom like '%"+i_nhom.ToString()+",%'";
			if (s_makp!="") sql+=" and id in ("+s_makp.Substring(0,s_makp.Length-1)+")";
			sql+=" order by stt";
			makp.DataSource=ttb.get_data(sql).Tables[0];
			makp.SelectedIndex=0;
		}

		private void mm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter || e.KeyCode==Keys.Tab) SendKeys.Send("{Tab}");
		}

		private void yyyy_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter || e.KeyCode==Keys.Tab) SendKeys.Send("{Tab}{F4}");
		}

		private void butOk_Click(object sender, System.EventArgs e)
		{
			mmyy=mm.Value.ToString().PadLeft(2,'0')+yyyy.Value.ToString().PadLeft(4,'0').Substring(2,2);
			i_makp=int.Parse(makp.SelectedValue.ToString());
			tenkp=makp.Text;
			this.Close();
		}

		private void butKetthuc_Click(object sender, System.EventArgs e)
		{
			mmyy="";
			this.Close();
		}

		private void makp_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter || e.KeyCode==Keys.Tab)
			{
				if (makp.SelectedIndex==-1) makp.SelectedIndex=0;
				SendKeys.Send("{Tab}");
			}		
		}
	}
}
