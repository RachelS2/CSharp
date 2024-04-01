using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula123enum.Entities.Enums
{
    enum OrderStatus : int //especifica que cada valor do OrderStatus é um número inteiro
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
