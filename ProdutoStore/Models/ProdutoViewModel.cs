using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProdutoStore.Models
{
    public class ProdutoViewModel 
    {
        [Required(ErrorMessage = "Nome não pode ser vazio!")]
        [StringLength(250, ErrorMessage = "Nome não pode exceder 250 caracteres")]
        [RegularExpression("^[a - záàâãéèêíïóôõöúçñÁÀÂÃÉÈÊÍÏÓÒÖÚÇÑ] +$", ErrorMessage = "Nome deve conter apenas texto!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Descrição não pode ser vazio!")]
        [StringLength(250, ErrorMessage = "Descrição não pode exceder 250 caracteres")]
        [RegularExpression("^[a - záàâãéèêíïóôõöúçñÁÀÂÃÉÈÊÍÏÓÒÖÚÇÑ] +$", ErrorMessage = "Descrição deve conter apenas texto!")]
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public bool Perecivel { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public List<Produto> ListaProdutos { get; set; }
    }
}