docker build src -t markbovee/quotes:0.1.3
docker push markbovee/quotes:0.1.3

helm package quotes
helm repo index quotes/ --url https://nsmbo.github.io/

helm repo add nsmbo https://nsmbo.github.io/

helm install quotes nsmbo/quotes --namespace quotes --create-namespace
helm install argo-cd nsmbo/quotes --namespace argo-cd  --create-namespace