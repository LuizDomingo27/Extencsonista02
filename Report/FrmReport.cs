using System.Data;

using ControleEstoqueEscolar.Controler;
using ControleEstoqueEscolar.DBContext;
using ControleEstoqueEscolar.ModelContext;

namespace ControleEstoqueEscolar.Report
{
   public partial class FrmReport : Form
   {
      public FrmReport()
      {
         InitializeComponent();
         AdcionarDadosNaCombo();
      }

      private void Btn_Print_Click(object sender, EventArgs e)
      {
         DataSetRelatorio.DataSetProdutoDataTable dt = new();
         DataTable data = new();
         data.Columns.Add("ID", typeof(string));
         data.Columns.Add("Nome", typeof(string));
         data.Columns.Add("Categoria", typeof(string));
         data.Columns.Add("Quantidade", typeof(string));
         data.Columns.Add("QuantidadeMinima", typeof(string));

         List<Produto> list = [];
         Report.SelecionarOpcaoRelatorio(list, Cbo_Relatorio, Rb_Maior100Relatorio, Rb_menos100Relatorio, Rb_Menos50Relatorio, Rb_TodosRelatorio, Rb_CategoriaRalatorio);

         var dados = from d in list.AsEnumerable() select d;

         foreach (var v in dados)
         {
            data.Rows.Add(v.Id, v.Nome, v.Categoria, v.Quantidade, v.QuantidadeMinima);
         }

         Report.MesclarDataTable(data, dt);
         Funcoes.Exportar("teste", "Relatorio", ["DataSeteRelatorioProduto"], [dt]);
      }

      private void AdcionarDadosNaCombo()
      {
         using ConexaoContexto conexao = new();
         var result = conexao.Produtos.Where(p => p.Id > 0).Select(p => new { p.Categoria })
            .Distinct()
            .ToList();
         result.ForEach(p => Cbo_Relatorio.Items.Add(p.Categoria));
      }
   }
}
