namespace _19._05
{
	partial class LoginForm
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
			this.Log = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.APanelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Log
			// 
			this.Log.Location = new System.Drawing.Point(16, 112);
			this.Log.Name = "Log";
			this.Log.Size = new System.Drawing.Size(75, 23);
			this.Log.TabIndex = 0;
			this.Log.Text = "Вход";
			this.Log.UseVisualStyleBackColor = true;
			this.Log.Click += new System.EventHandler(this.Log_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Логин";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(4, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Пароль:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(58, 27);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(213, 20);
			this.textBox1.TabIndex = 4;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(58, 56);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(213, 20);
			this.textBox2.TabIndex = 5;
			this.textBox2.UseSystemPasswordChar = true;
			// 
			// APanelButton
			// 
			this.APanelButton.Location = new System.Drawing.Point(182, 111);
			this.APanelButton.Name = "APanelButton";
			this.APanelButton.Size = new System.Drawing.Size(89, 23);
			this.APanelButton.TabIndex = 6;
			this.APanelButton.Text = "Админ-панель";
			this.APanelButton.UseVisualStyleBackColor = true;
			this.APanelButton.Click += new System.EventHandler(this.APanelButton_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(283, 168);
			this.Controls.Add(this.APanelButton);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Log);
			this.MaximizeBox = false;
			this.Name = "LoginForm";
			this.Text = "Вход в систему";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Log;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button APanelButton;
	}
}

