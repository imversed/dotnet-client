// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cosmos/app/v1alpha1/module.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cosmos.App.V1Alpha1 {

  /// <summary>Holder for reflection information generated from cosmos/app/v1alpha1/module.proto</summary>
  public static partial class ModuleReflection {

    #region Descriptor
    /// <summary>File descriptor for cosmos/app/v1alpha1/module.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ModuleReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBjb3Ntb3MvYXBwL3YxYWxwaGExL21vZHVsZS5wcm90bxITY29zbW9zLmFw",
            "cC52MWFscGhhMRogZ29vZ2xlL3Byb3RvYnVmL2Rlc2NyaXB0b3IucHJvdG8i",
            "oQEKEE1vZHVsZURlc2NyaXB0b3ISEQoJZ29faW1wb3J0GAEgASgJEjoKC3Vz",
            "ZV9wYWNrYWdlGAIgAygLMiUuY29zbW9zLmFwcC52MWFscGhhMS5QYWNrYWdl",
            "UmVmZXJlbmNlEj4KEGNhbl9taWdyYXRlX2Zyb20YAyADKAsyJC5jb3Ntb3Mu",
            "YXBwLnYxYWxwaGExLk1pZ3JhdGVGcm9tSW5mbyIyChBQYWNrYWdlUmVmZXJl",
            "bmNlEgwKBG5hbWUYASABKAkSEAoIcmV2aXNpb24YAiABKA0iIQoPTWlncmF0",
            "ZUZyb21JbmZvEg4KBm1vZHVsZRgBIAEoCTpZCgZtb2R1bGUSHy5nb29nbGUu",
            "cHJvdG9idWYuTWVzc2FnZU9wdGlvbnMYh+iiGyABKAsyJS5jb3Ntb3MuYXBw",
            "LnYxYWxwaGExLk1vZHVsZURlc2NyaXB0b3JiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.Reflection.DescriptorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pb::Extension[] { ModuleExtensions.Module }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.App.V1Alpha1.ModuleDescriptor), global::Cosmos.App.V1Alpha1.ModuleDescriptor.Parser, new[]{ "GoImport", "UsePackage", "CanMigrateFrom" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.App.V1Alpha1.PackageReference), global::Cosmos.App.V1Alpha1.PackageReference.Parser, new[]{ "Name", "Revision" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Cosmos.App.V1Alpha1.MigrateFromInfo), global::Cosmos.App.V1Alpha1.MigrateFromInfo.Parser, new[]{ "Module" }, null, null, null, null)
          }));
    }
    #endregion

  }
  /// <summary>Holder for extension identifiers generated from the top level of cosmos/app/v1alpha1/module.proto</summary>
  public static partial class ModuleExtensions {
    /// <summary>
    /// module indicates that this proto type is a config object for an app module
    /// and optionally provides other descriptive information about the module.
    /// It is recommended that a new module config object and go module is versioned
    /// for every state machine breaking version of a module. The recommended
    /// pattern for doing this is to put module config objects in a separate proto
    /// package from the API they expose. Ex: the cosmos.group.v1 API would be
    /// exposed by module configs cosmos.group.module.v1, cosmos.group.module.v2, etc.
    /// </summary>
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, global::Cosmos.App.V1Alpha1.ModuleDescriptor> Module =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, global::Cosmos.App.V1Alpha1.ModuleDescriptor>(57193479, pb::FieldCodec.ForMessage(457547834, global::Cosmos.App.V1Alpha1.ModuleDescriptor.Parser));
  }

  #region Messages
  /// <summary>
  /// ModuleDescriptor describes an app module.
  /// </summary>
  public sealed partial class ModuleDescriptor : pb::IMessage<ModuleDescriptor>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ModuleDescriptor> _parser = new pb::MessageParser<ModuleDescriptor>(() => new ModuleDescriptor());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ModuleDescriptor> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.App.V1Alpha1.ModuleReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ModuleDescriptor() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ModuleDescriptor(ModuleDescriptor other) : this() {
      goImport_ = other.goImport_;
      usePackage_ = other.usePackage_.Clone();
      canMigrateFrom_ = other.canMigrateFrom_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ModuleDescriptor Clone() {
      return new ModuleDescriptor(this);
    }

    /// <summary>Field number for the "go_import" field.</summary>
    public const int GoImportFieldNumber = 1;
    private string goImport_ = "";
    /// <summary>
    /// go_import names the package that should be imported by an app to load the
    /// module in the runtime module registry. It is required to make debugging
    /// of configuration errors easier for users.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string GoImport {
      get { return goImport_; }
      set {
        goImport_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "use_package" field.</summary>
    public const int UsePackageFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Cosmos.App.V1Alpha1.PackageReference> _repeated_usePackage_codec
        = pb::FieldCodec.ForMessage(18, global::Cosmos.App.V1Alpha1.PackageReference.Parser);
    private readonly pbc::RepeatedField<global::Cosmos.App.V1Alpha1.PackageReference> usePackage_ = new pbc::RepeatedField<global::Cosmos.App.V1Alpha1.PackageReference>();
    /// <summary>
    /// use_package refers to a protobuf package that this module
    /// uses and exposes to the world. In an app, only one module should "use"
    /// or own a single protobuf package. It is assumed that the module uses
    /// all of the .proto files in a single package.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Cosmos.App.V1Alpha1.PackageReference> UsePackage {
      get { return usePackage_; }
    }

    /// <summary>Field number for the "can_migrate_from" field.</summary>
    public const int CanMigrateFromFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Cosmos.App.V1Alpha1.MigrateFromInfo> _repeated_canMigrateFrom_codec
        = pb::FieldCodec.ForMessage(26, global::Cosmos.App.V1Alpha1.MigrateFromInfo.Parser);
    private readonly pbc::RepeatedField<global::Cosmos.App.V1Alpha1.MigrateFromInfo> canMigrateFrom_ = new pbc::RepeatedField<global::Cosmos.App.V1Alpha1.MigrateFromInfo>();
    /// <summary>
    /// can_migrate_from defines which module versions this module can migrate
    /// state from. The framework will check that one module version is able to
    /// migrate from a previous module version before attempting to update its
    /// config. It is assumed that modules can transitively migrate from earlier
    /// versions. For instance if v3 declares it can migrate from v2, and v2
    /// declares it can migrate from v1, the framework knows how to migrate
    /// from v1 to v3, assuming all 3 module versions are registered at runtime.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Cosmos.App.V1Alpha1.MigrateFromInfo> CanMigrateFrom {
      get { return canMigrateFrom_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ModuleDescriptor);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ModuleDescriptor other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GoImport != other.GoImport) return false;
      if(!usePackage_.Equals(other.usePackage_)) return false;
      if(!canMigrateFrom_.Equals(other.canMigrateFrom_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GoImport.Length != 0) hash ^= GoImport.GetHashCode();
      hash ^= usePackage_.GetHashCode();
      hash ^= canMigrateFrom_.GetHashCode();
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
      if (GoImport.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(GoImport);
      }
      usePackage_.WriteTo(output, _repeated_usePackage_codec);
      canMigrateFrom_.WriteTo(output, _repeated_canMigrateFrom_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (GoImport.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(GoImport);
      }
      usePackage_.WriteTo(ref output, _repeated_usePackage_codec);
      canMigrateFrom_.WriteTo(ref output, _repeated_canMigrateFrom_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (GoImport.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GoImport);
      }
      size += usePackage_.CalculateSize(_repeated_usePackage_codec);
      size += canMigrateFrom_.CalculateSize(_repeated_canMigrateFrom_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ModuleDescriptor other) {
      if (other == null) {
        return;
      }
      if (other.GoImport.Length != 0) {
        GoImport = other.GoImport;
      }
      usePackage_.Add(other.usePackage_);
      canMigrateFrom_.Add(other.canMigrateFrom_);
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
            GoImport = input.ReadString();
            break;
          }
          case 18: {
            usePackage_.AddEntriesFrom(input, _repeated_usePackage_codec);
            break;
          }
          case 26: {
            canMigrateFrom_.AddEntriesFrom(input, _repeated_canMigrateFrom_codec);
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
            GoImport = input.ReadString();
            break;
          }
          case 18: {
            usePackage_.AddEntriesFrom(ref input, _repeated_usePackage_codec);
            break;
          }
          case 26: {
            canMigrateFrom_.AddEntriesFrom(ref input, _repeated_canMigrateFrom_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// PackageReference is a reference to a protobuf package used by a module.
  /// </summary>
  public sealed partial class PackageReference : pb::IMessage<PackageReference>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PackageReference> _parser = new pb::MessageParser<PackageReference>(() => new PackageReference());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PackageReference> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.App.V1Alpha1.ModuleReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PackageReference() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PackageReference(PackageReference other) : this() {
      name_ = other.name_;
      revision_ = other.revision_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PackageReference Clone() {
      return new PackageReference(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// name is the fully-qualified name of the package.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "revision" field.</summary>
    public const int RevisionFieldNumber = 2;
    private uint revision_;
    /// <summary>
    /// revision is the optional revision of the package that is being used.
    /// Protobuf packages used in Cosmos should generally have a major version
    /// as the last part of the package name, ex. foo.bar.baz.v1.
    /// The revision of a package can be thought of as the minor version of a
    /// package which has additional backwards compatible definitions that weren't
    /// present in a previous version.
    ///
    /// A package should indicate its revision with a source code comment
    /// above the package declaration in one of its files containing the
    /// text "Revision N" where N is an integer revision. All packages start
    /// at revision 0 the first time they are released in a module.
    ///
    /// When a new version of a module is released and items are added to existing
    /// .proto files, these definitions should contain comments of the form
    /// "Since Revision N" where N is an integer revision.
    ///
    /// When the module runtime starts up, it will check the pinned proto
    /// image and panic if there are runtime protobuf definitions that are not
    /// in the pinned descriptor which do not have
    /// a "Since Revision N" comment or have a "Since Revision N" comment where
    /// N is &lt;= to the revision specified here. This indicates that the protobuf
    /// files have been updated, but the pinned file descriptor hasn't.
    ///
    /// If there are items in the pinned file descriptor with a revision
    /// greater than the value indicated here, this will also cause a panic
    /// as it may mean that the pinned descriptor for a legacy module has been
    /// improperly updated or that there is some other versioning discrepancy.
    /// Runtime protobuf definitions will also be checked for compatibility
    /// with pinned file descriptors to make sure there are no incompatible changes.
    ///
    /// This behavior ensures that:
    /// * pinned proto images are up-to-date
    /// * protobuf files are carefully annotated with revision comments which
    ///   are important good client UX
    /// * protobuf files are changed in backwards and forwards compatible ways
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Revision {
      get { return revision_; }
      set {
        revision_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PackageReference);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PackageReference other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Revision != other.Revision) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Revision != 0) hash ^= Revision.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Revision != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Revision);
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Revision != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Revision);
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
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Revision != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Revision);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PackageReference other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Revision != 0) {
        Revision = other.Revision;
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
            Name = input.ReadString();
            break;
          }
          case 16: {
            Revision = input.ReadUInt32();
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
            Name = input.ReadString();
            break;
          }
          case 16: {
            Revision = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// MigrateFromInfo is information on a module version that a newer module
  /// can migrate from.
  /// </summary>
  public sealed partial class MigrateFromInfo : pb::IMessage<MigrateFromInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MigrateFromInfo> _parser = new pb::MessageParser<MigrateFromInfo>(() => new MigrateFromInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MigrateFromInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cosmos.App.V1Alpha1.ModuleReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MigrateFromInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MigrateFromInfo(MigrateFromInfo other) : this() {
      module_ = other.module_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MigrateFromInfo Clone() {
      return new MigrateFromInfo(this);
    }

    /// <summary>Field number for the "module" field.</summary>
    public const int ModuleFieldNumber = 1;
    private string module_ = "";
    /// <summary>
    /// module is the fully-qualified protobuf name of the module config object
    /// for the previous module version, ex: "cosmos.group.module.v1.Module".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Module {
      get { return module_; }
      set {
        module_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MigrateFromInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MigrateFromInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Module != other.Module) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Module.Length != 0) hash ^= Module.GetHashCode();
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
      if (Module.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Module);
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
      if (Module.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Module);
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
      if (Module.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Module);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MigrateFromInfo other) {
      if (other == null) {
        return;
      }
      if (other.Module.Length != 0) {
        Module = other.Module;
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
            Module = input.ReadString();
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
            Module = input.ReadString();
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