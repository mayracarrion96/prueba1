using System;
using Modelo.Entidades;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //ADDRESS
            Address Mayra = new Address()
            {
                address = "Conocoto",
                address2 = "Frente a la Iglesia",
                district = "Quito",
                cityId = 1,
                postalCode = "180605",
                phone = "2070065",
                lastUpdate= new DateTime(2021, 01, 01)
            };
            Address Sonia = new Address()
            {
                address = "La Salle",
                address2 = "Frente al colegio",
                district = "Quito",
                cityId = 1,
                postalCode = "180604",
                phone = "2349722",
                lastUpdate = new DateTime(2022, 01, 01)
            };
            Address Nicolas = new Address()
            {
                address = "Sangolqui",
                address2 = "Frente al Tia",
                district = "Rumiñahui",
                cityId = 2,
                postalCode = "145673",
                phone = "0999171587",
                lastUpdate = new DateTime(2022, 01, 24)
            };
            Address Jhon = new Address()
            {
                address = "Sur",
                address2 = "La Argelia",
                district = "Quito",
                cityId = 1,
                postalCode = "180610",
                phone = "2012345",
                lastUpdate = new DateTime(2022, 01, 03)
            };
            Address Bayron = new Address()
            {
                address = "Quito",
                address2 = "Carcelen",
                district = "Quito",
                cityId = 1,
                postalCode = "180875",
                phone = "2012356",
                lastUpdate = new DateTime(2021, 12, 12)
            };
            //CUSTOMER
            Customer MC = new Customer()
            {
                firstName = "Mayra",
                lastName = "Carrion",
                email = "mc@yahoo.com",
                activebool = true,
                createDate = new DateTime(2021, 12, 01),
                lastUpdate = new DateTime(2022, 01, 01),
                active = true,
                storeId=1,
                addressId=1,
                Address=Mayra
            };
            Customer SC = new Customer()
            {
                firstName = "Sonia",
                lastName = "Carcelen",
                email = "sc@yahoo.com",
                activebool = true,
                createDate = new DateTime(2021, 11, 01),
                lastUpdate = new DateTime(2022, 01, 02),
                active = true,
                storeId = 2,
                addressId = 2,
                Address=Sonia
                
            };
            Customer NC = new Customer()
            {
                firstName = "Nicolas",
                lastName = "Carrion",
                email = "nc@yahoo.com",
                activebool = true,
                createDate = new DateTime(2021, 10, 01),
                lastUpdate = new DateTime(2022, 01, 12),
                active = true,
                storeId = 1,
                addressId = 3,
                Address= Nicolas
            };
            Customer JP = new Customer()
            {
                firstName = "Jhon",
                lastName = "Pinto",
                email = "jp@yahoo.com",
                activebool = true,
                createDate = new DateTime(2021, 12, 24),
                lastUpdate = new DateTime(2022, 01, 24),
                active =false,
                storeId = 3,
                addressId = 4,
                Address= Jhon
            };
            Customer BC = new Customer()
            {
                firstName = "Bayron",
                lastName = "Carrion",
                email = "bc@yahoo.com",
                activebool = true,
                createDate = new DateTime(2021, 09, 01),
                lastUpdate = new DateTime(2022, 01, 05),
                active = true,
                storeId = 2,
                addressId = 5,
                Address= Bayron
            };
            Customer SaC = new Customer()
            {
                firstName = "Samantha",
                lastName = "Carrion",
                email = "samy@yahoo.com",
                activebool = true,
                createDate = new DateTime(2022, 01, 01),
                lastUpdate = new DateTime(2022, 01, 02),
                active = true,
                storeId = 2,
                addressId = 1,
                Address= Mayra
            };
            //PAYMENT
            Payment uno = new Payment()
            {
                amount = 12.00f,
                paymentDate = new DateTime(2022, 01, 01),
                stafftId = 1,
                rentalId = 1,
                customerId =1,
                Customer=MC
            };
            Payment dos = new Payment()
            {
                amount = 10.00f,
                paymentDate = new DateTime(2022, 01, 02),
                stafftId = 1,
                rentalId = 1,
                customerId = 1,
                Customer = MC
            };
            Payment tres = new Payment()
            {
                amount = 5.00f,
                paymentDate = new DateTime(2022, 01, 03),
                stafftId = 1,
                rentalId = 2,
                customerId = 1,
                Customer = MC
            };
            Payment cuatro = new Payment()
            {
                amount = 3.00f,
                paymentDate = new DateTime(2022, 01, 04),
                stafftId = 1,
                rentalId = 2,
                customerId = 2,
                Customer = SC
            };
            Payment cinco = new Payment()
            {
                amount = 45.00f,
                paymentDate = new DateTime(2022, 01, 05),
                stafftId = 1,
                rentalId = 2,
                customerId = 2,
                Customer = SC
            };
            Payment seis = new Payment()
            {
                amount = 65.00f,
                paymentDate = new DateTime(2022, 01, 06),
                stafftId = 1,
                rentalId = 2,
                customerId = 3,
                Customer = NC
            };
            Payment siete = new Payment()
            {
                amount = 165.00f,
                paymentDate = new DateTime(2022, 01, 07),
                stafftId = 1,
                rentalId = 2,
                customerId = 4,
                Customer = JP
            };
            Payment ocho = new Payment()
            {
                amount = 15.00f,
                paymentDate = new DateTime(2022, 01, 08),
                stafftId = 1,
                rentalId = 2,
                customerId = 4,
                Customer = JP
            };
            Payment nueve = new Payment()
            {
                amount = 100.00f,
                paymentDate = new DateTime(2022, 01, 09),
                stafftId = 1,
                rentalId = 2,
                customerId = 5,
                Customer = BC
            };
            Payment diez = new Payment()
            {
                amount = 195.00f,
                paymentDate = new DateTime(2022, 01, 10),
                stafftId = 1,
                rentalId = 2,
                customerId = 6,
                Customer = SaC
            };
        }
    }
}
