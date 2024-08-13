
using MakePlus.Core;

namespace MakePlus.Entities
{
    public class Sellers : BaseEntity
    {
        public int ID_Seller { get; set; }
        public string name_Seller { get; set; }
        public string email {  get; set; }
        public string? business {  get; set; }
    }
}
