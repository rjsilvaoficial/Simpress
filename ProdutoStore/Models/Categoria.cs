using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProdutoStore.Models
{
    [Table("tblCategoriaProduto")]
    public class Categoria
    {        
        public Categoria() { }

        public Categoria(string nome, string descricao)
        {
            Ativo = true;
        }
        [Key]
        [Column("Id")]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "Nome não pode ser vazio!")]
        [StringLength(250, ErrorMessage = "Nome não pode exceder 250 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Descrição não pode ser vazio!")]
        [StringLength(250, ErrorMessage = "Descrição não pode exceder 250 caracteres")]
        //[RegularExpression("^[a - záàâãéèêíïóôõöúçñÁÀÂÃÉÈÊÍÏÓÒÖÚÇÑ] +$")]
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public ICollection<Produto> Produtos { get; set; }  
    }
}