namespace Parser
{
	partial class FormMain
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.ListTitles = new System.Windows.Forms.ListBox();
			this.LabelStartPoint = new System.Windows.Forms.Label();
			this.NumericStartPoint = new System.Windows.Forms.NumericUpDown();
			this.NumericEndPoint = new System.Windows.Forms.NumericUpDown();
			this.LabelEndPoint = new System.Windows.Forms.Label();
			this.ButtonStart = new System.Windows.Forms.Button();
			this.ButtonAbort = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.NumericStartPoint)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericEndPoint)).BeginInit();
			this.SuspendLayout();
			// 
			// ListTitles
			// 
			this.ListTitles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ListTitles.FormattingEnabled = true;
			this.ListTitles.Location = new System.Drawing.Point(12, 12);
			this.ListTitles.Name = "ListTitles";
			this.ListTitles.Size = new System.Drawing.Size(365, 225);
			this.ListTitles.TabIndex = 0;
			// 
			// LabelStartPoint
			// 
			this.LabelStartPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelStartPoint.AutoSize = true;
			this.LabelStartPoint.Location = new System.Drawing.Point(380, 13);
			this.LabelStartPoint.Name = "LabelStartPoint";
			this.LabelStartPoint.Size = new System.Drawing.Size(56, 13);
			this.LabelStartPoint.TabIndex = 1;
			this.LabelStartPoint.Text = "Start Point";
			// 
			// NumericStartPoint
			// 
			this.NumericStartPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NumericStartPoint.Location = new System.Drawing.Point(383, 29);
			this.NumericStartPoint.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NumericStartPoint.Name = "NumericStartPoint";
			this.NumericStartPoint.Size = new System.Drawing.Size(120, 20);
			this.NumericStartPoint.TabIndex = 2;
			this.NumericStartPoint.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// NumericEndPoint
			// 
			this.NumericEndPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NumericEndPoint.Location = new System.Drawing.Point(383, 80);
			this.NumericEndPoint.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NumericEndPoint.Name = "NumericEndPoint";
			this.NumericEndPoint.Size = new System.Drawing.Size(120, 20);
			this.NumericEndPoint.TabIndex = 4;
			this.NumericEndPoint.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// LabelEndPoint
			// 
			this.LabelEndPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelEndPoint.AutoSize = true;
			this.LabelEndPoint.Location = new System.Drawing.Point(380, 64);
			this.LabelEndPoint.Name = "LabelEndPoint";
			this.LabelEndPoint.Size = new System.Drawing.Size(53, 13);
			this.LabelEndPoint.TabIndex = 3;
			this.LabelEndPoint.Text = "End Point";
			// 
			// ButtonStart
			// 
			this.ButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonStart.Location = new System.Drawing.Point(383, 116);
			this.ButtonStart.Name = "ButtonStart";
			this.ButtonStart.Size = new System.Drawing.Size(120, 32);
			this.ButtonStart.TabIndex = 5;
			this.ButtonStart.Text = "Start";
			this.ButtonStart.UseVisualStyleBackColor = true;
			this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
			// 
			// ButtonAbort
			// 
			this.ButtonAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonAbort.Location = new System.Drawing.Point(383, 154);
			this.ButtonAbort.Name = "ButtonAbort";
			this.ButtonAbort.Size = new System.Drawing.Size(120, 32);
			this.ButtonAbort.TabIndex = 6;
			this.ButtonAbort.Text = "Abort";
			this.ButtonAbort.UseVisualStyleBackColor = true;
			this.ButtonAbort.Click += new System.EventHandler(this.ButtonAbort_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(510, 246);
			this.Controls.Add(this.ButtonAbort);
			this.Controls.Add(this.ButtonStart);
			this.Controls.Add(this.NumericEndPoint);
			this.Controls.Add(this.LabelEndPoint);
			this.Controls.Add(this.NumericStartPoint);
			this.Controls.Add(this.LabelStartPoint);
			this.Controls.Add(this.ListTitles);
			this.Name = "FormMain";
			this.Text = "Parser";
			((System.ComponentModel.ISupportInitialize)(this.NumericStartPoint)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericEndPoint)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox ListTitles;
		private System.Windows.Forms.Label LabelStartPoint;
		private System.Windows.Forms.NumericUpDown NumericStartPoint;
		private System.Windows.Forms.NumericUpDown NumericEndPoint;
		private System.Windows.Forms.Label LabelEndPoint;
		private System.Windows.Forms.Button ButtonStart;
		private System.Windows.Forms.Button ButtonAbort;
	}
}

