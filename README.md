# ecomove-web-service

## Summary
Ecomove Web Service API Application, made with Microsoft C#, ASP.NET Core, Entity Framework Core and MySQL persistence. It also illustrates open-api documentation configuration and integration with Swagger UI.

## Features
- RESTful API
- OpenAPI Documentation
- Swagger UI
- Entity Framework Core
- Microsoft ASP.NET Framework
- Audit Creation and Update Date
- Custom Route Naming Conventions
- Custom Object-Relational Mapping Naming Conventions
- MySQL Database
- Domain-Driven Design

## Bounded Context
This proyect of EcoMove Web Service is divided in the following bounded contexts:
- User Management 
- Vehicle Management
- Payment
- Customer Support
- Booking and Reservation

### User Management Context
The User Management Context is responsible for registering users, as well as their login and access authorization. This includes the following features:
- User register
- User Login
- User access authorization
- User membership control

### Vehicle Management Context
The Vehicle Management Context is responsible for managing the eco-friendly vehicles available in the system. This includes the following features:
- Vehicle registration
- Vehicle type management
- Vehicle status tracking
- Vehicle availability management

### Payment Context
The Payment Context is responsible for handling all financial transactions within the system. This includes the following features:
- Payment processing
- Payment methods management
- Transaction history

### Customer Support Context
The Customer Support Context is responsible for managing interactions with customers, providing assistance, and resolving issues. This includes the following features:
- Ticket creation and management
- Customer support agent assignment
- Ticket category management

### Booking and Reservation Context
The Booking and Reservation Context is responsible for managing bookings and reservations of vehicles. This includes the following features:
- Booking creation and management
- Reservation scheduling
- Customer booking history
