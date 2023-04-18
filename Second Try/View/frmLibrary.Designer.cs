namespace View
{
    partial class frmLibrary 
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnBorrowingList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.btnRemoveBookCopy = new System.Windows.Forms.Button();
            this.btnAddBookCopy = new System.Windows.Forms.Button();
            this.btnBookCopyList = new System.Windows.Forms.Button();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnMemberList = new System.Windows.Forms.Button();
            this.btnReturnCopy = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBorrowingList
            // 
            this.btnBorrowingList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.btnBorrowingList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(201)))));
            this.btnBorrowingList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowingList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBorrowingList.Location = new System.Drawing.Point(182, 436);
            this.btnBorrowingList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBorrowingList.Name = "btnBorrowingList";
            this.btnBorrowingList.Size = new System.Drawing.Size(136, 59);
            this.btnBorrowingList.TabIndex = 7;
            this.btnBorrowingList.Text = "Historial de Prestamos";
            this.btnBorrowingList.UseVisualStyleBackColor = false;
            this.btnBorrowingList.Click += new System.EventHandler(this.btnBorrowingList_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(174)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(4, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Libros";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(163)))), ((int)(((byte)(115)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(7, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(488, 51);
            this.label4.TabIndex = 12;
            this.label4.Text = "  BIBLIOTECA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(237)))), ((int)(((byte)(205)))));
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Time);
            this.panel1.Controls.Add(this.btnRemoveBookCopy);
            this.panel1.Controls.Add(this.btnAddBookCopy);
            this.panel1.Controls.Add(this.btnBookCopyList);
            this.panel1.Controls.Add(this.btnRemoveMember);
            this.panel1.Controls.Add(this.btnAddMember);
            this.panel1.Controls.Add(this.btnMemberList);
            this.panel1.Controls.Add(this.btnReturnCopy);
            this.panel1.Controls.Add(this.btnBorrow);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBorrowingList);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 577);
            this.panel1.TabIndex = 13;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(163)))), ((int)(((byte)(115)))));
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(163)))), ((int)(((byte)(115)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Image = global::View.Properties.Resources.Close_Icon_icon_icons_com_69144;
            this.Exit.Location = new System.Drawing.Point(454, 0);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(40, 25);
            this.Exit.TabIndex = 21;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Time.Location = new System.Drawing.Point(178, 75);
            this.Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(12, 15);
            this.Time.TabIndex = 20;
            this.Time.Text = "-";
            // 
            // btnRemoveBookCopy
            // 
            this.btnRemoveBookCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.btnRemoveBookCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(201)))));
            this.btnRemoveBookCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveBookCopy.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveBookCopy.Location = new System.Drawing.Point(343, 160);
            this.btnRemoveBookCopy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemoveBookCopy.Name = "btnRemoveBookCopy";
            this.btnRemoveBookCopy.Size = new System.Drawing.Size(136, 59);
            this.btnRemoveBookCopy.TabIndex = 19;
            this.btnRemoveBookCopy.Text = "Remover Libro/Ejemplar";
            this.btnRemoveBookCopy.UseVisualStyleBackColor = false;
            this.btnRemoveBookCopy.Click += new System.EventHandler(this.btnRemoveBookCopy_Click);
            // 
            // btnAddBookCopy
            // 
            this.btnAddBookCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.btnAddBookCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(201)))));
            this.btnAddBookCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBookCopy.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddBookCopy.Location = new System.Drawing.Point(20, 160);
            this.btnAddBookCopy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddBookCopy.Name = "btnAddBookCopy";
            this.btnAddBookCopy.Size = new System.Drawing.Size(136, 59);
            this.btnAddBookCopy.TabIndex = 18;
            this.btnAddBookCopy.Text = "Agregar Libro/Ejemplar";
            this.btnAddBookCopy.UseVisualStyleBackColor = false;
            this.btnAddBookCopy.Click += new System.EventHandler(this.btnAddBookCopy_Click);
            // 
            // btnBookCopyList
            // 
            this.btnBookCopyList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.btnBookCopyList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(201)))));
            this.btnBookCopyList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookCopyList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBookCopyList.Location = new System.Drawing.Point(182, 160);
            this.btnBookCopyList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBookCopyList.Name = "btnBookCopyList";
            this.btnBookCopyList.Size = new System.Drawing.Size(136, 59);
            this.btnBookCopyList.TabIndex = 17;
            this.btnBookCopyList.Text = "Lista de Libros y Ejemplares";
            this.btnBookCopyList.UseVisualStyleBackColor = false;
            this.btnBookCopyList.Click += new System.EventHandler(this.btnBookCopyList_Click);
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.btnRemoveMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(201)))));
            this.btnRemoveMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveMember.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveMember.Location = new System.Drawing.Point(343, 298);
            this.btnRemoveMember.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(136, 59);
            this.btnRemoveMember.TabIndex = 16;
            this.btnRemoveMember.Text = "Remover Miembro";
            this.btnRemoveMember.UseVisualStyleBackColor = false;
            this.btnRemoveMember.Click += new System.EventHandler(this.btnRemoveMember_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.btnAddMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(201)))));
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddMember.Location = new System.Drawing.Point(20, 298);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(136, 59);
            this.btnAddMember.TabIndex = 15;
            this.btnAddMember.Text = "Agregar Miembro";
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnMemberList
            // 
            this.btnMemberList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.btnMemberList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(201)))));
            this.btnMemberList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMemberList.Location = new System.Drawing.Point(182, 298);
            this.btnMemberList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMemberList.Name = "btnMemberList";
            this.btnMemberList.Size = new System.Drawing.Size(136, 59);
            this.btnMemberList.TabIndex = 14;
            this.btnMemberList.Text = "Lista de Miembros";
            this.btnMemberList.UseVisualStyleBackColor = false;
            this.btnMemberList.Click += new System.EventHandler(this.btnMemberList_Click);
            // 
            // btnReturnCopy
            // 
            this.btnReturnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.btnReturnCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(201)))));
            this.btnReturnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnCopy.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReturnCopy.Location = new System.Drawing.Point(343, 436);
            this.btnReturnCopy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReturnCopy.Name = "btnReturnCopy";
            this.btnReturnCopy.Size = new System.Drawing.Size(136, 59);
            this.btnReturnCopy.TabIndex = 13;
            this.btnReturnCopy.Text = "Devolver Ejemplar";
            this.btnReturnCopy.UseVisualStyleBackColor = false;
            this.btnReturnCopy.Click += new System.EventHandler(this.btnReturnCopy_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.btnBorrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(201)))));
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrow.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBorrow.Location = new System.Drawing.Point(20, 436);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(136, 59);
            this.btnBorrow.TabIndex = 12;
            this.btnBorrow.Text = "Prestar Ejemplar";
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(174)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(5, 385);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(490, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Prestamos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(213)))), ((int)(((byte)(174)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(5, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(490, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Miembros";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 520);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(504, 559);
            this.MinimumSize = new System.Drawing.Size(504, 559);
            this.Name = "frmLibrary";
            this.Text = "Biblioteca Administracion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBorrowingList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Button btnRemoveBookCopy;
        private System.Windows.Forms.Button btnAddBookCopy;
        private System.Windows.Forms.Button btnBookCopyList;
        private System.Windows.Forms.Button btnRemoveMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnMemberList;
        private System.Windows.Forms.Button btnReturnCopy;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Exit;
    }
}

