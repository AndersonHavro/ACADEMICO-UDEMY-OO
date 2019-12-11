using Secao9Enumerações01.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Secao9Enumerações01
{
    class Order
    {
        public int ID { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
    }
}
