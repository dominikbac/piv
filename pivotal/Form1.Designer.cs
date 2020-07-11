namespace pivotal
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
            this.TopCustomers = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BestCustormerOrdersDetail = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // TopCustomers
            // 
            this.TopCustomers.Location = new System.Drawing.Point(27, 12);
            this.TopCustomers.Name = "TopCustomers";
            this.TopCustomers.Size = new System.Drawing.Size(177, 28);
            this.TopCustomers.TabIndex = 0;
            this.TopCustomers.Text = "TopCustomers";
            this.TopCustomers.UseVisualStyleBackColor = true;
            this.TopCustomers.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(177, 230);
            this.dataGridView1.TabIndex = 1;
            // 
            // BestCustormerOrdersDetail
            // 
            this.BestCustormerOrdersDetail.Location = new System.Drawing.Point(242, 12);
            this.BestCustormerOrdersDetail.Name = "BestCustormerOrdersDetail";
            this.BestCustormerOrdersDetail.Size = new System.Drawing.Size(171, 27);
            this.BestCustormerOrdersDetail.TabIndex = 2;
            this.BestCustormerOrdersDetail.Text = "BestCustormerOrdersDetail";
            this.BestCustormerOrdersDetail.UseVisualStyleBackColor = true;
            this.BestCustormerOrdersDetail.Click += new System.EventHandler(this.BestCustormerOrdersDetail_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(242, 58);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(537, 230);
            this.dataGridView2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.BestCustormerOrdersDetail);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TopCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TopCustomers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BestCustormerOrdersDetail;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

