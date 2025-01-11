using System;
using System.Data;
using System.Data.SqlClient;

namespace UniversityMaterialsRegistrationSystem

{
    public partial class Form1 : Form
    {
        private List<Tuple<int, string>> selectedMaterials = new List<Tuple<int, string>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=VICTUS;Initial Catalog=UniversityDb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string query = "SELECT COUNT(*) FROM Users WHERE username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txtUser.Text); // Ensure the parameter name matches exactly
            cmd.Parameters.AddWithValue("@password", txtPass.Text); // Ensure the parameter name matches exactly
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count > 0)
            {
                MessageBox.Show("Login success", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("error in login");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            MessageBox.Show("You are now on the registration page.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLoadMaterials_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=VICTUS;Initial Catalog=UniversityDb;Integrated Security=True;TrustServerCertificate=True");
            string query = "SELECT * FROM Materials";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewMaterials.DataSource = dt;
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaterialId.Text) || string.IsNullOrWhiteSpace(txtMaterialName.Text))
            {
                MessageBox.Show("Please enter both Material ID and Name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int materialId;
            if (!int.TryParse(txtMaterialId.Text, out materialId))
            {
                MessageBox.Show("Material ID must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a Tuple to store the Material ID and Name and add it to the list
            string materialName = txtMaterialName.Text;
            selectedMaterials.Add(new Tuple<int, string>(materialId, materialName));

            // Update the ListBox with the newly added material
            UpdateSelectedMaterialsUI();

            // Clear the input fields
            txtMaterialId.Clear();
            txtMaterialName.Clear();

            MessageBox.Show("Material added to the list!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void UpdateSelectedMaterialsUI()
        {
            listBoxMyMaterials.Items.Clear(); // Clear the ListBox before updating

            // Add the remaining materials in the list to the ListBox
            foreach (var material in selectedMaterials)
            {
                listBoxMyMaterials.Items.Add($"{material.Item1} - {material.Item2}"); // Display Material ID and Name
            }
        }



        private void btnClearList_Click(object sender, EventArgs e)
        {
            // Clear the list of selected materials
            selectedMaterials.Clear();

            // Update the ListBox to reflect the cleared list
            UpdateSelectedMaterialsUI();
        }

        private void btnRemoveMaterial_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaterialId.Text))
            {
                MessageBox.Show("Please enter a Material ID to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int materialId;
            if (!int.TryParse(txtMaterialId.Text, out materialId))
            {
                MessageBox.Show("Material ID must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Find the material in the list using the Material ID
            var materialToRemove = selectedMaterials.FirstOrDefault(m => m.Item1 == materialId);

            if (materialToRemove != null)
            {
                // Remove the material from the list
                selectedMaterials.Remove(materialToRemove);

                // Update the ListBox after removal
                UpdateSelectedMaterialsUI();

                MessageBox.Show("Material removed successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Material with the given ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}