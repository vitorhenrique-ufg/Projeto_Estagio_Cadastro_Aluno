using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using EM.Domain;
using AcoesUsuario.cs;

namespace EM.WindowsForms
{
    public partial class Form_Cadastro : Form
    {
        private AcoesUsuario<Aluno> acao = new AcoesUsuario<Aluno>();
        private BindingSource bindingListaAlunos = new BindingSource();
        public Form_Cadastro()
        {            
            InitializeComponent();            
            cb_Sexo.DataSource = Enum.GetValues(typeof(EnumeradorSexo));            
            bindingListaAlunos.DataSource = acao.AlunosCadastradosNoSistema();
            dgv_AlunosCadastrados.DataSource = bindingListaAlunos;           

            bindingListaAlunos.ResetBindings(false);
        }
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            Aluno aluno;

            if (tb_Matricula.Text == "" || tb_Nome.Text == "" || tb_DataNascimento.Text == "")
            {
                MessageBox.Show("OS CAMPOS MATRICULA, NOME E DATA DE NASCIMENTO PRECISAM ESTAR PREENCHIDOS");
                tb_Matricula.Focus();
                return;
            }
            try
            {
                aluno = new Aluno(Convert.ToInt32(tb_Matricula.Text), tb_Nome.Text, tb_Cpf.Text, tb_DataNascimento.Text, cb_Sexo.Text);
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
                return;
            }            
            try
            {
                if (btn_adicionar.Text == "Adicionar")
                    acao.Adicionar(aluno);
                if (btn_adicionar.Text == "Modificar")
                    acao.Atualizar(aluno);
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
                return;
            }

