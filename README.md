# Booking API - Technical Task

## Overview

API that retrieves available homes for a given date range. Returns homes only if they are available for **every date** in the requested range.

## Architecture

Clean Architecture with 4 layers:
- **Domain**: Entities and interfaces
- **Application**: Use cases and business logic  
- **Infrastructure**: In-memory data storage
- **API**: Minimal API endpoints and request handling

## API Endpoint

### GET /api/available-homes

**Parameters:**
- `startDate`: Start date (YYYY-MM-DD)
- `endDate`: End date (YYYY-MM-DD)

**Example:**
```
GET /api/available-homes?startDate=2025-07-15&endDate=2025-07-16
```

**Response:**
```json
{
  "status": "OK",
  "homes": [
    {
      "id": "1",
      "name": "Cozy Mountain Cabin",
      "availableSlots": ["2025-07-15", "2025-07-16"]
    }
  ]
}
```

## Filtering Logic

1. Generate all dates in the requested range
2. Check each home's available slots
3. Return only homes that have **all required dates** available

## How to Run

1. Clone repository
2. Run: `dotnet run --project Booking.API`
3. Access: `https://localhost:44382/swagger`

## How to Test

**Manual**: Use Swagger UI at `/swagger`

**Automated**: 
```bash
dotnet test
```

## Performance Features

- **HashSet** for O(1) date lookups
- **ConcurrentDictionary** for thread-safe storage
- **Async operations** for non-blocking calls
- **Parallel filtering** for large datasets

## Technologies

- .NET 8 Web API
- Minimal API endpoints
- In-memory storage (no database)
- Clean Architecture pattern
- HashSet optimization for performance
- Parallel LINQ (AsParallel) for efficient filtering
- xUnit for integration testing

## Design Principles

This project follows key software engineering principles:
- **SOLID**: Single Responsibility, Open/Closed, Liskov Substitution, Interface Segregation, Dependency Inversion
- **KISS**: Keep It Simple, Stupid - straightforward, readable code
- **DRY**: Don't Repeat Yourself - reusable components and logic
- **YAGNI**: You Aren't Gonna Need It - focused on requirements without over-engineering
