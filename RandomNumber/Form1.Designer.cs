namespace RandomNumber
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			groupBox1 = new GroupBox();
			button1 = new Button();
			textBox1 = new TextBox();
			label2 = new Label();
			button2 = new Button();
			listBox1 = new ListBox();
			errorProvider1 = new ErrorProvider(components);
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(button1);
			groupBox1.Controls.Add(textBox1);
			groupBox1.Controls.Add(label2);
			groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			groupBox1.ForeColor = SystemColors.Control;
			groupBox1.Location = new Point(116, 75);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(250, 216);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Ədəd axtarışı";
			groupBox1.Enter += groupBox1_Enter;
			// 
			// button1
			// 
			button1.ForeColor = SystemColors.ActiveCaptionText;
			button1.Location = new Point(37, 138);
			button1.Name = "button1";
			button1.Size = new Size(171, 37);
			button1.TabIndex = 3;
			button1.Text = "Yoxla";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(37, 69);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(171, 27);
			textBox1.TabIndex = 2;
			textBox1.TextChanged += textBox1_TextChanged;
			textBox1.KeyPress += textBox1_KeyPress;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.ForeColor = SystemColors.ButtonHighlight;
			label2.Location = new Point(37, 37);
			label2.Name = "label2";
			label2.Size = new Size(106, 20);
			label2.TabIndex = 1;
			label2.Text = "Axtarılan ədəd";
			// 
			// button2
			// 
			button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button2.ForeColor = SystemColors.ActiveCaptionText;
			button2.Location = new Point(422, 256);
			button2.Name = "button2";
			button2.Size = new Size(191, 37);
			button2.TabIndex = 4;
			button2.Text = "Yeni oyun";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Location = new Point(422, 87);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(191, 154);
			listBox1.TabIndex = 5;
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.HotTrack;
			ClientSize = new Size(800, 450);
			Controls.Add(listBox1);
			Controls.Add(button2);
			Controls.Add(groupBox1);
			Name = "Form1";
			Text = "Form1";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private Label label2;
		private TextBox textBox1;
		private Button button1;
		private Button button2;
		private ListBox listBox1;
		private ErrorProvider errorProvider1;
	}
}
