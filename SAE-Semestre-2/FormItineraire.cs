namespace SAE_Semestre_2
{
    public partial class FormItineraire : Form
    {
        public FormItineraire()
        {
            InitializeComponent();
        }

        private void FormItineraire_Load(object sender, EventArgs e)
        {
            BD.connexion();
        }
    }
}
