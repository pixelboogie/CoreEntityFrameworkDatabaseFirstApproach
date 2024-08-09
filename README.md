# CoreEntityFrameworkDatabaseFirstApproach

## Description
CoreEntityFrameworkDatabaseFirstApproach is a project developed as part of the Coursera course for the ".NET FullStack Developer Specialization" certification. This project demonstrates the database-first approach using Entity Framework Core.

In the database-first approach, domain classes and DbContext classes are generated from an existing database using EF Core. The instructor demonstrates how to implement this approach using the `scaffold` command in the Package Manager Console. The scaffold command generates the domain and DbContext classes based on the specified database schema.

Additionally, the project covers how to modify the database and update the domain classes by re-running the scaffold command with the `--force` flag. This approach is particularly useful when working with larger databases, allowing for easy generation of domain classes that support CRUD (Create, Read, Update, Delete) operations.

## Table of Contents
- [Technologies Used](#technologies-used)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Technologies Used
- **Entity Framework Core**: For ORM and reverse engineering the database schema.
- **ASP.NET Core**: Framework for building the web application.
- **C#**: Programming language used in the project.
- **SQL Server**: Database management system for storing and retrieving data.

## Installation
To set up this project locally, follow these steps:

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/your-username/CoreEntityFrameworkDatabaseFirstApproach.git
   cd CoreEntityFrameworkDatabaseFirstApproach

2. **Install Dependencies:**

    Ensure that you have the .NET SDK installed. Then, restore any required packages:

        dotnet restore


3. **Configure the Database Connection:**

    Update the appsettings.json file with your database connection string.


4. **Scaffold the Database:**

    Generate the domain and DbContext classes from your existing database using the scaffold command:

        dotnet ef dbcontext scaffold "YourConnectionString" Microsoft.EntityFrameworkCore.SqlServer -o Models

    If you need to update the domain classes after modifying the database, run the scaffold command again with the --force flag:

        dotnet ef dbcontext scaffold "YourConnectionString" Microsoft.EntityFrameworkCore.SqlServer -o Models --force

5. **Run the Application:**

    Start the application using the following command:

        dotnet run

## Usage ## 
Once the application is running, you can perform CRUD operations on the entities generated from the database. The database-first approach makes it easy to work with existing databases and quickly set up the application for data management.

## License ##
This project is licensed under the MIT License. See the LICENSE file for more information.
