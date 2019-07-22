namespace Si.Criptografia
{
    partial class MainForm
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
            this.keySizeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.encryptionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.encryptionInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // keySizeComboBox
            // 
            this.keySizeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.encryptionInfoBindingSource, "KeySize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.keySizeComboBox.FormattingEnabled = true;
            this.keySizeComboBox.Location = new System.Drawing.Point(16, 27);
            this.keySizeComboBox.Name = "keySizeComboBox";
            this.keySizeComboBox.Size = new System.Drawing.Size(79, 21);
            this.keySizeComboBox.TabIndex = 0;
            this.keySizeComboBox.SelectedValueChanged += new System.EventHandler(this.keySizeComboBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chave";
            // 
            // keyTextBox
            // 
            this.keyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.encryptionInfoBindingSource, "Key", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.keyTextBox.Location = new System.Drawing.Point(102, 27);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(175, 20);
            this.keyTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Arquivo";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "txt| *.txt";
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(14, 118);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(96, 23);
            this.encryptButton.TabIndex = 5;
            this.encryptButton.Text = "Criptografar";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(111, 118);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(96, 23);
            this.decryptButton.TabIndex = 6;
            this.decryptButton.Text = "Descriptografar";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // fileTextBox
            // 
            this.fileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.encryptionInfoBindingSource, "File", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fileTextBox.Location = new System.Drawing.Point(16, 79);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.ReadOnly = true;
            this.fileTextBox.Size = new System.Drawing.Size(185, 20);
            this.fileTextBox.TabIndex = 7;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(201, 78);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 22);
            this.selectButton.TabIndex = 8;
            this.selectButton.Text = "Selecionar";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt| *.txt";
            // 
            // encryptionInfoBindingSource
            // 
            this.encryptionInfoBindingSource.DataSource = typeof(Si.Criptografia.EncryptionInfo);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keySizeComboBox);
            this.Name = "MainForm";
            this.Text = "Criptografia e Segurança";
            ((System.ComponentModel.ISupportInitialize)(this.encryptionInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox keySizeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.BindingSource encryptionInfoBindingSource;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;

    }
}

