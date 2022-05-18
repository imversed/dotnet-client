// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/nft/query.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Imversed.Nft {
  /// <summary>
  /// Query defines the gRPC querier service for NFT module
  /// </summary>
  public static partial class Query
  {
    static readonly string __ServiceName = "imversed.nft.Query";

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
    static readonly grpc::Marshaller<global::Imversed.Nft.QuerySupplyRequest> __Marshaller_imversed_nft_QuerySupplyRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Imversed.Nft.QuerySupplyRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Imversed.Nft.QuerySupplyResponse> __Marshaller_imversed_nft_QuerySupplyResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Imversed.Nft.QuerySupplyResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Imversed.Nft.QueryOwnerRequest> __Marshaller_imversed_nft_QueryOwnerRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Imversed.Nft.QueryOwnerRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Imversed.Nft.QueryOwnerResponse> __Marshaller_imversed_nft_QueryOwnerResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Imversed.Nft.QueryOwnerResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Imversed.Nft.QueryCollectionRequest> __Marshaller_imversed_nft_QueryCollectionRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Imversed.Nft.QueryCollectionRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Imversed.Nft.QueryCollectionResponse> __Marshaller_imversed_nft_QueryCollectionResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Imversed.Nft.QueryCollectionResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Imversed.Nft.QueryDenomRequest> __Marshaller_imversed_nft_QueryDenomRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Imversed.Nft.QueryDenomRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Imversed.Nft.QueryDenomResponse> __Marshaller_imversed_nft_QueryDenomResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Imversed.Nft.QueryDenomResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Imversed.Nft.QueryDenomsRequest> __Marshaller_imversed_nft_QueryDenomsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Imversed.Nft.QueryDenomsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Imversed.Nft.QueryDenomsResponse> __Marshaller_imversed_nft_QueryDenomsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Imversed.Nft.QueryDenomsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Imversed.Nft.QueryNFTRequest> __Marshaller_imversed_nft_QueryNFTRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Imversed.Nft.QueryNFTRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Imversed.Nft.QueryNFTResponse> __Marshaller_imversed_nft_QueryNFTResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Imversed.Nft.QueryNFTResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Imversed.Nft.QuerySupplyRequest, global::Imversed.Nft.QuerySupplyResponse> __Method_Supply = new grpc::Method<global::Imversed.Nft.QuerySupplyRequest, global::Imversed.Nft.QuerySupplyResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Supply",
        __Marshaller_imversed_nft_QuerySupplyRequest,
        __Marshaller_imversed_nft_QuerySupplyResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Imversed.Nft.QueryOwnerRequest, global::Imversed.Nft.QueryOwnerResponse> __Method_Owner = new grpc::Method<global::Imversed.Nft.QueryOwnerRequest, global::Imversed.Nft.QueryOwnerResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Owner",
        __Marshaller_imversed_nft_QueryOwnerRequest,
        __Marshaller_imversed_nft_QueryOwnerResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Imversed.Nft.QueryCollectionRequest, global::Imversed.Nft.QueryCollectionResponse> __Method_Collection = new grpc::Method<global::Imversed.Nft.QueryCollectionRequest, global::Imversed.Nft.QueryCollectionResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Collection",
        __Marshaller_imversed_nft_QueryCollectionRequest,
        __Marshaller_imversed_nft_QueryCollectionResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Imversed.Nft.QueryDenomRequest, global::Imversed.Nft.QueryDenomResponse> __Method_Denom = new grpc::Method<global::Imversed.Nft.QueryDenomRequest, global::Imversed.Nft.QueryDenomResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Denom",
        __Marshaller_imversed_nft_QueryDenomRequest,
        __Marshaller_imversed_nft_QueryDenomResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Imversed.Nft.QueryDenomsRequest, global::Imversed.Nft.QueryDenomsResponse> __Method_Denoms = new grpc::Method<global::Imversed.Nft.QueryDenomsRequest, global::Imversed.Nft.QueryDenomsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Denoms",
        __Marshaller_imversed_nft_QueryDenomsRequest,
        __Marshaller_imversed_nft_QueryDenomsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Imversed.Nft.QueryNFTRequest, global::Imversed.Nft.QueryNFTResponse> __Method_Nft = new grpc::Method<global::Imversed.Nft.QueryNFTRequest, global::Imversed.Nft.QueryNFTResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Nft",
        __Marshaller_imversed_nft_QueryNFTRequest,
        __Marshaller_imversed_nft_QueryNFTResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Imversed.Nft.QueryReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Query</summary>
    [grpc::BindServiceMethod(typeof(Query), "BindService")]
    public abstract partial class QueryBase
    {
      /// <summary>
      /// Supply queries the total supply of a given denom or owner
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Imversed.Nft.QuerySupplyResponse> Supply(global::Imversed.Nft.QuerySupplyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Owner queries the NFTs of the specified owner
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Imversed.Nft.QueryOwnerResponse> Owner(global::Imversed.Nft.QueryOwnerRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Collection queries the NFTs of the specified denom
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Imversed.Nft.QueryCollectionResponse> Collection(global::Imversed.Nft.QueryCollectionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Denom queries the definition of a given denom
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Imversed.Nft.QueryDenomResponse> Denom(global::Imversed.Nft.QueryDenomRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Denoms queries all the denoms
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Imversed.Nft.QueryDenomsResponse> Denoms(global::Imversed.Nft.QueryDenomsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// NFT queries the NFT for the given denom and token ID
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Imversed.Nft.QueryNFTResponse> Nft(global::Imversed.Nft.QueryNFTRequest request, grpc::ServerCallContext context)
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
      /// Supply queries the total supply of a given denom or owner
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Imversed.Nft.QuerySupplyResponse Supply(global::Imversed.Nft.QuerySupplyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Supply(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Supply queries the total supply of a given denom or owner
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Imversed.Nft.QuerySupplyResponse Supply(global::Imversed.Nft.QuerySupplyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Supply, null, options, request);
      }
      /// <summary>
      /// Supply queries the total supply of a given denom or owner
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Imversed.Nft.QuerySupplyResponse> SupplyAsync(global::Imversed.Nft.QuerySupplyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SupplyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Supply queries the total supply of a given denom or owner
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Imversed.Nft.QuerySupplyResponse> SupplyAsync(global::Imversed.Nft.QuerySupplyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Supply, null, options, request);
      }
      /// <summary>
      /// Owner queries the NFTs of the specified owner
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Imversed.Nft.QueryOwnerResponse Owner(global::Imversed.Nft.QueryOwnerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Owner(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Owner queries the NFTs of the specified owner
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Imversed.Nft.QueryOwnerResponse Owner(global::Imversed.Nft.QueryOwnerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Owner, null, options, request);
      }
      /// <summary>
      /// Owner queries the NFTs of the specified owner
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Imversed.Nft.QueryOwnerResponse> OwnerAsync(global::Imversed.Nft.QueryOwnerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OwnerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Owner queries the NFTs of the specified owner
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Imversed.Nft.QueryOwnerResponse> OwnerAsync(global::Imversed.Nft.QueryOwnerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Owner, null, options, request);
      }
      /// <summary>
      /// Collection queries the NFTs of the specified denom
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Imversed.Nft.QueryCollectionResponse Collection(global::Imversed.Nft.QueryCollectionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Collection(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Collection queries the NFTs of the specified denom
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Imversed.Nft.QueryCollectionResponse Collection(global::Imversed.Nft.QueryCollectionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Collection, null, options, request);
      }
      /// <summary>
      /// Collection queries the NFTs of the specified denom
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Imversed.Nft.QueryCollectionResponse> CollectionAsync(global::Imversed.Nft.QueryCollectionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CollectionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Collection queries the NFTs of the specified denom
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Imversed.Nft.QueryCollectionResponse> CollectionAsync(global::Imversed.Nft.QueryCollectionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Collection, null, options, request);
      }
      /// <summary>
      /// Denom queries the definition of a given denom
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Imversed.Nft.QueryDenomResponse Denom(global::Imversed.Nft.QueryDenomRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Denom(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Denom queries the definition of a given denom
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Imversed.Nft.QueryDenomResponse Denom(global::Imversed.Nft.QueryDenomRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Denom, null, options, request);
      }
      /// <summary>
      /// Denom queries the definition of a given denom
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Imversed.Nft.QueryDenomResponse> DenomAsync(global::Imversed.Nft.QueryDenomRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DenomAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Denom queries the definition of a given denom
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Imversed.Nft.QueryDenomResponse> DenomAsync(global::Imversed.Nft.QueryDenomRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Denom, null, options, request);
      }
      /// <summary>
      /// Denoms queries all the denoms
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Imversed.Nft.QueryDenomsResponse Denoms(global::Imversed.Nft.QueryDenomsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Denoms(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Denoms queries all the denoms
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Imversed.Nft.QueryDenomsResponse Denoms(global::Imversed.Nft.QueryDenomsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Denoms, null, options, request);
      }
      /// <summary>
      /// Denoms queries all the denoms
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Imversed.Nft.QueryDenomsResponse> DenomsAsync(global::Imversed.Nft.QueryDenomsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DenomsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Denoms queries all the denoms
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Imversed.Nft.QueryDenomsResponse> DenomsAsync(global::Imversed.Nft.QueryDenomsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Denoms, null, options, request);
      }
      /// <summary>
      /// NFT queries the NFT for the given denom and token ID
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Imversed.Nft.QueryNFTResponse Nft(global::Imversed.Nft.QueryNFTRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Nft(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// NFT queries the NFT for the given denom and token ID
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Imversed.Nft.QueryNFTResponse Nft(global::Imversed.Nft.QueryNFTRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Nft, null, options, request);
      }
      /// <summary>
      /// NFT queries the NFT for the given denom and token ID
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Imversed.Nft.QueryNFTResponse> NftAsync(global::Imversed.Nft.QueryNFTRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return NftAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// NFT queries the NFT for the given denom and token ID
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Imversed.Nft.QueryNFTResponse> NftAsync(global::Imversed.Nft.QueryNFTRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Nft, null, options, request);
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
          .AddMethod(__Method_Supply, serviceImpl.Supply)
          .AddMethod(__Method_Owner, serviceImpl.Owner)
          .AddMethod(__Method_Collection, serviceImpl.Collection)
          .AddMethod(__Method_Denom, serviceImpl.Denom)
          .AddMethod(__Method_Denoms, serviceImpl.Denoms)
          .AddMethod(__Method_Nft, serviceImpl.Nft).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, QueryBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Supply, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Imversed.Nft.QuerySupplyRequest, global::Imversed.Nft.QuerySupplyResponse>(serviceImpl.Supply));
      serviceBinder.AddMethod(__Method_Owner, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Imversed.Nft.QueryOwnerRequest, global::Imversed.Nft.QueryOwnerResponse>(serviceImpl.Owner));
      serviceBinder.AddMethod(__Method_Collection, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Imversed.Nft.QueryCollectionRequest, global::Imversed.Nft.QueryCollectionResponse>(serviceImpl.Collection));
      serviceBinder.AddMethod(__Method_Denom, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Imversed.Nft.QueryDenomRequest, global::Imversed.Nft.QueryDenomResponse>(serviceImpl.Denom));
      serviceBinder.AddMethod(__Method_Denoms, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Imversed.Nft.QueryDenomsRequest, global::Imversed.Nft.QueryDenomsResponse>(serviceImpl.Denoms));
      serviceBinder.AddMethod(__Method_Nft, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Imversed.Nft.QueryNFTRequest, global::Imversed.Nft.QueryNFTResponse>(serviceImpl.Nft));
    }

  }
}
#endregion
