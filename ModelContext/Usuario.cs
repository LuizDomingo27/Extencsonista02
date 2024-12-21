using System.ComponentModel.DataAnnotations;

namespace ControleEstoqueEscolar.ModelContext
{
   public class Usuario
   {
      [Key]
      public int Id { get; set; }
      public string Nome { get; set; }
      public string Email { get; set; }
      public string Senha { get; set; }

      //public string Senha
      //{
      //   get { return _password; }
      //   set
      //   {
      //      if (value.Length < 8)
      //      {
      //         MessageBox.Show("Digite no minimo 8 cararctere...");
      //         return;
      //      }
      //      else
      //         _password = value;
      //   }
      //}

      //Contrutor Padrão
      public Usuario(int id, string nome, string email, string senha)
      {
         this.Senha = senha;
         this.Id = id;
         this.Nome = nome;
         this.Email = email;
      }
      public Usuario() { }
   }
}