            if (btn_adicionar.Text == "Modificar")
            {
                MessageBox.Show("Aluno modificado com Sucesso");
                btn_limpar_Click(sender, e);
                return;
            }                
            if(btn_adicionar.Text == "Adicionar") 
            {
                MessageBox.Show("Aluno Cadastrado com sucesso!");
                btn_limpar_Click(sender,e);                
            }              
            bindingListaAlunos.DataSource = acao.AlunosCadastradosNoSistema();
            dgv_AlunosCadastrados.DataSource = bindingListaAlunos;
            dgv_AlunosCadastrados.ClearSelection();
        }   
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dgv_AlunosCadastrados.SelectedRows.Count;
            if (linhaSelecionada > 0)
            {
                if (MessageBox.Show("Deseja Realmente excluir os dados do Aluno Selecionado? Todos os dados serao perdidos", "EXCLUIR", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        acao.Remover((Aluno)bindingListaAlunos.Current);

                        MessageBox.Show("Dados Excluidos com Sucesso");

                        btn_limpar_Click(sender, e);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    bindingListaAlunos.DataSource = acao.AlunosCadastradosNoSistema();
                    dgv_AlunosCadastrados.ClearSelection();
                    tb_Matricula.Focus();
                }
            }
            else
            {
                MessageBox.Show("Selecione um Aluno para Excluir");
            }
        }
        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            IEnumerable<Aluno> alunosEncontradosAtravesDaPesquisa = null;
            if (tb_pesquisar.Text == "")
            {
                MessageBox.Show("Digite uma Matricula ou um Nome para realizar a pesquisa");
                return;
            }
            try
            {
                alunosEncontradosAtravesDaPesquisa = acao.PesquisarMatriculaOuParteDoNome(tb_pesquisar.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }           

            if (!alunosEncontradosAtravesDaPesquisa.Any())
                MessageBox.Show("NAO FORAM ENCOTRADOS DADOS PARA A PESQUISA SOLICITADA");
            else
            {
                bindingListaAlunos.DataSource = alunosEncontradosAtravesDaPesquisa;
                dgv_AlunosCadastrados.ClearSelection();
            }                
        }
        private void btn_editar_Click(object sender, EventArgs e)
        {            
            if (btn_editar.Text == "Novo")
            {                
                btn_editar.Text = "Editar";
                btn_limpar.Text = "Limpar";
                btn_adicionar.Text = "Adicionar";

                lb_CadastroDeAlunos.Text = "CADASTRO DE ALUNOS";
                lb_NovoAluno.Text = "NOVO ALUNO";

                tb_Matricula.Text = "";
                tb_Nome.Text = "";
                tb_Cpf.Text = "";
                tb_DataNascimento.Text = "";
                cb_Sexo.SelectedItem = "";
                tb_pesquisar.Text = "";
                tb_Matricula.Enabled = true;
                tb_Matricula.Focus();
                return;
            }
            if (btn_editar.Text == "Editar")
            {
                int linhaSelecionada = dgv_AlunosCadastrados.SelectedRows.Count;
                Aluno aluno = (Aluno)bindingListaAlunos.Current;
                string cpf = aluno.CPF.Replace(".", "").Replace("-", "");

                if (linhaSelecionada <= 0)
                    MessageBox.Show("SELECIONE UM ALUNO PARA EDICAO");
                else
                {
                    tb_Matricula.Text = aluno.Matricula.ToString();
                    tb_Nome.Text = aluno.Nome;
                    cb_Sexo.SelectedItem = aluno.Sexo;
                    tb_DataNascimento.Text = aluno.Nascimento.ToString();
                    tb_Cpf.Text = cpf;

                    tb_Matricula.Enabled = false;
                    btn_editar.Text = "Novo";
                    btn_limpar.Text = "Cancelar";
                    btn_adicionar.Text = "Modificar";

                    lb_NovoAluno.Text = "EDITAR ALUNO";
                    lb_CadastroDeAlunos.Text = "EDIÇÕES DE ALUNOS";
                    return;
                }               
            }
        }
        private void tb_Matricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void tb_Cpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void dgv_AlunosCadastrados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btn_editar.Text == "Novo")
            {                
                Aluno aluno = (Aluno)bindingListaAlunos.Current;
                string cpf = aluno.CPF.Replace(".", "").Replace("-", "");

                tb_Matricula.Text = aluno.Matricula.ToString();
                tb_Nome.Text = aluno.Nome;
                tb_Cpf.Text = cpf;
                tb_DataNascimento.Text = aluno.Nascimento.ToString();
                cb_Sexo.SelectedItem = aluno.Sexo;
            }
        }
        private void Form_Cadastro_Load(object sender, EventArgs e)
        {
            if (dgv_AlunosCadastrados.SelectedRows.Count > 0)
                dgv_AlunosCadastrados.ClearSelection();
            tb_Matricula.Select();
        }
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            if(btn_limpar.Text == "Limpar")
            {
                tb_Matricula.Text = "";
                tb_Nome.Text = "";
                tb_DataNascimento.Text = "";
                tb_Cpf.Text = "";
                tb_pesquisar.Text = "";
                tb_Matricula.Focus();
            }
            if(btn_limpar.Text == "Cancelar")
            {
                btn_editar_Click(sender,e);
            }

            bindingListaAlunos.DataSource = acao.AlunosCadastradosNoSistema();
            dgv_AlunosCadastrados.ClearSelection();
        }
        private void btn_testePDF_Click(object sender, EventArgs e)
        {
            string nomeArquivo = @"C:\Users\DEV-ESTAGIO-03\source\repos\2° - PROJETO\CADASTRO DE ALUNO\RelatorioDosAlunosCadastrados.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.B4);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            var imagem = iTextSharp.text.Image.GetInstance(@"C:\Users\DEV-ESTAGIO-03\source\repos\2° - PROJETO\CADASTRO DE ALUNO\logopdf.png");
            imagem.Alignment = Element.ALIGN_CENTER;

            string dados = "";
            Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 16, (int)System.Drawing.FontStyle.Bold));            
            paragrafo1.Alignment = Element.ALIGN_CENTER;
            paragrafo1.Add("ALUNOS CADASTRADOS\r\n\r\n");

            PdfPTable tabela = new PdfPTable(5);
            
            tabela.DefaultCell.FixedHeight = 30;
            float[] teste = new float[] {165,265,200,175,130};
            tabela.SetWidths(teste);
            tabela.AddCell("Matricula");
            tabela.AddCell("Nome");
            tabela.AddCell("CPF");
            tabela.AddCell("Data Nascimento");
            tabela.AddCell("Sexo");

            var listaDeAlunos = acao.AlunosCadastradosNoSistema();            
            foreach (var aluno in listaDeAlunos)
            {
                var dataNascimento = aluno.Nascimento.ToString("d", CultureInfo.CreateSpecificCulture("pt-BR"));

                tabela.AddCell(aluno.Matricula.ToString());   
                tabela.AddCell(aluno.Nome);   
                tabela.AddCell(aluno.CPF);   
                tabela.AddCell(dataNascimento);   
                tabela.AddCell(aluno.Sexo.ToString());   
            }
            doc.Open();
            doc.Add(imagem);
            doc.Add(paragrafo1);
            doc.Add(tabela);
            doc.Close();

            DialogResult resp = MessageBox.Show("Deseja abrir o Relatorio Gerado?", "RELATORIO ALUNOS CADASTRADOS", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == resp)
                System.Diagnostics.Process.Start(@"C:\Users\DEV-ESTAGIO-03\source\repos\2° - PROJETO\CADASTRO DE ALUNO\RelatorioDosAlunosCadastrados.pdf");
        }
        private void tb_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Space) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }        
        private void tb_pesquisar_KeyUp(object sender, KeyEventArgs e)
        {
          /*bindingListaAlunos.DataSource = acao.PesquisarMatriculaOuParteDoNome(tb_pesquisar.Text);
            dgv_AlunosCadastrados.DataSource = bindingListaAlunos;
            dgv_AlunosCadastrados.ClearSelection();*/
        }
        private void tb_pesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && !char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Space) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
