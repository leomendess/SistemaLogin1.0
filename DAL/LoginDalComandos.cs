using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTelaDeLogin.DAL
{
    class LoginDalComandos
    {
        public bool tem = false;
        public String mensagem = "";//tudo certo
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        //private object con;
        SqlDataReader dr;
        public bool verificarLogin(String login, String senha)
        {
            // comandos sql para verificar se tem no banco
            cmd.CommandText = "select * from logins where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro, Verifique.";
                //throw;
            }

            return tem;

        }

        internal void cadastrar()
        {
            throw new NotImplementedException();
        }

        public String cadastrar(String email, String senha, String confSenha)
        {
            //comandos para inserir
            if (senha.Equals(confSenha))
            {
                cmd.CommandText = "insert into logins values(@e,@s);";
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", senha);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastro feito com sucesso, você ja poder entar no sistema!";
                    tem = true;

                }
                catch (SqlException)
                {
                    this.mensagem = "Erro, Login já existente. Modifique por favor!";
                }
            }
            else
            {
                this.mensagem = "Senhas não correspondem, favor verificar";
            }
            return mensagem; 
        }
    }
    }
            
            
        
