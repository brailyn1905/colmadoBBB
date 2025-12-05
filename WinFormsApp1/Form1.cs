using CapaPresenacion;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            GestiónInventario ventana = new GestiónInventario();
            ventana.Show();  
        }
    }
}
