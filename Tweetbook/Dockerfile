FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
COPY ["Tweetbook.csproj", "/build/"]
RUN dotnet restore "./build/Tweetbook.csproj"

COPY . ./build/

FROM build AS publish
WORKDIR /build/
RUN dotnet publish "./Tweetbook.csproj" -c Release -o out

FROM base AS final
WORKDIR /app
COPY --from=publish /build/out .
ENTRYPOINT ["dotnet", "Tweetbook.dll"]