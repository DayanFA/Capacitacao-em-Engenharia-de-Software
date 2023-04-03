using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System.Data;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var strconexao = "server=localhost;uid=root;database=filmes;pwd=1234";
                var conexao = new MySqlConnection(strconexao);
                conexao.Open();
                MessageBox.Show("Conexão bem sucedida");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao se conectar: " + ex.Message);
            }
        }

        private void botao_Click(object sender, EventArgs e)
        {
            resultado.Text = campo_id.Text;

        }

        private void botao2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(campo_id.Text);
                string titulo = campo_titulo.Text;
                string estou = campo_estou.Text;
                float nota = float.Parse(campo_nota.Text);
                float data = float.Parse(campo_data.Text);
                string critica = campo_critica.Text;

                MySqlConnection con = new MySqlConnection("server = localhost; " + "database= filmes; " + "user id = root; " + "password=1234;");
                MySqlCommand cmd = new MySqlCommand("insert into filmes values ('" + id + "','" + titulo + "','" + estou + "','" + nota + "','" + data + "','" + critica + "' ); ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                atualizar_ds();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível enviar: " + ex.Message);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_desativar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void carregar_Click(object sender, EventArgs e)
        {
            atualizar_ds();
        }
        public void atualizar_ds()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("server = localhost; " + "database= filmes; " + "user id = root; " + "password=1234;");
                MySqlCommand cmd = new MySqlCommand(" select * from filmes ", con);
                con.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                dados.DataSource = ds;
                dados.DataMember = ds.Tables[0].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao se conectar: " + ex.Message);
            }
        }
        private void dados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            campo_id.Text = dados.CurrentRow.Cells[0].Value.ToString();
            campo_titulo.Text = dados.CurrentRow.Cells[1].Value.ToString();
            campo_estou.Text = dados.CurrentRow.Cells[2].Value.ToString();
            campo_nota.Text = dados.CurrentRow.Cells[3].Value.ToString();
            campo_data.Text = dados.CurrentRow.Cells[4].Value.ToString();
            campo_critica.Text = dados.CurrentRow.Cells[5].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(campo_id.Text);
                string titulo = campo_titulo.Text;
                string estou = campo_estou.Text;
                float nota = float.Parse(campo_nota.Text);
                float data = float.Parse(campo_data.Text);
                string critica = campo_critica.Text;

                MySqlConnection con = new MySqlConnection("server = localhost; " + "database= filmes; " + "user id = root; " + "password=1234;");
                MySqlCommand cmd = new MySqlCommand("update filmes set Título = '" + titulo + "', Estou = '" + estou + "', Nota = '" + nota + "', Ano_Assistido = '" + data + "', Crítica = '" + critica + "' where Id ='" + id + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                atualizar_ds();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível editar: " + ex.Message);
            }
        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(campo_id.Text);

                MySqlConnection con = new MySqlConnection("server = localhost; " + "database= filmes; " + "user id = root; " + "password=1234;");
                MySqlCommand cmd = new MySqlCommand("delete from filmes where Id = '" + id + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                campo_titulo.Clear();
                campo_estou.Clear();
                campo_nota.Clear();
                campo_data.Clear();
                campo_critica.Clear();
                atualizar_ds();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível deletar: " + ex.Message);
            }
        }

        private void campo_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultado_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}