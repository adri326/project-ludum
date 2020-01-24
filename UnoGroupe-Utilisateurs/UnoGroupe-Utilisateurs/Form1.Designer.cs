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
            this.button1 = new System.Windows.Forms.Button();
            this.lstFriendsOfGroup = new System.Windows.Forms.ListBox();
            this.btnDelFriendInGroup = new System.Windows.Forms.Button();
            this.btnAddFriendInGroup = new System.Windows.Forms.Button();
            this.btnDelGroup = new System.Windows.Forms.Button();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.btnDelFriend = new System.Windows.Forms.Button();
            this.btnAddFriend = new System.Windows.Forms.Button();
            this.txtFriend = new System.Windows.Forms.TextBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstGroups
            // 
            this.lstGroups.FormattingEnabled = true;
            this.lstGroups.Location = new System.Drawing.Point(181, 107);
            this.lstGroups.Name = "lstGroups";
            this.lstGroups.Size = new System.Drawing.Size(120, 95);
            this.lstGroups.TabIndex = 0;
            this.lstGroups.SelectedIndexChanged += new System.EventHandler(this.lstGroups_SelectedIndexChanged);
            // 
            // lstFriends
            // 
            this.lstFriends.FormattingEnabled = true;
            this.lstFriends.Location = new System.Drawing.Point(23, 107);
            this.lstFriends.Name = "lstFriends";
            this.lstFriends.Size = new System.Drawing.Size(120, 95);
            this.lstFriends.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstFriendsOfGroup
            // 
            this.lstFriendsOfGroup.FormattingEnabled = true;
            this.lstFriendsOfGroup.Location = new System.Drawing.Point(397, 107);
            this.lstFriendsOfGroup.Name = "lstFriendsOfGroup";
            this.lstFriendsOfGroup.Size = new System.Drawing.Size(120, 95);
            this.lstFriendsOfGroup.TabIndex = 3;
            // 
            // btnDelFriendInGroup
            // 
            this.btnDelFriendInGroup.Location = new System.Drawing.Point(415, 237);
            this.btnDelFriendInGroup.Name = "btnDelFriendInGroup";
            this.btnDelFriendInGroup.Size = new System.Drawing.Size(75, 23);
            this.btnDelFriendInGroup.TabIndex = 4;
            this.btnDelFriendInGroup.Text = "button2";
            this.btnDelFriendInGroup.UseVisualStyleBackColor = true;
            // 
            // btnAddFriendInGroup
            // 
            this.btnAddFriendInGroup.Location = new System.Drawing.Point(415, 208);
            this.btnAddFriendInGroup.Name = "btnAddFriendInGroup";
            this.btnAddFriendInGroup.Size = new System.Drawing.Size(75, 23);
            this.btnAddFriendInGroup.TabIndex = 5;
            this.btnAddFriendInGroup.Text = "button3";
            this.btnAddFriendInGroup.UseVisualStyleBackColor = true;
            // 
            // btnDelGroup
            // 
            this.btnDelGroup.Location = new System.Drawing.Point(205, 237);
            this.btnDelGroup.Name = "btnDelGroup";
            this.btnDelGroup.Size = new System.Drawing.Size(75, 23);
            this.btnDelGroup.TabIndex = 6;
            this.btnDelGroup.Text = "button4";
            this.btnDelGroup.UseVisualStyleBackColor = true;
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Location = new System.Drawing.Point(205, 208);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(75, 23);
            this.btnAddGroup.TabIndex = 7;
            this.btnAddGroup.Text = "button5";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnDelFriend
            // 
            this.btnDelFriend.Location = new System.Drawing.Point(46, 237);
            this.btnDelFriend.Name = "btnDelFriend";
            this.btnDelFriend.Size = new System.Drawing.Size(75, 23);
            this.btnDelFriend.TabIndex = 8;
            this.btnDelFriend.Text = "button6";
            this.btnDelFriend.UseVisualStyleBackColor = true;
            this.btnDelFriend.Click += new System.EventHandler(this.btnDelFriend_Click);
            // 
            // btnAddFriend
            // 
            this.btnAddFriend.Location = new System.Drawing.Point(46, 208);
            this.btnAddFriend.Name = "btnAddFriend";
            this.btnAddFriend.Size = new System.Drawing.Size(75, 23);
            this.btnAddFriend.TabIndex = 9;
            this.btnAddFriend.Text = "button7";
            this.btnAddFriend.UseVisualStyleBackColor = true;
            this.btnAddFriend.Click += new System.EventHandler(this.btnAddFriend_Click);
            // 
            // txtFriend
            // 
            this.txtFriend.Location = new System.Drawing.Point(23, 81);
            this.txtFriend.Name = "txtFriend";
            this.txtFriend.Size = new System.Drawing.Size(100, 20);
            this.txtFriend.TabIndex = 10;
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(180, 81);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(100, 20);
            this.txtGroup.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.txtFriend);
            this.Controls.Add(this.btnAddFriend);
            this.Controls.Add(this.btnDelFriend);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.btnDelGroup);
            this.Controls.Add(this.btnAddFriendInGroup);
            this.Controls.Add(this.btnDelFriendInGroup);
            this.Controls.Add(this.lstFriendsOfGroup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstFriends);
            this.Controls.Add(this.lstGroups);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGroups;
        private System.Windows.Forms.ListBox lstFriends;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstFriendsOfGroup;
        private System.Windows.Forms.Button btnDelFriendInGroup;
        private System.Windows.Forms.Button btnAddFriendInGroup;
        private System.Windows.Forms.Button btnDelGroup;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Button btnDelFriend;
        private System.Windows.Forms.Button btnAddFriend;
        private System.Windows.Forms.TextBox txtFriend;
        private System.Windows.Forms.TextBox txtGroup;
    }
}

