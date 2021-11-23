# Docker security

This is to follow https://github.com/docker/labs/blob/master/security/README.md

## Distribution and Trust

This is to follow https://github.com/docker/labs/blob/master/security/trust/README.md and https://github.com/docker/labs/blob/master/security/trust-basics/README.md.

Docker commands:
- Pulling image by tag
   - docker pull alpine:edge
   - docker images
   - docker run --rm -it alpine:edge sh
- Pulling image by digest
   - docker pull alpine@sha256:b7233dafbed64e3738630b69382a8b231726aa1014ccaabc1947c5308a8910a7
   - docker images --digests alpine
- Docker Content Trust
   - (Linux environment variable) export DOCKER_CONTENT_TRUST=1
   - docker pull riyaz/dockercon:trust
   - docker pull riyaz/dockercon:untrusted
   - docker tag alpine:edge charlehsin/alpine:trusted
   - docker push charlehsin/alpine:trusted
   - (Linux environment variable) export DOCKER_CONTENT_TRUST=0
   - docker pull charlehsin/alpine:trusted

## Secrets

This is to follow https://github.com/docker/labs/blob/master/security/secrets/README.md and https://github.com/docker/labs/blob/master/security/secrets-ddc/README.md.

## Secure networking

This is to follow https://github.com/docker/labs/blob/master/security/networking/README.md.

## Security scanning

This is to follow https://github.com/docker/labs/blob/master/security/scanning/README.md.

Docker commands:
- docker image pull alpine:edge
- docker image ls
- docker image tag alpine:edge charlehsin/scan:v1
- docker login
- docker image push charlehsin/scan:v1
- docker image rm alpine:edge
- docker image rm charlehsin/scan:v1

## Swarm mode security

This is to follow https://github.com/docker/labs/blob/master/security/swarm/README.md.