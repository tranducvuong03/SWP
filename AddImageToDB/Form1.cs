using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace C_
{
	public partial class Form1 : Form
	{
		string imageUrl = null;
		SqlConnection con = new SqlConnection("server=.\\hungdt; database=Test; integrated security = true");
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'testDataSet.Images' table. You can move, or remove it, as needed.
			this.imagesTableAdapter.Fill(this.testDataSet.Images);

		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			using(OpenFileDialog ofd= new OpenFileDialog())
			{
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					imageUrl = ofd.FileName;
					pictureBox1.Image= Image.FromFile(ofd.FileName);
				}
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Image img = pictureBox1.Image;
			byte[] arr;
			ImageConverter converter = new ImageConverter();
			arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

			con.Open();

			// Get the latest ID from the database
			SqlCommand cmd3 = new SqlCommand("SELECT MAX(Id) FROM Images", con);
			int latestId = (int)cmd3.ExecuteScalar() + 1;

			SqlCommand cmd = new SqlCommand("INSERT INTO Images (Id, ImageName, Image, ImageUrl) VALUES (@Id, @ImageName, @Image, @Imageurl)", con);
			cmd.Parameters.AddWithValue("@Id", latestId);
			cmd.Parameters.AddWithValue("@ImageName", textBox1.Text);
			cmd.Parameters.AddWithValue("@Image", arr);
			cmd.Parameters.AddWithValue("@Imageurl", imageUrl);
			cmd.ExecuteNonQuery();
			MessageBox.Show("Image saved!!!");

			SqlCommand cmd2 = new SqlCommand("SELECT * FROM IMAGES", con);
			DataTable dt = new DataTable();
			dt.Load(cmd2.ExecuteReader());
			dataGridView1.DataSource = dt;
			con.Close();

		}
	}
}
