# Build the imagr from base image (Official node image of latest version)
FROM node:latest

# Provides metada like maintainer.
LABEL author="Adrita Sharma"

#RUN mkdir \app

# Create app directory where the code is going to reside inside Docker container 
#(All the commands are run from this directory - this is treated as the root directory )
WORKDIR /app

COPY package.json /app

# Install app dependencies
RUN npm install

# Copy local files into container Working directory (/app)
COPY . /app

# Execute app

# Option 1 (Ececute this command directly)
#CMD node index.js

# Option 2 (Add 'start' script in package.json and make this as Entrypoint)

# When container gets started up, Entrypoint fire ups the container
ENTRYPOINT ["npm" , "start"]


EXPOSE 8081


# Instructions

# Build Command - It creates the image that can be view under Images in Docker Desktop
    # docker build -t test2/node .

# Run Command - It runs the image.(Creates a container) We can see it under Containers/Apps in Docker Desktop
 # If we browse 8081, it should route to 3000 within the container 
    # docker run -p  8081:3000 test2/node