# Mango.Services.CouponAPI

## Overview
`Mango.Services.CouponAPI` is a .NET Core-based microservice designed to handle coupon-related operations. It provides API endpoints for managing coupons, including retrieving coupons by ID or code, creating new coupons, updating existing coupons, and deleting coupons.

This service utilizes **Entity Framework Core** for database operations and **AutoMapper** for mapping between data models and DTOs (Data Transfer Objects).

## Features
- **Retrieve Coupons**: Fetch all coupons or retrieve them by ID or coupon code.
- **Create Coupons**: Create new coupons by sending data through the API.
- **Update Coupons**: Update existing coupons by providing the updated data.
- **Delete Coupons**: Delete coupons by code.

## Project Structure
- **Controllers**: 
  - `CouponAPIController.cs`: Contains API endpoints to manage coupon-related data.
- **Data**: 
  - `AppDBContext.cs`: Entity Framework Core DB Context for accessing the database.
- **Models**:
  - `Coupon.cs`: The main entity model representing a coupon.
  - `CouponDto.cs`: Data Transfer Object (DTO) for managing coupon data between API and database.
  - `ResponseDTO.cs`: Wrapper for API responses, providing structure for the result, success flag, and messages.
- **AutoMapper**: Used for mapping between the `Coupon` entity and the `CouponDto`.

### Technologies Used
- **ASP.NET Core**: The framework used to build the API.
- **Entity Framework Core**: ORM used for database management.
- **AutoMapper**: Library for object-to-object mapping between models and DTOs.
- **SQL Server**: The database used to store coupon data.

## Getting Started

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Setting Up the Project
1. **Clone the repository**:
   ```bash
   git clone https://github.com/yourusername/Mango.Services.CouponAPI.git
   cd Mango.Services.CouponAPI
