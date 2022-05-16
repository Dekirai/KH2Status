using KHMemLibrary;
using KH2Status.Properties;
namespace KH2Status
{
    public partial class MainForm : Form
    {
        KH2FM kh = new KH2FM();
        public MainForm()
        {
            InitializeComponent();
            cb_Level.Checked = Settings.Default.Level;
            cb_NextLV.Checked = Settings.Default.NextLV;
            cb_Strength.Checked = Settings.Default.Strength;
            cb_Magic.Checked = Settings.Default.Magic;
            cb_Defense.Checked = Settings.Default.Defense;
            cb_MaxHP.Checked = Settings.Default.MaxHP;
            cb_MaxMP.Checked = Settings.Default.MaxMP;
            cb_Location.Checked = Settings.Default.Location;
            timer_status.Start();
        }

        private async void timer_status_Tick(object sender, EventArgs e)
        {
            var EXPTable = new List<int>
            {
                0, 40, 100, 184, 296, 440, 620, 840, 1128, 1492, 1940, 2480, 3120, 3902, 4838, 5940, 7260, 8814, 10618,
                12688, 15088, 17838, 20949, 24433, 28302, 32622, 37407, 42671, 48485, 54865, 61886, 69566, 77984, 87160,
                97177, 108057, 119887, 132691, 146560, 161520, 177666, 195026, 213699, 233715, 255177, 278117, 302642,
                328786, 356660, 386378, 417978, 450378, 483578, 517578, 552378, 587978, 624378, 661578, 699578, 738378,
                777978, 818378, 859578, 901578, 944378, 987987, 1032378, 1077578, 1123578, 1170378, 1217978, 1266378,
                1315578, 1365578, 1416378, 1467978, 1520378, 1573578, 1627578, 1682378, 1737978, 1794378, 1851578,
                1909578, 1968378, 2027978, 2088378, 2149578, 2211578, 2274378, 2337978, 2402378, 2467578, 2533578,
                2600378, 2667978, 2736378, 2805578, 2875578
            };

            var level = kh.ReadByte(0x9A95AF);
            var experience = kh.ReadInt(0x9AA790);
            int nextlv = 0;
            var strength = kh.ReadByte(0x2A20E20);
            var magic = kh.ReadByte(0x2A20E22);
            var defense = kh.ReadByte(0x2A20E24);
            var maxhp = kh.ReadByte(0x2A20C9C);
            var maxmp = kh.ReadByte(0x2A20E1C);
            var location_world = await kh.GetWorldText();
            var location_room = await kh.GetRoomText();

            if (level != 99)
                nextlv = EXPTable[level] - experience;

            lb_Level.Text = level.ToString();
            lb_NextLV.Text = nextlv.ToString();
            lb_Strength.Text = strength.ToString();
            lb_Magic.Text = magic.ToString();
            lb_Defense.Text = defense.ToString();
            lb_MaxHP.Text = maxhp.ToString();
            lb_MaxMP.Text = maxmp.ToString();
            lb_Location.Text = $"{location_world} - {location_room}";

            if (cb_Level.Checked)
            {
                if (!File.Exists(Environment.CurrentDirectory + @"/kh2_level.txt"))
                {
                    var file = File.Create(Environment.CurrentDirectory + @"/kh2_level.txt");
                    file.Close();
                }
                File.WriteAllText(Environment.CurrentDirectory + @"/kh2_level.txt", $"Level: {level}");
            }
            else
            {
                if (File.Exists(Environment.CurrentDirectory + @"/kh2_level.txt"))
                    File.Delete(Environment.CurrentDirectory + @"/kh2_level.txt");
            }

            if (cb_NextLV.Checked)
            {
                if (!File.Exists(Environment.CurrentDirectory + @"/kh2_nextlv.txt"))
                {
                    var file = File.Create(Environment.CurrentDirectory + @"/kh2_nextlv.txt");
                    file.Close();
                }
                File.WriteAllText(Environment.CurrentDirectory + @"/kh2_nextlv.txt", $"Next LV: {nextlv}");
            }
            else
            {
                if (File.Exists(Environment.CurrentDirectory + @"/kh2_nextlv.txt"))
                    File.Delete(Environment.CurrentDirectory + @"/kh2_nextlv.txt");
            }

            if (cb_Strength.Checked)
            {
                if (!File.Exists(Environment.CurrentDirectory + @"/kh2_strength.txt"))
                {
                    var file = File.Create(Environment.CurrentDirectory + @"/kh2_strength.txt");
                    file.Close();
                }
                File.WriteAllText(Environment.CurrentDirectory + @"/kh2_strength.txt", $"Strength: {strength}");
            }
            else
            {
                if (File.Exists(Environment.CurrentDirectory + @"/kh2_strength.txt"))
                    File.Delete(Environment.CurrentDirectory + @"/kh2_strength.txt");
            }

            if (cb_Magic.Checked)
            {
                if (!File.Exists(Environment.CurrentDirectory + @"/kh2_magic.txt"))
                {
                    var file = File.Create(Environment.CurrentDirectory + @"/kh2_magic.txt");
                    file.Close();
                }
                File.WriteAllText(Environment.CurrentDirectory + @"/kh2_magic.txt", $"Magic: {magic}");
            }
            else
            {
                if (File.Exists(Environment.CurrentDirectory + @"/kh2_magic.txt"))
                    File.Delete(Environment.CurrentDirectory + @"/kh2_magic.txt");
            }

            if (cb_Defense.Checked)
            {
                if (!File.Exists(Environment.CurrentDirectory + @"/kh2_defense.txt"))
                {
                    var file = File.Create(Environment.CurrentDirectory + @"/kh2_defense.txt");
                    file.Close();
                }
                File.WriteAllText(Environment.CurrentDirectory + @"/kh2_defense.txt", $"Defense: {defense}");
            }
            else
            {
                if (File.Exists(Environment.CurrentDirectory + @"/kh2_defense.txt"))
                    File.Delete(Environment.CurrentDirectory + @"/kh2_defense.txt");
            }

            if (cb_MaxHP.Checked)
            {
                if (!File.Exists(Environment.CurrentDirectory + @"/kh2_maxhp.txt"))
                {
                    var file = File.Create(Environment.CurrentDirectory + @"/kh2_maxhp.txt");
                    file.Close();
                }
                File.WriteAllText(Environment.CurrentDirectory + @"/kh2_maxhp.txt", $"Max HP: {maxhp}");
            }
            else
            {
                if (File.Exists(Environment.CurrentDirectory + @"/kh2_maxhp.txt"))
                    File.Delete(Environment.CurrentDirectory + @"/kh2_maxhp.txt");
            }

            if (cb_MaxMP.Checked)
            {
                if (!File.Exists(Environment.CurrentDirectory + @"/kh2_maxmp.txt"))
                {
                    var file = File.Create(Environment.CurrentDirectory + @"/kh2_maxmp.txt");
                    file.Close();
                }
                File.WriteAllText(Environment.CurrentDirectory + @"/kh2_maxmp.txt", $"Max MP: {maxmp}");
            }
            else
            {
                if (File.Exists(Environment.CurrentDirectory + @"/kh2_maxmp.txt"))
                    File.Delete(Environment.CurrentDirectory + @"/kh2_maxmp.txt");
            }

            if (cb_Location.Checked)
            {
                if (!File.Exists(Environment.CurrentDirectory + @"/kh2_location.txt"))
                {
                    var file = File.Create(Environment.CurrentDirectory + @"/kh2_location.txt");
                    file.Close();
                }
                File.WriteAllText(Environment.CurrentDirectory + @"/kh2_location.txt", $"Location: {location_world} - {location_room}");
            }
            else
            {
                if (File.Exists(Environment.CurrentDirectory + @"/kh2_location.txt"))
                    File.Delete(Environment.CurrentDirectory + @"/kh2_location.txt");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Level = cb_Level.Checked;
            Settings.Default.NextLV = cb_NextLV.Checked;
            Settings.Default.Strength = cb_Strength.Checked;
            Settings.Default.Magic = cb_Magic.Checked;
            Settings.Default.Defense = cb_Defense.Checked;
            Settings.Default.MaxHP = cb_MaxHP.Checked;
            Settings.Default.MaxMP = cb_MaxMP.Checked;
            Settings.Default.Location = cb_Location.Checked;
            Settings.Default.Save();
        }
    }
}