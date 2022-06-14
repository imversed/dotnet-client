// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/tx/v1beta1/service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Cosmos.Tx.V1Beta1 {
  /// <summary>
  /// Service defines a gRPC service for interacting with transactions.
  /// </summary>
  public static partial class Service
  {
    static readonly string __ServiceName = "cosmos.tx.v1beta1.Service";

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
    static readonly grpc::Marshaller<global::Cosmos.Tx.V1Beta1.SimulateRequest> __Marshaller_cosmos_tx_v1beta1_SimulateRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Tx.V1Beta1.SimulateRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Tx.V1Beta1.SimulateResponse> __Marshaller_cosmos_tx_v1beta1_SimulateResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Tx.V1Beta1.SimulateResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Tx.V1Beta1.GetTxRequest> __Marshaller_cosmos_tx_v1beta1_GetTxRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Tx.V1Beta1.GetTxRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Tx.V1Beta1.GetTxResponse> __Marshaller_cosmos_tx_v1beta1_GetTxResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Tx.V1Beta1.GetTxResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Tx.V1Beta1.BroadcastTxRequest> __Marshaller_cosmos_tx_v1beta1_BroadcastTxRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Tx.V1Beta1.BroadcastTxRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Tx.V1Beta1.BroadcastTxResponse> __Marshaller_cosmos_tx_v1beta1_BroadcastTxResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Tx.V1Beta1.BroadcastTxResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Tx.V1Beta1.GetTxsEventRequest> __Marshaller_cosmos_tx_v1beta1_GetTxsEventRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Tx.V1Beta1.GetTxsEventRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Tx.V1Beta1.GetTxsEventResponse> __Marshaller_cosmos_tx_v1beta1_GetTxsEventResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Tx.V1Beta1.GetTxsEventResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Tx.V1Beta1.GetBlockWithTxsRequest> __Marshaller_cosmos_tx_v1beta1_GetBlockWithTxsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Tx.V1Beta1.GetBlockWithTxsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Tx.V1Beta1.GetBlockWithTxsResponse> __Marshaller_cosmos_tx_v1beta1_GetBlockWithTxsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Tx.V1Beta1.GetBlockWithTxsResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Cosmos.Tx.V1Beta1.SimulateRequest, global::Cosmos.Tx.V1Beta1.SimulateResponse> __Method_Simulate = new grpc::Method<global::Cosmos.Tx.V1Beta1.SimulateRequest, global::Cosmos.Tx.V1Beta1.SimulateResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Simulate",
        __Marshaller_cosmos_tx_v1beta1_SimulateRequest,
        __Marshaller_cosmos_tx_v1beta1_SimulateResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Cosmos.Tx.V1Beta1.GetTxRequest, global::Cosmos.Tx.V1Beta1.GetTxResponse> __Method_GetTx = new grpc::Method<global::Cosmos.Tx.V1Beta1.GetTxRequest, global::Cosmos.Tx.V1Beta1.GetTxResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetTx",
        __Marshaller_cosmos_tx_v1beta1_GetTxRequest,
        __Marshaller_cosmos_tx_v1beta1_GetTxResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Cosmos.Tx.V1Beta1.BroadcastTxRequest, global::Cosmos.Tx.V1Beta1.BroadcastTxResponse> __Method_BroadcastTx = new grpc::Method<global::Cosmos.Tx.V1Beta1.BroadcastTxRequest, global::Cosmos.Tx.V1Beta1.BroadcastTxResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "BroadcastTx",
        __Marshaller_cosmos_tx_v1beta1_BroadcastTxRequest,
        __Marshaller_cosmos_tx_v1beta1_BroadcastTxResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Cosmos.Tx.V1Beta1.GetTxsEventRequest, global::Cosmos.Tx.V1Beta1.GetTxsEventResponse> __Method_GetTxsEvent = new grpc::Method<global::Cosmos.Tx.V1Beta1.GetTxsEventRequest, global::Cosmos.Tx.V1Beta1.GetTxsEventResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetTxsEvent",
        __Marshaller_cosmos_tx_v1beta1_GetTxsEventRequest,
        __Marshaller_cosmos_tx_v1beta1_GetTxsEventResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Cosmos.Tx.V1Beta1.GetBlockWithTxsRequest, global::Cosmos.Tx.V1Beta1.GetBlockWithTxsResponse> __Method_GetBlockWithTxs = new grpc::Method<global::Cosmos.Tx.V1Beta1.GetBlockWithTxsRequest, global::Cosmos.Tx.V1Beta1.GetBlockWithTxsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetBlockWithTxs",
        __Marshaller_cosmos_tx_v1beta1_GetBlockWithTxsRequest,
        __Marshaller_cosmos_tx_v1beta1_GetBlockWithTxsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Cosmos.Tx.V1Beta1.ServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Service</summary>
    [grpc::BindServiceMethod(typeof(Service), "BindService")]
    public abstract partial class ServiceBase
    {
      /// <summary>
      /// Simulate simulates executing a transaction for estimating gas usage.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Cosmos.Tx.V1Beta1.SimulateResponse> Simulate(global::Cosmos.Tx.V1Beta1.SimulateRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// GetTx fetches a tx by hash.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Cosmos.Tx.V1Beta1.GetTxResponse> GetTx(global::Cosmos.Tx.V1Beta1.GetTxRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// BroadcastTx broadcast transaction.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Cosmos.Tx.V1Beta1.BroadcastTxResponse> BroadcastTx(global::Cosmos.Tx.V1Beta1.BroadcastTxRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// GetTxsEvent fetches txs by event.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Cosmos.Tx.V1Beta1.GetTxsEventResponse> GetTxsEvent(global::Cosmos.Tx.V1Beta1.GetTxsEventRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// GetBlockWithTxs fetches a block with decoded txs.
      ///
      /// Since: cosmos-sdk 0.45.2
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Cosmos.Tx.V1Beta1.GetBlockWithTxsResponse> GetBlockWithTxs(global::Cosmos.Tx.V1Beta1.GetBlockWithTxsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Service</summary>
    public partial class ServiceClient : grpc::ClientBase<ServiceClient>
    {
      /// <summary>Creates a new client for Service</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Service that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Simulate simulates executing a transaction for estimating gas usage.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Tx.V1Beta1.SimulateResponse Simulate(global::Cosmos.Tx.V1Beta1.SimulateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Simulate(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Simulate simulates executing a transaction for estimating gas usage.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Tx.V1Beta1.SimulateResponse Simulate(global::Cosmos.Tx.V1Beta1.SimulateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Simulate, null, options, request);
      }
      /// <summary>
      /// Simulate simulates executing a transaction for estimating gas usage.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Tx.V1Beta1.SimulateResponse> SimulateAsync(global::Cosmos.Tx.V1Beta1.SimulateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SimulateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Simulate simulates executing a transaction for estimating gas usage.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Tx.V1Beta1.SimulateResponse> SimulateAsync(global::Cosmos.Tx.V1Beta1.SimulateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Simulate, null, options, request);
      }
      /// <summary>
      /// GetTx fetches a tx by hash.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Tx.V1Beta1.GetTxResponse GetTx(global::Cosmos.Tx.V1Beta1.GetTxRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetTx(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// GetTx fetches a tx by hash.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Tx.V1Beta1.GetTxResponse GetTx(global::Cosmos.Tx.V1Beta1.GetTxRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetTx, null, options, request);
      }
      /// <summary>
      /// GetTx fetches a tx by hash.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Tx.V1Beta1.GetTxResponse> GetTxAsync(global::Cosmos.Tx.V1Beta1.GetTxRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetTxAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// GetTx fetches a tx by hash.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Tx.V1Beta1.GetTxResponse> GetTxAsync(global::Cosmos.Tx.V1Beta1.GetTxRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetTx, null, options, request);
      }
      /// <summary>
      /// BroadcastTx broadcast transaction.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Tx.V1Beta1.BroadcastTxResponse BroadcastTx(global::Cosmos.Tx.V1Beta1.BroadcastTxRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return BroadcastTx(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// BroadcastTx broadcast transaction.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Tx.V1Beta1.BroadcastTxResponse BroadcastTx(global::Cosmos.Tx.V1Beta1.BroadcastTxRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_BroadcastTx, null, options, request);
      }
      /// <summary>
      /// BroadcastTx broadcast transaction.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Tx.V1Beta1.BroadcastTxResponse> BroadcastTxAsync(global::Cosmos.Tx.V1Beta1.BroadcastTxRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return BroadcastTxAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// BroadcastTx broadcast transaction.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Tx.V1Beta1.BroadcastTxResponse> BroadcastTxAsync(global::Cosmos.Tx.V1Beta1.BroadcastTxRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_BroadcastTx, null, options, request);
      }
      /// <summary>
      /// GetTxsEvent fetches txs by event.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Tx.V1Beta1.GetTxsEventResponse GetTxsEvent(global::Cosmos.Tx.V1Beta1.GetTxsEventRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetTxsEvent(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// GetTxsEvent fetches txs by event.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Tx.V1Beta1.GetTxsEventResponse GetTxsEvent(global::Cosmos.Tx.V1Beta1.GetTxsEventRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetTxsEvent, null, options, request);
      }
      /// <summary>
      /// GetTxsEvent fetches txs by event.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Tx.V1Beta1.GetTxsEventResponse> GetTxsEventAsync(global::Cosmos.Tx.V1Beta1.GetTxsEventRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetTxsEventAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// GetTxsEvent fetches txs by event.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Tx.V1Beta1.GetTxsEventResponse> GetTxsEventAsync(global::Cosmos.Tx.V1Beta1.GetTxsEventRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetTxsEvent, null, options, request);
      }
      /// <summary>
      /// GetBlockWithTxs fetches a block with decoded txs.
      ///
      /// Since: cosmos-sdk 0.45.2
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Tx.V1Beta1.GetBlockWithTxsResponse GetBlockWithTxs(global::Cosmos.Tx.V1Beta1.GetBlockWithTxsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetBlockWithTxs(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// GetBlockWithTxs fetches a block with decoded txs.
      ///
      /// Since: cosmos-sdk 0.45.2
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Tx.V1Beta1.GetBlockWithTxsResponse GetBlockWithTxs(global::Cosmos.Tx.V1Beta1.GetBlockWithTxsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetBlockWithTxs, null, options, request);
      }
      /// <summary>
      /// GetBlockWithTxs fetches a block with decoded txs.
      ///
      /// Since: cosmos-sdk 0.45.2
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Tx.V1Beta1.GetBlockWithTxsResponse> GetBlockWithTxsAsync(global::Cosmos.Tx.V1Beta1.GetBlockWithTxsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetBlockWithTxsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// GetBlockWithTxs fetches a block with decoded txs.
      ///
      /// Since: cosmos-sdk 0.45.2
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Tx.V1Beta1.GetBlockWithTxsResponse> GetBlockWithTxsAsync(global::Cosmos.Tx.V1Beta1.GetBlockWithTxsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetBlockWithTxs, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override ServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Simulate, serviceImpl.Simulate)
          .AddMethod(__Method_GetTx, serviceImpl.GetTx)
          .AddMethod(__Method_BroadcastTx, serviceImpl.BroadcastTx)
          .AddMethod(__Method_GetTxsEvent, serviceImpl.GetTxsEvent)
          .AddMethod(__Method_GetBlockWithTxs, serviceImpl.GetBlockWithTxs).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Simulate, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Cosmos.Tx.V1Beta1.SimulateRequest, global::Cosmos.Tx.V1Beta1.SimulateResponse>(serviceImpl.Simulate));
      serviceBinder.AddMethod(__Method_GetTx, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Cosmos.Tx.V1Beta1.GetTxRequest, global::Cosmos.Tx.V1Beta1.GetTxResponse>(serviceImpl.GetTx));
      serviceBinder.AddMethod(__Method_BroadcastTx, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Cosmos.Tx.V1Beta1.BroadcastTxRequest, global::Cosmos.Tx.V1Beta1.BroadcastTxResponse>(serviceImpl.BroadcastTx));
      serviceBinder.AddMethod(__Method_GetTxsEvent, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Cosmos.Tx.V1Beta1.GetTxsEventRequest, global::Cosmos.Tx.V1Beta1.GetTxsEventResponse>(serviceImpl.GetTxsEvent));
      serviceBinder.AddMethod(__Method_GetBlockWithTxs, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Cosmos.Tx.V1Beta1.GetBlockWithTxsRequest, global::Cosmos.Tx.V1Beta1.GetBlockWithTxsResponse>(serviceImpl.GetBlockWithTxs));
    }

  }
}
#endregion
