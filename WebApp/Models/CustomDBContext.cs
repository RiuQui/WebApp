using Microsoft.EntityFrameworkCore;

namespace WebApp.Models
{
    public partial class WebSysRGContext
    {
      public WebSysRGContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-LJLDID0\\SQLEXPRESS;Initial Catalog=WebSysRG;Integrated Security=True;Trust Server Certificate=True");
        }

    }
}
