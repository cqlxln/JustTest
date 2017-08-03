using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Domain
{
    //调用BOOK数据模型的接口类
    public  interface IBookRepository
    {
        IQueryable<Book> Books { get; }
        //IEnumerable<Book> Books { get; }
    }
}
