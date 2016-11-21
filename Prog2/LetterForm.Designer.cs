namespace Prog2
{
    partial class LetterForm
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
            this.components = new System.ComponentModel.Container();
            this.origAddrLbl = new System.Windows.Forms.Label();
            this.destAddrLbl = new System.Windows.Forms.Label();
            this.costLbl = new System.Windows.Forms.Label();
            this.costInput = new System.Windows.Forms.TextBox();
            this.origAddrComboBox = new System.Windows.Forms.ComboBox();
            this.destAddrComboBox = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // origAddrLbl
            // 
            this.origAddrLbl.AutoSize = true;
            this.origAddrLbl.Location = new System.Drawing.Point(23, 23);
            this.origAddrLbl.Name = "origAddrLbl";
            this.origAddrLbl.Size = new System.Drawing.Size(78, 13);
            this.origAddrLbl.TabIndex = 0;
            this.origAddrLbl.Text = "Origin Address:";
            // 
            // destAddrLbl
            // 
            this.destAddrLbl.AutoSize = true;
            this.destAddrLbl.Location = new System.Drawing.Point(23, 71);
            this.destAddrLbl.Name = "destAddrLbl";
            this.destAddrLbl.Size = new System.Drawing.Size(104, 13);
            this.destAddrLbl.TabIndex = 1;
            this.destAddrLbl.Text = "Destination Address:";
            // 
            // costLbl
            // 
            this.costLbl.AutoSize = true;
            this.costLbl.Location = new System.Drawing.Point(23, 119);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(31, 13);
            this.costLbl.TabIndex = 2;
            this.costLbl.Text = "Cost:";
            // 
            // costInput
            // 
            this.costInput.Location = new System.Drawing.Point(151, 116);
            this.costInput.Name = "costInput";
            this.costInput.Size = new System.Drawing.Size(100, 20);
            this.costInput.TabIndex = 4;
            this.costInput.Validating += new System.ComponentModel.CancelEventHandler(this.costInput_Validating);
            this.costInput.Validated += new System.EventHandler(this.costInput_Validated);
            // 
            // origAddrComboBox
            // 
            this.origAddrComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.origAddrComboBox.FormattingEnabled = true;
            this.origAddrComboBox.Location = new System.Drawing.Point(151, 20);
            this.origAddrComboBox.Name = "origAddrComboBox";
            this.origAddrComboBox.Size = new System.Drawing.Size(100, 21);
            this.origAddrComboBox.TabIndex = 5;
            this.origAddrComboBox.ValueMemberChanged += new System.EventHandler(this.ComboBox_Validated);
            this.origAddrComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.origAddrComboBox_Validating);
            // 
            // destAddrComboBox
            // 
            this.destAddrComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destAddrComboBox.FormattingEnabled = true;
            this.destAddrComboBox.Location = new System.Drawing.Point(151, 68);
            this.destAddrComboBox.Name = "destAddrComboBox";
            this.destAddrComboBox.Size = new System.Drawing.Size(100, 21);
            this.destAddrComboBox.TabIndex = 6;
            this.destAddrComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.destAddrComboBox_Validating);
            this.destAddrComboBox.Validated += new System.EventHandler(this.ComboBox_Validated);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(36, 161);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add Letter";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(165, 161);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 196);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.destAddrComboBox);
            this.Controls.Add(this.origAddrComboBox);
            this.Controls.Add(this.costInput);
            this.Controls.Add(this.costLbl);
            this.Controls.Add(this.destAddrLbl);
            this.Controls.Add(this.origAddrLbl);
            this.Name = "LetterForm";
            this.Text = "LetterForm";
            this.Load += new System.EventHandler(this.LetterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label origAddrLbl;
        private System.Windows.Forms.Label destAddrLbl;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.TextBox costInput;
        private System.Windows.Forms.ComboBox origAddrComboBox;
        private System.Windows.Forms.ComboBox destAddrComboBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}