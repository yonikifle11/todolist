namespace todolist
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Class1 s = new Class1()
            {
                thing1 = tb1.Text,
                
            };
            s.save();
            //DGV1.DataSource = null;
            //DGV1.DataSource = String.GetAllProducts();

        }

        

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}