FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

COPY ["BlazorUI/BlazorUI.App/BlazorUI.App.csproj", "BlazorUI/BlazorUI.App/"]
RUN dotnet restore "BlazorUI/BlazorUI.App/BlazorUI.App.csproj"
COPY . .

WORKDIR "/src/BlazorUI/BlazorUI.App"
RUN dotnet build "BlazorUI.App.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlazorUI.App.csproj" -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/wwwroot .
COPY ["BlazorUI/BlazorUI.App/nginx.conf", "/etc/nginx/nginx.conf"]
EXPOSE 80