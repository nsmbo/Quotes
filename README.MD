docker build /src -t markbovee/quotes:0.1.0

helm repo index quotes --url https://github.com/nsmbo/Quotes

helm repo add https://github.com/nsmbo/Quotes/charts
helm install quotes quotes