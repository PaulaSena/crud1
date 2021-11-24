using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            consultarPessoa();
            //  fillComboBox();
        }


        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            consultarPessoa();
        }
        #region  Load || Botão Consultar Pessoa

        public DataTable consultarPessoa()
        {
            DataTable gridPessoa = new DataTable();

            SqlConnection Conexao = new SqlConnection();

            String str = @"Data Source = DESKTOP-9J2BVIQ; Initial Catalog = hotelTeste; Integrated Security = True";

            try
            {

                string Query = " SELECT idPessoa " +
                              " , telPessoal " + " As [Tipo de Usuario] " +
                              " , nome " +
                              " , dataNasci " +
                              " , emailPessoal" +
                              " , dataDeAceP " +
                              " , paisOrigem " +
                              " , estadoOrigem " +
                              " , cidadeOrigem " +
                              " , sobrenome " +
                              " , idHosp_FK " +
                              " FROM Pessoa ";
                // " FROM Usuario " + ;
                //  " Where idUser = 3  ";



                Conexao.ConnectionString = str;
                SqlDataAdapter Da = new SqlDataAdapter(Query, Conexao);
                // F9
                Da.Fill(gridPessoa);

            }
            catch (Exception e)
            {
                String err = e.Message;
            }

            return gridPessoa;
        }
        #endregion


        //string str = @"Data Source = DESKTOP-9J2BVIQ; Initial Catalog = hotelTeste; Integrated Security = True";
        //string Query = "SELECT ID,nome FROM Pessoa";

        //SqlConnection Conexao = new SqlConnection(str);
        //SqlCommand Comando = new SqlCommand(Query, Conexao);
        //SqlDataAdapter da = new SqlDataAdapter(Query, Conexao);

        //DataTable Pessoa = new DataTable();

        //da.Fill(Pessoa);

        //gridPessoa.DataSource = Pessoa;




        private void BtnNomeInserir_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection("Data Source = DESKTOP-9J2BVIQ;Initial Catalog = hotelTeste;Integrated Security = True");


            con.Open();
            SqlCommand command = new SqlCommand("insert into Pessoa values ('" + int.Parse(txtIdPessoa.Text) + "','" + txtNome.Text + "','" + txtSobrenome.Text + "','" + cbxEmailPromo.Text + "', getdate(), getdate(),'" + DateTime.Parse(dataTimeS.Text) + "')");
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted.");
            con.Close();
            BindData();
        }
        void BindData()
        {
            SqlConnection con = new SqlConnection("Data Source=catalog-svr;Initial Catalog=ProgrammingTutorialDB;Persist Security Info=True;User ID=sa;Password=row@129");

            SqlCommand command = new SqlCommand("select * from Pessoa", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            gridPessoa.DataSource = dt;
        }

        // SqlConnection Conexao = new SqlConnection("Data Source = DESKTOP-9J2BVIQ; Initial Catalog = hotelTeste; Integrated Security = True");

        // //  string Query =("INSERT INTO Pessoa Values('"+ + "'))";
        //SqlCommand Comando = new SqlCommand("insert into Pessoa values('" + int.Parse(txtIdPessoa.Text) + "','" + txtNome.Text + "','" + txtSobrenome.Text + "','" + txtTelefone.Text + "','" + DateTime.Parse(maskDataN.Text) + "','" + txtEmail.Text + "','" + txtPais.Text + "','" + txtEstado.Text + "','" + txtCidade.Text + "','" + DateTime.Parse(dataTimeS.Text) + "','" + unchecked(cbxEmailPromo.Text) + "', getdate())", Conexao);

        // Conexao.Open();
        // Comando.ExecuteNonQuery();
        // Conexao.Close();
        // MessageBox.Show("Dados Cadastrados!");






    

        //   string Query = "INSERT INTO Pessoa Values('" + int.Parse(txtIdPessoa.Text) + "','" + txtNome.Text + "','" + txtSobrenome.Text + "','" + txtTelefone.Text + "','" + DateTime.Parse(maskDataN.Text) + "','" + txtEmail.Text + "','" + txtPais.Text + "','" + txtEstado.Text + "','" + txtCidade.Text + "','" + DateTime.Parse(dataTimeS.Text) + "','" + cbxEmailPromo + "', getdate())";
        //string Query = "INSERT INTO Pessoa Values('" + "idPessoa = '" + int.Parse(txtIdPessoa.Text) + "'," +
        //    " nome = '" + txtNome.Text + "'," +
        //    "sobrenome = '" + txtSobrenome.Text + "'," +
        //    "telPessoal = '" + txtTelefone.Text + "'," +
        //    "dataNasci = '" + DateTime.Parse(maskDataN.Text) + "'," +
        //    "emailPessoal= '" + txtEmail.Text + "'," +
        //    "paisOrigem = '" + txtPais.Text + "'," +
        //    "estadoOrigem = '" + txtEstado.Text + "'," +
        //    "cidadeOrigem = '" + txtCidade.Text + "'," +
        //    "dataDeAceP = '" + DateTime.Parse(dataTimeS.Text) + "'," +
        //    "idAceite = '" + cbxEmailPromo.Checked + "', getdate())";

        // SqlCommand Comando = new SqlCommand(Query, Conexao);

        //  "VALUES('" + txtIdPessoa.Text + "'," +
        //  " '" + txtNome.Text + "'," +
        //  " '" + txtSobrenome.Text + "'," +
        //  " '" + txtTelefone.Text + "'," +
        //" '" + maskDataN.ToString + "'," +
        //  " '" + txtEmail.Text + "'," +
        //  " '" + txtPais.Text + "'," +
        //  " '" + txtEstado.Text + "'," +
        //  " '" + txtCidade.Text + "'," +
        //" '" +DataTime.Parse(dataTimeS.Text) + "'," +
        //  " '" + cbxEmailPromo.Checked + "') ";



        //SqlConnection Conexao = new SqlConnection(str);
        //SqlCommand Comando = new SqlCommand(Query, Conexao);


        //  string Query = "INSERT INTO Pessoa(nome//,sobrenome,telPessoal,dataNasci,emailPessoal,paisOrigem,estadoOrigem,cidadeOrigem,dataDeAceP,idAceite)VALUES(@idPessoa,@nome,@sobrenome,@telPessoal,@dataNasci,@emailPessoal,@paisOrigem,@estadoOrigem,@cidadeOrigem,@dataDeAceP,@idAceite)";
        //'" + txtNome.Text + "')";
        //  SqlCommand Comando = new SqlCommand(Query, Conexao);
        // nome,sobrenome,telPessoal,dataNasci,emailPessoal,paisOrigem,estadoOrigem,cidadeOrigem,dataDeAceP,
        //Comando.Parameters.AddWithValue("@idPessoa", txtIdPessoa.Text);
        //Comando.Parameters.AddWithValue("@nome", txtNome.Text);
        //Comando.Parameters.AddWithValue("@sobrenome", txtSobrenome.Text);
        //Comando.Parameters.AddWithValue("@telPessoal", txtTelefone.Text);
        //Comando.Parameters.AddWithValue("@dataNasci", maskDataN.Text);
        //Comando.Parameters.AddWithValue("@emailPessoal", txtEmail.Text);
        //Comando.Parameters.AddWithValue("@paisOrigem", cboxPais.SelectedItem);
        //Comando.Parameters.AddWithValue("@estadoOrigem", cboxEst.SelectedItem);
        //Comando.Parameters.AddWithValue("@cidadeOrigem", cboxCid.SelectedItem);
        //Comando.Parameters.AddWithValue("@dataDeAceP", dataTimeS.Value.ToShortDateString());
        //Comando.Parameters.AddWithValue("@idAceite", cbxEmailPromo.Checked);

        // Conexao.ConnectionString = str; 
        //  SqlDataAdapter Da = new SqlDataAdapter(Query, Conexao);

        // Conexao.Open();
        //     Comando.ExecuteNonQuery();
        //     Conexao.Close();
        //     MessageBox.Show("Dados Cadastrados!");

        //}

        ////fillComboBox method for filling the ComboBox with Data
        //private void fillComboBox()
        //{
        //    try
        //    {
        //        string strConexao = @"Server=(DESKTOP-9J2BVIQ);DataBase= hotelTeste;Integrated Security=true";
        //      //  string Query = "INSERT INTO Pessoa(nome,sobrenome,telPessoal,dataNasci,emailPessoal,paisOrigem,estadoOrigem,cidadeOrigem,dataDeAceP,idAceite)VALUES(@idPessoa,@nome,@sobrenome,@telPessoal,@dataNasci,@emailPessoal,@paisOrigem,@estadoOrigem,@cidadeOrigem,@dataDeAceP,@idAceite)"; //'" + txtNome.Text + "')";

        //        SqlConnection conexao = new SqlConnection(strConexao);
        //        //SqlCommand Comando = new SqlCommand(Query, conexao);


        //     //   SqlConnection conexao = new SqlConnection();
        //        // SqlConnection conexao = new SqlConnection(@"Server=(DESKTOP-9J2BVIQ);DataBase= hotelTeste;Integrated Security=true")
        //        {
        //            conexao.Open();
        //            SqlDataAdapter adapt = new SqlDataAdapter("Select * from pais", conexao);
        //            DataTable pais = new DataTable();
        //            adapt.Fill(pais);
        //            //Set Displaymember as Country
        //            cboxPais.DisplayMember = "pais";
        //            //Set ValueMember as ID
        //            cboxPais.ValueMember = "nome";
        //            cboxPais.DataSource = pais;
        //        }
        //        conexao.Close();
        //    }

        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);

        //    }
        //}

        private void BtnNomeUpdate_Click(object sender, EventArgs e)
            {

            }

            private void BtnNomeDelete_Click(object sender, EventArgs e)
            {

            }
     }
 }



//'" + txtNome.Text + "')";
//txtIdPessoa.Clear();
//txtNome.Clear();
//txtSobrenome.Clear();
//txtEmail.Clear();
//txtTelefone.Clear();
//maskDataN.Clear();
//dataTimeS.Text = "";
//cboxCid.Text = "";
//cboxEst.Text = "";
//cboxPais.Text = "";
//"@idAceite", cbxEmailPromo.Checked);
//txtIdPessoa txtNome txtSobrenome  txtEmail  txtTelefone  maskDataN  dataTimeS  cboxCid  cboxEst  cboxPais idAceite