using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Binarysharp.MemoryManagement;

namespace GGACRDummyTool
{
    public partial class Form1 : Form
    {
        private readonly Process process;
        private readonly IntPtr recordingOffset = new IntPtr(0x4FDD26);

        public Form1()
        {
            InitializeComponent();
            process = Process.GetProcessesByName("GGXXACPR_Win").FirstOrDefault();
        }

        private void btnSaveRecording_Click(object sender, EventArgs e)
        {
            using (MemorySharp sharp = new MemorySharp(process))
            {
                var recording = sharp.Read<byte>(recordingOffset, 14406);
                using (var dialog = new SaveFileDialog
                {
                    Filter = "Dummy Recording|*.acrdummy",
                    Title = "Save the current dummy recording",
                    RestoreDirectory = true
                })
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(dialog.FileName, recording);
                    }
                }
            }
        }

        private void btnLoadRecording_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog
            {
                Filter = "Dummy Recording|*.acrdummy",
                Title = "Load a saved dummy recording",
                RestoreDirectory = true
            })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var recording = File.ReadAllBytes(dialog.FileName);
                    using (MemorySharp sharp = new MemorySharp(process))
                    {
                        sharp.Write(recordingOffset, recording);
                    }
                }
            }
        }
    }
}
