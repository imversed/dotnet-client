// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/feegrant/v1beta1/tx.proto
// </auto-generated>
// Original file comments:
// Since: cosmos-sdk 0.43
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Cosmos.Feegrant.V1Beta1 {
  /// <summary>
  /// Msg defines the feegrant msg service.
  /// </summary>
  public static partial class Msg
  {
    static readonly string __ServiceName = "cosmos.feegrant.v1beta1.Msg";

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
    static readonly grpc::Marshaller<global::Cosmos.Feegrant.V1Beta1.MsgGrantAllowance> __Marshaller_cosmos_feegrant_v1beta1_MsgGrantAllowance = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Feegrant.V1Beta1.MsgGrantAllowance.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Feegrant.V1Beta1.MsgGrantAllowanceResponse> __Marshaller_cosmos_feegrant_v1beta1_MsgGrantAllowanceResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Feegrant.V1Beta1.MsgGrantAllowanceResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Feegrant.V1Beta1.MsgRevokeAllowance> __Marshaller_cosmos_feegrant_v1beta1_MsgRevokeAllowance = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Feegrant.V1Beta1.MsgRevokeAllowance.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Cosmos.Feegrant.V1Beta1.MsgRevokeAllowanceResponse> __Marshaller_cosmos_feegrant_v1beta1_MsgRevokeAllowanceResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Cosmos.Feegrant.V1Beta1.MsgRevokeAllowanceResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Cosmos.Feegrant.V1Beta1.MsgGrantAllowance, global::Cosmos.Feegrant.V1Beta1.MsgGrantAllowanceResponse> __Method_GrantAllowance = new grpc::Method<global::Cosmos.Feegrant.V1Beta1.MsgGrantAllowance, global::Cosmos.Feegrant.V1Beta1.MsgGrantAllowanceResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GrantAllowance",
        __Marshaller_cosmos_feegrant_v1beta1_MsgGrantAllowance,
        __Marshaller_cosmos_feegrant_v1beta1_MsgGrantAllowanceResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Cosmos.Feegrant.V1Beta1.MsgRevokeAllowance, global::Cosmos.Feegrant.V1Beta1.MsgRevokeAllowanceResponse> __Method_RevokeAllowance = new grpc::Method<global::Cosmos.Feegrant.V1Beta1.MsgRevokeAllowance, global::Cosmos.Feegrant.V1Beta1.MsgRevokeAllowanceResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RevokeAllowance",
        __Marshaller_cosmos_feegrant_v1beta1_MsgRevokeAllowance,
        __Marshaller_cosmos_feegrant_v1beta1_MsgRevokeAllowanceResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Cosmos.Feegrant.V1Beta1.TxReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Msg</summary>
    [grpc::BindServiceMethod(typeof(Msg), "BindService")]
    public abstract partial class MsgBase
    {
      /// <summary>
      /// GrantAllowance grants fee allowance to the grantee on the granter's
      /// account with the provided expiration time.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Cosmos.Feegrant.V1Beta1.MsgGrantAllowanceResponse> GrantAllowance(global::Cosmos.Feegrant.V1Beta1.MsgGrantAllowance request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// RevokeAllowance revokes any fee allowance of granter's account that
      /// has been granted to the grantee.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Cosmos.Feegrant.V1Beta1.MsgRevokeAllowanceResponse> RevokeAllowance(global::Cosmos.Feegrant.V1Beta1.MsgRevokeAllowance request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Msg</summary>
    public partial class MsgClient : grpc::ClientBase<MsgClient>
    {
      /// <summary>Creates a new client for Msg</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public MsgClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Msg that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public MsgClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected MsgClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected MsgClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// GrantAllowance grants fee allowance to the grantee on the granter's
      /// account with the provided expiration time.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Feegrant.V1Beta1.MsgGrantAllowanceResponse GrantAllowance(global::Cosmos.Feegrant.V1Beta1.MsgGrantAllowance request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GrantAllowance(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// GrantAllowance grants fee allowance to the grantee on the granter's
      /// account with the provided expiration time.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Feegrant.V1Beta1.MsgGrantAllowanceResponse GrantAllowance(global::Cosmos.Feegrant.V1Beta1.MsgGrantAllowance request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GrantAllowance, null, options, request);
      }
      /// <summary>
      /// GrantAllowance grants fee allowance to the grantee on the granter's
      /// account with the provided expiration time.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Feegrant.V1Beta1.MsgGrantAllowanceResponse> GrantAllowanceAsync(global::Cosmos.Feegrant.V1Beta1.MsgGrantAllowance request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GrantAllowanceAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// GrantAllowance grants fee allowance to the grantee on the granter's
      /// account with the provided expiration time.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Feegrant.V1Beta1.MsgGrantAllowanceResponse> GrantAllowanceAsync(global::Cosmos.Feegrant.V1Beta1.MsgGrantAllowance request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GrantAllowance, null, options, request);
      }
      /// <summary>
      /// RevokeAllowance revokes any fee allowance of granter's account that
      /// has been granted to the grantee.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Feegrant.V1Beta1.MsgRevokeAllowanceResponse RevokeAllowance(global::Cosmos.Feegrant.V1Beta1.MsgRevokeAllowance request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RevokeAllowance(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// RevokeAllowance revokes any fee allowance of granter's account that
      /// has been granted to the grantee.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Cosmos.Feegrant.V1Beta1.MsgRevokeAllowanceResponse RevokeAllowance(global::Cosmos.Feegrant.V1Beta1.MsgRevokeAllowance request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RevokeAllowance, null, options, request);
      }
      /// <summary>
      /// RevokeAllowance revokes any fee allowance of granter's account that
      /// has been granted to the grantee.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Feegrant.V1Beta1.MsgRevokeAllowanceResponse> RevokeAllowanceAsync(global::Cosmos.Feegrant.V1Beta1.MsgRevokeAllowance request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RevokeAllowanceAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// RevokeAllowance revokes any fee allowance of granter's account that
      /// has been granted to the grantee.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Cosmos.Feegrant.V1Beta1.MsgRevokeAllowanceResponse> RevokeAllowanceAsync(global::Cosmos.Feegrant.V1Beta1.MsgRevokeAllowance request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RevokeAllowance, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override MsgClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MsgClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(MsgBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GrantAllowance, serviceImpl.GrantAllowance)
          .AddMethod(__Method_RevokeAllowance, serviceImpl.RevokeAllowance).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, MsgBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GrantAllowance, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Cosmos.Feegrant.V1Beta1.MsgGrantAllowance, global::Cosmos.Feegrant.V1Beta1.MsgGrantAllowanceResponse>(serviceImpl.GrantAllowance));
      serviceBinder.AddMethod(__Method_RevokeAllowance, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Cosmos.Feegrant.V1Beta1.MsgRevokeAllowance, global::Cosmos.Feegrant.V1Beta1.MsgRevokeAllowanceResponse>(serviceImpl.RevokeAllowance));
    }

  }
}
#endregion
