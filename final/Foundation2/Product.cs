public class Product {
    private string name;
    private int productId;
    private double price;
    private int quantity;
    
    public Product(string name, int productId, double price, int quantity) {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }
    
    public double GetPrice() {
        return price * quantity;
    }
    
    public string GetName() {
        return name;
    }
    
    public int GetProductId() {
        return productId;
    }
    
    public int GetQuantity() {
        return quantity;
    }
}