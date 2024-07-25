using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;
using RE_JavaTexturePackage2NBTP.SDK;

namespace RE_JavaTexturePackage2NBTP
{
    public partial class MainForm : Form
    {
        public List<JavaPackage> JavaPackages = new List<JavaPackage>();
        public MainForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            listBox1.DataSource = JavaPackages;
            listBox1.DisplayMember = "Name";

            this.DragEnter += FileDragEnter;
            this.DragDrop += FileDragDrop;
        }

        private void Refresh()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = JavaPackages;
            listBox1.DisplayMember = "Name";
            listBox1.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                // 设置对话框的标题
                dialog.Description = "请选择文件夹";

                // 如果用户点击了“确定”按钮
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // 返回用户选择的文件夹路径
                    textBox1.Text = dialog.SelectedPath;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                // 设置对话框的标题
                dialog.Title = "请选择Java材质包/音效包压缩包（可以多选）";

                // 设置对话框的过滤器，只允许选择特定类型的文件
                dialog.Filter = "压缩文件 (*.zip)|*.zip|任意文件 (*.*)|*.*";

                dialog.Multiselect = true;

                // 如果用户点击了“确定”按钮
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // 返回用户选择的文件路径
                    foreach (string file in dialog.FileNames)
                    {
                        JavaPackage rFile = new JavaPackage(file);
doExtract: ;
                        if (!rFile.Extract())
                        {
                            goto doExtract;
                        }
                        
                        JavaPackages.Add(rFile);
                    }
                    Refresh();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("选择项为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show($"你确定要删除{JavaPackages[listBox1.SelectedIndex].Name}吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                JavaPackages.RemoveAt(listBox1.SelectedIndex);
                Refresh();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex - 1 < 0) return;
            JavaPackages.Swap(listBox1.SelectedIndex, listBox1.SelectedIndex - 1);
            int tar = listBox1.SelectedIndex - 1;
            Refresh();
            listBox1.SelectedIndex = tar;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex - 1 < 0) button4.Enabled = false; else button4.Enabled = true;
            if (listBox1.SelectedIndex + 1 == JavaPackages.Count) button5.Enabled = false; else button5.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex + 1 == JavaPackages.Count) return;
            JavaPackages.Swap(listBox1.SelectedIndex, listBox1.SelectedIndex + 1);
            int tar = listBox1.SelectedIndex + 1;
            Refresh();
            listBox1.SelectedIndex = tar;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            JavaPackages.Swap(listBox1.SelectedIndex, 0);
            int tar = 0;
            Refresh();
            listBox1.SelectedIndex = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            JavaPackages.Swap(listBox1.SelectedIndex, JavaPackages.Count - 1);
            int tar = JavaPackages.Count - 1;
            Refresh();
            listBox1.SelectedIndex = JavaPackages.Count - 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int totalsuc = 0,totalfail = 0;
            try
            {
                foreach (JavaPackage pck in JavaPackages)
                {
                    var c = new PackageConverter(textBox1.Text, pck);
                    c.Convert();
                    totalsuc += c.sucCount;
                    totalfail += c.failCount;
                }
                MessageBox.Show($"转换完成，总计成功{totalsuc}，总计失败{totalfail}","完成",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
            }
        }

        private void FileDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void FileDragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            // 处理拖放的文件
            foreach (string file in files)
            {
                if (ZipHelper.IsValid(file)) continue;
                JavaPackages.Add(new JavaPackage(file.Replace('\\', '/')));
            }
            Refresh();
        }
    }
}
