# Getting started tutorial for Helm

## Basic overview

1. [Helm tutorial videos](https://jfrog.com/blog/10-helm-tutorials-to-start-your-kubernetes-journey/)
2. [Bitnami tutorial](https://docs.bitnami.com/tutorials/create-your-first-helm-chart/)
3. [Helm documentation](https://helm.sh/docs/)

## Basic Helm commands in Bitnami tutorial

1. (Create the default Helm chart structure.) helm create mychart
2. (Just return the resulting manifest file without installing.) helm install --dry-run --debug ./mychart --generate-name
3. (Set the targe field.) helm install --dry-run --debug ./mychart --generate-name --set service.port=8080
4. (Deploy.) helm install example ./mychart --set service.type=NodePort
5. (List all Helm deployment in all namespaces.) helm list --all-namespaces
6. (Use Linter to check chats.) helm lint ./mychart
7. (Uninstall.) helm uninstall example --namespace default
8. (Package.) helm package ./mychart
9. (Deploy using a package.) helm install example3 mychart-0.1.0.tgz --set service.type=NodePort
10. (Update dependencies for any change in requirements.yaml. The dependencies are defined at Chart.yaml, instead of requirements.yaml in Helm 3.) helm dep update ./mychart

## Basic Helm commands in Helm documentation

1. (Add a repo.) helm repo add bitnami https://charts.bitnami.com/bitnami
2. (Search chat in the repo.) helm search repo bitnami
3. (Update info for the repo.) helm repo update
4. (Deploy using a existing chart on the repo.) helm install bitnami/mysql --generate-name
5. (Show my releases.) helm list
6. (Uninstall a release.) helm uninstall mysql-1639437912