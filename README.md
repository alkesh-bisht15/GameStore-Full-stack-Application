# 🎮 GameStore

GameStore is a full-stack web application developed to demonstrate my skills in modern **.NET full-stack development**. The project provides a platform for users to browse and interact with a collection of games through a responsive web interface, while a dedicated REST API handles backend operations and data management.

The application is built using **C#** and follows a layered architecture, with **Blazor** powering the frontend and **ASP.NET Core Web API** providing the backend services. **Entity Framework Core** is used for database integration and object-relational mapping.

## 🚀 Project Overview

The primary goal of GameStore is to build a complete full-stack application using the Microsoft .NET ecosystem, covering both client-side and server-side development.

The project demonstrates:

- Building interactive web interfaces using **Blazor**
- Developing RESTful APIs using **ASP.NET Core**
- Implementing database operations using **Entity Framework Core**
- Connecting the frontend with backend REST APIs
- Performing CRUD operations and managing application data
- Structuring a full-stack application using modern software development practices
- Working with C# across both frontend and backend layers

## 🛠️ Technologies Used

### Frontend
- **C#**
- **Blazor**
- HTML5
- CSS3

### Backend
- **C#**
- **ASP.NET Core Web API**
- RESTful APIs
- **Entity Framework Core**

### Database
- Relational Database
- Entity Framework Core for ORM and database integration

### Development & Deployment
- Git & GitHub
- .NET
- Visual Studio / Visual Studio Code

## 🏗️ Architecture

The application is divided into three major components:

```text
┌─────────────────────────┐
│      Blazor Frontend    │
│       (Client UI)       │
└────────────┬────────────┘
             │
             │ HTTP / REST API
             ▼
┌─────────────────────────┐
│   ASP.NET Core Web API  │
│       (Backend)         │
└────────────┬────────────┘
             │
             │ Entity Framework Core
             ▼
┌─────────────────────────┐
│        Database         │
└─────────────────────────┘


The Blazor frontend communicates with the ASP.NET Core REST API through HTTP requests. The API handles business logic and data operations, while Entity Framework Core manages communication between the application and the database.

✨ Key Features
🎮 Game catalogue management
🔍 Browse and view game information
🌐 REST API-based communication
🗄️ Database integration using Entity Framework Core
⚡ Interactive Blazor user interface
🔄 CRUD-based data operations
📱 Responsive web interface
🧩 Separation of frontend and backend responsibilities
🎯 Purpose of the Project

GameStore was developed as a practical demonstration of my Full Stack Development skills using the C# and .NET ecosystem.

Rather than building only a frontend application or a standalone backend, this project focuses on understanding how different components of a modern web application work together — from the user interface and REST APIs to database integration.

📚 What I Learned

Through this project, I gained practical experience in:

1.)Developing applications with Blazor
2.)Creating RESTful services with ASP.NET Core
3.)Working with Entity Framework Core
4.)Designing and consuming APIs
5.)Performing database operations through an ORM
6.)Connecting frontend and backend applications
7.)Structuring and developing a full-stack .NET application
8.)Using GitHub for source control and project deployment
👨‍💻 Developer

Developed by Alkesh Singh Bisht

This project represents my practical experience and learning in Full Stack Development using C# and .NET.
