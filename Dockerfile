FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY . .

FROM build AS publish
RUN dotnet publish "Put387" -c Release -o /app
FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ADD ./img ./img

ENTRYPOINT ["dotnet", "Put387.dll"] 