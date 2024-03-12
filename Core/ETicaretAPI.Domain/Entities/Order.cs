using ETicaretAPI.Domain.Entities.Common;

namespace ETicaretAPI.Domain.Entities
{
    public class Order : BaseEntity
    {
        public int CustomerId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        //N-N PRODUCT İLİŞKİSİ
        public ICollection<Product> Products { get; set; }
        // 1-n Customer
        public Customer Customer { get; set; }  

    }
}
