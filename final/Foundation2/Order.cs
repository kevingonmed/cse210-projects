public class Order {
    private Customer customer;
    private Product[] products;
    
    public Order(Customer customer, Product[] products) {
        this.customer = customer;
        this.products = products;
    }
    
    public double GetTotalPrice() {
        double totalPrice = 0;
        foreach (Product product in products) {
            totalPrice += product.GetPrice();
        }
        totalPrice += customer.IsInUSA() ? 5 : 35;
        return totalPrice;
    }
    
    public string GetPackingLabel() {
        string packingLabel = "";
        foreach (Product product in products) {
            packingLabel += $"{product.GetName()} (Product ID: {product.GetProductId()})\n";
        }
        return packingLabel;
    }
    
    public string GetShippingLabel() {
        string shippingLabel = $"{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
        return shippingLabel;
    }
}