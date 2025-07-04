namespace WinFormsApp1
{
    using System;
    using System.Diagnostics;
    using System.Windows.Forms;
    using System.IO;

    public partial class Form1 : Form
    {
        public static Timer RunningTime;
        public static Timer StartingTime;
        public static Stopwatch StopWatchTime;
        public static List<TimeSpan>[] itemTotalTime;
        public static List<TimeSpan>[] itemLapTime;
        public static TimeSpan[] itemStartTime;
        public static int[] itemCount;
        public static int IntervalStart = 0;
        public static int IntervalStartCount = 0;
        public static bool StartBeep = false;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Init the form
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            itemTotalTime = new List<TimeSpan>[20];
            itemLapTime = new List<TimeSpan>[20];
            itemStartTime = new TimeSpan[20];

            for (int i = 0; i < 20; i++)
            {
                itemTotalTime[i] = new List<TimeSpan>();
                itemLapTime[i] = new List<TimeSpan>();
            }
            itemCount = new Int32[20];
            StopWatchTime = new Stopwatch();
            RunningTime = new Timer();
            RunningTime.Interval = 100;
            RunningTime.Tick += new EventHandler(TimerEventShowTime);
            StartingTime = new Timer();
            StartingTime.Tick += new EventHandler(TimerEventStartTime);

            comboBox16.SelectedIndex = 0;
            for (int i = 1; i < 16; i++)
            {
                Button btn = ButtonControl(i);
                if (btn != null)
                {
                    btn.BackColor = Color.LightCoral;
                    btn.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Start the timer
        /// </summary>
        private void start_Click(object sender, EventArgs e)
        {
            IntervalStart = 0;
            IntervalStartCount = 0;
            int.TryParse(comboBox16.Text, out IntervalStart);

            if (IntervalStart > 0)
            {
                StartingTime.Interval = IntervalStart * 1000;
                StartingTime.Start();
            }

            //Clear arrays
            Array.Clear(itemStartTime);
            for (int i = 0; i < 20; i++)
            {
                itemTotalTime[i].Clear();
                itemLapTime[i].Clear();
            }

            for (int i = 1; i <= 15; i++)
            {
                ComboBox comboLeft = ComboBoxLeftControl(i);
                if (comboLeft != null)
                {
                    comboLeft.Items.Clear();
                    comboLeft.Text = string.Empty;
                }
                ComboBox comboRight = ComboBoxRightControl(i);
                if (comboRight != null)
                {
                    comboRight.Items.Clear();
                    comboRight.Text = string.Empty;
                }
                Label labelCount = LabelCounter(i);
                if (labelCount != null)
                {
                    labelCount.Text = "0";
                }
                comboBox16.Enabled = false;
            }

            //enable buttons for the lap time
            if (IntervalStart == 0)
            {
                for (int i = 1; i < 16; i++)
                {
                    Button btn = ButtonControl(i);
                    if (btn != null)
                    {
                        btn.BackColor = Color.LightGreen;
                        btn.Enabled = true;
                    }
                }
            }
            else
            {
                Button btn = ButtonControl(1);
                if (btn != null)
                {
                    btn.BackColor = Color.LightGreen;
                    btn.Enabled = true;
                }
            }

            Array.Clear(itemCount);
            StopWatchTime.Reset();
            StopWatchTime.Start();
            RunningTime.Start();
        }

        private ComboBox ComboBoxLeftControl(int i)
        {
            return (ComboBox)this.Controls["comboBox" + i.ToString()];
        }
        private ComboBox ComboBoxRightControl(int i)
        {
            return (ComboBox)this.Controls["comboBox" + i.ToString() + "a"];
        }
        private Label LabelCounter(int i)
        {
            return (Label)this.Controls["label" + i.ToString()];
        }
        private TextBox TextBoxControl(int i)
        {
            return (TextBox)Controls["textBox" + i.ToString()];
        }
        private Button ButtonControl(int i)
        {
            return (Button)Controls["button" + i.ToString()];
        }

        /// <summary>
        /// Stop the timer
        /// </summary>
        private void stop_Click(object sender, EventArgs e)
        {
            StopWatchTime.Stop();
            RunningTime.Stop();
            StartingTime.Stop();

            //disable buttons
            for (int i = 1; i < 16; i++)
            {
                Button btn = ButtonControl(i);
                if (btn != null)
                {
                    btn.BackColor = Color.LightCoral;
                    btn.Enabled = false;
                }
            }
            comboBox16.Enabled = true;
        }

        /// <summary>
        /// This is the method to run when the timer for the time contol is raised.
        /// </summary>
        private void TimerEventShowTime(Object myObject, EventArgs myEventArgs)
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

        /// <summary>
        /// This is the method to run when the timer for the starting time is raised.
        /// </summary>
        private void TimerEventStartTime(Object myObject, EventArgs myEventArgs)
        {
            IntervalStartCount++;
            Button btn = (Button)this.Controls["button" + (IntervalStartCount + 1).ToString()];

            if (btn != null)
            {
                if (btn.InvokeRequired)
                {
                    btn.BeginInvoke((MethodInvoker)delegate () { btn.BackColor = Color.LightGreen; });
                    btn.BeginInvoke((MethodInvoker)delegate () { btn.Enabled = true; });
                }
                else
                {

                    btn.BackColor = Color.LightGreen;
                    btn.Enabled = true;
                }
            }
            itemStartTime[IntervalStartCount] = StopWatchTime.Elapsed;

            // Final button reached
            if (IntervalStartCount >= 14)
            {
                StartingTime.Stop();
                IntervalStartCount = 0;
            }
        }

        /// <summary>
        /// Evaluate and store the lap times
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            string text = (new String(bt.Name.ToString().Where(Char.IsDigit).ToArray()));
            int line = Convert.ToInt32(text) - 1;
            TimeSpan lapTime;
            itemTotalTime[line].Add(StopWatchTime.Elapsed - itemStartTime[line]);

            ComboBox comboLeft = ComboBoxLeftControl(line + 1);
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
            ComboBox comboRight = ComboBoxRightControl(line + 1);
            if (comboRight != null)
            {
                comboRight.Items.Add(lapTime.ToString(@"mm\:ss\.f"));
                comboRight.Text = lapTime.ToString(@"mm\:ss\.f");
            }
            itemCount[line]++;
            Label labelCount = LabelCounter(line + 1);
            if (labelCount != null)
            {
                labelCount.Text = itemCount[line].ToString();
            }

            // MessageBox.Show(itemStartTime[line].ToString() +"\n" + itemTotalTime[line][itemTotalTime[line].Count() - 1]);
        }

        /// <summary>
        /// save the results to disc
        /// </summary>
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
                            TextBox text = TextBoxControl(i + 1);
                            if (text != null)
                            {
                                if (text.Text.Length > 0)
                                {
                                    line += text.Text + "\t";
                                    for (int lapTimes = 0; lapTimes < itemTotalTime[i].Count; lapTimes++)
                                    {
                                        line += itemTotalTime[i][lapTimes].ToString(@"mm\:ss\.f", System.Globalization.CultureInfo.CurrentUICulture).Replace('.', Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator)) + "\t";
                                    }
                                    sw.WriteLine(line);
                                }
                            }

                        }

                        sw.WriteLine("Lap Time");
                        for (int i = 0; i < 15; i++)
                        {
                            string line = string.Empty;
                            TextBox text = TextBoxControl(i + 1);
                            if (text != null)
                            {
                                if (text.Text.Length > 0)
                                {
                                    line += text.Text + "\t";

                                    for (int lapTimes = 0; lapTimes < itemLapTime[i].Count; lapTimes++)
                                    {
                                        line += itemLapTime[i][lapTimes].ToString(@"mm\:ss\.f", System.Globalization.CultureInfo.CurrentUICulture).Replace('.', Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator)) + "\t";
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

        /// <summary>
        /// Load a list of athlete names
        /// </summary>
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
                        TextBox text = TextBoxControl(i + 1);
                        if (text != null)
                        {
                            text.Text = names[i];
                        }
                    }
                }
            }
        }

        /// <summary>
        /// copy the results to the clipboard
        /// </summary>
        private void button17_Click(object sender, EventArgs e)
        {
            string clip = "Total Time" + Environment.NewLine;
            
            for (int i = 0; i < 15; i++)
            {
                string line = string.Empty;
                TextBox text = TextBoxControl(i + 1);
                if (text != null)
                {
                    if (text.Text.Length > 0)
                    {
                        line += text.Text + "\t";
                        for (int lapTimes = 0; lapTimes < itemTotalTime[i].Count; lapTimes++)
                        {
                            line += itemTotalTime[i][lapTimes].ToString(@"mm\:ss\.f", System.Globalization.CultureInfo.CurrentUICulture).Replace('.', Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator)) + "\t";
                        }
                        clip += line + Environment.NewLine;
                    }
                }

            }

            clip += "Lap Time" + Environment.NewLine;
            for (int i = 0; i < 15; i++)
            {
                string line = string.Empty;
                TextBox text = TextBoxControl(i + 1);
                if (text != null)
                {
                    if (text.Text.Length > 0)
                    {
                        line += text.Text + "\t";

                        for (int lapTimes = 0; lapTimes < itemLapTime[i].Count; lapTimes++)
                        {
                            line += itemLapTime[i][lapTimes].ToString(@"mm\:ss\.f", System.Globalization.CultureInfo.CurrentUICulture).Replace('.', Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator)) + "\t";
                        }
                        clip += line + Environment.NewLine;
                    }
                }
            }
            System.Windows.Forms.Clipboard.SetText(clip);
        }

    }
}
