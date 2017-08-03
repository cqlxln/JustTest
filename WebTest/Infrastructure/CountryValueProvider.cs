using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTest.Infrastructure
{
    public class CountryValueProvider//:IValueProvider
    {
        public bool ContainsPrefix(string prefix)
        {
            return prefix.ToLower().IndexOf("country") > -1;
        }

        //public ValueProviderResult GetVaule(string key)
        //{
        //    if (ContainsPrefix(key))
        //        return new ValueProviderResult("China", "China", CultureInfo.InvariantCulture);
        //    else
        //        return null;
        //}
    }
}