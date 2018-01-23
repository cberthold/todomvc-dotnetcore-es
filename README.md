# A simple Todo list implementation using ASP.NET Core Web API with SQLite persistence. Frontend is using Vue2, Vuex.

This was forked from https://github.com/hoandang/todomvc-dotnetcore

The intention is to use this as a quick spot to train others on the basics of DDD and Event Sourcing concepts using
a working application and replacing functionality with an aggregate TodoList

### Build Frontend
- npm run build

### Build Backend
- dotnet restore
- dotnet build
- dotnet run
- the api exposes at http://localhost:5000/api/todo

### Dev Backend
- dotnet run watch

### Dev Frontend
- npm run dev
