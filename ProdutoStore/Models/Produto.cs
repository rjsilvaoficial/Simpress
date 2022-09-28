using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProdutoStore.Models
{
    [Table("tblProduto")]
    public class Produto
    {
        [Key]
        [Column("Id")]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Nome não pode ser vazio!")]
        [StringLength(250, ErrorMessage = "Nome não pode exceder 250 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Descrição não pode ser vazio!")]
        [StringLength(250, ErrorMessage = "Descrição não pode exceder 250 caracteres")]
        //[RegularExpression("^[a - záàâãéèêíïóôõöúçñÁÀÂÃÉÈÊÍÏÓÒÖÚÇÑ] +$")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Produto deve ser marcado como ativo!")]
        public bool Ativo { get; set; }
        [Required(ErrorMessage = "Perecível deve ser marcado como ativo!")]

        public bool Perecivel { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}