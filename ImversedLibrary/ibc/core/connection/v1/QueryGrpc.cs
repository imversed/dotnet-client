// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ibc/core/connection/v1/query.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Ibc.Core.Connection.V1 {
  /// <summary>
  /// Query provides defines the gRPC querier service
  /// </summary>
  public static partial class Query
  {
    static readonly string __ServiceName = "ibc.core.connection.v1.Query";

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
    static readonly grpc::Marshaller<global::Ibc.Core.Connection.V1.QueryConnectionRequest> __Marshaller_ibc_core_connection_v1_QueryConnectionRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Ibc.Core.Connection.V1.QueryConnectionRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Ibc.Core.Connection.V1.QueryConnectionResponse> __Marshaller_ibc_core_connection_v1_QueryConnectionResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Ibc.Core.Connection.V1.QueryConnectionResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Ibc.Core.Connection.V1.QueryConnectionsRequest> __Marshaller_ibc_core_connection_v1_QueryConnectionsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Ibc.Core.Connection.V1.QueryConnectionsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Ibc.Core.Connection.V1.QueryConnectionsResponse> __Marshaller_ibc_core_connection_v1_QueryConnectionsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Ibc.Core.Connection.V1.QueryConnectionsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Ibc.Core.Connection.V1.QueryClientConnectionsRequest> __Marshaller_ibc_core_connection_v1_QueryClientConnectionsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Ibc.Core.Connection.V1.QueryClientConnectionsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Ibc.Core.Connection.V1.QueryClientConnectionsResponse> __Marshaller_ibc_core_connection_v1_QueryClientConnectionsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Ibc.Core.Connection.V1.QueryClientConnectionsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Ibc.Core.Connection.V1.QueryConnectionClientStateRequest> __Marshaller_ibc_core_connection_v1_QueryConnectionClientStateRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Ibc.Core.Connection.V1.QueryConnectionClientStateRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Ibc.Core.Connection.V1.QueryConnectionClientStateResponse> __Marshaller_ibc_core_connection_v1_QueryConnectionClientStateResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Ibc.Core.Connection.V1.QueryConnectionClientStateResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Ibc.Core.Connection.V1.QueryConnectionConsensusStateRequest> __Marshaller_ibc_core_connection_v1_QueryConnectionConsensusStateRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Ibc.Core.Connection.V1.QueryConnectionConsensusStateRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Ibc.Core.Connection.V1.QueryConnectionConsensusStateResponse> __Marshaller_ibc_core_connection_v1_QueryConnectionConsensusStateResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Ibc.Core.Connection.V1.QueryConnectionConsensusStateResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Ibc.Core.Connection.V1.QueryConnectionRequest, global::Ibc.Core.Connection.V1.QueryConnectionResponse> __Method_Connection = new grpc::Method<global::Ibc.Core.Connection.V1.QueryConnectionRequest, global::Ibc.Core.Connection.V1.QueryConnectionResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Connection",
        __Marshaller_ibc_core_connection_v1_QueryConnectionRequest,
        __Marshaller_ibc_core_connection_v1_QueryConnectionResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Ibc.Core.Connection.V1.QueryConnectionsRequest, global::Ibc.Core.Connection.V1.QueryConnectionsResponse> __Method_Connections = new grpc::Method<global::Ibc.Core.Connection.V1.QueryConnectionsRequest, global::Ibc.Core.Connection.V1.QueryConnectionsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Connections",
        __Marshaller_ibc_core_connection_v1_QueryConnectionsRequest,
        __Marshaller_ibc_core_connection_v1_QueryConnectionsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Ibc.Core.Connection.V1.QueryClientConnectionsRequest, global::Ibc.Core.Connection.V1.QueryClientConnectionsResponse> __Method_ClientConnections = new grpc::Method<global::Ibc.Core.Connection.V1.QueryClientConnectionsRequest, global::Ibc.Core.Connection.V1.QueryClientConnectionsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ClientConnections",
        __Marshaller_ibc_core_connection_v1_QueryClientConnectionsRequest,
        __Marshaller_ibc_core_connection_v1_QueryClientConnectionsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Ibc.Core.Connection.V1.QueryConnectionClientStateRequest, global::Ibc.Core.Connection.V1.QueryConnectionClientStateResponse> __Method_ConnectionClientState = new grpc::Method<global::Ibc.Core.Connection.V1.QueryConnectionClientStateRequest, global::Ibc.Core.Connection.V1.QueryConnectionClientStateResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ConnectionClientState",
        __Marshaller_ibc_core_connection_v1_QueryConnectionClientStateRequest,
        __Marshaller_ibc_core_connection_v1_QueryConnectionClientStateResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Ibc.Core.Connection.V1.QueryConnectionConsensusStateRequest, global::Ibc.Core.Connection.V1.QueryConnectionConsensusStateResponse> __Method_ConnectionConsensusState = new grpc::Method<global::Ibc.Core.Connection.V1.QueryConnectionConsensusStateRequest, global::Ibc.Core.Connection.V1.QueryConnectionConsensusStateResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ConnectionConsensusState",
        __Marshaller_ibc_core_connection_v1_QueryConnectionConsensusStateRequest,
        __Marshaller_ibc_core_connection_v1_QueryConnectionConsensusStateResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Ibc.Core.Connection.V1.QueryReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Query</summary>
    [grpc::BindServiceMethod(typeof(Query), "BindService")]
    public abstract partial class QueryBase
    {
      /// <summary>
      /// Connection queries an IBC connection end.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Ibc.Core.Connection.V1.QueryConnectionResponse> Connection(global::Ibc.Core.Connection.V1.QueryConnectionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Connections queries all the IBC connections of a chain.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Ibc.Core.Connection.V1.QueryConnectionsResponse> Connections(global::Ibc.Core.Connection.V1.QueryConnectionsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// ClientConnections queries the connection paths associated with a client
      /// state.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Ibc.Core.Connection.V1.QueryClientConnectionsResponse> ClientConnections(global::Ibc.Core.Connection.V1.QueryClientConnectionsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// ConnectionClientState queries the client state associated with the
      /// connection.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Ibc.Core.Connection.V1.QueryConnectionClientStateResponse> ConnectionClientState(global::Ibc.Core.Connection.V1.QueryConnectionClientStateRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// ConnectionConsensusState queries the consensus state associated with the
      /// connection.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Ibc.Core.Connection.V1.QueryConnectionConsensusStateResponse> ConnectionConsensusState(global::Ibc.Core.Connection.V1.QueryConnectionConsensusStateRequest request, grpc::ServerCallContext context)
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
      /// Connection queries an IBC connection end.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Ibc.Core.Connection.V1.QueryConnectionResponse Connection(global::Ibc.Core.Connection.V1.QueryConnectionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Connection(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Connection queries an IBC connection end.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Ibc.Core.Connection.V1.QueryConnectionResponse Connection(global::Ibc.Core.Connection.V1.QueryConnectionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Connection, null, options, request);
      }
      /// <summary>
      /// Connection queries an IBC connection end.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Ibc.Core.Connection.V1.QueryConnectionResponse> ConnectionAsync(global::Ibc.Core.Connection.V1.QueryConnectionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ConnectionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Connection queries an IBC connection end.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Ibc.Core.Connection.V1.QueryConnectionResponse> ConnectionAsync(global::Ibc.Core.Connection.V1.QueryConnectionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Connection, null, options, request);
      }
      /// <summary>
      /// Connections queries all the IBC connections of a chain.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Ibc.Core.Connection.V1.QueryConnectionsResponse Connections(global::Ibc.Core.Connection.V1.QueryConnectionsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Connections(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Connections queries all the IBC connections of a chain.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Ibc.Core.Connection.V1.QueryConnectionsResponse Connections(global::Ibc.Core.Connection.V1.QueryConnectionsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Connections, null, options, request);
      }
      /// <summary>
      /// Connections queries all the IBC connections of a chain.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Ibc.Core.Connection.V1.QueryConnectionsResponse> ConnectionsAsync(global::Ibc.Core.Connection.V1.QueryConnectionsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ConnectionsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Connections queries all the IBC connections of a chain.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Ibc.Core.Connection.V1.QueryConnectionsResponse> ConnectionsAsync(global::Ibc.Core.Connection.V1.QueryConnectionsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Connections, null, options, request);
      }
      /// <summary>
      /// ClientConnections queries the connection paths associated with a client
      /// state.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Ibc.Core.Connection.V1.QueryClientConnectionsResponse ClientConnections(global::Ibc.Core.Connection.V1.QueryClientConnectionsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ClientConnections(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// ClientConnections queries the connection paths associated with a client
      /// state.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Ibc.Core.Connection.V1.QueryClientConnectionsResponse ClientConnections(global::Ibc.Core.Connection.V1.QueryClientConnectionsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ClientConnections, null, options, request);
      }
      /// <summary>
      /// ClientConnections queries the connection paths associated with a client
      /// state.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Ibc.Core.Connection.V1.QueryClientConnectionsResponse> ClientConnectionsAsync(global::Ibc.Core.Connection.V1.QueryClientConnectionsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ClientConnectionsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// ClientConnections queries the connection paths associated with a client
      /// state.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Ibc.Core.Connection.V1.QueryClientConnectionsResponse> ClientConnectionsAsync(global::Ibc.Core.Connection.V1.QueryClientConnectionsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ClientConnections, null, options, request);
      }
      /// <summary>
      /// ConnectionClientState queries the client state associated with the
      /// connection.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Ibc.Core.Connection.V1.QueryConnectionClientStateResponse ConnectionClientState(global::Ibc.Core.Connection.V1.QueryConnectionClientStateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ConnectionClientState(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// ConnectionClientState queries the client state associated with the
      /// connection.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Ibc.Core.Connection.V1.QueryConnectionClientStateResponse ConnectionClientState(global::Ibc.Core.Connection.V1.QueryConnectionClientStateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ConnectionClientState, null, options, request);
      }
      /// <summary>
      /// ConnectionClientState queries the client state associated with the
      /// connection.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Ibc.Core.Connection.V1.QueryConnectionClientStateResponse> ConnectionClientStateAsync(global::Ibc.Core.Connection.V1.QueryConnectionClientStateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ConnectionClientStateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// ConnectionClientState queries the client state associated with the
      /// connection.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Ibc.Core.Connection.V1.QueryConnectionClientStateResponse> ConnectionClientStateAsync(global::Ibc.Core.Connection.V1.QueryConnectionClientStateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ConnectionClientState, null, options, request);
      }
      /// <summary>
      /// ConnectionConsensusState queries the consensus state associated with the
      /// connection.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Ibc.Core.Connection.V1.QueryConnectionConsensusStateResponse ConnectionConsensusState(global::Ibc.Core.Connection.V1.QueryConnectionConsensusStateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ConnectionConsensusState(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// ConnectionConsensusState queries the consensus state associated with the
      /// connection.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Ibc.Core.Connection.V1.QueryConnectionConsensusStateResponse ConnectionConsensusState(global::Ibc.Core.Connection.V1.QueryConnectionConsensusStateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ConnectionConsensusState, null, options, request);
      }
      /// <summary>
      /// ConnectionConsensusState queries the consensus state associated with the
      /// connection.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Ibc.Core.Connection.V1.QueryConnectionConsensusStateResponse> ConnectionConsensusStateAsync(global::Ibc.Core.Connection.V1.QueryConnectionConsensusStateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ConnectionConsensusStateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// ConnectionConsensusState queries the consensus state associated with the
      /// connection.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Ibc.Core.Connection.V1.QueryConnectionConsensusStateResponse> ConnectionConsensusStateAsync(global::Ibc.Core.Connection.V1.QueryConnectionConsensusStateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ConnectionConsensusState, null, options, request);
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
          .AddMethod(__Method_Connection, serviceImpl.Connection)
          .AddMethod(__Method_Connections, serviceImpl.Connections)
          .AddMethod(__Method_ClientConnections, serviceImpl.ClientConnections)
          .AddMethod(__Method_ConnectionClientState, serviceImpl.ConnectionClientState)
          .AddMethod(__Method_ConnectionConsensusState, serviceImpl.ConnectionConsensusState).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, QueryBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Connection, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Ibc.Core.Connection.V1.QueryConnectionRequest, global::Ibc.Core.Connection.V1.QueryConnectionResponse>(serviceImpl.Connection));
      serviceBinder.AddMethod(__Method_Connections, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Ibc.Core.Connection.V1.QueryConnectionsRequest, global::Ibc.Core.Connection.V1.QueryConnectionsResponse>(serviceImpl.Connections));
      serviceBinder.AddMethod(__Method_ClientConnections, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Ibc.Core.Connection.V1.QueryClientConnectionsRequest, global::Ibc.Core.Connection.V1.QueryClientConnectionsResponse>(serviceImpl.ClientConnections));
      serviceBinder.AddMethod(__Method_ConnectionClientState, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Ibc.Core.Connection.V1.QueryConnectionClientStateRequest, global::Ibc.Core.Connection.V1.QueryConnectionClientStateResponse>(serviceImpl.ConnectionClientState));
      serviceBinder.AddMethod(__Method_ConnectionConsensusState, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Ibc.Core.Connection.V1.QueryConnectionConsensusStateRequest, global::Ibc.Core.Connection.V1.QueryConnectionConsensusStateResponse>(serviceImpl.ConnectionConsensusState));
    }

  }
}
#endregion
