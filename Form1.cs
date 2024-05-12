using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;

namespace RE_JavaTexturePackage2NBTP
{
    public partial class Form1 : Form
    {
        public List<JavaPackage> JavaPackages = new List<JavaPackage>();
        public Form1()
        {
            InitializeComponent();
            listBox1.DataSource = JavaPackages;
            listBox1.DisplayMember = "Name";
        }

        private void Refresh()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = JavaPackages;
            listBox1.DisplayMember = "Name";
            listBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                // ���öԻ���ı���
                dialog.Description = "��ѡ���ļ���";

                // ����û�����ˡ�ȷ������ť
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // �����û�ѡ����ļ���·��
                    textBox1.Text = dialog.SelectedPath;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                // ���öԻ���ı���
                dialog.Title = "��ѡ��Java���ʰ�/��Ч��ѹ���������Զ�ѡ��";

                // ���öԻ���Ĺ�������ֻ����ѡ���ض����͵��ļ�
                dialog.Filter = "ѹ���ļ� (*.zip)|*.zip|�����ļ� (*.*)|*.*";

                dialog.Multiselect = true;

                // ����û�����ˡ�ȷ������ť
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // �����û�ѡ����ļ�·��
                    foreach (string file in dialog.FileNames)
                    {
                        JavaPackages.Add(new JavaPackage(file));
                    }
                    Refresh();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("ѡ����Ϊ��", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show($"��ȷ��Ҫɾ��{JavaPackages[listBox1.SelectedIndex].Name}��", "ȷ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                MessageBox.Show($"ת����ɣ��ܼƳɹ�{totalsuc}���ܼ�ʧ��{totalfail}","���",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
            }
        }
    }
}
