#Define image for BUILD: https://hub.docker.com/_/microsoft-dotnet-sdk/
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
#Define working directory
WORKDIR /src
#Copy all files
COPY . .
#Restore dependencies
RUN dotnet restore "HelloAspNetCore.csproj"
#Build prject
RUN dotnet build "HelloAspNetCore.csproj" -c Release -o /app/build
#Publish project
RUN dotnet publish "HelloAspNetCore.csproj" -c Release -o /app/publish
 
 
#Define base image for RUNTIME: https://hub.docker.com/_/microsoft-dotnet-aspnet
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS deployment
#Define working directory
WORKDIR /app
#Define ports to expose
EXPOSE 80
EXPOSE 443
#Copy files from "build" app/publish directory to current working directory (app)
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet","HelloAspNetCore.dll"]
