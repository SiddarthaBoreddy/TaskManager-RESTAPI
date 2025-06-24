# ✅ Task Manager REST API (ASP.NET Core 8)

## 📖 Overview

This project is a **secure, production-ready REST API** for managing personal tasks.
It is built using **ASP.NET Core 8**, **SQLite**, **JWT Authentication**, and follows a clean architecture with Dependency Injection.

---

## 🛠 Technologies Used

- **C# & ASP.NET Core 8** – Main API framework.
- **Entity Framework Core** – ORM for SQLite.
- **JWT (JSON Web Tokens)** – Authentication & authorization.
- **Swagger UI** – API documentation & testing.
- **Dependency Injection & Repository Pattern** – Clean architecture.

---

## 📌 Features

✅ **User Registration & Login**  
✅ **JWT-Based Authentication & Secure Endpoints**  
✅ **CRUD Operations for Tasks**  
✅ **SQLite Database with EF Core Migrations**  
✅ **Async/Await for Scalability**  
✅ **Swagger UI for API Exploration**

---

## 📂 Project Structure

```
📁 TaskManagerAPI/
│── 📁 Controllers/        # API Controllers (Auth, Tasks)
│── 📁 Models/             # Entity models (User, TaskItem)
│── 📁 DTOs/               # Data Transfer Objects
│── 📁 Repositories/       # Repositories & Interfaces
│── 📁 Services/           # Service Layer & Interfaces
│── 📁 Data/               # Database Context
│── Program.cs             # Entry Point & DI Config
│── appsettings.json       # Configuration (JWT Key & Connection String)
│── .gitignore             # Git Ignore Rules
│── README.md              # Project Documentation (this file)
```

---

## 🚀 How It Works

### **1️⃣ Register & Login**

- `POST /api/auth/register` — Register a new user.
- `POST /api/auth/login` — Login and receive a JWT token.

### **2️⃣ CRUD Tasks**

- `GET /api/tasks` — Get all tasks for logged-in user.
- `POST /api/tasks` — Create a new task.
- `PUT /api/tasks/{id}` — Update an existing task.
- `DELETE /api/tasks/{id}` — Delete a task.

**All task routes are protected — require JWT token in the `Authorization` header.**

---

## 🏃 Running the Project

### **1️⃣ Clone & Install**

```bash
git clone <YOUR_REPO_URL>
cd TaskManagerAPI
dotnet restore
```

### **2️⃣ Apply Database Migration**

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### **3️⃣ Run the API**

```bash
dotnet run
```

Visit: [https://localhost:5001/swagger](https://localhost:5001/swagger)

---

## 🔐 Security Highlights

- **JWT Auth:** All user data is protected.
- **Hashed & Salted Passwords:** Secure storage.
- **HTTPS Redirection:** Enabled by default.
- **Input Validation & Clean Code:** Follows best practices.

---

## 🔬 Example Requests

### **Register**
```bash
curl -X POST https://localhost:5001/api/auth/register -H "Content-Type: application/json" -d '{"username":"testuser","password":"Password123"}'
```

### **Login & Get Token**
```bash
curl -X POST https://localhost:5001/api/auth/login -H "Content-Type: application/json" -d '{"username":"testuser","password":"Password123"}'
```

### **Use JWT for Tasks**
Add `Authorization: Bearer <your_token>` header in Postman or curl to access:
- `GET /api/tasks`
- `POST /api/tasks`
- `PUT /api/tasks/{id}`
- `DELETE /api/tasks/{id}`

---

## ⚙️ Dependencies

- `Microsoft.EntityFrameworkCore.Sqlite`
- `Microsoft.AspNetCore.Authentication.JwtBearer`
- `Swashbuckle.AspNetCore` (Swagger)
- `.NET 8 SDK`

---

## 📧 Contact

**Author:** Siddartha Reddy Boreddy  
📍 **Binghamton University**  
✉️ **Email:** sboreddy@binghamton.edu

---

### ⭐ If you find this project helpful, please star the repository! 🚀
