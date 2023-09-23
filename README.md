# Web API Using Entity Framework Core and In-Memory Database

This is a simple Web API project built using ASP.NET Core and Entity Framework Core with an in-memory database. It demonstrates the basic setup of a RESTful API, including CRUD (Create, Read, Update, Delete) operations on a collection of entities.

## Getting Started

### Prerequisites

To run this project, you need to have the following software installed on your machine:

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Visual Studio](https://visualstudio.microsoft.com/), [Visual Studio Code](https://code.visualstudio.com/), or any code editor of your choice.

### Installation

1. Clone this repository to your local machine:

   ```bash
   git clone https://github.com/yourusername/WebAPIUsingEFCore.git
   ```

2. Navigate to the project directory:

   ```bash
   cd WebAPIUsingEFCore
   ```

3. Build and run the project:

   ```bash
   dotnet build
   dotnet run
   ```


## Usage

### Endpoints

The API exposes the following endpoints:

- `GET /api/products`: Retrieve a list of all products.
- `GET /api/products/{id}`: Retrieve a product by its ID.
- `POST /api/products`: Create a new product.
- `PUT /api/products/{id}`: Update an existing product by its ID.
- `DELETE /api/products/{id}`: Delete a product by its ID.

### Example Requests

![image](https://github.com/LavanyaPasumarthi3/WebAPIUsingEFCore/assets/141587110/7caca787-1679-4364-a60b-70b7631ece15)

#### GET /api/products

Retrieve all products:

```http
GET http://localhost:someportNumber/api/Products
```
![image](https://github.com/LavanyaPasumarthi3/WebAPIUsingEFCore/assets/141587110/c6919647-1eea-48f8-b7ff-7cea1d251947)

#### GET /api/products/id

Retrieve specific product:

```http
GET http://localhost:someportNumber/api/Products/1
```
![image](https://github.com/LavanyaPasumarthi3/WebAPIUsingEFCore/assets/141587110/bbab84da-cce3-465f-947e-b12a474e1689)

#### POST /api/products

Create a new product:

```http
POST http://localhost:someportNumber/api/Products

```
![image](https://github.com/LavanyaPasumarthi3/WebAPIUsingEFCore/assets/141587110/772d28ab-86c4-454a-9bf3-58ee7aee3bb2)
![image](https://github.com/LavanyaPasumarthi3/WebAPIUsingEFCore/assets/141587110/5a0a975e-afb9-40df-bea0-bafd18cba053)

#### PUT /api/products/{id}

Update an existing product:

```http
PUT http://localhost:someportNumber/api/Products/1

```
![image](https://github.com/LavanyaPasumarthi3/WebAPIUsingEFCore/assets/141587110/cd300d08-9531-44cd-9363-a3cb5df0cb74)
![image](https://github.com/LavanyaPasumarthi3/WebAPIUsingEFCore/assets/141587110/af7038e9-a7d6-40f9-b575-09d2bb78efae)


#### DELETE /api/products/{id}

Delete a product:

```http
DELETE http://localhost:someportNumber/api/products/1
```
#### Returned deleted product:
![image](https://github.com/LavanyaPasumarthi3/WebAPIUsingEFCore/assets/141587110/98a651f9-8e58-494f-84e8-fe404bf0c5e8)

## Development

### Project Structure

- `Controllers/`: Contains API controller classes.
- `Data/`: Contains database context and entity classes.
- `Migrations/`: Contains EF Core migration files.
- `Startup.cs`: Configures the application and services.

### Adding Features

You can extend this project by adding more features such as authentication, validation, or additional endpoints. Refer to the [ASP.NET Core documentation](https://docs.microsoft.com/aspnet/core) for guidance on adding new functionalities.

## Contributing

Contributions to this project are welcome. Feel free to open an issue or submit a pull request.



