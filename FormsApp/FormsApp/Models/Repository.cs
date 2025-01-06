namespace FormsApp.Models;

public class Repository
{
    private static readonly List<Product> _products = new();
    private static readonly List<Category> _categories = new();


    static Repository()
    {
        _categories.Add(new Category { CategoryId = 1, CategoryName = "Telefon"});
        _categories.Add(new Category { CategoryId = 2, CategoryName = "Bilgisayar"});

        _products.Add(new Product{ProductId = 1,Name = "Iphone 16", price = 85000, isActive = true,Image = "4.jpg",CategoryId = 1});
        _products.Add(new Product{ProductId = 2,Name = "Iphone 16 pro max", price = 115000, isActive = true,Image = "3.jpg",CategoryId = 1});
        _products.Add(new Product{ProductId = 3,Name = "Macbook Pro", price = 85000, isActive = true,Image = "2.jpeg",CategoryId = 2});
        _products.Add(new Product{ProductId = 4,Name = "Macbook Air", price = 85000, isActive = true,Image = "1.jpg",CategoryId = 2});

    }
    public static List<Product> Products
    {
        get { return _products; }
    }
    public static List<Category> Categories
    {
        get { return _categories; }
    }

    public static void CreateProduct(Product product)
    {
        _products.Add(product);
    }
    
    //hem category hem product verilerine erişim için yapılır
}