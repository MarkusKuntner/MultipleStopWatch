namespace WinFormsApp1
{
    using System;
    using System.Diagnostics;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using System.IO;

    public partial class Form1 : Form
    {
        public static Timer RunningTime;
        public static Stopwatch StopWatchTime;
        public static List<TimeSpan>[] itemTotalTime;
        public static List<TimeSpan>[] itemLapTime;
        public static int[] itemCount;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            itemTotalTime = new List<TimeSpan>[20];
            itemLapTime = new List<TimeSpan>[20];
            for (int i = 0; i < 20; i++)
            {
                itemTotalTime[i] = new List<TimeSpan>();
                itemLapTime[i] = new List<TimeSpan>();
            }
            itemCount = new Int32[20];
            StopWatchTime = new Stopwatch();
            RunningTime = new Timer();
            RunningTime.Interval = 100;
            RunningTime.Tick += new EventHandler(TimerEventProcessor);
        }

        private void start_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                itemTotalTime[i].Clear();
                itemLapTime[i].Clear();
            }
            for (int i = 1; i <= 15; i++)
            {
                ComboBox comboLeft = (ComboBox)this.Controls["comboBox" + (i).ToString()];
                comboLeft.Items.Clear();
                comboLeft.Text = string.Empty;
                ComboBox comboRight = (ComboBox)this.Controls["comboBox" + (i).ToString() + "a"];
                comboRight.Items.Clear();
                comboRight.Text = string.Empty;
                Label labelCount = (Label)this.Controls["label" + (i).ToString()];
                labelCount.Text = "0";
            }

            Array.Clear(itemCount);
            StopWatchTime.Reset();
            StopWatchTime.Start();
            RunningTime.Start();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            StopWatchTime.Stop();
            RunningTime.Stop();
        }

        // This is the method to run when the timer is raised.
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            string newText = StopWatchTime.Elapsed.ToString(@"mm\:ss\.f");
            if (this.labelTimeSum.InvokeRequired)
            {
                this.labelTimeSum.BeginInvoke((MethodInvoker)delegate () { this.labelTimeSum.Text = newText; });
            }
            else
            {
                this.labelTimeSum.Text = newText;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            string text = (new String(bt.Name.ToString().Where(Char.IsDigit).ToArray()));
            int line = Convert.ToInt32(text) - 1;
            TimeSpan lapTime;
            itemTotalTime[line].Add(StopWatchTime.Elapsed);

            ComboBox comboLeft = (ComboBox)this.Controls["comboBox" + (line + 1).ToString()];
            if (comboLeft != null)
            {
                comboLeft.Items.Add(itemTotalTime[line][itemTotalTime[line].Count() - 1].ToString(@"mm\:ss\.f"));
                comboLeft.Text = itemTotalTime[line][itemTotalTime[line].Count() - 1].ToString(@"mm\:ss\.f");
            }

            if (itemCount[line] > 0)
            {
                lapTime = itemTotalTime[line][itemTotalTime[line].Count() - 1] - itemTotalTime[line][itemTotalTime[line].Count() - 2];
            }
            else
            {
                lapTime = itemTotalTime[line][itemTotalTime[line].Count() - 1];
            }
            itemLapTime[line].Add(lapTime);
            ComboBox comboRight = (ComboBox)Controls["comboBox" + (line + 1).ToString() + "a"];
            if (comboRight != null)
            {
                comboRight.Items.Add(lapTime.ToString(@"mm\:ss\.f"));
                comboRight.Text = lapTime.ToString(@"mm\:ss\.f");
            }
            itemCount[line]++;
            Label labelCount = (Label)Controls["label" + (line + 1).ToString()];
            labelCount.Text = itemCount[line].ToString();
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text File|*.txt";
            saveFileDialog1.Title = "Save the lap times";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        sw.WriteLine("Total Time");
                        for (int i = 0; i < 15; i++)
                        {
                            string line = string.Empty;
                            TextBox text = (TextBox)Controls["textBox" + (i + 1).ToString()];
                            if (text != null)
                            {
                                if (text.Text.Length > 0)
                                {
                                    line += text.Text + "\t";
                                    for (int lapTimes = 0; lapTimes < itemTotalTime[i].Count; lapTimes++)
                                    {
                                        line += itemTotalTime[i][lapTimes].ToString(@"mm\:ss\.f") + "\t";
                                    }
                                    sw.WriteLine(line);
                                }
                            }

                        }

                        sw.WriteLine("Lap Time");
                        for (int i = 0; i < 15; i++)
                        {
                            string line = string.Empty;
                            TextBox text = (TextBox)Controls["textBox" + (i + 1).ToString()];
                            if (text != null)
                            {
                                if (text.Text.Length > 0)
                                {
                                    line += text.Text + "\t";

                                    for (int lapTimes = 0; lapTimes < itemLapTime[i].Count; lapTimes++)
                                    {
                                        line += itemLapTime[i][lapTimes].ToString(@"mm\:ss\.f") + "\t";
                                    }
                                    sw.WriteLine(line);
                                }
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text File|*.txt";
            openFileDialog1.Title = "Load a list of names";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                List<string> names = new List<string>();
                try
                {
                    using (StreamReader rw = new StreamReader(openFileDialog1.FileName))
                    {
                        int count = 0;
                        do
                        {
                            string name = rw.ReadLine();
                            if (name != null && name != string.Empty)
                            {
                                names.Add(name);
                                count++;
                            }
                            else
                            {
                                count = 15;
                            }
                        }
                        while (count < 15);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                for (int i = 0; i < 15; i++)
                {
                    if (i < names.Count)
                    {
                        TextBox text = (TextBox)Controls["textBox" + (i + 1).ToString()];
                        if (text != null)
                        {
                            text.Text = names[i];
                        }
                    }
                }
            }
        }

    }
}
