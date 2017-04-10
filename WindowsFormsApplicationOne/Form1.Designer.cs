namespace WindowsFormsApplicationOne
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
            this.gridView = new System.Windows.Forms.DataGridView();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAllowedEffect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDrag = new System.Windows.Forms.Button();
            this.btnHdrop = new System.Windows.Forms.Button();
            this.btnIneturl = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.AllowDrop = true;
            this.gridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colType,
            this.colAllowedEffect,
            this.colDataType,
            this.colData});
            this.gridView.Location = new System.Drawing.Point(12, 12);
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(606, 305);
            this.gridView.TabIndex = 0;
            this.gridView.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.gridView.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // colType
            // 
            this.colType.HeaderText = "MIME";
            this.colType.Name = "colType";
            // 
            // colAllowedEffect
            // 
            this.colAllowedEffect.HeaderText = "AllowedEffect";
            this.colAllowedEffect.Name = "colAllowedEffect";
            // 
            // colDataType
            // 
            this.colDataType.HeaderText = "Type";
            this.colDataType.Name = "colDataType";
            // 
            // colData
            // 
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            // 
            // btnDrag
            // 
            this.btnDrag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDrag.Location = new System.Drawing.Point(624, 12);
            this.btnDrag.Name = "btnDrag";
            this.btnDrag.Size = new System.Drawing.Size(146, 41);
            this.btnDrag.TabIndex = 1;
            this.btnDrag.Text = "Both";
            this.btnDrag.UseVisualStyleBackColor = true;
            this.btnDrag.Click += new System.EventHandler(this.btnDrag_Click);
            this.btnDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDrag_MouseDown);
            // 
            // btnHdrop
            // 
            this.btnHdrop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHdrop.Location = new System.Drawing.Point(624, 59);
            this.btnHdrop.Name = "btnHdrop";
            this.btnHdrop.Size = new System.Drawing.Size(146, 41);
            this.btnHdrop.TabIndex = 2;
            this.btnHdrop.Text = "HDrop";
            this.btnHdrop.UseVisualStyleBackColor = true;
            this.btnHdrop.Click += new System.EventHandler(this.btnHdrop_Click);
            this.btnHdrop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHdrop_MouseDown);
            // 
            // btnIneturl
            // 
            this.btnIneturl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIneturl.Location = new System.Drawing.Point(624, 106);
            this.btnIneturl.Name = "btnIneturl";
            this.btnIneturl.Size = new System.Drawing.Size(146, 41);
            this.btnIneturl.TabIndex = 3;
            this.btnIneturl.Text = "INetUrl";
            this.btnIneturl.UseVisualStyleBackColor = true;
            this.btnIneturl.Click += new System.EventHandler(this.btnIneturl_Click);
            this.btnIneturl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnIneturl_MouseDown);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(624, 276);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(146, 41);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 329);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnIneturl);
            this.Controls.Add(this.btnHdrop);
            this.Controls.Add(this.btnDrag);
            this.Controls.Add(this.gridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Button btnDrag;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAllowedEffect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.Button btnHdrop;
        private System.Windows.Forms.Button btnIneturl;
        private System.Windows.Forms.Button btnClear;
    }
}

