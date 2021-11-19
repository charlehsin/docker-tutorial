# Getting started tutorial for Docker Swarm

## Basic overview

This is to follow https://docs.docker.com/get-started/orchestration/.

The Powershell commands:
- docker swarm init
- docker system info
- docker service create --name demo alpine:3.5 ping 8.8.8.8
- docker service ps demo
- docker service logs demo
- docker service rm demo

## Deploy to Swarm

This is to follow https://docs.docker.com/get-started/swarm-deploy/.

Try the following Powershell command first, as we will use this image in our deployment.
- docker run -d -p 30000:80 docker/getting-started

The Powershell commands:
- docker stack deploy -c bb-stack.yaml demo
- docker service ls
- docker stack rm demo