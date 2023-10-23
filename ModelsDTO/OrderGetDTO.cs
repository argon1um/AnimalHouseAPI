using AnimalHouseRestAPI.Models;
using AnimalHouseRestAPI.ModelsDTO;
using System.Collections.Generic;

namespace AHRestAPI.ModelsDTO
{
    public class OrderGetDTO
    {
        public int OrderNoteId { get; set; }
        public int OrderId { get; set; }
        public int ClientId { get; set; }
        public int RoomId { get; set; }
        public int WorkerId { get; set; }
        public DateOnly IssueDate { get; set; }
        public DateOnly AdmissionDate { get; set; }
        public int OrderStatusId { get; set; }

        public static Order ConvertGetToOrder(OrderDTO order)
        {
            Order order1 = new Order();
            order1.OrderNoteid = order.OrderNoteId;
            order1.OrderId = order.OrderId;
            order1.ClientId = order.ClientId;
            order1.RoomId = order.RoomId;
            order1.WorkerId = order.WorkerId;
            order1.IssueDate = order.IssueDate;
            order1.AdmissionDate = order.AdmissionDate;
            order1.OrderStatusid = order.OrderStatusId;
            return order1;

        }

        public static OrderGetDTO ConvertToGet(Order order)
        {
            OrderGetDTO order1 = new OrderGetDTO();
            order1.OrderNoteId = order.OrderNoteid;
            order1.OrderId = order.OrderId;
            order1.ClientId = (int)order.ClientId;
            order1.RoomId = (int)order.RoomId;
            order1.WorkerId = (int)order.WorkerId;
            order1.IssueDate = (DateOnly)order.IssueDate;
            order1.AdmissionDate = (DateOnly)order.AdmissionDate;
            order1.OrderStatusId = (int)order.OrderStatusid;
            return order1;
        }

        public static List<OrderGetDTO> ConvertToGet(List<Order> orders)
        {
            List<OrderGetDTO> order1 = new List<OrderGetDTO>();
            foreach (Order order in orders)
            {
                order1.Add(new OrderGetDTO
                {
                    OrderNoteId = order.OrderNoteid,
                    OrderId = order.OrderId,
                    ClientId = (int)order.ClientId,
                    OrderStatusId = (int)order.OrderStatusid,
                    AdmissionDate = (DateOnly)order.AdmissionDate,
                    IssueDate = (DateOnly)order.IssueDate,
                    RoomId = (int)order.RoomId,
                    WorkerId = (int)order.WorkerId
                });
            }
            return order1;
        }
    }
}
