# Task Manager API

A simple ASP.NET Core 8 REST API with JWT authentication for managing tasks.

## Features

✅ Register & Login (JWT)  
✅ CRUD for Tasks (user-specific)  
✅ SQLite DB with EF Core  
✅ Clean architecture with DI  
✅ Ready to deploy & scale

## Getting Started

1. **Restore & Run**  
```bash
dotnet restore
dotnet ef database update
dotnet run
```

2. **Test Endpoints**
- Register: `POST /api/auth/register` `{ "username": "test", "password": "pass" }`
- Login: `POST /api/auth/login` → Get JWT token
- Use JWT as Bearer in `Authorization` header for `/api/tasks` CRUD.

## Security
- JWT signed with symmetric key.
- Passwords hashed & salted.
- HTTPS enforced.
- DI & async for scalability.

## Example curl

```bash
# Register
curl -X POST https://localhost:5001/api/auth/register -H "Content-Type: application/json" -d '{"username":"test","password":"pass"}'

# Login
curl -X POST https://localhost:5001/api/auth/login -H "Content-Type: application/json" -d '{"username":"test","password":"pass"}'
```

## Dependencies
- .NET 8
- Microsoft.EntityFrameworkCore.Sqlite
- Microsoft.AspNetCore.Authentication.JwtBearer
- Swashbuckle.AspNetCore (Swagger)

## Unit Tests
- Add tests in `UnitTests/` using xUnit.

Enjoy building!