#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-sac2016 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk-nanoserver-sac2016 AS build
WORKDIR /src
COPY ["SB.Product.API/SB.Product.API.csproj", "SB.Product.API/"]
RUN dotnet restore "SB.Product.API/SB.Product.API.csproj"
COPY . .
WORKDIR "/src/SB.Product.API"
RUN dotnet build "SB.Product.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "SB.Product.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SB.Product.API.dll"]