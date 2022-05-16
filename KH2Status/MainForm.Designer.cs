namespace KH2Status
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer_status = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Level = new System.Windows.Forms.Label();
            this.lb_Strength = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_NextLV = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_Magic = new System.Windows.Forms.Label();
            this.lb_Defense = new System.Windows.Forms.Label();
            this.lb_MaxHP = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_MaxMP = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_Location = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputAsFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_Level = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_NextLV = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_Strength = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_Magic = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_Defense = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_MaxHP = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_MaxMP = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_Location = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_status
            // 
            this.timer_status.Interval = 3000;
            this.timer_status.Tick += new System.EventHandler(this.timer_status_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(52, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Level:";
            // 
            // lb_Level
            // 
            this.lb_Level.AutoSize = true;
            this.lb_Level.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_Level.Location = new System.Drawing.Point(118, 34);
            this.lb_Level.Name = "lb_Level";
            this.lb_Level.Size = new System.Drawing.Size(36, 23);
            this.lb_Level.TabIndex = 1;
            this.lb_Level.Text = "??";
            // 
            // lb_Strength
            // 
            this.lb_Strength.AutoSize = true;
            this.lb_Strength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_Strength.Location = new System.Drawing.Point(118, 80);
            this.lb_Strength.Name = "lb_Strength";
            this.lb_Strength.Size = new System.Drawing.Size(36, 23);
            this.lb_Strength.TabIndex = 3;
            this.lb_Strength.Text = "??";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(8, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Strength:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(48, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Magic:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(18, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Defense:";
            // 
            // lb_NextLV
            // 
            this.lb_NextLV.AutoSize = true;
            this.lb_NextLV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_NextLV.Location = new System.Drawing.Point(118, 57);
            this.lb_NextLV.Name = "lb_NextLV";
            this.lb_NextLV.Size = new System.Drawing.Size(36, 23);
            this.lb_NextLV.TabIndex = 7;
            this.lb_NextLV.Text = "??";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(22, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "Next LV:";
            // 
            // lb_Magic
            // 
            this.lb_Magic.AutoSize = true;
            this.lb_Magic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_Magic.Location = new System.Drawing.Point(118, 103);
            this.lb_Magic.Name = "lb_Magic";
            this.lb_Magic.Size = new System.Drawing.Size(36, 23);
            this.lb_Magic.TabIndex = 8;
            this.lb_Magic.Text = "??";
            // 
            // lb_Defense
            // 
            this.lb_Defense.AutoSize = true;
            this.lb_Defense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_Defense.Location = new System.Drawing.Point(118, 126);
            this.lb_Defense.Name = "lb_Defense";
            this.lb_Defense.Size = new System.Drawing.Size(36, 23);
            this.lb_Defense.TabIndex = 9;
            this.lb_Defense.Text = "??";
            // 
            // lb_MaxHP
            // 
            this.lb_MaxHP.AutoSize = true;
            this.lb_MaxHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_MaxHP.Location = new System.Drawing.Point(118, 149);
            this.lb_MaxHP.Name = "lb_MaxHP";
            this.lb_MaxHP.Size = new System.Drawing.Size(36, 23);
            this.lb_MaxHP.TabIndex = 11;
            this.lb_MaxHP.Text = "??";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(28, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 23);
            this.label12.TabIndex = 10;
            this.label12.Text = "Max HP:";
            // 
            // lb_MaxMP
            // 
            this.lb_MaxMP.AutoSize = true;
            this.lb_MaxMP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_MaxMP.Location = new System.Drawing.Point(118, 172);
            this.lb_MaxMP.Name = "lb_MaxMP";
            this.lb_MaxMP.Size = new System.Drawing.Size(36, 23);
            this.lb_MaxMP.TabIndex = 13;
            this.lb_MaxMP.Text = "??";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(25, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 23);
            this.label14.TabIndex = 12;
            this.label14.Text = "Max MP:";
            // 
            // lb_Location
            // 
            this.lb_Location.AutoSize = true;
            this.lb_Location.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_Location.Location = new System.Drawing.Point(118, 195);
            this.lb_Location.Name = "lb_Location";
            this.lb_Location.Size = new System.Drawing.Size(36, 23);
            this.lb_Location.TabIndex = 15;
            this.lb_Location.Text = "??";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(16, 195);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 23);
            this.label16.TabIndex = 14;
            this.label16.Text = "Location:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputAsFileToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // outputAsFileToolStripMenuItem
            // 
            this.outputAsFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cb_Level,
            this.cb_NextLV,
            this.cb_Strength,
            this.cb_Magic,
            this.cb_Defense,
            this.cb_MaxHP,
            this.cb_MaxMP,
            this.cb_Location});
            this.outputAsFileToolStripMenuItem.Name = "outputAsFileToolStripMenuItem";
            this.outputAsFileToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.outputAsFileToolStripMenuItem.Text = "Output as file";
            // 
            // cb_Level
            // 
            this.cb_Level.CheckOnClick = true;
            this.cb_Level.Name = "cb_Level";
            this.cb_Level.Size = new System.Drawing.Size(120, 22);
            this.cb_Level.Text = "Level";
            // 
            // cb_NextLV
            // 
            this.cb_NextLV.CheckOnClick = true;
            this.cb_NextLV.Name = "cb_NextLV";
            this.cb_NextLV.Size = new System.Drawing.Size(120, 22);
            this.cb_NextLV.Text = "Next LV";
            // 
            // cb_Strength
            // 
            this.cb_Strength.CheckOnClick = true;
            this.cb_Strength.Name = "cb_Strength";
            this.cb_Strength.Size = new System.Drawing.Size(120, 22);
            this.cb_Strength.Text = "Strength";
            // 
            // cb_Magic
            // 
            this.cb_Magic.CheckOnClick = true;
            this.cb_Magic.Name = "cb_Magic";
            this.cb_Magic.Size = new System.Drawing.Size(120, 22);
            this.cb_Magic.Text = "Magic";
            // 
            // cb_Defense
            // 
            this.cb_Defense.CheckOnClick = true;
            this.cb_Defense.Name = "cb_Defense";
            this.cb_Defense.Size = new System.Drawing.Size(120, 22);
            this.cb_Defense.Text = "Defense";
            // 
            // cb_MaxHP
            // 
            this.cb_MaxHP.CheckOnClick = true;
            this.cb_MaxHP.Name = "cb_MaxHP";
            this.cb_MaxHP.Size = new System.Drawing.Size(120, 22);
            this.cb_MaxHP.Text = "Max HP";
            // 
            // cb_MaxMP
            // 
            this.cb_MaxMP.CheckOnClick = true;
            this.cb_MaxMP.Name = "cb_MaxMP";
            this.cb_MaxMP.Size = new System.Drawing.Size(120, 22);
            this.cb_MaxMP.Text = "Max MP";
            // 
            // cb_Location
            // 
            this.cb_Location.CheckOnClick = true;
            this.cb_Location.Name = "cb_Location";
            this.cb_Location.Size = new System.Drawing.Size(120, 22);
            this.cb_Location.Text = "Location";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(677, 232);
            this.Controls.Add(this.lb_Location);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lb_MaxMP);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lb_MaxHP);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lb_Defense);
            this.Controls.Add(this.lb_Magic);
            this.Controls.Add(this.lb_NextLV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_Strength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_Level);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("KHMenu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "KH2Status";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_status;
        private Label label1;
        private Label lb_Level;
        private Label lb_Strength;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lb_NextLV;
        private Label label8;
        private Label lb_Magic;
        private Label lb_Defense;
        private Label lb_MaxHP;
        private Label label12;
        private Label lb_MaxMP;
        private Label label14;
        private Label lb_Location;
        private Label label16;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem outputAsFileToolStripMenuItem;
        private ToolStripMenuItem cb_Level;
        private ToolStripMenuItem cb_NextLV;
        private ToolStripMenuItem cb_Strength;
        private ToolStripMenuItem cb_Magic;
        private ToolStripMenuItem cb_Defense;
        private ToolStripMenuItem cb_MaxHP;
        private ToolStripMenuItem cb_MaxMP;
        private ToolStripMenuItem cb_Location;
    }
}