// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/publish.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcAgent {
  public static partial class Publisher
  {
    static readonly string __ServiceName = "GrpcAgent.Publisher";

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

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

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

    static readonly grpc::Marshaller<global::GrpcAgent.PublishRequest> __Marshaller_GrpcAgent_PublishRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcAgent.PublishRequest.Parser));
    static readonly grpc::Marshaller<global::GrpcAgent.PublishReply> __Marshaller_GrpcAgent_PublishReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcAgent.PublishReply.Parser));

    static readonly grpc::Method<global::GrpcAgent.PublishRequest, global::GrpcAgent.PublishReply> __Method_PublishMessage = new grpc::Method<global::GrpcAgent.PublishRequest, global::GrpcAgent.PublishReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "PublishMessage",
        __Marshaller_GrpcAgent_PublishRequest,
        __Marshaller_GrpcAgent_PublishReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcAgent.PublishReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Publisher</summary>
    [grpc::BindServiceMethod(typeof(Publisher), "BindService")]
    public abstract partial class PublisherBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcAgent.PublishReply> PublishMessage(global::GrpcAgent.PublishRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Publisher</summary>
    public partial class PublisherClient : grpc::ClientBase<PublisherClient>
    {
      /// <summary>Creates a new client for Publisher</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public PublisherClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Publisher that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public PublisherClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected PublisherClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected PublisherClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GrpcAgent.PublishReply PublishMessage(global::GrpcAgent.PublishRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PublishMessage(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcAgent.PublishReply PublishMessage(global::GrpcAgent.PublishRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_PublishMessage, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcAgent.PublishReply> PublishMessageAsync(global::GrpcAgent.PublishRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PublishMessageAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcAgent.PublishReply> PublishMessageAsync(global::GrpcAgent.PublishRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_PublishMessage, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override PublisherClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PublisherClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PublisherBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_PublishMessage, serviceImpl.PublishMessage).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PublisherBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_PublishMessage, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcAgent.PublishRequest, global::GrpcAgent.PublishReply>(serviceImpl.PublishMessage));
    }

  }
}
#endregion
