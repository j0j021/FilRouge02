
using Domain.DTO.Request;
using Domain.Entities;
using System.ComponentModel;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FilRouge
{
    public partial class Utilsateur : Form
    {
        private string token { get; set; }
        public JsonSerializerOptions options = new() { WriteIndented = true, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault, PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
        public Materiel materiel { get; set; }
        BindingList<User> _user;
        public APILink _link;
        public string base_Url = "https://localhost:7201/";
        public affichage Parent;
        public Utilsateur(string token, Materiel mat, affichage parent)

        {

            Parent = parent;
            if (mat.Debut is null) mat.Debut = DateTime.Now;
            if (mat.Fin is null) mat.Fin = DateTime.Now;
            this.token = token;
            this.materiel = mat;


            InitializeComponent();
            InitializeBinding();


        }

        private void BtRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void InitializeBinding()
        {
            _user = new BindingList<User>();
            dgvUser.DataSource = _user;
            BSUser.DataSource = _user;
            dgvUser.DataSource = BSUser;
            NomMateriel.Text = materiel.Nom;
            dgvUser.Columns["password"].Visible = false;
            dgvUser.Columns["Role"].Visible = false;
            dgvUser.Columns["Email"].Visible = false;
            dgvUser.Columns["Created"].Visible = false;
            dgvUser.Columns["Telephone"].Visible = false;
            dtpDebut.Value = (DateTime)materiel.Debut;
            dtpFin.Value = (DateTime)materiel.Fin;
            dtpDebut.DataBindings.Add("Text", materiel, "Debut", false, DataSourceUpdateMode.Never);
            dtpFin.DataBindings.Add("Text", materiel, "Fin", false, DataSourceUpdateMode.Never);

        }

        private async void Utilsateur_Load(object sender, EventArgs e)
        {
            _link = new APILink();
            await ActualiserAsync();
        }
        public async Task ActualiserAsync()
        {
            User currentUser = BSUser.Current as User;

            {

                HttpResponseMessage reponse = await _link._httpClient.GetAsync(base_Url + "api/user/user");
                string jsonText = await reponse.Content.ReadAsStringAsync();
                var user = JsonSerializer.Deserialize<IEnumerable<User>>(jsonText, options);
                _user.Clear();
                foreach (User detenteur in user)
                {
                    _user.Add(detenteur);
                    if (currentUser is not null)
                    {
                        BSUser.Position = _user.IndexOf(_user.Where(u => u.Id == currentUser.Id).FirstOrDefault());

                    }
                }
            }
        }

        private void btRetour_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btAssigner_Click(object sender, EventArgs e)
        {

            User currentUser = BSUser.Current as User;
            if (currentUser is not null)
            {
                AssignerMaterielDTORequest lien = new AssignerMaterielDTORequest(currentUser.Id, (int)materiel.Id, dtpDebut.Value, dtpFin.Value);
                var lienJson = JsonSerializer.Serialize(lien);
                JsonContent json = JsonContent.Create(lien);
                HttpResponseMessage res = await _link._httpClient.PostAsync(base_Url + "api/user/assign", json);

                await Parent.ActualiserAsync();
                this.Close();
                ;

            }
        }

        private void BSUser_CurrentChanged(object sender, EventArgs e)
        {
            User currentUser = BSUser.Current as User;
            if (currentUser is not null)
            {
                proprietaire.Text = currentUser.Name;

            }
        }
    }
}
