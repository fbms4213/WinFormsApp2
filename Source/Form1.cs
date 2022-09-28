using Source.Properties;

namespace Source
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Image image = Resources.Azerbaijan_Satellite_Map;

            // PictureBox picture = new()
            // {
            //     BackgroundImage = Resources.Azerbaijan_Satellite_Map,
            //     BackgroundImageLayout = ImageLayout.Zoom,
            //     Size = new Size(Width, Height)
            // };


            // picture.SendToBack();
            // picture.BringToFront();



            // Controls.Add(picture);
            // Controls.Remove(richTextBox1);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // pictureBox1.SendToBack();

            // this.Controls.SetChildIndex(picture, 1);
            // this.Controls.SetChildIndex(pictureBox1, -1);
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

            CheckBox? chk = (sender as CheckBox);
            // MessageBox.Show($"{chk?.Checked} {chk?.Text}");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var control in groupBox1.Controls)
            {
                if(control is CheckBox chk && chk.Checked)
                {
                    MessageBox.Show($"{chk.Text}");
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(textBox1.Text);
            MessageBox.Show(textBox1.SelectedText);


            textBox1.DeselectAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString());

            // monthCalendar1.SelectionEnd = DateTime.Now;
            // monthCalendar1.SelectionStart 
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}