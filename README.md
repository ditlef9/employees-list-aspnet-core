# Example Code ASP.NET Core

![Logo](docs/aspnet-core-logo.png)

## Index

[🏠 1 Howto run locally](#🏠-1-howto-run-locally)<br>
[☁️ 2 Howto deploy to Azure](#☁️-2-howto-deploy-to-azure)<br>
[🛠️ 3 How I created the application](#🛠️-4-how-i-created-the-application)<br>
[📜 4 License](#📜-4-license)<br>
[✅ 5 Question and Answers](✅-5-question-and-answers)

## 🏠 1 Howto run locally

1. Install Visual Studio Community: https://visualstudio.microsoft.com
2. In Visual Studio Code Install Workloads: `ASP.Net and Web Development`

Clone the repository and open it in Visual Studio Community.

**Set font size**<br>
I like to increase the font size from 10 to 11.

Tools > Options > Enviroment: Fonts and Colors<br>

* Size: 11



## ☁️ 2 Howto deploy to Azure


## 🛠️ 3 How I created the application

Visual Studio > New Project > Language: C# > Project Types: Web > `ASP.NET Core Empty`


## 📜 4 License

This project is licensed under the
[Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0).

```
Copyright 2024 github.com/ditlef9

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
```


## ✅ 5 Question and Answers

### Understanding Key Components of ASP.NET Core

**1. What is Kestrel and what are advantages of Kestrel in Asp.Net Core?**<br>
Kestrel is a cross-platform, lightweight web server that comes built into ASP.NET Core. It is highly performant and supports features like HTTPS, WebSockets, and HTTP/2. Kestrel excels in scenarios requiring high-speed communication, especially for modern microservices and cloud applications.

**2. What is the difference between IIS and Kestrel? Why do we need two web servers?**<br>
IIS is a full-featured web server for hosting and managing web applications on Windows, while Kestrel is a lightweight server optimized for performance. They are often used together, where IIS acts as a reverse proxy for better security, scalability, and integration with Windows features.

**3. What is the purpose of launchSettings.json in ASP.NET Core?**<br>
The launchSettings.json file defines how an ASP.NET Core application is launched, specifying profiles for different environments, ports, and hosting settings. It simplifies development by enabling seamless configuration for local debugging and testing.

**4. What is generic host or HostBuilder in .NET Core?**<br>
The generic host (HostBuilder) is a foundational framework in .NET Core for configuring and running applications. It manages application lifecycle events and supports dependency injection, logging, and configuration setup, making it ideal for web and non-web apps alike.

**5. What is the purpose of the .csproj file?**<br>
The .csproj file is an XML-based project file that defines the build and configuration settings of a .NET project, including dependencies, framework versions, and compilation instructions. It serves as the backbone for managing the project structure.

**6. What is IIS?**<br>
Internet Information Services (IIS) is Microsoft’s web server used to host websites and web applications on Windows. It provides robust features such as request handling, load balancing, and security enhancements, ideal for enterprise-grade applications.

**7. What is the “Startup” class in ASP.NET Core prior to Asp.Net Core 6?**<br>
The Startup class is the entry point for configuring an ASP.NET Core application. It includes methods like ConfigureServices for registering services and Configure for defining the middleware pipeline.

**8. What does WebApplication.CreateBuilder() do?**<br>
WebApplication.CreateBuilder() initializes a new instance of a WebApplicationBuilder in ASP.NET Core, setting up default configurations, services, and middleware for creating and running modern web applications.



### Quick Overview of HTTP and Web Servers  

**1. What is HTTP?**  
HTTP (HyperText Transfer Protocol) is a stateless protocol used to transfer data such as HTML, 
images, and multimedia between web servers and clients. 
It underpins how browsers and web applications communicate over the internet.  

**2. What is the format of a Request Message?**  
An HTTP request message has three parts: the request line (e.g., `GET / HTTP/1.1`), headers for metadata (e.g., `Host: example.com`), and an optional body for data (used in methods like POST).  

**3. What are the important HTTP methods (or HTTP verbs)?**  
HTTP methods define actions on resources: **GET** retrieves data, **POST** submits data, **PUT** updates or creates a resource, **PATCH** modifies parts of a resource, **DELETE** removes a resource, and **HEAD** fetches headers without a body.  

**4. What are the important HTTP status codes?**  
Status codes indicate request results: **2xx** for success (e.g., 200 OK), **3xx** for redirection (e.g., 301 Moved Permanently), **4xx** for client errors (e.g., 404 Not Found), and **5xx** for server errors (e.g., 500 Internal Server Error).  

**5. What is Content Negotiation in HTTP?**  
Content negotiation allows a client and server to agree on the format of the response (e.g., JSON, XML) based on headers like `Accept` and `Accept-Language`, enhancing flexibility in data exchange.  

**6. Explain how HTTP protocol works?**  
HTTP works by sending a request from the client to the server over TCP, specifying a resource and method. The server processes the request and responds with a status code, headers, and optionally the resource or data.  

**7. What is a web server?**  
A web server processes client requests and serves web content, such as HTML pages and APIs, using HTTP or HTTPS protocols. Examples include Apache, Nginx, and IIS, powering websites and web apps.  