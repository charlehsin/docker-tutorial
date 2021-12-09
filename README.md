# Tutorial for Docker

## Installation

Check [Installation guide](https://docs.docker.com/desktop/windows/install/)

1. Run "sysinfo". Check 4 "Hyper-V" items. On my system, they are all enabled. You may need to go to BIOS to enable virtualization.
1. Follow [WSL install](https://docs.microsoft.com/en-us/windows/wsl/install)
1. Follow [Checking virtualization](https://docs.docker.com/desktop/windows/troubleshoot/#virtualization-must-be-enabled)

## Overview

1. [General](https://docs.docker.com/)
1. Guide
   1. [Basic](https://docs.microsoft.com/en-us/learn/modules/intro-to-docker-containers/)
   1. [Develop using Docker](https://docs.docker.com/develop/)
   1. [Set up CI/CD](https://docs.docker.com/ci-cd/best-practices/)
   1. [Deploy app to the cloud](https://docs.docker.com/cloud/aci-integration/)
   1. [Azure container instance](https://azure.microsoft.com/en-us/services/container-instances/#overview)
   1. [Docker Swarm Mode](https://docs.docker.com/engine/swarm/)
   1. [Docker networking](https://docs.docker.com/network/)
   1. [Manage application data](https://docs.docker.com/storage/)
   1. [Samples](https://docs.docker.com/samples/#tutorial-labs)
   1. [12 factor application](https://github.com/docker/labs/tree/master/12factor)
1. Getting started guide: getting-started-from-docker folder.
1. ASP NET Core guide: asp-net-core-basic folder.
1. The GitHub Actions workflow is at .github\workflows folder.
1. The "getting started" on Kubernetes is at kubernetes folder.
1. The "getting started" on Docker Swarm is at swarm folder.
1. The "security lab" is at security folder.
1. The "Go development environment" is at go-dev-env folder.
1. The "getting started" on Helm is at helm folder.

## Useful Visual Studio Code extensions

- [Docker extension](https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-docker)

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