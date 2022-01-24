using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using System;

namespace ModeloDB
{
    public class Repositorio : DbContext
    {
       public DbSet<Address> addresses { get; set; }
       public DbSet<Customer> customers { get; set; }
       public DbSet<Payment> payments { get; set; }


        //Configuracion de la conexion
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DESKTOP-975JAJB; Initial Catalog= Prueba1; trusted_connection=true;");
        }

        //Configurar el modelo de objetos
        protected override void OnModelCreating(ModelBuilder model)
        {
            //Relacion de de uno a muchos
            //una direccion tiene varios customers
            model.Entity<Customer>()
                .HasOne(customer => customer.Address)
                .WithMany(address=> address.Customer)
                .HasForeignKey(customer => customer.addressId);

            //un customer tiene varios payments
            model.Entity<Payment>()
                .HasOne(payment => payment.Customer)
                .WithMany(customer => customer.Payment)
                .HasForeignKey(payment => payment.customerId);


        }



    }


    }
