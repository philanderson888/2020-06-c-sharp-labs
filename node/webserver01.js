// use a library http
var http = require('http')
var port = 8080;

console.log('HTTP Web Server')

http.createServer( (request, response) => {
    console.log('HTTP Request received')
    response.writeHead(200, {'Content-Type' : 'text/html' })
    response.end('<p>HTML code sent to a <strong>web page</strong>')
}).listen(port,'127.0.0.1');

console.log('Server listening on port ' + port);
