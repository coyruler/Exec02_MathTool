namespace 單一乘法表
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.btnCaculate = new System.Windows.Forms.Button();
			this.txtForm = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
			this.comboBox1.Location = new System.Drawing.Point(12, 32);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 20);
			this.comboBox1.TabIndex = 0;
			// 
			// btnCaculate
			// 
			this.btnCaculate.Location = new System.Drawing.Point(139, 30);
			this.btnCaculate.Name = "btnCaculate";
			this.btnCaculate.Size = new System.Drawing.Size(75, 23);
			this.btnCaculate.TabIndex = 1;
			this.btnCaculate.Text = "產生";
			this.btnCaculate.UseVisualStyleBackColor = true;
			this.btnCaculate.Click += new System.EventHandler(this.btnCaculate_Click);
			// 
			// txtForm
			// 
			this.txtForm.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtForm.Location = new System.Drawing.Point(12, 67);
			this.txtForm.Multiline = true;
			this.txtForm.Name = "txtForm";
			this.txtForm.Size = new System.Drawing.Size(202, 222);
			this.txtForm.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(231, 316);
			this.Controls.Add(this.txtForm);
			this.Controls.Add(this.btnCaculate);
			this.Controls.Add(this.comboBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(251, 359);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(251, 359);
			this.Name = "Form1";
			this.Text = "單一乘法表";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button btnCaculate;
		private System.Windows.Forms.TextBox txtForm;
	}
}

