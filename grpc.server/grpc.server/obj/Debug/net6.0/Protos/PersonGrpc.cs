// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/person.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace grpc.server.Protos {
  public static partial class PersonService
  {
    static readonly string __ServiceName = "PersonService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::grpc.server.Protos.PersonRequest> __Marshaller_PersonRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::grpc.server.Protos.PersonRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::grpc.server.Protos.PersonResponse> __Marshaller_PersonResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::grpc.server.Protos.PersonResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::grpc.server.Protos.PersonPaginationRequest> __Marshaller_PersonPaginationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::grpc.server.Protos.PersonPaginationRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::grpc.server.Protos.PersonRequest, global::grpc.server.Protos.PersonResponse> __Method_AddPerson = new grpc::Method<global::grpc.server.Protos.PersonRequest, global::grpc.server.Protos.PersonResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddPerson",
        __Marshaller_PersonRequest,
        __Marshaller_PersonResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::grpc.server.Protos.PersonPaginationRequest, global::grpc.server.Protos.PersonResponse> __Method_GetPersons = new grpc::Method<global::grpc.server.Protos.PersonPaginationRequest, global::grpc.server.Protos.PersonResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetPersons",
        __Marshaller_PersonPaginationRequest,
        __Marshaller_PersonResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::grpc.server.Protos.PersonReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PersonService</summary>
    [grpc::BindServiceMethod(typeof(PersonService), "BindService")]
    public abstract partial class PersonServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::grpc.server.Protos.PersonResponse> AddPerson(global::grpc.server.Protos.PersonRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task GetPersons(global::grpc.server.Protos.PersonPaginationRequest request, grpc::IServerStreamWriter<global::grpc.server.Protos.PersonResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(PersonServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AddPerson, serviceImpl.AddPerson)
          .AddMethod(__Method_GetPersons, serviceImpl.GetPersons).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PersonServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AddPerson, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::grpc.server.Protos.PersonRequest, global::grpc.server.Protos.PersonResponse>(serviceImpl.AddPerson));
      serviceBinder.AddMethod(__Method_GetPersons, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::grpc.server.Protos.PersonPaginationRequest, global::grpc.server.Protos.PersonResponse>(serviceImpl.GetPersons));
    }

  }
}
#endregion
