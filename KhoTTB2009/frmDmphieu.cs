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
	/// Summary description for frmDm.
	/// </summary>
	public class frmDmphieu : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button butKetthuc;
        private LibTTB.AccessData ttb;
        //private LibDuoc.AccessData d=new LibDuoc.AccessData();
		private DataTable dt=new DataTable();
		private DataTable dtkho=new DataTable();
		private DataTable dtnguon=new DataTable();
		private DataTable dtnhom=new DataTable();
		private DataTable dtdt=new DataTable();
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button butSua;
		private System.Windows.Forms.Button butLuu;
        private System.Windows.Forms.Button butBoqua;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown stt;
		private int i_nhom,i_id,itable,i_userid;
		private string s_kho,s_makho,s_nguon,s_madoituong,user,sql;
		private System.Windows.Forms.TextBox ten;
		private System.Windows.Forms.CheckedListBox kho;
		private System.Windows.Forms.CheckedListBox nguon;
		private System.Windows.Forms.CheckedListBox madoituong;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

        public frmDmphieu(AccessData acc, int nhom, string kho, string title, int userid)
        {
            InitializeComponent();
            ttb = acc; this.Text = title; i_nhom = nhom; s_makho = kho; i_userid = userid;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDmphieu));
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.butKetthuc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ten = new System.Windows.Forms.TextBox();
            this.butSua = new System.Windows.Forms.Button();
            this.butLuu = new System.Windows.Forms.Button();
            this.butBoqua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.stt = new System.Windows.Forms.NumericUpDown();
            this.kho = new System.Windows.Forms.CheckedListBox();
            this.nguon = new System.Windows.Forms.CheckedListBox();
            this.madoituong = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stt)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.AlternatingBackColor = System.Drawing.Color.Lavender;
            this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid1.CaptionBackColor = System.Drawing.SystemColors.Control;
            this.dataGrid1.CaptionFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid1.CaptionForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid1.DataMember = "";
            this.dataGrid1.FlatMode = true;
            this.dataGrid1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid1.GridLineColor = System.Drawing.Color.Gainsboro;
            this.dataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dataGrid1.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dataGrid1.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid1.LinkColor = System.Drawing.Color.Teal;
            this.dataGrid1.Location = new System.Drawing.Point(8, -13);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
            this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.RowHeaderWidth = 10;
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid1.Size = new System.Drawing.Size(568, 469);
            this.dataGrid1.TabIndex = 19;
            this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
            // 
            // butKetthuc
            // 
            this.butKetthuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butKetthuc.Image = ((System.Drawing.Image)(resources.GetObject("butKetthuc.Image")));
            this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butKetthuc.Location = new System.Drawing.Point(397, 489);
            this.butKetthuc.Name = "butKetthuc";
            this.butKetthuc.Size = new System.Drawing.Size(76, 25);
            this.butKetthuc.TabIndex = 7;
            this.butKetthuc.Text = "     &Kết thúc";
            this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Location = new System.Drawing.Point(88, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nội dung :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ten
            // 
            this.ten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ten.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ten.Enabled = false;
            this.ten.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten.Location = new System.Drawing.Point(144, 462);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(640, 21);
            this.ten.TabIndex = 1;
            this.ten.Validated += new System.EventHandler(this.ten_Validated);
            this.ten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ten_KeyDown);
            // 
            // butSua
            // 
            this.butSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butSua.Image = ((System.Drawing.Image)(resources.GetObject("butSua.Image")));
            this.butSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butSua.Location = new System.Drawing.Point(213, 489);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(60, 25);
            this.butSua.TabIndex = 5;
            this.butSua.Text = "    &Sửa";
            this.butSua.Click += new System.EventHandler(this.butSua_Click);
            // 
            // butLuu
            // 
            this.butLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butLuu.Enabled = false;
            this.butLuu.Image = ((System.Drawing.Image)(resources.GetObject("butLuu.Image")));
            this.butLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butLuu.Location = new System.Drawing.Point(273, 489);
            this.butLuu.Name = "butLuu";
            this.butLuu.Size = new System.Drawing.Size(60, 25);
            this.butLuu.TabIndex = 2;
            this.butLuu.Text = "    &Lưu";
            this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
            // 
            // butBoqua
            // 
            this.butBoqua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butBoqua.Enabled = false;
            this.butBoqua.Image = ((System.Drawing.Image)(resources.GetObject("butBoqua.Image")));
            this.butBoqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butBoqua.Location = new System.Drawing.Point(333, 489);
            this.butBoqua.Name = "butBoqua";
            this.butBoqua.Size = new System.Drawing.Size(64, 25);
            this.butBoqua.TabIndex = 3;
            this.butBoqua.Text = "     &Bỏ qua";
            this.butBoqua.Click += new System.EventHandler(this.butBoqua_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Location = new System.Drawing.Point(-3, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "STT :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stt
            // 
            this.stt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stt.Enabled = false;
            this.stt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stt.Location = new System.Drawing.Point(40, 462);
            this.stt.Name = "stt";
            this.stt.Size = new System.Drawing.Size(40, 21);
            this.stt.TabIndex = 0;
            this.stt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stt_KeyDown);
            // 
            // kho
            // 
            this.kho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kho.CheckOnClick = true;
            this.kho.Enabled = false;
            this.kho.Location = new System.Drawing.Point(584, 5);
            this.kho.Name = "kho";
            this.kho.Size = new System.Drawing.Size(200, 154);
            this.kho.TabIndex = 29;
            // 
            // nguon
            // 
            this.nguon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nguon.CheckOnClick = true;
            this.nguon.Enabled = false;
            this.nguon.Location = new System.Drawing.Point(584, 161);
            this.nguon.Name = "nguon";
            this.nguon.Size = new System.Drawing.Size(200, 199);
            this.nguon.TabIndex = 30;
            // 
            // madoituong
            // 
            this.madoituong.CheckOnClick = true;
            this.madoituong.Enabled = false;
            this.madoituong.Location = new System.Drawing.Point(584, 363);
            this.madoituong.Name = "madoituong";
            this.madoituong.Size = new System.Drawing.Size(200, 94);
            this.madoituong.TabIndex = 31;
            this.madoituong.Visible = false;
            // 
            // frmDmphieu
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(792, 523);
            this.Controls.Add(this.madoituong);
            this.Controls.Add(this.nguon);
            this.Controls.Add(this.kho);
            this.Controls.Add(this.stt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.butBoqua);
            this.Controls.Add(this.butLuu);
            this.Controls.Add(this.butSua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butKetthuc);
            this.Controls.Add(this.dataGrid1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDmphieu";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhóm phiếu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDmphieu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDmphieu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        string sUserMedi = "",dbLink="";
		private void frmDmphieu_Load(object sender, System.EventArgs e)
		{
            if (Screen.PrimaryScreen.WorkingArea.Width > 800) this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            user = ttb.user; itable = ttb.tableid("","ttb_dmphieu");
            sUserMedi = ttb.UserMedi;
            dbLink = ttb.dbLink;
            dtdt = ttb.get_data("select * from " + sUserMedi + ".d_doituong" + dbLink + " order by madoituong").Tables[0];
            madoituong.DataSource = dtdt;
			madoituong.DisplayMember="DOITUONG";
			madoituong.ValueMember="MADOITUONG";
            dtnguon = ttb.get_data("select * from " + user + ".ttb_dmnguon where id<>0 order by id,stt").Tables[0];
            nguon.DataSource = dtnguon;
			nguon.DisplayMember="TEN";
			nguon.ValueMember="ID";
            string sql = "select * from " + user + ".ttb_dmkho order by id,stt";
            dtkho = ttb.get_data(sql).Tables[0];
            kho.DataSource = dtkho;
			kho.DisplayMember="TEN";
			kho.ValueMember="ID";
			load_grid();
			AddGridTableStyle();
			ref_text();
		}

		private void load_grid()
		{
			try
			{
                sql = "select * from " + user + ".ttb_dmphieu where id in(3,4)";
                sql += " order by stt";
                dt = ttb.get_data(sql).Tables[0];
				dataGrid1.DataSource=dt;
			}
			catch{}
		}

		private void AddGridTableStyle()
		{
			DataGridTableStyle ts =new DataGridTableStyle();
			ts.MappingName = dt.TableName;
			ts.AlternatingBackColor = Color.Beige;
			ts.BackColor = Color.GhostWhite;
			ts.ForeColor = Color.MidnightBlue;
			ts.GridLineColor = Color.RoyalBlue;
			ts.HeaderBackColor = Color.MidnightBlue;
			ts.HeaderForeColor = Color.Lavender;
			ts.SelectionBackColor = Color.Teal;
			ts.SelectionForeColor = Color.PaleGreen;
			ts.ReadOnly=false;
			ts.RowHeaderWidth=10;
						
			DataGridTextBoxColumn TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "stt";
			TextCol.HeaderText = "STT";
			TextCol.Width = 30;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "ten";
			TextCol.HeaderText = "Nội dung";
			TextCol.Width = 520;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "id";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "kho";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "nguon";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "manhom";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "madoituong";
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
            dataGrid1.TableStyles.Add(ts);
		}

		private void butKetthuc_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void ten_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");
		}

		private void ena_object(bool ena)
		{
			dataGrid1.Enabled=!ena;
			stt.Enabled=ena;
			ten.Enabled=ena;
			butSua.Enabled=!ena;
			butLuu.Enabled=ena;
			butBoqua.Enabled=ena;
			butKetthuc.Enabled=!ena;
			kho.Enabled=ena;
			nguon.Enabled=ena;
			madoituong.Enabled=ena;
		}

		private void butMoi_Click(object sender, System.EventArgs e)
		{
			try
			{
                stt.Value = decimal.Parse(ttb.get_data("select max(stt) from " + user + ".ttb_dmphieu where nhom=" + i_nhom).Tables[0].Rows[0][0].ToString()) + 1;
			}
			catch{stt.Value=1;}
			i_id=0;
			ten.Text="";
			for(int k=0;k<kho.Items.Count;k++) kho.SetItemCheckState(k,CheckState.Unchecked);
			for(int k=0;k<nguon.Items.Count;k++) nguon.SetItemCheckState(k,CheckState.Unchecked);
			for(int k=0;k<madoituong.Items.Count;k++) madoituong.SetItemCheckState(k,CheckState.Unchecked);
			ena_object(true);
			ten.Focus();
		}

		private void butSua_Click(object sender, System.EventArgs e)
		{
			if (dt.Rows.Count==0) return;
			i_id=int.Parse(dataGrid1[dataGrid1.CurrentCell.RowNumber,2].ToString());
			ena_object(true);
			ten.Focus();
		}

		private bool kiemtra()
		{
			if (ten.Text=="")
			{
				ten.Focus();
				return false;
			}
			s_kho="";
			for(int i=0;i<kho.Items.Count;i++)
				if (kho.GetItemChecked(i)) s_kho+=dtkho.Rows[i]["id"].ToString().Trim()+",";
			if (s_kho=="")
			{
				MessageBox.Show("Yêu cầu chọn kho !",ttb.Msg);
				kho.Focus();
				return false;
			}
			s_nguon="";
			for(int i=0;i<nguon.Items.Count;i++)
				if (nguon.GetItemChecked(i)) s_nguon+=dtnguon.Rows[i]["id"].ToString().Trim()+",";
			s_madoituong="";
			for(int i=0;i<madoituong.Items.Count;i++)
				if (madoituong.GetItemChecked(i)) s_madoituong+=dtdt.Rows[i]["madoituong"].ToString().Trim()+",";
			return true;
		}

		private void butLuu_Click(object sender, System.EventArgs e)
		{
			if (!kiemtra()) return ;
            if (i_id == 0)
            {
                try
                {
                    i_id = int.Parse(ttb.get_data("select max(id) from " + user + ".ttb_dmphieu").Tables[0].Rows[0][0].ToString()) + 1;
                }
                catch { i_id = 1; }
                ttb.upd_eve_tables(itable, i_userid, "ins");
            }
            else
            {
                ttb.upd_eve_tables(itable, i_userid, "upd");
                ttb.upd_eve_upd_del(itable, i_userid, "upd", ttb.fields(user + ".ttb_dmphieu", "id=" + i_id));
            }
			if (!ttb.upd_dmphieu(i_id,ten.Text,i_nhom,int.Parse(stt.Value.ToString()),s_kho,s_nguon,s_madoituong))
			{
				MessageBox.Show("Không cập nhật thông tin "+this.Text.Trim()+" !",ttb.Msg);
				return;
			}
            load_grid();
			ena_object(false);
			ref_text();
		}

		private void butBoqua_Click(object sender, System.EventArgs e)
		{
			ref_text();
			ena_object(false);
		}

		private void butHuy_Click(object sender, System.EventArgs e)
		{
			if (dt.Rows.Count==1)
			{
				MessageBox.Show("Không cho phép hủy ?",ttb.Msg);
				return;
			}	
			try
			{
				if (decimal.Parse(dataGrid1[dataGrid1.CurrentCell.RowNumber,2].ToString())<7)
				{
					MessageBox.Show("Nội dung đang sử dụng không cho phép hủy !",ttb.Msg);
					return;
				}
			}
			catch{}
			if (MessageBox.Show("Đồng ý hủy thông tin này !",ttb.Msg,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
			{
                i_id = int.Parse(dataGrid1[dataGrid1.CurrentCell.RowNumber, 2].ToString());
                ttb.upd_eve_tables(itable, i_userid, "del");
                ttb.upd_eve_upd_del(itable, i_userid, "del", ttb.fields(user + ".ttb_dmphieu" , "id=" + i_id));
                ttb.execute_data("delete from " + user + ".ttb_dmphieu where id=" + i_id);
				load_grid();
			}
		}

		private void ref_text()
		{
			try
			{
				int i=dataGrid1.CurrentCell.RowNumber;
				stt.Value=decimal.Parse(dataGrid1[i,0].ToString());
				ten.Text=dataGrid1[i,1].ToString();
				i_id=int.Parse(dataGrid1[i,2].ToString());
				s_kho=","+dataGrid1[i,3].ToString();
				for(int j=0;j<dtkho.Rows.Count;j++)
					if (s_kho.IndexOf(","+dtkho.Rows[j]["id"].ToString().Trim()+",")!=-1) kho.SetItemCheckState(j,CheckState.Checked);
					else kho.SetItemCheckState(j,CheckState.Unchecked);
				s_nguon=","+dataGrid1[i,4].ToString();
				for(int j=0;j<dtnguon.Rows.Count;j++)
					if (s_nguon.IndexOf(","+dtnguon.Rows[j]["id"].ToString().Trim()+",")!=-1) nguon.SetItemCheckState(j,CheckState.Checked);
					else nguon.SetItemCheckState(j,CheckState.Unchecked);
				s_madoituong=","+dataGrid1[i,6].ToString();
				for(int j=0;j<dtdt.Rows.Count;j++)
					if (s_madoituong.IndexOf(","+dtdt.Rows[j]["madoituong"].ToString().Trim()+",")!=-1) madoituong.SetItemCheckState(j,CheckState.Checked);
					else madoituong.SetItemCheckState(j,CheckState.Unchecked);
			}
			catch{}
		}

		private void dataGrid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			ref_text();
		}

		private void frmDmphieu_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.F10) butKetthuc_Click(sender,e);
		}

		private void stt_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) SendKeys.Send("{Tab}");		
		}

		private void ten_Validated(object sender, System.EventArgs e)
		{
			if (i_id==0 && ten.Text!="")
			{
				DataRow r1=ttb.getrowbyid(dt,"ten='"+ten.Text+"'");
				if (r1!=null)
				{
					MessageBox.Show("Nội dung đã nhập !",ttb.Msg);
					ten.Focus();
				}
			}
		}
	}
}
