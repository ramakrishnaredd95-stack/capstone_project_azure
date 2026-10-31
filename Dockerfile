FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY *.sln .
COPY FlipkartApp.data/ FlipkartApp.data/
COPY FlipkartApp.business/ FlipkartApp.business/
COPY FlipkartApp.web/ FlipkartApp.web/

WORKDIR /src/FlipkartApp.web
RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 8080
ENTRYPOINT ["dotnet", "FlipkartApp.web.dll"]