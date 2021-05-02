namespace PartyPanelUI
{
    partial class PartyPanel
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
            this.songListView = new System.Windows.Forms.ListView();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.characteristicDropdown = new System.Windows.Forms.ComboBox();
            this.positiveModifierBox = new System.Windows.Forms.GroupBox();
            this.SuperFastSong = new System.Windows.Forms.CheckBox();
            this.FasterSong = new System.Windows.Forms.CheckBox();
            this.SlowerSong = new System.Windows.Forms.CheckBox();
            this.ZenMode = new System.Windows.Forms.CheckBox();
            this.StrictAngles = new System.Windows.Forms.CheckBox();
            this.ProMode = new System.Windows.Forms.CheckBox();
            this.SmallNotes = new System.Windows.Forms.CheckBox();
            this.DissapearingArrows = new System.Windows.Forms.CheckBox();
            this.GhostNotes = new System.Windows.Forms.CheckBox();
            this.NoArrows = new System.Windows.Forms.CheckBox();
            this.NoWalls = new System.Windows.Forms.CheckBox();
            this.NoBombs = new System.Windows.Forms.CheckBox();
            this.OneLife = new System.Windows.Forms.CheckBox();
            this.FourLives = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.NoFail = new System.Windows.Forms.CheckBox();
            this.playerSettingsBox = new System.Windows.Forms.GroupBox();
            this.ReduceDebris = new System.Windows.Forms.CheckBox();
            this.NoHud = new System.Windows.Forms.CheckBox();
            this.LeftHanded = new System.Windows.Forms.CheckBox();
            this.AdvancedHud = new System.Windows.Forms.CheckBox();
            this.returnToMenuButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.difficultyDropdown = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.positiveModifierBox.SuspendLayout();
            this.playerSettingsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // songListView
            // 
            this.songListView.BackColor = System.Drawing.Color.Gray;
            this.songListView.HideSelection = false;
            this.songListView.Location = new System.Drawing.Point(12, 38);
            this.songListView.MultiSelect = false;
            this.songListView.Name = "songListView";
            this.songListView.Size = new System.Drawing.Size(544, 820);
            this.songListView.TabIndex = 0;
            this.songListView.UseCompatibleStateImageBehavior = false;
            this.songListView.SelectedIndexChanged += new System.EventHandler(this.songListView_SelectedIndexChangedAsync);
            this.songListView.DoubleClick += new System.EventHandler(this.playButton_Click);
            // 
            // groupBox
            // 
            this.groupBox.AutoSize = true;
            this.groupBox.Controls.Add(this.groupBox1);
            this.groupBox.Controls.Add(this.characteristicDropdown);
            this.groupBox.Controls.Add(this.positiveModifierBox);
            this.groupBox.Controls.Add(this.playerSettingsBox);
            this.groupBox.Controls.Add(this.returnToMenuButton);
            this.groupBox.Controls.Add(this.playButton);
            this.groupBox.Controls.Add(this.difficultyDropdown);
            this.groupBox.Location = new System.Drawing.Point(588, 38);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(305, 825);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Options";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox8);
            this.groupBox1.Controls.Add(this.checkBox10);
            this.groupBox1.Controls.Add(this.checkBox12);
            this.groupBox1.Controls.Add(this.checkBox13);
            this.groupBox1.Location = new System.Drawing.Point(13, 470);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(278, 84);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Practice Settings";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(16, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 13);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Speed: 100%";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(5, 30);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(263, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Tag = "";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(5, -118);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(97, 17);
            this.checkBox6.TabIndex = 8;
            this.checkBox6.Text = "Reduce Debris";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(5, -140);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(102, 17);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "Advanced HUD";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(5, -185);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(84, 17);
            this.checkBox10.TabIndex = 2;
            this.checkBox10.Text = "Static Lights";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(5, -208);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(52, 17);
            this.checkBox12.TabIndex = 1;
            this.checkBox12.Text = "Mirror";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(5, -162);
            this.checkBox13.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(67, 17);
            this.checkBox13.TabIndex = 6;
            this.checkBox13.Text = "No HUD";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // characteristicDropdown
            // 
            this.characteristicDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.characteristicDropdown.FormattingEnabled = true;
            this.characteristicDropdown.Location = new System.Drawing.Point(13, 701);
            this.characteristicDropdown.Name = "characteristicDropdown";
            this.characteristicDropdown.Size = new System.Drawing.Size(174, 21);
            this.characteristicDropdown.TabIndex = 10;
            this.characteristicDropdown.SelectedIndexChanged += new System.EventHandler(this.CharacteristicDropdown_SelectedIndexChanged);
            // 
            // positiveModifierBox
            // 
            this.positiveModifierBox.Controls.Add(this.SuperFastSong);
            this.positiveModifierBox.Controls.Add(this.FasterSong);
            this.positiveModifierBox.Controls.Add(this.SlowerSong);
            this.positiveModifierBox.Controls.Add(this.ZenMode);
            this.positiveModifierBox.Controls.Add(this.StrictAngles);
            this.positiveModifierBox.Controls.Add(this.ProMode);
            this.positiveModifierBox.Controls.Add(this.SmallNotes);
            this.positiveModifierBox.Controls.Add(this.DissapearingArrows);
            this.positiveModifierBox.Controls.Add(this.GhostNotes);
            this.positiveModifierBox.Controls.Add(this.NoArrows);
            this.positiveModifierBox.Controls.Add(this.NoWalls);
            this.positiveModifierBox.Controls.Add(this.NoBombs);
            this.positiveModifierBox.Controls.Add(this.OneLife);
            this.positiveModifierBox.Controls.Add(this.FourLives);
            this.positiveModifierBox.Controls.Add(this.checkBox5);
            this.positiveModifierBox.Controls.Add(this.checkBox4);
            this.positiveModifierBox.Controls.Add(this.checkBox3);
            this.positiveModifierBox.Controls.Add(this.checkBox2);
            this.positiveModifierBox.Controls.Add(this.checkBox1);
            this.positiveModifierBox.Controls.Add(this.NoFail);
            this.positiveModifierBox.Location = new System.Drawing.Point(13, 130);
            this.positiveModifierBox.Margin = new System.Windows.Forms.Padding(2);
            this.positiveModifierBox.Name = "positiveModifierBox";
            this.positiveModifierBox.Padding = new System.Windows.Forms.Padding(2);
            this.positiveModifierBox.Size = new System.Drawing.Size(278, 336);
            this.positiveModifierBox.TabIndex = 9;
            this.positiveModifierBox.TabStop = false;
            this.positiveModifierBox.Text = "Modifiers";
            // 
            // SuperFastSong
            // 
            this.SuperFastSong.AutoSize = true;
            this.SuperFastSong.Location = new System.Drawing.Point(12, 311);
            this.SuperFastSong.Margin = new System.Windows.Forms.Padding(2);
            this.SuperFastSong.Name = "SuperFastSong";
            this.SuperFastSong.Size = new System.Drawing.Size(105, 17);
            this.SuperFastSong.TabIndex = 26;
            this.SuperFastSong.Text = "Super Fast Song";
            this.SuperFastSong.UseVisualStyleBackColor = true;
            // 
            // FasterSong
            // 
            this.FasterSong.AutoSize = true;
            this.FasterSong.Location = new System.Drawing.Point(12, 290);
            this.FasterSong.Margin = new System.Windows.Forms.Padding(2);
            this.FasterSong.Name = "FasterSong";
            this.FasterSong.Size = new System.Drawing.Size(83, 17);
            this.FasterSong.TabIndex = 25;
            this.FasterSong.Text = "Faster Song";
            this.FasterSong.UseVisualStyleBackColor = true;
            // 
            // SlowerSong
            // 
            this.SlowerSong.AutoSize = true;
            this.SlowerSong.Location = new System.Drawing.Point(12, 269);
            this.SlowerSong.Margin = new System.Windows.Forms.Padding(2);
            this.SlowerSong.Name = "SlowerSong";
            this.SlowerSong.Size = new System.Drawing.Size(86, 17);
            this.SlowerSong.TabIndex = 24;
            this.SlowerSong.Text = "Slower Song";
            this.SlowerSong.UseVisualStyleBackColor = true;
            // 
            // ZenMode
            // 
            this.ZenMode.AutoSize = true;
            this.ZenMode.Location = new System.Drawing.Point(12, 248);
            this.ZenMode.Margin = new System.Windows.Forms.Padding(2);
            this.ZenMode.Name = "ZenMode";
            this.ZenMode.Size = new System.Drawing.Size(75, 17);
            this.ZenMode.TabIndex = 23;
            this.ZenMode.Text = "Zen Mode";
            this.ZenMode.UseVisualStyleBackColor = true;
            // 
            // StrictAngles
            // 
            this.StrictAngles.AutoSize = true;
            this.StrictAngles.Location = new System.Drawing.Point(12, 227);
            this.StrictAngles.Margin = new System.Windows.Forms.Padding(2);
            this.StrictAngles.Name = "StrictAngles";
            this.StrictAngles.Size = new System.Drawing.Size(85, 17);
            this.StrictAngles.TabIndex = 22;
            this.StrictAngles.Text = "Strict Angles";
            this.StrictAngles.UseVisualStyleBackColor = true;
            // 
            // ProMode
            // 
            this.ProMode.AutoSize = true;
            this.ProMode.Location = new System.Drawing.Point(12, 206);
            this.ProMode.Margin = new System.Windows.Forms.Padding(2);
            this.ProMode.Name = "ProMode";
            this.ProMode.Size = new System.Drawing.Size(72, 17);
            this.ProMode.TabIndex = 21;
            this.ProMode.Text = "Pro Mode";
            this.ProMode.UseVisualStyleBackColor = true;
            // 
            // SmallNotes
            // 
            this.SmallNotes.AutoSize = true;
            this.SmallNotes.Location = new System.Drawing.Point(12, 185);
            this.SmallNotes.Margin = new System.Windows.Forms.Padding(2);
            this.SmallNotes.Name = "SmallNotes";
            this.SmallNotes.Size = new System.Drawing.Size(82, 17);
            this.SmallNotes.TabIndex = 20;
            this.SmallNotes.Text = "Small Notes";
            this.SmallNotes.UseVisualStyleBackColor = true;
            // 
            // DissapearingArrows
            // 
            this.DissapearingArrows.AutoSize = true;
            this.DissapearingArrows.Location = new System.Drawing.Point(12, 164);
            this.DissapearingArrows.Margin = new System.Windows.Forms.Padding(2);
            this.DissapearingArrows.Name = "DissapearingArrows";
            this.DissapearingArrows.Size = new System.Drawing.Size(122, 17);
            this.DissapearingArrows.TabIndex = 19;
            this.DissapearingArrows.Text = "Dissapearing Arrows";
            this.DissapearingArrows.UseVisualStyleBackColor = true;
            // 
            // GhostNotes
            // 
            this.GhostNotes.AutoSize = true;
            this.GhostNotes.Location = new System.Drawing.Point(12, 143);
            this.GhostNotes.Margin = new System.Windows.Forms.Padding(2);
            this.GhostNotes.Name = "GhostNotes";
            this.GhostNotes.Size = new System.Drawing.Size(85, 17);
            this.GhostNotes.TabIndex = 18;
            this.GhostNotes.Text = "Ghost Notes";
            this.GhostNotes.UseVisualStyleBackColor = true;
            // 
            // NoArrows
            // 
            this.NoArrows.AutoSize = true;
            this.NoArrows.Location = new System.Drawing.Point(12, 122);
            this.NoArrows.Margin = new System.Windows.Forms.Padding(2);
            this.NoArrows.Name = "NoArrows";
            this.NoArrows.Size = new System.Drawing.Size(74, 17);
            this.NoArrows.TabIndex = 17;
            this.NoArrows.Text = "No arrows";
            this.NoArrows.UseVisualStyleBackColor = true;
            // 
            // NoWalls
            // 
            this.NoWalls.AutoSize = true;
            this.NoWalls.Location = new System.Drawing.Point(12, 101);
            this.NoWalls.Margin = new System.Windows.Forms.Padding(2);
            this.NoWalls.Name = "NoWalls";
            this.NoWalls.Size = new System.Drawing.Size(66, 17);
            this.NoWalls.TabIndex = 16;
            this.NoWalls.Text = "No walls";
            this.NoWalls.UseVisualStyleBackColor = true;
            // 
            // NoBombs
            // 
            this.NoBombs.AutoSize = true;
            this.NoBombs.Location = new System.Drawing.Point(12, 80);
            this.NoBombs.Margin = new System.Windows.Forms.Padding(2);
            this.NoBombs.Name = "NoBombs";
            this.NoBombs.Size = new System.Drawing.Size(74, 17);
            this.NoBombs.TabIndex = 15;
            this.NoBombs.Text = "No bombs";
            this.NoBombs.UseVisualStyleBackColor = true;
            // 
            // OneLife
            // 
            this.OneLife.AutoSize = true;
            this.OneLife.Location = new System.Drawing.Point(12, 38);
            this.OneLife.Margin = new System.Windows.Forms.Padding(2);
            this.OneLife.Name = "OneLife";
            this.OneLife.Size = new System.Drawing.Size(52, 17);
            this.OneLife.TabIndex = 14;
            this.OneLife.Text = "1 Life";
            this.OneLife.UseVisualStyleBackColor = true;
            // 
            // FourLives
            // 
            this.FourLives.AutoSize = true;
            this.FourLives.Location = new System.Drawing.Point(12, 59);
            this.FourLives.Margin = new System.Windows.Forms.Padding(2);
            this.FourLives.Name = "FourLives";
            this.FourLives.Size = new System.Drawing.Size(60, 17);
            this.FourLives.TabIndex = 13;
            this.FourLives.Text = "4 Lives";
            this.FourLives.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(5, -118);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(97, 17);
            this.checkBox5.TabIndex = 8;
            this.checkBox5.Text = "Reduce Debris";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(5, -140);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(102, 17);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "Advanced HUD";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(5, -185);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(84, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Static Lights";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(5, -208);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(52, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Mirror";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(5, -162);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "No HUD";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // NoFail
            // 
            this.NoFail.AutoSize = true;
            this.NoFail.Location = new System.Drawing.Point(12, 17);
            this.NoFail.Margin = new System.Windows.Forms.Padding(2);
            this.NoFail.Name = "NoFail";
            this.NoFail.Size = new System.Drawing.Size(59, 17);
            this.NoFail.TabIndex = 12;
            this.NoFail.Text = "No Fail";
            this.NoFail.UseVisualStyleBackColor = true;
            this.NoFail.CheckedChanged += new System.EventHandler(this.instaFailCheckbox_CheckedChanged);
            // 
            // playerSettingsBox
            // 
            this.playerSettingsBox.Controls.Add(this.ReduceDebris);
            this.playerSettingsBox.Controls.Add(this.NoHud);
            this.playerSettingsBox.Controls.Add(this.LeftHanded);
            this.playerSettingsBox.Controls.Add(this.AdvancedHud);
            this.playerSettingsBox.Location = new System.Drawing.Point(13, 18);
            this.playerSettingsBox.Margin = new System.Windows.Forms.Padding(2);
            this.playerSettingsBox.Name = "playerSettingsBox";
            this.playerSettingsBox.Padding = new System.Windows.Forms.Padding(2);
            this.playerSettingsBox.Size = new System.Drawing.Size(278, 108);
            this.playerSettingsBox.TabIndex = 7;
            this.playerSettingsBox.TabStop = false;
            this.playerSettingsBox.Text = "Player Settings";
            // 
            // ReduceDebris
            // 
            this.ReduceDebris.AutoSize = true;
            this.ReduceDebris.Location = new System.Drawing.Point(5, 85);
            this.ReduceDebris.Margin = new System.Windows.Forms.Padding(2);
            this.ReduceDebris.Name = "ReduceDebris";
            this.ReduceDebris.Size = new System.Drawing.Size(97, 17);
            this.ReduceDebris.TabIndex = 8;
            this.ReduceDebris.Text = "Reduce Debris";
            this.ReduceDebris.UseVisualStyleBackColor = true;
            // 
            // NoHud
            // 
            this.NoHud.AutoSize = true;
            this.NoHud.Location = new System.Drawing.Point(5, 41);
            this.NoHud.Name = "NoHud";
            this.NoHud.Size = new System.Drawing.Size(114, 17);
            this.NoHud.TabIndex = 2;
            this.NoHud.Text = "No Text And Huds";
            this.NoHud.UseVisualStyleBackColor = true;
            // 
            // LeftHanded
            // 
            this.LeftHanded.AutoSize = true;
            this.LeftHanded.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftHanded.Location = new System.Drawing.Point(5, 18);
            this.LeftHanded.Name = "LeftHanded";
            this.LeftHanded.Size = new System.Drawing.Size(85, 17);
            this.LeftHanded.TabIndex = 1;
            this.LeftHanded.Text = "Left Handed";
            this.LeftHanded.UseVisualStyleBackColor = true;
            // 
            // AdvancedHud
            // 
            this.AdvancedHud.AutoSize = true;
            this.AdvancedHud.Location = new System.Drawing.Point(5, 64);
            this.AdvancedHud.Margin = new System.Windows.Forms.Padding(2);
            this.AdvancedHud.Name = "AdvancedHud";
            this.AdvancedHud.Size = new System.Drawing.Size(98, 17);
            this.AdvancedHud.TabIndex = 6;
            this.AdvancedHud.Text = "Advanced Hud";
            this.AdvancedHud.UseVisualStyleBackColor = true;
            // 
            // returnToMenuButton
            // 
            this.returnToMenuButton.Location = new System.Drawing.Point(13, 783);
            this.returnToMenuButton.Name = "returnToMenuButton";
            this.returnToMenuButton.Size = new System.Drawing.Size(174, 23);
            this.returnToMenuButton.TabIndex = 5;
            this.returnToMenuButton.Text = "Return to Menu";
            this.returnToMenuButton.UseVisualStyleBackColor = true;
            this.returnToMenuButton.Click += new System.EventHandler(this.returnToMenuButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(13, 753);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(174, 23);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // difficultyDropdown
            // 
            this.difficultyDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultyDropdown.FormattingEnabled = true;
            this.difficultyDropdown.Location = new System.Drawing.Point(13, 727);
            this.difficultyDropdown.Name = "difficultyDropdown";
            this.difficultyDropdown.Size = new System.Drawing.Size(174, 21);
            this.difficultyDropdown.TabIndex = 3;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.Gray;
            this.searchBox.Enabled = false;
            this.searchBox.ForeColor = System.Drawing.SystemColors.Window;
            this.searchBox.Location = new System.Drawing.Point(312, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(244, 20);
            this.searchBox.TabIndex = 2;
            this.searchBox.Text = "Search:";
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(12, 15);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(133, 13);
            this.searchLabel.TabIndex = 3;
            this.searchLabel.Text = "Waiting for songs to load...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 871);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Party Panel v0.1.0";
            // 
            // PartyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(914, 901);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.songListView);
            this.Name = "PartyPanel";
            this.Text = "PartyPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PartyPanel_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PartyPanel_FormClosed);
            this.groupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.positiveModifierBox.ResumeLayout(false);
            this.positiveModifierBox.PerformLayout();
            this.playerSettingsBox.ResumeLayout(false);
            this.playerSettingsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView songListView;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox difficultyDropdown;
        private System.Windows.Forms.CheckBox NoHud;
        private System.Windows.Forms.CheckBox LeftHanded;
        private System.Windows.Forms.Button returnToMenuButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.GroupBox playerSettingsBox;
        private System.Windows.Forms.CheckBox AdvancedHud;
        private System.Windows.Forms.CheckBox ReduceDebris;
        private System.Windows.Forms.GroupBox positiveModifierBox;
        private System.Windows.Forms.CheckBox NoFail;
        private System.Windows.Forms.ComboBox characteristicDropdown;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox GhostNotes;
        private System.Windows.Forms.CheckBox NoArrows;
        private System.Windows.Forms.CheckBox NoWalls;
        private System.Windows.Forms.CheckBox NoBombs;
        private System.Windows.Forms.CheckBox OneLife;
        private System.Windows.Forms.CheckBox FourLives;
        private System.Windows.Forms.CheckBox SuperFastSong;
        private System.Windows.Forms.CheckBox FasterSong;
        private System.Windows.Forms.CheckBox SlowerSong;
        private System.Windows.Forms.CheckBox ZenMode;
        private System.Windows.Forms.CheckBox StrictAngles;
        private System.Windows.Forms.CheckBox ProMode;
        private System.Windows.Forms.CheckBox SmallNotes;
        private System.Windows.Forms.CheckBox DissapearingArrows;
    }
}