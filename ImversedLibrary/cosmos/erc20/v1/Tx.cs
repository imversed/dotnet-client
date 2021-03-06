// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/erc20/v1/tx.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Imversed.Erc20.V1 {

  /// <summary>Holder for reflection information generated from cosmos/erc20/v1/tx.proto</summary>
  public static partial class TxReflection {

    #region Descriptor
    /// <summary>File descriptor for cosmos/erc20/v1/tx.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TxReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chhjb3Ntb3MvZXJjMjAvdjEvdHgucHJvdG8SEWltdmVyc2VkLmVyYzIwLnYx",
            "Ghxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvGhRnb2dvcHJvdG8vZ29n",
            "by5wcm90bxoeY29zbW9zL2Jhc2UvdjFiZXRhMS9jb2luLnByb3RvImEKDk1z",
            "Z0NvbnZlcnRDb2luEi0KBGNvaW4YASABKAsyGS5jb3Ntb3MuYmFzZS52MWJl",
            "dGExLkNvaW5CBMjeHwASEAoIcmVjZWl2ZXIYAiABKAkSDgoGc2VuZGVyGAMg",
            "ASgJIhgKFk1zZ0NvbnZlcnRDb2luUmVzcG9uc2UijQEKD01zZ0NvbnZlcnRF",
            "UkMyMBIYChBjb250cmFjdF9hZGRyZXNzGAEgASgJEj4KBmFtb3VudBgCIAEo",
            "CUIu2t4fJmdpdGh1Yi5jb20vY29zbW9zL2Nvc21vcy1zZGsvdHlwZXMuSW50",
            "yN4fABIQCghyZWNlaXZlchgDIAEoCRIOCgZzZW5kZXIYBCABKAkiGQoXTXNn",
            "Q29udmVydEVSQzIwUmVzcG9uc2UynQIKA01zZxKHAQoLQ29udmVydENvaW4S",
            "IS5pbXZlcnNlZC5lcmMyMC52MS5Nc2dDb252ZXJ0Q29pbhopLmltdmVyc2Vk",
            "LmVyYzIwLnYxLk1zZ0NvbnZlcnRDb2luUmVzcG9uc2UiKoLT5JMCJBIiL2lt",
            "dmVyc2VkL2VyYzIwL3YxL3R4L2NvbnZlcnRfY29pbhKLAQoMQ29udmVydEVS",
            "QzIwEiIuaW12ZXJzZWQuZXJjMjAudjEuTXNnQ29udmVydEVSQzIwGiouaW12",
            "ZXJzZWQuZXJjMjAudjEuTXNnQ29udmVydEVSQzIwUmVzcG9uc2UiK4LT5JMC",
            "JRIjL2ltdmVyc2VkL2VyYzIwL3YxL3R4L2NvbnZlcnRfZXJjMjBCLFoqZ2l0",
            "aHViLmNvbS9pbXZlcnNlZC9pbXZlcnNlZC94L2VyYzIwL3R5cGVzYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Gogoproto.GogoReflection.Descriptor, global::Cosmos.Base.V1Beta1.CoinReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Imversed.Erc20.V1.MsgConvertCoin), global::Imversed.Erc20.V1.MsgConvertCoin.Parser, new[]{ "Coin", "Receiver", "Sender" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Imversed.Erc20.V1.MsgConvertCoinResponse), global::Imversed.Erc20.V1.MsgConvertCoinResponse.Parser, null, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Imversed.Erc20.V1.MsgConvertERC20), global::Imversed.Erc20.V1.MsgConvertERC20.Parser, new[]{ "ContractAddress", "Amount", "Receiver", "Sender" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Imversed.Erc20.V1.MsgConvertERC20Response), global::Imversed.Erc20.V1.MsgConvertERC20Response.Parser, null, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// MsgConvertCoin defines a Msg to convert a Cosmos Coin to a ERC20 token
  /// </summary>
  public sealed partial class MsgConvertCoin : pb::IMessage<MsgConvertCoin>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MsgConvertCoin> _parser = new pb::MessageParser<MsgConvertCoin>(() => new MsgConvertCoin());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MsgConvertCoin> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Imversed.Erc20.V1.TxReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgConvertCoin() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgConvertCoin(MsgConvertCoin other) : this() {
      coin_ = other.coin_ != null ? other.coin_.Clone() : null;
      receiver_ = other.receiver_;
      sender_ = other.sender_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgConvertCoin Clone() {
      return new MsgConvertCoin(this);
    }

    /// <summary>Field number for the "coin" field.</summary>
    public const int CoinFieldNumber = 1;
    private global::Cosmos.Base.V1Beta1.Coin coin_;
    /// <summary>
    /// Cosmos coin which denomination is registered on erc20 bridge.
    /// The coin amount defines the total ERC20 tokens to convert.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Cosmos.Base.V1Beta1.Coin Coin {
      get { return coin_; }
      set {
        coin_ = value;
      }
    }

    /// <summary>Field number for the "receiver" field.</summary>
    public const int ReceiverFieldNumber = 2;
    private string receiver_ = "";
    /// <summary>
    /// recipient hex address to receive ERC20 token
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Receiver {
      get { return receiver_; }
      set {
        receiver_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sender" field.</summary>
    public const int SenderFieldNumber = 3;
    private string sender_ = "";
    /// <summary>
    /// cosmos bech32 address from the owner of the given ERC20 tokens
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Sender {
      get { return sender_; }
      set {
        sender_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MsgConvertCoin);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MsgConvertCoin other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Coin, other.Coin)) return false;
      if (Receiver != other.Receiver) return false;
      if (Sender != other.Sender) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (coin_ != null) hash ^= Coin.GetHashCode();
      if (Receiver.Length != 0) hash ^= Receiver.GetHashCode();
      if (Sender.Length != 0) hash ^= Sender.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (coin_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Coin);
      }
      if (Receiver.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Receiver);
      }
      if (Sender.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Sender);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (coin_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Coin);
      }
      if (Receiver.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Receiver);
      }
      if (Sender.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Sender);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (coin_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Coin);
      }
      if (Receiver.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Receiver);
      }
      if (Sender.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Sender);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MsgConvertCoin other) {
      if (other == null) {
        return;
      }
      if (other.coin_ != null) {
        if (coin_ == null) {
          Coin = new global::Cosmos.Base.V1Beta1.Coin();
        }
        Coin.MergeFrom(other.Coin);
      }
      if (other.Receiver.Length != 0) {
        Receiver = other.Receiver;
      }
      if (other.Sender.Length != 0) {
        Sender = other.Sender;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (coin_ == null) {
              Coin = new global::Cosmos.Base.V1Beta1.Coin();
            }
            input.ReadMessage(Coin);
            break;
          }
          case 18: {
            Receiver = input.ReadString();
            break;
          }
          case 26: {
            Sender = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (coin_ == null) {
              Coin = new global::Cosmos.Base.V1Beta1.Coin();
            }
            input.ReadMessage(Coin);
            break;
          }
          case 18: {
            Receiver = input.ReadString();
            break;
          }
          case 26: {
            Sender = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// MsgConvertCoinResponse returns no fields
  /// </summary>
  public sealed partial class MsgConvertCoinResponse : pb::IMessage<MsgConvertCoinResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MsgConvertCoinResponse> _parser = new pb::MessageParser<MsgConvertCoinResponse>(() => new MsgConvertCoinResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MsgConvertCoinResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Imversed.Erc20.V1.TxReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgConvertCoinResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgConvertCoinResponse(MsgConvertCoinResponse other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgConvertCoinResponse Clone() {
      return new MsgConvertCoinResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MsgConvertCoinResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MsgConvertCoinResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MsgConvertCoinResponse other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

  }

  /// <summary>
  /// MsgConvertERC20 defines a Msg to convert an ERC20 token to a Cosmos SDK coin.
  /// </summary>
  public sealed partial class MsgConvertERC20 : pb::IMessage<MsgConvertERC20>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MsgConvertERC20> _parser = new pb::MessageParser<MsgConvertERC20>(() => new MsgConvertERC20());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MsgConvertERC20> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Imversed.Erc20.V1.TxReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgConvertERC20() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgConvertERC20(MsgConvertERC20 other) : this() {
      contractAddress_ = other.contractAddress_;
      amount_ = other.amount_;
      receiver_ = other.receiver_;
      sender_ = other.sender_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgConvertERC20 Clone() {
      return new MsgConvertERC20(this);
    }

    /// <summary>Field number for the "contract_address" field.</summary>
    public const int ContractAddressFieldNumber = 1;
    private string contractAddress_ = "";
    /// <summary>
    /// ERC20 token contract address registered on erc20 bridge
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ContractAddress {
      get { return contractAddress_; }
      set {
        contractAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "amount" field.</summary>
    public const int AmountFieldNumber = 2;
    private string amount_ = "";
    /// <summary>
    /// amount of ERC20 tokens to mint
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Amount {
      get { return amount_; }
      set {
        amount_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "receiver" field.</summary>
    public const int ReceiverFieldNumber = 3;
    private string receiver_ = "";
    /// <summary>
    /// bech32 address to receive SDK coins.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Receiver {
      get { return receiver_; }
      set {
        receiver_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sender" field.</summary>
    public const int SenderFieldNumber = 4;
    private string sender_ = "";
    /// <summary>
    /// sender hex address from the owner of the given ERC20 tokens
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Sender {
      get { return sender_; }
      set {
        sender_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MsgConvertERC20);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MsgConvertERC20 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ContractAddress != other.ContractAddress) return false;
      if (Amount != other.Amount) return false;
      if (Receiver != other.Receiver) return false;
      if (Sender != other.Sender) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ContractAddress.Length != 0) hash ^= ContractAddress.GetHashCode();
      if (Amount.Length != 0) hash ^= Amount.GetHashCode();
      if (Receiver.Length != 0) hash ^= Receiver.GetHashCode();
      if (Sender.Length != 0) hash ^= Sender.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ContractAddress.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ContractAddress);
      }
      if (Amount.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Amount);
      }
      if (Receiver.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Receiver);
      }
      if (Sender.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Sender);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ContractAddress.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ContractAddress);
      }
      if (Amount.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Amount);
      }
      if (Receiver.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Receiver);
      }
      if (Sender.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Sender);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ContractAddress.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ContractAddress);
      }
      if (Amount.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Amount);
      }
      if (Receiver.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Receiver);
      }
      if (Sender.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Sender);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MsgConvertERC20 other) {
      if (other == null) {
        return;
      }
      if (other.ContractAddress.Length != 0) {
        ContractAddress = other.ContractAddress;
      }
      if (other.Amount.Length != 0) {
        Amount = other.Amount;
      }
      if (other.Receiver.Length != 0) {
        Receiver = other.Receiver;
      }
      if (other.Sender.Length != 0) {
        Sender = other.Sender;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ContractAddress = input.ReadString();
            break;
          }
          case 18: {
            Amount = input.ReadString();
            break;
          }
          case 26: {
            Receiver = input.ReadString();
            break;
          }
          case 34: {
            Sender = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            ContractAddress = input.ReadString();
            break;
          }
          case 18: {
            Amount = input.ReadString();
            break;
          }
          case 26: {
            Receiver = input.ReadString();
            break;
          }
          case 34: {
            Sender = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// MsgConvertERC20Response returns no fields
  /// </summary>
  public sealed partial class MsgConvertERC20Response : pb::IMessage<MsgConvertERC20Response>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MsgConvertERC20Response> _parser = new pb::MessageParser<MsgConvertERC20Response>(() => new MsgConvertERC20Response());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MsgConvertERC20Response> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Imversed.Erc20.V1.TxReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgConvertERC20Response() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgConvertERC20Response(MsgConvertERC20Response other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgConvertERC20Response Clone() {
      return new MsgConvertERC20Response(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MsgConvertERC20Response);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MsgConvertERC20Response other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MsgConvertERC20Response other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
