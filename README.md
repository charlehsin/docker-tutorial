# Tutorial for Docker

## Installation

- [Installation guide](https://docs.docker.com/desktop/windows/install/)
   - Run "sysinfo". Check 4 "Hyper-V" items. On my system, they are all enabled. You may need to go to BIOS to enable virtualization.
   - Follow https://docs.microsoft.com/en-us/windows/wsl/install
   - Follow https://docs.docker.com/desktop/windows/troubleshoot/#virtualization-must-be-enabled 

## Overview

- [General](https://docs.docker.com/) 
- Guide
   - [Basic](https://docs.microsoft.com/en-us/learn/modules/intro-to-docker-containers/)
   - [Develop using Docker](https://docs.docker.com/develop/)
   - [Set up CI/CD](https://docs.docker.com/ci-cd/best-practices/)
   - [Deploy app to the cloud](https://docs.docker.com/cloud/aci-integration/)
      - [Azure container instance](https://azure.microsoft.com/en-us/services/container-instances/#overview)
   - [Run app in production](https://docs.docker.com/get-started/orchestration/)
   - [Samples](https://docs.docker.com/samples/#tutorial-labs)
- Getting started guide: getting-started-from-docker folder.
- ASP NET Core guide: asp-net-core-basic folder.
- The GitHub Actions workflow is at  .github\workflows folder.

## Useful Visual Studio Code extensions

- https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-docker 

## Useful docker commands

- docker build -t getting-started .
- docker run -dp 3000:3000 getting-started
- docker ps
- docker stop <the-container-id>
- docker rm <the-container-id>
- docker login -u YOUR-USER-NAME
- docker tag getting-started YOUR-USER-NAME/getting-started
- docker push YOUR-USER-NAME/getting-started
- docker volume create todo-db
- docker run -dp 3000:3000 -v todo-db:/etc/todos getting-started
- docker volume inspect todo-db
- docker network create todo-app
- docker logs <container-id>