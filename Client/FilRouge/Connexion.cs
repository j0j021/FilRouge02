using Domain.DTO.Requests;
using Domain.DTO.Responses;
using System.Net.Http.Json;
using System.Text.Json;

namespace FilRouge;

public partial class Connexion : Form
{
    private string AccesToken;
    APILink _link;
    public string base_Url = "https://localhost:7201/";
    public Connexion()
    {
        InitializeComponent();

    }




    private async void btValider_Click_1(object sender, EventArgs e)
    {
        if (!((txtUsername.Text == string.Empty) || (txtPassword.Text == string.Empty)))
        {
            var login = new LoginRequest(txtUsername.Text, txtPassword.Text);
            var logJson = JsonSerializer.Serialize(login);
            JsonContent json = JsonContent.Create(login);
            var reponse = await _link._httpClient.PostAsync(base_Url + "api/account/login", json);
            if (reponse.IsSuccessStatusCode)
            {
                AccesToken = (await reponse.Content.ReadFromJsonAsync<LoginResponse>()).AccessToken;

                if (AccesToken != "")
                {
                    affichage aff = new affichage(AccesToken);


                    aff.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Identification incorrecte", "Attention", MessageBoxButtons.OK);
                }
            }


        }
        else
        {
            MessageBox.Show("Remplissez tous les champs s'il vous plait !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    private void btQuitter_Click_1(object sender, EventArgs e)
    {
        this.Close();
    }

    private void Connexion_Load(object sender, EventArgs e)
    {
        _link = new APILink();
    }
}