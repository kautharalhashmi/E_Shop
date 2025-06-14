
# E-Shop Database Schema

E-Shop is an online shopping platform that offers a wide range of products to customers worldwide. This database schema is designed to support the functionality of the E-Shop application, ensuring efficient management of product inventory, customer data, order processing, and user interactions.

## 📦 Overview

The E-Shop database schema consists of the following core entities:

- **Customers**  
- **Products**  
- **Orders**  
- **Order Items**  
- **Shipping Addresses**  
- **Payment Information**  
- **Categories**  
- **Reviews**


## 🔐 Notes on Security and Optimization

- **Sensitive data** (e.g., card number, CVV) should be stored using strong encryption and follow PCI compliance guidelines.
- **Indexes** should be applied to frequently queried fields such as `email`, `product_id`, and `order_id`.
- **Referential integrity** is enforced via foreign key constraints to maintain data consistency across tables.

---

## ✅ Benefits

- Efficient inventory management
- Streamlined order processing
- Organized product browsing
- Secure customer data handling
- Valuable customer feedback for quality improvement



> This schema provides a solid foundation for E-Shop’s growing e-commerce platform and ensures a seamless, secure, and efficient shopping experience for its users.
