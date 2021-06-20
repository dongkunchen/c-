using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Juicer
    {
        /// <summary>
        /// 榨汁功能
        /// </summary>
        /// <param name="fruit">水果</param>
        /// <returns></returns>
        public string Juicing(string fruit)
        {
            string result = fruit + "汁";
            return result;
        }
    }
}
