FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
EXPOSE 5000
EXPOSE 443
COPY  ./publish .
ENTRYPOINT ["dotnet","LiteSunstone.Api.dll","--urls=http://*:5000"]

