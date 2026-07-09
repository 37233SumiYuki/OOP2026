using System.Globalization;

namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        //‡@
        private void button1_Click(object sender, EventArgs e) {
            DateTime today = DateTime.Now;
            textBox1.Text = $"{today.Year}/{today.Month:00}/{today.Day:00} {today.Hour:00}:{today.Minute:00}";
        }
        //‡A
        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            DateTime today = DateTime.Now;
            textBox2.Text = $"{today.Year}”N{today.Month:00}ŒŽ{today.Day:00}“ú {today.Hour:00}Žž{today.Minute:00}•ª{today.Second:00}•b";
        }

        private void button3_Click(object sender, EventArgs e) {
            DateTime today = DateTime.Now;
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            textBox3.Text = today.ToString("gg y”N MŒŽ d“ú(dddd)",culture);
           
        }
    }
}
