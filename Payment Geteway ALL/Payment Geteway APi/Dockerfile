FROM node:16-alpine

ENV DEBIAN_FRONTEND=noninteractive

LABEL author="Tolfix" maintainer="support@tolfix.com"

RUN apk update && \
    apk upgrade && \
    apk add git

RUN npm install -g @types/node \
    && npm install -g typescript@4.3.5

WORKDIR /usr/src

COPY package*.json ./

RUN npm install --force

COPY . ./

RUN tsc -b

# Remove unused files
#RUN rm -r ./src && \
#    rm -r ./test

ENV JWT_ACCESS_TOKEN ""
ENV DEBUG "false"
ENV MONGO_URI ""
ENV DOMAIN ""
ENV HTTP_SCHEMA ""

ENV SESSION_SECRET ""
ENV PORT "8080"

ENV OSTICKET_URL ""
ENV OSTICKET_API_KEY ""

ENV SWISH_PAYEE_NUMBER ""

ENV PAYPAL_CLIENT_ID ""
ENV PAYPAL_CLIENT_SECRET ""

ENV STRIPE_SK_LIVE ""
ENV STRIPE_SK_PUBLIC ""
ENV STRIPE_WEBHOOK_SECRET ""

ENV PDF_TEMPLATE_URL ""

ENV PLUGINS "[]"

ENV WEBHOOK_SECRET ""

EXPOSE 8080

CMD [ "node", "./build/Main.js" ]
