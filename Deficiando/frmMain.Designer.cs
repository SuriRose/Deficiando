namespace Deficiando
{
    partial class Definiciando
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tblControls = new System.Windows.Forms.TableLayoutPanel();
            this.btnPickWord = new System.Windows.Forms.Button();
            this.optDef1 = new System.Windows.Forms.RadioButton();
            this.optDef2 = new System.Windows.Forms.RadioButton();
            this.optDef3 = new System.Windows.Forms.RadioButton();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnGiveUp = new System.Windows.Forms.Button();
            this.tblPlayArea = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblDef1 = new System.Windows.Forms.Label();
            this.lblDef2 = new System.Windows.Forms.Label();
            this.lblDef3 = new System.Windows.Forms.Label();
            this.lblNumWordsTried = new System.Windows.Forms.Label();
            this.lblNumWords = new System.Windows.Forms.Label();
            this.lblScoreCaption = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tblMain.SuspendLayout();
            this.tblControls.SuspendLayout();
            this.tblPlayArea.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.lblMessage, 0, 0);
            this.tblMain.Controls.Add(this.tblControls, 0, 1);
            this.tblMain.Controls.Add(this.tblPlayArea, 0, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.90635F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.88842F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.21199F));
            this.tblMain.Size = new System.Drawing.Size(1187, 717);
            this.tblMain.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.SystemColors.Info;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Location = new System.Drawing.Point(3, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(1181, 114);
            this.lblMessage.TabIndex = 0;
            // 
            // tblControls
            // 
            this.tblControls.BackColor = System.Drawing.Color.LightCoral;
            this.tblControls.ColumnCount = 6;
            this.tblControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblControls.Controls.Add(this.btnPickWord, 1, 0);
            this.tblControls.Controls.Add(this.optDef1, 4, 0);
            this.tblControls.Controls.Add(this.optDef2, 5, 0);
            this.tblControls.Controls.Add(this.optDef3, 3, 0);
            this.tblControls.Controls.Add(this.btnEnter, 0, 0);
            this.tblControls.Controls.Add(this.btnGiveUp, 2, 0);
            this.tblControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblControls.Location = new System.Drawing.Point(3, 117);
            this.tblControls.Name = "tblControls";
            this.tblControls.RowCount = 1;
            this.tblControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblControls.Size = new System.Drawing.Size(1181, 279);
            this.tblControls.TabIndex = 1;
            // 
            // btnPickWord
            // 
            this.btnPickWord.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPickWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPickWord.Location = new System.Drawing.Point(199, 3);
            this.btnPickWord.Name = "btnPickWord";
            this.btnPickWord.Size = new System.Drawing.Size(190, 273);
            this.btnPickWord.TabIndex = 0;
            this.btnPickWord.Text = "Pick a Word";
            this.btnPickWord.UseVisualStyleBackColor = false;
            // 
            // optDef1
            // 
            this.optDef1.AutoSize = true;
            this.optDef1.BackColor = System.Drawing.Color.DarkOrange;
            this.optDef1.Location = new System.Drawing.Point(787, 3);
            this.optDef1.Name = "optDef1";
            this.optDef1.Size = new System.Drawing.Size(104, 24);
            this.optDef1.TabIndex = 2;
            this.optDef1.TabStop = true;
            this.optDef1.Text = "Definition2";
            this.optDef1.UseVisualStyleBackColor = false;
            // 
            // optDef2
            // 
            this.optDef2.AutoSize = true;
            this.optDef2.BackColor = System.Drawing.Color.DarkOrange;
            this.optDef2.Dock = System.Windows.Forms.DockStyle.Top;
            this.optDef2.Location = new System.Drawing.Point(983, 3);
            this.optDef2.Name = "optDef2";
            this.optDef2.Size = new System.Drawing.Size(195, 24);
            this.optDef2.TabIndex = 5;
            this.optDef2.TabStop = true;
            this.optDef2.Text = "Definition3";
            this.optDef2.UseVisualStyleBackColor = false;
            // 
            // optDef3
            // 
            this.optDef3.AutoSize = true;
            this.optDef3.BackColor = System.Drawing.Color.DarkOrange;
            this.optDef3.Dock = System.Windows.Forms.DockStyle.Top;
            this.optDef3.Location = new System.Drawing.Point(591, 3);
            this.optDef3.Name = "optDef3";
            this.optDef3.Size = new System.Drawing.Size(190, 24);
            this.optDef3.TabIndex = 7;
            this.optDef3.TabStop = true;
            this.optDef3.Text = "Definition1";
            this.optDef3.UseVisualStyleBackColor = false;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.LawnGreen;
            this.btnEnter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEnter.Location = new System.Drawing.Point(3, 3);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(190, 273);
            this.btnEnter.TabIndex = 6;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.BackColor = System.Drawing.Color.Yellow;
            this.btnGiveUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGiveUp.Location = new System.Drawing.Point(395, 3);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(190, 273);
            this.btnGiveUp.TabIndex = 1;
            this.btnGiveUp.Text = "Give Up";
            this.btnGiveUp.UseVisualStyleBackColor = false;
            // 
            // tblPlayArea
            // 
            this.tblPlayArea.ColumnCount = 5;
            this.tblPlayArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPlayArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPlayArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tblPlayArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPlayArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tblPlayArea.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tblPlayArea.Controls.Add(this.lblNumWordsTried, 1, 0);
            this.tblPlayArea.Controls.Add(this.lblNumWords, 2, 0);
            this.tblPlayArea.Controls.Add(this.lblScoreCaption, 3, 0);
            this.tblPlayArea.Controls.Add(this.lblScore, 4, 0);
            this.tblPlayArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblPlayArea.Location = new System.Drawing.Point(3, 402);
            this.tblPlayArea.Name = "tblPlayArea";
            this.tblPlayArea.RowCount = 1;
            this.tblPlayArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPlayArea.Size = new System.Drawing.Size(1181, 312);
            this.tblPlayArea.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Crimson;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblWord, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDef1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDef2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDef3, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(843, 306);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(3, 0);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(45, 20);
            this.lblWord.TabIndex = 2;
            this.lblWord.Text = "Word";
            // 
            // lblDef1
            // 
            this.lblDef1.AutoSize = true;
            this.lblDef1.Location = new System.Drawing.Point(3, 76);
            this.lblDef1.Name = "lblDef1";
            this.lblDef1.Size = new System.Drawing.Size(83, 20);
            this.lblDef1.TabIndex = 3;
            this.lblDef1.Text = "Definition1";
            // 
            // lblDef2
            // 
            this.lblDef2.AutoSize = true;
            this.lblDef2.Location = new System.Drawing.Point(3, 152);
            this.lblDef2.Name = "lblDef2";
            this.lblDef2.Size = new System.Drawing.Size(83, 20);
            this.lblDef2.TabIndex = 4;
            this.lblDef2.Text = "Definition2";
            // 
            // lblDef3
            // 
            this.lblDef3.AutoSize = true;
            this.lblDef3.Location = new System.Drawing.Point(3, 228);
            this.lblDef3.Name = "lblDef3";
            this.lblDef3.Size = new System.Drawing.Size(83, 20);
            this.lblDef3.TabIndex = 6;
            this.lblDef3.Text = "Definition3";
            // 
            // lblNumWordsTried
            // 
            this.lblNumWordsTried.AutoSize = true;
            this.lblNumWordsTried.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNumWordsTried.Location = new System.Drawing.Point(852, 0);
            this.lblNumWordsTried.Name = "lblNumWordsTried";
            this.lblNumWordsTried.Size = new System.Drawing.Size(124, 20);
            this.lblNumWordsTried.TabIndex = 1;
            this.lblNumWordsTried.Text = "Num Words Tried";
            // 
            // lblNumWords
            // 
            this.lblNumWords.AutoSize = true;
            this.lblNumWords.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNumWords.Location = new System.Drawing.Point(982, 0);
            this.lblNumWords.Name = "lblNumWords";
            this.lblNumWords.Size = new System.Drawing.Size(69, 20);
            this.lblNumWords.TabIndex = 2;
            this.lblNumWords.Text = "0";
            this.lblNumWords.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblScoreCaption
            // 
            this.lblScoreCaption.AutoSize = true;
            this.lblScoreCaption.Location = new System.Drawing.Point(1057, 0);
            this.lblScoreCaption.Name = "lblScoreCaption";
            this.lblScoreCaption.Size = new System.Drawing.Size(46, 20);
            this.lblScoreCaption.TabIndex = 3;
            this.lblScoreCaption.Text = "Score";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblScore.Location = new System.Drawing.Point(1109, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(69, 20);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "0";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(497, 65);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(146, 30);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Definiciando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 717);
            this.Controls.Add(this.tblMain);
            this.Name = "Definiciando";
            this.Text = "Deficiando";
            this.tblMain.ResumeLayout(false);
            this.tblControls.ResumeLayout(false);
            this.tblControls.PerformLayout();
            this.tblPlayArea.ResumeLayout(false);
            this.tblPlayArea.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblMessage;
        private TableLayoutPanel tblControls;
        private Button btnPickWord;
        private Button btnGiveUp;
        private RadioButton optDef1;
        private RadioButton radioButton2;
        private RadioButton optDef2;
        private TableLayoutPanel tblPlayArea;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblWord;
        private Label lblDef1;
        private Label lblDef2;
        private Label lblDef3;
        private Label lblNumWordsTried;
        private Label lblNumWords;
        private Label lblScoreCaption;
        private Label lblScore;
        private Button btnEnter;
        private RadioButton optDef3;
    }
}