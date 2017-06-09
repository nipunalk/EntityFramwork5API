using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EntityFramwork5API
{
   [Serializable(), ClassInterface(ClassInterfaceType.AutoDual), ComVisible(true)]
   public class DeliveryDAO
    {
       

       //public void setConnection
        
        //public void add()
        //{
        //   String d= ConnectionFactory.getConnection("mysql");
        //    //string d = "metadata=res://*/EPSEntity.csdl|res://*/EPSEntity.ssdl|res://*/EPSEntity.msl;provider=MySql.Data.MySqlClient;provider connection string=';server=127.0.0.1;user id=root;password=root;persistsecurityinfo=True;database=vbadb';";
        //    //create DBContext object
        //    using (var dbCtx = new vbadbEntities(d))
        //   {

        //       //delivery ad = dbCtx.deliveries.Where(x => x.iddeliveryId.Equals(3)).FirstOrDefault<delivery>();
        //       var newStudent = new delivery();

        //       //set student name
        //       newStudent.deliverycol = "Bill";
        //       newStudent.iddeliveryId = 15;
        //       var w = new employee();
        //       w.EmpId = 2;
        //       w.EmpName = "Nipuna";
        //       w.EmpAddress = "address1";


        //        //Add Student object into Students DBset
               

        //        //dbCtx.Entry<delivery>(newStudent).State = System.Data.EntityState.Added;

        //        // call SaveChanges method to save student into database
        //        //dbCtx.SaveChanges();

        //        //  dbCtx.Entry(newStudent).State = System.Data.Entity.EntityState.Added;

        //        // call SaveChanges method to save new Student into database
        //        try
        //        {
        //            dbCtx.deliveries.Add(newStudent);
        //            dbCtx.SaveChanges();
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }
                
        //    }
        //}

        public void addByDel(delivery delivery)
        {

           // string d = "metadata=res://*/EPSEntity.csdl|res://*/EPSEntity.ssdl|res://*/EPSEntity.msl;provider=MySql.Data.MySqlClient;provider connection string=';server=127.0.0.1;user id=root;password=root;persistsecurityinfo=True;database=vbadb';";
            //create DBContext object
            String d = ConnectionFactory.getConnection("mysql");
            using (var dbCtx = new vbadbEntities(d))
            {

                
               
                    dbCtx.deliveries.Add(delivery);
                    dbCtx.SaveChanges();
              

            }
        }

        //public void addByPassConnection(string con)
        //{

        //    string d = con; ///"metadata=res://*/EPSEntity.csdl|res://*/EPSEntity.ssdl|res://*/EPSEntity.msl;provider=MySql.Data.MySqlClient;provider connection string=';server=127.0.0.1;user id=root;password=root;persistsecurityinfo=True;database=vbadb';";
        //    //create DBContext object
        //    using (var dbCtx = new vbadbEntities(d))
        //    {
        //        var newStudent = new delivery();

        //        //set student name
        //        newStudent.deliverycol = "Bill2";
        //        newStudent.iddeliveryId = 16;

               
        //            dbCtx.deliveries.Add(newStudent);
        //            dbCtx.SaveChanges();
               
               

        //    }
        //}
        public delivery getDlivery(delivery delivery)
        {
           // string d = "metadata=res://*/EPSEntity.csdl|res://*/EPSEntity.ssdl|res://*/EPSEntity.msl;provider=MySql.Data.MySqlClient;provider connection string=';server=127.0.0.1;user id=root;password=root;persistsecurityinfo=True;database=vbadb';";
            //create DBContext object
           // string d1 = Environment.GetEnvironmentVariable("EPS_DB", EnvironmentVariableTarget.User);
            String d = ConnectionFactory.getConnection("mysql");
         
            using (var dbCtx = new vbadbEntities(d))
            {

                return dbCtx.deliveries.Include("deliveryparts").Where(x => x.iddeliveryId.Equals(delivery.iddeliveryId)).FirstOrDefault<delivery>();

              


            }
        }

    }
}
