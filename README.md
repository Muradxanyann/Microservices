# ️ 🛍️ ShopAPI - Clean Architecture ASP.NET Core Project
> A fully structured ASP.NET Core Web API built with Clean Architecture principles, microservices, Dapper ORM, and JWT Authentication


This repository contains the microservices for the shop project:

#### `Shop.Api` - Orders & Products services
#### `Auth.Api` - Authentication service (Users & Tokens)

## 🧠 Project Architecture
```
ShopApi
│
├── 📂 Domain
│   ├── OrderEntity.cs
│   ├── ProductEntity.cs
│   ├── ProductOrderEntity.cs
│   └── Domain.csproj
│
├── 📂 Application
│   ├── Dto/
│   ├── Interfaces/
│   ├── MappingProfiles/
│   ├── Services/
│   └── Application.csproj
│
├── 📂 Infrastructure
│   ├── Repositories/
│   ├── Seed/
│   └── Infrastructure.csproj
│
├── 📂 Presentation
│   ├── Controllers/
│   ├── Exceptions/
│   ├── Program.cs
│   ├── appsettings.json
│   └── Presentation.csproj
│
├── 📂 Shared
│   ├── Dto/
│   ├── UserClient.cs
│   └── Shared.csproj
│
├── 📂 Tests
│   ├── Services/
│   │   └── OrderServiceTest.cs
│   └── Tests.csproj
│
└── 📜 ShopApi
```
---

## ⚙️ Tech Stack

| Layer | Technologies |
|-------|---------------|
| **Core Framework** | ASP.NET Core 9.0 |
| **ORM** | Dapper |
| **Mapping** | AutoMapper |
| **Database** | PostgreSQL |
| **Authentication** | JWT (Access + Refresh Tokens) |
| **Security** | BCrypt password hashing |
| **Architecture** | Clean Architecture (Domain → Application → Infrastructure → Presentation) |
| **Docs** | Swagger / Swashbuckle |

---
