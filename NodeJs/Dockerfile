FROM node:latest

LABEL author="Adrita Sharma"

ENV NODE_ENV=production
ENV PORT=3000

COPY . /var/www
WORKDIR /var/www

VOLUME [ "/var/www" ]

EXPOSE $PORT

ENTRYPOINT ["npm" , "start"]