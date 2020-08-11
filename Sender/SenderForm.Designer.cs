namespace Sender
{
	partial class SenderForm
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
			this.tabControlContracts = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDownCaseId = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownCaseIdType = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxLpuId = new System.Windows.Forms.TextBox();
			this.dateTimePickerCloseDate = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxPatientId = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxDiagnosis = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxMessage = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.buttonSend = new System.Windows.Forms.Button();
			this.tabControlContracts.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCaseId)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCaseIdType)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControlContracts
			// 
			this.tabControlContracts.Controls.Add(this.tabPage1);
			this.tabControlContracts.Controls.Add(this.tabPage2);
			this.tabControlContracts.Location = new System.Drawing.Point(12, 12);
			this.tabControlContracts.Name = "tabControlContracts";
			this.tabControlContracts.SelectedIndex = 0;
			this.tabControlContracts.Size = new System.Drawing.Size(356, 232);
			this.tabControlContracts.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.textBoxMessage);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(348, 206);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "MessageTextContract";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.textBoxDiagnosis);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.textBoxPatientId);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.dateTimePickerCloseDate);
			this.tabPage2.Controls.Add(this.textBoxLpuId);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.numericUpDownCaseIdType);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.numericUpDownCaseId);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(348, 206);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "SormoNewCaseContract";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "CaseId";
			// 
			// numericUpDownCasId
			// 
			this.numericUpDownCaseId.Location = new System.Drawing.Point(91, 16);
			this.numericUpDownCaseId.Name = "numericUpDownCaseId";
			this.numericUpDownCaseId.Size = new System.Drawing.Size(235, 20);
			this.numericUpDownCaseId.TabIndex = 1;
			// 
			// numericUpDownCaseIdType
			// 
			this.numericUpDownCaseIdType.Location = new System.Drawing.Point(91, 42);
			this.numericUpDownCaseIdType.Name = "numericUpDownCaseIdType";
			this.numericUpDownCaseIdType.Size = new System.Drawing.Size(235, 20);
			this.numericUpDownCaseIdType.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "CaseTypeId";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "LpuId";
			// 
			// textBoxLpuId
			// 
			this.textBoxLpuId.Location = new System.Drawing.Point(91, 69);
			this.textBoxLpuId.Name = "textBoxLpuId";
			this.textBoxLpuId.Size = new System.Drawing.Size(235, 20);
			this.textBoxLpuId.TabIndex = 5;
			// 
			// dateTimePickerCloseDate
			// 
			this.dateTimePickerCloseDate.Location = new System.Drawing.Point(91, 96);
			this.dateTimePickerCloseDate.Name = "dateTimePickerCloseDate";
			this.dateTimePickerCloseDate.Size = new System.Drawing.Size(235, 20);
			this.dateTimePickerCloseDate.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(19, 102);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "CloseDate";
			// 
			// textBoxPatientId
			// 
			this.textBoxPatientId.Location = new System.Drawing.Point(91, 122);
			this.textBoxPatientId.Name = "textBoxPatientId";
			this.textBoxPatientId.Size = new System.Drawing.Size(235, 20);
			this.textBoxPatientId.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(19, 125);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "PatientId";
			// 
			// textBoxDiagnosis
			// 
			this.textBoxDiagnosis.Location = new System.Drawing.Point(91, 148);
			this.textBoxDiagnosis.Name = "textBoxDiagnosis";
			this.textBoxDiagnosis.Size = new System.Drawing.Size(235, 20);
			this.textBoxDiagnosis.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(19, 151);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Diagnosis";
			// 
			// textBoxMessage
			// 
			this.textBoxMessage.Location = new System.Drawing.Point(81, 19);
			this.textBoxMessage.Multiline = true;
			this.textBoxMessage.Name = "textBoxMessage";
			this.textBoxMessage.Size = new System.Drawing.Size(244, 89);
			this.textBoxMessage.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(9, 22);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Message";
			// 
			// buttonSend
			// 
			this.buttonSend.Location = new System.Drawing.Point(409, 221);
			this.buttonSend.Name = "buttonSend";
			this.buttonSend.Size = new System.Drawing.Size(89, 23);
			this.buttonSend.TabIndex = 1;
			this.buttonSend.Text = "Отправить";
			this.buttonSend.UseVisualStyleBackColor = true;
			this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
			// 
			// SenderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(524, 266);
			this.Controls.Add(this.buttonSend);
			this.Controls.Add(this.tabControlContracts);
			this.Name = "SenderForm";
			this.Text = "Sender";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SenderForm_FormClosed);
			this.tabControlContracts.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCaseId)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCaseIdType)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControlContracts;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDownCaseIdType;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDownCaseId;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dateTimePickerCloseDate;
		private System.Windows.Forms.TextBox textBoxLpuId;
		private System.Windows.Forms.TextBox textBoxPatientId;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxDiagnosis;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxMessage;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button buttonSend;
	}
}

