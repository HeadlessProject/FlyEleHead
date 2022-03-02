using info = FlyElepHead.GlobalInfo;

#pragma warning disable CS8602 // 解引用可能出现空引用。

namespace FlyElepHead
{
    public partial class MainWindow : Form
    {
        Dictionary<string, Panel> scenes = new();
        Dictionary<string, Control> controllib = new();

        public MainWindow()
        {
            InitializeComponent();

            InitForm();

            Panel start_panel = new();
            scenes.Add("StartPanel", start_panel);
            Panel game_panel = new();
            scenes.Add("GamePanel", game_panel);
            Panel end_panel = new();
            scenes.Add("EndPanel", end_panel);

            InitPanel("StartPanel");

            scenes["StartPanel"].Parent = this;

            InitPanel("GamePanel");

        }

        private void InitForm()
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void InitPanel(string name)
        {
            switch (name)
            {
                case "StartPanel":
                    Panel panel = scenes[name];
                    panel.Dock = DockStyle.Fill;
                    Label label = new Label()
                    {
                        Text = info.start_panel_title,
                        Parent = panel,
                        Size = new Size()
                        {
                            Width = info.menu_label_title_width,
                            Height = info.menu_label_title_height
                        },
                        Font = new Font("Consolas", info.menu_label_title_fontsize)
                    };
                    label.Location = new Point()
                    {
                        X = (Width - label.PreferredSize.Width) / 2,
                        Y = (Height - label.PreferredSize.Height) / 2 - info.menu_label_title_vertical_offset
                    };
                    Button button = new Button()
                    {
                        Text = "开始游戏",
                        Size = new Size()
                        {
                            Width = info.menu_btn_width,
                            Height = info.menu_btn_height
                        },
                        Location = new Point()
                        {
                            X = (Width - info.menu_btn_width) / 2,
                            Y = (Height - info.menu_btn_height) / 2 + 100
                        },
                        Parent = panel,
                    };
                    controllib.Add("StartPanel_Label_Title", label);
                    controllib.Add("StartPanel_Button_StartGame", button);
                    break;
                case "GamePanel":
                    Panel game_panel =scenes[name];
                    game_panel.Dock = DockStyle.Fill;

                    break;
            }
        }
    }
}

#pragma warning restore CS8602 // 解引用可能出现空引用。