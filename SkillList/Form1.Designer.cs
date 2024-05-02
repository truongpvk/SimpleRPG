namespace SkillList
{
    partial class Form1
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
            this.dgvSkillList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnChooseFirst = new System.Windows.Forms.Button();
            this.btnChooseSecond = new System.Windows.Forms.Button();
            this.btnChooseThird = new System.Windows.Forms.Button();
            this.lbNameSkill = new System.Windows.Forms.Label();
            this.lbCostSkill = new System.Windows.Forms.Label();
            this.lbSkillCD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkillList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSkillList
            // 
            this.dgvSkillList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkillList.Location = new System.Drawing.Point(55, 58);
            this.dgvSkillList.Name = "dgvSkillList";
            this.dgvSkillList.RowHeadersWidth = 51;
            this.dgvSkillList.RowTemplate.Height = 24;
            this.dgvSkillList.Size = new System.Drawing.Size(539, 487);
            this.dgvSkillList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(665, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(665, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(665, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cost:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(665, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cooldown(s):";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(669, 166);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(442, 158);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // btnChooseFirst
            // 
            this.btnChooseFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseFirst.Location = new System.Drawing.Point(669, 471);
            this.btnChooseFirst.Name = "btnChooseFirst";
            this.btnChooseFirst.Size = new System.Drawing.Size(96, 34);
            this.btnChooseFirst.TabIndex = 6;
            this.btnChooseFirst.Text = "Choose 1";
            this.btnChooseFirst.UseVisualStyleBackColor = true;
            // 
            // btnChooseSecond
            // 
            this.btnChooseSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseSecond.Location = new System.Drawing.Point(849, 471);
            this.btnChooseSecond.Name = "btnChooseSecond";
            this.btnChooseSecond.Size = new System.Drawing.Size(96, 34);
            this.btnChooseSecond.TabIndex = 7;
            this.btnChooseSecond.Text = "Choose 2";
            this.btnChooseSecond.UseVisualStyleBackColor = true;
            // 
            // btnChooseThird
            // 
            this.btnChooseThird.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseThird.Location = new System.Drawing.Point(1015, 471);
            this.btnChooseThird.Name = "btnChooseThird";
            this.btnChooseThird.Size = new System.Drawing.Size(96, 34);
            this.btnChooseThird.TabIndex = 8;
            this.btnChooseThird.Text = "Choose 3";
            this.btnChooseThird.UseVisualStyleBackColor = true;
            // 
            // lbNameSkill
            // 
            this.lbNameSkill.AutoSize = true;
            this.lbNameSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameSkill.Location = new System.Drawing.Point(804, 79);
            this.lbNameSkill.Name = "lbNameSkill";
            this.lbNameSkill.Size = new System.Drawing.Size(0, 20);
            this.lbNameSkill.TabIndex = 9;
            // 
            // lbCostSkill
            // 
            this.lbCostSkill.AutoSize = true;
            this.lbCostSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCostSkill.Location = new System.Drawing.Point(804, 346);
            this.lbCostSkill.Name = "lbCostSkill";
            this.lbCostSkill.Size = new System.Drawing.Size(0, 20);
            this.lbCostSkill.TabIndex = 10;
            // 
            // lbSkillCD
            // 
            this.lbSkillCD.AutoSize = true;
            this.lbSkillCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSkillCD.Location = new System.Drawing.Point(804, 391);
            this.lbSkillCD.Name = "lbSkillCD";
            this.lbSkillCD.Size = new System.Drawing.Size(0, 20);
            this.lbSkillCD.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 626);
            this.Controls.Add(this.lbSkillCD);
            this.Controls.Add(this.lbCostSkill);
            this.Controls.Add(this.lbNameSkill);
            this.Controls.Add(this.btnChooseThird);
            this.Controls.Add(this.btnChooseSecond);
            this.Controls.Add(this.btnChooseFirst);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSkillList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkillList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSkillList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnChooseFirst;
        private System.Windows.Forms.Button btnChooseSecond;
        private System.Windows.Forms.Button btnChooseThird;
        private System.Windows.Forms.Label lbNameSkill;
        private System.Windows.Forms.Label lbCostSkill;
        private System.Windows.Forms.Label lbSkillCD;
    }
}

