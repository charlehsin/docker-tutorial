# Getting started tutorial for Kubernetes

## Basic overview

This is to follow https://docs.docker.com/get-started/orchestration/.

The Powershell commands:

- kubectl apply -f pod.yaml
- kubectl get pods
- kubectl logs demo
- kubectl delete -f pod.yaml

## Deploy to Kubernetes

This is to follow https://docs.docker.com/get-started/kube-deploy/.

Try the following Powershell command first, as we will use this image in our deployment.

- docker run -d -p 30000:80 docker/getting-started

The Powershell commands:

- kubectl apply -f bb.yaml
- kubectl get deployments
- kubectl get services
- kubectl delete -f bb.yaml