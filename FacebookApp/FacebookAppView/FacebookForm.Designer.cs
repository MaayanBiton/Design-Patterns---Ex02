namespace FacebookApp
{
    partial class FacebookForm
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label messageLabel;
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.postAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelHometown = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.buttonPost = new System.Windows.Forms.Button();
            this.pictureBoxLittleProfile = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.buttonMatch = new System.Windows.Forms.Button();
            this.buttonSortLikes = new System.Windows.Forms.Button();
            this.labelFindMatch = new System.Windows.Forms.Label();
            this.labelSortLikes = new System.Windows.Forms.Label();
            this.checkBoxMale = new System.Windows.Forms.CheckBox();
            this.checkBoxFemale = new System.Windows.Forms.CheckBox();
            this.comboBoxAges = new System.Windows.Forms.ComboBox();
            this.labelPost = new System.Windows.Forms.Label();
            this.labelPsots = new System.Windows.Forms.Label();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.labelMyFacebookFriends = new System.Windows.Forms.Label();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.checkinsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelCheckIns = new System.Windows.Forms.Label();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.labelWriteToFile = new System.Windows.Forms.Label();
            this.textBoxToFile = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            nameLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLittleProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkinsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nameLabel.Location = new System.Drawing.Point(718, 171);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(52, 21);
            nameLabel.TabIndex = 32;
            nameLabel.Text = "From:";
            nameLabel.Visible = false;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            messageLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            messageLabel.Location = new System.Drawing.Point(652, 233);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(113, 21);
            messageLabel.TabIndex = 33;
            messageLabel.Text = "Edit the post:";
            messageLabel.Visible = false;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonLogIn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.ForeColor = System.Drawing.Color.White;
            this.buttonLogIn.Location = new System.Drawing.Point(953, 32);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(115, 48);
            this.buttonLogIn.TabIndex = 0;
            this.buttonLogIn.Text = "LOG IN";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Image = global::FacebookApp.Properties.Resources.icons8_facebook_100;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1134, 138);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.BackColor = System.Drawing.Color.SteelBlue;
            this.checkBoxRememberMe.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRememberMe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(956, 93);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(151, 25);
            this.checkBoxRememberMe.TabIndex = 3;
            this.checkBoxRememberMe.Text = "Remember me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = false;
            this.checkBoxRememberMe.CheckedChanged += new System.EventHandler(this.checkBoxRememberMe_CheckedChanged);
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(38, 171);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(192, 142);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilePicture.TabIndex = 4;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.DataSource = this.postAdapterBindingSource;
            this.listBoxPosts.DisplayMember = "NewPost";
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 20;
            this.listBoxPosts.Location = new System.Drawing.Point(855, 172);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(259, 164);
            this.listBoxPosts.TabIndex = 10;
            this.listBoxPosts.Visible = false;
            // 
            // postAdapterBindingSource
            // 
            this.postAdapterBindingSource.DataSource = typeof(FacebookApp.PostAdapter);
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // textBoxPost
            // 
            this.textBoxPost.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxPost.Location = new System.Drawing.Point(416, 44);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPost.Size = new System.Drawing.Size(203, 71);
            this.textBoxPost.TabIndex = 11;
            this.textBoxPost.Visible = false;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.labelFullName.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFullName.Location = new System.Drawing.Point(236, 171);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(120, 21);
            this.labelFullName.TabIndex = 12;
            this.labelFullName.Text = "labelFullName";
            this.labelFullName.Visible = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.labelEmail.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEmail.Location = new System.Drawing.Point(236, 292);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(89, 21);
            this.labelEmail.TabIndex = 13;
            this.labelEmail.Text = "labelEmail";
            this.labelEmail.Visible = false;
            // 
            // labelHometown
            // 
            this.labelHometown.AutoSize = true;
            this.labelHometown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Hometown", true));
            this.labelHometown.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHometown.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHometown.Location = new System.Drawing.Point(236, 265);
            this.labelHometown.Name = "labelHometown";
            this.labelHometown.Size = new System.Drawing.Size(135, 21);
            this.labelHometown.TabIndex = 14;
            this.labelHometown.Text = "labelHometown";
            this.labelHometown.Visible = false;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Gender", true));
            this.labelGender.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGender.Location = new System.Drawing.Point(236, 232);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(108, 21);
            this.labelGender.TabIndex = 15;
            this.labelGender.Text = "labelGender";
            this.labelGender.Visible = false;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.labelBirthday.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthday.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBirthday.Location = new System.Drawing.Point(236, 202);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(112, 21);
            this.labelBirthday.TabIndex = 16;
            this.labelBirthday.Text = "labelBirthday";
            this.labelBirthday.Visible = false;
            // 
            // buttonPost
            // 
            this.buttonPost.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonPost.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPost.Location = new System.Drawing.Point(635, 80);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(72, 35);
            this.buttonPost.TabIndex = 17;
            this.buttonPost.Text = "POST";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Visible = false;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // pictureBoxLittleProfile
            // 
            this.pictureBoxLittleProfile.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBoxLittleProfile.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageSmall", true));
            this.pictureBoxLittleProfile.Location = new System.Drawing.Point(158, 48);
            this.pictureBoxLittleProfile.Name = "pictureBoxLittleProfile";
            this.pictureBoxLittleProfile.Size = new System.Drawing.Size(58, 54);
            this.pictureBoxLittleProfile.TabIndex = 18;
            this.pictureBoxLittleProfile.TabStop = false;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.Color.SteelBlue;
            this.labelFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "FirstName", true));
            this.labelFirstName.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFirstName.Location = new System.Drawing.Point(223, 65);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(125, 19);
            this.labelFirstName.TabIndex = 19;
            this.labelFirstName.Text = "labelFirstName";
            this.labelFirstName.Visible = false;
            // 
            // buttonMatch
            // 
            this.buttonMatch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonMatch.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMatch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMatch.Location = new System.Drawing.Point(61, 594);
            this.buttonMatch.Name = "buttonMatch";
            this.buttonMatch.Size = new System.Drawing.Size(83, 36);
            this.buttonMatch.TabIndex = 20;
            this.buttonMatch.Text = "FIND ";
            this.buttonMatch.UseVisualStyleBackColor = false;
            this.buttonMatch.Visible = false;
            this.buttonMatch.Click += new System.EventHandler(this.buttonMatch_Click);
            // 
            // buttonSortLikes
            // 
            this.buttonSortLikes.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSortLikes.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortLikes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSortLikes.Location = new System.Drawing.Point(61, 425);
            this.buttonSortLikes.Name = "buttonSortLikes";
            this.buttonSortLikes.Size = new System.Drawing.Size(83, 34);
            this.buttonSortLikes.TabIndex = 21;
            this.buttonSortLikes.Text = "SORT";
            this.buttonSortLikes.UseVisualStyleBackColor = false;
            this.buttonSortLikes.Visible = false;
            this.buttonSortLikes.Click += new System.EventHandler(this.buttonSortLikes_Click);
            // 
            // labelFindMatch
            // 
            this.labelFindMatch.AutoSize = true;
            this.labelFindMatch.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFindMatch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFindMatch.Location = new System.Drawing.Point(19, 495);
            this.labelFindMatch.Name = "labelFindMatch";
            this.labelFindMatch.Size = new System.Drawing.Size(185, 19);
            this.labelFindMatch.TabIndex = 22;
            this.labelFindMatch.Text = "FIND OPTIONAL MATCH";
            this.labelFindMatch.Visible = false;
            // 
            // labelSortLikes
            // 
            this.labelSortLikes.AutoSize = true;
            this.labelSortLikes.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSortLikes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSortLikes.Location = new System.Drawing.Point(5, 394);
            this.labelSortLikes.Name = "labelSortLikes";
            this.labelSortLikes.Size = new System.Drawing.Size(237, 19);
            this.labelSortLikes.TabIndex = 23;
            this.labelSortLikes.Text = "SORT FRIENDS BY PICTURE LIKES";
            this.labelSortLikes.Visible = false;
            // 
            // checkBoxMale
            // 
            this.checkBoxMale.AutoSize = true;
            this.checkBoxMale.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxMale.Location = new System.Drawing.Point(23, 523);
            this.checkBoxMale.Name = "checkBoxMale";
            this.checkBoxMale.Size = new System.Drawing.Size(75, 25);
            this.checkBoxMale.TabIndex = 24;
            this.checkBoxMale.Text = "Male";
            this.checkBoxMale.UseVisualStyleBackColor = true;
            this.checkBoxMale.Visible = false;
            // 
            // checkBoxFemale
            // 
            this.checkBoxFemale.AutoSize = true;
            this.checkBoxFemale.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFemale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxFemale.Location = new System.Drawing.Point(97, 523);
            this.checkBoxFemale.Name = "checkBoxFemale";
            this.checkBoxFemale.Size = new System.Drawing.Size(93, 25);
            this.checkBoxFemale.TabIndex = 25;
            this.checkBoxFemale.Text = "Female";
            this.checkBoxFemale.UseVisualStyleBackColor = true;
            this.checkBoxFemale.Visible = false;
            // 
            // comboBoxAges
            // 
            this.comboBoxAges.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAges.FormattingEnabled = true;
            this.comboBoxAges.Location = new System.Drawing.Point(23, 554);
            this.comboBoxAges.Name = "comboBoxAges";
            this.comboBoxAges.Size = new System.Drawing.Size(266, 29);
            this.comboBoxAges.TabIndex = 26;
            this.comboBoxAges.Text = "Select your desired age range";
            this.comboBoxAges.Visible = false;
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.BackColor = System.Drawing.Color.SteelBlue;
            this.labelPost.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPost.Location = new System.Drawing.Point(412, 12);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(152, 21);
            this.labelPost.TabIndex = 27;
            this.labelPost.Text = "Share something...";
            this.labelPost.Visible = false;
            // 
            // labelPsots
            // 
            this.labelPsots.AutoSize = true;
            this.labelPsots.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelPsots.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPsots.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPsots.Location = new System.Drawing.Point(851, 141);
            this.labelPsots.Name = "labelPsots";
            this.labelPsots.Size = new System.Drawing.Size(55, 22);
            this.labelPsots.TabIndex = 28;
            this.labelPsots.Text = "Posts";
            this.labelPsots.Visible = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 20;
            this.listBoxFriends.Location = new System.Drawing.Point(311, 413);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(192, 244);
            this.listBoxFriends.TabIndex = 29;
            this.listBoxFriends.Visible = false;
            // 
            // labelMyFacebookFriends
            // 
            this.labelMyFacebookFriends.AutoSize = true;
            this.labelMyFacebookFriends.BackColor = System.Drawing.Color.SteelBlue;
            this.labelMyFacebookFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyFacebookFriends.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMyFacebookFriends.Location = new System.Drawing.Point(307, 381);
            this.labelMyFacebookFriends.Name = "labelMyFacebookFriends";
            this.labelMyFacebookFriends.Size = new System.Drawing.Size(161, 20);
            this.labelMyFacebookFriends.TabIndex = 30;
            this.labelMyFacebookFriends.Text = "My Facebook Friends";
            this.labelMyFacebookFriends.Visible = false;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.DataSource = this.checkinsBindingSource;
            this.listBoxGroups.DisplayMember = "Name";
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 20;
            this.listBoxGroups.Location = new System.Drawing.Point(532, 413);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(192, 244);
            this.listBoxGroups.TabIndex = 29;
            this.listBoxGroups.Visible = false;
            // 
            // checkinsBindingSource
            // 
            this.checkinsBindingSource.DataMember = "Checkins";
            this.checkinsBindingSource.DataSource = this.userBindingSource;
            // 
            // labelCheckIns
            // 
            this.labelCheckIns.AutoSize = true;
            this.labelCheckIns.BackColor = System.Drawing.Color.SteelBlue;
            this.labelCheckIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckIns.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCheckIns.Location = new System.Drawing.Point(528, 381);
            this.labelCheckIns.Name = "labelCheckIns";
            this.labelCheckIns.Size = new System.Drawing.Size(166, 20);
            this.labelCheckIns.TabIndex = 30;
            this.labelCheckIns.Text = "My Checked in  places";
            this.labelCheckIns.Visible = false;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.postAdapterBindingSource, "ImageURL", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(654, 172);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(53, 51);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox.TabIndex = 31;
            this.imageNormalPictureBox.TabStop = false;
            this.imageNormalPictureBox.Visible = false;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postAdapterBindingSource, "UserName", true));
            this.nameLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel1.Location = new System.Drawing.Point(718, 200);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 33;
            this.nameLabel1.Visible = false;
            // 
            // messageTextBox
            // 
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postAdapterBindingSource, "NewPost", true));
            this.messageTextBox.Location = new System.Drawing.Point(654, 256);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(185, 79);
            this.messageTextBox.TabIndex = 34;
            this.messageTextBox.Visible = false;
            // 
            // labelWriteToFile
            // 
            this.labelWriteToFile.AutoSize = true;
            this.labelWriteToFile.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWriteToFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelWriteToFile.Location = new System.Drawing.Point(749, 381);
            this.labelWriteToFile.Name = "labelWriteToFile";
            this.labelWriteToFile.Size = new System.Drawing.Size(100, 21);
            this.labelWriteToFile.TabIndex = 36;
            this.labelWriteToFile.Text = "Write to file ";
            this.labelWriteToFile.Visible = false;
            // 
            // textBoxToFile
            // 
            this.textBoxToFile.Location = new System.Drawing.Point(753, 413);
            this.textBoxToFile.Multiline = true;
            this.textBoxToFile.Name = "textBoxToFile";
            this.textBoxToFile.ShortcutsEnabled = false;
            this.textBoxToFile.Size = new System.Drawing.Size(361, 217);
            this.textBoxToFile.TabIndex = 37;
            this.textBoxToFile.Visible = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSave.Location = new System.Drawing.Point(1019, 636);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(95, 44);
            this.buttonSave.TabIndex = 38;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            // 
            // FacebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1134, 692);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxToFile);
            this.Controls.Add(this.labelWriteToFile);
            this.Controls.Add(messageLabel);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.imageNormalPictureBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.labelCheckIns);
            this.Controls.Add(this.labelMyFacebookFriends);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.labelPsots);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.comboBoxAges);
            this.Controls.Add(this.checkBoxFemale);
            this.Controls.Add(this.checkBoxMale);
            this.Controls.Add(this.labelSortLikes);
            this.Controls.Add(this.labelFindMatch);
            this.Controls.Add(this.buttonSortLikes);
            this.Controls.Add(this.buttonMatch);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.pictureBoxLittleProfile);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelHometown);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.pictureBoxProfilePicture);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FacebookForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLittleProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkinsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelHometown;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.PictureBox pictureBoxLittleProfile;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Button buttonMatch;
        private System.Windows.Forms.Button buttonSortLikes;
        private System.Windows.Forms.Label labelFindMatch;
        private System.Windows.Forms.Label labelSortLikes;
        private System.Windows.Forms.CheckBox checkBoxMale;
        private System.Windows.Forms.CheckBox checkBoxFemale;
        private System.Windows.Forms.ComboBox comboBoxAges;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.Label labelPsots;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label labelMyFacebookFriends;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Label labelCheckIns;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label labelWriteToFile;
        private System.Windows.Forms.TextBox textBoxToFile;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource checkinsBindingSource;
        private System.Windows.Forms.BindingSource postAdapterBindingSource;
    }
}