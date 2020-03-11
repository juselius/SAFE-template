FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-alpine
EXPOSE 8085
COPY deploy/ /app
COPY scripts/entrypoint.sh /
CMD /entrypoint.sh

