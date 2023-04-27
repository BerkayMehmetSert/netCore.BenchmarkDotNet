# .Net Core BenchmarkDotNet

This is a benchmark project using the **BenchmarkDotNet** library to measure the performance of a ProductsController in a WebAPI project.

## Prerequisites

- [.Net Core 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)

## Installing

1. Clone the repository

```
git clone https://github.com/BerkayMehmetSert/netCore.BenchmarkDotNet.git
```

2. Change directory to the project
```	
cd WebAPI
```

3. Run the project
```
dotnet run
```

## Usage

The API allows you to manage products. You can create, update, delete, and retrieve products.

**Create a product**
```bash
POST /api/products
```

Request Body:
```json
{
  "name": "Product Name",
  "price": 9.99
}
```

Response Body:
```json
{
  "id": "1a2b3c4d-5e6f-7g8h-9i10-jk11lmno12pq",
  "name": "Product Name",
  "price": 9.99
}
```

**Update a product**
```bash
PUT /api/products/{id}
```

Request Body:
```json
{
  "name": "Updated Product Name",
  "price": 12.99
}
```

Response Body:
```json
{
  "id": "1a2b3c4d-5e6f-7g8h-9i10-jk11lmno12pq",
  "name": "Updated Product Name",
  "price": 12.99
}
```

**Delete a product**
```bash
DELETE /api/products/{id}
```

Response Body:
```json
{
  "id": "1a2b3c4d-5e6f-7g8h-9i10-jk11lmno12pq",
  "name": "Product Name",
  "price": 9.99
}
```

**Get a product by ID**
```bash
GET /api/products/{id}
```

Response Body:
```json
{
  "id": "1a2b3c4d-5e6f-7g8h-9i10-jk11lmno12pq",
  "name": "Product Name",
  "price": 9.99
}
```

**Get all products**
```bash
GET /api/products
```

Response Body:
```json
[
  {
    "id": "1a2b3c4d-5e6f-7g8h-9i10-jk11lmno12pq",
    "name": "Product Name 1",
    "price": 9.99
  },
  {
    "id": "2b3c4d5e-6f7g-8h9i-10jk-lm11nopq12rs",
    "name": "Product Name 2",
    "price": 12.99
  }
]
```

## Performance Tests
We have also included a performance benchmark for the Get All Products endpoint. To run the benchmark, navigate to the **WebAPI** project and execute the following command:

```bash
dotnet run -c Release --framework net6.0 --project WebAPI.csproj

dotnet run -c Release --framework net6.0 --project Benchmark.Test.csproj
```
