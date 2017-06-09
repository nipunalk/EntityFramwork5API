using EntityFramwork5API;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DeliveryDAO da = new DeliveryDAO();
            delivery del=new delivery();
           // ConnectionFactory.setConnection("mysql", "127.0.0.1", "vbadb", "root", "root");
            del.iddeliveryId=32;
           delivery x= da.getDlivery(del);
           ICollection<deliverypart> b =x.deliveryparts;
           int a = 2;
          //  var a = new DeliveryDAO();
          //  a.add();
           /** deliverypart delpart = new deliverypart();
            delpart.id = 10;
            delpart.deliverypartName ="fdfdf";

            deliverypart delpart2 = new deliverypart();
            delpart2.id = 10;
            delpart2.deliverypartName = "fdfdf";
            delivery xi = new delivery();
            object obj = new[] { delpart2, delpart };**/
          /**  var strings = ((IEnumerable)obj).Cast<object>()
                                   .Select(x => x == null ? x : x.ToString())
                                   .ToArray();
            string[] mm=strings.Select(x2 => x2.ToString()).ToArray();**/
           // string kk = strings.ToList<string>();
            //double []m=x.LoadComObjectIntoDoubleArray(obj);

          //  deliverypart[] strings = ((IEnumerable)obj).Cast<object>()
            //                       .Select(x => (deliverypart)x)
           //                        .ToArray();
          
        }
    }
}
