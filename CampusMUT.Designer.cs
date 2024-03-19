namespace CampusMUT
{
    partial class CampusMUT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CampusMUT));
            statusStrip1 = new StatusStrip();
            toolStrip1 = new ToolStrip();
            menuStrip1 = new MenuStrip();
            toolStripButton1 = new ToolStripButton();
            YearToolStripComboBox = new ToolStripComboBox();
            SchoolToolStripComboBox = new ToolStripComboBox();
            CalendarToolStripComboBox = new ToolStripComboBox();
            StructureToolStripComboBox = new ToolStripComboBox();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 487);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1099, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 27);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1099, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, YearToolStripComboBox, SchoolToolStripComboBox, CalendarToolStripComboBox, StructureToolStripComboBox });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1099, 27);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(42, 22);
            toolStripButton1.Text = "Select";
            toolStripButton1.ToolTipText = "Select Columns To Display";
            // 
            // YearToolStripComboBox
            // 
            YearToolStripComboBox.Name = "YearToolStripComboBox";
            YearToolStripComboBox.Size = new Size(121, 23);
            YearToolStripComboBox.Text = "All Years";
            YearToolStripComboBox.ToolTipText = "Year";
            // 
            // SchoolToolStripComboBox
            // 
            SchoolToolStripComboBox.Name = "SchoolToolStripComboBox";
            SchoolToolStripComboBox.Size = new Size(121, 23);
            SchoolToolStripComboBox.Text = "All Schools";
            SchoolToolStripComboBox.ToolTipText = "School";
            // 
            // CalendarToolStripComboBox
            // 
            CalendarToolStripComboBox.Name = "CalendarToolStripComboBox";
            CalendarToolStripComboBox.Size = new Size(121, 23);
            CalendarToolStripComboBox.Text = "All Calendars";
            CalendarToolStripComboBox.ToolTipText = "Calendar";
            // 
            // StructureToolStripComboBox
            // 
            StructureToolStripComboBox.Name = "StructureToolStripComboBox";
            StructureToolStripComboBox.Size = new Size(121, 23);
            StructureToolStripComboBox.Text = "Main Structure";
            StructureToolStripComboBox.ToolTipText = "Structure";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(125, 23);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // CampusMUT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 509);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "CampusMUT";
            Text = "Campus MUT";
            WindowState = FormWindowState.Maximized;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private MenuStrip menuStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripComboBox YearToolStripComboBox;
        private ToolStripComboBox SchoolToolStripComboBox;
        private ToolStripComboBox CalendarToolStripComboBox;
        private ToolStripComboBox StructureToolStripComboBox;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}
