# backend

## Database

### Create Migrations

Got to to root of your backend folder ("packages/backend") and enter the following command into the terminal:  

`dotnet ef migrations add <name> --output-dir viden.Infrastructure/Migrations -s viden.Api -v`  
"-v" is to see more logs