using System;
namespace CustomerOrderOOP
{
	public class Customer
	{
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Name{get{ return FirstName + LastName;}}
        public string? Email { get; set; }
        public Order? Orders { get; set; }
    }

	public class Order
    {
        //Earlier GUID was known as UUID.
        //UUID stands for Universally Unique Identifier.
        //We use GUID for unique identifier.
        public Order(Guid ordNum)
        {
            OrderNumber = ordNum;
        }
        public Guid OrderNumber { get; }
    }
}

