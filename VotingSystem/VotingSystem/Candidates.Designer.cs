﻿namespace VotingSystem
{
    partial class Candidates
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.studNameTxt = new System.Windows.Forms.TextBox();
            this.posTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.partytxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.secTxt = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.progTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.levelTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(274, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 415);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // studNameTxt
            // 
            this.studNameTxt.Location = new System.Drawing.Point(40, 143);
            this.studNameTxt.Name = "studNameTxt";
            this.studNameTxt.Size = new System.Drawing.Size(187, 20);
            this.studNameTxt.TabIndex = 3;
            this.studNameTxt.TextChanged += new System.EventHandler(this.studNameTxt_TextChanged);
            // 
            // posTxt
            // 
            this.posTxt.Location = new System.Drawing.Point(40, 181);
            this.posTxt.Name = "posTxt";
            this.posTxt.Size = new System.Drawing.Size(187, 20);
            this.posTxt.TabIndex = 5;
            this.posTxt.TextChanged += new System.EventHandler(this.posTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Student name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Position";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(152, 451);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Partylist";
            // 
            // partytxt
            // 
            this.partytxt.Location = new System.Drawing.Point(40, 220);
            this.partytxt.Name = "partytxt";
            this.partytxt.Size = new System.Drawing.Size(187, 20);
            this.partytxt.TabIndex = 13;
            this.partytxt.TextChanged += new System.EventHandler(this.partytxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Section";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // secTxt
            // 
            this.secTxt.Location = new System.Drawing.Point(40, 259);
            this.secTxt.Name = "secTxt";
            this.secTxt.Size = new System.Drawing.Size(187, 20);
            this.secTxt.TabIndex = 15;
            this.secTxt.TextChanged += new System.EventHandler(this.secTxt_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(40, 451);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Return";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Program";
            // 
            // progTxt
            // 
            this.progTxt.Location = new System.Drawing.Point(40, 298);
            this.progTxt.Name = "progTxt";
            this.progTxt.Size = new System.Drawing.Size(187, 20);
            this.progTxt.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Level";
            // 
            // levelTxt
            // 
            this.levelTxt.Location = new System.Drawing.Point(40, 337);
            this.levelTxt.Name = "levelTxt";
            this.levelTxt.Size = new System.Drawing.Size(187, 20);
            this.levelTxt.TabIndex = 20;
            // 
            // Candidates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 503);
            this.Controls.Add(this.levelTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.secTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.partytxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.posTxt);
            this.Controls.Add(this.studNameTxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Candidates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Candidates";
            this.Load += new System.EventHandler(this.Candidates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox studNameTxt;
        private System.Windows.Forms.TextBox posTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox partytxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox secTxt;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox progTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox levelTxt;
    }
}