using System.ComponentModel;

namespace BMSApi.Models
{
    public class Bill
    {

        [DisplayName("Bill Id")]
        public int billId { get; set; }

        [DisplayName("Bill Date")]
        public string date { get; set; }

        [DisplayName("Customer Name")]
        public string customerName { get; set; }

        [DisplayName("Customer PhoneNumber")]
        public string customerPhone { get; set; }

        [DisplayName("Customer Email")]
        public string customerEmail { get; set; }

        [DisplayName("Total Amount")]
        public float amount { get; set; }
    }
}
