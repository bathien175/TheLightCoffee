using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.DTO
{
    public class ingredientDTO
    {
        public int Ingredient_ID { get; set; }
        public string Ingredient_Name { get; set; }
        public Image Ingredient_Image { get; set; }
        public double Ingredient_Reserved { get; set; }
        public String Ingredient_Unit { get; set; }
        public String Ingredient_PriceImport { get; set; }
        public String Ingredient_isActive { get; set; }
    }
}
