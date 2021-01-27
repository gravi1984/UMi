#### use docker run mssql on mac/linux

1. pull docker mssql inmage
    *  ```docker pull microsoft/mssql-server-linux```
    * ```docker images ```
2. run the image
    * ```docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD={pwd}' -p 1433:1433 -d microsoft/mssql-server-linux```
    * ```docker ps``` 
3. test local db connection to local:1433 with login set above


#### apply EF in project
1. install package EF core; {EF core.SqlServer}
2. create Database/AppDbContext.cs: Model <- Bridger -> Db
3. inject service; configure conn string
4. add Db notation in Models for validation
5. install EF tool, and relevant
6. init migrations, update it { db|model|code first(context) }
* ```
  dotnet tool install --global dotnet-ef --version 3.1.4
  dotnet ef migrations add initialMigration --project Umi.API
  dotnet ef database update -p Umi.API
  ```

