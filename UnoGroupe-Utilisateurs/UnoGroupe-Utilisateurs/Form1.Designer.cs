namespace UnoGroupe_Utilisateurs
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstGroups = new System.Windows.Forms.ListBox();
            this.lstFriends = new System.Windows.Forms.ListBox();
            this.refresh = new System.Windows.Forms.Button();
            this.lstFriendsOfGroup = new System.Windows.Forms.ListBox();
            this.btnDelFriendInGroup = new System.Windows.Forms.Button();
            this.btnAddFriendInGroup = new System.Windows.Forms.Button();
            this.btnDelGroup = new System.Windows.Forms.Button();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.btnDelFriend = new System.Windows.Forms.Button();
            this.btnAddFriend = new System.Windows.Forms.Button();
            this.txtFriend = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstGroups
            // 
            this.lstGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstGroups.FormattingEnabled = true;
            this.lstGroups.Location = new System.Drawing.Point(263, 40);
            this.lstGroups.Name = "lstGroups";
            this.lstGroups.Size = new System.Drawing.Size(248, 301);
            this.lstGroups.TabIndex = 0;
            this.lstGroups.SelectedIndexChanged += new System.EventHandler(this.lstGroups_SelectedIndexChanged);
            // 
            // lstFriends
            // 
            this.lstFriends.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstFriends.FormattingEnabled = true;
            this.lstFriends.Location = new System.Drawing.Point(3, 40);
            this.lstFriends.Name = "lstFriends";
            this.lstFriends.Size = new System.Drawing.Size(248, 301);
            this.lstFriends.TabIndex = 1;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.White;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Location = new System.Drawing.Point(263, 3);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(250, 31);
            this.refresh.TabIndex = 2;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // lstFriendsOfGroup
            // 
            this.lstFriendsOfGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstFriendsOfGroup.FormattingEnabled = true;
            this.lstFriendsOfGroup.Location = new System.Drawing.Point(523, 40);
            this.lstFriendsOfGroup.Name = "lstFriendsOfGroup";
            this.lstFriendsOfGroup.Size = new System.Drawing.Size(250, 301);
            this.lstFriendsOfGroup.TabIndex = 3;
            // 
            // btnDelFriendInGroup
            // 
            this.btnDelFriendInGroup.BackColor = System.Drawing.Color.White;
            this.btnDelFriendInGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelFriendInGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelFriendInGroup.Location = new System.Drawing.Point(523, 390);
            this.btnDelFriendInGroup.Name = "btnDelFriendInGroup";
            this.btnDelFriendInGroup.Size = new System.Drawing.Size(250, 37);
            this.btnDelFriendInGroup.TabIndex = 4;
            this.btnDelFriendInGroup.Text = "Supprimer du groupe";
            this.btnDelFriendInGroup.UseVisualStyleBackColor = false;
            this.btnDelFriendInGroup.Click += new System.EventHandler(this.btnDelFriendInGroup_Click);
            // 
            // btnAddFriendInGroup
            // 
            this.btnAddFriendInGroup.BackColor = System.Drawing.Color.White;
            this.btnAddFriendInGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFriendInGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFriendInGroup.Location = new System.Drawing.Point(523, 347);
            this.btnAddFriendInGroup.Name = "btnAddFriendInGroup";
            this.btnAddFriendInGroup.Size = new System.Drawing.Size(253, 36);
            this.btnAddFriendInGroup.TabIndex = 5;
            this.btnAddFriendInGroup.Text = "Ajouter au groupe";
            this.btnAddFriendInGroup.UseVisualStyleBackColor = false;
            this.btnAddFriendInGroup.Click += new System.EventHandler(this.btnAddFriendInGroup_Click);
            // 
            // btnDelGroup
            // 
            this.btnDelGroup.BackColor = System.Drawing.Color.White;
            this.btnDelGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelGroup.Location = new System.Drawing.Point(263, 390);
            this.btnDelGroup.Name = "btnDelGroup";
            this.btnDelGroup.Size = new System.Drawing.Size(248, 36);
            this.btnDelGroup.TabIndex = 6;
            this.btnDelGroup.Text = "Supprimer le groupe";
            this.btnDelGroup.UseVisualStyleBackColor = false;
            this.btnDelGroup.Click += new System.EventHandler(this.btnDelGroup_Click);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.BackColor = System.Drawing.Color.White;
            this.btnAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGroup.Location = new System.Drawing.Point(263, 347);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(248, 36);
            this.btnAddGroup.TabIndex = 7;
            this.btnAddGroup.Text = "Nouveau groupe";
            this.btnAddGroup.UseVisualStyleBackColor = false;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnDelFriend
            // 
            this.btnDelFriend.BackColor = System.Drawing.Color.White;
            this.btnDelFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelFriend.Location = new System.Drawing.Point(3, 390);
            this.btnDelFriend.Name = "btnDelFriend";
            this.btnDelFriend.Size = new System.Drawing.Size(248, 36);
            this.btnDelFriend.TabIndex = 8;
            this.btnDelFriend.Text = "Supprimer";
            this.btnDelFriend.UseVisualStyleBackColor = false;
            this.btnDelFriend.Click += new System.EventHandler(this.btnDelFriend_Click);
            // 
            // btnAddFriend
            // 
            this.btnAddFriend.BackColor = System.Drawing.Color.White;
            this.btnAddFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFriend.Location = new System.Drawing.Point(3, 347);
            this.btnAddFriend.Name = "btnAddFriend";
            this.btnAddFriend.Size = new System.Drawing.Size(248, 36);
            this.btnAddFriend.TabIndex = 9;
            this.btnAddFriend.Text = "Ajouter";
            this.btnAddFriend.UseVisualStyleBackColor = false;
            this.btnAddFriend.Click += new System.EventHandler(this.btnAddFriend_Click);
            // 
            // txtFriend
            // 
            this.txtFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFriend.Location = new System.Drawing.Point(3, 3);
            this.txtFriend.Name = "txtFriend";
            this.txtFriend.Size = new System.Drawing.Size(250, 29);
            this.txtFriend.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnDelFriendInGroup, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAddFriendInGroup, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDelGroup, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAddGroup, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDelFriend, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAddFriend, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lstFriends, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lstGroups, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lstFriendsOfGroup, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtFriend, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.refresh, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.604651F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.39535F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0939F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.624413F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 430);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstGroups;
        private System.Windows.Forms.ListBox lstFriends;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.ListBox lstFriendsOfGroup;
        private System.Windows.Forms.Button btnDelFriendInGroup;
        private System.Windows.Forms.Button btnAddFriendInGroup;
        private System.Windows.Forms.Button btnDelGroup;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Button btnDelFriend;
        private System.Windows.Forms.Button btnAddFriend;
        private System.Windows.Forms.TextBox txtFriend;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

