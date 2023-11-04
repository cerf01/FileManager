using Microsoft.VisualBasic.Devices;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FileManager
{
    public partial class Form1 : Form
    {
        private DirectoryInfo _currDir;
        public Form1()
        {

            InitializeComponent();
            CreationPanelOKButton.Enabled = false;
            CreationPanelOKButton.Visible = false;
            CreationPanelOKButton2.Enabled = false;
            CreationPanelOKButton2.Visible = false;
            RPanelOKButton.Enabled = false;
            RPanelOKButton.Visible = false;
            RPanelOKButton2.Enabled = false;
            RPanelOKButton2.Visible = false;

            _currDir = new DirectoryInfo(path.Text);
            Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update();
        }
        private void Update()
        {
            listBox1.Items.Clear();
            try
            {
                _currDir = new DirectoryInfo(path.Text);
                foreach (var d in _currDir.GetDirectories())
                {
                    listBox1.Items.Add(d);
                }

                foreach (var f in _currDir.GetFiles())
                {
                    listBox1.Items.Add(f);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Back();
        }
        private void Back()
        {
            if (path.Text == "C:\\")
                return;
            do
            {
                path.Text = path.Text.Remove(path.Text.Length - 1);
            } while (path.Text[path.Text.Length - 1] != '\\');
            Update();
        }
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItems == null)
                return;
            if (Path.GetExtension(listBox1.SelectedItem.ToString()) == "")
            {
                path.Text = listBox1.SelectedItem.ToString();
                Update();
            }
            else
            {
                ProcessStartInfo pi = new ProcessStartInfo();
                pi.UseShellExecute = true;
                pi.FileName = listBox1.SelectedItem.ToString();
                Process.Start(pi);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async Task startCopy()
        {
            foreach (var item in listBox1.SelectedItems)
            {
                Copy(item.ToString(), item.ToString() + " " + DateTime.Now.Second);
            }
            Update();
        }
        private async Task Copy(string source, string dest)
        {
            try
            {
                if (Path.GetExtension(source) == "")
                {
                    var dir = new DirectoryInfo(source);
                    DirectoryInfo[] dirs = dir.GetDirectories();
                    Directory.CreateDirectory(dest);

                    foreach (var file in dir.GetFiles())
                    {
                        string mewFilePath = dest + "\\" + file.Name;
                        file.CopyTo(mewFilePath);
                    }

                    foreach (var subDir in dirs)
                    {
                        string newDir = dest + "\\" + subDir.Name;
                        Copy(subDir.FullName, newDir);
                    }
                }
                else
                {
                    File.Copy(source, dest);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void path_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Update();
        }

        private void CopyPanel_Leave(object sender, EventArgs e)
        {
            RemovePanel.Visible = false;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;
            var dialogResult = MessageBox.Show("Are You shure?", "Delete this?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (dialogResult == DialogResult.Yes)
                StartDelete();
            else
                return;
        }

        private async Task StartDelete()
        {
            foreach (var item in listBox1.SelectedItems)
            {
                Delete(item.ToString());
            }
            Update();
        }
        private async Task Delete(string path)
        {
            if (Path.GetExtension(path) == "")
            {
                try
                {
                    DirectoryInfo di = new DirectoryInfo(path);
                    foreach (FileInfo file in di.GetFiles())
                    {
                        file.Delete();
                    }
                    foreach (DirectoryInfo dir in di.GetDirectories())
                    {
                        dir.Delete(true);
                    }
                    Directory.Delete(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                try
                {
                    File.Delete(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }
        private async Task startRemove()
        {
            foreach (var item in listBox1.SelectedItems)
            {
                await Copy(item.ToString(), DestDir.Text);
                Delete(item.ToString());
            }
            Update();
        }
        private async Task Rename(string source, string dest)
        {
            try
            {
                if (Path.GetExtension(source) == "")
                {
                    Directory.Move(source, dest);
                }
                else
                {
                    File.Move(source, dest);
                }
                Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FindPanel.Visible = true;
            FindPanel.Focus();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CreationPanel.Visible = true;
            CreationPanel.Focus();
            if (!label3.Visible)
                label3.Visible = true;
            if (!comboBox1.Visible)
                comboBox1.Visible = true;
            if (!CreationPanelOKButton2.Enabled)
            {
                CreationPanelOKButton2.Enabled = true;
                CreationPanelOKButton2.Visible = true;
            }
            if (!CreationPanelOKButton.Enabled)
            {
                CreationPanelOKButton.Enabled = false;
                CreationPanelOKButton.Visible = false;
            }

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void directoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CreationPanel.Visible = true;
            CreationPanel.Focus();
            if (label3.Visible)
                label3.Visible = false;
            if (comboBox1.Visible)
                comboBox1.Visible = false;
            if (!CreationPanelOKButton.Enabled)
            {
                CreationPanelOKButton.Enabled = true;
                CreationPanelOKButton.Visible = true;
            }
            if (CreationPanelOKButton2.Enabled)
            {
                CreationPanelOKButton2.Enabled = false;
                CreationPanelOKButton2.Visible = false;
            }
        }

        private void CreationPanelCancleButton_Click(object sender, EventArgs e)
        {
            DisableAll();
        }
        private void DisableAll()
        {
            if (CreationPanel.Visible)
            {
                CreationPanel.Visible = false;
                CreateName.Text = "";
                comboBox1.SelectedItem = null;
                CreationPanelOKButton.Enabled = false;
                CreationPanelOKButton.Visible = false;
                CreationPanelOKButton2.Enabled = false;
                CreationPanelOKButton2.Visible = false;
            }
            if (RemovePanel.Visible)
            {
                RemovePanel.Visible = false;
                DestDir.Text = "";
                RPanelOKButton.Enabled = false;
                RPanelOKButton.Visible = false;
                RPanelOKButton2.Enabled = false;
                RPanelOKButton2.Visible = false;
            }
        }
        private void CreationPanel_Leave(object sender, EventArgs e)
        {
            CreationPanel.Visible = false;
            CreateName.Text = "";
            comboBox1.SelectedItem = null;
        }

        private void CreationPanelOKButton_Click(object sender, EventArgs e)
        {
            try
            {
                string pathC = path.Text + "\\" + CreateName.Text;
                if (Directory.Exists(pathC))
                {
                    MessageBox.Show("Dir alrady exist!");
                    return;
                }

                Directory.CreateDirectory(pathC);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DisableAll();
            Update();
        }

        private void CreationPanelOKButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string pathC = path.Text + "\\" + CreateName.Text + comboBox1.SelectedItem.ToString();
                if (File.Exists(pathC))
                {
                    MessageBox.Show("File alrady exist!");
                    return;
                }
                File.Create(pathC).Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DisableAll();
            Update();

        }

        private void RemovePanel_Leave(object sender, EventArgs e)
        {
            RemovePanel.Visible = false;
            DestDir.Text = "";
        }

        private void CopyPanelCancleButton_Click(object sender, EventArgs e)
        {
            RemovePanel.Visible = false;
            DestDir.Text = "";
        }

        private void CopyPanelOKButton_Click(object sender, EventArgs e)
        {
            Rename(listBox1.SelectedItem.ToString(), path.Text + "\\" + DestDir.Text);
            DisableAll();

        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void moreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;
            string info;
            if (Path.GetExtension(listBox1.SelectedItem.ToString()) == "")
            {
                var dir = new DirectoryInfo(listBox1.SelectedItem.ToString());
                info = "Name: " + dir.Name + "\n Count of dirs in: " + dir.GetDirectories().Length + "\nCount of files in: " + dir.GetFiles().Length + "\nParent root: " + dir.Parent + "\n Attributes" + dir.Attributes + "\n Creation time: " + dir.CreationTime + "\n Last access time: " + dir.LastAccessTime + "\n";
            }
            else
            {
                var file = new FileInfo(listBox1.SelectedItem.ToString());

                info = "Name: " + file.Name + "\n Extension: " + file.Extension + "\nSize(in bytes): " + file.Length + "\nDir name: " + file.DirectoryName + "\n Attributes" + file.Attributes + "\n Creation time: " + file.CreationTime + "\n Last access time: " + file.LastAccessTime + "\nRead only?: " + file.IsReadOnly + "\n";

            }
            MessageBox.Show(info);
        }
      
        private void CopyPanelOKButton2_Click(object sender, EventArgs e)
        {
            startRemove();
            DisableAll();
        }

        private void FindPanel_Leave(object sender, EventArgs e)
        {
            FindPanel.Visible = false;
            FindThis.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FindFile();
            FindPanel.Visible = false;
        }
        private void FindFile()
        {

            try
            {
                string[] find;
                if (Path.GetExtension(FindThis.Text) == "")
                {
                    find = Directory.GetDirectories(path.Text, FindThis.Text, SearchOption.AllDirectories);
                    path.Text = find[0];
                }

                else
                {
                    find = Directory.GetFiles(path.Text, FindThis.Text, SearchOption.AllDirectories);
                    path.Text = find[0];
                }
                if (find.Length >= 0)
                {
                    MessageBox.Show($"File found \n{find[0]}");
                    Back();
                }
                else
                {
                    MessageBox.Show($"File not found ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            startCopy();
        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;
            RemovePanel.Visible = true;
            RemovePanel.Focus();
            if (!RPanelOKButton2.Enabled)
            {
                RPanelOKButton2.Enabled = true;
                RPanelOKButton2.Visible = true;
            }
            if (RPanelOKButton.Enabled)
            {
                RPanelOKButton.Enabled = false;
                RPanelOKButton.Visible = false;
            }
            label1.Text = "Enter full path to new dir:";
        }

        private void renameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;
            label1.Text = "Enter new name:";
            RemovePanel.Visible = true;
            RemovePanel.Focus();
            if (!RPanelOKButton.Enabled)
            {
                RPanelOKButton.Enabled = true;
                RPanelOKButton.Visible = true;
            }
            if (RPanelOKButton2.Enabled)
            {
                RPanelOKButton2.Enabled = false;
                RPanelOKButton2.Visible = false;
            }
        }

        private void dackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(64, 64, 64);
            listBox1.BackColor = Color.DimGray;
            listBox1.ForeColor = Color.SeaShell;

            path.BackColor = Color.Gray;
            path.ForeColor = Color.WhiteSmoke;

            GoToButton.BackColor = Color.Gray;

            backButton.BackColor = Color.Gray;

            menuStrip1.BackColor = SystemColors.ControlDark;

            contextMenuStrip1.BackColor = SystemColors.ControlDark;

            directoryToolStripMenuItem.BackColor = SystemColors.ControlDark;

            fileToolStripMenuItem.BackColor = SystemColors.ControlDark;

            copyToolStripMenuItem1.BackColor = SystemColors.ControlDark;

            removeToolStripMenuItem1.BackColor = SystemColors.ControlDark;

            renameToolStripMenuItem1.BackColor = SystemColors.ControlDark;

            editToolStripMenuItem1.BackColor = SystemColors.ControlDark;

            backgraundToolStripMenuItem.BackColor = SystemColors.ControlDark;

            dackToolStripMenuItem.BackColor = SystemColors.ControlDark;

            ligthToolStripMenuItem.BackColor = SystemColors.ControlDark;

            closeToolStripMenuItem.BackColor = SystemColors.ControlDark;

            CreationPanel.BackColor = Color.FromArgb(64, 64, 64);
            CreationPanelCancleButton.BackColor = Color.Gray;
            CreationPanelOKButton.BackColor = Color.Gray;
            CreationPanelOKButton2.BackColor = Color.Gray;
            CreateName.BackColor = SystemColors.WindowFrame;
            CreateName.ForeColor = Color.WhiteSmoke;
            comboBox1.ForeColor = Color.WhiteSmoke;
            comboBox1.BackColor = Color.Gray;
            label2.ForeColor = Color.WhiteSmoke;
            label3.ForeColor = Color.WhiteSmoke;

            RemovePanel.BackColor = Color.FromArgb(64, 64, 64);
            RPanelCancleButton.BackColor = Color.Gray;
            RPanelOKButton.BackColor = Color.Gray;
            RPanelOKButton2.BackColor = Color.Gray;
            DestDir.BackColor = SystemColors.WindowFrame;
            DestDir.ForeColor = Color.WhiteSmoke;
            label1.ForeColor = Color.WhiteSmoke;

            FindPanel.BackColor = Color.FromArgb(64, 64, 64);
            FindCancle.BackColor = Color.Gray;
            FindButton.BackColor = Color.Gray;
            label4.ForeColor = Color.WhiteSmoke;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ligthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            listBox1.BackColor = SystemColors.Window;
            listBox1.ForeColor = SystemColors.WindowText;

            path.BackColor = SystemColors.Window;
            path.ForeColor = SystemColors.WindowText;

            GoToButton.BackColor = SystemColors.ButtonFace;


            backButton.BackColor = SystemColors.ButtonFace;


            menuStrip1.BackColor = SystemColors.ControlLight;

            editToolStripMenuItem1.BackColor = SystemColors.ControlLightLight;

            contextMenuStrip1.BackColor = SystemColors.ControlLightLight;


            directoryToolStripMenuItem.BackColor = SystemColors.ControlLightLight;

            fileToolStripMenuItem.BackColor = SystemColors.ControlLightLight;


            copyToolStripMenuItem1.BackColor = SystemColors.ControlLightLight;


            removeToolStripMenuItem1.BackColor = SystemColors.ControlLightLight;

            renameToolStripMenuItem1.BackColor = SystemColors.ControlLightLight;

            backgraundToolStripMenuItem.BackColor = SystemColors.ControlLightLight;

            dackToolStripMenuItem.BackColor = SystemColors.ControlLightLight;

            ligthToolStripMenuItem.BackColor = SystemColors.ControlLightLight;

            closeToolStripMenuItem.BackColor = SystemColors.ControlLightLight;

            CreationPanel.BackColor = SystemColors.AppWorkspace;
            CreationPanelCancleButton.BackColor = SystemColors.ButtonFace;
            CreationPanelOKButton.BackColor = SystemColors.ButtonFace;
            CreationPanelOKButton2.BackColor = SystemColors.ButtonFace;
            CreateName.BackColor = SystemColors.Window;
            CreateName.ForeColor = SystemColors.WindowText;
            comboBox1.ForeColor = SystemColors.WindowText;
            comboBox1.BackColor = SystemColors.Window;
            label2.ForeColor = SystemColors.WindowText;
            label3.ForeColor = SystemColors.WindowText;

            RemovePanel.BackColor = SystemColors.AppWorkspace;
            RPanelCancleButton.BackColor = SystemColors.ButtonFace;
            RPanelOKButton.BackColor = SystemColors.ButtonFace;
            RPanelOKButton2.BackColor = SystemColors.ButtonFace;
            DestDir.BackColor = SystemColors.Window;
            DestDir.ForeColor = SystemColors.WindowText;
            label1.ForeColor = SystemColors.WindowText;

            FindPanel.BackColor = SystemColors.AppWorkspace;
            FindCancle.BackColor = SystemColors.ButtonFace;
            FindButton.BackColor = SystemColors.ButtonFace;
            label4.ForeColor = SystemColors.WindowText;

        }


    }
}