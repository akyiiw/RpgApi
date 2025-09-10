using System;
using System.Linq;
using System.Threading.Tasks;
using RPGAPI.Models.Enuns;


namespace RPGAPI.Models
{
    public class Personagem
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int PontosVida { get; set; }
        public int Forca { get; set; }
        public int Defesa { get; set; }
        public int Inteligencia { get; set; }

        public ClasseEnum Classe { get; set; }
    }
    
}