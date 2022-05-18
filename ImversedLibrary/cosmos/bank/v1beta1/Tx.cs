// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/bank/v1beta1/tx.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cosmos.Bank.V1Beta1 {

  /// <summary>Holder for reflection information generated from cosmos/bank/v1beta1/tx.proto</summary>
  public static partial class TxReflection {

    #region Descriptor
    /// <summary>File descriptor for cosmos/bank/v1beta1/tx.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TxReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chxjb3Ntb3MvYmFuay92MWJldGExL3R4LnByb3RvEhNjb3Ntb3MuYmFuay52",
            "MWJldGExGhRnb2dvcHJvdG8vZ29nby5wcm90bxoeY29zbW9zL2Jhc2UvdjFi",
            "ZXRhMS9jb2luLnByb3RvGh5jb3Ntb3MvYmFuay92MWJldGExL2JhbmsucHJv",
            "dG8iygEKB01zZ1NlbmQSLQoMZnJvbV9hZGRyZXNzGAEgASgJQhfy3h8TeWFt",
            "bDoiZnJvbV9hZGRyZXNzIhIpCgp0b19hZGRyZXNzGAIgASgJQhXy3h8ReWFt",
            "bDoidG9fYWRkcmVzcyISWwoGYW1vdW50GAMgAygLMhkuY29zbW9zLmJhc2Uu",
            "djFiZXRhMS5Db2luQjDI3h8Aqt8fKGdpdGh1Yi5jb20vY29zbW9zL2Nvc21v",
            "cy1zZGsvdHlwZXMuQ29pbnM6COigHwCIoB8AIhEKD01zZ1NlbmRSZXNwb25z",
            "ZSJ6CgxNc2dNdWx0aVNlbmQSMAoGaW5wdXRzGAEgAygLMhouY29zbW9zLmJh",
            "bmsudjFiZXRhMS5JbnB1dEIEyN4fABIyCgdvdXRwdXRzGAIgAygLMhsuY29z",
            "bW9zLmJhbmsudjFiZXRhMS5PdXRwdXRCBMjeHwA6BOigHwAiFgoUTXNnTXVs",
            "dGlTZW5kUmVzcG9uc2UyrAEKA01zZxJKCgRTZW5kEhwuY29zbW9zLmJhbmsu",
            "djFiZXRhMS5Nc2dTZW5kGiQuY29zbW9zLmJhbmsudjFiZXRhMS5Nc2dTZW5k",
            "UmVzcG9uc2USWQoJTXVsdGlTZW5kEiEuY29zbW9zLmJhbmsudjFiZXRhMS5N",
            "c2dNdWx0aVNlbmQaKS5jb3Ntb3MuYmFuay52MWJldGExLk1zZ011bHRpU2Vu",
            "ZFJlc3BvbnNlQitaKWdpdGh1Yi5jb20vY29zbW9zL2Nvc21vcy1zZGsveC9i",
            "YW5rL3R5cGVzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Gogoproto.GogoReflection.Descriptor, global::Cosmos.Base.V1Beta1.CoinReflection.Descriptor, global::Cosmos.Bank.V1Beta1.BankReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Bank.V1Beta1.MsgSend), global::Cosmos.Bank.V1Beta1.MsgSend.Parser, new[]{ "FromAddress", "ToAddress", "Amount" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Bank.V1Beta1.MsgSendResponse), global::Cosmos.Bank.V1Beta1.MsgSendResponse.Parser, null, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Bank.V1Beta1.MsgMultiSend), global::Cosmos.Bank.V1Beta1.MsgMultiSend.Parser, new[]{ "Inputs", "Outputs" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Bank.V1Beta1.MsgMultiSendResponse), global::Cosmos.Bank.V1Beta1.MsgMultiSendResponse.Parser, null, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// MsgSend represents a message to send coins from one account to another.
  /// </summary>
  public sealed partial class MsgSend : pb::IMessage<MsgSend>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MsgSend> _parser = new pb::MessageParser<MsgSend>(() => new MsgSend());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MsgSend> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Bank.V1Beta1.TxReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgSend() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgSend(MsgSend other) : this() {
      fromAddress_ = other.fromAddress_;
      toAddress_ = other.toAddress_;
      amount_ = other.amount_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgSend Clone() {
      return new MsgSend(this);
    }

    /// <summary>Field number for the "from_address" field.</summary>
    public const int FromAddressFieldNumber = 1;
    private string fromAddress_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string FromAddress {
      get { return fromAddress_; }
      set {
        fromAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "to_address" field.</summary>
    public const int ToAddressFieldNumber = 2;
    private string toAddress_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ToAddress {
      get { return toAddress_; }
      set {
        toAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "amount" field.</summary>
    public const int AmountFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Cosmos.Base.V1Beta1.Coin> _repeated_amount_codec
        = pb::FieldCodec.ForMessage(26, global::Cosmos.Base.V1Beta1.Coin.Parser);
    private readonly pbc::RepeatedField<global::Cosmos.Base.V1Beta1.Coin> amount_ = new pbc::RepeatedField<global::Cosmos.Base.V1Beta1.Coin>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Cosmos.Base.V1Beta1.Coin> Amount {
      get { return amount_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MsgSend);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MsgSend other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FromAddress != other.FromAddress) return false;
      if (ToAddress != other.ToAddress) return false;
      if(!amount_.Equals(other.amount_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FromAddress.Length != 0) hash ^= FromAddress.GetHashCode();
      if (ToAddress.Length != 0) hash ^= ToAddress.GetHashCode();
      hash ^= amount_.GetHashCode();
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
      if (FromAddress.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FromAddress);
      }
      if (ToAddress.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ToAddress);
      }
      amount_.WriteTo(output, _repeated_amount_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (FromAddress.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FromAddress);
      }
      if (ToAddress.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ToAddress);
      }
      amount_.WriteTo(ref output, _repeated_amount_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (FromAddress.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FromAddress);
      }
      if (ToAddress.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ToAddress);
      }
      size += amount_.CalculateSize(_repeated_amount_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MsgSend other) {
      if (other == null) {
        return;
      }
      if (other.FromAddress.Length != 0) {
        FromAddress = other.FromAddress;
      }
      if (other.ToAddress.Length != 0) {
        ToAddress = other.ToAddress;
      }
      amount_.Add(other.amount_);
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
            FromAddress = input.ReadString();
            break;
          }
          case 18: {
            ToAddress = input.ReadString();
            break;
          }
          case 26: {
            amount_.AddEntriesFrom(input, _repeated_amount_codec);
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
            FromAddress = input.ReadString();
            break;
          }
          case 18: {
            ToAddress = input.ReadString();
            break;
          }
          case 26: {
            amount_.AddEntriesFrom(ref input, _repeated_amount_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// MsgSendResponse defines the Msg/Send response type.
  /// </summary>
  public sealed partial class MsgSendResponse : pb::IMessage<MsgSendResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MsgSendResponse> _parser = new pb::MessageParser<MsgSendResponse>(() => new MsgSendResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MsgSendResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Bank.V1Beta1.TxReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgSendResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgSendResponse(MsgSendResponse other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgSendResponse Clone() {
      return new MsgSendResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MsgSendResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MsgSendResponse other) {
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
    public void MergeFrom(MsgSendResponse other) {
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
  /// MsgMultiSend represents an arbitrary multi-in, multi-out send message.
  /// </summary>
  public sealed partial class MsgMultiSend : pb::IMessage<MsgMultiSend>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MsgMultiSend> _parser = new pb::MessageParser<MsgMultiSend>(() => new MsgMultiSend());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MsgMultiSend> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Bank.V1Beta1.TxReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgMultiSend() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgMultiSend(MsgMultiSend other) : this() {
      inputs_ = other.inputs_.Clone();
      outputs_ = other.outputs_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgMultiSend Clone() {
      return new MsgMultiSend(this);
    }

    /// <summary>Field number for the "inputs" field.</summary>
    public const int InputsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Cosmos.Bank.V1Beta1.Input> _repeated_inputs_codec
        = pb::FieldCodec.ForMessage(10, global::Cosmos.Bank.V1Beta1.Input.Parser);
    private readonly pbc::RepeatedField<global::Cosmos.Bank.V1Beta1.Input> inputs_ = new pbc::RepeatedField<global::Cosmos.Bank.V1Beta1.Input>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Cosmos.Bank.V1Beta1.Input> Inputs {
      get { return inputs_; }
    }

    /// <summary>Field number for the "outputs" field.</summary>
    public const int OutputsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Cosmos.Bank.V1Beta1.Output> _repeated_outputs_codec
        = pb::FieldCodec.ForMessage(18, global::Cosmos.Bank.V1Beta1.Output.Parser);
    private readonly pbc::RepeatedField<global::Cosmos.Bank.V1Beta1.Output> outputs_ = new pbc::RepeatedField<global::Cosmos.Bank.V1Beta1.Output>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Cosmos.Bank.V1Beta1.Output> Outputs {
      get { return outputs_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MsgMultiSend);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MsgMultiSend other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!inputs_.Equals(other.inputs_)) return false;
      if(!outputs_.Equals(other.outputs_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= inputs_.GetHashCode();
      hash ^= outputs_.GetHashCode();
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
      inputs_.WriteTo(output, _repeated_inputs_codec);
      outputs_.WriteTo(output, _repeated_outputs_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      inputs_.WriteTo(ref output, _repeated_inputs_codec);
      outputs_.WriteTo(ref output, _repeated_outputs_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += inputs_.CalculateSize(_repeated_inputs_codec);
      size += outputs_.CalculateSize(_repeated_outputs_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MsgMultiSend other) {
      if (other == null) {
        return;
      }
      inputs_.Add(other.inputs_);
      outputs_.Add(other.outputs_);
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
            inputs_.AddEntriesFrom(input, _repeated_inputs_codec);
            break;
          }
          case 18: {
            outputs_.AddEntriesFrom(input, _repeated_outputs_codec);
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
            inputs_.AddEntriesFrom(ref input, _repeated_inputs_codec);
            break;
          }
          case 18: {
            outputs_.AddEntriesFrom(ref input, _repeated_outputs_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// MsgMultiSendResponse defines the Msg/MultiSend response type.
  /// </summary>
  public sealed partial class MsgMultiSendResponse : pb::IMessage<MsgMultiSendResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MsgMultiSendResponse> _parser = new pb::MessageParser<MsgMultiSendResponse>(() => new MsgMultiSendResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MsgMultiSendResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Bank.V1Beta1.TxReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgMultiSendResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgMultiSendResponse(MsgMultiSendResponse other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgMultiSendResponse Clone() {
      return new MsgMultiSendResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MsgMultiSendResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MsgMultiSendResponse other) {
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
    public void MergeFrom(MsgMultiSendResponse other) {
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
