namespace dizain_hiiw
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
            textBox1 = new TextBox();
            cmbLanguage = new ComboBox();
            label1 = new Label();
            dgvDictionary = new DataGridView();
            label2 = new Label();
            dgvSaved = new DataGridView();
            label3 = new Label();
            txtEng = new TextBox();
            label4 = new Label();
            txtMon = new TextBox();
            label5 = new Label();
            txtRus = new TextBox();
            label6 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnSaveWord = new Button();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDictionary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaved).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(610, 39);
            textBox1.TabIndex = 0;
            textBox1.Text = "Хайх үг...";
            // 
            // cmbLanguage
            // 
            cmbLanguage.FormattingEnabled = true;
            cmbLanguage.Items.AddRange(new object[] { "Англи", "Монгол", "Орос" });
            cmbLanguage.Location = new Point(865, 29);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new Size(242, 40);
            cmbLanguage.TabIndex = 1;
            cmbLanguage.Text = "Бүгд";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(782, 30);
            label1.Name = "label1";
            label1.Size = new Size(57, 32);
            label1.TabIndex = 2;
            label1.Text = "Хэл:";
            // 
            // dgvDictionary
            // 
            dgvDictionary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDictionary.Location = new Point(12, 96);
            dgvDictionary.Name = "dgvDictionary";
            dgvDictionary.RowHeadersWidth = 82;
            dgvDictionary.Size = new Size(684, 551);
            dgvDictionary.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(70, 32);
            label2.TabIndex = 4;
            label2.Text = "Хайх:";
            // 
            // dgvSaved
            // 
            dgvSaved.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaved.Location = new Point(754, 240);
            dgvSaved.Name = "dgvSaved";
            dgvSaved.RowHeadersWidth = 82;
            dgvSaved.Size = new Size(422, 334);
            dgvSaved.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(782, 96);
            label3.Name = "label3";
            label3.Size = new Size(143, 32);
            label3.TabIndex = 6;
            label3.Text = "Санасан үгс";
            // 
            // txtEng
            // 
            txtEng.Location = new Point(97, 674);
            txtEng.Name = "txtEng";
            txtEng.Size = new Size(219, 39);
            txtEng.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 677);
            label4.Name = "label4";
            label4.Size = new Size(79, 32);
            label4.TabIndex = 8;
            label4.Text = "Англи";
            // 
            // txtMon
            // 
            txtMon.Location = new Point(453, 674);
            txtMon.Name = "txtMon";
            txtMon.Size = new Size(248, 39);
            txtMon.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(347, 677);
            label5.Name = "label5";
            label5.Size = new Size(100, 32);
            label5.TabIndex = 10;
            label5.Text = "Монгол";
            // 
            // txtRus
            // 
            txtRus.Location = new Point(844, 674);
            txtRus.Name = "txtRus";
            txtRus.Size = new Size(245, 39);
            txtRus.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(738, 677);
            label6.Name = "label6";
            label6.Size = new Size(71, 32);
            label6.TabIndex = 12;
            label6.Text = "Орос";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(31, 736);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "+ Нэмэх";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(287, 736);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 46);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "✎ Засах";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(531, 736);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "🗑 Устгах";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(775, 736);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 46);
            btnClear.TabIndex = 16;
            btnClear.Text = " Цэвэрлэх";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSaveWord
            // 
            btnSaveWord.Location = new Point(1026, 736);
            btnSaveWord.Name = "btnSaveWord";
            btnSaveWord.Size = new Size(150, 46);
            btnSaveWord.TabIndex = 17;
            btnSaveWord.Text = "💾 Санах";
            btnSaveWord.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 785);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(269, 32);
            lblStatus.TabIndex = 18;
            lblStatus.Text = "Нийт: 10 үг · Санасан: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 820);
            Controls.Add(lblStatus);
            Controls.Add(btnSaveWord);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(txtRus);
            Controls.Add(label5);
            Controls.Add(txtMon);
            Controls.Add(label4);
            Controls.Add(txtEng);
            Controls.Add(label3);
            Controls.Add(dgvSaved);
            Controls.Add(label2);
            Controls.Add(dgvDictionary);
            Controls.Add(label1);
            Controls.Add(cmbLanguage);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Гурван хэлний толь бичиг";
            ((System.ComponentModel.ISupportInitialize)dgvDictionary).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaved).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox cmbLanguage;
        private Label label1;
        private DataGridView dgvDictionary;
        private Label label2;
        private DataGridView dgvSaved;
        private Label label3;
        private TextBox txtEng;
        private Label label4;
        private TextBox txtMon;
        private Label label5;
        private TextBox txtRus;
        private Label label6;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClear;
        private Button btnSaveWord;
        private Label lblStatus;
    }
}