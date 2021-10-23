# Basic tutorial for ASP.NET Core

## Docker commands

- We use the this repo's API project instead https://github.com/charlehsin/net5-webapi-tutorial. 
   - Because it is not easy to generate and trust dev TLS cert, we disabled HTTPS though. Check Program.cs and Startup.cs
   - We did not use the following since there are many problems to Entity framework migration on databse.
      - (Use .NET CLI to get default MVC app. Run this in app folder.) docker run -v ${PWD}:/app --workdir /app mcr.microsoft.com/dotnet/sdk:5.0 dotnet new mvc --auth Individual
- Befor running the following change the line break style for entrypoint.sh from CRLF to LF first.
   - (Run this in app folder.) docker-compose build
   - (Run this in app folder.) docker-compose up

## References

- https://docs.docker.com/samples/dotnetcore/
- https://github.com/docker/labs/tree/master/windows
- https://docs.docker.com/samples/aspnet-mssql-compose/
