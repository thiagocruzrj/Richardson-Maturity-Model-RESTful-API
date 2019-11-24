FROM microsoft/aspnetcore:2.0-stretch AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-stretch AS build
WORKDIR /src
COPY ["LibraryApi/RestWithASPNETUdemy.csproj", "LibraryApi/"]
RUN dotnet restore "LibraryApi/RestWithASPNETUdemy.csproj"
COPY . .
WORKDIR "/src/LibraryApi"
RUN dotnet build "RestWithASPNETUdemy.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RestWithASPNETUdemy.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RestWithASPNETUdemy.dll"]