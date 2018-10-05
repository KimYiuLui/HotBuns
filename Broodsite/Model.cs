using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Model
{
  public class Broodwinkel : DbContext
  {
    public DbSet<Address> Addresses { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductAmount> ProductsAmount { get; set; }
    public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    public DbSet<Favorite> Favorites { get; set; }

    //this method is run automatically by EF the first time we run the application
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
      //here we define the name of our database
      optionsBuilder.UseNpgsql("User ID=postgres;Password=admin;Host=localhost;Port=5432;Database=Broodsite;Pooling=true;");
    }
  }

  //this is the typed representation of a movie in our project
  public class Address
  {
    public int Id { get; set; }
    public string PostalCode { get; set; }
    public int PhoneNumber { get; set; } //Phone number moet string worden vanwege "0" die wegvalt
    public string Place { get; set; }
    public string Street { get; set; }
    public int StreetNumber { get; set; } //Number in ERD?
    public int AddressID { get; set; }
  }

  public class User
  {
    public int Id { get; set; }
    public string Email { get; set; }
    public int UserID { get; set; }
    public string Password { get; set; }
  }  

  public class Order
  {
    public int Id { get; set; }
    public int OrderID { get; set; }
    public int ProductID { get; set; }
    public float Price { get; set; }
    public int Quantity { get; set; }
    public int TotalPrice { get; set; }
  } 

  public class Product
  {
    public int Id { get; set; }
    //public int ID { get; set; }
    public float Price { get; set; }
    public string Image { get; set; }
    public string Description { get; set; }
    public string Ingredients { get; set; }
  } 

  public class ProductAmount
  {
    public int Id { get; set; }
    //public int ID { get; set; }
    public int Quantity { get; set; }
  }

  public class ShoppingCart
  {
    public int Id { get; set; }
    public int AccountID { get; set; }
    public int ProductID { get; set; }
  }
  
  public class Favorite
  {
    public int Id { get; set; }
    public int ProductID { get; set; }
  }
}