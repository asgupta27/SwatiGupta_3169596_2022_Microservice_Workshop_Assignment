#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.


FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app
Copy /NotificationAPI ./
Copy /EventBus.Message ./
EXPOSE 80

RUN dotnet restore "./NotificationAPI.csproj"
RUN dotnet publish "./NotificationAPI.csproj" -c Release -o /out

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS final

EXPOSE 80

WORKDIR /app
COPY --from=build /out /app

ENTRYPOINT ["dotnet", "NotificationAPI.dll"]