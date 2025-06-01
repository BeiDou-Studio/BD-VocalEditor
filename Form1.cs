using System;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace VocalEditor_CStest
{
    public partial class Form1 : Form
    {
        private GroupBox newTrackInfoGroup;
        private GroupBox newTracknoteGroup;
        private PictureBox newTrackInfoImage;
        private TextBox newTrackName;
        private Label newTrackSinger;
        private int track = 1; // 初始化轨道计数

        private void Init()
        {
            ListSinger();
        }

        private void ListSinger()
        {
            if (Directory.Exists("Singer"))
            {
                string[] singerDirs = Directory.GetDirectories("Singer");
                SingerList.Items.AddRange(singerDirs); // 使用 AddRange 方法
            }
            else
            {
                MessageBox.Show("目录 'Singer' 不存在。");
            }
        }

        private void SingerSelected(object sender, EventArgs e)
        {
            if (SingerList.SelectedItem != null) // 确保有选中项
            {
                LoadVocalData((string)SingerList.SelectedItem);
            }
        }

        private void LoadVocalData(string directory)
        {
            // 加载 JSON 文件
            string jsonFilePath = Path.Combine(directory, "vocal-oto.json");
            if (File.Exists(jsonFilePath))
            {
                string jsonContent = File.ReadAllText(jsonFilePath);
                JObject jsonObject = JObject.Parse(jsonContent);

                tracksingerlabel.Text = jsonObject["vocal-name"]?.ToString() ?? "未知"; // 处理可能的空值
                Console.WriteLine(jsonContent);
            }
            else
            {
                MessageBox.Show("未找到 vocal-oto.json 文件。");
            }

            // 加载 icon.png
            string iconFilePath = Path.Combine(directory, "icon.png");
            if (File.Exists(iconFilePath))
            {
                trackinfoimage.Image = Image.FromFile(iconFilePath); // 使用 Image.FromFile 加载图像
                if (newTrackInfoImage != null)
                {
                    newTrackInfoImage.Image = Image.FromFile(iconFilePath);
                }
            }
            else
            {
                MessageBox.Show("未找到 icon.png 文件。");
            }
        }

        private void trackgroupHScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int scrollValue = e.NewValue * 6; // 每次滚动的增量
            Console.WriteLine($"当前滚动值: {scrollValue}");

            // 更新轨道信息组和按钮的位置
            UpdateTrackPositions(scrollValue);
        }

        private void UpdateTrackPositions(int offset)
        {
            trackinfogroup.Location = new Point(trackinfogroup.Location.X, 22 - offset);
            tracknotegroup.Location = new Point(tracknotegroup.Location.X, 22 - offset);
            newtrackbutton.Location = new Point(newtrackbutton.Location.X, 176 * track - offset);
            if (newTrackInfoGroup != null)
            {
                newTrackInfoGroup.Location = new Point(newTrackInfoGroup.Location.X, 88 * track - offset);
                newTracknoteGroup.Location = new Point(newTracknoteGroup.Location.X, 88 * track - offset);
            }
        }

        private void newtrackbutton_Click(object sender, EventArgs e)
        {
            track++; // 增加轨道计数

            // 创建新的轨道组
            newTrackInfoGroup = new GroupBox
            {
                Text = "Track Info",
                Size = new Size(239, 148),
                Location = new Point(10, 176 * track) // 更新位置
            };

            newTracknoteGroup = new GroupBox
            {
                Text = "Notes",
                Size = new Size(493, 148),
                Location = new Point(255, 176 * track)
            };

            newTrackInfoImage = new PictureBox
            {
                Size = new Size(120, 120),
                Location = new Point(6, 22)
            };

            newTrackName = new TextBox
            {
                Text = $"Track{track}",
                Size = new Size(100, 23),
                Location = new Point(132, 56)
            };

            newTrackSinger = new Label
            {
                Text = "No Singer",
                Size = new Size(72, 17),
                Location = new Point(144, 91)
            };

            // 创建音量控制条


            // 添加控件到新的轨道组
            newTrackInfoGroup.Controls.Add(newTrackInfoImage);
            newTrackInfoGroup.Controls.Add(newTrackName);
            newTrackInfoGroup.Controls.Add(newTrackSinger);
            trackgroup.Controls.Add(newTrackInfoGroup); // 将新轨道组添加到 trackgroup
            trackgroup.Controls.Add(newTracknoteGroup); // 将新轨道组添加到 trackgroup


            // 更新新按钮的位置
            newtrackbutton.Location = new Point(newtrackbutton.Location.X, 88 * track); // 保证按钮位置合理
        }
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void singerOtoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}