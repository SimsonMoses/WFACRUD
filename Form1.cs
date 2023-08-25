using Amazon.Runtime.Internal.Util;
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
    public partial class Form1 : Form
    {

        static MongoClient client = new MongoClient();
        static IMongoDatabase database = client.GetDatabase("dotnetCRUD");
        static IMongoCollection<Student> collection = database.GetCollection<Student>("students");

        public void ReadAllDocuments()
        {
            List<Student> studentsList = collection.AsQueryable().ToList<Student>();
            dataGridView1.DataSource = studentsList;
            textBox1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[0].Cells[2 ].Value.ToString();


        }


        public Form1()
        {
            InitializeComponent();
            ReadAllDocuments();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student(textBox2.Text,Double.Parse(textBox3.Text)); 
            collection.InsertOne(s);
            ReadAllDocuments();
        }
    }
}
