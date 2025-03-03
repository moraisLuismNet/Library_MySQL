## Library_MySQL
ASP.NET Core Web API Biblioteca

![Library](img/1.png)
![Library](img/2.png)


## Program
``` 
var connectionString = builder.Configuration.GetConnectionString("Connection");
builder.Services.AddDbContext<LibraryContext>(options =>
{
    options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 31)));
});
``` 

## appsetting.Development.json
``` 
{
  "ConnectionStrings": {
        "Connection": "Server=localhost;Port=3306;Database=library;User=root;Password=root"
}
``` 