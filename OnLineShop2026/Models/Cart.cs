namespace OnLineShop2026.Models
{
    public class Cart
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public List<CartItem> CartItems { get; set; }
        public decimal Cost
        {
            get { return CartItems.Sum(x => x.Cost); }
            set { }
        }
        public Cart()
        {
            CartItems = new List<CartItem>();
        }
    }
}
