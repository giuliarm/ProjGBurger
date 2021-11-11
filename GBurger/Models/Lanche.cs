using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GBurger.Models
{
    public class Lanche
    {
        [StringLength(100)]
        public int LancheId { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(255)]
        public string DescricaoCurta { get; set; }
        [StringLength(255)]
        public string DescricaoDetalhada { get; set; }
        public double Preco { get; set; }
        [StringLength(255)]
        public string ImagemUrl { get; set; }
        [StringLength(255)]
        public string ImagemThumbnailUrl { get; set; }
        public bool LancheFavorito { get; set; }
        public bool EmEstoque { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
