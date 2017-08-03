using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using System.Threading.Tasks;


//异步处理类
namespace BookShop.WebUI.Models
{
    public class RemoteService
    {
        public async Task<string> GetRemoteDataAsync()
        {
            return await Task<string>.Factory.StartNew(() => {
                Thread.Sleep(2000);
                return "Hello from the other side of the world";
            });
        }
    }
}