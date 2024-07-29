# CPW211 - EntityFrameworkQueries

## Getting started
- VS 2024
- .NET 8
- [AP Database](create_ap.sql) installed

  you may need to change the DB connection string located in the ApContext class
  By default it points to mssqllocaldb. if your AP script is not installed on mssqllocaldb, update on string.
  ```csharp
  optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AP");
  ```
