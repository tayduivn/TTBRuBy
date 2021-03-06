﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using LibDuoc;

namespace Duoc
{
	/// <summary>
	/// Summary description for frmNhap.
	/// </summary>
	public class frmKbtonvayct : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox manguon;
		private LibList.List listDMBD;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label lTen;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox tenbd;
		private System.Windows.Forms.TextBox mabd;
		private MaskedBox.MaskedBox dang;
		private MaskedTextBox.MaskedTextBox soluong;
		private MaskedTextBox.MaskedTextBox sotien;
		private System.Windows.Forms.Button butMoi;
		private System.Windows.Forms.Button butSua;
		private System.Windows.Forms.Button butLuu;
		private System.Windows.Forms.Button butBoqua;
		private System.Windows.Forms.Button butHuy;
		private System.Windows.Forms.Button butIn;
		private System.Windows.Forms.Button butKetthuc;
		private string sql,format_sotien,format_dongia,format_soluong,format_giaban;
		private int i_nhom,i_makho,i_mabd,i_makp;
		private long l_id;
		private decimal d_soluong,d_sotien,d_slnhap,d_slxuat,d_giaban,d_soluongcu,d_dongia;
		private bool bGiaban,bGiaban_nguon;
		private AccessData d;
		private DataTable dtdmbd=new DataTable();
		private DataTable dt=new DataTable();
		private DataTable dtnguon=new DataTable();
		private System.Windows.Forms.Label ldvt;
		private DataRow r;
		private System.Windows.Forms.TextBox stt;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label24;
		private MaskedBox.MaskedBox handung;
		private System.Windows.Forms.TextBox tenhc;
		private System.Windows.Forms.Label lTenhc;
		private MaskedTextBox.MaskedTextBox giaban;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.ComboBox nhomcc;
		private frmMain parent;
		private MaskedTextBox.MaskedTextBox dongia;
		private System.Windows.Forms.Label label1;
		private MaskedTextBox.MaskedTextBox losx;
		private System.Windows.Forms.TextBox tim;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmKbtonvayct(AccessData acc,int makp,int nhom,int kho,string title,bool ban)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			d=acc;
			i_makp=makp;
			i_nhom=nhom;
			i_makho=kho;
			bGiaban=ban;
			this.Text="Tồn đầu "+title.Trim();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmKbtonvayct));
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.manguon = new System.Windows.Forms.ComboBox();
			this.nhomcc = new System.Windows.Forms.ComboBox();
			this.listDMBD = new LibList.List();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.label13 = new System.Windows.Forms.Label();
			this.lTen = new System.Windows.Forms.Label();
			this.ldvt = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.tenbd = new System.Windows.Forms.TextBox();
			this.mabd = new System.Windows.Forms.TextBox();
			this.dang = new MaskedBox.MaskedBox();
			this.soluong = new MaskedTextBox.MaskedTextBox();
			this.sotien = new MaskedTextBox.MaskedTextBox();
			this.butMoi = new System.Windows.Forms.Button();
			this.butSua = new System.Windows.Forms.Button();
			this.butLuu = new System.Windows.Forms.Button();
			this.butBoqua = new System.Windows.Forms.Button();
			this.butHuy = new System.Windows.Forms.Button();
			this.butIn = new System.Windows.Forms.Button();
			this.butKetthuc = new System.Windows.Forms.Button();
			this.stt = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.handung = new MaskedBox.MaskedBox();
			this.tenhc = new System.Windows.Forms.TextBox();
			this.lTenhc = new System.Windows.Forms.Label();
			this.giaban = new MaskedTextBox.MaskedTextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.dongia = new MaskedTextBox.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.losx = new MaskedTextBox.MaskedTextBox();
			this.tim = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(120, 438);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(48, 23);
			this.label9.TabIndex = 8;
			this.label9.Text = "Nguồn :";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(412, 438);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(96, 23);
			this.label10.TabIndex = 9;
			this.label10.Text = "Nhóm cung cấp :";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// manguon
			// 
			this.manguon.BackColor = System.Drawing.SystemColors.HighlightText;
			this.manguon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.manguon.Enabled = false;
			this.manguon.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.manguon.Location = new System.Drawing.Point(168, 438);
			this.manguon.Name = "manguon";
			this.manguon.Size = new System.Drawing.Size(248, 21);
			this.manguon.TabIndex = 5;
			this.manguon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.manguon_KeyDown);
			this.manguon.SelectedIndexChanged += new System.EventHandler(this.manguon_SelectedIndexChanged);
			// 
			// nhomcc
			// 
			this.nhomcc.BackColor = System.Drawing.SystemColors.HighlightText;
			this.nhomcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.nhomcc.Enabled = false;
			this.nhomcc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nhomcc.Location = new System.Drawing.Point(505, 438);
			this.nhomcc.Name = "nhomcc";
			this.nhomcc.Size = new System.Drawing.Size(280, 21);
			this.nhomcc.TabIndex = 6;
			this.nhomcc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nhomcc_KeyDown);
			// 
			// listDMBD
			// 
			this.listDMBD.ColumnCount = 0;
			this.listDMBD.Location = new System.Drawing.Point(376, 544);
			this.listDMBD.MatchBufferTimeOut = 1000;
			this.listDMBD.MatchEntryStyle = AsYetUnnamed.MatchEntryStyle.FirstLetterInsensitive;
			this.listDMBD.Name = "listDMBD";
			this.listDMBD.Size = new System.Drawing.Size(75, 17);
			this.listDMBD.TabIndex = 26;
			this.listDMBD.TextIndex = -1;
			this.listDMBD.TextMember = null;
			this.listDMBD.ValueIndex = -1;
			this.listDMBD.Visible = false;
			this.listDMBD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listDMBD_KeyDown);
			// 
			// dataGrid1
			// 
			this.dataGrid1.AlternatingBackColor = System.Drawing.Color.Lavender;
			this.dataGrid1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGrid1.CaptionBackColor = System.Drawing.SystemColors.Control;
			this.dataGrid1.CaptionFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGrid1.CaptionForeColor = System.Drawing.Color.MidnightBlue;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.FlatMode = true;
			this.dataGrid1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGrid1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dataGrid1.GridLineColor = System.Drawing.Color.Gainsboro;
			this.dataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
			this.dataGrid1.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.dataGrid1.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
			this.dataGrid1.LinkColor = System.Drawing.Color.Teal;
			this.dataGrid1.Location = new System.Drawing.Point(8, 8);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
			this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.RowHeaderWidth = 10;
			this.dataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue;
			this.dataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
			this.dataGrid1.Size = new System.Drawing.Size(776, 400);
			this.dataGrid1.TabIndex = 0;
			this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(18, 415);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(32, 23);
			this.label13.TabIndex = 28;
			this.label13.Text = "Mã :";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lTen
			// 
			this.lTen.Location = new System.Drawing.Point(112, 415);
			this.lTen.Name = "lTen";
			this.lTen.Size = new System.Drawing.Size(56, 23);
			this.lTen.TabIndex = 29;
			this.lTen.Text = "Tên :";
			this.lTen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ldvt
			// 
			this.ldvt.Location = new System.Drawing.Point(16, 438);
			this.ldvt.Name = "ldvt";
			this.ldvt.Size = new System.Drawing.Size(34, 23);
			this.ldvt.TabIndex = 30;
			this.ldvt.Text = "ĐVT :";
			this.ldvt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(-4, 461);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(56, 23);
			this.label16.TabIndex = 31;
			this.label16.Text = "Số lượng :";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(272, 461);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(56, 23);
			this.label18.TabIndex = 33;
			this.label18.Text = "Số tiền :";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tenbd
			// 
			this.tenbd.BackColor = System.Drawing.SystemColors.HighlightText;
			this.tenbd.Enabled = false;
			this.tenbd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tenbd.Location = new System.Drawing.Point(168, 415);
			this.tenbd.Name = "tenbd";
			this.tenbd.Size = new System.Drawing.Size(272, 21);
			this.tenbd.TabIndex = 2;
			this.tenbd.Text = "";
			this.tenbd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tenbd_KeyDown);
			this.tenbd.Validated += new System.EventHandler(this.tenbd_Validated);
			this.tenbd.TextChanged += new System.EventHandler(this.tenbd_TextChanged);
			// 
			// mabd
			// 
			this.mabd.BackColor = System.Drawing.SystemColors.HighlightText;
			this.mabd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.mabd.Enabled = false;
			this.mabd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mabd.Location = new System.Drawing.Point(50, 415);
			this.mabd.Name = "mabd";
			this.mabd.Size = new System.Drawing.Size(71, 21);
			this.mabd.TabIndex = 1;
			this.mabd.Text = "";
			this.mabd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tenbd_KeyDown);
			this.mabd.Validated += new System.EventHandler(this.mabd_Validated);
			this.mabd.TextChanged += new System.EventHandler(this.mabd_TextChanged);
			// 
			// dang
			// 
			this.dang.BackColor = System.Drawing.SystemColors.HighlightText;
			this.dang.Enabled = false;
			this.dang.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dang.Location = new System.Drawing.Point(50, 438);
			this.dang.Mask = "";
			this.dang.MaxLength = 10;
			this.dang.Name = "dang";
			this.dang.Size = new System.Drawing.Size(71, 21);
			this.dang.TabIndex = 4;
			this.dang.Text = "";
			// 
			// soluong
			// 
			this.soluong.BackColor = System.Drawing.SystemColors.HighlightText;
			this.soluong.Enabled = false;
			this.soluong.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.soluong.Location = new System.Drawing.Point(50, 461);
			this.soluong.Masked = MaskedTextBox.MaskedTextBox.Mask.Decimal;
			this.soluong.Name = "soluong";
			this.soluong.Size = new System.Drawing.Size(71, 21);
			this.soluong.TabIndex = 7;
			this.soluong.Text = "";
			this.soluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.soluong.Validated += new System.EventHandler(this.soluong_Validated);
			// 
			// sotien
			// 
			this.sotien.BackColor = System.Drawing.SystemColors.HighlightText;
			this.sotien.Enabled = false;
			this.sotien.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.sotien.Location = new System.Drawing.Point(328, 461);
			this.sotien.Masked = MaskedTextBox.MaskedTextBox.Mask.Decimal;
			this.sotien.Name = "sotien";
			this.sotien.Size = new System.Drawing.Size(112, 21);
			this.sotien.TabIndex = 9;
			this.sotien.Text = "";
			this.sotien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.sotien.Validated += new System.EventHandler(this.sotien_Validated);
			// 
			// butMoi
			// 
			this.butMoi.Image = ((System.Drawing.Bitmap)(resources.GetObject("butMoi.Image")));
			this.butMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butMoi.Location = new System.Drawing.Point(128, 490);
			this.butMoi.Name = "butMoi";
			this.butMoi.Size = new System.Drawing.Size(75, 28);
			this.butMoi.TabIndex = 15;
			this.butMoi.Text = "      &Mới";
			this.butMoi.Click += new System.EventHandler(this.butMoi_Click);
			// 
			// butSua
			// 
			this.butSua.Image = ((System.Drawing.Bitmap)(resources.GetObject("butSua.Image")));
			this.butSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butSua.Location = new System.Drawing.Point(205, 490);
			this.butSua.Name = "butSua";
			this.butSua.Size = new System.Drawing.Size(75, 28);
			this.butSua.TabIndex = 16;
			this.butSua.Text = "     &Sửa";
			this.butSua.Click += new System.EventHandler(this.butSua_Click);
			// 
			// butLuu
			// 
			this.butLuu.Enabled = false;
			this.butLuu.Image = ((System.Drawing.Bitmap)(resources.GetObject("butLuu.Image")));
			this.butLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butLuu.Location = new System.Drawing.Point(282, 490);
			this.butLuu.Name = "butLuu";
			this.butLuu.Size = new System.Drawing.Size(75, 28);
			this.butLuu.TabIndex = 13;
			this.butLuu.Text = "     &Lưu";
			this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
			// 
			// butBoqua
			// 
			this.butBoqua.Enabled = false;
			this.butBoqua.Image = ((System.Drawing.Bitmap)(resources.GetObject("butBoqua.Image")));
			this.butBoqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butBoqua.Location = new System.Drawing.Point(359, 490);
			this.butBoqua.Name = "butBoqua";
			this.butBoqua.Size = new System.Drawing.Size(75, 28);
			this.butBoqua.TabIndex = 14;
			this.butBoqua.Text = "     &Bỏ qua";
			this.butBoqua.Click += new System.EventHandler(this.butBoqua_Click);
			// 
			// butHuy
			// 
			this.butHuy.Image = ((System.Drawing.Bitmap)(resources.GetObject("butHuy.Image")));
			this.butHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butHuy.Location = new System.Drawing.Point(436, 490);
			this.butHuy.Name = "butHuy";
			this.butHuy.Size = new System.Drawing.Size(75, 28);
			this.butHuy.TabIndex = 18;
			this.butHuy.Text = "     &Hủy";
			this.butHuy.Click += new System.EventHandler(this.butHuy_Click);
			// 
			// butIn
			// 
			this.butIn.Image = ((System.Drawing.Bitmap)(resources.GetObject("butIn.Image")));
			this.butIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butIn.Location = new System.Drawing.Point(513, 490);
			this.butIn.Name = "butIn";
			this.butIn.Size = new System.Drawing.Size(75, 28);
			this.butIn.TabIndex = 19;
			this.butIn.Text = "   &In";
			this.butIn.Click += new System.EventHandler(this.butIn_Click);
			// 
			// butKetthuc
			// 
			this.butKetthuc.Image = ((System.Drawing.Bitmap)(resources.GetObject("butKetthuc.Image")));
			this.butKetthuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.butKetthuc.Location = new System.Drawing.Point(590, 490);
			this.butKetthuc.Name = "butKetthuc";
			this.butKetthuc.Size = new System.Drawing.Size(75, 28);
			this.butKetthuc.TabIndex = 20;
			this.butKetthuc.Text = "&Kết thúc";
			this.butKetthuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.butKetthuc.Click += new System.EventHandler(this.butKetthuc_Click);
			// 
			// stt
			// 
			this.stt.Enabled = false;
			this.stt.Location = new System.Drawing.Point(64, 352);
			this.stt.Name = "stt";
			this.stt.Size = new System.Drawing.Size(40, 20);
			this.stt.TabIndex = 60;
			this.stt.Text = "";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(592, 461);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(61, 23);
			this.label15.TabIndex = 61;
			this.label15.Text = "Hạn dùng :";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(696, 461);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(24, 23);
			this.label24.TabIndex = 62;
			this.label24.Text = "Lô :";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// handung
			// 
			this.handung.BackColor = System.Drawing.SystemColors.HighlightText;
			this.handung.Enabled = false;
			this.handung.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.handung.Location = new System.Drawing.Point(656, 461);
			this.handung.Mask = "####";
			this.handung.Name = "handung";
			this.handung.Size = new System.Drawing.Size(39, 21);
			this.handung.TabIndex = 11;
			this.handung.Text = "";
			// 
			// tenhc
			// 
			this.tenhc.BackColor = System.Drawing.SystemColors.HighlightText;
			this.tenhc.Enabled = false;
			this.tenhc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tenhc.Location = new System.Drawing.Point(505, 415);
			this.tenhc.Name = "tenhc";
			this.tenhc.Size = new System.Drawing.Size(280, 21);
			this.tenhc.TabIndex = 3;
			this.tenhc.Text = "";
			// 
			// lTenhc
			// 
			this.lTenhc.Location = new System.Drawing.Point(446, 414);
			this.lTenhc.Name = "lTenhc";
			this.lTenhc.Size = new System.Drawing.Size(59, 23);
			this.lTenhc.TabIndex = 64;
			this.lTenhc.Text = "Hoạt chất :";
			this.lTenhc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// giaban
			// 
			this.giaban.BackColor = System.Drawing.SystemColors.HighlightText;
			this.giaban.Enabled = false;
			this.giaban.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.giaban.Location = new System.Drawing.Point(505, 461);
			this.giaban.Masked = MaskedTextBox.MaskedTextBox.Mask.Decimal;
			this.giaban.Name = "giaban";
			this.giaban.Size = new System.Drawing.Size(87, 21);
			this.giaban.TabIndex = 10;
			this.giaban.Text = "";
			this.giaban.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.giaban.Validated += new System.EventHandler(this.giaban_Validated);
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(452, 461);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(56, 23);
			this.label25.TabIndex = 66;
			this.label25.Text = "Giá bán :";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dongia
			// 
			this.dongia.BackColor = System.Drawing.SystemColors.HighlightText;
			this.dongia.Enabled = false;
			this.dongia.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dongia.Location = new System.Drawing.Point(168, 461);
			this.dongia.Masked = MaskedTextBox.MaskedTextBox.Mask.Decimal;
			this.dongia.Name = "dongia";
			this.dongia.Size = new System.Drawing.Size(112, 21);
			this.dongia.TabIndex = 8;
			this.dongia.Text = "";
			this.dongia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.dongia.Validated += new System.EventHandler(this.dongia_Validated);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(112, 461);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 69;
			this.label1.Text = "Đơn giá :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// losx
			// 
			this.losx.BackColor = System.Drawing.SystemColors.HighlightText;
			this.losx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.losx.Enabled = false;
			this.losx.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.losx.Location = new System.Drawing.Point(720, 461);
			this.losx.Masked = MaskedTextBox.MaskedTextBox.Mask.None;
			this.losx.MaxLength = 20;
			this.losx.Name = "losx";
			this.losx.Size = new System.Drawing.Size(64, 21);
			this.losx.TabIndex = 12;
			this.losx.Text = "";
			// 
			// tim
			// 
			this.tim.Location = new System.Drawing.Point(8, 3);
			this.tim.Name = "tim";
			this.tim.Size = new System.Drawing.Size(776, 20);
			this.tim.TabIndex = 70;
			this.tim.Text = "Tìm kiếm";
			this.tim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tim.TextChanged += new System.EventHandler(this.tim_TextChanged);
			this.tim.Enter += new System.EventHandler(this.tim_Enter);
			// 
			// frmKbtonvayct
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(792, 573);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.tim,
																		  this.losx,
																		  this.soluong,
																		  this.dongia,
																		  this.label1,
																		  this.mabd,
																		  this.sotien,
																		  this.giaban,
																		  this.label25,
																		  this.tenbd,
																		  this.tenhc,
																		  this.lTenhc,
																		  this.handung,
																		  this.label24,
																		  this.label15,
																		  this.dang,
																		  this.butKetthuc,
																		  this.butIn,
																		  this.butHuy,
																		  this.butBoqua,
																		  this.butLuu,
																		  this.butSua,
																		  this.butMoi,
																		  this.label18,
																		  this.label16,
																		  this.ldvt,
																		  this.lTen,
																		  this.label13,
																		  this.nhomcc,
																		  this.manguon,
																		  this.label10,
																		  this.label9,
																		  this.dataGrid1,
																		  this.listDMBD,
																		  this.stt});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmKbtonvayct";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tồn đầu";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmKbtonvayct_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmKbtonvayct_Load(object sender, System.EventArgs e)
		{
			format_sotien=d.format_sotien(i_nhom);
			format_dongia=d.format_dongia(i_nhom);
			format_soluong=d.format_soluong(i_nhom);
			bGiaban_nguon=d.bGiaban_nguon(i_nhom);
			format_giaban=d.format_giaban(i_nhom);
			manguon.DisplayMember="TEN";
			manguon.ValueMember="ID";
			if (d.bQuanlynguon(i_nhom))
				dtnguon=d.get_data("select * from d_dmnguon where nhom="+i_nhom+" order by stt").Tables[0];
			else
				dtnguon=d.get_data("select * from d_dmnguon where nhom=0 or nhom="+i_nhom+" order by stt").Tables[0];
			manguon.DataSource=dtnguon;
			nhomcc.DisplayMember="TEN";
			nhomcc.ValueMember="ID";
			if (d.bQuanlynhomcc(i_nhom))
				nhomcc.DataSource=d.get_data("select * from d_nhomcc where nhom="+i_nhom+" order by stt").Tables[0];
			else
				nhomcc.DataSource=d.get_data("select * from d_nhomcc where nhom=0 or nhom="+i_nhom+" order by stt").Tables[0];

			listDMBD.DisplayMember="TEN";
			listDMBD.ValueMember="MA";
			load_dm();
			
			load_grid();
			AddGridTableStyle();
			ref_text(0);
		}

		private void load_grid()
		{
			sql="select a.stt,a.manguon,a.nhomcc,c.ten tennguon,d.ten tennhomcc,b.ma,trim(b.ten)||' '||b.hamluong tenbd,b.tenhc,b.dang,a.handung,a.losx,a.tondau,a.tondau*a.giamua as sttondau,a.slvay slnhap,a.stvay stnhap,a.slquyettoan slxuat,a.stquyettoan stxuat,a.giaban,a.giamua dongia ";
			sql+=" from d_tonvayct a,d_dmbd b,d_dmnguon c,d_nhomcc d ";
			sql+=" where a.mabd=b.id and a.manguon=c.id and a.tondau<>0 and a.nhomcc=d.id and a.makho="+i_makho+" and a.makp="+i_makp+" order by a.stt";
			dt=d.get_data(sql).Tables[0];
			dataGrid1.DataSource=dt;
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
			TextCol.HeaderText = "";
			TextCol.Width = 0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tennguon";
			TextCol.HeaderText = "Nguồn";
			TextCol.Width = (d.bQuanlynguon(i_nhom))?80:0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tennhomcc";
			TextCol.HeaderText = "Nhóm cung cấp";
			TextCol.Width = (d.bQuanlynhomcc(i_nhom))?90:0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "ma";
			TextCol.HeaderText = "Mã số";
			TextCol.Width = 50;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tenbd";
			TextCol.HeaderText = "Tên";
			TextCol.Width = (d.bHoatchat || bGiaban || d.bQuanlyhandung(i_nhom) || d.bQuanlylosx(i_nhom) || d.bQuanlynguon(i_nhom)|| d.bQuanlynhomcc(i_nhom))?200:450;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tenhc";
			TextCol.HeaderText = "Hoạt chất";
			TextCol.Width = (d.bHoatchat)?200:0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "dang";
			TextCol.HeaderText = "ĐVT";
			TextCol.Width = 50;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "handung";
			TextCol.HeaderText = "Date";
			TextCol.Width = (d.bQuanlyhandung(i_nhom))?30:0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "losx";
			TextCol.HeaderText = "Lô SX";
			TextCol.Width = (d.bQuanlylosx(i_nhom))?50:0;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "tondau";
			TextCol.HeaderText = "Tồn đầu";
			TextCol.Width = 80;
			TextCol.Format=format_soluong;
			TextCol.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "dongia";
			TextCol.HeaderText = "Đơn giá";
			TextCol.Width = 100;
			TextCol.Format=format_dongia;
			TextCol.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "sttondau";
			TextCol.HeaderText = "Số tiền";
			TextCol.Width = 100;
			TextCol.Format=format_sotien;
			TextCol.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);

			TextCol=new DataGridTextBoxColumn();
			TextCol.MappingName = "giaban";
			TextCol.HeaderText = (bGiaban)?"Giá bán":"";
			TextCol.Width = (bGiaban)?100:0;
			TextCol.Format="###,###,###,##0";
			TextCol.Alignment=HorizontalAlignment.Right;
			ts.GridColumnStyles.Add(TextCol);
			dataGrid1.TableStyles.Add(ts);
		}

		private void ref_text(long id)
		{
			try
			{
				if (id==0)
				{
					int i=dataGrid1.CurrentCell.RowNumber;
					r=d.getrowbyid(dt,"stt="+long.Parse(dataGrid1[i,0].ToString()));
				}
				else r=d.getrowbyid(dt,"stt="+id);
				if (r!=null)
				{
					stt.Text=r["stt"].ToString();
					manguon.SelectedValue=r["manguon"].ToString();
					nhomcc.SelectedValue=r["nhomcc"].ToString();
					mabd.Text=r["ma"].ToString();
					tenbd.Text=r["tenbd"].ToString();
					tenhc.Text=r["tenhc"].ToString();
					dang.Text=r["dang"].ToString();
					handung.Text=r["handung"].ToString();
					losx.Text=r["losx"].ToString();
					d_soluong=(r["tondau"].ToString()!="")?decimal.Parse(r["tondau"].ToString()):0;
					d_dongia=(r["dongia"].ToString()!="")?decimal.Parse(r["dongia"].ToString()):0;
					d_sotien=(r["sttondau"].ToString()!="")?decimal.Parse(r["sttondau"].ToString()):0;
					d_giaban=(r["giaban"].ToString()!="")?decimal.Parse(r["giaban"].ToString()):0;
					d_slnhap=(r["slnhap"].ToString()!="")?decimal.Parse(r["slnhap"].ToString()):0;
					d_slxuat=(r["slxuat"].ToString()!="")?decimal.Parse(r["slxuat"].ToString()):0;
					soluong.Text=d_soluong.ToString(format_soluong);
					sotien.Text=d_sotien.ToString(format_sotien);
					giaban.Text=d_giaban.ToString(format_giaban);
					dongia.Text=d_dongia.ToString(format_dongia);
					l_id=long.Parse(stt.Text);
					d_soluongcu=d_soluong;
				}
			}
			catch{}
		}

		private void load_dm()
		{
			dtdmbd=d.get_data("select ma,trim(ten)||' '||hamluong ten,tenhc,dang,id from d_dmbd where nhom="+i_nhom+" order by ten").Tables[0];
			listDMBD.DataSource=dtdmbd;
		}

		private void butKetthuc_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void Filter_dmbd(string ten)
		{
			try
			{
				CurrencyManager cm= (CurrencyManager)BindingContext[listDMBD.DataSource];
				DataView dv=(DataView)cm.List;
				dv.RowFilter="ten like '%"+ten.Trim()+"%'"+" or tenhc like '%"+ten.Trim()+"%'";
			}
			catch{}
		}

		private void tenbd_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Down || e.KeyCode==Keys.Up) listDMBD.Focus();
			else if (e.KeyCode==Keys.Enter)
			{
				if (listDMBD.Visible) listDMBD.Focus();
				else SendKeys.Send("{Tab}");
			}
		}

		private void tenbd_TextChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==tenbd)
			{
				Filter_dmbd(tenbd.Text);
				if (manguon.Enabled)
					listDMBD.BrowseToDmbd(tenbd,mabd,manguon,mabd.Location.X,mabd.Location.Y + mabd.Height-2,mabd.Width+lTen.Width+tenbd.Width+lTenhc.Width+tenhc.Width,mabd.Height+5);
				else 
					listDMBD.BrowseToDmbd(tenbd,mabd,soluong,mabd.Location.X,mabd.Location.Y + mabd.Height-2,mabd.Width+lTen.Width+tenbd.Width+lTenhc.Width+tenhc.Width,mabd.Height+5);
			}
		}

		private void tenbd_Validated(object sender, System.EventArgs e)
		{
			if(!listDMBD.Focused) listDMBD.Hide();
			if (tenbd.Text!="" && mabd.Text=="")
			{
				r=d.getrowbyid(dtdmbd,"ten='"+tenbd.Text+"'");
				if (r!=null)
				{
					mabd.Text=r["ma"].ToString();
					dang.Text=r["dang"].ToString();
					tenhc.Text=r["tenhc"].ToString();
				}
			}
			SendKeys.Send("{F4}");
		}

		private void ena_object(bool ena)
		{
			dataGrid1.Enabled=!ena;
			if (d.bQuanlynguon(i_nhom)) manguon.Enabled=ena;
			else manguon.SelectedValue="0";
			if (d.bQuanlynhomcc(i_nhom)) nhomcc.Enabled=ena;
			else nhomcc.SelectedValue="0";
			if (d.bNhapmaso) mabd.Enabled=ena;
			tenbd.Enabled=ena;
			soluong.Enabled=ena;
			if (d.bQuanlyhandung(i_nhom)) handung.Enabled=ena;
			if (d.bQuanlylosx(i_nhom)) losx.Enabled=ena;
			if (d.bDongia(i_nhom)) dongia.Enabled=ena;
			else sotien.Enabled=ena;
			if (bGiaban_nguon) giaban.Enabled=ena;
			else if (bGiaban) giaban.Enabled=ena;
			if (bGiaban_nguon && ena && manguon.SelectedIndex!=-1)
				giaban.Enabled=dtnguon.Rows[manguon.SelectedIndex]["loai"].ToString()=="1";
			butMoi.Enabled=!ena;
			butSua.Enabled=!ena;
			butLuu.Enabled=ena;
			butBoqua.Enabled=ena;
			butHuy.Enabled=!ena;
			butIn.Enabled=!ena;
			butKetthuc.Enabled=!ena;
			if (d.bDanhmuc || d.bDmbd)
			{
				if (d.bDanhmuc) d.writeXml("d_thongso","c01","0");
				else d.writeXml("d_thongso","c06","0");
				load_dm();
			}
        }

		private void emp_detail()
		{
			l_id=0;
			mabd.Text="";
			tenbd.Text="";
			tenhc.Text="";
			dang.Text="";
			soluong.Text="";
			sotien.Text="";
			dongia.Text="";
			handung.Text="";
			losx.Text="";
			giaban.Text="0";
			stt.Text="";
			d_soluongcu=0;
			d_slnhap=0;
			d_slxuat=0;
		}

		private void butMoi_Click(object sender, System.EventArgs e)
		{
			ena_object(true);
			emp_detail();
			if (mabd.Enabled) mabd.Focus();
			else tenbd.Focus();
		}
		private void butSua_Click(object sender, System.EventArgs e)
		{
			if (dt.Rows.Count==0) return;
			l_id=long.Parse(stt.Text);
			ena_object(true);
			if (mabd.Enabled) mabd.Focus();
			else tenbd.Focus();
		}

		private bool KiemtraDetail()
		{
			i_mabd=0;
			if (mabd.Text=="" && tenbd.Text=="")
			{
				mabd.Focus();
				return false;
			}
			if ((mabd.Text=="" && tenbd.Text!="") || (mabd.Text!="" && tenbd.Text==""))
			{
				if (mabd.Text=="")
				{
					MessageBox.Show("Nhập mã số !",d.Msg);
					mabd.Focus();
					return false;
				}
				else if (tenbd.Text=="")
				{
					MessageBox.Show("Nhập tên !",d.Msg);
					tenbd.Focus();
					return false;
				}
			}
			r=d.getrowbyid(dtdmbd,"ma='"+mabd.Text+"'");
			if (r==null)
			{
				MessageBox.Show("Mã số không hợp lệ !",d.Msg);
				mabd.Focus();
				return false;
			}
			i_mabd=int.Parse(r["id"].ToString());
			if (soluong.Text=="" || soluong.Text=="0.00" || soluong.Text=="0")
			{
				MessageBox.Show("Nhập số lượng !",d.Msg);
				soluong.Focus();
				return false;
			}
			if (d.bQuanlynguon(i_nhom))
			{
				if (manguon.SelectedIndex==-1 || manguon.SelectedValue.ToString()=="0")
				{
					MessageBox.Show("Nguồn không hợp lệ !",d.Msg);
					manguon.Focus();
					return false;
				}
			}
			else manguon.SelectedValue="0";
			if (d.bQuanlynhomcc(i_nhom))
			{
				if (nhomcc.SelectedIndex==-1 || nhomcc.SelectedValue.ToString()=="0")
				{
					MessageBox.Show("Nhóm nhà cung cấp không hợp lệ !",d.Msg);
					nhomcc.Focus();
					return false;
				}
			}
			else nhomcc.SelectedValue="0";
			d_soluong=(soluong.Text!="")?decimal.Parse(soluong.Text):0;
			d_dongia=(dongia.Text!="")?decimal.Parse(dongia.Text):0;
			d_sotien=(sotien.Text!="")?decimal.Parse(sotien.Text):0;
			d_giaban=(giaban.Text!="")?decimal.Parse(giaban.Text):d_dongia;
			handung.Text=handung.Text.Trim().PadRight(4,'0');
			handung.Refresh();
			losx.Refresh();
			return true;
		}

		private void butLuu_Click(object sender, System.EventArgs e)
		{
			if (!KiemtraDetail()) return;
			bool bEdit=l_id!=0;
			l_id=(l_id==0)?d.get_id_tonkho:l_id;
			if (!d.upd_tonvayct(i_makp,i_makho,int.Parse(manguon.SelectedValue.ToString()),int.Parse(nhomcc.SelectedValue.ToString()),l_id,i_mabd,handung.Text,losx.Text,d_soluong,d_sotien,d_giaban,Math.Round(d_sotien/d_soluong,3)))
			{
				MessageBox.Show("Không cập nhật được thông tin tồn vay !",d.Msg);
				return;
			}
			d.upd_tonvayth(i_makp,i_makho,int.Parse(manguon.SelectedValue.ToString()),i_mabd,decimal.Parse(soluong.Text),"tondau");
			ena_object(false);
			load_grid();
			ref_text(0);
			butMoi.Focus();
		}

		private void butBoqua_Click(object sender, System.EventArgs e)
		{
			ena_object(false);
			butMoi.Focus();
		}

		private void manguon_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter || e.KeyCode==Keys.Tab)
			{
				if (manguon.SelectedIndex==-1) manguon.SelectedIndex=0;
				SendKeys.Send("{Tab}{F4}");
			}
		}

		private void mabd_Validated(object sender, System.EventArgs e)
		{
			if (mabd.Text!="")
			{
				r=d.getrowbyid(dtdmbd,"ma='"+mabd.Text+"'");
				if (r!=null) 
				{
					tenbd.Text=r["ten"].ToString();
					tenhc.Text=r["tenhc"].ToString();
					dang.Text=r["dang"].ToString();
				}
			}
		}

		private void listDMBD_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter) mabd_Validated(null,null);
		}

		private void dataGrid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			ref_text(0);
		}

		private void sotien_Validated(object sender, System.EventArgs e)
		{
			try
			{
				d_sotien=(sotien.Text!="")?decimal.Parse(sotien.Text):0;
				sotien.Text=d_sotien.ToString(format_sotien);
			}
			catch{}
			tinh_giatri();
		}

		private void soluong_Validated(object sender, System.EventArgs e)
		{
			try
			{
				d_soluong=(soluong.Text!="")?decimal.Parse(soluong.Text):0;
				soluong.Text=d_soluong.ToString(format_soluong);
				if (d_soluong+d_slnhap-d_slxuat<0)
				{
					MessageBox.Show("Số lượng không hợp lệ (Tồn kho sẽ bị âm) !",d.Msg);
					soluong.Text=d_soluongcu.ToString(format_soluong);
					soluong.Focus();
				}
			}
			catch{}
			tinh_giatri();
		}

		private void tinh_giatri()
		{
			try
			{
				d_soluong=(soluong.Text!="")?decimal.Parse(soluong.Text):0;
				if (d.bDongia(i_nhom))
				{
					d_dongia=(dongia.Text!="")?decimal.Parse(dongia.Text):0;
					d_sotien=Math.Round(d_soluong*d_dongia,3);
					sotien.Text=d_sotien.ToString(format_sotien);
				}
				else
				{	
					d_sotien=(sotien.Text!="")?decimal.Parse(sotien.Text):0;
					d_dongia=Math.Round(d_sotien/d_soluong,3);
					dongia.Text=d_dongia.ToString(format_dongia);
				}
				giaban.Text=d_dongia.ToString(format_giaban);
			}
			catch{}
		}

		private void butHuy_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (dt.Rows.Count==0) return;
				if (d_slnhap!=0 || d_slxuat!=0)
				{
					MessageBox.Show(tenbd.Text.Trim()+" "+dang.Text.Trim()+"\nĐã nhập/xuất không cho phép hủy !",d.Msg);
					return;
				}
				if (MessageBox.Show("Đồng ý hủy thông tin này ?",d.Msg,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
				{
					r=d.getrowbyid(dtdmbd,"ma='"+mabd.Text+"'");
					if (r!=null)
					{
						d.execute_data("delete from d_tonvayct where makho="+i_makho+" and stt="+l_id+" and makp="+i_makp);
						d.upd_tonvayth(d.delete,i_makp,i_makho,int.Parse(r["id"].ToString()),int.Parse(manguon.SelectedValue.ToString()),decimal.Parse(soluong.Text),"tondau");
						load_grid();
						ref_text(0);
					}
				}
			}
			catch{}
		}

		private void giaban_Validated(object sender, System.EventArgs e)
		{
			try
			{
				d_giaban=(giaban.Text!="")?decimal.Parse(giaban.Text):0;
				giaban.Text=d_giaban.ToString(format_giaban);
			}
			catch{giaban.Text="0";}
		}

		private void butIn_Click(object sender, System.EventArgs e)
		{
			string sql="select b.ma,trim(b.ten)||' '||b.hamluong ten,b.tenhc,b.dang,a.tondau,a.tondau*a.giamua as sttondau, c.stt, c.ten nhombd, a.manguon, d.ten tennguon "+
				" from d_tonvayct a,d_dmbd b,d_dmnhom c,d_dmnguon d "+
				" where a.mabd=b.id and b.manhom=c.id and a.manguon=d.id and a.tondau<>0 and a.makho="+i_makho+" and a.makp="+i_makp+" order by b.ten";
			DataTable ldt=d.get_data(sql).Tables[0];
			frmReport f=new frmReport(d,ldt,"d_tondau.rpt",this.Text.Trim().ToUpper(),"","","","","","","","","");
			f.ShowDialog();			
		}

		public void RefreshChildren(string text)
		{
			try
			{
				CurrencyManager cm= (CurrencyManager)BindingContext[dataGrid1.DataSource];
				DataView dv=(DataView)cm.List;
				dv.RowFilter="tenbd like '%"+text.Trim()+"%'"+" or tenhc like '%"+text.Trim()+"%' or ma like '%"+text.Trim()+"%'";
				if (text!="") ref_text(0);
				else ref_text(l_id);
			}
			catch{}
		}

		private void nhomcc_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter || e.KeyCode==Keys.Tab) SendKeys.Send("{Tab}");
		}

		private void mabd_TextChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==mabd)
			{
				Filter_mabd(mabd.Text);
				if (manguon.Enabled)
					listDMBD.BrowseToDmbd(mabd,tenbd,manguon,mabd.Location.X,mabd.Location.Y + mabd.Height-2,mabd.Width+lTen.Width+tenbd.Width+lTenhc.Width+tenhc.Width,mabd.Height+5);
				else 
					listDMBD.BrowseToDmbd(mabd,tenbd,soluong,mabd.Location.X,mabd.Location.Y + mabd.Height-2,mabd.Width+lTen.Width+tenbd.Width+lTenhc.Width+tenhc.Width,mabd.Height+5);
			}		
		}

		private void Filter_mabd(string ma)
		{
			try
			{
				CurrencyManager cm= (CurrencyManager)BindingContext[listDMBD.DataSource];
				DataView dv=(DataView)cm.List;
				dv.RowFilter="ma like '%"+ma.Trim()+"%'";
			}
			catch{}
		}

		private void dongia_Validated(object sender, System.EventArgs e)
		{
			try
			{
				d_dongia=(dongia.Text!="")?decimal.Parse(dongia.Text):0;
				dongia.Text=d_dongia.ToString(format_dongia);
			}
			catch{dongia.Text="0";}
			tinh_giatri();
		}

		private void manguon_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==manguon)
				if (bGiaban_nguon && butLuu.Enabled && manguon.SelectedIndex!=-1)
					giaban.Enabled=dtnguon.Rows[manguon.SelectedIndex]["loai"].ToString()=="1";
		}

		private void tim_Enter(object sender, System.EventArgs e)
		{
			tim.Text="";
		}

		private void tim_TextChanged(object sender, System.EventArgs e)
		{
			if (this.ActiveControl==tim) RefreshChildren(tim.Text);
		}
	}
}
