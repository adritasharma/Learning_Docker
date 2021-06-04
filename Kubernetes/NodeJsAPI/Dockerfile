FROM node:latest
LABEL author="Adrita Sharma"
WORKDIR /app

COPY package.json /app
RUN npm install
COPY . /app

ENTRYPOINT ["npm" , "start"]



# Instructions

# kubectl get nodes

##Create Namespace:
# kubectl create ns demo-app

## Create Deployment
# kubectl apply -n demo-app -f .\deployment\deployment.yml

## View Namespace:
#kubectl get ns

## View deployment:
#kubectl -n demo-app get deploy

## View pods:
#kubectl -n demo-app get pods

## Create Service
# kubectl apply -n demo-app -f .\deployment\service.yml# This service is




