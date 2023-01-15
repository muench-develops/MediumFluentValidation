FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MediumFluentValidation/MediumFluentValidation.csproj", "MediumFluentValidation/"]
RUN dotnet restore "MediumFluentValidation/MediumFluentValidation.csproj"
COPY . .
WORKDIR "/src/MediumFluentValidation"
RUN dotnet build "MediumFluentValidation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MediumFluentValidation.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MediumFluentValidation.dll"]
