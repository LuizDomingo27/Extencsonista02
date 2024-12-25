using System.Security.Cryptography;
using System.Text;

using ControleEstoqueEscolar.DBContext;
using ControleEstoqueEscolar.ModelContext;

using Guna.UI2.WinForms;

namespace ControleEstoqueEscolar.Controler
{
   public static class Funcoes
   {
      static string senhaComparado;
      static string nomeComparado;
      static string emailComparado;
      static int Id;
      public static void SalvarUsuario(Form frm, string nome, string email, string senha)
      {
         if (VerificaCamposVazios(frm))
         {
            Usuario user = new()
            {
               Email = email,
               Nome = nome,
               Senha = senha
            };

            try
            {
               using ConexaoContexto conexao = new();
               conexao.Usuarios.Add(user);
               conexao.SaveChanges();
               MessageBox.Show($"Usuário {nome} cadastrado.");
               conexao.Dispose();
            }
            catch (Exception e)
            {
               if (e.InnerException.HResult == -2147467259)
               {
                  MessageBox.Show("E-mail já está cadastrado...");
                  return;
               }
               else
               {
                  MessageBox.Show(e.InnerException.Message);
                  return;
               }
            }
         }
      }

      public static void SalvarProduto(string nome, string categoria, int qtd, int qtdmim, ListView lista)
      {
         try
         {
            Produto produto = new()
            {
               Nome = nome,
               Categoria = categoria,
               Quantidade = qtd,
               QuantidadeMinima = qtdmim,
            };

            using ConexaoContexto conexao = new();
            conexao.Produtos.Add(produto);
            conexao.SaveChanges();
            MessageBox.Show("Produto salvo!");
            conexao.Dispose();
            AdcionarDadosNaListViewProduto(lista);
         }
         catch (Exception e)
         {
            MessageBox.Show("Erro ao cadastrar produto,\n Verifique se ele já está cadastrado.");
            MessageBox.Show(e.InnerException.Message);
            return;
         }
      }

      public static bool VerificaCamposVazios(Form frm)
      {
         foreach (Control control in frm.Controls)
         {
            if (control is Guna2TextBox)
            {
               if (control.Text == "")
               {
                  MessageBox.Show("Existe campos vazios!");
                  return false;
               }
            }
         }
         return true;
      }

      public static void LimparCampos(Form frm)
      {
         foreach (Control c in frm.Controls)
         {
            if (c is ComboBox || c is Guna2TextBox)
            {
               c.ResetText();
            }
         }
      }

      public static void AdcionarDadosNaListViewProduto(ListView list)
      {
         List<Produto> produtos = [];
         using ConexaoContexto conexao = new();
         var consulta = conexao.Produtos;
         var result = consulta.Where(p => p.Id > 0)
                              .Select(p => new
                              {
                                 p.Id,
                                 p.Nome,
                                 p.Categoria,
                                 p.Quantidade,
                                 p.QuantidadeMinima
                              }).ToList();

         //Adicionando os dados na Lista de produtos que é o parametro
         result.ForEach(p => produtos.Add
                       (new Produto
                       (p.Id, p.Nome, p.Categoria, p.Quantidade, p.QuantidadeMinima)));

         list.Items.Clear();

         //Adicionando os dados dentro da ListView
         foreach (var p in produtos)
         {
            ListViewItem item = list.Items.Add(p.Id.ToString()); ;
            item.SubItems.Add(p.Nome);
            item.SubItems.Add(p.Categoria);
            item.SubItems.Add(p.Quantidade.ToString());
            item.SubItems.Add(p.QuantidadeMinima.ToString());
         }
      }

      public static string EncriptPassword(string pass)
      {
         //using RSA rs = RSA.Create();
         //byte[] caractere = rs.Encrypt(Encoding.UTF8.GetBytes(pass), RSAEncryptionPadding.OaepSHA3_256);
         using SHA256 hash = SHA256.Create();
         byte[] caractere = hash.ComputeHash(Encoding.UTF8.GetBytes(pass));
         StringBuilder fraseEncript = new();
         foreach (var letra in caractere)
         {
            fraseEncript.Append(letra.ToString("x2"));
         }
         return $"{fraseEncript}";
      }

