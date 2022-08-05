namespace phoneContact
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
            this.add_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.id_btn = new System.Windows.Forms.Label();
            this.name_btn = new System.Windows.Forms.Label();
            this.last_btn = new System.Windows.Forms.Label();
            this.phone_btn = new System.Windows.Forms.Label();
            this.id_lbl = new System.Windows.Forms.TextBox();
            this.name_lbl = new System.Windows.Forms.TextBox();
            this.last_lbl = new System.Windows.Forms.TextBox();
            this.phone_lbl = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Label();
            this.search_lbl = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.srch_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.add_btn.Location = new System.Drawing.Point(408, 12);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(150, 68);
            this.add_btn.TabIndex = 0;
            this.add_btn.Text = "Add!";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.remove_btn.Location = new System.Drawing.Point(408, 86);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(150, 68);
            this.remove_btn.TabIndex = 1;
            this.remove_btn.Text = "Remove!";
            this.remove_btn.UseVisualStyleBackColor = false;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.update_btn.Location = new System.Drawing.Point(408, 160);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(150, 68);
            this.update_btn.TabIndex = 2;
            this.update_btn.Text = "Update!";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // id_btn
            // 
            this.id_btn.AutoSize = true;
            this.id_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.id_btn.Location = new System.Drawing.Point(89, 19);
            this.id_btn.Name = "id_btn";
            this.id_btn.Size = new System.Drawing.Size(28, 17);
            this.id_btn.TabIndex = 3;
            this.id_btn.Text = "ID:";
            // 
            // name_btn
            // 
            this.name_btn.AutoSize = true;
            this.name_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name_btn.Location = new System.Drawing.Point(61, 48);
            this.name_btn.Name = "name_btn";
            this.name_btn.Size = new System.Drawing.Size(56, 17);
            this.name_btn.TabIndex = 4;
            this.name_btn.Text = "NAME:";
            // 
            // last_btn
            // 
            this.last_btn.AutoSize = true;
            this.last_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.last_btn.Location = new System.Drawing.Point(22, 81);
            this.last_btn.Name = "last_btn";
            this.last_btn.Size = new System.Drawing.Size(95, 17);
            this.last_btn.TabIndex = 5;
            this.last_btn.Text = "LASTNAME:";
            // 
            // phone_btn
            // 
            this.phone_btn.AutoSize = true;
            this.phone_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phone_btn.Location = new System.Drawing.Point(50, 115);
            this.phone_btn.Name = "phone_btn";
            this.phone_btn.Size = new System.Drawing.Size(67, 17);
            this.phone_btn.TabIndex = 6;
            this.phone_btn.Text = "PHONE:";
            // 
            // id_lbl
            // 
            this.id_lbl.Location = new System.Drawing.Point(123, 14);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(170, 22);
            this.id_lbl.TabIndex = 7;
            // 
            // name_lbl
            // 
            this.name_lbl.Location = new System.Drawing.Point(123, 45);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(170, 22);
            this.name_lbl.TabIndex = 8;
            // 
            // last_lbl
            // 
            this.last_lbl.Location = new System.Drawing.Point(123, 78);
            this.last_lbl.Name = "last_lbl";
            this.last_lbl.Size = new System.Drawing.Size(170, 22);
            this.last_lbl.TabIndex = 9;
            // 
            // phone_lbl
            // 
            this.phone_lbl.Location = new System.Drawing.Point(123, 110);
            this.phone_lbl.Name = "phone_lbl";
            this.phone_lbl.Size = new System.Drawing.Size(170, 22);
            this.phone_lbl.TabIndex = 10;
            // 
            // search_btn
            // 
            this.search_btn.AutoSize = true;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.search_btn.Location = new System.Drawing.Point(22, 187);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(120, 17);
            this.search_btn.TabIndex = 11;
            this.search_btn.Text = "SEARCH BY ID:";
            // 
            // search_lbl
            // 
            this.search_lbl.Location = new System.Drawing.Point(143, 181);
            this.search_lbl.Name = "search_lbl";
            this.search_lbl.Size = new System.Drawing.Size(65, 22);
            this.search_lbl.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(533, 307);
            this.dataGridView1.TabIndex = 13;
            // 
            // srch_btn
            // 
            this.srch_btn.Location = new System.Drawing.Point(214, 180);
            this.srch_btn.Name = "srch_btn";
            this.srch_btn.Size = new System.Drawing.Size(67, 23);
            this.srch_btn.TabIndex = 14;
            this.srch_btn.Text = "Search!";
            this.srch_btn.UseVisualStyleBackColor = true;
            this.srch_btn.Click += new System.EventHandler(this.srch_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.srch_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search_lbl);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.phone_lbl);
            this.Controls.Add(this.last_lbl);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.phone_btn);
            this.Controls.Add(this.last_btn);
            this.Controls.Add(this.name_btn);
            this.Controls.Add(this.id_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.add_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phone Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label id_btn;
        private System.Windows.Forms.Label name_btn;
        private System.Windows.Forms.Label last_btn;
        private System.Windows.Forms.Label phone_btn;
        private System.Windows.Forms.TextBox id_lbl;
        private System.Windows.Forms.TextBox name_lbl;
        private System.Windows.Forms.TextBox last_lbl;
        private System.Windows.Forms.TextBox phone_lbl;
        private System.Windows.Forms.Label search_btn;
        private System.Windows.Forms.TextBox search_lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button srch_btn;
    }
}