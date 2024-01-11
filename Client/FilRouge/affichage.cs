using Domain.DTO.Request;
using Domain.Entities;
using System.ComponentModel;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FilRouge
{
    public partial class affichage : Form
    {
        private string AccessToken { get; set; }
        public APILink _link;
        public string base_Url = "https://localhost:7201/";
        BindingList<Categorie> _categories;
        BindingList<Materiel> _materiel;
        public JsonSerializerOptions options = new() { WriteIndented = true, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault, PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
        public affichage(string token)
        {
            AccessToken = token;
            InitializeComponent();

        }
        private async void affichage_LoadAsync(object sender, EventArgs e)
        {
            _link = new APILink();
            InitializeBinding();
            await ActualiserAsync();


        }
        private void InitializeBinding()
        {
            _categories = new BindingList<Categorie>();
            BSCategorie.DataSource = _categories;
            dgvCategorie.DataSource = BSCategorie;
            _materiel = new BindingList<Materiel>();
            BSMateriel.DataSource = _materiel;
            dgvMateriel.DataSource = BSMateriel;
            txtBoxCategorie.DataBindings.Add("Text", BSCategorie, "Label", true, DataSourceUpdateMode.Never);
            txtBoxMateriel.DataBindings.Add("Text", BSMateriel, "Nom", true, DataSourceUpdateMode.Never);
            _link._httpClient.BaseAddress = new Uri("https://localhost:7201/api/");
            _link._httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + AccessToken);
            dgvCategorie.Columns["Id"].Visible = false;
            dgvMateriel.Columns["Id"].Visible = false;
        }
        public async Task ActualiserAsync()
        {

            Categorie currentCat = BSCategorie.Current as Categorie;
            Materiel currentMat = BSMateriel.Current as Materiel;
            HttpResponseMessage reponse = await _link._httpClient.GetAsync(base_Url + "api/categorie/categorie");
            string jsontext = await reponse.Content.ReadAsStringAsync();
            var categories = JsonSerializer.Deserialize<IEnumerable<Categorie>>(jsontext, options);
            _categories.Clear();
            if (categories != null)
            {
                foreach (Categorie cat in categories)
                {
                    _categories.Add(cat);
                    if (currentCat is not null)
                    {
                        BSCategorie.Position = _categories.IndexOf(_categories.Where(i => i.Id == currentCat.Id).FirstOrDefault());
                    }
                }
                var reponseMat = await _link._httpClient.GetAsync(base_Url + "api/materiel/materiel");
                var jsonMat = await reponseMat.Content.ReadAsStringAsync();
                var materiel = JsonSerializer.Deserialize<IEnumerable<Materiel>>(jsonMat, options);
                _materiel.Clear();
                if (_materiel != null)
                {
                    foreach (Materiel mat in materiel)
                    {
                        _materiel.Add(mat);
                    }
                }
            }
            if (currentMat is not null)
            {
                BSMateriel.Position = _materiel.IndexOf(_materiel.Where(i => i.Id == currentMat.Id).FirstOrDefault(u => u.Id == currentMat.Id));
            }
        }

        public async void btAjouterCat_Click(object sender, EventArgs e)
        {
            if (txtBoxCategorie != null)
            {
                var cat = new CreateCategorieRequest(txtBoxCategorie.Text);

                JsonContent catJson = JsonContent.Create(cat);
                HttpResponseMessage reponseCat = await _link._httpClient.PostAsync(base_Url + " api/categorie/add", catJson);
                await ActualiserAsync();
            }
            else
            {
                MessageBox.Show("Veuillez renseigner le nom !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btSupCat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sur de vouloir supprimer cette catégorie ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Categorie current = BSCategorie.Current as Categorie;
                var reponseCat = await _link._httpClient.DeleteAsync(base_Url + "api/categorie/" + current.Id);
                if (reponseCat.IsSuccessStatusCode == false)
                {
                    MessageBox.Show(reponseCat.ReasonPhrase, "Problème !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                await ActualiserAsync();
            }
        }

        private async void btSupMat_Click(object sender, EventArgs e)
        {
            Materiel current = BSMateriel.Current as Materiel;
            if (MessageBox.Show("Etes vous sur de vouloir supprimer ce matériel ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                HttpResponseMessage reponse = await _link._httpClient.DeleteAsync(base_Url + "api / materiel/" + current.Id);
                if (reponse.IsSuccessStatusCode == false)
                {
                    MessageBox.Show(reponse.ReasonPhrase, "Problème !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                await ActualiserAsync();
            }
        }

        private async void btModifierMat_Click(object sender, EventArgs e)
        {
            Materiel current = BSMateriel.Current as Materiel;
            if (txtBoxMateriel.Text != "")
            {
                int idMat = (int)current.Id;
                var mat = new ModifyMaterielDTORequest(idMat, txtBoxMateriel.Text);
                JsonContent matJson = JsonContent.Create(mat);
                HttpResponseMessage reponse = await _link._httpClient.PutAsync(base_Url + "api/materiel/" + current.Id, matJson);
                if (reponse.IsSuccessStatusCode == false)
                {
                    MessageBox.Show(reponse.ReasonPhrase, "Problème !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            await ActualiserAsync();
        }

        private async void btModCat_Click(object sender, EventArgs e)
        {
            Categorie current = BSCategorie.Current as Categorie;
            if (txtBoxCategorie.Text != "")
            {
                var cat = new ModifyCategorieDTORequest(current.Id, txtBoxCategorie.Text);
                JsonContent catJson = JsonContent.Create(cat);
                HttpResponseMessage reponse = await _link._httpClient.PutAsync(base_Url + "api/categorie/" + current.Id, catJson);
            }
        }

        private async void dgvCategorie_CurrentCellChangedAsync(object sender, EventArgs e)
        {
            Categorie current = BSCategorie.Current as Categorie;
            if (current != null)
            {
                int idCat = current.Id;
                await ActualiserMatAsync(idCat);
            }
        }



        private async void btAjouterMat_Click(object sender, EventArgs e)
        {
            if (txtBoxMateriel.Text != "")
            {
                Categorie current = BSCategorie.Current as Categorie;
                var mat = new AddMaterielDTORequest(txtBoxMateriel.Text, current.Id, DateTime.Now, DateTime.Now);
                JsonContent matJson = JsonContent.Create(mat);
                HttpResponseMessage reponse = await _link._httpClient.PostAsync(base_Url + "api/ materiel", matJson);
                if (reponse.IsSuccessStatusCode == false)
                {
                    MessageBox.Show(reponse.ReasonPhrase, "Problème", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                await ActualiserAsync();
            }

        }
        private async Task ActualiserMatAsync(int idCategorie)
        {
            Materiel currentMat = BSMateriel.Current as Materiel;
            var jsonMat = await _link._httpClient.GetStringAsync(base_Url + "api/materiel/" + idCategorie);
            var materiel = JsonSerializer.Deserialize<IEnumerable<Materiel>>(jsonMat, options);
            _materiel.Clear();
            foreach (Materiel mat in materiel)
            {
                _materiel.Add(mat);
                if (currentMat != null)
                    BSMateriel.Position = _materiel.IndexOf(_materiel.Where(i => i.Id == currentMat.Id).FirstOrDefault(u => u.Id == currentMat.Id));
            }



        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btActualiser_Click(object sender, EventArgs e)
        {
            await ActualiserAsync();
        }

        private void btAssigner_Click(object sender, EventArgs e)
        {
            Materiel current = BSMateriel.Current as Materiel;
            if (current != null)
            {
                Utilsateur user = new Utilsateur(AccessToken, current, this);

                user.Show();


            }
        }
        private async Task ActualiserCatAsync(int idMat)
        {
            var jsonCat = await _link._httpClient.GetStringAsync(base_Url + "api/categorie/materiel " + idMat);
            _categories.Clear();
            var categorie = JsonSerializer.Deserialize<IEnumerable<Categorie>>(jsonCat, options);
            foreach (Categorie cat in categorie)
            {
                _categories.Add(cat);

            }
        }



        private async void dgvMateriel_CellClickAsync(object sender, DataGridViewCellEventArgs e)
        {
            {
                Materiel current = BSMateriel.Current as Materiel;

                if (current is not null)
                    await ActualiserCatAsync(current.Id);
            }
        }
    }
}


