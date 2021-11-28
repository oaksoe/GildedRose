### Project setup
- Download .NET 5.0 from https://dotnet.microsoft.com/download and install
- Check .NET version in the terminal
```
dotnet --version
```
- Create a root folder called 'GildedRose'
- Create C# solution file inside the root folder
```
dotnet new sln
```
- Create C# project inside the root folder
```
dotnet new console -o app
```
- Create C# test project inside the root folder  
```
dotnet new mstest -o appTest
```
- Add the projects to solution file
```
dotnet sln add app/app.csproj
dotnet sln add appTest/appTest.csproj
```
- Add app project reference to appTest project
```
dotnet add appTest/appTest.csproj reference app/app.csproj
```

### Run the app
```
cd app
dotnet run
```

### Test the app
```
cd appTest
dotnet test appTest.csproj
```