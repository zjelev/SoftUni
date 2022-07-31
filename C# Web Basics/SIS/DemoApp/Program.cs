// Actions
// / => IndexPage()
// /favicon.ico => favicon.ico
// GET /Contact => response ShowContactForm(request) 
// POST /Contact => response FillContactForm(request) 

using SIS.Http;

var httpServer = new HttpServer(80);
await httpServer.StartAsync();
