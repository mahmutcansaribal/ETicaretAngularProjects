using ETicaretAPI.Domain.Entities.Common;

namespace ETicaretAPI.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }

        // Order 1-n İlişki Kuruyoruz.
        public ICollection<Order> Orders { get; set; }
    }
}
