using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Domain
{
    //实现了IBookRepository接口的仓储类，可以具体化调用(调用数据使用)
    public class BookRepository:IBookRepository
    {
        //定义上下文类-数据连接
        private EFDbContext context = new EFDbContext();

        //IQueryable是指查询
        //我们对使用IQueryable作为返回类型提了个疑问：为什么用IQueryable而不用IEnumerable作为返回类型？
        //答案是：使用IQueryable，EF会根据调用者的Linq表达式先生成相应的SQL查询语句，然后到数据库中执行查询，查询出来的数据即是用户想要的数据；
        //而使用IEnumerable，Linq表达式的过滤、排序等操作都是在内存中发生的，即EF会先从数据库中把整个表的数据查询出来放在内存中，然后由调用者使用Linq语句进行过滤、排序等操作
        //我想，对于少量的数据（比如从数据库中读取应用程序相关的系统信息）和不需要对数据进行过滤操作的情况，用IEnumerable比较适合；
        //对于数据量较大需要对数据进行过滤（比如分页查询）的情况，则用IQueryable比较合适。
        public IQueryable<Book> Books//IEnumerable<Book> Books//
        {
            //get { return GetBooks().AsQueryable(); }
            get { return context.Books; }
        }

        private static List<Book> GetBooks()
        {
            //为了演示，这里手工造一些数据，后面会介绍使用EF从数据库中读取。
            List<Book> books = new List<Book>{
            new Book { ID = 1, Title = "ASP.NET MVC 4 编程", Price = 52},
            new Book { ID = 2, Title = "CLR Via C#", Price = 46},
            new Book { ID = 3, Title = "平凡的世界", Price = 37}
        };
            return books;
        }
    }
}
