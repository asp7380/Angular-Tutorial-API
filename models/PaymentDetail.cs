using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentsAPI.models
{
    public class PaymentDetail
    {
        [Key]
        public int PaymentDetailId { get; set; }

        [Column(TypeName = "Nvarchar(100)")]
        public string CardOwnerName { get; set; }

        [Column(TypeName = "Nvarchar(16)")]
        public string CardNumber { get; set; }

        [Column(TypeName = "Nvarchar(5)")]
        public string ExpirationDate { get; set; }

        [Column(TypeName = "Nvarchar(3)")]
        public string SecurityCode { get; set; }


    }
}
