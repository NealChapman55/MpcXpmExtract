using System.Xml.Serialization;

namespace MpcXpmExtract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void WriteToLog(string message)
        {
            TextBoxLog.AppendText(message + Environment.NewLine);
        }

        private TreeNode ScanDir(string path)
        {
            var node = new TreeNode(path);

            foreach (var dir in Directory.GetDirectories(path))
            {
                var dirNode = ScanDir(dir);

                if (dirNode.Nodes.Count > 0)
                    node.Nodes.Add(ScanDir(dir));
            }

            foreach (var file in Directory.GetFiles(path, "*.xpm"))
            {
                var fileNode = new TreeNode(file);
                node.Nodes.Add(fileNode);
            }

            return node;
        }

        private void Extract(string sourceBaseDir, string targetBaseDir, TreeNode rootNode)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(MPCVObject));

            foreach (TreeNode node in rootNode.Nodes)
            {
                string file = node.Text;

                if (file.ToLower().EndsWith(".xpm"))
                {
                    WriteToLog($"Extracting {file}");

                    try
                    {
                        using (Stream reader = new FileStream(file, FileMode.Open))
                        {
                            if (serializer.Deserialize(reader) is MPCVObject kit)
                            {
                                string? sourceDir = Path.GetDirectoryName(file);

                                if (sourceDir is null)
                                    continue;

                                string targetDir = Path.Combine(sourceDir, Path.GetFileNameWithoutExtension(file)).Replace(sourceBaseDir, targetBaseDir);

                                foreach (var instrument in kit.Program.Instruments)
                                {
                                    foreach (var layer in instrument.Layers)
                                    {
                                        string? sourceFile;

                                        if (layer.SampleName is string sampleName)
                                            sourceFile = Path.Combine(sourceDir, $"{sampleName}.wav");
                                        else
                                            continue;

                                        if (!string.IsNullOrEmpty(sourceFile) && File.Exists(sourceFile))
                                        {
                                            if (!Directory.Exists(targetDir))
                                            {
                                                System.Diagnostics.Debug.WriteLine(targetDir);
                                                Directory.CreateDirectory(targetDir);
                                            }

                                            string targetFile = Path.Combine(targetDir, Path.GetFileName(sourceFile));

                                            if (!File.Exists(targetFile))
                                                File.Copy(sourceFile, targetFile);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        WriteToLog($"{Path.GetFileName(file)} {ex.Message}");
                    }
                }
                else
                    Extract(sourceBaseDir, targetBaseDir, node);
            }
        }

        private void ButtonLoadDir_Click(object sender, EventArgs e)
        {
            TextBoxDir.Clear();
            TreeViewKits.Nodes.Clear();

            string selectedFolder;

            using (var dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Select source folder";

                if (dlg.ShowDialog() == DialogResult.OK)
                    selectedFolder = dlg.SelectedPath;
                else
                    return;
            }

            if (!string.IsNullOrEmpty(selectedFolder))
            {
                TextBoxDir.Text = selectedFolder;
                TreeViewKits.Nodes.Add(ScanDir(selectedFolder));
                return;
            }
        }

        private void ButtonExtractAll_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxDir.Text) || TreeViewKits.Nodes.Count == 0)
                return;

            string sourceDir = TextBoxDir.Text;
            string targetDir;

            using (var dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Select target folder";

                if (dlg.ShowDialog() == DialogResult.OK)
                    targetDir = dlg.SelectedPath;
                else
                    return;
            }

            Extract(sourceDir, targetDir, TreeViewKits.Nodes[0]);

            WriteToLog("Extract finished");
        }
    }
}