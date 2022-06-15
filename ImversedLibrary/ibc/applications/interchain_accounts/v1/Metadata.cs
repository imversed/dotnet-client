// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ibc/applications/interchain_accounts/v1/metadata.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Ibc.Applications.InterchainAccounts.V1 {

  /// <summary>Holder for reflection information generated from ibc/applications/interchain_accounts/v1/metadata.proto</summary>
  public static partial class MetadataReflection {

    #region Descriptor
    /// <summary>File descriptor for ibc/applications/interchain_accounts/v1/metadata.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MetadataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZpYmMvYXBwbGljYXRpb25zL2ludGVyY2hhaW5fYWNjb3VudHMvdjEvbWV0",
            "YWRhdGEucHJvdG8SJ2liYy5hcHBsaWNhdGlvbnMuaW50ZXJjaGFpbl9hY2Nv",
            "dW50cy52MRoUZ29nb3Byb3RvL2dvZ28ucHJvdG8i0QEKCE1ldGFkYXRhEg8K",
            "B3ZlcnNpb24YASABKAkSRQoYY29udHJvbGxlcl9jb25uZWN0aW9uX2lkGAIg",
            "ASgJQiPy3h8feWFtbDoiY29udHJvbGxlcl9jb25uZWN0aW9uX2lkIhI5ChJo",
            "b3N0X2Nvbm5lY3Rpb25faWQYAyABKAlCHfLeHxl5YW1sOiJob3N0X2Nvbm5l",
            "Y3Rpb25faWQiEg8KB2FkZHJlc3MYBCABKAkSEAoIZW5jb2RpbmcYBSABKAkS",
            "DwoHdHhfdHlwZRgGIAEoCUJHWkVnaXRodWIuY29tL2Nvc21vcy9pYmMtZ28v",
            "djMvbW9kdWxlcy9hcHBzLzI3LWludGVyY2hhaW4tYWNjb3VudHMvdHlwZXNi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Gogoproto.GogoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Ibc.Applications.InterchainAccounts.V1.Metadata), global::Ibc.Applications.InterchainAccounts.V1.Metadata.Parser, new[]{ "Version", "ControllerConnectionId", "HostConnectionId", "Address", "Encoding", "TxType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Metadata defines a set of protocol specific data encoded into the ICS27 channel version bytestring
  /// See ICS004: https://github.com/cosmos/ibc/tree/master/spec/core/ics-004-channel-and-packet-semantics#Versioning
  /// </summary>
  public sealed partial class Metadata : pb::IMessage<Metadata>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Metadata> _parser = new pb::MessageParser<Metadata>(() => new Metadata());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Metadata> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Ibc.Applications.InterchainAccounts.V1.MetadataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Metadata() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Metadata(Metadata other) : this() {
      version_ = other.version_;
      controllerConnectionId_ = other.controllerConnectionId_;
      hostConnectionId_ = other.hostConnectionId_;
      address_ = other.address_;
      encoding_ = other.encoding_;
      txType_ = other.txType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Metadata Clone() {
      return new Metadata(this);
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 1;
    private string version_ = "";
    /// <summary>
    /// version defines the ICS27 protocol version
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Version {
      get { return version_; }
      set {
        version_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "controller_connection_id" field.</summary>
    public const int ControllerConnectionIdFieldNumber = 2;
    private string controllerConnectionId_ = "";
    /// <summary>
    /// controller_connection_id is the connection identifier associated with the controller chain
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ControllerConnectionId {
      get { return controllerConnectionId_; }
      set {
        controllerConnectionId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "host_connection_id" field.</summary>
    public const int HostConnectionIdFieldNumber = 3;
    private string hostConnectionId_ = "";
    /// <summary>
    /// host_connection_id is the connection identifier associated with the host chain
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string HostConnectionId {
      get { return hostConnectionId_; }
      set {
        hostConnectionId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "address" field.</summary>
    public const int AddressFieldNumber = 4;
    private string address_ = "";
    /// <summary>
    /// address defines the interchain account address to be fulfilled upon the OnChanOpenTry handshake step
    /// NOTE: the address field is empty on the OnChanOpenInit handshake step
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Address {
      get { return address_; }
      set {
        address_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "encoding" field.</summary>
    public const int EncodingFieldNumber = 5;
    private string encoding_ = "";
    /// <summary>
    /// encoding defines the supported codec format
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Encoding {
      get { return encoding_; }
      set {
        encoding_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "tx_type" field.</summary>
    public const int TxTypeFieldNumber = 6;
    private string txType_ = "";
    /// <summary>
    /// tx_type defines the type of transactions the interchain account can execute
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string TxType {
      get { return txType_; }
      set {
        txType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Metadata);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Metadata other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Version != other.Version) return false;
      if (ControllerConnectionId != other.ControllerConnectionId) return false;
      if (HostConnectionId != other.HostConnectionId) return false;
      if (Address != other.Address) return false;
      if (Encoding != other.Encoding) return false;
      if (TxType != other.TxType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Version.Length != 0) hash ^= Version.GetHashCode();
      if (ControllerConnectionId.Length != 0) hash ^= ControllerConnectionId.GetHashCode();
      if (HostConnectionId.Length != 0) hash ^= HostConnectionId.GetHashCode();
      if (Address.Length != 0) hash ^= Address.GetHashCode();
      if (Encoding.Length != 0) hash ^= Encoding.GetHashCode();
      if (TxType.Length != 0) hash ^= TxType.GetHashCode();
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
      if (Version.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Version);
      }
      if (ControllerConnectionId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ControllerConnectionId);
      }
      if (HostConnectionId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(HostConnectionId);
      }
      if (Address.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Address);
      }
      if (Encoding.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Encoding);
      }
      if (TxType.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(TxType);
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
      if (Version.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Version);
      }
      if (ControllerConnectionId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ControllerConnectionId);
      }
      if (HostConnectionId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(HostConnectionId);
      }
      if (Address.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Address);
      }
      if (Encoding.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Encoding);
      }
      if (TxType.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(TxType);
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
      if (Version.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Version);
      }
      if (ControllerConnectionId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ControllerConnectionId);
      }
      if (HostConnectionId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(HostConnectionId);
      }
      if (Address.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Address);
      }
      if (Encoding.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Encoding);
      }
      if (TxType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TxType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Metadata other) {
      if (other == null) {
        return;
      }
      if (other.Version.Length != 0) {
        Version = other.Version;
      }
      if (other.ControllerConnectionId.Length != 0) {
        ControllerConnectionId = other.ControllerConnectionId;
      }
      if (other.HostConnectionId.Length != 0) {
        HostConnectionId = other.HostConnectionId;
      }
      if (other.Address.Length != 0) {
        Address = other.Address;
      }
      if (other.Encoding.Length != 0) {
        Encoding = other.Encoding;
      }
      if (other.TxType.Length != 0) {
        TxType = other.TxType;
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
            Version = input.ReadString();
            break;
          }
          case 18: {
            ControllerConnectionId = input.ReadString();
            break;
          }
          case 26: {
            HostConnectionId = input.ReadString();
            break;
          }
          case 34: {
            Address = input.ReadString();
            break;
          }
          case 42: {
            Encoding = input.ReadString();
            break;
          }
          case 50: {
            TxType = input.ReadString();
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
            Version = input.ReadString();
            break;
          }
          case 18: {
            ControllerConnectionId = input.ReadString();
            break;
          }
          case 26: {
            HostConnectionId = input.ReadString();
            break;
          }
          case 34: {
            Address = input.ReadString();
            break;
          }
          case 42: {
            Encoding = input.ReadString();
            break;
          }
          case 50: {
            TxType = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code