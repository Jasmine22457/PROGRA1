using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEntity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (BarDbEntities db= new BarDbEntities())
            {
                Producto oproducto=new Producto();
                Console.WriteLine("Nombre");
                oproducto.nomProd=Console.ReadLine();
                Console.WriteLine("Descripcion");
                oproducto.descripcion = Console.ReadLine(); ;
                Console.WriteLine("Precio");
                oproducto.precio = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine("Cantidad"); 
                oproducto.cantidad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Estado");
                oproducto.estado = Convert.ToInt32(Console.ReadLine()); 


                oproducto.nomProd = "trenzuda";
                oproducto.descripcion = "Medio litro";
                oproducto.precio = 20;
                oproducto.cantidad = 50;
                oproducto.estado = 1;
                

                db.Producto.Add(oproducto);
                db.SaveChanges();

                /*


                //Actalizar/
                Producto oproducto = db.Producto.Find(1);
                oproducto.nomProd = "chamacoss";
                db.Entry(oproducto).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                //borrar//
                Producto oproducto = db.Producto.Find();
                db.Producto.Remove(oproducto);
                db.SaveChanges();*/

                var list = db.Producto;
                foreach(var oproductos in list)
                {
                    Console.WriteLine(oproductos.idProducto);
                }
                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.Read();
            }  
           
        }
    }
}
