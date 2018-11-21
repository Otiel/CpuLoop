using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpuLoop {

    public partial class FormSystray: Form {
        private Thread loopThread;

        public FormSystray() {
            InitializeComponent();
            notifyIcon.Icon = Properties.Resources.Processor;
            notifyIcon.Text = "CpuLoop";
            StartCpuLoop();
        }

        private void Loop() {
            do {
                // Nothing
            } while (true);
        }

        private void StartCpuLoop() {
            toolStripMenuItemStart.Enabled = false;
            toolStripMenuItemStop.Enabled = true;
            notifyIcon.Icon = Properties.Resources.ProcessorStarted;
            notifyIcon.Text = "CpuLoop - Running";

            Task.Factory.StartNew(() => {
                loopThread = Thread.CurrentThread;
                Loop();
            });
        }

        private void StopCpuLoop() {
            toolStripMenuItemStart.Enabled = true;
            toolStripMenuItemStop.Enabled = false;
            notifyIcon.Icon = Properties.Resources.ProcessorStopped;
            notifyIcon.Text = "CpuLoop - Stopped";

            loopThread.Abort();
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e) {
            Application.Exit();
            notifyIcon.Visible = false;
        }

        private void ToolStripMenuItemStart_Click(object sender, EventArgs e) {
            StartCpuLoop();
        }

        private void ToolStripMenuItemStop_Click(object sender, EventArgs e) {
            StopCpuLoop();
        }
    }
}