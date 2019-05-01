FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-stretch AS build
WORKDIR /src
COPY ["BlazorSentimentAnalysis.Server/BlazorSentimentAnalysis.Server.csproj", "BlazorSentimentAnalysis.Server/"]
COPY ["BlazorSentimentAnalysis.Client/BlazorSentimentAnalysis.Client.csproj", "BlazorSentimentAnalysis.Client/"]
RUN dotnet restore "BlazorSentimentAnalysis.Server/BlazorSentimentAnalysis.Server.csproj"
COPY . .
WORKDIR "/src/BlazorSentimentAnalysis.Server"
RUN dotnet build "BlazorSentimentAnalysis.Server.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "BlazorSentimentAnalysis.Server.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "BlazorSentimentAnalysis.Server.dll"]