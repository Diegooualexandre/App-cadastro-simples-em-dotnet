using System

namespace DIO.Series
{
    public class series : EntidadeBase /* Lê, classe series herda ":" de EntidadeBase*/
    {
        //Atributos
        
        private Genero Genero {get;set;} /* não sei porque que esse private tá saindo com a cor diferente...já tentei de tudo e fica assim sempre*/
        private string Titulo {get; set;}
        private string Descricao {get;set;}
        private int Ano {get;set;}
        private bool Excluido {get;set;}

        //Métodos
        public Serie(int id, Genero genero, string titulo, string descricao, int ano) 
        {
                this.Id = id;
                this.Genero = genero;
                this.Titulo = titulo;
                this.Descricao = descricao;
                this.Ano = ano;
                this.Excluido = false;
               
        }

        public override string toString()
        {
            string retorno = " ";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Lançamento: " + this.Ano + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}