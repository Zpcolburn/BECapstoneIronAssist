# IronAssist 🛠️

IronAssist is a revolutionary platform designed to streamline communication and repair management for heavy equipment operators and mechanics. By bridging the gap between field operators and maintenance teams, IronAssist ensures real-time issue reporting, quicker resolutions, and improved operational efficiency.

### 👤 Ideal User
IronAssist is tailored for two primary user roles:

Heavy Equipment Operators

Operators who need a fast and reliable way to report equipment issues.
They value clear communication and rapid response to minimize downtime.
Mechanics

Maintenance professionals who require detailed, real-time reports to prioritize and resolve issues efficiently.
They appreciate well-organized information and streamlined workflows.

---

## 💻 Technologies

- C#
- .NET
- Entity Framework Core
- Moq
- xUnit
- PostgreSQL
- pgAdmin
- Swagger
- Postman

---

## 🚀 Getting Started

### Prerequisites

For this project to run successfully, you'll need the following:

- [.NET](https://dotnet.microsoft.com/en-us)
- [PostgreSQL](https://www.postgresql.org/download)
- [pgAdmin](https://www.pgadmin.org)

### 1. Clone the Repo

Clone this repo using the following command in your terminal:

```bash
git clone git@github.com:Zpcolburn/BECapstoneIronAssist.git
```

### 2. Install Required Packages

Once the repository is cloned, navigate to the project directory in your terminal and run the following commands to install the necessary packages:

```bash
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 8.0
dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0
```

### 3. Set Up Secrets for PostgreSQL Connection

To store sensitive connection details, initialize the secret storage with:

```bash
dotnet user-secrets init
```

Then, set the connection string for your PostgreSQL database (replace with your actual PostgreSQL password):

```bash
dotnet user-secrets set "BECapstoneIronAssistDbConnectionString" "Host=localhost;Port=5432;Username=postgres;Password=<your_postgresql_password>;Database=BECapstoneIronAssist"
```

### 4. Apply Migrations to the Database

Run the following command to apply the database migrations:

```bash
dotnet ef database update
```

This will create the necessary tables and schema in your PostgreSQL database.

### 5. Run the Solution

Launch the solution. Swagger should automatically launch and provide you with the API documentation.

## 📍 Features/API Endpoints

| HTTP Method | Route                                       | Endpoint Description                               |
|-------------|---------------------------------------------|---------------------------------------------------|
| GET         | /equipment                                  | Get All Equipment                                 |
| GET         | /equipment/{id}                             | Get Single Equipment                              |
| POST        | /equipment                                  | Add New Equipment                                 |
| PUT         | /equipment/{id}                             | Update Single Equipment                           |
| DELETE      | /equipment{id}                               | Delete Single Equipment                           |
| POST        | /equipmentPart/{equipmentId}/{partId}      | Add EquipmentPart to Equipment                    |
| PUT         | /equipmentPart/{equipmentId}/{partId}      | Edit EquipmentPart                                |
| DELETE      | /equipmentPart/{equipmentId}/{partId}      | Delete EquipmentPart                              |
| GET         | /jobsites                                   | Get All Jobsites                                  |
| GET         | /jobsite/{id}                               | Get Single Jobsite                                |
| POST        | /jobsite                                    | Create New Jobsite                                |
| PUT         | /jobsite/{id}                               | Update Single Jobsite                             |
| DELETE      | /jobsite{id}                                | Delete Single Jobsite                             |
| GET         | /parts                                      | Get All Parts                                     |
| GET         | /part/{id}                                  | Get Single Part by Id                             |
| POST        | /part                                       | Add New Part                                      |
| PUT         | /part/{id}                                  | Edit Part                                         |
| DELETE      | /part/{id}                                  | Delete Part                                       |
| GET         | /reports                                    | Get All Reports                                   |
| GET         | /report/{id}                                | Get Single Report                                 |
| POST        | /report                                     | Create New Report                                 |
| PUT         | /report/{id}                                | Edit Report                                       |
| DELETE      | /report/{id}                                | Delete Report                                     |
| GET         | /users                                      | Get All Users                                     |
| GET         | /users/checkUser/{uid}                      | Check if User Exists                              |
| GET         | /users/{id}                                 | Get Single User                                   |
| POST        | /users                                      | Add New User                                      |
| PUT         | /users/{id}                                 | Update Single User                                |


## 📄 Postman Documentation

Check out the [Iron AssistPostman Documentation](https://documenter.getpostman.com/view/39137419/2sAYBYhAwA) to learn more about the API routes and see examples of how each request and response should look.

[Iron Assist Loom Video](https://www.loom.com/share/757554624c7f42959a43b0767543f43b?sid=6b8e0df2-2c1b-4f52-868c-bd431fdc7cc9)

## 📋 Project Board

View the [Iron Assist Project Board](https://github.com/users/Zpcolburn/projects/8) to see open and completed project tickets.

## Project Owner

<table>
<tr>
<td align="center">
<a href="https://github.com/Zpcolburn">
<img src="https://avatars.githubusercontent.com/u/144184847?s=400&u=10233cb286abe8334e8e4c7aba715fc647d76108&v=4" width="100px;" alt="Zach Colburn Profile Picture"/><br>
<sub><b>Zach Colburn</b></sub>
</a>
</td>
</tr>
</table>
