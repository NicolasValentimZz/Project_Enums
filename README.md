# Project_Enums - Order System with Class Composition and Enum in C#

A small C# console project built to solidify key Object-Oriented Programming concepts learned over the past few months.  
This project focuses on **class composition**, **instance methods** (Subtotal, Total, AddItem, RemoveItem), **enumerations (enum)** for order status, and **list manipulation** using `List<T>` with foreach loops.

The application simulates a simple order processing system: it registers customer data, creates an order with a selected status, adds multiple items to the order, calculates subtotals and the final total, and displays a complete order summary.

### Features
- Customer registration: name, email, and date of birth.
- Order creation with current date/time, status selected via enum, and association to the customer.
- Dynamic addition of multiple order items (product name, unit price, quantity).
- Automatic calculation of each item's subtotal and the order's total value.
- Clean, formatted console output showing all customer data, order details, items list, and final amount.

### Technical Highlights
- **Class Composition**:
  - `Order` composes a `Client` and a `List<OrderItem>`.
  - `OrderItem` composes a `Product` along with quantity and price (price is captured at order time).
- **Enum Usage**:
  ```csharp
  public enum OrderStatus
  {
      PendingPayment = 0,
      Processing = 1,
      Shipped = 2,
      Delivered = 3
  }

  Used to define and manage the order status.

Key Methods:
AddItem(OrderItem item) and RemoveItem(OrderItem item) on Order.
SubTotal() on OrderItem → returns Price × Quantity.
Total() on Order → iterates over the items list and sums all subtotals.

List Handling:
List<OrderItem> Items is initialized directly in the property declaration (prevents null references).
Items are added dynamically based on user input.

Internationalization:
Use of CultureInfo.InvariantCulture for parsing and formatting monetary values and dates.
Proper date input with DateTime.ParseExact.

Output Formatting:
Overridden ToString() methods for readable display.
StringBuilder used in Order.ToString() for efficient string construction.


Project Structure

Entities/
Client.cs
Product.cs
OrderItem.cs
Order.cs
Enums/OrderStatus.cs

Program.cs – Console-based interaction (data input and final summary display).

How to Run

Clone the repository.
Open Exercicio_Enum.sln in Visual Studio or JetBrains Rider.
Build and run the project.
Follow the console prompts to enter customer data, order status, and items.

This project successfully reinforces core OOP principles in C# and serves as a clean, well-structured example of class composition and enum usage.
Made with ❤️ by NicolasValentimZz
