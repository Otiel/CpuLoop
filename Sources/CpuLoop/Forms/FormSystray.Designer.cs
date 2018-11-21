namespace CpuLoop {
    partial class FormSystray {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemStart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemStart,
            this.toolStripMenuItemStop,
            this.toolStripMenuItemExit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(152, 70);
            // 
            // toolStripMenuItemStart
            // 
            this.toolStripMenuItemStart.Image = global::CpuLoop.Properties.Resources.Control;
            this.toolStripMenuItemStart.Name = "toolStripMenuItemStart";
            this.toolStripMenuItemStart.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItemStart.Text = "&Start CPU loop";
            this.toolStripMenuItemStart.Click += new System.EventHandler(this.ToolStripMenuItemStart_Click);
            // 
            // toolStripMenuItemStop
            // 
            this.toolStripMenuItemStop.Image = global::CpuLoop.Properties.Resources.ControlRecord;
            this.toolStripMenuItemStop.Name = "toolStripMenuItemStop";
            this.toolStripMenuItemStop.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItemStop.Text = "Sto&p CPU loop";
            this.toolStripMenuItemStop.Click += new System.EventHandler(this.ToolStripMenuItemStop_Click);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItemExit.Text = "E&xit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Text = "CpuLoop";
            this.notifyIcon.Visible = true;
            // 
            // FormSystray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormSystray";
            this.Text = "FormSystray";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStart;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStop;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
    }
}

