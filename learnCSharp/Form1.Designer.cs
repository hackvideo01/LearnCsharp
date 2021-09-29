
namespace learnCSharp
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbnt1 = new System.Windows.Forms.RadioButton();
            this.rdbnt2 = new System.Windows.Forms.RadioButton();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.btnUndo = new System.Windows.Forms.Button();
            this.lbRUNSTOPTEXT = new System.Windows.Forms.Label();
            this.btnRunStop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(93, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name:";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(232, 47);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(323, 19);
            this.txbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Font Type Choose";
            // 
            // rdbnt1
            // 
            this.rdbnt1.AutoSize = true;
            this.rdbnt1.Location = new System.Drawing.Point(121, 149);
            this.rdbnt1.Name = "rdbnt1";
            this.rdbnt1.Size = new System.Drawing.Size(111, 16);
            this.rdbnt1.TabIndex = 3;
            this.rdbnt1.TabStop = true;
            this.rdbnt1.Text = "lowercase letters";
            this.rdbnt1.UseVisualStyleBackColor = true;
            // 
            // rdbnt2
            // 
            this.rdbnt2.AutoSize = true;
            this.rdbnt2.Location = new System.Drawing.Point(121, 186);
            this.rdbnt2.Name = "rdbnt2";
            this.rdbnt2.Size = new System.Drawing.Size(104, 16);
            this.rdbnt2.TabIndex = 4;
            this.rdbnt2.TabStop = true;
            this.rdbnt2.Text = "Capitalize letter";
            this.rdbnt2.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(435, 78);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(257, 105);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 6;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(338, 107);
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(312, 19);
            this.txbResult.TabIndex = 7;
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(516, 78);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 8;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // lbRUNSTOPTEXT
            // 
            this.lbRUNSTOPTEXT.AutoSize = true;
            this.lbRUNSTOPTEXT.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbRUNSTOPTEXT.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbRUNSTOPTEXT.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbRUNSTOPTEXT.Location = new System.Drawing.Point(275, 138);
            this.lbRUNSTOPTEXT.Name = "lbRUNSTOPTEXT";
            this.lbRUNSTOPTEXT.Padding = new System.Windows.Forms.Padding(3);
            this.lbRUNSTOPTEXT.Size = new System.Drawing.Size(6, 33);
            this.lbRUNSTOPTEXT.TabIndex = 9;
            // 
            // btnRunStop
            // 
            this.btnRunStop.Location = new System.Drawing.Point(257, 186);
            this.btnRunStop.Name = "btnRunStop";
            this.btnRunStop.Size = new System.Drawing.Size(75, 23);
            this.btnRunStop.TabIndex = 10;
            this.btnRunStop.Text = "START";
            this.btnRunStop.UseVisualStyleBackColor = true;
            this.btnRunStop.Click += new System.EventHandler(this.btnRunStop_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(280, 276);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRunStop);
            this.Controls.Add(this.lbRUNSTOPTEXT);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.rdbnt2);
            this.Controls.Add(this.rdbnt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Change Font Type";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbnt1;
        private System.Windows.Forms.RadioButton rdbnt2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Label lbRUNSTOPTEXT;
        private System.Windows.Forms.Button btnRunStop;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

