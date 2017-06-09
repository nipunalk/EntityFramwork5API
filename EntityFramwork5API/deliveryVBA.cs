using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramwork5API
{
    [Serializable(), ClassInterface(ClassInterfaceType.AutoDual), ComVisible(true)]
    public partial class delivery
    {
        
        

        public void setDeliveryDateNew(System.DateTime value){
            if (value == null || "".Equals(value))
                    {
                        this.deliveryDate = null;
                    }
                    else {
                        this.deliveryDate = value;
                    }
        }
        public System.DateTime getDeliveryDateNew(){
             if (this.deliveryDate != null)
                    {
                        return (DateTime)this.deliveryDate;
                    }
                    
                        return DateTime.MinValue;
        }
       

        
        public void setDeliverypartsObject(Object values)
        {
          //  deliverypart[] a = ((IEnumerable)values).Cast<object>()
           //                   .Select(x => x == null ? x : (deliverypart)x)
           //                   .ToArray();
           deliverypart[] delivParts= ((IEnumerable)values).Cast<object>()
                                   .Select(x => (deliverypart)x)
                                   .ToArray();
            
            foreach(deliverypart deliveryparts22 in delivParts){
                this.deliveryparts.Add(deliveryparts22);
            }
            //for(
            //var a=new Microsoft.VisualBasic.Collection
        }
       
         public deliverypart[] getDetDeliverypartsObject()
        {
          return this.deliveryparts.ToArray();
        }

         public string[] getDetDeliverypartsString()
         {
             string[] a = new string[2];
             a[0]="ss";
             a[1]="jj";
             return a;
         }
    } 
   

}
