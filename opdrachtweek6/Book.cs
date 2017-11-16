using System.Collections.Generic;

public class Book{
    
    string name;

    List<Author> authors;

    double price;
    int qtyInStock;

    public string Name { get => name; set => name = value; }

    public Book(string name, List<Author> authors, double price, int qtyInStock)
    {
        this.name = name;
        this.authors = authors;
        this.price = price;
        this.qtyInStock = qtyInStock;
    }

    public string getName(){
        return this.name;
    }

    public List<Author> getAuthors(){
        return this.authors;
    }

    public double getPrice(){
        return this.price;
    }

    public void setPrice(double newPrice){
        this.price = newPrice;
    }

    public double getQtyInStock(){
        return this.qtyInStock;
    }

    public void setQtyInStock(int newQtyInStock){
        this.qtyInStock = newQtyInStock;
    }

    public void print(){

    }

    public string getAuthorName(int authorNumber){
            return this.authors[authorNumber].Name;
    }


}

