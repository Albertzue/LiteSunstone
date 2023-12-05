FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
EXPOSE 80
COPY  ./publish .
ENV DB_CONNECTION=mongodb://localhost:27017
ENTRYPOINT ["dotnet","LiteSunstone.Api.dll"]

