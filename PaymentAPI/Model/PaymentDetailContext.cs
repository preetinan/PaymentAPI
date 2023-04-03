using Microsoft.EntityFrameworkCore;
using System.Data;

namespace PaymentAPI.Model
{
    public class PaymentDetailContext : DbContext
    {
        public PaymentDetailContext (DbContextOptions<PaymentDetailContext> options) : base(options)
        { 
        }

        public DbSet<PaymentDetail> PaymentDetails { get; set; }

    }
}
