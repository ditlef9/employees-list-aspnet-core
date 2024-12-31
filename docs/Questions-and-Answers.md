# Question and Answers

## Index

[1. Understanding Key Components of ASP.NET Core](#-1-howto-run-locally)<br>
[2. Quick Overview of HTTP and Web Servers  ](#%EF%B8%8F-2-howto-deploy-to-azure)<br>
[3. Simple Overview of Middleware in ASP.NET Core](#%EF%B8%8F-3-how-i-created-the-application)<br>
[4. Basics of Routing and wwwroot in ASP.NET Core](#-4-license)<br>
[5. Model Binding and Validation in ASP.NET Core](#-4-license)<br>


## 1. Understanding Key Components of ASP.NET Core

**1. What is Kestrel and what are advantages of Kestrel in Asp.Net Core?**<br>
Kestrel is a cross-platform, lightweight web server that comes built into ASP.NET Core. 
It is highly performant and supports features like HTTPS, WebSockets, and HTTP/2. 
Kestrel excels in scenarios requiring high-speed communication, 
especially for modern microservices and cloud applications.

**2. What is the difference between IIS and Kestrel? Why do we need two web servers?**<br>
IIS is a full-featured web server for hosting and managing web applications on Windows, 
while Kestrel is a lightweight server optimized for performance. They are often used together, 
where IIS acts as a reverse proxy for better security, scalability, and integration with Windows features.

**3. What is the purpose of launchSettings.json in ASP.NET Core?**<br>
The launchSettings.json file defines how an ASP.NET Core application is launched, 
specifying profiles for different environments, ports, and hosting settings. 
It simplifies development by enabling seamless configuration for local debugging and testing.

**4. What is generic host or HostBuilder in .NET Core?**<br>
The generic host (HostBuilder) is a foundational framework in .NET Core for 
configuring and running applications. It manages application lifecycle events and 
supports dependency injection, logging, and configuration setup, 
making it ideal for web and non-web apps alike.

**5. What is the purpose of the .csproj file?**<br>
The .csproj file is an XML-based project file that defines the build and 
configuration settings of a .NET project, including dependencies, framework versions, 
and compilation instructions. It serves as the backbone for managing the project structure.

**6. What is IIS?**<br>
Internet Information Services (IIS) is Microsoft’s web server used to host 
websites and web applications on Windows. It provides robust features such as request handling, 
load balancing, and security enhancements, ideal for enterprise-grade applications.

**7. What is the “Startup” class in ASP.NET Core prior to Asp.Net Core 6?**<br>
The Startup class is the entry point for configuring an ASP.NET Core application. 
It includes methods like ConfigureServices for registering services and 
Configure for defining the middleware pipeline.

**8. What does WebApplication.CreateBuilder() do?**<br>
WebApplication.CreateBuilder() initializes a new instance of a WebApplicationBuilder in ASP.NET Core, 
setting up default configurations, services, and middleware for creating and running modern web applications.



## 2. Quick Overview of HTTP and Web Servers  

**1. What is HTTP?**  
HTTP (HyperText Transfer Protocol) is a stateless protocol used to transfer data such as HTML, 
images, and multimedia between web servers and clients. 
It underpins how browsers and web applications communicate over the internet.  

**2. What is the format of a Request Message?**  
An HTTP request message has three parts: the request line (e.g., `GET / HTTP/1.1`), 
headers for metadata (e.g., `Host: example.com`), and an optional body for data (used in methods like POST).  

**3. What are the important HTTP methods (or HTTP verbs)?**  
HTTP methods define actions on resources: **GET** retrieves data, 
**POST** submits data, **PUT** updates or creates a resource, 
**PATCH** modifies parts of a resource, **DELETE** removes a resource, 
and **HEAD** fetches headers without a body.  

**4. What are the important HTTP status codes?**  
Status codes indicate request results: **2xx** for success (e.g., 200 OK), 
**3xx** for redirection (e.g., 301 Moved Permanently), 
**4xx** for client errors (e.g., 404 Not Found), and 
**5xx** for server errors (e.g., 500 Internal Server Error).  

**5. What is Content Negotiation in HTTP?**  
Content negotiation allows a client and server to agree on the format of the response 
(e.g., JSON, XML) based on headers like `Accept` and `Accept-Language`, 
enhancing flexibility in data exchange.  

**6. Explain how HTTP protocol works?**  
HTTP works by sending a request from the client to the server over TCP, 
specifying a resource and method. The server processes the request and responds with a status code, 
headers, and optionally the resource or data.  

**7. What is a web server?**  
A web server processes client requests and serves web content, such as HTML pages and APIs, 
using HTTP or HTTPS protocols. Examples include Apache, Nginx, and IIS, powering websites and web apps.  


## 3. Simple Overview of Middleware in ASP.NET Core

**1. What is middleware?**<br>
Middleware is code that handles requests and responses in an ASP.NET Core app. 
It runs in a pipeline, where each piece can modify the data or pass it to the next step.

**2. What is the difference between IApplicationBuilder.Use() and IApplicationBuilder.Run()?**<br>
Use() adds middleware and passes the request to the next step, 
while Run() stops the pipeline and handles the request fully.

**3. What is the use of the "Map" extension while adding middleware?**<br>
The Map extension splits the pipeline based on the request path, 
so you can run specific code for certain routes.

**4. How do you create a custom middleware?**<br>
To make custom middleware, write a class with an Invoke method to process requests. 
Add it to the pipeline using UseMiddleware<ClassName>().

**5. What is the right order of middleware in production?**<br>
Start with error handling, then add security (like authentication), routing, 
and finally your app logic to keep things working smoothly.

## 4. Basics of Routing and wwwroot in ASP.NET Core

**1. What is Routing?**<br>
Routing is the process of mapping a URL to a specific action in a controller or 
endpoint in an ASP.NET Core application, enabling dynamic navigation and request handling.

**2. How Routing works in ASP.NET Core?**<br>
Routing works by defining templates or patterns in controllers or endpoints. 
When a request is received, the routing system matches the URL to these 
patterns and directs it to the correct action or middleware.

**3. What are the important route constraints?**<br>
Route constraints ensure URLs match specific rules. Common ones include {int} for integers, 
{guid} for GUIDs, {minlength} for string length, and {regex} for custom patterns.

**4. What is the purpose of the wwwroot folder?**<br>
The wwwroot folder is the default location for serving static files like CSS, JavaScript, 
and images in an ASP.NET Core application.

**5. How do you change the path of the wwwroot folder?**<br>
To change the wwwroot folder path, modify the WebHostDefaults.WebRootKey property in the 
CreateBuilder() method or use UseWebRoot("NewPath") in the application setup.

## 5. Quick Answers for ASP.NET Core

**1. What is a Controller?**<br>
A Controller is a class that handles incoming HTTP requests, 
interacts with data (via models), and returns responses (HTML, JSON, etc.).

**2. What is an Action Method?**<br>
An Action Method is a public method in a Controller that executes in response to a request. 
It returns data or views to the client.

**3. Types of Action Results in ASP.NET Core**<br>

* ViewResult: Renders HTML.
* JsonResult: Returns JSON data.
* RedirectResult: Redirects to another URL or action.
* ContentResult: Sends plain text content.

**4. What’s HttpContext?**<br>

HttpContext represents the current request and response, including headers, cookies, session, and user info.

Access in Controller:

```var userAgent = HttpContext.Request.Headers["User-Agent"];```

## 6. Model Binding and Validation in ASP.NET Core



**1. What is model binding in ASP.NET CORE?**<br>

Model Binding in ASP.NET Core automatically maps incoming HTTP request data (e.g., query strings, form fields, route values, or JSON payload) to method parameters or properties of a model. This simplifies handling user input in controllers or Razor Pages.


**2. How Validation Works in ASP.NET Core MVC and How It Follows the DRY Principle?**<br>

(Don’t Repeat Yourself)

Validation ensures that the data submitted by users is correct and complete before being processed. ASP.NET Core uses Data Annotations for validation, which are attributes applied to model properties.


```
public IActionResult Details(int id) // "id" comes from the request (?id=5)
{
    var product = _service.GetById(id);
    return View(product);
}
```


Validation uses Data Annotations like [Required] and [Range] on model properties.

Example:

```[Required]
public string Name { get; set; }
[Range(1, 100)]
public int Quantity { get; set; }```


* Server-side: Validation runs automatically in controllers.
* Client-side: ASP.NET Core generates JavaScript to enforce rules in forms.

Follows DRY: Rules are defined once in the model and applied on both client and server automatically.


## 7. Razor Views

