# Tutorial for Docker and ASP.NET Core

## Overview

- General tutorial
   - https://docs.docker.com/samples/dotnetcore/
   - https://github.com/docker/labs/tree/master/windows
   - We use the this repo's API project https://github.com/charlehsin/net5-webapi-tutorial. 
      - Because it is not easy to generate and trust dev TLS cert in Linux, we disabled HTTPS in that API project.
      - We did not use the following since there are many problems to Entity framework migration on databse.
         - (Use .NET CLI to get default MVC app. Run this in app folder.) docker run -v ${PWD}:/app --workdir /app mcr.microsoft.com/dotnet/sdk:5.0 dotnet new mvc --auth Individual
- Docker compose with 2 containers
   - https://docs.docker.com/samples/aspnet-mssql-compose/
- Run the docker images
   - Befor running the following change the line break style for entrypoint.sh from CRLF to LF first.
   - (Run this in app folder.) docker-compose build
   - (Run this in app folder.) docker-compose up




