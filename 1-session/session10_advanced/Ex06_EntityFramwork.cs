using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace session10_Advanced {

    // 1. Item Class
    [Table("Items")]
    class DTA
    {
        [Key]
        public string Code { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }

        public override string ToString()
        {
            return $"Code: {Code}, Name: {Name}, Price: {Price}";
        }
    }

    // 2/ ItemDbContext Class
    class ItemDbContext : DbContext
    {
        public ItemDbContext() : base("name=ItemContext") { }
        public DbSet<DTA> Items { get; set; }




    }

    // 3. Main
    internal class Ex06_EntityFramwork
    {
        ItemDbContext ctx;
        void select()
        {
            using(ctx = new ItemDbContext())
            {
                foreach (var item in ctx.Items)
                {
                    Console.WriteLine(item);
                }
            }
        }

        void insert(string code, string name, int price)
        {
            using (ctx = new ItemDbContext())
            {
                var item = new DTA
                {
                    Code = code,
                    Name = name,
                    Price = price
                };

                ctx.Items.Add(item);
                var rs = ctx.SaveChanges();

                if(rs <=0)
                {
                    Console.WriteLine("Insert Fail!!!");
                }
                else
                {
                    Console.WriteLine("Successfully Insert");
                }
              
            }
        }

        void update(string code, string name, int price)
        {
            using (ctx = new ItemDbContext())
            {
                var newItem = new DTA
                {
                    Code = code
                };

                ctx.Items.Attach(newItem);// Item Register with DbSet

                newItem.Name = name;
                newItem.Price = price;

                var rs = ctx.SaveChanges();

                if (rs <= 0)
                {
                    Console.WriteLine("Update Fail!!!");
                }
                else
                {
                    Console.WriteLine("Successfully Update");
                }

            }
        }

        void delete (string code)
        {
            using (ctx = new ItemDbContext())
            {
                var item = new DTA
                {
                    Code = code
                };

                ctx.Items.Attach(item);// Item Register with DbSet

                ctx.Items.Remove(item);

                var rs = ctx.SaveChanges();

                if (rs <= 0)
                {
                    Console.WriteLine("Delete Fail!!!");
                }
                else
                {
                    Console.WriteLine("Delete Update");
                }

            }
        }

      
        static void Main(string[] args)
        {
            var ex06 = new Ex06_EntityFramwork();
            //ex06.insert("f-1", "hahhaha", 1000);
            //ex06.insert("f-2", "hahhaha", 1000);
            //ex06.insert("f-3", "hahhaha", 1000);

            ex06.update("f-1", "lalalal", 2000);
            ex06.delete("f-1");
            ex06.select();
            
        }
    }

}
