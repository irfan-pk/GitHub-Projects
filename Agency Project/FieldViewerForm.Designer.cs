
namespace WholeSaleApplication
{
    partial class FieldViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FieldViewerForm));
            this.cbViewData = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbViewData
            // 
            this.cbViewData.BackColor = System.Drawing.Color.LightGray;
            this.cbViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbViewData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbViewData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbViewData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbViewData.FormattingEnabled = true;
            this.cbViewData.Location = new System.Drawing.Point(0, 0);
            this.cbViewData.Name = "cbViewData";
            this.cbViewData.Size = new System.Drawing.Size(311, 428);
            this.cbViewData.Sorted = true;
            this.cbViewData.TabIndex = 0;
            this.cbViewData.SelectedIndexChanged += new System.EventHandler(this.cbViewData_SelectedIndexChanged);
            // 
            // FieldViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 428);
            this.Controls.Add(this.cbViewData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FieldViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List View";
            this.Load += new System.EventHandler(this.FieldViewerForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FieldViewerForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FieldViewerForm_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbViewData;
    }
}