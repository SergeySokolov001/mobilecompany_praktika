﻿namespace _19._05
{
	partial class AForm
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.reload = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(3, 40);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(795, 342);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(10, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = " ";
			// 
			// reload
			// 
			this.reload.Location = new System.Drawing.Point(13, 388);
			this.reload.Name = "reload";
			this.reload.Size = new System.Drawing.Size(197, 50);
			this.reload.TabIndex = 2;
			this.reload.Text = "Обновить данные";
			this.reload.UseVisualStyleBackColor = true;
			this.reload.Click += new System.EventHandler(this.reload_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(227, 388);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(197, 50);
			this.button1.TabIndex = 3;
			this.button1.Text = "Удалить выбранную строку";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(440, 388);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(197, 50);
			this.button2.TabIndex = 4;
			this.button2.Text = "Добавить пользователя";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// AForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.reload);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.MaximizeBox = false;
			this.Name = "AForm";
			this.Text = "Админ панель";
			this.Load += new System.EventHandler(this.AForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button reload;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}