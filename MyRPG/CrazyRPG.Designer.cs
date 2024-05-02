namespace MyRPG
{
    partial class CrazyRPG
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
            this.Status = new System.Windows.Forms.GroupBox();
            this.lbCurrentManaPoints = new System.Windows.Forms.Label();
            this.lbCurrentHitPoints = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbExp = new System.Windows.Forms.Label();
            this.lbLevel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbLocation = new System.Windows.Forms.RichTextBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.dtvQuest = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbWestLocation = new System.Windows.Forms.Label();
            this.lbEastLocation = new System.Windows.Forms.Label();
            this.lbSouthLocation = new System.Windows.Forms.Label();
            this.lbNorthLocation = new System.Windows.Forms.Label();
            this.lbCurrentLocation = new System.Windows.Forms.Label();
            this.btnMoveNorth = new System.Windows.Forms.Button();
            this.btnMoveWest = new System.Windows.Forms.Button();
            this.btnMoveEast = new System.Windows.Forms.Button();
            this.btnMoveSouth = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUseThirdSkill = new System.Windows.Forms.Button();
            this.btnUseSecondSkill = new System.Windows.Forms.Button();
            this.btnUseFirstSkill = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboPotion = new System.Windows.Forms.ComboBox();
            this.cboWeapon = new System.Windows.Forms.ComboBox();
            this.btnUsePotion = new System.Windows.Forms.Button();
            this.btnUseWeapon = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnOpenTreasure = new System.Windows.Forms.Button();
            this.btnBattleWithMonster = new System.Windows.Forms.Button();
            this.btnAcceptQuest = new System.Windows.Forms.Button();
            this.cboTreasure = new System.Windows.Forms.ComboBox();
            this.cboMonster = new System.Windows.Forms.ComboBox();
            this.cboQuest = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSkillList = new System.Windows.Forms.Button();
            this.Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvQuest)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.Controls.Add(this.lbCurrentManaPoints);
            this.Status.Controls.Add(this.lbCurrentHitPoints);
            this.Status.Controls.Add(this.label6);
            this.Status.Controls.Add(this.label5);
            this.Status.Controls.Add(this.lbExp);
            this.Status.Controls.Add(this.lbLevel);
            this.Status.Controls.Add(this.label2);
            this.Status.Controls.Add(this.label1);
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(27, 21);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(336, 312);
            this.Status.TabIndex = 0;
            this.Status.TabStop = false;
            this.Status.Text = "Status";
            // 
            // lbCurrentManaPoints
            // 
            this.lbCurrentManaPoints.AutoSize = true;
            this.lbCurrentManaPoints.Location = new System.Drawing.Point(151, 235);
            this.lbCurrentManaPoints.Name = "lbCurrentManaPoints";
            this.lbCurrentManaPoints.Size = new System.Drawing.Size(0, 26);
            this.lbCurrentManaPoints.TabIndex = 7;
            // 
            // lbCurrentHitPoints
            // 
            this.lbCurrentHitPoints.AutoSize = true;
            this.lbCurrentHitPoints.Location = new System.Drawing.Point(151, 161);
            this.lbCurrentHitPoints.Name = "lbCurrentHitPoints";
            this.lbCurrentHitPoints.Size = new System.Drawing.Size(0, 26);
            this.lbCurrentHitPoints.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mana:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "HP:";
            // 
            // lbExp
            // 
            this.lbExp.AutoSize = true;
            this.lbExp.Location = new System.Drawing.Point(230, 84);
            this.lbExp.Name = "lbExp";
            this.lbExp.Size = new System.Drawing.Size(0, 26);
            this.lbExp.TabIndex = 3;
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Location = new System.Drawing.Point(83, 84);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(0, 26);
            this.lbLevel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Level";
            // 
            // rtbLocation
            // 
            this.rtbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLocation.Location = new System.Drawing.Point(441, 38);
            this.rtbLocation.Name = "rtbLocation";
            this.rtbLocation.ReadOnly = true;
            this.rtbLocation.Size = new System.Drawing.Size(587, 96);
            this.rtbLocation.TabIndex = 1;
            this.rtbLocation.Text = "";
            // 
            // rtbMessage
            // 
            this.rtbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMessage.Location = new System.Drawing.Point(441, 182);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.ReadOnly = true;
            this.rtbMessage.Size = new System.Drawing.Size(587, 441);
            this.rtbMessage.TabIndex = 2;
            this.rtbMessage.Text = "";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(27, 384);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.Size = new System.Drawing.Size(336, 239);
            this.dgvInventory.TabIndex = 3;
            // 
            // dtvQuest
            // 
            this.dtvQuest.AllowUserToAddRows = false;
            this.dtvQuest.AllowUserToDeleteRows = false;
            this.dtvQuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvQuest.Location = new System.Drawing.Point(29, 649);
            this.dtvQuest.Name = "dtvQuest";
            this.dtvQuest.ReadOnly = true;
            this.dtvQuest.RowHeadersWidth = 51;
            this.dtvQuest.RowTemplate.Height = 24;
            this.dtvQuest.Size = new System.Drawing.Size(334, 239);
            this.dtvQuest.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbWestLocation);
            this.groupBox1.Controls.Add(this.lbEastLocation);
            this.groupBox1.Controls.Add(this.lbSouthLocation);
            this.groupBox1.Controls.Add(this.lbNorthLocation);
            this.groupBox1.Controls.Add(this.lbCurrentLocation);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1117, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 312);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Map";
            // 
            // lbWestLocation
            // 
            this.lbWestLocation.AutoSize = true;
            this.lbWestLocation.Location = new System.Drawing.Point(82, 144);
            this.lbWestLocation.Name = "lbWestLocation";
            this.lbWestLocation.Size = new System.Drawing.Size(62, 26);
            this.lbWestLocation.TabIndex = 12;
            this.lbWestLocation.Text = "West";
            // 
            // lbEastLocation
            // 
            this.lbEastLocation.AutoSize = true;
            this.lbEastLocation.Location = new System.Drawing.Point(351, 144);
            this.lbEastLocation.Name = "lbEastLocation";
            this.lbEastLocation.Size = new System.Drawing.Size(56, 26);
            this.lbEastLocation.TabIndex = 11;
            this.lbEastLocation.Text = "East";
            // 
            // lbSouthLocation
            // 
            this.lbSouthLocation.AutoSize = true;
            this.lbSouthLocation.Location = new System.Drawing.Point(210, 218);
            this.lbSouthLocation.Name = "lbSouthLocation";
            this.lbSouthLocation.Size = new System.Drawing.Size(69, 26);
            this.lbSouthLocation.TabIndex = 10;
            this.lbSouthLocation.Text = "South";
            // 
            // lbNorthLocation
            // 
            this.lbNorthLocation.AutoSize = true;
            this.lbNorthLocation.Location = new System.Drawing.Point(210, 67);
            this.lbNorthLocation.Name = "lbNorthLocation";
            this.lbNorthLocation.Size = new System.Drawing.Size(65, 26);
            this.lbNorthLocation.TabIndex = 9;
            this.lbNorthLocation.Text = "North";
            // 
            // lbCurrentLocation
            // 
            this.lbCurrentLocation.AutoSize = true;
            this.lbCurrentLocation.Location = new System.Drawing.Point(200, 144);
            this.lbCurrentLocation.Name = "lbCurrentLocation";
            this.lbCurrentLocation.Size = new System.Drawing.Size(84, 26);
            this.lbCurrentLocation.TabIndex = 8;
            this.lbCurrentLocation.Text = "Current";
            // 
            // btnMoveNorth
            // 
            this.btnMoveNorth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveNorth.Location = new System.Drawing.Point(1304, 384);
            this.btnMoveNorth.Name = "btnMoveNorth";
            this.btnMoveNorth.Size = new System.Drawing.Size(123, 40);
            this.btnMoveNorth.TabIndex = 9;
            this.btnMoveNorth.Text = "North";
            this.btnMoveNorth.UseVisualStyleBackColor = true;
            this.btnMoveNorth.Click += new System.EventHandler(this.btnMoveNorth_Click);
            // 
            // btnMoveWest
            // 
            this.btnMoveWest.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveWest.Location = new System.Drawing.Point(1187, 442);
            this.btnMoveWest.Name = "btnMoveWest";
            this.btnMoveWest.Size = new System.Drawing.Size(123, 40);
            this.btnMoveWest.TabIndex = 10;
            this.btnMoveWest.Text = "West";
            this.btnMoveWest.UseVisualStyleBackColor = true;
            this.btnMoveWest.Click += new System.EventHandler(this.btnMoveWest_Click);
            // 
            // btnMoveEast
            // 
            this.btnMoveEast.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveEast.Location = new System.Drawing.Point(1419, 442);
            this.btnMoveEast.Name = "btnMoveEast";
            this.btnMoveEast.Size = new System.Drawing.Size(123, 40);
            this.btnMoveEast.TabIndex = 11;
            this.btnMoveEast.Text = "East";
            this.btnMoveEast.UseVisualStyleBackColor = true;
            this.btnMoveEast.Click += new System.EventHandler(this.btnMoveEast_Click);
            // 
            // btnMoveSouth
            // 
            this.btnMoveSouth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveSouth.Location = new System.Drawing.Point(1305, 501);
            this.btnMoveSouth.Name = "btnMoveSouth";
            this.btnMoveSouth.Size = new System.Drawing.Size(123, 40);
            this.btnMoveSouth.TabIndex = 12;
            this.btnMoveSouth.Text = "South";
            this.btnMoveSouth.UseVisualStyleBackColor = true;
            this.btnMoveSouth.Click += new System.EventHandler(this.btnMoveSouth_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUseThirdSkill);
            this.groupBox2.Controls.Add(this.btnUseSecondSkill);
            this.groupBox2.Controls.Add(this.btnUseFirstSkill);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1117, 599);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 289);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Skill";
            // 
            // btnUseThirdSkill
            // 
            this.btnUseThirdSkill.Location = new System.Drawing.Point(37, 214);
            this.btnUseThirdSkill.Name = "btnUseThirdSkill";
            this.btnUseThirdSkill.Size = new System.Drawing.Size(124, 40);
            this.btnUseThirdSkill.TabIndex = 2;
            this.btnUseThirdSkill.Text = "Skill 3";
            this.btnUseThirdSkill.UseVisualStyleBackColor = true;
            this.btnUseThirdSkill.Click += new System.EventHandler(this.btnUseThirdSkill_Click);
            // 
            // btnUseSecondSkill
            // 
            this.btnUseSecondSkill.Location = new System.Drawing.Point(37, 140);
            this.btnUseSecondSkill.Name = "btnUseSecondSkill";
            this.btnUseSecondSkill.Size = new System.Drawing.Size(124, 40);
            this.btnUseSecondSkill.TabIndex = 1;
            this.btnUseSecondSkill.Text = "Skill 2";
            this.btnUseSecondSkill.UseVisualStyleBackColor = true;
            this.btnUseSecondSkill.Click += new System.EventHandler(this.btnUseSecondSkill_Click);
            // 
            // btnUseFirstSkill
            // 
            this.btnUseFirstSkill.Location = new System.Drawing.Point(38, 64);
            this.btnUseFirstSkill.Name = "btnUseFirstSkill";
            this.btnUseFirstSkill.Size = new System.Drawing.Size(124, 40);
            this.btnUseFirstSkill.TabIndex = 0;
            this.btnUseFirstSkill.Text = "Skill 1";
            this.btnUseFirstSkill.UseVisualStyleBackColor = true;
            this.btnUseFirstSkill.Click += new System.EventHandler(this.btnUseFirstSkill_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboPotion);
            this.groupBox3.Controls.Add(this.cboWeapon);
            this.groupBox3.Controls.Add(this.btnUsePotion);
            this.groupBox3.Controls.Add(this.btnUseWeapon);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1322, 599);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 289);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Battle";
            // 
            // cboPotion
            // 
            this.cboPotion.FormattingEnabled = true;
            this.cboPotion.Location = new System.Drawing.Point(10, 193);
            this.cboPotion.Name = "cboPotion";
            this.cboPotion.Size = new System.Drawing.Size(121, 34);
            this.cboPotion.TabIndex = 3;
            // 
            // cboWeapon
            // 
            this.cboWeapon.FormattingEnabled = true;
            this.cboWeapon.Location = new System.Drawing.Point(10, 86);
            this.cboWeapon.Name = "cboWeapon";
            this.cboWeapon.Size = new System.Drawing.Size(121, 34);
            this.cboWeapon.TabIndex = 2;
            // 
            // btnUsePotion
            // 
            this.btnUsePotion.Location = new System.Drawing.Point(161, 193);
            this.btnUsePotion.Name = "btnUsePotion";
            this.btnUsePotion.Size = new System.Drawing.Size(110, 36);
            this.btnUsePotion.TabIndex = 1;
            this.btnUsePotion.Text = "Use";
            this.btnUsePotion.UseVisualStyleBackColor = true;
            this.btnUsePotion.Click += new System.EventHandler(this.btnUsePotion_Click);
            // 
            // btnUseWeapon
            // 
            this.btnUseWeapon.Location = new System.Drawing.Point(161, 86);
            this.btnUseWeapon.Name = "btnUseWeapon";
            this.btnUseWeapon.Size = new System.Drawing.Size(110, 34);
            this.btnUseWeapon.TabIndex = 0;
            this.btnUseWeapon.Text = "Use";
            this.btnUseWeapon.UseVisualStyleBackColor = true;
            this.btnUseWeapon.Click += new System.EventHandler(this.btnUseWeapon_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnOpenTreasure);
            this.groupBox4.Controls.Add(this.btnBattleWithMonster);
            this.groupBox4.Controls.Add(this.btnAcceptQuest);
            this.groupBox4.Controls.Add(this.cboTreasure);
            this.groupBox4.Controls.Add(this.cboMonster);
            this.groupBox4.Controls.Add(this.cboQuest);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(441, 649);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(306, 239);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Location Status";
            // 
            // btnOpenTreasure
            // 
            this.btnOpenTreasure.Location = new System.Drawing.Point(201, 190);
            this.btnOpenTreasure.Name = "btnOpenTreasure";
            this.btnOpenTreasure.Size = new System.Drawing.Size(75, 27);
            this.btnOpenTreasure.TabIndex = 5;
            this.btnOpenTreasure.Text = "Open";
            this.btnOpenTreasure.UseVisualStyleBackColor = true;
            // 
            // btnBattleWithMonster
            // 
            this.btnBattleWithMonster.Location = new System.Drawing.Point(201, 118);
            this.btnBattleWithMonster.Name = "btnBattleWithMonster";
            this.btnBattleWithMonster.Size = new System.Drawing.Size(75, 27);
            this.btnBattleWithMonster.TabIndex = 4;
            this.btnBattleWithMonster.Text = "Battle";
            this.btnBattleWithMonster.UseVisualStyleBackColor = true;
            // 
            // btnAcceptQuest
            // 
            this.btnAcceptQuest.Location = new System.Drawing.Point(201, 48);
            this.btnAcceptQuest.Name = "btnAcceptQuest";
            this.btnAcceptQuest.Size = new System.Drawing.Size(75, 27);
            this.btnAcceptQuest.TabIndex = 3;
            this.btnAcceptQuest.Text = "Accept";
            this.btnAcceptQuest.UseVisualStyleBackColor = true;
            // 
            // cboTreasure
            // 
            this.cboTreasure.FormattingEnabled = true;
            this.cboTreasure.Location = new System.Drawing.Point(30, 189);
            this.cboTreasure.Name = "cboTreasure";
            this.cboTreasure.Size = new System.Drawing.Size(121, 28);
            this.cboTreasure.TabIndex = 2;
            // 
            // cboMonster
            // 
            this.cboMonster.FormattingEnabled = true;
            this.cboMonster.Location = new System.Drawing.Point(30, 117);
            this.cboMonster.Name = "cboMonster";
            this.cboMonster.Size = new System.Drawing.Size(121, 28);
            this.cboMonster.TabIndex = 1;
            // 
            // cboQuest
            // 
            this.cboQuest.FormattingEnabled = true;
            this.cboQuest.Location = new System.Drawing.Point(30, 48);
            this.cboQuest.Name = "cboQuest";
            this.cboQuest.Size = new System.Drawing.Size(121, 28);
            this.cboQuest.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSkillList);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(828, 649);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 239);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Skill List";
            // 
            // btnSkillList
            // 
            this.btnSkillList.Location = new System.Drawing.Point(46, 104);
            this.btnSkillList.Name = "btnSkillList";
            this.btnSkillList.Size = new System.Drawing.Size(112, 41);
            this.btnSkillList.TabIndex = 0;
            this.btnSkillList.Text = "List of Skill";
            this.btnSkillList.UseVisualStyleBackColor = true;
            this.btnSkillList.Click += new System.EventHandler(this.btnSkillList_Click);
            // 
            // CrazyRPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1623, 915);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnMoveSouth);
            this.Controls.Add(this.btnMoveEast);
            this.Controls.Add(this.btnMoveWest);
            this.Controls.Add(this.btnMoveNorth);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtvQuest);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.rtbLocation);
            this.Controls.Add(this.Status);
            this.Name = "CrazyRPG";
            this.Text = "Form1";
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvQuest)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Status;
        private System.Windows.Forms.Label lbCurrentManaPoints;
        private System.Windows.Forms.Label lbCurrentHitPoints;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbExp;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbLocation;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridView dtvQuest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbNorthLocation;
        private System.Windows.Forms.Label lbCurrentLocation;
        private System.Windows.Forms.Label lbWestLocation;
        private System.Windows.Forms.Label lbEastLocation;
        private System.Windows.Forms.Label lbSouthLocation;
        private System.Windows.Forms.Button btnMoveNorth;
        private System.Windows.Forms.Button btnMoveWest;
        private System.Windows.Forms.Button btnMoveEast;
        private System.Windows.Forms.Button btnMoveSouth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUseThirdSkill;
        private System.Windows.Forms.Button btnUseSecondSkill;
        private System.Windows.Forms.Button btnUseFirstSkill;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUseWeapon;
        private System.Windows.Forms.ComboBox cboPotion;
        private System.Windows.Forms.ComboBox cboWeapon;
        private System.Windows.Forms.Button btnUsePotion;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnOpenTreasure;
        private System.Windows.Forms.Button btnBattleWithMonster;
        private System.Windows.Forms.Button btnAcceptQuest;
        private System.Windows.Forms.ComboBox cboTreasure;
        private System.Windows.Forms.ComboBox cboMonster;
        private System.Windows.Forms.ComboBox cboQuest;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSkillList;
    }
}

