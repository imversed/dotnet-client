// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/auth/v1beta1/auth.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cosmos.Auth.V1Beta1 {

  /// <summary>Holder for reflection information generated from cosmos/auth/v1beta1/auth.proto</summary>
  public static partial class AuthReflection {

    #region Descriptor
    /// <summary>File descriptor for cosmos/auth/v1beta1/auth.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AuthReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5jb3Ntb3MvYXV0aC92MWJldGExL2F1dGgucHJvdG8SE2Nvc21vcy5hdXRo",
            "LnYxYmV0YTEaGWNvc21vc19wcm90by9jb3Ntb3MucHJvdG8aFGdvZ29wcm90",
            "by9nb2dvLnByb3RvGhlnb29nbGUvcHJvdG9idWYvYW55LnByb3RvIr0BCgtC",
            "YXNlQWNjb3VudBIpCgdhZGRyZXNzGAEgASgJQhjStC0UY29zbW9zLkFkZHJl",
            "c3NTdHJpbmcSPwoHcHViX2tleRgCIAEoCzIULmdvb2dsZS5wcm90b2J1Zi5B",
            "bnlCGOreHxRwdWJsaWNfa2V5LG9taXRlbXB0eRIWCg5hY2NvdW50X251bWJl",
            "chgDIAEoBBIQCghzZXF1ZW5jZRgEIAEoBDoYiKAfAJigHwDooB8AyrQtCEFj",
            "Y291bnRJIowBCg1Nb2R1bGVBY2NvdW50EjwKDGJhc2VfYWNjb3VudBgBIAEo",
            "CzIgLmNvc21vcy5hdXRoLnYxYmV0YTEuQmFzZUFjY291bnRCBNDeHwESDAoE",
            "bmFtZRgCIAEoCRITCgtwZXJtaXNzaW9ucxgDIAMoCToaiKAfAJigHwDKtC0O",
            "TW9kdWxlQWNjb3VudEki3gEKBlBhcmFtcxIbChNtYXhfbWVtb19jaGFyYWN0",
            "ZXJzGAEgASgEEhQKDHR4X3NpZ19saW1pdBgCIAEoBBIdChV0eF9zaXplX2Nv",
            "c3RfcGVyX2J5dGUYAyABKAQSOQoXc2lnX3ZlcmlmeV9jb3N0X2VkMjU1MTkY",
            "BCABKARCGOLeHxRTaWdWZXJpZnlDb3N0RUQyNTUxORI9ChlzaWdfdmVyaWZ5",
            "X2Nvc3Rfc2VjcDI1NmsxGAUgASgEQhri3h8WU2lnVmVyaWZ5Q29zdFNlY3Ay",
            "NTZrMToI6KAfAZigHwBCK1opZ2l0aHViLmNvbS9jb3Ntb3MvY29zbW9zLXNk",
            "ay94L2F1dGgvdHlwZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::CosmosProto.CosmosReflection.Descriptor, global::Gogoproto.GogoReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Auth.V1Beta1.BaseAccount), global::Cosmos.Auth.V1Beta1.BaseAccount.Parser, new[]{ "Address", "PubKey", "AccountNumber", "Sequence" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Auth.V1Beta1.ModuleAccount), global::Cosmos.Auth.V1Beta1.ModuleAccount.Parser, new[]{ "BaseAccount", "Name", "Permissions" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.Auth.V1Beta1.Params), global::Cosmos.Auth.V1Beta1.Params.Parser, new[]{ "MaxMemoCharacters", "TxSigLimit", "TxSizeCostPerByte", "SigVerifyCostEd25519", "SigVerifyCostSecp256K1" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// BaseAccount defines a base account type. It contains all the necessary fields
  /// for basic account functionality. Any custom account type should extend this
  /// type for additional functionality (e.g. vesting).
  /// </summary>
  public sealed partial class BaseAccount : pb::IMessage<BaseAccount>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BaseAccount> _parser = new pb::MessageParser<BaseAccount>(() => new BaseAccount());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BaseAccount> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Auth.V1Beta1.AuthReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BaseAccount() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BaseAccount(BaseAccount other) : this() {
      address_ = other.address_;
      pubKey_ = other.pubKey_ != null ? other.pubKey_.Clone() : null;
      accountNumber_ = other.accountNumber_;
      sequence_ = other.sequence_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BaseAccount Clone() {
      return new BaseAccount(this);
    }

    /// <summary>Field number for the "address" field.</summary>
    public const int AddressFieldNumber = 1;
    private string address_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Address {
      get { return address_; }
      set {
        address_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pub_key" field.</summary>
    public const int PubKeyFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Any pubKey_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Any PubKey {
      get { return pubKey_; }
      set {
        pubKey_ = value;
      }
    }

    /// <summary>Field number for the "account_number" field.</summary>
    public const int AccountNumberFieldNumber = 3;
    private ulong accountNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong AccountNumber {
      get { return accountNumber_; }
      set {
        accountNumber_ = value;
      }
    }

    /// <summary>Field number for the "sequence" field.</summary>
    public const int SequenceFieldNumber = 4;
    private ulong sequence_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Sequence {
      get { return sequence_; }
      set {
        sequence_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BaseAccount);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BaseAccount other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Address != other.Address) return false;
      if (!object.Equals(PubKey, other.PubKey)) return false;
      if (AccountNumber != other.AccountNumber) return false;
      if (Sequence != other.Sequence) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Address.Length != 0) hash ^= Address.GetHashCode();
      if (pubKey_ != null) hash ^= PubKey.GetHashCode();
      if (AccountNumber != 0UL) hash ^= AccountNumber.GetHashCode();
      if (Sequence != 0UL) hash ^= Sequence.GetHashCode();
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
      if (Address.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Address);
      }
      if (pubKey_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PubKey);
      }
      if (AccountNumber != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(AccountNumber);
      }
      if (Sequence != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(Sequence);
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
      if (Address.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Address);
      }
      if (pubKey_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PubKey);
      }
      if (AccountNumber != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(AccountNumber);
      }
      if (Sequence != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(Sequence);
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
      if (Address.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Address);
      }
      if (pubKey_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PubKey);
      }
      if (AccountNumber != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(AccountNumber);
      }
      if (Sequence != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Sequence);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BaseAccount other) {
      if (other == null) {
        return;
      }
      if (other.Address.Length != 0) {
        Address = other.Address;
      }
      if (other.pubKey_ != null) {
        if (pubKey_ == null) {
          PubKey = new global::Google.Protobuf.WellKnownTypes.Any();
        }
        PubKey.MergeFrom(other.PubKey);
      }
      if (other.AccountNumber != 0UL) {
        AccountNumber = other.AccountNumber;
      }
      if (other.Sequence != 0UL) {
        Sequence = other.Sequence;
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
            Address = input.ReadString();
            break;
          }
          case 18: {
            if (pubKey_ == null) {
              PubKey = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(PubKey);
            break;
          }
          case 24: {
            AccountNumber = input.ReadUInt64();
            break;
          }
          case 32: {
            Sequence = input.ReadUInt64();
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
            Address = input.ReadString();
            break;
          }
          case 18: {
            if (pubKey_ == null) {
              PubKey = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(PubKey);
            break;
          }
          case 24: {
            AccountNumber = input.ReadUInt64();
            break;
          }
          case 32: {
            Sequence = input.ReadUInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// ModuleAccount defines an account for modules that holds coins on a pool.
  /// </summary>
  public sealed partial class ModuleAccount : pb::IMessage<ModuleAccount>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ModuleAccount> _parser = new pb::MessageParser<ModuleAccount>(() => new ModuleAccount());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ModuleAccount> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Auth.V1Beta1.AuthReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ModuleAccount() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ModuleAccount(ModuleAccount other) : this() {
      baseAccount_ = other.baseAccount_ != null ? other.baseAccount_.Clone() : null;
      name_ = other.name_;
      permissions_ = other.permissions_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ModuleAccount Clone() {
      return new ModuleAccount(this);
    }

    /// <summary>Field number for the "base_account" field.</summary>
    public const int BaseAccountFieldNumber = 1;
    private global::Cosmos.Auth.V1Beta1.BaseAccount baseAccount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Cosmos.Auth.V1Beta1.BaseAccount BaseAccount {
      get { return baseAccount_; }
      set {
        baseAccount_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "permissions" field.</summary>
    public const int PermissionsFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_permissions_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> permissions_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> Permissions {
      get { return permissions_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ModuleAccount);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ModuleAccount other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(BaseAccount, other.BaseAccount)) return false;
      if (Name != other.Name) return false;
      if(!permissions_.Equals(other.permissions_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (baseAccount_ != null) hash ^= BaseAccount.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= permissions_.GetHashCode();
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
      if (baseAccount_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(BaseAccount);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      permissions_.WriteTo(output, _repeated_permissions_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (baseAccount_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(BaseAccount);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      permissions_.WriteTo(ref output, _repeated_permissions_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (baseAccount_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BaseAccount);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += permissions_.CalculateSize(_repeated_permissions_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ModuleAccount other) {
      if (other == null) {
        return;
      }
      if (other.baseAccount_ != null) {
        if (baseAccount_ == null) {
          BaseAccount = new global::Cosmos.Auth.V1Beta1.BaseAccount();
        }
        BaseAccount.MergeFrom(other.BaseAccount);
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      permissions_.Add(other.permissions_);
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
            if (baseAccount_ == null) {
              BaseAccount = new global::Cosmos.Auth.V1Beta1.BaseAccount();
            }
            input.ReadMessage(BaseAccount);
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            permissions_.AddEntriesFrom(input, _repeated_permissions_codec);
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
            if (baseAccount_ == null) {
              BaseAccount = new global::Cosmos.Auth.V1Beta1.BaseAccount();
            }
            input.ReadMessage(BaseAccount);
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            permissions_.AddEntriesFrom(ref input, _repeated_permissions_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Params defines the parameters for the auth module.
  /// </summary>
  public sealed partial class Params : pb::IMessage<Params>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Params> _parser = new pb::MessageParser<Params>(() => new Params());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Params> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.Auth.V1Beta1.AuthReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Params() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Params(Params other) : this() {
      maxMemoCharacters_ = other.maxMemoCharacters_;
      txSigLimit_ = other.txSigLimit_;
      txSizeCostPerByte_ = other.txSizeCostPerByte_;
      sigVerifyCostEd25519_ = other.sigVerifyCostEd25519_;
      sigVerifyCostSecp256K1_ = other.sigVerifyCostSecp256K1_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Params Clone() {
      return new Params(this);
    }

    /// <summary>Field number for the "max_memo_characters" field.</summary>
    public const int MaxMemoCharactersFieldNumber = 1;
    private ulong maxMemoCharacters_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong MaxMemoCharacters {
      get { return maxMemoCharacters_; }
      set {
        maxMemoCharacters_ = value;
      }
    }

    /// <summary>Field number for the "tx_sig_limit" field.</summary>
    public const int TxSigLimitFieldNumber = 2;
    private ulong txSigLimit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong TxSigLimit {
      get { return txSigLimit_; }
      set {
        txSigLimit_ = value;
      }
    }

    /// <summary>Field number for the "tx_size_cost_per_byte" field.</summary>
    public const int TxSizeCostPerByteFieldNumber = 3;
    private ulong txSizeCostPerByte_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong TxSizeCostPerByte {
      get { return txSizeCostPerByte_; }
      set {
        txSizeCostPerByte_ = value;
      }
    }

    /// <summary>Field number for the "sig_verify_cost_ed25519" field.</summary>
    public const int SigVerifyCostEd25519FieldNumber = 4;
    private ulong sigVerifyCostEd25519_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong SigVerifyCostEd25519 {
      get { return sigVerifyCostEd25519_; }
      set {
        sigVerifyCostEd25519_ = value;
      }
    }

    /// <summary>Field number for the "sig_verify_cost_secp256k1" field.</summary>
    public const int SigVerifyCostSecp256K1FieldNumber = 5;
    private ulong sigVerifyCostSecp256K1_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong SigVerifyCostSecp256K1 {
      get { return sigVerifyCostSecp256K1_; }
      set {
        sigVerifyCostSecp256K1_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Params);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Params other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MaxMemoCharacters != other.MaxMemoCharacters) return false;
      if (TxSigLimit != other.TxSigLimit) return false;
      if (TxSizeCostPerByte != other.TxSizeCostPerByte) return false;
      if (SigVerifyCostEd25519 != other.SigVerifyCostEd25519) return false;
      if (SigVerifyCostSecp256K1 != other.SigVerifyCostSecp256K1) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MaxMemoCharacters != 0UL) hash ^= MaxMemoCharacters.GetHashCode();
      if (TxSigLimit != 0UL) hash ^= TxSigLimit.GetHashCode();
      if (TxSizeCostPerByte != 0UL) hash ^= TxSizeCostPerByte.GetHashCode();
      if (SigVerifyCostEd25519 != 0UL) hash ^= SigVerifyCostEd25519.GetHashCode();
      if (SigVerifyCostSecp256K1 != 0UL) hash ^= SigVerifyCostSecp256K1.GetHashCode();
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
      if (MaxMemoCharacters != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(MaxMemoCharacters);
      }
      if (TxSigLimit != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(TxSigLimit);
      }
      if (TxSizeCostPerByte != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(TxSizeCostPerByte);
      }
      if (SigVerifyCostEd25519 != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(SigVerifyCostEd25519);
      }
      if (SigVerifyCostSecp256K1 != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(SigVerifyCostSecp256K1);
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
      if (MaxMemoCharacters != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(MaxMemoCharacters);
      }
      if (TxSigLimit != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(TxSigLimit);
      }
      if (TxSizeCostPerByte != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(TxSizeCostPerByte);
      }
      if (SigVerifyCostEd25519 != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(SigVerifyCostEd25519);
      }
      if (SigVerifyCostSecp256K1 != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(SigVerifyCostSecp256K1);
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
      if (MaxMemoCharacters != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(MaxMemoCharacters);
      }
      if (TxSigLimit != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TxSigLimit);
      }
      if (TxSizeCostPerByte != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TxSizeCostPerByte);
      }
      if (SigVerifyCostEd25519 != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(SigVerifyCostEd25519);
      }
      if (SigVerifyCostSecp256K1 != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(SigVerifyCostSecp256K1);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Params other) {
      if (other == null) {
        return;
      }
      if (other.MaxMemoCharacters != 0UL) {
        MaxMemoCharacters = other.MaxMemoCharacters;
      }
      if (other.TxSigLimit != 0UL) {
        TxSigLimit = other.TxSigLimit;
      }
      if (other.TxSizeCostPerByte != 0UL) {
        TxSizeCostPerByte = other.TxSizeCostPerByte;
      }
      if (other.SigVerifyCostEd25519 != 0UL) {
        SigVerifyCostEd25519 = other.SigVerifyCostEd25519;
      }
      if (other.SigVerifyCostSecp256K1 != 0UL) {
        SigVerifyCostSecp256K1 = other.SigVerifyCostSecp256K1;
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
          case 8: {
            MaxMemoCharacters = input.ReadUInt64();
            break;
          }
          case 16: {
            TxSigLimit = input.ReadUInt64();
            break;
          }
          case 24: {
            TxSizeCostPerByte = input.ReadUInt64();
            break;
          }
          case 32: {
            SigVerifyCostEd25519 = input.ReadUInt64();
            break;
          }
          case 40: {
            SigVerifyCostSecp256K1 = input.ReadUInt64();
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
          case 8: {
            MaxMemoCharacters = input.ReadUInt64();
            break;
          }
          case 16: {
            TxSigLimit = input.ReadUInt64();
            break;
          }
          case 24: {
            TxSizeCostPerByte = input.ReadUInt64();
            break;
          }
          case 32: {
            SigVerifyCostEd25519 = input.ReadUInt64();
            break;
          }
          case 40: {
            SigVerifyCostSecp256K1 = input.ReadUInt64();
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
