
namespace MakePlus.Domain.Entities
{
    public class ProductCustumer
    {
        public int ID_Sale { get; set; }
        public int sold_amount { get; set; }
        public string payment_method { get; set; }
        public DateTime sold_Date { get; set; }
        public int ID_Product { get; set; }
        public int ID_Custumer { get; set; }
    }
}
