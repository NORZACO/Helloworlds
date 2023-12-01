using System;

namespace Helloworlds
{
    public class Products
    {
        //public fields	The code is accessible for all classes
        public string _name;
        public string _description;
        public float _price;
        public int _quantity;

        // private fieldsThe code is only accessible within the declared class
        private string _category;
        private string _manufacturer;

        // protected fields	The code is accessible within the declared class and within classes that inherit from the declared class
        protected string _color;
        protected string _size;

        // internal
        internal string _regularMember;

        // constructor
        public Products(string name, string description, float price, int quantity, string category, string manufacturer, string color, string size, string regularMember)
        {
            _name = name;
            _description = description;
            _price = price;
            _quantity = quantity;
            _category = category;
            _manufacturer = manufacturer;
            _color = color;
            _size = size;
            _regularMember = regularMember;
        }

        // TODO get product info
        public string GetProductInformation()
        {
            return $"Name: {_name}\n Description: {_description}\n Price: {_price}\n Quantity: {_quantity}\n Category: {_category}\n Manufacturer: {_manufacturer}\n Color: {_color}\n Size: {_size}\n";
        }

        // TODO get product price
        public float GetProductPrice()
        {
            return _price;
        }
    }
}
