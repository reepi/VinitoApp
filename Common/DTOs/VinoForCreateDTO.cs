using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOs
{
    public class VinoForCreateDTO
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Variety { get; set; } = string.Empty;
        public int Year {
            get => Year;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Poneme un año válido, gato");
            }
        }
        public string Region { get; set; } = string.Empty;

        private int _stock;
        public int Stock
        {
            get => _stock;
            set
            {
                if (value < 0) throw new ArgumentException("El stock no puede ser negativo.");
                _stock = value;
            }
        }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
