// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/feegrant/v1beta1/query.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Cosmos.Feegrant.V1Beta1 {
  /// <summary>
  /// Query defines the gRPC querier service.
  /// </summary>
  public static partial class Query
  {
    static readonly string __ServiceName = "cosmos.feegrant.v1beta1.Query";

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
    static readonly grpc::Marshaller<global::Cosmos.Feegrant.V1Beta1.QueryAllowanceRequest> __Marshaller_cosmos_feegrant_v1beta1_QueryAllowanceRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Feegrant.V1Beta1.QueryAllowanceRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Feegrant.V1Beta1.QueryAllowanceResponse> __Marshaller_cosmos_feegrant_v1beta1_QueryAllowanceResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Feegrant.V1Beta1.QueryAllowanceResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Feegrant.V1Beta1.QueryAllowancesRequest> __Marshaller_cosmos_feegrant_v1beta1_QueryAllowancesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Feegrant.V1Beta1.QueryAllowancesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Feegrant.V1Beta1.QueryAllowancesResponse> __Marshaller_cosmos_feegrant_v1beta1_QueryAllowancesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Feegrant.V1Beta1.QueryAllowancesResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Cosmos.Feegrant.V1Beta1.QueryAllowanceRequest, global::Cosmos.Feegrant.V1Beta1.QueryAllowanceResponse> __Method_Allowance = new grpc::Method<global::Cosmos.Feegrant.V1Beta1.QueryAllowanceRequest, global::Cosmos.Feegrant.V1Beta1.QueryAllowanceResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Allowance",
        __Marshaller_cosmos_feegrant_v1beta1_QueryAllowanceRequest,
        __Marshaller_cosmos_feegrant_v1beta1_QueryAllowanceResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Cosmos.Feegrant.V1Beta1.QueryAllowancesRequest, global::Cosmos.Feegrant.V1Beta1.QueryAllowancesResponse> __Method_Allowances = new grpc::Method<global::Cosmos.Feegrant.V1Beta1.QueryAllowancesRequest, global::Cosmos.Feegrant.V1Beta1.QueryAllowancesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Allowances",
        __Marshaller_cosmos_feegrant_v1beta1_QueryAllowancesRequest,
        __Marshaller_cosmos_feegrant_v1beta1_QueryAllowancesResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Cosmos.Feegrant.V1Beta1.QueryReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Query</summary>
    [grpc::BindServiceMethod(typeof(Query), "BindService")]
    public abstract partial class QueryBase
    {
      /// <summary>
      /// Allowance returns fee granted to the grantee by the granter.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Cosmos.Feegrant.V1Beta1.QueryAllowanceResponse> Allowance(global::Cosmos.Feegrant.V1Beta1.QueryAllowanceRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Allowances returns all the grants for address.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Cosmos.Feegrant.V1Beta1.QueryAllowancesResponse> Allowances(global::Cosmos.Feegrant.V1Beta1.QueryAllowancesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Query</summary>
    public partial class QueryClient : grpc::ClientBase<QueryClient>
    {
      /// <summary>Creates a new client for Query</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public QueryClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Query that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public QueryClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected QueryClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected QueryClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Allowance returns fee granted to the grantee by the granter.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Feegrant.V1Beta1.QueryAllowanceResponse Allowance(global::Cosmos.Feegrant.V1Beta1.QueryAllowanceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Allowance(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Allowance returns fee granted to the grantee by the granter.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Feegrant.V1Beta1.QueryAllowanceResponse Allowance(global::Cosmos.Feegrant.V1Beta1.QueryAllowanceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Allowance, null, options, request);
      }
      /// <summary>
      /// Allowance returns fee granted to the grantee by the granter.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Feegrant.V1Beta1.QueryAllowanceResponse> AllowanceAsync(global::Cosmos.Feegrant.V1Beta1.QueryAllowanceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AllowanceAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Allowance returns fee granted to the grantee by the granter.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Feegrant.V1Beta1.QueryAllowanceResponse> AllowanceAsync(global::Cosmos.Feegrant.V1Beta1.QueryAllowanceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Allowance, null, options, request);
      }
      /// <summary>
      /// Allowances returns all the grants for address.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Feegrant.V1Beta1.QueryAllowancesResponse Allowances(global::Cosmos.Feegrant.V1Beta1.QueryAllowancesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Allowances(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Allowances returns all the grants for address.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Feegrant.V1Beta1.QueryAllowancesResponse Allowances(global::Cosmos.Feegrant.V1Beta1.QueryAllowancesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Allowances, null, options, request);
      }
      /// <summary>
      /// Allowances returns all the grants for address.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Feegrant.V1Beta1.QueryAllowancesResponse> AllowancesAsync(global::Cosmos.Feegrant.V1Beta1.QueryAllowancesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AllowancesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Allowances returns all the grants for address.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Feegrant.V1Beta1.QueryAllowancesResponse> AllowancesAsync(global::Cosmos.Feegrant.V1Beta1.QueryAllowancesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Allowances, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override QueryClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new QueryClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(QueryBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Allowance, serviceImpl.Allowance)
          .AddMethod(__Method_Allowances, serviceImpl.Allowances).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, QueryBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Allowance, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Cosmos.Feegrant.V1Beta1.QueryAllowanceRequest, global::Cosmos.Feegrant.V1Beta1.QueryAllowanceResponse>(serviceImpl.Allowance));
      serviceBinder.AddMethod(__Method_Allowances, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Cosmos.Feegrant.V1Beta1.QueryAllowancesRequest, global::Cosmos.Feegrant.V1Beta1.QueryAllowancesResponse>(serviceImpl.Allowances));
    }

  }
}
#endregion
