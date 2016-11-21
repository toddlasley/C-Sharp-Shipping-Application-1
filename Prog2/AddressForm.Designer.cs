namespace Prog2
{
    partial class AddressForm
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
            this.nameLbl = new System.Windows.Forms.Label();
            this.address1Lbl = new System.Windows.Forms.Label();
            this.address2Lbl = new System.Windows.Forms.Label();
            this.cityLbl = new System.Windows.Forms.Label();
            this.stateLbl = new System.Windows.Forms.Label();
            this.zipCodeLbl = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.address2Input = new System.Windows.Forms.TextBox();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.address1Input = new System.Windows.Forms.TextBox();
            this.zipCodeInput = new System.Windows.Forms.TextBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(12, 9);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(38, 13);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name:";
            // 
            // address1Lbl
            // 
            this.address1Lbl.AutoSize = true;
            this.address1Lbl.Location = new System.Drawing.Point(12, 43);
            this.address1Lbl.Name = "address1Lbl";
            this.address1Lbl.Size = new System.Drawing.Size(57, 13);
            this.address1Lbl.TabIndex = 1;
            this.address1Lbl.Text = "Address 1:";
            // 
            // address2Lbl
            // 
            this.address2Lbl.AutoSize = true;
            this.address2Lbl.Location = new System.Drawing.Point(12, 77);
            this.address2Lbl.Name = "address2Lbl";
            this.address2Lbl.Size = new System.Drawing.Size(57, 13);
            this.address2Lbl.TabIndex = 2;
            this.address2Lbl.Text = "Address 2:";
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Location = new System.Drawing.Point(12, 111);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(27, 13);
            this.cityLbl.TabIndex = 3;
            this.cityLbl.Text = "City:";
            // 
            // stateLbl
            // 
            this.stateLbl.AutoSize = true;
            this.stateLbl.Location = new System.Drawing.Point(12, 145);
            this.stateLbl.Name = "stateLbl";
            this.stateLbl.Size = new System.Drawing.Size(35, 13);
            this.stateLbl.TabIndex = 4;
            this.stateLbl.Text = "State:";
            // 
            // zipCodeLbl
            // 
            this.zipCodeLbl.AutoSize = true;
            this.zipCodeLbl.Location = new System.Drawing.Point(12, 179);
            this.zipCodeLbl.Name = "zipCodeLbl";
            this.zipCodeLbl.Size = new System.Drawing.Size(53, 13);
            this.zipCodeLbl.TabIndex = 5;
            this.zipCodeLbl.Text = "Zip Code:";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(157, 6);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 6;
            this.nameInput.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validating);
            this.nameInput.Validated += new System.EventHandler(this.textbox_Validated);
            // 
            // address2Input
            // 
            this.address2Input.Location = new System.Drawing.Point(157, 74);
            this.address2Input.Name = "address2Input";
            this.address2Input.Size = new System.Drawing.Size(100, 20);
            this.address2Input.TabIndex = 7;
            // 
            // cityInput
            // 
            this.cityInput.Location = new System.Drawing.Point(157, 108);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(100, 20);
            this.cityInput.TabIndex = 8;
            this.cityInput.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validating);
            this.cityInput.Validated += new System.EventHandler(this.textbox_Validated);
            // 
            // address1Input
            // 
            this.address1Input.Location = new System.Drawing.Point(157, 40);
            this.address1Input.Name = "address1Input";
            this.address1Input.Size = new System.Drawing.Size(100, 20);
            this.address1Input.TabIndex = 9;
            this.address1Input.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validating);
            this.address1Input.Validated += new System.EventHandler(this.textbox_Validated);
            // 
            // zipCodeInput
            // 
            this.zipCodeInput.Location = new System.Drawing.Point(157, 176);
            this.zipCodeInput.Name = "zipCodeInput";
            this.zipCodeInput.Size = new System.Drawing.Size(100, 20);
            this.zipCodeInput.TabIndex = 10;
            this.zipCodeInput.Validating += new System.ComponentModel.CancelEventHandler(this.zipCode_Validating);
            this.zipCodeInput.Validated += new System.EventHandler(this.textbox_Validated);
            // 
            // stateComboBox
            // 
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(157, 142);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(100, 21);
            this.stateComboBox.TabIndex = 11;
            this.stateComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.stateComboBox_Validating);
            this.stateComboBox.Validated += new System.EventHandler(this.stateComboBox_Validated);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(43, 217);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "Add Address";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(182, 217);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.zipCodeInput);
            this.Controls.Add(this.address1Input);
            this.Controls.Add(this.cityInput);
            this.Controls.Add(this.address2Input);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.zipCodeLbl);
            this.Controls.Add(this.stateLbl);
            this.Controls.Add(this.cityLbl);
            this.Controls.Add(this.address2Lbl);
            this.Controls.Add(this.address1Lbl);
            this.Controls.Add(this.nameLbl);
            this.Name = "AddressForm";
            this.Text = "AddressForm";
            this.Load += new System.EventHandler(this.AddressForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label address1Lbl;
        private System.Windows.Forms.Label address2Lbl;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.Label stateLbl;
        private System.Windows.Forms.Label zipCodeLbl;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox address2Input;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.TextBox address1Input;
        private System.Windows.Forms.TextBox zipCodeInput;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}