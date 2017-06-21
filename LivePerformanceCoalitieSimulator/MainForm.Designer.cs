namespace LivePerformanceCoalitieSimulator
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
            this.NieuwUitslagbtn = new System.Windows.Forms.Button();
            this.UitslagAanpassenbtn = new System.Windows.Forms.Button();
            this.NieuwPartijbtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.Refreshbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // NieuwUitslagbtn
            // 
            this.NieuwUitslagbtn.Location = new System.Drawing.Point(12, 41);
            this.NieuwUitslagbtn.Name = "NieuwUitslagbtn";
            this.NieuwUitslagbtn.Size = new System.Drawing.Size(110, 23);
            this.NieuwUitslagbtn.TabIndex = 0;
            this.NieuwUitslagbtn.Text = "Nieuw Uitslag";
            this.NieuwUitslagbtn.UseVisualStyleBackColor = true;
            this.NieuwUitslagbtn.Click += new System.EventHandler(this.NieuwUitslagbtn_Click);
            // 
            // UitslagAanpassenbtn
            // 
            this.UitslagAanpassenbtn.Location = new System.Drawing.Point(12, 70);
            this.UitslagAanpassenbtn.Name = "UitslagAanpassenbtn";
            this.UitslagAanpassenbtn.Size = new System.Drawing.Size(110, 23);
            this.UitslagAanpassenbtn.TabIndex = 1;
            this.UitslagAanpassenbtn.Text = "Uitslag Aanpassen";
            this.UitslagAanpassenbtn.UseVisualStyleBackColor = true;
            this.UitslagAanpassenbtn.Click += new System.EventHandler(this.UitslagAanpassenbtn_Click);
            // 
            // NieuwPartijbtn
            // 
            this.NieuwPartijbtn.Location = new System.Drawing.Point(12, 383);
            this.NieuwPartijbtn.Name = "NieuwPartijbtn";
            this.NieuwPartijbtn.Size = new System.Drawing.Size(110, 23);
            this.NieuwPartijbtn.TabIndex = 2;
            this.NieuwPartijbtn.Text = "Nieuw Partij";
            this.NieuwPartijbtn.UseVisualStyleBackColor = true;
            this.NieuwPartijbtn.Click += new System.EventHandler(this.NieuwPartijbtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 440);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Partij Verdwijderen";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(145, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(307, 393);
            this.dataGridView1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(458, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 393);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zetels voor uitslag van:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Verkiezingsnaam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Statistieken Uitslag";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(799, 440);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Coalitie Aanmaken";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(915, 440);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Coalitie Exporteren";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(816, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(335, 393);
            this.dataGridView2.TabIndex = 10;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1031, 440);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "Coalitie Verdwijderen";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(813, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Coalities";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 412);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 23);
            this.button8.TabIndex = 13;
            this.button8.Text = "Partij Aanpassen";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.Location = new System.Drawing.Point(12, 99);
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(110, 23);
            this.Refreshbtn.TabIndex = 14;
            this.Refreshbtn.Text = "Refresh";
            this.Refreshbtn.UseVisualStyleBackColor = true;
            this.Refreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 492);
            this.Controls.Add(this.Refreshbtn);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.NieuwPartijbtn);
            this.Controls.Add(this.UitslagAanpassenbtn);
            this.Controls.Add(this.NieuwUitslagbtn);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NieuwUitslagbtn;
        private System.Windows.Forms.Button UitslagAanpassenbtn;
        private System.Windows.Forms.Button NieuwPartijbtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button Refreshbtn;
    }
}

