# ecommerceNasdak

# Project Description: E-Commerce Management System using Blazor and .NET 8

The E-Commerce Management System is a web-based platform developed using Blazor and .NET 8. It allows seamless management of users, products, product inventories, and customer orders, making it ideal for running and managing e-commerce operations. The application uses a modern, interactive, and dynamic UI built on Blazor Server and leverages Entity Framework Core for database operations.

## Key Features

### User Management
- Allows administrators to manage users who can access the system.
- Secure login and password handling for authentication.

### Product Management
- Create, read, update, and delete (CRUD) operations for products.
- Product details include name, price, and association with inventory.

### Product Inventory Management
- Keeps track of the quantity of each product in stock.
- Allows updates to the inventory as products are added or sold.

### Order Management
- Displays customer orders with details of each product ordered.
- Supports CRUD operations for orders and their details.

### Order Details
- Each order can be associated with multiple products, tracking quantities and pricing.

### Interactive DataTables
- Data is presented interactively using DataTables, providing sorting, searching, and pagination functionality for better user experience.
- This allows for efficient management of large datasets (e.g., lists of products or orders).

### Blazor Components
- The project is modular, with separate Blazor components for each entity (Users, Products, Inventory, Orders), allowing for easy code maintenance and scalability.

### Entity Framework Core
- The application uses Entity Framework Core to handle database interactions and manages relationships between entities such as Products, Orders, Users, and Inventories.

## Technologies Used
- **Blazor (Server):** For building a dynamic, single-page application (SPA) experience.
- **.NET 8:** The latest version of the .NET framework, providing high performance and modern features.
- **Entity Framework Core:** Used for database management and interaction with SQL Server.
- **SQL Server:** As the backend database for storing users, products, inventory, and order information.
- **DataTables (jQuery):** To provide a rich and interactive data presentation layer for lists of products, orders, and users.

## How it Works
- **Admin Interface:** Provides an interface for administrators to log in, manage products, view current inventory, process orders, and view details of individual customer purchases.
- **Product Inventory Management:** Ensures that product quantities are tracked, automatically updated as orders are placed, and helps maintain stock levels.
- **Orders Processing:** Displays customer orders, and details can be modified or removed based on changes in product availability.
- **CRUD Operations:** CRUD functionality is implemented for all major components, allowing for easy manipulation and management of the underlying data.

This project is designed to handle the basic needs of a small-to-medium e-commerce platform, with room for future expansion such as user roles, product categories, shipping integration, and reporting.
