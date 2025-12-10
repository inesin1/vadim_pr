using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachaVadim.Models
{
    public class RepairOrder
    {
        public int Id { get; set; }
        public string CarInfo { get; set; }
        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public string ProblemDescription { get; set; }
        public AutoMechanic AssignedMechanic { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TotalCost { get; set; }

        public string AssignedMechanicName
        {
            get { return AssignedMechanic.Name; }
        }
    }

    public enum OrderStatus
    {
        Active,
        Completed,
    }
}
