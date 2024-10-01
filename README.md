# Mango.Services.CouponAPI

## Overview
`Mango.Services.CouponAPI` is a .NET Core-based microservice designed to handle coupon-related operations. It provides API endpoints for managing coupons, including retrieving all coupons and retrieving individual coupons by ID.

## Features
- Retrieve a list of coupons
- Retrieve a coupon by ID
- Handle coupon data with validation and error handling

## Project Structure
- **Controllers**: Contains API controllers to manage incoming HTTP requests.
- **Data**: Contains the `AppDBContext` class for Entity Framework Core integration.
- **Models**: Defines the data models for the service (e.g., `Coupon`).
- **Migrations**: Contains the Entity Framework migrations to update and manage the database schema.

### Technologies Used
- **ASP.NET Core**: The framework used to create the API.
- **Entity Framework Core**: For database management and migrations.
- **SQL Server**: The database used for storing coupon data.

## Getting Started

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Setting Up the Project
1. **Clone the repository**:
   ```bash
   git clone https://github.com/yourusername/Mango.Services.CouponAPI.git
   cd Mango.Services.CouponAPI
