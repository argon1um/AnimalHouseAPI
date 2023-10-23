using AnimalHouseRestAPI.Models;

namespace AnimalHouseRestAPI.ModelsDTO
{
    public class OrderDTO
    {
        public int OrderNoteId { get; set; }
        public int OrderId { get; set; }
        public int ClientId { get; set; }
        public int RoomId { get; set; }
        public int WorkerId { get; set; }
        public int AnimalId { get; set; }
        public DateOnly IssueDate { get; set; }
        public DateOnly AdmissionDate { get; set; }
        public int OrderStatusId { get; set; }

        public static Order ConvertToOrder(OrderDTO order)
        {
            Order order1 = new Order();
            order1.OrderNoteid = order.OrderNoteId;
            order1.OrderId = order.OrderId;
            order1.ClientId = order.ClientId;
            order1.RoomId = order.RoomId;
            order1.WorkerId = order.WorkerId;
            order1.IssueDate = order.IssueDate;
            order1.AnimalId = order.AnimalId;
            order1.AdmissionDate = order.AdmissionDate;
            order1.OrderStatusid = order.OrderStatusId;
            return order1;
            
        }
    }

}
