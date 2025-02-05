using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Parcel : Form
    {
        /// <summary>
        /// 
        /// </summary>
        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parcel));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblDiscHdr = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SaleDataGrid = new System.Windows.Forms.DataGridView();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.CbQuantity = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.cmdCustomerList = new System.Windows.Forms.Button();
            this.cmdMenu = new System.Windows.Forms.Button();
            this.cmdSaleReturn = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.lblRefund = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.cmdReturn = new System.Windows.Forms.Button();
            this.lblCustID = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.lblSequence = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.lblSaleType = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.cmdDiscount = new System.Windows.Forms.Button();
            this.cmdSuspend = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.SaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RecordDataSet = new System.Data.DataSet();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.cmdNew = new System.Windows.Forms.Button();
            this.lblOrgPrice = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.cmdViewSale = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHold = new System.Windows.Forms.Label();
            this.lblNum2Word = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaleDataGrid)).BeginInit();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).BeginInit();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Gray;
            this.Panel1.Controls.Add(this.lblUserRole);
            this.Panel1.Controls.Add(this.lblMode);
            this.Panel1.Controls.Add(this.Label14);
            this.Panel1.Controls.Add(this.lblCustomer);
            this.Panel1.Controls.Add(this.lblUserID);
            this.Panel1.Controls.Add(this.lblDate);
            this.Panel1.Controls.Add(this.lblUserName);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1264, 137);
            this.Panel1.TabIndex = 0;
            // 
            // lblUserRole
            // 
            this.lblUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.ForeColor = System.Drawing.Color.White;
            this.lblUserRole.Location = new System.Drawing.Point(617, 11);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(174, 22);
            this.lblUserRole.TabIndex = 57;
            this.lblUserRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMode
            // 
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.White;
            this.lblMode.Location = new System.Drawing.Point(367, 108);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(127, 22);
            this.lblMode.TabIndex = 56;
            this.lblMode.Text = "Sale";
            this.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label14
            // 
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.ForeColor = System.Drawing.Color.White;
            this.Label14.Location = new System.Drawing.Point(192, 108);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(169, 22);
            this.Label14.TabIndex = 1;
            this.Label14.Text = "Current Mode";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomer
            // 
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.White;
            this.lblCustomer.Location = new System.Drawing.Point(367, 83);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(257, 22);
            this.lblCustomer.TabIndex = 9;
            this.lblCustomer.Text = "No Customer Selected";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserID
            // 
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.White;
            this.lblUserID.Location = new System.Drawing.Point(367, 59);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(257, 22);
            this.lblUserID.TabIndex = 8;
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(367, 35);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(257, 22);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(367, 11);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(257, 22);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(192, 86);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(149, 22);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "Customer Account ID";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(192, 58);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(124, 22);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "Cash Drawer ID";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(192, 35);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(178, 22);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Cash Drawer Allocated";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(192, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(124, 22);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Logged on User";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.DimGray;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel2.Controls.Add(this.lblDiscount);
            this.Panel2.Controls.Add(this.lblDiscHdr);
            this.Panel2.Controls.Add(this.lblTotalPrice);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Location = new System.Drawing.Point(797, 17);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(435, 104);
            this.Panel2.TabIndex = 1;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDiscount.Location = new System.Drawing.Point(81, 13);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(103, 22);
            this.lblDiscount.TabIndex = 54;
            this.lblDiscount.Text = "0.00";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDiscount.Visible = false;
            // 
            // lblDiscHdr
            // 
            this.lblDiscHdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscHdr.ForeColor = System.Drawing.Color.White;
            this.lblDiscHdr.Location = new System.Drawing.Point(7, 12);
            this.lblDiscHdr.Name = "lblDiscHdr";
            this.lblDiscHdr.Size = new System.Drawing.Size(75, 22);
            this.lblDiscHdr.TabIndex = 53;
            this.lblDiscHdr.Text = "Discount.";
            this.lblDiscHdr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDiscHdr.Visible = false;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTotalPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalPrice.Location = new System.Drawing.Point(103, 37);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(329, 63);
            this.lblTotalPrice.TabIndex = 1;
            this.lblTotalPrice.Text = "0";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalPrice.Validating += new System.ComponentModel.CancelEventHandler(this.lblTotalPrice_Validating);
            this.lblTotalPrice.Validated += new System.EventHandler(this.lblTotalPrice_Validated);
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.Label1.Location = new System.Drawing.Point(260, 7);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(165, 32);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Sale Total";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImage = global::POS_System.My.Resources.Resources.cashbox_1281;
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox1.Location = new System.Drawing.Point(12, 10);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(155, 116);
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Location = new System.Drawing.Point(22, 139);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.SaleDataGrid);
            this.SplitContainer1.Panel1.Enabled = false;
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.Panel3);
            this.SplitContainer1.Size = new System.Drawing.Size(1242, 450);
            this.SplitContainer1.SplitterDistance = 590;
            this.SplitContainer1.TabIndex = 998;
            this.SplitContainer1.TabStop = false;
            // 
            // SaleDataGrid
            // 
            this.SaleDataGrid.AllowUserToAddRows = false;
            this.SaleDataGrid.AllowUserToDeleteRows = false;
            this.SaleDataGrid.AllowUserToResizeColumns = false;
            this.SaleDataGrid.AllowUserToResizeRows = false;
            this.SaleDataGrid.BackgroundColor = System.Drawing.Color.Gray;
            this.SaleDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SaleDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SaleDataGrid.ColumnHeadersHeight = 28;
            this.SaleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SaleDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDescription,
            this.colPrice,
            this.colQuantity,
            this.colSubTotal,
            this.colCode,
            this.colUnit});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SaleDataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.SaleDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaleDataGrid.EnableHeadersVisualStyles = false;
            this.SaleDataGrid.Location = new System.Drawing.Point(0, 0);
            this.SaleDataGrid.Name = "SaleDataGrid";
            this.SaleDataGrid.ReadOnly = true;
            this.SaleDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SaleDataGrid.Size = new System.Drawing.Size(590, 450);
            this.SaleDataGrid.TabIndex = 999;
            this.SaleDataGrid.TabStop = false;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "STOCKDESC";
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Width = 246;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "UnitCost";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "QTY";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colQuantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.colQuantity.HeaderText = "Qty";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colSubTotal
            // 
            this.colSubTotal.DataPropertyName = "PRICE";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSubTotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.colSubTotal.HeaderText = "Sub Total";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            // 
            // colCode
            // 
            this.colCode.HeaderText = "Code";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            this.colCode.Visible = false;
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            this.colUnit.Visible = false;
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.label23);
            this.Panel3.Controls.Add(this.label16);
            this.Panel3.Controls.Add(this.CbQuantity);
            this.Panel3.Controls.Add(this.label10);
            this.Panel3.Controls.Add(this.txtCustomerName);
            this.Panel3.Controls.Add(this.cmdCustomerList);
            this.Panel3.Controls.Add(this.cmdMenu);
            this.Panel3.Controls.Add(this.cmdSaleReturn);
            this.Panel3.Controls.Add(this.cmdSave);
            this.Panel3.Controls.Add(this.Label7);
            this.Panel3.Controls.Add(this.cmdSearch);
            this.Panel3.Controls.Add(this.Label6);
            this.Panel3.Controls.Add(this.txtCode);
            this.Panel3.Controls.Add(this.Label20);
            this.Panel3.Controls.Add(this.cmdDelete);
            this.Panel3.Controls.Add(this.lblRefund);
            this.Panel3.Controls.Add(this.Label12);
            this.Panel3.Controls.Add(this.Label8);
            this.Panel3.Controls.Add(this.txtPaid);
            this.Panel3.Controls.Add(this.Label17);
            this.Panel3.Controls.Add(this.cmdReturn);
            this.Panel3.Controls.Add(this.lblCustID);
            this.Panel3.Controls.Add(this.Label15);
            this.Panel3.Controls.Add(this.lblSequence);
            this.Panel3.Controls.Add(this.Label13);
            this.Panel3.Controls.Add(this.lblInvoice);
            this.Panel3.Controls.Add(this.Label11);
            this.Panel3.Controls.Add(this.lblSaleType);
            this.Panel3.Controls.Add(this.Label9);
            this.Panel3.Controls.Add(this.cmdPrint);
            this.Panel3.Controls.Add(this.cmdDiscount);
            this.Panel3.Controls.Add(this.cmdSuspend);
            this.Panel3.Controls.Add(this.txtQty);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel3.Location = new System.Drawing.Point(0, 0);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(648, 450);
            this.Panel3.TabIndex = 0;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(178, 315);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 22);
            this.label23.TabIndex = 64;
            this.label23.Text = "Kg / Piece";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(264, 285);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 22);
            this.label16.TabIndex = 63;
            this.label16.Text = "Select Qty";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CbQuantity
            // 
            this.CbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbQuantity.FormattingEnabled = true;
            this.CbQuantity.Items.AddRange(new object[] {
            "0.125",
            "0.250",
            "0.500",
            "0.750",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.CbQuantity.Location = new System.Drawing.Point(267, 312);
            this.CbQuantity.Name = "CbQuantity";
            this.CbQuantity.Size = new System.Drawing.Size(143, 28);
            this.CbQuantity.TabIndex = 9;
            this.CbQuantity.SelectedIndexChanged += new System.EventHandler(this.CbQuantity_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(229, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 22);
            this.label10.TabIndex = 61;
            this.label10.Text = "( Press F2 for Customers )";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(46, 171);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(321, 29);
            this.txtCustomerName.TabIndex = 4;
            this.txtCustomerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerName_KeyDown);
            this.txtCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerName_KeyPress);
            this.txtCustomerName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCustomerName_KeyUp);
            this.txtCustomerName.LostFocus += new System.EventHandler(this.txtCustomerName_LostFocus);
            // 
            // cmdCustomerList
            // 
            this.cmdCustomerList.BackColor = System.Drawing.Color.Gray;
            this.cmdCustomerList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdCustomerList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCustomerList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdCustomerList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.cmdCustomerList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmdCustomerList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCustomerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCustomerList.ForeColor = System.Drawing.Color.Yellow;
            this.cmdCustomerList.Image = global::POS_System.My.Resources.Resources.search13;
            this.cmdCustomerList.Location = new System.Drawing.Point(373, 168);
            this.cmdCustomerList.Name = "cmdCustomerList";
            this.cmdCustomerList.Size = new System.Drawing.Size(37, 35);
            this.cmdCustomerList.TabIndex = 5;
            this.cmdCustomerList.TabStop = false;
            this.cmdCustomerList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdCustomerList.UseVisualStyleBackColor = false;
            this.cmdCustomerList.Click += new System.EventHandler(this.cmdCustomerList_Click);
            // 
            // cmdMenu
            // 
            this.cmdMenu.BackColor = System.Drawing.Color.DimGray;
            this.cmdMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMenu.ForeColor = System.Drawing.Color.White;
            this.cmdMenu.Location = new System.Drawing.Point(477, 35);
            this.cmdMenu.Name = "cmdMenu";
            this.cmdMenu.Size = new System.Drawing.Size(138, 42);
            this.cmdMenu.TabIndex = 12;
            this.cmdMenu.Text = "&Food Menu (F4)";
            this.cmdMenu.UseVisualStyleBackColor = false;
            this.cmdMenu.Click += new System.EventHandler(this.cmdMenu_Click);
            // 
            // cmdSaleReturn
            // 
            this.cmdSaleReturn.BackColor = System.Drawing.Color.DimGray;
            this.cmdSaleReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSaleReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSaleReturn.ForeColor = System.Drawing.Color.White;
            this.cmdSaleReturn.Location = new System.Drawing.Point(477, 323);
            this.cmdSaleReturn.Name = "cmdSaleReturn";
            this.cmdSaleReturn.Size = new System.Drawing.Size(138, 42);
            this.cmdSaleReturn.TabIndex = 18;
            this.cmdSaleReturn.Text = "Sa&le Return (F10)";
            this.cmdSaleReturn.UseVisualStyleBackColor = false;
            this.cmdSaleReturn.Click += new System.EventHandler(this.cmdSaleReturn_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.BackColor = System.Drawing.Color.DimGray;
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.ForeColor = System.Drawing.Color.White;
            this.cmdSave.Location = new System.Drawing.Point(478, 371);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(138, 42);
            this.cmdSave.TabIndex = 19;
            this.cmdSave.Text = "&Save Sale (F12)";
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // Label7
            // 
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(229, 214);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(138, 22);
            this.Label7.TabIndex = 58;
            this.Label7.Text = "( Press F2 for Items List )";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdSearch
            // 
            this.cmdSearch.BackColor = System.Drawing.Color.Gray;
            this.cmdSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.cmdSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSearch.ForeColor = System.Drawing.Color.Yellow;
            this.cmdSearch.Image = global::POS_System.My.Resources.Resources.search13;
            this.cmdSearch.Location = new System.Drawing.Point(373, 239);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(37, 35);
            this.cmdSearch.TabIndex = 7;
            this.cmdSearch.TabStop = false;
            this.cmdSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdSearch.UseVisualStyleBackColor = false;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // Label6
            // 
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(43, 214);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(169, 22);
            this.Label6.TabIndex = 59;
            this.Label6.Text = "Barcode / Stock Code";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(46, 239);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(321, 35);
            this.txtCode.TabIndex = 6;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            this.txtCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyUp);
            // 
            // Label20
            // 
            this.Label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.ForeColor = System.Drawing.Color.White;
            this.Label20.Location = new System.Drawing.Point(43, 283);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(76, 22);
            this.Label20.TabIndex = 54;
            this.Label20.Text = "Qty.";
            this.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdDelete
            // 
            this.cmdDelete.BackColor = System.Drawing.Color.DimGray;
            this.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.ForeColor = System.Drawing.Color.White;
            this.cmdDelete.Location = new System.Drawing.Point(477, 275);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(138, 42);
            this.cmdDelete.TabIndex = 17;
            this.cmdDelete.Text = "Re&move Item (F7)";
            this.cmdDelete.UseVisualStyleBackColor = false;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // lblRefund
            // 
            this.lblRefund.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefund.ForeColor = System.Drawing.Color.Yellow;
            this.lblRefund.Location = new System.Drawing.Point(267, 373);
            this.lblRefund.Name = "lblRefund";
            this.lblRefund.Size = new System.Drawing.Size(143, 35);
            this.lblRefund.TabIndex = 11;
            this.lblRefund.Text = "00";
            this.lblRefund.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label12
            // 
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.Color.White;
            this.Label12.Location = new System.Drawing.Point(264, 349);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(146, 22);
            this.Label12.TabIndex = 51;
            this.Label12.Text = "Refund";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label8
            // 
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(43, 349);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(138, 22);
            this.Label8.TabIndex = 49;
            this.Label8.Text = "Payment";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPaid
            // 
            this.txtPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaid.Enabled = false;
            this.txtPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaid.Location = new System.Drawing.Point(46, 373);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(129, 35);
            this.txtPaid.TabIndex = 10;
            this.txtPaid.Text = "00";
            this.txtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPaid.GotFocus += new System.EventHandler(this.txtPaid_GotFocus);
            this.txtPaid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaid_KeyDown);
            this.txtPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaid_KeyPress);
            // 
            // Label17
            // 
            this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.ForeColor = System.Drawing.Color.White;
            this.Label17.Location = new System.Drawing.Point(43, 149);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(169, 22);
            this.Label17.TabIndex = 47;
            this.Label17.Text = "Customer Name";
            this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdReturn
            // 
            this.cmdReturn.BackColor = System.Drawing.Color.DimGray;
            this.cmdReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReturn.ForeColor = System.Drawing.Color.White;
            this.cmdReturn.Location = new System.Drawing.Point(477, 227);
            this.cmdReturn.Name = "cmdReturn";
            this.cmdReturn.Size = new System.Drawing.Size(138, 42);
            this.cmdReturn.TabIndex = 16;
            this.cmdReturn.Text = "Ret&urn Item (F6)";
            this.cmdReturn.UseVisualStyleBackColor = false;
            this.cmdReturn.Click += new System.EventHandler(this.cmdReturn_Click);
            // 
            // lblCustID
            // 
            this.lblCustID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblCustID.Location = new System.Drawing.Point(218, 109);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(149, 30);
            this.lblCustID.TabIndex = 3;
            this.lblCustID.Text = "00";
            this.lblCustID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustID.DoubleClick += new System.EventHandler(this.lblCustID_DoubleClick);
            // 
            // Label15
            // 
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.ForeColor = System.Drawing.Color.White;
            this.Label15.Location = new System.Drawing.Point(215, 87);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(169, 22);
            this.Label15.TabIndex = 44;
            this.Label15.Text = "Customer ID";
            this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSequence
            // 
            this.lblSequence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSequence.ForeColor = System.Drawing.Color.Maroon;
            this.lblSequence.Location = new System.Drawing.Point(211, 46);
            this.lblSequence.Name = "lblSequence";
            this.lblSequence.Size = new System.Drawing.Size(156, 30);
            this.lblSequence.TabIndex = 1;
            this.lblSequence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label13
            // 
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.Color.White;
            this.Label13.Location = new System.Drawing.Point(212, 24);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(155, 22);
            this.Label13.TabIndex = 42;
            this.Label13.Text = "Sequence #";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInvoice
            // 
            this.lblInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice.ForeColor = System.Drawing.Color.Maroon;
            this.lblInvoice.Location = new System.Drawing.Point(46, 46);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(166, 30);
            this.lblInvoice.TabIndex = 0;
            this.lblInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label11
            // 
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.White;
            this.Label11.Location = new System.Drawing.Point(43, 24);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(169, 22);
            this.Label11.TabIndex = 40;
            this.Label11.Text = "Sale Invoice #";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSaleType
            // 
            this.lblSaleType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSaleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleType.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblSaleType.Location = new System.Drawing.Point(46, 109);
            this.lblSaleType.Name = "lblSaleType";
            this.lblSaleType.Size = new System.Drawing.Size(166, 30);
            this.lblSaleType.TabIndex = 2;
            this.lblSaleType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSaleType.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblSaleType_MouseClick);
            // 
            // Label9
            // 
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(43, 87);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(169, 22);
            this.Label9.TabIndex = 2;
            this.Label9.Text = "Sale Type";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdPrint
            // 
            this.cmdPrint.BackColor = System.Drawing.Color.DimGray;
            this.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPrint.ForeColor = System.Drawing.Color.White;
            this.cmdPrint.Location = new System.Drawing.Point(477, 179);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(138, 42);
            this.cmdPrint.TabIndex = 15;
            this.cmdPrint.Text = "&Print (F5)";
            this.cmdPrint.UseVisualStyleBackColor = false;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // cmdDiscount
            // 
            this.cmdDiscount.BackColor = System.Drawing.Color.DimGray;
            this.cmdDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDiscount.ForeColor = System.Drawing.Color.White;
            this.cmdDiscount.Location = new System.Drawing.Point(477, 83);
            this.cmdDiscount.Name = "cmdDiscount";
            this.cmdDiscount.Size = new System.Drawing.Size(138, 42);
            this.cmdDiscount.TabIndex = 13;
            this.cmdDiscount.Text = "&Discount";
            this.cmdDiscount.UseVisualStyleBackColor = false;
            this.cmdDiscount.Click += new System.EventHandler(this.cmdDiscount_Click);
            // 
            // cmdSuspend
            // 
            this.cmdSuspend.BackColor = System.Drawing.Color.DimGray;
            this.cmdSuspend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSuspend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSuspend.ForeColor = System.Drawing.Color.White;
            this.cmdSuspend.Location = new System.Drawing.Point(477, 131);
            this.cmdSuspend.Name = "cmdSuspend";
            this.cmdSuspend.Size = new System.Drawing.Size(138, 42);
            this.cmdSuspend.TabIndex = 14;
            this.cmdSuspend.Text = "&Hold (F3)";
            this.cmdSuspend.UseVisualStyleBackColor = false;
            this.cmdSuspend.Click += new System.EventHandler(this.cmdSuspend_Click);
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(46, 310);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(129, 29);
            this.txtQty.TabIndex = 8;
            this.txtQty.Text = "0";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            // 
            // SaleBindingSource
            // 
            this.SaleBindingSource.DataSource = this.RecordDataSet;
            this.SaleBindingSource.Position = 0;
            // 
            // RecordDataSet
            // 
            this.RecordDataSet.DataSetName = "RecordDataSet";
            // 
            // SplitContainer2
            // 
            this.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SplitContainer2.Location = new System.Drawing.Point(0, 595);
            this.SplitContainer2.Name = "SplitContainer2";
            // 
            // SplitContainer2.Panel1
            // 
            this.SplitContainer2.Panel1.Controls.Add(this.Label22);
            this.SplitContainer2.Panel1.Controls.Add(this.Label18);
            this.SplitContainer2.Panel1.Controls.Add(this.cmdNew);
            this.SplitContainer2.Panel1.Controls.Add(this.lblOrgPrice);
            this.SplitContainer2.Panel1.Controls.Add(this.Label21);
            this.SplitContainer2.Panel1.Controls.Add(this.lblTax);
            this.SplitContainer2.Panel1.Controls.Add(this.Label19);
            this.SplitContainer2.Panel1.Controls.Add(this.cmdViewSale);
            this.SplitContainer2.Panel1.Controls.Add(this.cmdExit);
            // 
            // SplitContainer2.Panel2
            // 
            this.SplitContainer2.Panel2.Controls.Add(this.GroupBox1);
            this.SplitContainer2.Panel2.Controls.Add(this.lblNum2Word);
            this.SplitContainer2.Size = new System.Drawing.Size(1264, 74);
            this.SplitContainer2.SplitterDistance = 613;
            this.SplitContainer2.TabIndex = 2;
            // 
            // Label22
            // 
            this.Label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label22.ForeColor = System.Drawing.Color.DarkRed;
            this.Label22.Location = new System.Drawing.Point(582, 41);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(22, 22);
            this.Label22.TabIndex = 54;
            this.Label22.Text = "/=";
            this.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label18
            // 
            this.Label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label18.ForeColor = System.Drawing.Color.DarkRed;
            this.Label18.Location = new System.Drawing.Point(582, 19);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(22, 22);
            this.Label18.TabIndex = 53;
            this.Label18.Text = "/=";
            this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdNew
            // 
            this.cmdNew.BackColor = System.Drawing.Color.DimGray;
            this.cmdNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNew.ForeColor = System.Drawing.Color.DarkKhaki;
            this.cmdNew.Location = new System.Drawing.Point(254, 22);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(133, 33);
            this.cmdNew.TabIndex = 0;
            this.cmdNew.Text = "Re&fresh (F11)";
            this.cmdNew.UseVisualStyleBackColor = false;
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // lblOrgPrice
            // 
            this.lblOrgPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrgPrice.ForeColor = System.Drawing.Color.DarkRed;
            this.lblOrgPrice.Location = new System.Drawing.Point(493, 41);
            this.lblOrgPrice.Name = "lblOrgPrice";
            this.lblOrgPrice.Size = new System.Drawing.Size(94, 22);
            this.lblOrgPrice.TabIndex = 52;
            this.lblOrgPrice.Text = "0.00";
            this.lblOrgPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label21
            // 
            this.Label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label21.ForeColor = System.Drawing.Color.White;
            this.Label21.Location = new System.Drawing.Point(419, 41);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(75, 22);
            this.Label21.TabIndex = 51;
            this.Label21.Text = "Amount :";
            this.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTax
            // 
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTax.Location = new System.Drawing.Point(490, 19);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(97, 22);
            this.lblTax.TabIndex = 50;
            this.lblTax.Text = "0.00";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label19
            // 
            this.Label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.ForeColor = System.Drawing.Color.White;
            this.Label19.Location = new System.Drawing.Point(412, 19);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(82, 22);
            this.Label19.TabIndex = 49;
            this.Label19.Text = "Services :";
            this.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdViewSale
            // 
            this.cmdViewSale.BackColor = System.Drawing.Color.DimGray;
            this.cmdViewSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdViewSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdViewSale.ForeColor = System.Drawing.Color.DarkKhaki;
            this.cmdViewSale.Image = global::POS_System.My.Resources.Resources.PrintHS;
            this.cmdViewSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdViewSale.Location = new System.Drawing.Point(115, 22);
            this.cmdViewSale.Name = "cmdViewSale";
            this.cmdViewSale.Size = new System.Drawing.Size(133, 33);
            this.cmdViewSale.TabIndex = 1;
            this.cmdViewSale.TabStop = false;
            this.cmdViewSale.Text = "&Request Slip";
            this.cmdViewSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdViewSale.UseVisualStyleBackColor = false;
            this.cmdViewSale.Click += new System.EventHandler(this.cmdViewSale_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.Color.DimGray;
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.ForeColor = System.Drawing.Color.DarkKhaki;
            this.cmdExit.Image = global::POS_System.My.Resources.Resources.remove3;
            this.cmdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExit.Location = new System.Drawing.Point(22, 22);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(87, 33);
            this.cmdExit.TabIndex = 2;
            this.cmdExit.Text = "Cl&ose";
            this.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lblHold);
            this.GroupBox1.Enabled = false;
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.Cyan;
            this.GroupBox1.Location = new System.Drawing.Point(478, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(137, 43);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Total Hold (F9)";
            this.GroupBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GroupBox1_MouseDoubleClick);
            // 
            // lblHold
            // 
            this.lblHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHold.ForeColor = System.Drawing.Color.White;
            this.lblHold.Location = new System.Drawing.Point(32, 19);
            this.lblHold.Name = "lblHold";
            this.lblHold.Size = new System.Drawing.Size(76, 16);
            this.lblHold.TabIndex = 0;
            this.lblHold.Text = "00";
            this.lblHold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHold.DoubleClick += new System.EventHandler(this.lblHold_DoubleClick);
            this.lblHold.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblHold_MouseDoubleClick);
            // 
            // lblNum2Word
            // 
            this.lblNum2Word.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2Word.ForeColor = System.Drawing.Color.Black;
            this.lblNum2Word.Location = new System.Drawing.Point(45, 6);
            this.lblNum2Word.Name = "lblNum2Word";
            this.lblNum2Word.Size = new System.Drawing.Size(416, 56);
            this.lblNum2Word.TabIndex = 6;
            this.lblNum2Word.Text = "Num2Word";
            this.lblNum2Word.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Parcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1264, 669);
            this.ControlBox = false;
            this.Controls.Add(this.SplitContainer1);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.SplitContainer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Parcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Sale Invoice";
            this.Load += new System.EventHandler(this.frmSale_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmSale_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmSale_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmSale_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmSale_MouseUp);
            this.Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SaleDataGrid)).EndInit();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordDataSet)).EndInit();
            this.SplitContainer2.Panel1.ResumeLayout(false);
            this.SplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).EndInit();
            this.SplitContainer2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        internal Panel Panel1;
        internal PictureBox PictureBox1;
        internal Panel Panel2;
        internal Label Label1;
        internal Label lblTotalPrice;
        internal SplitContainer SplitContainer1;
        internal SplitContainer SplitContainer2;
        internal DataGridView SaleDataGrid;
        internal Label Label5;
        internal Label Label4;
        internal Label Label3;
        internal Label Label2;
        internal Label lblCustomer;
        internal Label lblUserID;
        internal Label lblDate;
        internal Label lblUserName;
        internal Panel Panel3;
        internal Label lblCustID;
        internal Label Label15;
        internal Label lblSequence;
        internal Label Label13;
        internal Label lblInvoice;
        internal Label Label11;
        internal Label lblSaleType;
        internal Label Label9;
        internal Button cmdPrint;
        internal Button cmdDiscount;
        internal Button cmdSuspend;
        internal Label Label17;
        internal Button cmdViewSale;
        internal Label Label19;
        internal Label lblOrgPrice;
        internal Label Label21;
        internal Label lblTax;
        internal Label lblNum2Word;
        internal Label Label8;
        internal TextBox txtPaid;
        internal Label lblRefund;
        internal Label Label12;
        internal Button cmdNew;
        internal Button cmdExit;
        internal TextBox txtCustomerName;
        internal DataSet RecordDataSet;
        internal BindingSource SaleBindingSource;
        internal Button cmdReturn;
        internal Button cmdDelete;
        internal Label lblDiscount;
        internal Label lblDiscHdr;
        internal Label lblMode;
        internal Label Label14;
        internal Label Label20;
        internal TextBox txtQty;
        internal Label Label7;
        internal Button cmdSearch;
        internal Label Label6;
        internal TextBox txtCode;
        internal GroupBox GroupBox1;
        internal Label lblHold;
        internal Label Label22;
        internal Label Label18;
        internal Button cmdSave;
        internal Button cmdSaleReturn;
        internal Label lblUserRole;
        internal Label label10;
        internal Button cmdCustomerList;
        internal Button cmdMenu;
        private ComboBox CbQuantity;
        internal Label label16;
        internal Label label23;
        private DataGridViewTextBoxColumn colDescription;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colSubTotal;
        private DataGridViewTextBoxColumn colCode;
        private DataGridViewTextBoxColumn colUnit;
    }
}