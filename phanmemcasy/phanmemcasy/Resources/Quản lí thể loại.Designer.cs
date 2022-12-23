namespace phanmemcasy.Resources
{
    partial class frm_theloai
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txTenCS = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txMaCS = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gwCaSi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txTenCS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txMaCS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwCaSi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_del);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txTenCS);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txMaCS);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(66, 38);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(525, 257);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Thông tin Thể Loại";
            // 
            // btn_del
            // 
            this.btn_del.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Appearance.Options.UseFont = true;
            this.btn_del.Location = new System.Drawing.Point(322, 169);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(104, 60);
            this.btn_del.TabIndex = 6;
            this.btn_del.Text = "Xóa";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Location = new System.Drawing.Point(183, 169);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(105, 60);
            this.simpleButton3.TabIndex = 7;
            this.simpleButton3.Text = "Sửa";
            // 
            // simpleButton1
            // 
            this.simpleButton1.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.BackgroundImage = global::phanmemcasy.Properties.Resources.tải_xuống;
            this.simpleButton1.Location = new System.Drawing.Point(63, 169);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(103, 60);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Thêm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(164, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(160, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "*";
            // 
            // txTenCS
            // 
            this.txTenCS.Location = new System.Drawing.Point(223, 124);
            this.txTenCS.Name = "txTenCS";
            this.txTenCS.Size = new System.Drawing.Size(255, 22);
            this.txTenCS.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(52, 123);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(106, 22);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên Thể Loại";
            // 
            // txMaCS
            // 
            this.txMaCS.Location = new System.Drawing.Point(223, 80);
            this.txMaCS.Name = "txMaCS";
            this.txMaCS.Size = new System.Drawing.Size(255, 22);
            this.txMaCS.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(52, 79);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 22);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mã Thể Loại";
            // 
            // gwCaSi
            // 
            this.gwCaSi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gwCaSi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwCaSi.Location = new System.Drawing.Point(634, 38);
            this.gwCaSi.Name = "gwCaSi";
            this.gwCaSi.RowHeadersWidth = 51;
            this.gwCaSi.RowTemplate.Height = 24;
            this.gwCaSi.Size = new System.Drawing.Size(443, 257);
            this.gwCaSi.TabIndex = 6;
            // 
            // frm_theloai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gwCaSi);
            this.Controls.Add(this.groupControl1);
            this.Name = "frm_theloai";
            this.Size = new System.Drawing.Size(1141, 408);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txTenCS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txMaCS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwCaSi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_del;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txTenCS;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txMaCS;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridView gwCaSi;
    }
}
