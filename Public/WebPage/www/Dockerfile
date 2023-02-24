FROM node:16.18 AS build
WORKDIR /src
COPY . .
RUN npm install --registry=https://registry.npm.taobao.org
RUN npm run build
FROM nginx:1.23.3
WORKDIR /app
COPY --from=build /src/dist /usr/share/nginx/html/