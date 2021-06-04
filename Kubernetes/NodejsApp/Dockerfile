FROM node:latest as debug

WORKDIR /work/

COPY ./src/package.json /work/package.json
RUN npm install
RUN npm install -g nodemon

COPY ./src/ /work/src/

ENTRYPOINT [ "nodemon","--inspect=0.0.0.0","./src/server.js" ]

FROM node:latest as prod

WORKDIR /work/
COPY ./src/package.json /work/package.json
RUN npm install
COPY ./src/ /work/

CMD node .


## INSTRUCTIONS

#kubectl get nodes

#kubectl create ns example-app

#kubectl get ns

#kubectl apply -n example-app -f .\deployment\deployment.yml


#kubectl -n example-app get pods
# Output:
# example-deploy-5b4cf787b-lf7ld   1/1     Running   0          39s
# example-deploy-5b4cf787b-lp6b9   1/1     Running   0          39s

# -> We have 2 pods as we mentioned 2 replicas in deployment.yml

# kubectl -n example-app logs example-deploy-5b4cf787b-lf7ld
# Output:
# Running on http://0.0.0.0:5000

# -> Running in 5000 as we mentioned containerPort as 5000 in deployment.yml


# -> Create Service ( A load balancer between this pods) - service.yml is created
# -> In the service we point the label to that od the deployment label (here : example-app)
# -> We expose the service to port 80. It will load balance the 2 pods on targetPort 5000
# -> This allows to runn all in a single port 80
# -> The service is type of ClusterIP. I means thsis will be only accesible internally for other pods running inside kubernetes cluster
#-> Therefore we will port forward

### Create Service
# kubectl apply -n example-app -f .\deployment\service.yml

# kubectl -n example-app get svc
# Output:
# NAME              TYPE        CLUSTER-IP     EXTERNAL-IP   PORT(S)   AGE
# example-service   ClusterIP   10.109.52.12   <none>        80/TCP    80s

#-> It shows it is an internal IP
#-> Therefore we have to ise port forward command to test our services

# kubectl -n example-app port-forward example-deploy-5b4cf787b-lf7ld 5000