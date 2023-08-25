using Amazon.Runtime.Internal.Util;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFACRUD.model;

namespace WFACRUD
{
    public partial class WAFPage : Form
    {

        static MongoClient client = new MongoClient();
        static IMongoDatabase database = client.GetDatabase("dotnetCRUD");
        static IMongoCollection<Student> collection = database.GetCollection<Student>("students");

        public void ReadAllDocuments()
        {
            List<Student> studentsList = collection.AsQueryable().ToList<Student>();
            dataView.DataSource = studentsList;
            Id.Text = dataView.Rows[0].Cells[0].Value.ToString();
            txtName.Text = dataView.Rows[0].Cells[1].Value.ToString();
            GPA.Text = dataView.Rows[0].Cells[2 ].Value.ToString();

        }

        public WAFPage()
        {
            InitializeComponent();
            ReadAllDocuments();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id.Text = dataView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataView.Rows[e.RowIndex].Cells[1].Value.ToString();
            GPA.Text = dataView.Rows[e.RowIndex].Cells[2].Value.ToString();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student(txtName.Text,Double.Parse(GPA.Text)); 
            collection.InsertOne(s);
            ReadAllDocuments();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var  updateDef = Builders<Student>.Update.Set("name",txtName.Text).Set("gpa",GPA.Text);
            collection.UpdateOne(s => s.Id == ObjectId.Parse(Id.Text), updateDef);
            ReadAllDocuments();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            collection.DeleteOne(s=>s.Id == ObjectId.Parse(Id.Text));
            ReadAllDocuments();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtId(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GPA_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