      public static string DecriptPassword(ReadOnlySpan<byte> pass)
      {
         using RSA rs = RSA.Create();
         byte[] caractere = rs.Decrypt(pass, RSAEncryptionPadding.OaepSHA3_256);
         StringBuilder fraseDescript = new();
         foreach (var letra in caractere)
         {
            fraseDescript.Append(letra);
         }
         return $"{fraseDescript}";
      }

      public static bool Login(string senha, string email)
      {
         List<Usuario> list = new();
         BuscarDados<Usuario>(list);
         var result = list.Where(use => use.Senha.Equals(senha) && use.Email.Equals(email))
                          .Select(r => r.Senha).ToList();

         if (result.Contains(senha))
         {
            return true;
         }
         else
         {
            MessageBox.Show("Senha ou e-mail inválido", ":)");
            return false;
         }
      }

      static void BuscarDados<T>(List<T> obj) where T : class
      {
         if (obj.GetType() == typeof(List<Usuario>))
         {
            using ConexaoContexto conexao = new();
            var result = from p in conexao.Usuarios select p;
            foreach (var use in result)
            {
               obj.Add(new Usuario(use.Id, use.Nome, use.Email, use.Senha) as T);
            }
         }
         else if (obj.GetType() == typeof(List<Produto>))
         {
            using ConexaoContexto conexao = new();
            var result = from p in conexao.Produtos select p;
            foreach (var p in result)
            {
               obj.Add(new Produto(p.Id, p.Nome, p.Categoria, p.Quantidade, p.QuantidadeMinima) as T);
            }
         }
      }

      public static void AtualizarProduto(int id, string nome, string categoria, int quant, int qtdMin)
      {
         using ConexaoContexto conexao = new();
         var prod = conexao.Produtos.Find(id);
         prod.Nome = nome;
         prod.Categoria = categoria;
         prod.Quantidade = quant;
         prod.QuantidadeMinima = qtdMin;
         conexao.SaveChanges();
      }

      public static void DeleteProduto(int Id)
      {
         try
         {
            /* Essa froma de selecionar um unico registro de uma tabela
               usando a consulta abaixo, não vai fucnionar para deletar 
               um resgistro. EX -> var result = from p in conexao.Produtos where p.Id == Id select p;
               sendo dessa froma citada, não ira funcionar, vai causar um erro.
               a forma coreta será -> var result = conexao.Produtos.Single(p => p.Id == Id);
             */

            using ConexaoContexto conexao = new();
            var result = conexao.Produtos.Single(p => p.Id == Id);
            conexao.Remove(result);
            conexao.SaveChanges();
         }
         catch (Exception e)
         {
            MessageBox.Show(e.Message);
         }
      }

      public static bool RecuperarSenha(string nome, string email, string senha)
      {
         try
         {
            using ConexaoContexto conexao = new();
            var id = (from use in conexao.Usuarios where use.Email == email select use).ToList();
            foreach (var user in id)
            {
               senhaComparado = user.Senha;
               nomeComparado = user.Nome;
               emailComparado = user.Email;
               Id = user.Id;
            }

            var result = conexao.Usuarios.Find(Id);
            if (nomeComparado == nome && emailComparado == email)
            {
               result.Nome = nome;
               result.Email = email;
               result.Senha = senha;
               conexao.SaveChanges();
               return true;
            }
            else
            {
               MessageBox.Show("Usuário ou email não encontrado");
               return false;
            }
         }
         catch (Exception e)
         {
            MessageBox.Show("Erro ao atualizar a senha...\n" + e.Message);
         }
         return false;
      }

      public static string EncryptiPassowrMD5(string senha)
      {
         using MD5 md5 = MD5.Create();
         byte[] caracter = md5.ComputeHash(Encoding.UTF8.GetBytes(senha));
         StringBuilder sb = new();

         foreach (byte letter in caracter)
         {
            sb.Append(letter.ToString("X2"));
         }

         return sb.ToString();
      }

      public static int VerificarForcaSenha(string senha)
      {
         int forca = 0;
         if (senha.Length >= 6)
            forca++;

         if (senha.Any(char.IsLower))
            forca++;

         if (senha.Any(char.IsUpper))
            forca++;

         if (senha.Any(char.IsNumber))
            forca++;

         if (senha.Any(letra => !char.IsLetterOrDigit(letra)))
            forca++;

         return forca;
      }
   }
}
