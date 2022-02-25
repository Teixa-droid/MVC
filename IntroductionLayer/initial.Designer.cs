
namespace IntroductionLayer
{
    partial class initial
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuuser = new FontAwesome.Sharp.IconMenuItem();
            this.menuupdater = new FontAwesome.Sharp.IconMenuItem();
            this.menusales = new FontAwesome.Sharp.IconMenuItem();
            this.menupurchases = new FontAwesome.Sharp.IconMenuItem();
            this.menucustomers = new FontAwesome.Sharp.IconMenuItem();
            this.menuproviders = new FontAwesome.Sharp.IconMenuItem();
            this.menureports = new FontAwesome.Sharp.IconMenuItem();
            this.menuabout = new FontAwesome.Sharp.IconMenuItem();
            this.menutitle = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.container = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.SandyBrown;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuuser,
            this.menuupdater,
            this.menusales,
            this.menupurchases,
            this.menucustomers,
            this.menuproviders,
            this.menureports,
            this.menuabout});
            this.menu.Location = new System.Drawing.Point(0, 66);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(963, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuuser
            // 
            this.menuuser.AutoSize = false;
            this.menuuser.IconChar = FontAwesome.Sharp.IconChar.UserClock;
            this.menuuser.IconColor = System.Drawing.Color.Black;
            this.menuuser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuuser.IconSize = 50;
            this.menuuser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuuser.Name = "menuuser";
            this.menuuser.Size = new System.Drawing.Size(80, 69);
            this.menuuser.Text = "User";
            this.menuuser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuupdater
            // 
            this.menuupdater.AutoSize = false;
            this.menuupdater.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.menuupdater.IconColor = System.Drawing.Color.Black;
            this.menuupdater.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuupdater.IconSize = 50;
            this.menuupdater.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuupdater.Name = "menuupdater";
            this.menuupdater.Size = new System.Drawing.Size(80, 69);
            this.menuupdater.Text = "Updater";
            this.menuupdater.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menusales
            // 
            this.menusales.AutoSize = false;
            this.menusales.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menusales.IconColor = System.Drawing.Color.Black;
            this.menusales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menusales.IconSize = 50;
            this.menusales.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menusales.Name = "menusales";
            this.menusales.Size = new System.Drawing.Size(80, 69);
            this.menusales.Text = "Sales";
            this.menusales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menupurchases
            // 
            this.menupurchases.AutoSize = false;
            this.menupurchases.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.menupurchases.IconColor = System.Drawing.Color.Black;
            this.menupurchases.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menupurchases.IconSize = 50;
            this.menupurchases.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menupurchases.Name = "menupurchases";
            this.menupurchases.Size = new System.Drawing.Size(80, 69);
            this.menupurchases.Text = "Purchases";
            this.menupurchases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menupurchases.Click += new System.EventHandler(this.iconMenuItem2_Click);
            // 
            // menucustomers
            // 
            this.menucustomers.AutoSize = false;
            this.menucustomers.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.menucustomers.IconColor = System.Drawing.Color.Black;
            this.menucustomers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menucustomers.IconSize = 50;
            this.menucustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menucustomers.Name = "menucustomers";
            this.menucustomers.Size = new System.Drawing.Size(80, 69);
            this.menucustomers.Text = "Customers";
            this.menucustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuproviders
            // 
            this.menuproviders.AutoSize = false;
            this.menuproviders.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menuproviders.IconColor = System.Drawing.Color.Black;
            this.menuproviders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuproviders.IconSize = 50;
            this.menuproviders.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuproviders.Name = "menuproviders";
            this.menuproviders.Size = new System.Drawing.Size(80, 69);
            this.menuproviders.Text = "Providers";
            this.menuproviders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menureports
            // 
            this.menureports.AutoSize = false;
            this.menureports.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.menureports.IconColor = System.Drawing.Color.Black;
            this.menureports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menureports.IconSize = 50;
            this.menureports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menureports.Name = "menureports";
            this.menureports.Size = new System.Drawing.Size(80, 69);
            this.menureports.Text = "Reports";
            this.menureports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuabout
            // 
            this.menuabout.AutoSize = false;
            this.menuabout.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.menuabout.IconColor = System.Drawing.Color.Black;
            this.menuabout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuabout.IconSize = 50;
            this.menuabout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuabout.Name = "menuabout";
            this.menuabout.Size = new System.Drawing.Size(80, 69);
            this.menuabout.Text = "About us";
            this.menuabout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menutitle
            // 
            this.menutitle.AutoSize = false;
            this.menutitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menutitle.Location = new System.Drawing.Point(0, 0);
            this.menutitle.Name = "menutitle";
            this.menutitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitle.Size = new System.Drawing.Size(963, 66);
            this.menutitle.TabIndex = 1;
            this.menutitle.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sales System";
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 139);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(963, 427);
            this.container.TabIndex = 3;
            // 
            // initial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 566);
            this.Controls.Add(this.container);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutitle);
            this.MainMenuStrip = this.menu;
            this.Name = "initial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menuuser;
        private FontAwesome.Sharp.IconMenuItem menuupdater;
        private FontAwesome.Sharp.IconMenuItem menusales;
        private FontAwesome.Sharp.IconMenuItem menupurchases;
        private FontAwesome.Sharp.IconMenuItem menucustomers;
        private FontAwesome.Sharp.IconMenuItem menuproviders;
        private FontAwesome.Sharp.IconMenuItem menureports;
        private FontAwesome.Sharp.IconMenuItem menuabout;
        private System.Windows.Forms.MenuStrip menutitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel container;
    }
}

