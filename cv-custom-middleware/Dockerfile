FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-stage
WORKDIR /api
COPY . .
RUN dotnet publish -o /publish

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime-stage
WORKDIR /publish
COPY --from=build-stage /publish .
# ENV ASPNETCORE_URLS http://localhost:80
ENTRYPOINT [ "dotnet","cv-custom-middleware.dll" ]
