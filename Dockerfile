FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /app
COPY *.csproj ./
RUN dotnet restore
RUN dotnet publish -c Release -o out
ENTRYPOINT [ “dotnet”, “Investimentos.API.dll”]
