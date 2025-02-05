using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class DineTableMenu : Form
    {

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DineTableMenu));
            this.TabDine = new System.Windows.Forms.TabControl();
            this.tabReservation = new System.Windows.Forms.TabPage();
            this.cmdExit = new System.Windows.Forms.Button();
            this.H5 = new System.Windows.Forms.Button();
            this.H4 = new System.Windows.Forms.Button();
            this.H1 = new System.Windows.Forms.Button();
            this.H2 = new System.Windows.Forms.Button();
            this.H3 = new System.Windows.Forms.Button();
            this.P12 = new System.Windows.Forms.Button();
            this.P11 = new System.Windows.Forms.Button();
            this.P10 = new System.Windows.Forms.Button();
            this.P3 = new System.Windows.Forms.Button();
            this.P4 = new System.Windows.Forms.Button();
            this.P5 = new System.Windows.Forms.Button();
            this.P6 = new System.Windows.Forms.Button();
            this.P7 = new System.Windows.Forms.Button();
            this.P8 = new System.Windows.Forms.Button();
            this.P9 = new System.Windows.Forms.Button();
            this.P2 = new System.Windows.Forms.Button();
            this.P1 = new System.Windows.Forms.Button();
            this.B18 = new System.Windows.Forms.Button();
            this.B17 = new System.Windows.Forms.Button();
            this.B16 = new System.Windows.Forms.Button();
            this.B13 = new System.Windows.Forms.Button();
            this.B14 = new System.Windows.Forms.Button();
            this.B15 = new System.Windows.Forms.Button();
            this.B12 = new System.Windows.Forms.Button();
            this.B11 = new System.Windows.Forms.Button();
            this.B10 = new System.Windows.Forms.Button();
            this.B03 = new System.Windows.Forms.Button();
            this.B04 = new System.Windows.Forms.Button();
            this.B05 = new System.Windows.Forms.Button();
            this.B06 = new System.Windows.Forms.Button();
            this.B07 = new System.Windows.Forms.Button();
            this.B08 = new System.Windows.Forms.Button();
            this.B09 = new System.Windows.Forms.Button();
            this.B02 = new System.Windows.Forms.Button();
            this.B01 = new System.Windows.Forms.Button();
            this.tabCheckIn = new System.Windows.Forms.TabPage();
            this.Label20 = new System.Windows.Forms.Label();
            this.lblTaxes = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblWaiter = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.lblOrgPrice = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.SequenceNo = new System.Windows.Forms.Label();
            this.OrderNo = new System.Windows.Forms.Label();
            this.cmdWaiter = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.cmdChange = new System.Windows.Forms.Button();
            this.cmdVoid = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.cmdBack = new System.Windows.Forms.Button();
            this.Num0 = new System.Windows.Forms.Button();
            this.NumFriction = new System.Windows.Forms.Button();
            this.Num9 = new System.Windows.Forms.Button();
            this.Num8 = new System.Windows.Forms.Button();
            this.Num7 = new System.Windows.Forms.Button();
            this.Num6 = new System.Windows.Forms.Button();
            this.Num5 = new System.Windows.Forms.Button();
            this.Num4 = new System.Windows.Forms.Button();
            this.Num3 = new System.Windows.Forms.Button();
            this.Num2 = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.Button();
            this.ItemFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.GroupFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdSettle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCustomer = new System.Windows.Forms.Button();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.SaleDataGrid = new System.Windows.Forms.DataGridView();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RecordDataSet = new System.Data.DataSet();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdSelect = new System.Windows.Forms.Button();
            this.cmdNew = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabCheckOut = new System.Windows.Forms.TabPage();
            this.lblFinalOrderNo = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.cmdPaid = new System.Windows.Forms.Button();
            this.lblDue = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.cmdRefreshBill = new System.Windows.Forms.Button();
            this.cmdDiscount = new System.Windows.Forms.Button();
            this.cmdDiscPaid = new System.Windows.Forms.Button();
            this.cmdClearDisplay = new System.Windows.Forms.Button();
            this.cmdCloseBack = new System.Windows.Forms.Button();
            this.lblRefund = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.cmdBackSpace = new System.Windows.Forms.Button();
            this.D0 = new System.Windows.Forms.Button();
            this.D9 = new System.Windows.Forms.Button();
            this.D8 = new System.Windows.Forms.Button();
            this.D7 = new System.Windows.Forms.Button();
            this.D6 = new System.Windows.Forms.Button();
            this.D5 = new System.Windows.Forms.Button();
            this.D4 = new System.Windows.Forms.Button();
            this.D3 = new System.Windows.Forms.Button();
            this.D2 = new System.Windows.Forms.Button();
            this.D1 = new System.Windows.Forms.Button();
            this.cmdPrintBill = new System.Windows.Forms.Button();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.label99 = new System.Windows.Forms.Label();
            this.lblTotalBill = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.lblFinalDiscount = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.lblFinalCharges = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.lblFinalWaiter = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.lblFinalBill = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.lblFinalSequence = new System.Windows.Forms.Label();
            this.lblFinalCustomer = new System.Windows.Forms.Label();
            this.lblFinalStatus = new System.Windows.Forms.Label();
            this.lblFinalTable = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.dgvFinalBill = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FinalDataSet = new System.Data.DataSet();
            this.ShapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.LineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.LineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TabDine.SuspendLayout();
            this.tabReservation.SuspendLayout();
            this.tabCheckIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaleDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordDataSet)).BeginInit();
            this.tabCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.tabCheckOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TabDine
            // 
            this.TabDine.Controls.Add(this.tabReservation);
            this.TabDine.Controls.Add(this.tabCheckIn);
            this.TabDine.Controls.Add(this.tabCustomer);
            this.TabDine.Controls.Add(this.tabCheckOut);
            this.TabDine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabDine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabDine.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabDine.ItemSize = new System.Drawing.Size(146, 35);
            this.TabDine.Location = new System.Drawing.Point(0, 0);
            this.TabDine.Name = "TabDine";
            this.TabDine.SelectedIndex = 0;
            this.TabDine.Size = new System.Drawing.Size(1168, 669);
            this.TabDine.TabIndex = 0;
            this.TabDine.SelectedIndexChanged += new System.EventHandler(this.TabDine_SelectedIndexChanged);
            // 
            // tabReservation
            // 
            this.tabReservation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabReservation.Controls.Add(this.cmdExit);
            this.tabReservation.Controls.Add(this.H5);
            this.tabReservation.Controls.Add(this.H4);
            this.tabReservation.Controls.Add(this.H1);
            this.tabReservation.Controls.Add(this.H2);
            this.tabReservation.Controls.Add(this.H3);
            this.tabReservation.Controls.Add(this.P12);
            this.tabReservation.Controls.Add(this.P11);
            this.tabReservation.Controls.Add(this.P10);
            this.tabReservation.Controls.Add(this.P3);
            this.tabReservation.Controls.Add(this.P4);
            this.tabReservation.Controls.Add(this.P5);
            this.tabReservation.Controls.Add(this.P6);
            this.tabReservation.Controls.Add(this.P7);
            this.tabReservation.Controls.Add(this.P8);
            this.tabReservation.Controls.Add(this.P9);
            this.tabReservation.Controls.Add(this.P2);
            this.tabReservation.Controls.Add(this.P1);
            this.tabReservation.Controls.Add(this.B18);
            this.tabReservation.Controls.Add(this.B17);
            this.tabReservation.Controls.Add(this.B16);
            this.tabReservation.Controls.Add(this.B13);
            this.tabReservation.Controls.Add(this.B14);
            this.tabReservation.Controls.Add(this.B15);
            this.tabReservation.Controls.Add(this.B12);
            this.tabReservation.Controls.Add(this.B11);
            this.tabReservation.Controls.Add(this.B10);
            this.tabReservation.Controls.Add(this.B03);
            this.tabReservation.Controls.Add(this.B04);
            this.tabReservation.Controls.Add(this.B05);
            this.tabReservation.Controls.Add(this.B06);
            this.tabReservation.Controls.Add(this.B07);
            this.tabReservation.Controls.Add(this.B08);
            this.tabReservation.Controls.Add(this.B09);
            this.tabReservation.Controls.Add(this.B02);
            this.tabReservation.Controls.Add(this.B01);
            this.tabReservation.ForeColor = System.Drawing.Color.Black;
            this.tabReservation.ImageIndex = 6;
            this.tabReservation.Location = new System.Drawing.Point(4, 39);
            this.tabReservation.Name = "tabReservation";
            this.tabReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabReservation.Size = new System.Drawing.Size(1160, 626);
            this.tabReservation.TabIndex = 0;
            this.tabReservation.Text = "Order / Reservation";
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.Color.White;
            this.cmdExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExit.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Image = global::POS_System.My.Resources.Resources._1480381921_exit1;
            this.cmdExit.Location = new System.Drawing.Point(968, 521);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(186, 97);
            this.cmdExit.TabIndex = 35;
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // H5
            // 
            this.H5.BackColor = System.Drawing.Color.White;
            this.H5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.H5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.H5.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H5.Location = new System.Drawing.Point(775, 521);
            this.H5.Name = "H5";
            this.H5.Size = new System.Drawing.Size(186, 97);
            this.H5.TabIndex = 34;
            this.H5.Text = "H05";
            this.H5.UseVisualStyleBackColor = false;
            this.H5.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // H4
            // 
            this.H4.BackColor = System.Drawing.Color.White;
            this.H4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.H4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.H4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H4.Location = new System.Drawing.Point(583, 521);
            this.H4.Name = "H4";
            this.H4.Size = new System.Drawing.Size(186, 97);
            this.H4.TabIndex = 33;
            this.H4.Text = "H04";
            this.H4.UseVisualStyleBackColor = false;
            this.H4.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // H1
            // 
            this.H1.BackColor = System.Drawing.Color.White;
            this.H1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.H1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.H1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H1.Location = new System.Drawing.Point(8, 521);
            this.H1.Name = "H1";
            this.H1.Size = new System.Drawing.Size(186, 97);
            this.H1.TabIndex = 30;
            this.H1.Text = "H01";
            this.H1.UseVisualStyleBackColor = false;
            this.H1.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // H2
            // 
            this.H2.BackColor = System.Drawing.Color.White;
            this.H2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.H2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.H2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H2.Location = new System.Drawing.Point(199, 521);
            this.H2.Name = "H2";
            this.H2.Size = new System.Drawing.Size(186, 97);
            this.H2.TabIndex = 31;
            this.H2.Text = "H02";
            this.H2.UseVisualStyleBackColor = false;
            this.H2.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // H3
            // 
            this.H3.BackColor = System.Drawing.Color.White;
            this.H3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.H3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.H3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H3.Location = new System.Drawing.Point(391, 521);
            this.H3.Name = "H3";
            this.H3.Size = new System.Drawing.Size(186, 97);
            this.H3.TabIndex = 32;
            this.H3.Text = "H03";
            this.H3.UseVisualStyleBackColor = false;
            this.H3.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // P12
            // 
            this.P12.BackColor = System.Drawing.Color.White;
            this.P12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.P12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.P12.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P12.Location = new System.Drawing.Point(968, 418);
            this.P12.Name = "P12";
            this.P12.Size = new System.Drawing.Size(186, 97);
            this.P12.TabIndex = 29;
            this.P12.Text = "P12";
            this.P12.UseVisualStyleBackColor = false;
            this.P12.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // P11
            // 
            this.P11.BackColor = System.Drawing.Color.White;
            this.P11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.P11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.P11.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P11.Location = new System.Drawing.Point(775, 418);
            this.P11.Name = "P11";
            this.P11.Size = new System.Drawing.Size(186, 97);
            this.P11.TabIndex = 28;
            this.P11.Text = "P11";
            this.P11.UseVisualStyleBackColor = false;
            this.P11.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // P10
            // 
            this.P10.BackColor = System.Drawing.Color.White;
            this.P10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.P10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.P10.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P10.Location = new System.Drawing.Point(583, 418);
            this.P10.Name = "P10";
            this.P10.Size = new System.Drawing.Size(186, 97);
            this.P10.TabIndex = 27;
            this.P10.Text = "P10";
            this.P10.UseVisualStyleBackColor = false;
            this.P10.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // P3
            // 
            this.P3.BackColor = System.Drawing.Color.White;
            this.P3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.P3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.P3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P3.Location = new System.Drawing.Point(391, 315);
            this.P3.Name = "P3";
            this.P3.Size = new System.Drawing.Size(186, 97);
            this.P3.TabIndex = 20;
            this.P3.Text = "P03";
            this.P3.UseVisualStyleBackColor = false;
            this.P3.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // P4
            // 
            this.P4.BackColor = System.Drawing.Color.White;
            this.P4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.P4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.P4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P4.Location = new System.Drawing.Point(583, 315);
            this.P4.Name = "P4";
            this.P4.Size = new System.Drawing.Size(186, 97);
            this.P4.TabIndex = 21;
            this.P4.Text = "P04";
            this.P4.UseVisualStyleBackColor = false;
            this.P4.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // P5
            // 
            this.P5.BackColor = System.Drawing.Color.White;
            this.P5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.P5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.P5.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P5.Location = new System.Drawing.Point(775, 315);
            this.P5.Name = "P5";
            this.P5.Size = new System.Drawing.Size(186, 97);
            this.P5.TabIndex = 22;
            this.P5.Text = "P05";
            this.P5.UseVisualStyleBackColor = false;
            this.P5.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // P6
            // 
            this.P6.BackColor = System.Drawing.Color.White;
            this.P6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.P6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.P6.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P6.Location = new System.Drawing.Point(967, 315);
            this.P6.Name = "P6";
            this.P6.Size = new System.Drawing.Size(186, 97);
            this.P6.TabIndex = 23;
            this.P6.Text = "P06";
            this.P6.UseVisualStyleBackColor = false;
            this.P6.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // P7
            // 
            this.P7.BackColor = System.Drawing.Color.White;
            this.P7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.P7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.P7.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P7.Location = new System.Drawing.Point(8, 418);
            this.P7.Name = "P7";
            this.P7.Size = new System.Drawing.Size(186, 97);
            this.P7.TabIndex = 24;
            this.P7.Text = "P07";
            this.P7.UseVisualStyleBackColor = false;
            this.P7.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // P8
            // 
            this.P8.BackColor = System.Drawing.Color.White;
            this.P8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.P8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.P8.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P8.Location = new System.Drawing.Point(199, 418);
            this.P8.Name = "P8";
            this.P8.Size = new System.Drawing.Size(186, 97);
            this.P8.TabIndex = 25;
            this.P8.Text = "P08";
            this.P8.UseVisualStyleBackColor = false;
            this.P8.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // P9
            // 
            this.P9.BackColor = System.Drawing.Color.White;
            this.P9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.P9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.P9.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P9.Location = new System.Drawing.Point(391, 418);
            this.P9.Name = "P9";
            this.P9.Size = new System.Drawing.Size(186, 97);
            this.P9.TabIndex = 26;
            this.P9.Text = "P09";
            this.P9.UseVisualStyleBackColor = false;
            this.P9.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // P2
            // 
            this.P2.BackColor = System.Drawing.Color.White;
            this.P2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.P2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.P2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2.Location = new System.Drawing.Point(199, 315);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(186, 97);
            this.P2.TabIndex = 19;
            this.P2.Text = "P02";
            this.P2.UseVisualStyleBackColor = false;
            this.P2.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // P1
            // 
            this.P1.BackColor = System.Drawing.Color.White;
            this.P1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.P1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.P1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1.Location = new System.Drawing.Point(7, 315);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(186, 97);
            this.P1.TabIndex = 18;
            this.P1.Text = "B19";
            this.P1.UseVisualStyleBackColor = false;
            this.P1.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // B18
            // 
            this.B18.BackColor = System.Drawing.Color.White;
            this.B18.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.B18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B18.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B18.Location = new System.Drawing.Point(968, 212);
            this.B18.Name = "B18";
            this.B18.Size = new System.Drawing.Size(186, 97);
            this.B18.TabIndex = 17;
            this.B18.Text = "B18";
            this.B18.UseVisualStyleBackColor = false;
            this.B18.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // B17
            // 
            this.B17.BackColor = System.Drawing.Color.White;
            this.B17.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.B17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B17.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B17.Location = new System.Drawing.Point(775, 212);
            this.B17.Name = "B17";
            this.B17.Size = new System.Drawing.Size(186, 97);
            this.B17.TabIndex = 16;
            this.B17.Text = "B17";
            this.B17.UseVisualStyleBackColor = false;
            this.B17.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // B16
            // 
            this.B16.BackColor = System.Drawing.Color.White;
            this.B16.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.B16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B16.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B16.Location = new System.Drawing.Point(583, 212);
            this.B16.Name = "B16";
            this.B16.Size = new System.Drawing.Size(186, 97);
            this.B16.TabIndex = 15;
            this.B16.Text = "B16";
            this.B16.UseVisualStyleBackColor = false;
            this.B16.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // B13
            // 
            this.B13.BackColor = System.Drawing.Color.White;
            this.B13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.B13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B13.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B13.Location = new System.Drawing.Point(8, 212);
            this.B13.Name = "B13";
            this.B13.Size = new System.Drawing.Size(186, 97);
            this.B13.TabIndex = 12;
            this.B13.Text = "B13";
            this.B13.UseVisualStyleBackColor = false;
            this.B13.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // B14
            // 
            this.B14.BackColor = System.Drawing.Color.White;
            this.B14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.B14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B14.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B14.Location = new System.Drawing.Point(199, 212);
            this.B14.Name = "B14";
            this.B14.Size = new System.Drawing.Size(186, 97);
            this.B14.TabIndex = 13;
            this.B14.Text = "B14";
            this.B14.UseVisualStyleBackColor = false;
            this.B14.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // B15
            // 
            this.B15.BackColor = System.Drawing.Color.White;
            this.B15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.B15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B15.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B15.Location = new System.Drawing.Point(391, 212);
            this.B15.Name = "B15";
            this.B15.Size = new System.Drawing.Size(186, 97);
            this.B15.TabIndex = 14;
            this.B15.Text = "B15";
            this.B15.UseVisualStyleBackColor = false;
            this.B15.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // B12
            // 
            this.B12.BackColor = System.Drawing.Color.White;
            this.B12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.B12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B12.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B12.Location = new System.Drawing.Point(968, 109);
            this.B12.Name = "B12";
            this.B12.Size = new System.Drawing.Size(186, 97);
            this.B12.TabIndex = 11;
            this.B12.Text = "B12";
            this.B12.UseVisualStyleBackColor = false;
            this.B12.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // B11
            // 
            this.B11.BackColor = System.Drawing.Color.White;
            this.B11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.B11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B11.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B11.Location = new System.Drawing.Point(775, 109);
            this.B11.Name = "B11";
            this.B11.Size = new System.Drawing.Size(186, 97);
            this.B11.TabIndex = 10;
            this.B11.Text = "B11";
            this.B11.UseVisualStyleBackColor = false;
            this.B11.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // B10
            // 
            this.B10.BackColor = System.Drawing.Color.White;
            this.B10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.B10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B10.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B10.Location = new System.Drawing.Point(583, 109);
            this.B10.Name = "B10";
            this.B10.Size = new System.Drawing.Size(186, 97);
            this.B10.TabIndex = 9;
            this.B10.Text = "B10";
            this.B10.UseVisualStyleBackColor = false;
            this.B10.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // B03
            // 
            this.B03.BackColor = System.Drawing.Color.White;
            this.B03.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.B03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B03.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B03.Location = new System.Drawing.Point(391, 6);
            this.B03.Name = "B03";
            this.B03.Size = new System.Drawing.Size(186, 97);
            this.B03.TabIndex = 2;
            this.B03.Text = "B03";
            this.B03.UseVisualStyleBackColor = false;
            this.B03.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // B04
            // 
            this.B04.BackColor = System.Drawing.Color.White;
            this.B04.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.B04.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B04.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B04.Location = new System.Drawing.Point(583, 6);
            this.B04.Name = "B04";
            this.B04.Size = new System.Drawing.Size(186, 97);
            this.B04.TabIndex = 3;
            this.B04.Text = "B04";
            this.B04.UseVisualStyleBackColor = false;
            this.B04.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // B05
            // 
            this.B05.BackColor = System.Drawing.Color.White;
            this.B05.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.B05.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B05.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B05.Location = new System.Drawing.Point(775, 6);
            this.B05.Name = "B05";
            this.B05.Size = new System.Drawing.Size(186, 97);
            this.B05.TabIndex = 4;
            this.B05.Text = "B05";
            this.B05.UseVisualStyleBackColor = false;
            this.B05.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // B06
            // 
            this.B06.BackColor = System.Drawing.Color.White;
            this.B06.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.B06.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B06.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B06.Location = new System.Drawing.Point(967, 6);
            this.B06.Name = "B06";
            this.B06.Size = new System.Drawing.Size(186, 97);
            this.B06.TabIndex = 5;
            this.B06.Text = "B06";
            this.B06.UseVisualStyleBackColor = false;
            this.B06.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // B07
            // 
            this.B07.BackColor = System.Drawing.Color.White;
            this.B07.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.B07.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B07.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B07.Location = new System.Drawing.Point(8, 109);
            this.B07.Name = "B07";
            this.B07.Size = new System.Drawing.Size(186, 97);
            this.B07.TabIndex = 6;
            this.B07.Text = "B07";
            this.B07.UseVisualStyleBackColor = false;
            this.B07.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // B08
            // 
            this.B08.BackColor = System.Drawing.Color.White;
            this.B08.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.B08.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B08.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B08.Location = new System.Drawing.Point(199, 109);
            this.B08.Name = "B08";
            this.B08.Size = new System.Drawing.Size(186, 97);
            this.B08.TabIndex = 7;
            this.B08.Text = "B08";
            this.B08.UseVisualStyleBackColor = false;
            this.B08.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // B09
            // 
            this.B09.BackColor = System.Drawing.Color.White;
            this.B09.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.B09.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B09.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B09.Location = new System.Drawing.Point(391, 109);
            this.B09.Name = "B09";
            this.B09.Size = new System.Drawing.Size(186, 97);
            this.B09.TabIndex = 8;
            this.B09.Text = "B09";
            this.B09.UseVisualStyleBackColor = false;
            this.B09.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // B02
            // 
            this.B02.BackColor = System.Drawing.Color.White;
            this.B02.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.B02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B02.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B02.Location = new System.Drawing.Point(199, 6);
            this.B02.Name = "B02";
            this.B02.Size = new System.Drawing.Size(186, 97);
            this.B02.TabIndex = 1;
            this.B02.Text = "B02";
            this.B02.UseVisualStyleBackColor = false;
            this.B02.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // B01
            // 
            this.B01.BackColor = System.Drawing.Color.White;
            this.B01.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.B01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B01.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B01.Location = new System.Drawing.Point(7, 6);
            this.B01.Name = "B01";
            this.B01.Size = new System.Drawing.Size(186, 97);
            this.B01.TabIndex = 0;
            this.B01.Text = "B01";
            this.B01.UseVisualStyleBackColor = false;
            this.B01.Click += new System.EventHandler(this.TableButtonClick);
            // 
            // tabCheckIn
            // 
            this.tabCheckIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabCheckIn.Controls.Add(this.Label20);
            this.tabCheckIn.Controls.Add(this.lblTaxes);
            this.tabCheckIn.Controls.Add(this.Label9);
            this.tabCheckIn.Controls.Add(this.Label7);
            this.tabCheckIn.Controls.Add(this.Label4);
            this.tabCheckIn.Controls.Add(this.lblWaiter);
            this.tabCheckIn.Controls.Add(this.Label6);
            this.tabCheckIn.Controls.Add(this.lblOrgPrice);
            this.tabCheckIn.Controls.Add(this.Label5);
            this.tabCheckIn.Controls.Add(this.SequenceNo);
            this.tabCheckIn.Controls.Add(this.OrderNo);
            this.tabCheckIn.Controls.Add(this.cmdWaiter);
            this.tabCheckIn.Controls.Add(this.lblCustomer);
            this.tabCheckIn.Controls.Add(this.lblStatus);
            this.tabCheckIn.Controls.Add(this.lblTable);
            this.tabCheckIn.Controls.Add(this.cmdChange);
            this.tabCheckIn.Controls.Add(this.cmdVoid);
            this.tabCheckIn.Controls.Add(this.cmdClear);
            this.tabCheckIn.Controls.Add(this.lblDisplay);
            this.tabCheckIn.Controls.Add(this.cmdBack);
            this.tabCheckIn.Controls.Add(this.Num0);
            this.tabCheckIn.Controls.Add(this.NumFriction);
            this.tabCheckIn.Controls.Add(this.Num9);
            this.tabCheckIn.Controls.Add(this.Num8);
            this.tabCheckIn.Controls.Add(this.Num7);
            this.tabCheckIn.Controls.Add(this.Num6);
            this.tabCheckIn.Controls.Add(this.Num5);
            this.tabCheckIn.Controls.Add(this.Num4);
            this.tabCheckIn.Controls.Add(this.Num3);
            this.tabCheckIn.Controls.Add(this.Num2);
            this.tabCheckIn.Controls.Add(this.Num1);
            this.tabCheckIn.Controls.Add(this.ItemFlowPanel);
            this.tabCheckIn.Controls.Add(this.GroupFlowPanel);
            this.tabCheckIn.Controls.Add(this.label3);
            this.tabCheckIn.Controls.Add(this.label2);
            this.tabCheckIn.Controls.Add(this.cmdClose);
            this.tabCheckIn.Controls.Add(this.cmdSettle);
            this.tabCheckIn.Controls.Add(this.label1);
            this.tabCheckIn.Controls.Add(this.cmdCustomer);
            this.tabCheckIn.Controls.Add(this.cmdPrint);
            this.tabCheckIn.Controls.Add(this.SaleDataGrid);
            this.tabCheckIn.ImageKey = "Breakfast-icon.png";
            this.tabCheckIn.Location = new System.Drawing.Point(4, 39);
            this.tabCheckIn.Name = "tabCheckIn";
            this.tabCheckIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabCheckIn.Size = new System.Drawing.Size(1160, 626);
            this.tabCheckIn.TabIndex = 1;
            this.tabCheckIn.Text = "Check In";
            // 
            // Label20
            // 
            this.Label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label20.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.ForeColor = System.Drawing.Color.Gray;
            this.Label20.Location = new System.Drawing.Point(8, 534);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(122, 36);
            this.Label20.TabIndex = 1056;
            this.Label20.Text = "Order No :";
            this.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTaxes
            // 
            this.lblTaxes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTaxes.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxes.ForeColor = System.Drawing.Color.Red;
            this.lblTaxes.Location = new System.Drawing.Point(298, 534);
            this.lblTaxes.Name = "lblTaxes";
            this.lblTaxes.Size = new System.Drawing.Size(158, 16);
            this.lblTaxes.TabIndex = 1016;
            this.lblTaxes.Text = "0.00";
            this.lblTaxes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTaxes.Visible = false;
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.Red;
            this.Label9.Location = new System.Drawing.Point(136, 534);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(156, 16);
            this.Label9.TabIndex = 1015;
            this.Label9.Text = "Service Charges :";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label9.Visible = false;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.SeaGreen;
            this.Label7.Location = new System.Drawing.Point(674, 7);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(478, 41);
            this.Label7.TabIndex = 1014;
            this.Label7.Text = "DISHES";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.Label4.Location = new System.Drawing.Point(484, 7);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(170, 41);
            this.Label4.TabIndex = 1013;
            this.Label4.Text = "MAIN MENU";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWaiter
            // 
            this.lblWaiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblWaiter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaiter.ForeColor = System.Drawing.Color.Gray;
            this.lblWaiter.Location = new System.Drawing.Point(215, 70);
            this.lblWaiter.Name = "lblWaiter";
            this.lblWaiter.Size = new System.Drawing.Size(241, 20);
            this.lblWaiter.TabIndex = 1008;
            this.lblWaiter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Gray;
            this.Label6.Location = new System.Drawing.Point(136, 70);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(79, 20);
            this.Label6.TabIndex = 1007;
            this.Label6.Text = "Waiter :";
            // 
            // lblOrgPrice
            // 
            this.lblOrgPrice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblOrgPrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrgPrice.ForeColor = System.Drawing.Color.Red;
            this.lblOrgPrice.Location = new System.Drawing.Point(298, 550);
            this.lblOrgPrice.Name = "lblOrgPrice";
            this.lblOrgPrice.Size = new System.Drawing.Size(158, 16);
            this.lblOrgPrice.TabIndex = 1004;
            this.lblOrgPrice.Text = "0.00";
            this.lblOrgPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOrgPrice.Visible = false;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Red;
            this.Label5.Location = new System.Drawing.Point(136, 550);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(156, 16);
            this.Label5.TabIndex = 1003;
            this.Label5.Text = "Balance :";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label5.Visible = false;
            // 
            // SequenceNo
            // 
            this.SequenceNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SequenceNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SequenceNo.ForeColor = System.Drawing.Color.Gray;
            this.SequenceNo.Location = new System.Drawing.Point(293, 7);
            this.SequenceNo.Name = "SequenceNo";
            this.SequenceNo.Size = new System.Drawing.Size(163, 20);
            this.SequenceNo.TabIndex = 1002;
            this.SequenceNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OrderNo
            // 
            this.OrderNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OrderNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OrderNo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderNo.Location = new System.Drawing.Point(6, 577);
            this.OrderNo.Name = "OrderNo";
            this.OrderNo.Size = new System.Drawing.Size(124, 39);
            this.OrderNo.TabIndex = 0;
            this.OrderNo.Text = "0";
            this.OrderNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdWaiter
            // 
            this.cmdWaiter.BackColor = System.Drawing.Color.White;
            this.cmdWaiter.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.cmdWaiter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.cmdWaiter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.cmdWaiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdWaiter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdWaiter.Location = new System.Drawing.Point(6, 186);
            this.cmdWaiter.Name = "cmdWaiter";
            this.cmdWaiter.Size = new System.Drawing.Size(124, 39);
            this.cmdWaiter.TabIndex = 4;
            this.cmdWaiter.Text = "&Waiter";
            this.cmdWaiter.UseVisualStyleBackColor = false;
            this.cmdWaiter.Click += new System.EventHandler(this.cmdWaiter_Click);
            this.cmdWaiter.MouseEnter += new System.EventHandler(this.SpecialButtons1);
            this.cmdWaiter.MouseLeave += new System.EventHandler(this.SpecialButtons2);
            // 
            // lblCustomer
            // 
            this.lblCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCustomer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.Gray;
            this.lblCustomer.Location = new System.Drawing.Point(215, 49);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(241, 20);
            this.lblCustomer.TabIndex = 1006;
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Location = new System.Drawing.Point(215, 28);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(241, 20);
            this.lblStatus.TabIndex = 1004;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTable
            // 
            this.lblTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTable.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.ForeColor = System.Drawing.Color.Gray;
            this.lblTable.Location = new System.Drawing.Point(215, 7);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(79, 20);
            this.lblTable.TabIndex = 1001;
            this.lblTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdChange
            // 
            this.cmdChange.BackColor = System.Drawing.Color.White;
            this.cmdChange.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.cmdChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.cmdChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.cmdChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdChange.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdChange.Location = new System.Drawing.Point(6, 51);
            this.cmdChange.Name = "cmdChange";
            this.cmdChange.Size = new System.Drawing.Size(124, 39);
            this.cmdChange.TabIndex = 1;
            this.cmdChange.Text = "&Change Table";
            this.cmdChange.UseVisualStyleBackColor = true;
            this.cmdChange.Click += new System.EventHandler(this.cmdChange_Click);
            this.cmdChange.MouseEnter += new System.EventHandler(this.SpecialButtons1);
            this.cmdChange.MouseLeave += new System.EventHandler(this.SpecialButtons2);
            // 
            // cmdVoid
            // 
            this.cmdVoid.BackColor = System.Drawing.Color.White;
            this.cmdVoid.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.cmdVoid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.cmdVoid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.cmdVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdVoid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVoid.Location = new System.Drawing.Point(6, 141);
            this.cmdVoid.Name = "cmdVoid";
            this.cmdVoid.Size = new System.Drawing.Size(124, 39);
            this.cmdVoid.TabIndex = 3;
            this.cmdVoid.Text = "&Clear Order";
            this.cmdVoid.UseVisualStyleBackColor = false;
            this.cmdVoid.Click += new System.EventHandler(this.cmdVoid_Click);
            this.cmdVoid.MouseEnter += new System.EventHandler(this.SpecialButtons1);
            this.cmdVoid.MouseLeave += new System.EventHandler(this.SpecialButtons2);
            // 
            // cmdClear
            // 
            this.cmdClear.BackColor = System.Drawing.Color.White;
            this.cmdClear.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cmdClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.cmdClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.cmdClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClear.Location = new System.Drawing.Point(1082, 412);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(70, 26);
            this.cmdClear.TabIndex = 8;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = false;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.White;
            this.lblDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.Color.Red;
            this.lblDisplay.Location = new System.Drawing.Point(674, 411);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(402, 26);
            this.lblDisplay.TabIndex = 7;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdBack
            // 
            this.cmdBack.BackColor = System.Drawing.Color.White;
            this.cmdBack.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cmdBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.cmdBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.cmdBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBack.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBack.Location = new System.Drawing.Point(996, 578);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(156, 38);
            this.cmdBack.TabIndex = 29;
            this.cmdBack.Text = "Backspace";
            this.cmdBack.UseVisualStyleBackColor = false;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // Num0
            // 
            this.Num0.BackColor = System.Drawing.Color.White;
            this.Num0.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Num0.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Num0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Num0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num0.Location = new System.Drawing.Point(835, 578);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(156, 38);
            this.Num0.TabIndex = 28;
            this.Num0.Text = "0";
            this.Num0.UseVisualStyleBackColor = false;
            this.Num0.Click += new System.EventHandler(this.DigitClick);
            // 
            // NumFriction
            // 
            this.NumFriction.BackColor = System.Drawing.Color.White;
            this.NumFriction.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.NumFriction.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.NumFriction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.NumFriction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.NumFriction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumFriction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumFriction.Location = new System.Drawing.Point(674, 578);
            this.NumFriction.Name = "NumFriction";
            this.NumFriction.Size = new System.Drawing.Size(156, 38);
            this.NumFriction.TabIndex = 27;
            this.NumFriction.Text = ".";
            this.NumFriction.UseVisualStyleBackColor = false;
            this.NumFriction.Click += new System.EventHandler(this.NumFriction_Click);
            // 
            // Num9
            // 
            this.Num9.BackColor = System.Drawing.Color.White;
            this.Num9.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Num9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Num9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Num9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num9.Location = new System.Drawing.Point(996, 534);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(156, 38);
            this.Num9.TabIndex = 26;
            this.Num9.Text = "9";
            this.Num9.UseVisualStyleBackColor = false;
            this.Num9.Click += new System.EventHandler(this.DigitClick);
            // 
            // Num8
            // 
            this.Num8.BackColor = System.Drawing.Color.White;
            this.Num8.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Num8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Num8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Num8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num8.Location = new System.Drawing.Point(835, 534);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(156, 38);
            this.Num8.TabIndex = 25;
            this.Num8.Text = "8";
            this.Num8.UseVisualStyleBackColor = false;
            this.Num8.Click += new System.EventHandler(this.DigitClick);
            // 
            // Num7
            // 
            this.Num7.BackColor = System.Drawing.Color.White;
            this.Num7.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Num7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Num7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Num7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num7.Location = new System.Drawing.Point(674, 534);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(156, 38);
            this.Num7.TabIndex = 24;
            this.Num7.Text = "7";
            this.Num7.UseVisualStyleBackColor = false;
            this.Num7.Click += new System.EventHandler(this.DigitClick);
            // 
            // Num6
            // 
            this.Num6.BackColor = System.Drawing.Color.White;
            this.Num6.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Num6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Num6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Num6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num6.Location = new System.Drawing.Point(996, 491);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(156, 38);
            this.Num6.TabIndex = 23;
            this.Num6.Text = "6";
            this.Num6.UseVisualStyleBackColor = false;
            this.Num6.Click += new System.EventHandler(this.DigitClick);
            // 
            // Num5
            // 
            this.Num5.BackColor = System.Drawing.Color.White;
            this.Num5.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Num5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Num5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Num5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num5.Location = new System.Drawing.Point(835, 491);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(156, 38);
            this.Num5.TabIndex = 22;
            this.Num5.Text = "5";
            this.Num5.UseVisualStyleBackColor = false;
            this.Num5.Click += new System.EventHandler(this.DigitClick);
            // 
            // Num4
            // 
            this.Num4.BackColor = System.Drawing.Color.White;
            this.Num4.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Num4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Num4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Num4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num4.Location = new System.Drawing.Point(674, 491);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(156, 38);
            this.Num4.TabIndex = 21;
            this.Num4.Text = "4";
            this.Num4.UseVisualStyleBackColor = false;
            this.Num4.Click += new System.EventHandler(this.DigitClick);
            // 
            // Num3
            // 
            this.Num3.BackColor = System.Drawing.Color.White;
            this.Num3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Num3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Num3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Num3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num3.Location = new System.Drawing.Point(996, 448);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(156, 38);
            this.Num3.TabIndex = 20;
            this.Num3.Text = "3";
            this.Num3.UseVisualStyleBackColor = false;
            this.Num3.Click += new System.EventHandler(this.DigitClick);
            // 
            // Num2
            // 
            this.Num2.BackColor = System.Drawing.Color.White;
            this.Num2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Num2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Num2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Num2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num2.Location = new System.Drawing.Point(835, 448);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(156, 38);
            this.Num2.TabIndex = 19;
            this.Num2.Text = "2";
            this.Num2.UseVisualStyleBackColor = false;
            this.Num2.Click += new System.EventHandler(this.DigitClick);
            // 
            // Num1
            // 
            this.Num1.BackColor = System.Drawing.Color.White;
            this.Num1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Num1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.Num1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.Num1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num1.Location = new System.Drawing.Point(674, 448);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(156, 38);
            this.Num1.TabIndex = 18;
            this.Num1.Text = "1";
            this.Num1.UseVisualStyleBackColor = false;
            this.Num1.Click += new System.EventHandler(this.DigitClick);
            // 
            // ItemFlowPanel
            // 
            this.ItemFlowPanel.BackColor = System.Drawing.Color.White;
            this.ItemFlowPanel.Location = new System.Drawing.Point(674, 49);
            this.ItemFlowPanel.Name = "ItemFlowPanel";
            this.ItemFlowPanel.Size = new System.Drawing.Size(478, 352);
            this.ItemFlowPanel.TabIndex = 1012;
            // 
            // GroupFlowPanel
            // 
            this.GroupFlowPanel.Location = new System.Drawing.Point(482, 51);
            this.GroupFlowPanel.Name = "GroupFlowPanel";
            this.GroupFlowPanel.Size = new System.Drawing.Size(186, 565);
            this.GroupFlowPanel.TabIndex = 1010;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(136, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 1005;
            this.label3.Text = "Customer :";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(136, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1003;
            this.label2.Text = "Status :";
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.Color.Red;
            this.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmdClose.Location = new System.Drawing.Point(298, 577);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(158, 39);
            this.cmdClose.TabIndex = 6;
            this.cmdClose.Text = "&Close";
            this.cmdClose.UseVisualStyleBackColor = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdSettle
            // 
            this.cmdSettle.BackColor = System.Drawing.Color.White;
            this.cmdSettle.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cmdSettle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.cmdSettle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSettle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSettle.Location = new System.Drawing.Point(136, 577);
            this.cmdSettle.Name = "cmdSettle";
            this.cmdSettle.Size = new System.Drawing.Size(158, 39);
            this.cmdSettle.TabIndex = 5;
            this.cmdSettle.Text = "&Settle";
            this.cmdSettle.UseVisualStyleBackColor = false;
            this.cmdSettle.Click += new System.EventHandler(this.cmdSettle_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(136, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1000;
            this.label1.Text = "Table : ";
            // 
            // cmdCustomer
            // 
            this.cmdCustomer.BackColor = System.Drawing.Color.White;
            this.cmdCustomer.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.cmdCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.cmdCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.cmdCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCustomer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCustomer.Location = new System.Drawing.Point(6, 7);
            this.cmdCustomer.Name = "cmdCustomer";
            this.cmdCustomer.Size = new System.Drawing.Size(124, 39);
            this.cmdCustomer.TabIndex = 0;
            this.cmdCustomer.Text = "&Customer";
            this.cmdCustomer.UseVisualStyleBackColor = true;
            this.cmdCustomer.Click += new System.EventHandler(this.cmdCustomer_Click);
            this.cmdCustomer.MouseEnter += new System.EventHandler(this.SpecialButtons1);
            this.cmdCustomer.MouseLeave += new System.EventHandler(this.SpecialButtons2);
            // 
            // cmdPrint
            // 
            this.cmdPrint.BackColor = System.Drawing.Color.White;
            this.cmdPrint.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.cmdPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.cmdPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPrint.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPrint.Location = new System.Drawing.Point(6, 96);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(124, 39);
            this.cmdPrint.TabIndex = 2;
            this.cmdPrint.Text = "&Print Bill";
            this.cmdPrint.UseVisualStyleBackColor = false;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            this.cmdPrint.MouseEnter += new System.EventHandler(this.SpecialButtons1);
            this.cmdPrint.MouseLeave += new System.EventHandler(this.SpecialButtons2);
            // 
            // SaleDataGrid
            // 
            this.SaleDataGrid.AllowUserToAddRows = false;
            this.SaleDataGrid.AllowUserToResizeColumns = false;
            this.SaleDataGrid.AllowUserToResizeRows = false;
            this.SaleDataGrid.AutoGenerateColumns = false;
            this.SaleDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.SaleDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SaleDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SaleDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SaleDataGrid.ColumnHeadersHeight = 22;
            this.SaleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SaleDataGrid.ColumnHeadersVisible = false;
            this.SaleDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colQuantity,
            this.colDescription,
            this.colSubTotal});
            this.SaleDataGrid.DataSource = this.SaleBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SaleDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.SaleDataGrid.Location = new System.Drawing.Point(136, 93);
            this.SaleDataGrid.Name = "SaleDataGrid";
            this.SaleDataGrid.ReadOnly = true;
            this.SaleDataGrid.RowHeadersVisible = false;
            this.SaleDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SaleDataGrid.Size = new System.Drawing.Size(320, 436);
            this.SaleDataGrid.TabIndex = 1009;
            this.SaleDataGrid.TabStop = false;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "QTY";
            this.colQuantity.HeaderText = "Qty";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Width = 50;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "STOCKDESC";
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Width = 170;
            // 
            // colSubTotal
            // 
            this.colSubTotal.DataPropertyName = "PRICE";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            this.colSubTotal.DefaultCellStyle = dataGridViewCellStyle1;
            this.colSubTotal.HeaderText = "Sub Total";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
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
            // tabCustomer
            // 
            this.tabCustomer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabCustomer.Controls.Add(this.cmdCancel);
            this.tabCustomer.Controls.Add(this.Label10);
            this.tabCustomer.Controls.Add(this.txtPhone);
            this.tabCustomer.Controls.Add(this.cmdEdit);
            this.tabCustomer.Controls.Add(this.cmdDelete);
            this.tabCustomer.Controls.Add(this.cmdSelect);
            this.tabCustomer.Controls.Add(this.cmdNew);
            this.tabCustomer.Controls.Add(this.Label8);
            this.tabCustomer.Controls.Add(this.txtName);
            this.tabCustomer.Controls.Add(this.dgvCustomer);
            this.tabCustomer.Controls.Add(this.txtSearch);
            this.tabCustomer.ImageKey = "People-64.png";
            this.tabCustomer.Location = new System.Drawing.Point(4, 39);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomer.Size = new System.Drawing.Size(1160, 626);
            this.tabCustomer.TabIndex = 2;
            this.tabCustomer.Text = "Customers";
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.Color.White;
            this.cmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmdCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.cmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Location = new System.Drawing.Point(1029, 273);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(124, 60);
            this.cmdCancel.TabIndex = 11;
            this.cmdCancel.Text = "&Back";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            this.cmdCancel.MouseEnter += new System.EventHandler(this.ButtonMouseOver);
            this.cmdCancel.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(8, 62);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(62, 23);
            this.Label10.TabIndex = 10;
            this.Label10.Text = "Phone";
            this.Label10.Visible = false;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(82, 59);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(940, 29);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.Visible = false;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // cmdEdit
            // 
            this.cmdEdit.BackColor = System.Drawing.Color.White;
            this.cmdEdit.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmdEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.cmdEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEdit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEdit.Location = new System.Drawing.Point(1029, 76);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(124, 60);
            this.cmdEdit.TabIndex = 5;
            this.cmdEdit.Text = "&Edit Customer";
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            this.cmdEdit.MouseEnter += new System.EventHandler(this.ButtonMouseOver);
            this.cmdEdit.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // cmdDelete
            // 
            this.cmdDelete.BackColor = System.Drawing.Color.White;
            this.cmdDelete.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmdDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.cmdDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.Location = new System.Drawing.Point(1029, 207);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(124, 60);
            this.cmdDelete.TabIndex = 7;
            this.cmdDelete.Text = "&Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            this.cmdDelete.MouseEnter += new System.EventHandler(this.ButtonMouseOver);
            this.cmdDelete.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // cmdSelect
            // 
            this.cmdSelect.BackColor = System.Drawing.Color.White;
            this.cmdSelect.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmdSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.cmdSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.cmdSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSelect.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSelect.Location = new System.Drawing.Point(1029, 10);
            this.cmdSelect.Name = "cmdSelect";
            this.cmdSelect.Size = new System.Drawing.Size(124, 60);
            this.cmdSelect.TabIndex = 4;
            this.cmdSelect.Text = "Select &Customer";
            this.cmdSelect.UseVisualStyleBackColor = true;
            this.cmdSelect.Click += new System.EventHandler(this.cmdSelect_Click);
            this.cmdSelect.MouseEnter += new System.EventHandler(this.ButtonMouseOver);
            this.cmdSelect.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // cmdNew
            // 
            this.cmdNew.BackColor = System.Drawing.Color.White;
            this.cmdNew.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmdNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.cmdNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.cmdNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNew.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNew.Location = new System.Drawing.Point(1029, 142);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(124, 60);
            this.cmdNew.TabIndex = 6;
            this.cmdNew.Text = "&New Customer";
            this.cmdNew.UseVisualStyleBackColor = false;
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            this.cmdNew.MouseEnter += new System.EventHandler(this.ButtonMouseOver);
            this.cmdNew.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(8, 18);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(68, 23);
            this.Label8.TabIndex = 0;
            this.Label8.Text = "Search";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(82, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(940, 29);
            this.txtName.TabIndex = 8;
            this.txtName.Visible = false;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AllowUserToResizeColumns = false;
            this.dgvCustomer.AllowUserToResizeRows = false;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomer.ColumnHeadersHeight = 28;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.colPhone});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomer.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustomer.Location = new System.Drawing.Point(12, 59);
            this.dgvCustomer.MultiSelect = false;
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersVisible = false;
            this.dgvCustomer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(1009, 556);
            this.dgvCustomer.TabIndex = 12;
            this.dgvCustomer.TabStop = false;
            // 
            // ColName
            // 
            this.ColName.DataPropertyName = "cust_name";
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.Width = 505;
            // 
            // colPhone
            // 
            this.colPhone.DataPropertyName = "cust_tel";
            this.colPhone.HeaderText = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            this.colPhone.Width = 504;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(82, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(940, 26);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // tabCheckOut
            // 
            this.tabCheckOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabCheckOut.Controls.Add(this.lblFinalOrderNo);
            this.tabCheckOut.Controls.Add(this.Label19);
            this.tabCheckOut.Controls.Add(this.cmdPaid);
            this.tabCheckOut.Controls.Add(this.lblDue);
            this.tabCheckOut.Controls.Add(this.Label18);
            this.tabCheckOut.Controls.Add(this.cmdRefreshBill);
            this.tabCheckOut.Controls.Add(this.cmdDiscount);
            this.tabCheckOut.Controls.Add(this.cmdDiscPaid);
            this.tabCheckOut.Controls.Add(this.cmdClearDisplay);
            this.tabCheckOut.Controls.Add(this.cmdCloseBack);
            this.tabCheckOut.Controls.Add(this.lblRefund);
            this.tabCheckOut.Controls.Add(this.Label17);
            this.tabCheckOut.Controls.Add(this.cmdBackSpace);
            this.tabCheckOut.Controls.Add(this.D0);
            this.tabCheckOut.Controls.Add(this.D9);
            this.tabCheckOut.Controls.Add(this.D8);
            this.tabCheckOut.Controls.Add(this.D7);
            this.tabCheckOut.Controls.Add(this.D6);
            this.tabCheckOut.Controls.Add(this.D5);
            this.tabCheckOut.Controls.Add(this.D4);
            this.tabCheckOut.Controls.Add(this.D3);
            this.tabCheckOut.Controls.Add(this.D2);
            this.tabCheckOut.Controls.Add(this.D1);
            this.tabCheckOut.Controls.Add(this.cmdPrintBill);
            this.tabCheckOut.Controls.Add(this.txtPaid);
            this.tabCheckOut.Controls.Add(this.label99);
            this.tabCheckOut.Controls.Add(this.lblTotalBill);
            this.tabCheckOut.Controls.Add(this.Label11);
            this.tabCheckOut.Controls.Add(this.lblFinalDiscount);
            this.tabCheckOut.Controls.Add(this.Label13);
            this.tabCheckOut.Controls.Add(this.lblFinalCharges);
            this.tabCheckOut.Controls.Add(this.Label12);
            this.tabCheckOut.Controls.Add(this.lblFinalWaiter);
            this.tabCheckOut.Controls.Add(this.Label14);
            this.tabCheckOut.Controls.Add(this.lblFinalBill);
            this.tabCheckOut.Controls.Add(this.Label16);
            this.tabCheckOut.Controls.Add(this.lblFinalSequence);
            this.tabCheckOut.Controls.Add(this.lblFinalCustomer);
            this.tabCheckOut.Controls.Add(this.lblFinalStatus);
            this.tabCheckOut.Controls.Add(this.lblFinalTable);
            this.tabCheckOut.Controls.Add(this.Label21);
            this.tabCheckOut.Controls.Add(this.Label22);
            this.tabCheckOut.Controls.Add(this.Label23);
            this.tabCheckOut.Controls.Add(this.dgvFinalBill);
            this.tabCheckOut.Controls.Add(this.ShapeContainer1);
            this.tabCheckOut.ImageKey = "1487123129_Sales-by-Payment-Method-rep.png";
            this.tabCheckOut.Location = new System.Drawing.Point(4, 39);
            this.tabCheckOut.Name = "tabCheckOut";
            this.tabCheckOut.Padding = new System.Windows.Forms.Padding(3);
            this.tabCheckOut.Size = new System.Drawing.Size(1160, 626);
            this.tabCheckOut.TabIndex = 3;
            this.tabCheckOut.Text = "Check Out";
            // 
            // lblFinalOrderNo
            // 
            this.lblFinalOrderNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFinalOrderNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalOrderNo.ForeColor = System.Drawing.Color.Gray;
            this.lblFinalOrderNo.Location = new System.Drawing.Point(491, 14);
            this.lblFinalOrderNo.Name = "lblFinalOrderNo";
            this.lblFinalOrderNo.Size = new System.Drawing.Size(79, 20);
            this.lblFinalOrderNo.TabIndex = 1056;
            this.lblFinalOrderNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label19
            // 
            this.Label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label19.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.ForeColor = System.Drawing.Color.Gray;
            this.Label19.Location = new System.Drawing.Point(412, 14);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(79, 20);
            this.Label19.TabIndex = 1055;
            this.Label19.Text = "Order No :";
            // 
            // cmdPaid
            // 
            this.cmdPaid.BackColor = System.Drawing.Color.White;
            this.cmdPaid.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cmdPaid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.cmdPaid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.cmdPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPaid.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPaid.Location = new System.Drawing.Point(665, 497);
            this.cmdPaid.Name = "cmdPaid";
            this.cmdPaid.Size = new System.Drawing.Size(155, 104);
            this.cmdPaid.TabIndex = 17;
            this.cmdPaid.Text = "P&aid";
            this.cmdPaid.UseVisualStyleBackColor = false;
            this.cmdPaid.Click += new System.EventHandler(this.cmdPaid_Click);
            // 
            // lblDue
            // 
            this.lblDue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDue.ForeColor = System.Drawing.Color.Red;
            this.lblDue.Location = new System.Drawing.Point(251, 591);
            this.lblDue.Name = "lblDue";
            this.lblDue.Size = new System.Drawing.Size(158, 16);
            this.lblDue.TabIndex = 1054;
            this.lblDue.Text = "0.00";
            this.lblDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label18
            // 
            this.Label18.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Label18.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label18.ForeColor = System.Drawing.Color.Red;
            this.Label18.Location = new System.Drawing.Point(8, 591);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(156, 16);
            this.Label18.TabIndex = 1053;
            this.Label18.Text = "Balance :";
            this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdRefreshBill
            // 
            this.cmdRefreshBill.BackColor = System.Drawing.Color.White;
            this.cmdRefreshBill.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cmdRefreshBill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.cmdRefreshBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.cmdRefreshBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRefreshBill.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRefreshBill.Location = new System.Drawing.Point(504, 497);
            this.cmdRefreshBill.Name = "cmdRefreshBill";
            this.cmdRefreshBill.Size = new System.Drawing.Size(155, 104);
            this.cmdRefreshBill.TabIndex = 16;
            this.cmdRefreshBill.Text = "&Refresh Bill";
            this.cmdRefreshBill.UseVisualStyleBackColor = false;
            this.cmdRefreshBill.Click += new System.EventHandler(this.cmdRefreshBill_Click);
            // 
            // cmdDiscount
            // 
            this.cmdDiscount.BackColor = System.Drawing.Color.White;
            this.cmdDiscount.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cmdDiscount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.cmdDiscount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.cmdDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDiscount.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDiscount.Location = new System.Drawing.Point(504, 309);
            this.cmdDiscount.Name = "cmdDiscount";
            this.cmdDiscount.Size = new System.Drawing.Size(155, 81);
            this.cmdDiscount.TabIndex = 14;
            this.cmdDiscount.Text = "&Discount %";
            this.cmdDiscount.UseVisualStyleBackColor = false;
            this.cmdDiscount.Click += new System.EventHandler(this.cmdDiscount_Click);
            this.cmdDiscount.MouseEnter += new System.EventHandler(this.ButtonMouseOver);
            this.cmdDiscount.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // cmdDiscPaid
            // 
            this.cmdDiscPaid.BackColor = System.Drawing.Color.White;
            this.cmdDiscPaid.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cmdDiscPaid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.cmdDiscPaid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.cmdDiscPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDiscPaid.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDiscPaid.Location = new System.Drawing.Point(504, 395);
            this.cmdDiscPaid.Name = "cmdDiscPaid";
            this.cmdDiscPaid.Size = new System.Drawing.Size(155, 82);
            this.cmdDiscPaid.TabIndex = 15;
            this.cmdDiscPaid.Text = "D&iscount";
            this.cmdDiscPaid.UseVisualStyleBackColor = false;
            this.cmdDiscPaid.Click += new System.EventHandler(this.cmdDiscPaid_Click);
            this.cmdDiscPaid.MouseEnter += new System.EventHandler(this.ButtonMouseOver);
            this.cmdDiscPaid.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // cmdClearDisplay
            // 
            this.cmdClearDisplay.BackColor = System.Drawing.Color.White;
            this.cmdClearDisplay.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cmdClearDisplay.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.cmdClearDisplay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmdClearDisplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmdClearDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClearDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClearDisplay.Location = new System.Drawing.Point(988, 439);
            this.cmdClearDisplay.Name = "cmdClearDisplay";
            this.cmdClearDisplay.Size = new System.Drawing.Size(155, 38);
            this.cmdClearDisplay.TabIndex = 13;
            this.cmdClearDisplay.Text = "Clear";
            this.cmdClearDisplay.UseVisualStyleBackColor = false;
            this.cmdClearDisplay.Click += new System.EventHandler(this.cmdClearDisplay_Click);
            this.cmdClearDisplay.MouseEnter += new System.EventHandler(this.ButtonMouseOver);
            this.cmdClearDisplay.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // cmdCloseBack
            // 
            this.cmdCloseBack.BackColor = System.Drawing.Color.Red;
            this.cmdCloseBack.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cmdCloseBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cmdCloseBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCloseBack.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCloseBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmdCloseBack.Location = new System.Drawing.Point(987, 497);
            this.cmdCloseBack.Name = "cmdCloseBack";
            this.cmdCloseBack.Size = new System.Drawing.Size(156, 105);
            this.cmdCloseBack.TabIndex = 19;
            this.cmdCloseBack.Text = "&Close";
            this.cmdCloseBack.UseVisualStyleBackColor = false;
            this.cmdCloseBack.Click += new System.EventHandler(this.cmdCloseBack_Click);
            // 
            // lblRefund
            // 
            this.lblRefund.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblRefund.Font = new System.Drawing.Font("Garamond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefund.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblRefund.Location = new System.Drawing.Point(873, 146);
            this.lblRefund.Margin = new System.Windows.Forms.Padding(0);
            this.lblRefund.Name = "lblRefund";
            this.lblRefund.Size = new System.Drawing.Size(284, 54);
            this.lblRefund.TabIndex = 1052;
            this.lblRefund.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Label17.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.ForeColor = System.Drawing.Color.DarkGray;
            this.Label17.Location = new System.Drawing.Point(657, 151);
            this.Label17.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(147, 45);
            this.Label17.TabIndex = 1051;
            this.Label17.Text = "Refund";
            this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label17.Visible = false;
            // 
            // cmdBackSpace
            // 
            this.cmdBackSpace.BackColor = System.Drawing.Color.White;
            this.cmdBackSpace.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cmdBackSpace.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.cmdBackSpace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmdBackSpace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmdBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBackSpace.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBackSpace.Location = new System.Drawing.Point(826, 439);
            this.cmdBackSpace.Name = "cmdBackSpace";
            this.cmdBackSpace.Size = new System.Drawing.Size(156, 38);
            this.cmdBackSpace.TabIndex = 12;
            this.cmdBackSpace.Text = "Backspace";
            this.cmdBackSpace.UseVisualStyleBackColor = false;
            this.cmdBackSpace.Click += new System.EventHandler(this.cmdBackSapce_Click);
            this.cmdBackSpace.MouseEnter += new System.EventHandler(this.ButtonMouseOver);
            this.cmdBackSpace.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // D0
            // 
            this.D0.BackColor = System.Drawing.Color.White;
            this.D0.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.D0.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.D0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.D0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.D0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D0.Location = new System.Drawing.Point(665, 439);
            this.D0.Name = "D0";
            this.D0.Size = new System.Drawing.Size(156, 38);
            this.D0.TabIndex = 11;
            this.D0.Text = "0";
            this.D0.UseVisualStyleBackColor = false;
            this.D0.Click += new System.EventHandler(this.FinalDigitClick);
            this.D0.MouseEnter += new System.EventHandler(this.ButtonMouseOver);
            this.D0.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // D9
            // 
            this.D9.BackColor = System.Drawing.Color.White;
            this.D9.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.D9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.D9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.D9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.D9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D9.Location = new System.Drawing.Point(987, 395);
            this.D9.Name = "D9";
            this.D9.Size = new System.Drawing.Size(156, 38);
            this.D9.TabIndex = 10;
            this.D9.Text = "9";
            this.D9.UseVisualStyleBackColor = false;
            this.D9.Click += new System.EventHandler(this.FinalDigitClick);
            this.D9.MouseEnter += new System.EventHandler(this.ButtonMouseOver);
            this.D9.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // D8
            // 
            this.D8.BackColor = System.Drawing.Color.White;
            this.D8.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.D8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.D8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.D8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.D8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D8.Location = new System.Drawing.Point(826, 395);
            this.D8.Name = "D8";
            this.D8.Size = new System.Drawing.Size(156, 38);
            this.D8.TabIndex = 9;
            this.D8.Text = "8";
            this.D8.UseVisualStyleBackColor = false;
            this.D8.Click += new System.EventHandler(this.FinalDigitClick);
            this.D8.MouseEnter += new System.EventHandler(this.ButtonMouseOver);
            this.D8.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // D7
            // 
            this.D7.BackColor = System.Drawing.Color.White;
            this.D7.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.D7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.D7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.D7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.D7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D7.Location = new System.Drawing.Point(665, 395);
            this.D7.Name = "D7";
            this.D7.Size = new System.Drawing.Size(156, 38);
            this.D7.TabIndex = 8;
            this.D7.Text = "7";
            this.D7.UseVisualStyleBackColor = false;
            this.D7.Click += new System.EventHandler(this.FinalDigitClick);
            this.D7.MouseEnter += new System.EventHandler(this.ButtonMouseOver);
            this.D7.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // D6
            // 
            this.D6.BackColor = System.Drawing.Color.White;
            this.D6.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.D6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.D6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.D6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.D6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D6.Location = new System.Drawing.Point(987, 352);
            this.D6.Name = "D6";
            this.D6.Size = new System.Drawing.Size(156, 38);
            this.D6.TabIndex = 7;
            this.D6.Text = "6";
            this.D6.UseVisualStyleBackColor = false;
            this.D6.Click += new System.EventHandler(this.FinalDigitClick);
            this.D6.MouseEnter += new System.EventHandler(this.ButtonMouseOver);
            this.D6.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // D5
            // 
            this.D5.BackColor = System.Drawing.Color.White;
            this.D5.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.D5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.D5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.D5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.D5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D5.Location = new System.Drawing.Point(826, 352);
            this.D5.Name = "D5";
            this.D5.Size = new System.Drawing.Size(156, 38);
            this.D5.TabIndex = 6;
            this.D5.Text = "5";
            this.D5.UseVisualStyleBackColor = false;
            this.D5.Click += new System.EventHandler(this.FinalDigitClick);
            this.D5.MouseEnter += new System.EventHandler(this.ButtonMouseOver);
            this.D5.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // D4
            // 
            this.D4.BackColor = System.Drawing.Color.White;
            this.D4.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.D4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.D4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.D4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.D4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D4.Location = new System.Drawing.Point(665, 352);
            this.D4.Name = "D4";
            this.D4.Size = new System.Drawing.Size(156, 38);
            this.D4.TabIndex = 5;
            this.D4.Text = "4";
            this.D4.UseVisualStyleBackColor = false;
            this.D4.Click += new System.EventHandler(this.FinalDigitClick);
            this.D4.MouseEnter += new System.EventHandler(this.ButtonMouseOver);
            this.D4.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // D3
            // 
            this.D3.BackColor = System.Drawing.Color.White;
            this.D3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.D3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.D3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.D3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.D3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D3.Location = new System.Drawing.Point(987, 309);
            this.D3.Name = "D3";
            this.D3.Size = new System.Drawing.Size(156, 38);
            this.D3.TabIndex = 1041;
            this.D3.Text = "3";
            this.D3.UseVisualStyleBackColor = false;
            this.D3.Click += new System.EventHandler(this.FinalDigitClick);
            this.D3.MouseEnter += new System.EventHandler(this.ButtonMouseOver);
            this.D3.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // D2
            // 
            this.D2.BackColor = System.Drawing.Color.White;
            this.D2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.D2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.D2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.D2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.D2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D2.Location = new System.Drawing.Point(826, 309);
            this.D2.Name = "D2";
            this.D2.Size = new System.Drawing.Size(156, 38);
            this.D2.TabIndex = 1040;
            this.D2.Text = "2";
            this.D2.UseVisualStyleBackColor = false;
            this.D2.Click += new System.EventHandler(this.FinalDigitClick);
            this.D2.MouseEnter += new System.EventHandler(this.ButtonMouseOver);
            this.D2.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // D1
            // 
            this.D1.BackColor = System.Drawing.Color.White;
            this.D1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.D1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.D1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.D1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.D1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.D1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D1.Location = new System.Drawing.Point(665, 309);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(156, 38);
            this.D1.TabIndex = 3;
            this.D1.Text = "1";
            this.D1.UseVisualStyleBackColor = false;
            this.D1.Click += new System.EventHandler(this.FinalDigitClick);
            this.D1.MouseEnter += new System.EventHandler(this.ButtonMouseOver);
            this.D1.MouseLeave += new System.EventHandler(this.ButtonMouseLeave);
            // 
            // cmdPrintBill
            // 
            this.cmdPrintBill.BackColor = System.Drawing.Color.White;
            this.cmdPrintBill.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cmdPrintBill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.cmdPrintBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.cmdPrintBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPrintBill.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPrintBill.Location = new System.Drawing.Point(826, 498);
            this.cmdPrintBill.Name = "cmdPrintBill";
            this.cmdPrintBill.Size = new System.Drawing.Size(155, 104);
            this.cmdPrintBill.TabIndex = 18;
            this.cmdPrintBill.Text = "&Print Bill";
            this.cmdPrintBill.UseVisualStyleBackColor = false;
            // 
            // txtPaid
            // 
            this.txtPaid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPaid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPaid.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaid.Location = new System.Drawing.Point(874, 76);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(269, 57);
            this.txtPaid.TabIndex = 1;
            this.txtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPaid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaid_KeyDown);
            this.txtPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaid_KeyPress);
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label99.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.ForeColor = System.Drawing.Color.DarkGray;
            this.label99.Location = new System.Drawing.Point(657, 82);
            this.label99.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(171, 45);
            this.label99.TabIndex = 1036;
            this.label99.Text = "Charged";
            this.label99.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalBill.Font = new System.Drawing.Font("Lucida Sans Unicode", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBill.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTotalBill.Location = new System.Drawing.Point(874, 9);
            this.lblTotalBill.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalBill.Name = "lblTotalBill";
            this.lblTotalBill.Size = new System.Drawing.Size(284, 54);
            this.lblTotalBill.TabIndex = 1035;
            this.lblTotalBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Label11.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.DarkGray;
            this.Label11.Location = new System.Drawing.Point(657, 14);
            this.Label11.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(111, 45);
            this.Label11.TabIndex = 1033;
            this.Label11.Text = "Total";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFinalDiscount
            // 
            this.lblFinalDiscount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFinalDiscount.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalDiscount.ForeColor = System.Drawing.Color.Red;
            this.lblFinalDiscount.Location = new System.Drawing.Point(251, 574);
            this.lblFinalDiscount.Name = "lblFinalDiscount";
            this.lblFinalDiscount.Size = new System.Drawing.Size(158, 16);
            this.lblFinalDiscount.TabIndex = 1032;
            this.lblFinalDiscount.Text = "0.00";
            this.lblFinalDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.Color.Red;
            this.Label13.Location = new System.Drawing.Point(8, 574);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(156, 16);
            this.Label13.TabIndex = 1031;
            this.Label13.Text = "Discount :";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFinalCharges
            // 
            this.lblFinalCharges.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFinalCharges.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalCharges.ForeColor = System.Drawing.Color.Red;
            this.lblFinalCharges.Location = new System.Drawing.Point(251, 558);
            this.lblFinalCharges.Name = "lblFinalCharges";
            this.lblFinalCharges.Size = new System.Drawing.Size(158, 16);
            this.lblFinalCharges.TabIndex = 1030;
            this.lblFinalCharges.Text = "0.00";
            this.lblFinalCharges.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label12
            // 
            this.Label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.Color.Red;
            this.Label12.Location = new System.Drawing.Point(8, 558);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(156, 16);
            this.Label12.TabIndex = 1029;
            this.Label12.Text = "Service Charges :";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFinalWaiter
            // 
            this.lblFinalWaiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFinalWaiter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalWaiter.ForeColor = System.Drawing.Color.Gray;
            this.lblFinalWaiter.Location = new System.Drawing.Point(87, 77);
            this.lblFinalWaiter.Name = "lblFinalWaiter";
            this.lblFinalWaiter.Size = new System.Drawing.Size(322, 20);
            this.lblFinalWaiter.TabIndex = 1027;
            this.lblFinalWaiter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.ForeColor = System.Drawing.Color.Gray;
            this.Label14.Location = new System.Drawing.Point(8, 77);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(79, 20);
            this.Label14.TabIndex = 1026;
            this.Label14.Text = "Waiter :";
            // 
            // lblFinalBill
            // 
            this.lblFinalBill.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFinalBill.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalBill.ForeColor = System.Drawing.Color.Red;
            this.lblFinalBill.Location = new System.Drawing.Point(251, 542);
            this.lblFinalBill.Name = "lblFinalBill";
            this.lblFinalBill.Size = new System.Drawing.Size(158, 16);
            this.lblFinalBill.TabIndex = 1023;
            this.lblFinalBill.Text = "0.00";
            this.lblFinalBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label16
            // 
            this.Label16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.ForeColor = System.Drawing.Color.Red;
            this.Label16.Location = new System.Drawing.Point(8, 542);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(156, 16);
            this.Label16.TabIndex = 1020;
            this.Label16.Text = "Sub Total :";
            this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFinalSequence
            // 
            this.lblFinalSequence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFinalSequence.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalSequence.ForeColor = System.Drawing.Color.Gray;
            this.lblFinalSequence.Location = new System.Drawing.Point(165, 14);
            this.lblFinalSequence.Name = "lblFinalSequence";
            this.lblFinalSequence.Size = new System.Drawing.Size(244, 20);
            this.lblFinalSequence.TabIndex = 1019;
            this.lblFinalSequence.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFinalCustomer
            // 
            this.lblFinalCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFinalCustomer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalCustomer.ForeColor = System.Drawing.Color.Gray;
            this.lblFinalCustomer.Location = new System.Drawing.Point(87, 56);
            this.lblFinalCustomer.Name = "lblFinalCustomer";
            this.lblFinalCustomer.Size = new System.Drawing.Size(322, 20);
            this.lblFinalCustomer.TabIndex = 1025;
            this.lblFinalCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFinalStatus
            // 
            this.lblFinalStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFinalStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblFinalStatus.Location = new System.Drawing.Point(87, 35);
            this.lblFinalStatus.Name = "lblFinalStatus";
            this.lblFinalStatus.Size = new System.Drawing.Size(322, 20);
            this.lblFinalStatus.TabIndex = 1022;
            this.lblFinalStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFinalTable
            // 
            this.lblFinalTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFinalTable.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalTable.ForeColor = System.Drawing.Color.Gray;
            this.lblFinalTable.Location = new System.Drawing.Point(87, 14);
            this.lblFinalTable.Name = "lblFinalTable";
            this.lblFinalTable.Size = new System.Drawing.Size(79, 20);
            this.lblFinalTable.TabIndex = 1018;
            this.lblFinalTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label21
            // 
            this.Label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label21.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label21.ForeColor = System.Drawing.Color.Gray;
            this.Label21.Location = new System.Drawing.Point(8, 56);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(79, 20);
            this.Label21.TabIndex = 1024;
            this.Label21.Text = "Customer :";
            // 
            // Label22
            // 
            this.Label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label22.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label22.ForeColor = System.Drawing.Color.Gray;
            this.Label22.Location = new System.Drawing.Point(8, 35);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(79, 20);
            this.Label22.TabIndex = 1021;
            this.Label22.Text = "Status :";
            // 
            // Label23
            // 
            this.Label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label23.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label23.ForeColor = System.Drawing.Color.Gray;
            this.Label23.Location = new System.Drawing.Point(8, 14);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(79, 20);
            this.Label23.TabIndex = 1017;
            this.Label23.Text = "Table : ";
            // 
            // dgvFinalBill
            // 
            this.dgvFinalBill.AllowUserToAddRows = false;
            this.dgvFinalBill.AllowUserToResizeColumns = false;
            this.dgvFinalBill.AllowUserToResizeRows = false;
            this.dgvFinalBill.AutoGenerateColumns = false;
            this.dgvFinalBill.BackgroundColor = System.Drawing.Color.White;
            this.dgvFinalBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFinalBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvFinalBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFinalBill.ColumnHeadersHeight = 22;
            this.dgvFinalBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFinalBill.ColumnHeadersVisible = false;
            this.dgvFinalBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn1,
            this.DataGridViewTextBoxColumn2,
            this.DataGridViewTextBoxColumn3});
            this.dgvFinalBill.DataSource = this.FinalBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFinalBill.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFinalBill.Location = new System.Drawing.Point(8, 100);
            this.dgvFinalBill.Name = "dgvFinalBill";
            this.dgvFinalBill.ReadOnly = true;
            this.dgvFinalBill.RowHeadersVisible = false;
            this.dgvFinalBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinalBill.Size = new System.Drawing.Size(401, 436);
            this.dgvFinalBill.TabIndex = 0;
            this.dgvFinalBill.TabStop = false;
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.DataPropertyName = "QTY";
            this.DataGridViewTextBoxColumn1.HeaderText = "Qty";
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.ReadOnly = true;
            this.DataGridViewTextBoxColumn1.Width = 50;
            // 
            // DataGridViewTextBoxColumn2
            // 
            this.DataGridViewTextBoxColumn2.DataPropertyName = "STOCKDESC";
            this.DataGridViewTextBoxColumn2.HeaderText = "Description";
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.ReadOnly = true;
            this.DataGridViewTextBoxColumn2.Width = 220;
            // 
            // DataGridViewTextBoxColumn3
            // 
            this.DataGridViewTextBoxColumn3.DataPropertyName = "PRICE";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.DataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewTextBoxColumn3.HeaderText = "Sub Total";
            this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            this.DataGridViewTextBoxColumn3.ReadOnly = true;
            this.DataGridViewTextBoxColumn3.Width = 130;
            // 
            // FinalBindingSource
            // 
            this.FinalBindingSource.DataSource = this.FinalDataSet;
            this.FinalBindingSource.Position = 0;
            // 
            // FinalDataSet
            // 
            this.FinalDataSet.DataSetName = "FinalDataSet";
            // 
            // ShapeContainer1
            // 
            this.ShapeContainer1.Location = new System.Drawing.Point(3, 3);
            this.ShapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.ShapeContainer1.Name = "ShapeContainer1";
            this.ShapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.LineShape2,
            this.LineShape1});
            this.ShapeContainer1.Size = new System.Drawing.Size(1154, 620);
            this.ShapeContainer1.TabIndex = 1034;
            this.ShapeContainer1.TabStop = false;
            // 
            // LineShape2
            // 
            this.LineShape2.BorderColor = System.Drawing.Color.Gray;
            this.LineShape2.Name = "LineShape2";
            this.LineShape2.X1 = 871;
            this.LineShape2.X2 = 1140;
            this.LineShape2.Y1 = 133;
            this.LineShape2.Y2 = 133;
            // 
            // LineShape1
            // 
            this.LineShape1.BorderColor = System.Drawing.Color.Gray;
            this.LineShape1.Name = "LineShape1";
            this.LineShape1.X1 = 871;
            this.LineShape1.X2 = 1140;
            this.LineShape1.Y1 = 66;
            this.LineShape1.Y2 = 66;
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "Breakfast-icon.png");
            this.ImageList1.Images.SetKeyName(1, "1487899091_ordering.png");
            this.ImageList1.Images.SetKeyName(2, "Money-641.png");
            this.ImageList1.Images.SetKeyName(3, "People-64.png");
            this.ImageList1.Images.SetKeyName(4, "1487123129_Sales-by-Payment-Method-rep.png");
            this.ImageList1.Images.SetKeyName(5, "Money-64.png");
            this.ImageList1.Images.SetKeyName(6, "terrace.png");
            // 
            // DineTableMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 669);
            this.Controls.Add(this.TabDine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DineTableMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dining Hall";
            this.Load += new System.EventHandler(this.frmDineTable_Load);
            this.Click += new System.EventHandler(this.ItemButton);
            this.TabDine.ResumeLayout(false);
            this.tabReservation.ResumeLayout(false);
            this.tabCheckIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SaleDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordDataSet)).EndInit();
            this.tabCustomer.ResumeLayout(false);
            this.tabCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.tabCheckOut.ResumeLayout(false);
            this.tabCheckOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalDataSet)).EndInit();
            this.ResumeLayout(false);

        }
        internal TabControl TabDine;
        internal TabPage tabReservation;
        internal TabPage tabCheckIn;
        internal TabPage tabCustomer;
        internal TabPage tabCheckOut;
        internal ImageList ImageList1;
        internal Button B01;
        internal Button B03;
        internal Button B04;
        internal Button B05;
        internal Button B06;
        internal Button B07;
        internal Button B08;
        internal Button B09;
        internal Button B02;
        internal Button B12;
        internal Button B11;
        internal Button B10;
        internal Button B18;
        internal Button B17;
        internal Button B16;
        internal Button B13;
        internal Button B14;
        internal Button B15;
        internal Button cmdExit;
        internal Button H5;
        internal Button H4;
        internal Button H1;
        internal Button H2;
        internal Button H3;
        internal Button P12;
        internal Button P11;
        internal Button P10;
        internal Button P3;
        internal Button P4;
        internal Button P5;
        internal Button P6;
        internal Button P7;
        internal Button P8;
        internal Button P9;
        internal Button P2;
        internal Button P1;
        internal Label label1;
        internal Button cmdCustomer;
        internal Button cmdPrint;
        internal Button cmdSettle;
        internal Button cmdClose;
        internal Label label3;
        internal Label label2;
        internal FlowLayoutPanel GroupFlowPanel;
        internal FlowLayoutPanel ItemFlowPanel;
        internal Button cmdClear;
        internal Label lblDisplay;
        internal Button cmdBack;
        internal Button Num0;
        internal Button NumFriction;
        internal Button Num9;
        internal Button Num8;
        internal Button Num7;
        internal Button Num6;
        internal Button Num5;
        internal Button Num4;
        internal Button Num3;
        internal Button Num2;
        internal Button Num1;
        internal Button cmdChange;
        internal Button cmdVoid;
        internal Label lblCustomer;
        internal Label lblStatus;
        internal Label lblTable;
        internal DataGridView SaleDataGrid;
        internal BindingSource SaleBindingSource;
        internal DataSet RecordDataSet;
        internal Button cmdWaiter;
        internal Label OrderNo;
        internal Label SequenceNo;
        internal Label lblOrgPrice;
        internal Label Label5;
        internal Label lblWaiter;
        internal Label Label6;
        internal Label Label4;
        internal Label Label7;
        internal DataGridViewTextBoxColumn colQuantity;
        internal DataGridViewTextBoxColumn colDescription;
        internal DataGridViewTextBoxColumn colSubTotal;
        internal Label lblTaxes;
        internal Label Label9;
        internal TextBox txtSearch;
        internal Label Label8;
        internal Button cmdEdit;
        internal Button cmdDelete;
        internal Button cmdSelect;
        internal Button cmdNew;
        internal TextBox txtPhone;
        internal TextBox txtName;
        internal Label Label10;
        internal Button cmdCancel;
        internal DataGridView dgvCustomer;
        internal DataGridViewTextBoxColumn ColName;
        internal DataGridViewTextBoxColumn colPhone;
        internal BindingSource FinalBindingSource;
        internal DataSet FinalDataSet;
        internal Label lblFinalCharges;
        internal Label Label12;
        internal Label lblFinalWaiter;
        internal Label Label14;
        internal Label lblFinalBill;
        internal Label Label16;
        internal Label lblFinalSequence;
        internal Label lblFinalCustomer;
        internal Label lblFinalStatus;
        internal Label lblFinalTable;
        internal Label Label21;
        internal Label Label22;
        internal Label Label23;
        internal DataGridView dgvFinalBill;
        internal Label Label11;
        internal Label lblFinalDiscount;
        internal Label Label13;
        internal Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
        internal Microsoft.VisualBasic.PowerPacks.LineShape LineShape1;
        internal Label lblTotalBill;
        internal Label label99;
        internal Microsoft.VisualBasic.PowerPacks.LineShape LineShape2;
        internal TextBox txtPaid;
        internal Button cmdPrintBill;
        internal Button cmdBackSpace;
        internal Button D0;
        internal Button D9;
        internal Button D8;
        internal Button D7;
        internal Button D6;
        internal Button D5;
        internal Button D4;
        internal Button D3;
        internal Button D2;
        internal Button D1;
        internal Label lblRefund;
        internal Label Label17;
        internal Button cmdCloseBack;
        internal Button cmdClearDisplay;
        internal Button cmdDiscPaid;
        internal Button cmdDiscount;
        internal Button cmdRefreshBill;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        internal Label lblDue;
        internal Label Label18;
        internal Button cmdPaid;
        internal Label lblFinalOrderNo;
        internal Label Label19;
        internal Label Label20;
    }
}