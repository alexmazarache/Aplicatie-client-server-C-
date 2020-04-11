namespace Client
{
    partial class MainWindow
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
            this.CurseTabel = new System.Windows.Forms.DataGridView();
            this.PartTabel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.NumePart = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumePartTxt = new System.Windows.Forms.TextBox();
            this.NumeEchipaTxt = new System.Windows.Forms.TextBox();
            this.CapacitateBox = new System.Windows.Forms.ComboBox();
            this.SubmitBttn = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ClearSearchBttn = new System.Windows.Forms.Button();
            this.SearchBttn = new System.Windows.Forms.Button();
            this.Team = new System.Windows.Forms.Label();
            this.ClearSubmitBttn = new System.Windows.Forms.Button();
            this.LogoutBttn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CurseTabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartTabel)).BeginInit();
            this.SuspendLayout();
            // 
            // CurseTabel
            // 
            this.CurseTabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurseTabel.Location = new System.Drawing.Point(13, 58);
            this.CurseTabel.Margin = new System.Windows.Forms.Padding(4);
            this.CurseTabel.Name = "CurseTabel";
            this.CurseTabel.RowHeadersWidth = 51;
            this.CurseTabel.Size = new System.Drawing.Size(467, 241);
            this.CurseTabel.TabIndex = 0;
            this.CurseTabel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CurseTabel_CellContentClick);
            // 
            // PartTabel
            // 
            this.PartTabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartTabel.Location = new System.Drawing.Point(569, 58);
            this.PartTabel.Margin = new System.Windows.Forms.Padding(4);
            this.PartTabel.Name = "PartTabel";
            this.PartTabel.RowHeadersWidth = 51;
            this.PartTabel.Size = new System.Drawing.Size(467, 241);
            this.PartTabel.TabIndex = 1;
            this.PartTabel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartTabel_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 315);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inscriere ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NumePart
            // 
            this.NumePart.AutoSize = true;
            this.NumePart.Location = new System.Drawing.Point(-147, 145);
            this.NumePart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumePart.Name = "NumePart";
            this.NumePart.Size = new System.Drawing.Size(116, 17);
            this.NumePart.TabIndex = 3;
            this.NumePart.Text = "Nume Participant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-147, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nume Echipa";
            // 
            // NumePartTxt
            // 
            this.NumePartTxt.Location = new System.Drawing.Point(623, 380);
            this.NumePartTxt.Margin = new System.Windows.Forms.Padding(4);
            this.NumePartTxt.Name = "NumePartTxt";
            this.NumePartTxt.Size = new System.Drawing.Size(181, 22);
            this.NumePartTxt.TabIndex = 5;
            // 
            // NumeEchipaTxt
            // 
            this.NumeEchipaTxt.Location = new System.Drawing.Point(623, 433);
            this.NumeEchipaTxt.Margin = new System.Windows.Forms.Padding(4);
            this.NumeEchipaTxt.Name = "NumeEchipaTxt";
            this.NumeEchipaTxt.Size = new System.Drawing.Size(181, 22);
            this.NumeEchipaTxt.TabIndex = 6;
            // 
            // CapacitateBox
            // 
            this.CapacitateBox.FormattingEnabled = true;
            this.CapacitateBox.Location = new System.Drawing.Point(623, 489);
            this.CapacitateBox.Margin = new System.Windows.Forms.Padding(4);
            this.CapacitateBox.Name = "CapacitateBox";
            this.CapacitateBox.Size = new System.Drawing.Size(181, 24);
            this.CapacitateBox.TabIndex = 7;
            // 
            // SubmitBttn
            // 
            this.SubmitBttn.Location = new System.Drawing.Point(853, 315);
            this.SubmitBttn.Margin = new System.Windows.Forms.Padding(4);
            this.SubmitBttn.Name = "SubmitBttn";
            this.SubmitBttn.Size = new System.Drawing.Size(183, 49);
            this.SubmitBttn.TabIndex = 8;
            this.SubmitBttn.Text = "Submit";
            this.SubmitBttn.UseVisualStyleBackColor = true;
            this.SubmitBttn.Click += new System.EventHandler(this.handleSubmit);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(95, 367);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(222, 22);
            this.SearchTextBox.TabIndex = 9;
            // 
            // ClearSearchBttn
            // 
            this.ClearSearchBttn.Location = new System.Drawing.Point(95, 439);
            this.ClearSearchBttn.Margin = new System.Windows.Forms.Padding(4);
            this.ClearSearchBttn.Name = "ClearSearchBttn";
            this.ClearSearchBttn.Size = new System.Drawing.Size(100, 42);
            this.ClearSearchBttn.TabIndex = 10;
            this.ClearSearchBttn.Text = "Clear";
            this.ClearSearchBttn.UseVisualStyleBackColor = true;
            this.ClearSearchBttn.Click += new System.EventHandler(this.handleClear_Search);
            // 
            // SearchBttn
            // 
            this.SearchBttn.Location = new System.Drawing.Point(217, 439);
            this.SearchBttn.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBttn.Name = "SearchBttn";
            this.SearchBttn.Size = new System.Drawing.Size(100, 42);
            this.SearchBttn.TabIndex = 11;
            this.SearchBttn.Text = "Search";
            this.SearchBttn.UseVisualStyleBackColor = true;
            this.SearchBttn.Click += new System.EventHandler(this.handleSearch);
            // 
            // Team
            // 
            this.Team.AutoSize = true;
            this.Team.Location = new System.Drawing.Point(173, 331);
            this.Team.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Team.Name = "Team";
            this.Team.Size = new System.Drawing.Size(96, 17);
            this.Team.TabIndex = 12;
            this.Team.Text = "Nume Echipa:";
            // 
            // ClearSubmitBttn
            // 
            this.ClearSubmitBttn.Location = new System.Drawing.Point(853, 400);
            this.ClearSubmitBttn.Margin = new System.Windows.Forms.Padding(4);
            this.ClearSubmitBttn.Name = "ClearSubmitBttn";
            this.ClearSubmitBttn.Size = new System.Drawing.Size(183, 49);
            this.ClearSubmitBttn.TabIndex = 13;
            this.ClearSubmitBttn.Text = "Clear";
            this.ClearSubmitBttn.UseVisualStyleBackColor = true;
            this.ClearSubmitBttn.Click += new System.EventHandler(this.ClearInscText);
            // 
            // LogoutBttn
            // 
            this.LogoutBttn.Location = new System.Drawing.Point(853, 497);
            this.LogoutBttn.Margin = new System.Windows.Forms.Padding(4);
            this.LogoutBttn.Name = "LogoutBttn";
            this.LogoutBttn.Size = new System.Drawing.Size(183, 33);
            this.LogoutBttn.TabIndex = 14;
            this.LogoutBttn.Text = "Logout";
            this.LogoutBttn.UseVisualStyleBackColor = true;
            this.LogoutBttn.Click += new System.EventHandler(this.LogoutBttnClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Curse disponibile";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(749, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Participanti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 380);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nume Participant:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 439);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nume Echipa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(509, 492);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Capacitate:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogoutBttn);
            this.Controls.Add(this.ClearSubmitBttn);
            this.Controls.Add(this.Team);
            this.Controls.Add(this.SearchBttn);
            this.Controls.Add(this.ClearSearchBttn);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SubmitBttn);
            this.Controls.Add(this.CapacitateBox);
            this.Controls.Add(this.NumeEchipaTxt);
            this.Controls.Add(this.NumePartTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumePart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PartTabel);
            this.Controls.Add(this.CurseTabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.CurseTabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartTabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CurseTabel;
        private System.Windows.Forms.DataGridView PartTabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NumePart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumePartTxt;
        private System.Windows.Forms.TextBox NumeEchipaTxt;
        private System.Windows.Forms.ComboBox CapacitateBox;
        private System.Windows.Forms.Button SubmitBttn;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button ClearSearchBttn;
        private System.Windows.Forms.Button SearchBttn;
        private System.Windows.Forms.Label Team;
        private System.Windows.Forms.Button ClearSubmitBttn;
        private System.Windows.Forms.Button LogoutBttn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}