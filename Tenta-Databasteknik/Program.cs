using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta_Databasteknik
{
    class Program
    {

        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NORTHWND;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        static void Main(string[] args)
        {
            // FRÅGA ETT
            private static void ProductsByCategory(string CategoryName)
        {
            using (NorthwindContext db = new NorthwindContext())

            {
                var prodByCategory = from p in db.Products AND c in db.Categories
                                     where
                                     p.CategoryID = Categories.CategoryID
                                     select p;
                
                foreach (var product in db.Products)
                {
                    string queryString =
                    "SELECT ProductName, UnitPrice, UnitInStock, Categories.CateogoryName from dbo.Products, dbo.Categories ";

                    Console.WriteLine(queryString);
                    Console.ReadLine();
                    Console.WriteLine("Confections");
                    Console.ReadLine();
                }
            }

         
        }
        //FRÅGA 2
        private static string SalesByTerritory()
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                var FROM [Employees]
                        ,[EmployeesTerritory]
                        ,[Orders]
                        ,[Order Details]
                        ,[Territories] in db.NORTHWND
                    GROUP BY 

                   
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            //SELECT TOP (5) EmployeesTerritory, Orders, [Order Details], Employees, Territories,
               
            //FROM Employees INNER JOIN 
            //EmployeesTerritories ON Orders = [Order Details]

            //GROUP BY Territories.TerritoryDescription
            //ORDER BY [Order Details].UnitPrice
            //}
        }

            //FRÅGA TRE

            private static void EmployeesPerRegion()
            {

            using (NorthwindContext db = new NorthwindContext())
            {
                try
                {

                    foreach (var Region in db.Employees)
                    {
                        SELECT 
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //FRÅGA 4
           private static void  OrdersPerEmployee()
            {
            using (NorthWindContext cn = new NorthWindContext())
            {
            var orderPerEmployee = from emp in cn.Employees
                                   where emp.EmployeeID = Orders.EmployeeID
                                   select emp;
            foreach(var employee in orderPerEmployee)
                {
                    Console.WriteLine(employee.FirstName + SUM(orderPerEmployee);
                
            }
            }
        }

            // FRÅGA 5
            private static void CustomersWithNamesLongerThan25Characters()
        {
            using (NorthwindContext cn = new NorthwindContext())
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "Select Customers.ComapanyName WHERE Customers.CompanyName => nvarchar(40)";
                cn.Open();
                cmd.ExecuteNonQuery();
            }

    


        }

        }

    
    
    

