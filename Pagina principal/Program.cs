
using Microsoft.EntityFrameworkCore; 
using Pagina_principal;
using System;
using System.Windows.Forms;

namespace HotDogsApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlite("Data Source=hotdogsapp.db"); 

            
            using (var context = new ApplicationDbContext(optionsBuilder.Options))
            {
               
                context.Database.EnsureCreated(); 

            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); 
        }
    }
}