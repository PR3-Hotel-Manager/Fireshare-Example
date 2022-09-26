// 1. Install Firesharp 
// 2. Import libraries 
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Windows.Forms;

namespace vbEngC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 3. Copy AuthSecret and BasePath from Firebase Project
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "13qazvxvMETHRB4C4CWjlCkbQeHan9ePUz2Mg4Rs",
            BasePath = "https://cfireeng-6297d-default-rtdb.firebaseio.com/"
            
        };

        // 4. Type this
        IFirebaseClient client;

        // 5. Double click form
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            } catch
            {
                MessageBox.Show("There was a problem with the interenet");
            }
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            Student std = new Student()
            {
                FullName = nameTbox.Text,
                RollNo = rollTbox.Text,
                Grade = gradeTbox.Text,
                Section = sectionTbox.Text
            };
            var setter = client.Set("StudentList/" + rollTbox.Text, std);
            MessageBox.Show("Data inserted successfuly.");
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            var result = client.Get("StudentList/" + rollTbox.Text);
            Student std = result.ResultAs<Student>();
            nameTbox.Text = std.FullName;
            gradeTbox.Text = std.Grade;
            sectionTbox.Text = std.Section;
            MessageBox.Show("Data retrieved successfuly.");

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Student std = new Student()
            {
                FullName = nameTbox.Text,
                RollNo = rollTbox.Text,
                Grade = gradeTbox.Text,
                Section = sectionTbox.Text
            };
            var setter = client.Update("StudentList/" + rollTbox.Text, std);
            MessageBox.Show("Data inserted successfuly.");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var setter = client.Delete("StudentList/" + rollTbox.Text);
            MessageBox.Show("Data deleted successfuly.");
        }
    }
}