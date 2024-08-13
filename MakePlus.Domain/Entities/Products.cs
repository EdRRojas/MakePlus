

using MakePlus.Core;

namespace MakePlus.Domain.Entities
{
    public class Products : BaseEntity
    {
        public int ID_Product { get; set; }
        public string name_Product { get; set; }
        public string description {  get; set; }
        public string category {  get; set; }
        public decimal price { get; set; }
        public decimal discount { get; set; } 
        public int ID_Seller { get; set; }
    }
}
