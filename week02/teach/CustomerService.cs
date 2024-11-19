﻿using System.Data.Common;

/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>
public class CustomerService {
    public static void Run() {
        // Example code to see what's in the customer service queue:
        var cs = new CustomerService(10);
        Console.WriteLine(cs);

        // Test Cases

        // Test 1
        // Scenario: 
        // Expected Result: The user shall specify the maximum size of the Customer Service Queue when it is created. If the size is invalid (less than or equal to 0) then the size shall default to 10.
        Console.WriteLine("Test 1");
        // check the solution, got the setup wrong here
        CustomerService cs1 = new CustomerService(0);
        Console.WriteLine(cs1._maxSize);
        CustomerService cs2 = new CustomerService(1);
        Console.WriteLine(cs2._maxSize);
        CustomerService cs3 = new CustomerService(5);
        Console.WriteLine(cs3._maxSize);

        // Defect(s) Found: 

        Console.WriteLine("=================");

        // Test 
        // Scenario: 
        // Expected Result: The AddNewCustomer method shall enqueue a new customer into the queue.
        Console.WriteLine("Test 2");
        // cs3.AddNewCustomer();

        // Defect(s) Found: none

        Console.WriteLine("=================");

        // Add more Test Cases As Needed Below

        Console.WriteLine("=================");

        // Test 2
        // Scenario: 
        // Expected Result: If the queue is full when trying to add a customer, then an error message will be displayed
        Console.WriteLine("Test 3");
        cs2.AddNewCustomer();
        cs2.AddNewCustomer();
        cs2.AddNewCustomer();
        // Defect(s) Found: none

        Console.WriteLine("=================");

        Console.WriteLine("=================");

        // Test 4
        // Scenario: 
        // Expected Result: The ServeCustomer function shall dequeue the next customer from the queue and display the details
        Console.WriteLine("Test 4");
        cs2.ServeCustomer();
        cs2.ServeCustomer();
        // Defect(s) Found: exception thrown when trying to remove second customer. had to put remove function after queue was declared in variable

        // Console.WriteLine("=================");

        // Test 5
        // Scenario: 
        // Expected Result: If the queue is empty when trying to serve a customer, then an error message will be displayed.
        Console.WriteLine("Test 5");
        cs1.ServeCustomer();
        // Defect(s) Found: needs if/else to handle both situations

        // Console.WriteLine("=================");
    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;

    public CustomerService(int maxSize) {
        if (maxSize <= 0)
            _maxSize = 10;
        else
            _maxSize = maxSize;
    }

    /// <summary>
    /// Defines a Customer record for the service queue.
    /// This is an inner class.  Its real name is CustomerService.Customer
    /// </summary>
    private class Customer {
        public Customer(string name, string accountId, string problem) {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        private string Name { get; }
        private string AccountId { get; }
        private string Problem { get; }

        public override string ToString() {
            return $"{Name} ({AccountId})  : {Problem}";
        }
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the 
    /// new record into the queue.
    /// </summary>
    private void AddNewCustomer() {
        // Verify there is room in the service queue
        if (_queue.Count > _maxSize) {
            Console.WriteLine("Maximum Number of Customers in Queue.");
            return;
        }

        Console.Write("Customer Name: ");
        var name = Console.ReadLine()!.Trim();
        Console.Write("Account Id: ");
        var accountId = Console.ReadLine()!.Trim();
        Console.Write("Problem: ");
        var problem = Console.ReadLine()!.Trim();

        // Create the customer object and add it to the queue
        var customer = new Customer(name, accountId, problem);
        _queue.Add(customer);
    }

    /// <summary>
    /// Dequeue the next customer and display the information.
    /// </summary>
    private void ServeCustomer() {
        if (_queue.Count <= 0)
        {
            Console.WriteLine("No one to remove");
        }
        else{
            // wrong order. Can't remove first
            // _queue.RemoveAt(0);
            // var customer = _queue[0];
            var customer = _queue[0];
            _queue.RemoveAt(0);
            Console.WriteLine(customer);
        }
    }

    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a 
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
    public override string ToString() {
        return $"[size={_queue.Count} max_size={_maxSize} => " + string.Join(", ", _queue) + "]";
    }
}