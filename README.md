# GRPC: Google Remote Procedure Call

- Used to do effective microservice communication.
-  One of the RPC frameworks developed by Google.
-  Similar to invoking functions in a method, but from the server.
-  Uses HTTP/2 as transport, advanced than HTTP/1.1.
-  Rest API uses HTTP/1.1.
-  Transfers data in binary format, known as Protobuf.
-  HTTP/2 allows binary data like Audio, video, and images, which can't be sent over XML or JSON.
-  In HTTP/1.1 we cannot have real-time data, and we cannot push data from the server (Eg: Push Notification)
-  For Eg: CricBuzz & Grow have real-time data using Websockets, which does not work on http/1.1.
-  In HTTP/1.1 client has to always request data from the server. The server cannot push data to the client.
-  GRPC is not understandable by the web browser, so can't directly be called from the browser. As the browser only understands XML or JSON.

## GRPC Servers
- Listens for incoming requests.
- Implements business logic for gRPC services.
- Sends responses back to GRPC clients.

## GRPC Stub (Client)
- Generates and sends requests to the GRPC server.
- Deserializes and processes responses from GRPC servers.
- Usually, the Stub is implemented on a web server that also hosts REST API.

## Protobuf
- Google's representation to serialize structured data that is language neutral.
- Protobuf (.proto file) is a contract shared between the [GRPC server](grpc.server/grpc.server/Protos/person.proto) and the [GRPC stub](grpc.client/grpc.client/Protos/person.proto) for code generation in the respective programming language.
