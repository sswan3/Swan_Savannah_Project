using System.Xml.Linq;

namespace Swan_Savannah_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // 1. Get the text and remove leading/trailing spaces for clean checking
            string inputName = txtName.Text.Trim();

            // 2. Start the IF condition with two full checks:
            //    a) Check if the input is NOT null, empty, or just whitespace.
            //    b) Check if the list box does NOT already contain this exact name.
            if (!string.IsNullOrWhiteSpace(inputName) && !lstNames.Items.Contains(inputName))
            {
                // 3. If both checks pass, add the name to the ListBox
                lstNames.Items.Add(inputName);

                // Optional: Clear the TextBox after adding the name
                txtName.Text = string.Empty;
            }
            // 4. Optional: Add an 'else' block if you want to give the user feedback
            else
            {
                // Example: If the name is a duplicate or empty, you could show a message box
                // MessageBox.Show("Please ente
            }
        }
}
