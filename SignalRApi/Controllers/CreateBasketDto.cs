namespace SignalRApi.Controllers
{
    public class CreateBasketDto
    {
        public int ProductID { get; internal set; }
        public decimal TotalPrice { get; internal set; }
        public int MenuTableID { get; internal set; }
    }
}