
namespace InstituteUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.Aplikace = new System.Windows.Forms.ToolStripMenuItem();
            this.Ukoncit = new System.Windows.Forms.ToolStripMenuItem();
            this.OAplikaci = new System.Windows.Forms.ToolStripMenuItem();
            this.Zamestnanec = new System.Windows.Forms.ToolStripMenuItem();
            this.PridatZamestnance = new System.Windows.Forms.ToolStripMenuItem();
            this.SeznamZamestnancu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PracovniStitky = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Aplikace,
            this.Zamestnanec,
            this.PracovniStitky});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(685, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // Aplikace
            // 
            this.Aplikace.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OAplikaci,
            this.toolStripSeparator1,
            this.Ukoncit});
            this.Aplikace.Name = "Aplikace";
            this.Aplikace.Size = new System.Drawing.Size(64, 20);
            this.Aplikace.Text = "Aplikace";
            // 
            // Ukoncit
            // 
            this.Ukoncit.Name = "Ukoncit";
            this.Ukoncit.Size = new System.Drawing.Size(126, 22);
            this.Ukoncit.Text = "Ukončit";
            // 
            // OAplikaci
            // 
            this.OAplikaci.Name = "OAplikaci";
            this.OAplikaci.Size = new System.Drawing.Size(126, 22);
            this.OAplikaci.Text = "O aplikaci";
            // 
            // Zamestnanec
            // 
            this.Zamestnanec.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PridatZamestnance,
            this.SeznamZamestnancu});
            this.Zamestnanec.Name = "Zamestnanec";
            this.Zamestnanec.Size = new System.Drawing.Size(90, 20);
            this.Zamestnanec.Text = "Zaměstnanec";
            // 
            // PridatZamestnance
            // 
            this.PridatZamestnance.Name = "PridatZamestnance";
            this.PridatZamestnance.Size = new System.Drawing.Size(188, 22);
            this.PridatZamestnance.Text = "Přidat zaměstnance";
            // 
            // SeznamZamestnancu
            // 
            this.SeznamZamestnancu.Name = "SeznamZamestnancu";
            this.SeznamZamestnancu.Size = new System.Drawing.Size(188, 22);
            this.SeznamZamestnancu.Text = "Seznam zaměstnanců";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(123, 6);
            // 
            // PracovniStitky
            // 
            this.PracovniStitky.Name = "PracovniStitky";
            this.PracovniStitky.Size = new System.Drawing.Size(96, 20);
            this.PracovniStitky.Text = "Pracovní štítky";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(685, 380);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikace ústavu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem Aplikace;
        private System.Windows.Forms.ToolStripMenuItem Ukoncit;
        private System.Windows.Forms.ToolStripMenuItem OAplikaci;
        private System.Windows.Forms.ToolStripMenuItem Zamestnanec;
        private System.Windows.Forms.ToolStripMenuItem PridatZamestnance;
        private System.Windows.Forms.ToolStripMenuItem SeznamZamestnancu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem PracovniStitky;
    }
}

