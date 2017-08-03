using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace BookShop.Domain
{
    //EF Code First-上下文类
    public class EFDbContext: DbContext
    {
        //使用EF Code First第一步就是创建一个继承自System.Data.Entity.DbContext的类，
        //这个类将为数据库中的每个表定义一个属性，属性的名称代表数据库中的表名。DbSet作为返回类型，
        //它是用于生成CRUD(Create、Read、Update和Delete)操作的装置，映射数据库表的行。
        public DbSet<Book> Books { get; set; }
    }
}
