using StartToReadyLandingPage.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StartToReadyLandingPage.Models
{
    [Table("lead")]
    public class Lead {
        [Required(ErrorMessage = "O nome deve ser informado")]
        [StringLength(50, MinimumLength = 2)]
        [Column("Nome")]
        public string Nome { get; set; }

        [Key]
        [Required(ErrorMessage = "o e-mail deve ser informado")]
        [StringLength(50, MinimumLength = 2)]
        [Column("Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "a profissão deve ser informada")]
        [StringLength(50, MinimumLength = 2)]
        [Column("Profissao")]
        public string Profissao { get; set; }

        [Required(ErrorMessage = "a cidade deve ser informada")]
        [StringLength(50, MinimumLength = 2)]
        [Column("Cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "o estado deve sr informado")]
        [StringLength(2, MinimumLength = 2)]
        [Column("Estado")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "a empresa deve ser informada")]
        [Column("Empresa")]
        public Organizations Empresa { get; set; }

        [Required(ErrorMessage = "deve ser indicado se é ou já foi aluno")]
        [Column("EhAluno")]
        public bool EhAluno { get; set; }
    }
}