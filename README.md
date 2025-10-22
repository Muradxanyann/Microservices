# 🧩 Microservices E-Commerce Platform

A fully functional **microservices-based e-commerce system** built with **C#**, **ASP.NET Core**, **Dapper**, and **Docker**.  
This project demonstrates modern distributed architecture with independent services communicating via **RabbitMQ**, managed through an **API Gateway (Ocelot)**, and optimized with **Redis caching**.

---

## 🚀 Overview

This solution implements a scalable, event-driven microservices architecture.  
Each service is self-contained, has its own PostgreSQL database, and communicates asynchronously through a message broker.

**Main components:**

### 🧠 API Gateway
- Built with **Ocelot**.
- Serves as the single entry point for all client requests.
- Routes incoming HTTP requests to appropriate downstream services.
- Handles authentication, authorization, and load balancing between services.

### 🏪 Shop API
- Core service responsible for **products** and **orders** management.
- Built with **ASP.NET Core** and **Dapper**.
- Uses **Redis** for order caching to improve performance.
- Publishes events to **RabbitMQ** for inter-service communication.
- Stores data in **PostgreSQL** (separate database).

### 🔐 Shop API Auth Service
- Dedicated microservice for **user authentication and identification**.
- Implements **JWT** authentication with **refresh tokens**.
- Uses its own **PostgreSQL** database.
- Communicates with other services via **RabbitMQ**.

### 🐳 Docker Compose
- Orchestrates the entire infrastructure:
    - **Shop API**
    - **Shop Auth Service**
    - **API Gateway**
    - **PostgreSQL** instances
    - **Redis** cache
    - **RabbitMQ** message broker

---
 
## 🧱 Architecture Diagram

                     ┌──────────────────┐
                     │      Client      │
                     └────────┬─────────┘
                              │
                              ▼
                     ┌──────────────────┐
                     │   API Gateway    │
                     │     (Ocelot)     │
                     └────────┬─────────┘
              ┌───────────────┴───────────────┐
              ▼                               ▼
    ┌──────────────────┐            ┌──────────────────┐
    │    Shop API      │◄──────────►│   Auth Service   │
    │ (Orders,Products)│            │ (JWT, Refresh)   │
    └────────┬─────────┘            └────────┬─────────┘
             │                               │
             ▼                               ▼
    ┌──────────────┐               ┌──────────────┐
    │ PostgreSQL   │               │ PostgreSQL   │
    └──────────────┘               └──────────────┘
             ▲                               ▲
             │                               │
             └──────────────┬────────────────┘
                            ▼
                     ┌──────────────┐
                     │  RabbitMQ    │
                     └──────┬───────┘
                            │
                            ▼
                     ┌──────────────┐
                     │    Redis     │
                     └──────────────┘
---

## ⚙️ Technologies Used

| Category | Tools & Frameworks |
|-----------|--------------------|
| **Language** | C# (.NET 8) |
| **Web Framework** | ASP.NET Core Web API |
| **ORM / Data Access** | Dapper |
| **Gateway** | Ocelot |
| **Message Broker** | RabbitMQ |
| **Cache** | Redis |
| **Database** | PostgreSQL |
| **Containerization** | Docker, Docker Compose |
| **Mapping / Utils** | AutoMapper, ILogger |
| **Architecture** | Microservices, Event-Driven |

---

## 🧩 Key Features

- Independent, loosely coupled microservices
- JWT authentication with refresh token mechanism
- API Gateway routing and aggregation
- Event-driven communication via RabbitMQ
- Data caching with Redis for faster reads
- Dockerized deployment for easy setup and scaling
- Dapper-based lightweight data access layer
- PostgreSQL databases per service (Database-Per-Service pattern)

---

## 🧠 My Role

Designed and developed **the entire project from scratch**, including:
- System architecture and service separation
- Implementation of all APIs and data access layers
- Integration of Ocelot gateway, Redis, and RabbitMQ
- Setup of Docker Compose environment
- Configuration of authentication and caching
- Optimization for scalability and maintainability

---

## 🏃‍♂️ How to Run Locally

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/Microservices.git
   cd Microservices
   ```
   
2. Start the environment:
    ```bash
        docker-compose up -d
    ```

3. Access services:
- Gateway: http://localhost:8000
- RabbitMQ Management UI: http://localhost:15672 (default login: guest / guest)
- Redis: localhost:6379

## ✨ Author

Gor Muradkhanyan
Software Developer (C# /.NET, Microservices, Docker, RabbitMQ, Redis)
### 📬 Contact

**Gor Muradkhanyan**  
📧 Email: [gormuradxanyan@gmail.com](mailto:gormuradxanyan@gmail.com)  
💼 LinkedIn: [linkedin.com/in/gormuradxanyan](https://www.linkedin.com/feed/)