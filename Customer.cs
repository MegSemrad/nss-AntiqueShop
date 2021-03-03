using System;

namespace AntiqueShop
{
    public class Customer
    {
        public string FirstName { get; }

        public string LastName { get; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        private decimal _minprice;
        private decimal _maxPrice;

        public Customer(string firstName, string lastName,
            decimal minPrice, decimal maxPrice)
        {
            FirstName = firstName;
            LastName = lastName;
            _minprice = minPrice;
            _maxPrice = maxPrice;
        }

        public void ExamineItem(AntiqueItem item)
        {
            if (item.Price >= _minprice && item.Price < _maxPrice)
            {
                Console.WriteLine($"Would add {item.Name} to purchase list");
            }
            else if (item.Price >= _maxPrice)
            {
                Console.WriteLine($"Would add {item.Name} to wish list");
            }
        }

    }
}