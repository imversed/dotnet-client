// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ibc/core/channel/v1/genesis.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Ibc.Core.Channel.V1 {

  /// <summary>Holder for reflection information generated from ibc/core/channel/v1/genesis.proto</summary>
  public static partial class GenesisReflection {

    #region Descriptor
    /// <summary>File descriptor for ibc/core/channel/v1/genesis.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GenesisReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFpYmMvY29yZS9jaGFubmVsL3YxL2dlbmVzaXMucHJvdG8SE2liYy5jb3Jl",
            "LmNoYW5uZWwudjEaFGdvZ29wcm90by9nb2dvLnByb3RvGiFpYmMvY29yZS9j",
            "aGFubmVsL3YxL2NoYW5uZWwucHJvdG8i7wQKDEdlbmVzaXNTdGF0ZRJTCghj",
            "aGFubmVscxgBIAMoCzImLmliYy5jb3JlLmNoYW5uZWwudjEuSWRlbnRpZmll",
            "ZENoYW5uZWxCGfreHxFJZGVudGlmaWVkQ2hhbm5lbMjeHwASQAoQYWNrbm93",
            "bGVkZ2VtZW50cxgCIAMoCzIgLmliYy5jb3JlLmNoYW5uZWwudjEuUGFja2V0",
            "U3RhdGVCBMjeHwASOwoLY29tbWl0bWVudHMYAyADKAsyIC5pYmMuY29yZS5j",
            "aGFubmVsLnYxLlBhY2tldFN0YXRlQgTI3h8AEjgKCHJlY2VpcHRzGAQgAygL",
            "MiAuaWJjLmNvcmUuY2hhbm5lbC52MS5QYWNrZXRTdGF0ZUIEyN4fABJaCg5z",
            "ZW5kX3NlcXVlbmNlcxgFIAMoCzIjLmliYy5jb3JlLmNoYW5uZWwudjEuUGFj",
            "a2V0U2VxdWVuY2VCHcjeHwDy3h8VeWFtbDoic2VuZF9zZXF1ZW5jZXMiEloK",
            "DnJlY3Zfc2VxdWVuY2VzGAYgAygLMiMuaWJjLmNvcmUuY2hhbm5lbC52MS5Q",
            "YWNrZXRTZXF1ZW5jZUIdyN4fAPLeHxV5YW1sOiJyZWN2X3NlcXVlbmNlcyIS",
            "WAoNYWNrX3NlcXVlbmNlcxgHIAMoCzIjLmliYy5jb3JlLmNoYW5uZWwudjEu",
            "UGFja2V0U2VxdWVuY2VCHMjeHwDy3h8UeWFtbDoiYWNrX3NlcXVlbmNlcyIS",
            "PwoVbmV4dF9jaGFubmVsX3NlcXVlbmNlGAggASgEQiDy3h8ceWFtbDoibmV4",
            "dF9jaGFubmVsX3NlcXVlbmNlIiJyCg5QYWNrZXRTZXF1ZW5jZRIjCgdwb3J0",
            "X2lkGAEgASgJQhLy3h8OeWFtbDoicG9ydF9pZCISKQoKY2hhbm5lbF9pZBgC",
            "IAEoCUIV8t4fEXlhbWw6ImNoYW5uZWxfaWQiEhAKCHNlcXVlbmNlGAMgASgE",
            "QjtaOWdpdGh1Yi5jb20vY29zbW9zL2liYy1nby92My9tb2R1bGVzL2NvcmUv",
            "MDQtY2hhbm5lbC90eXBlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Gogoproto.GogoReflection.Descriptor, global::Ibc.Core.Channel.V1.ChannelReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Ibc.Core.Channel.V1.GenesisState), global::Ibc.Core.Channel.V1.GenesisState.Parser, new[]{ "Channels", "Acknowledgements", "Commitments", "Receipts", "SendSequences", "RecvSequences", "AckSequences", "NextChannelSequence" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Ibc.Core.Channel.V1.PacketSequence), global::Ibc.Core.Channel.V1.PacketSequence.Parser, new[]{ "PortId", "ChannelId", "Sequence" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// GenesisState defines the ibc channel submodule's genesis state.
  /// </summary>
  public sealed partial class GenesisState : pb::IMessage<GenesisState>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GenesisState> _parser = new pb::MessageParser<GenesisState>(() => new GenesisState());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GenesisState> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Ibc.Core.Channel.V1.GenesisReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GenesisState() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GenesisState(GenesisState other) : this() {
      channels_ = other.channels_.Clone();
      acknowledgements_ = other.acknowledgements_.Clone();
      commitments_ = other.commitments_.Clone();
      receipts_ = other.receipts_.Clone();
      sendSequences_ = other.sendSequences_.Clone();
      recvSequences_ = other.recvSequences_.Clone();
      ackSequences_ = other.ackSequences_.Clone();
      nextChannelSequence_ = other.nextChannelSequence_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GenesisState Clone() {
      return new GenesisState(this);
    }

    /// <summary>Field number for the "channels" field.</summary>
    public const int ChannelsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Ibc.Core.Channel.V1.IdentifiedChannel> _repeated_channels_codec
        = pb::FieldCodec.ForMessage(10, global::Ibc.Core.Channel.V1.IdentifiedChannel.Parser);
    private readonly pbc::RepeatedField<global::Ibc.Core.Channel.V1.IdentifiedChannel> channels_ = new pbc::RepeatedField<global::Ibc.Core.Channel.V1.IdentifiedChannel>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Ibc.Core.Channel.V1.IdentifiedChannel> Channels {
      get { return channels_; }
    }

    /// <summary>Field number for the "acknowledgements" field.</summary>
    public const int AcknowledgementsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Ibc.Core.Channel.V1.PacketState> _repeated_acknowledgements_codec
        = pb::FieldCodec.ForMessage(18, global::Ibc.Core.Channel.V1.PacketState.Parser);
    private readonly pbc::RepeatedField<global::Ibc.Core.Channel.V1.PacketState> acknowledgements_ = new pbc::RepeatedField<global::Ibc.Core.Channel.V1.PacketState>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Ibc.Core.Channel.V1.PacketState> Acknowledgements {
      get { return acknowledgements_; }
    }

    /// <summary>Field number for the "commitments" field.</summary>
    public const int CommitmentsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Ibc.Core.Channel.V1.PacketState> _repeated_commitments_codec
        = pb::FieldCodec.ForMessage(26, global::Ibc.Core.Channel.V1.PacketState.Parser);
    private readonly pbc::RepeatedField<global::Ibc.Core.Channel.V1.PacketState> commitments_ = new pbc::RepeatedField<global::Ibc.Core.Channel.V1.PacketState>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Ibc.Core.Channel.V1.PacketState> Commitments {
      get { return commitments_; }
    }

    /// <summary>Field number for the "receipts" field.</summary>
    public const int ReceiptsFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Ibc.Core.Channel.V1.PacketState> _repeated_receipts_codec
        = pb::FieldCodec.ForMessage(34, global::Ibc.Core.Channel.V1.PacketState.Parser);
    private readonly pbc::RepeatedField<global::Ibc.Core.Channel.V1.PacketState> receipts_ = new pbc::RepeatedField<global::Ibc.Core.Channel.V1.PacketState>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Ibc.Core.Channel.V1.PacketState> Receipts {
      get { return receipts_; }
    }

    /// <summary>Field number for the "send_sequences" field.</summary>
    public const int SendSequencesFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Ibc.Core.Channel.V1.PacketSequence> _repeated_sendSequences_codec
        = pb::FieldCodec.ForMessage(42, global::Ibc.Core.Channel.V1.PacketSequence.Parser);
    private readonly pbc::RepeatedField<global::Ibc.Core.Channel.V1.PacketSequence> sendSequences_ = new pbc::RepeatedField<global::Ibc.Core.Channel.V1.PacketSequence>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Ibc.Core.Channel.V1.PacketSequence> SendSequences {
      get { return sendSequences_; }
    }

    /// <summary>Field number for the "recv_sequences" field.</summary>
    public const int RecvSequencesFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Ibc.Core.Channel.V1.PacketSequence> _repeated_recvSequences_codec
        = pb::FieldCodec.ForMessage(50, global::Ibc.Core.Channel.V1.PacketSequence.Parser);
    private readonly pbc::RepeatedField<global::Ibc.Core.Channel.V1.PacketSequence> recvSequences_ = new pbc::RepeatedField<global::Ibc.Core.Channel.V1.PacketSequence>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Ibc.Core.Channel.V1.PacketSequence> RecvSequences {
      get { return recvSequences_; }
    }

    /// <summary>Field number for the "ack_sequences" field.</summary>
    public const int AckSequencesFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Ibc.Core.Channel.V1.PacketSequence> _repeated_ackSequences_codec
        = pb::FieldCodec.ForMessage(58, global::Ibc.Core.Channel.V1.PacketSequence.Parser);
    private readonly pbc::RepeatedField<global::Ibc.Core.Channel.V1.PacketSequence> ackSequences_ = new pbc::RepeatedField<global::Ibc.Core.Channel.V1.PacketSequence>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Ibc.Core.Channel.V1.PacketSequence> AckSequences {
      get { return ackSequences_; }
    }

    /// <summary>Field number for the "next_channel_sequence" field.</summary>
    public const int NextChannelSequenceFieldNumber = 8;
    private ulong nextChannelSequence_;
    /// <summary>
    /// the sequence for the next generated channel identifier
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong NextChannelSequence {
      get { return nextChannelSequence_; }
      set {
        nextChannelSequence_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GenesisState);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GenesisState other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!channels_.Equals(other.channels_)) return false;
      if(!acknowledgements_.Equals(other.acknowledgements_)) return false;
      if(!commitments_.Equals(other.commitments_)) return false;
      if(!receipts_.Equals(other.receipts_)) return false;
      if(!sendSequences_.Equals(other.sendSequences_)) return false;
      if(!recvSequences_.Equals(other.recvSequences_)) return false;
      if(!ackSequences_.Equals(other.ackSequences_)) return false;
      if (NextChannelSequence != other.NextChannelSequence) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= channels_.GetHashCode();
      hash ^= acknowledgements_.GetHashCode();
      hash ^= commitments_.GetHashCode();
      hash ^= receipts_.GetHashCode();
      hash ^= sendSequences_.GetHashCode();
      hash ^= recvSequences_.GetHashCode();
      hash ^= ackSequences_.GetHashCode();
      if (NextChannelSequence != 0UL) hash ^= NextChannelSequence.GetHashCode();
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
      channels_.WriteTo(output, _repeated_channels_codec);
      acknowledgements_.WriteTo(output, _repeated_acknowledgements_codec);
      commitments_.WriteTo(output, _repeated_commitments_codec);
      receipts_.WriteTo(output, _repeated_receipts_codec);
      sendSequences_.WriteTo(output, _repeated_sendSequences_codec);
      recvSequences_.WriteTo(output, _repeated_recvSequences_codec);
      ackSequences_.WriteTo(output, _repeated_ackSequences_codec);
      if (NextChannelSequence != 0UL) {
        output.WriteRawTag(64);
        output.WriteUInt64(NextChannelSequence);
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
      channels_.WriteTo(ref output, _repeated_channels_codec);
      acknowledgements_.WriteTo(ref output, _repeated_acknowledgements_codec);
      commitments_.WriteTo(ref output, _repeated_commitments_codec);
      receipts_.WriteTo(ref output, _repeated_receipts_codec);
      sendSequences_.WriteTo(ref output, _repeated_sendSequences_codec);
      recvSequences_.WriteTo(ref output, _repeated_recvSequences_codec);
      ackSequences_.WriteTo(ref output, _repeated_ackSequences_codec);
      if (NextChannelSequence != 0UL) {
        output.WriteRawTag(64);
        output.WriteUInt64(NextChannelSequence);
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
      size += channels_.CalculateSize(_repeated_channels_codec);
      size += acknowledgements_.CalculateSize(_repeated_acknowledgements_codec);
      size += commitments_.CalculateSize(_repeated_commitments_codec);
      size += receipts_.CalculateSize(_repeated_receipts_codec);
      size += sendSequences_.CalculateSize(_repeated_sendSequences_codec);
      size += recvSequences_.CalculateSize(_repeated_recvSequences_codec);
      size += ackSequences_.CalculateSize(_repeated_ackSequences_codec);
      if (NextChannelSequence != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(NextChannelSequence);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GenesisState other) {
      if (other == null) {
        return;
      }
      channels_.Add(other.channels_);
      acknowledgements_.Add(other.acknowledgements_);
      commitments_.Add(other.commitments_);
      receipts_.Add(other.receipts_);
      sendSequences_.Add(other.sendSequences_);
      recvSequences_.Add(other.recvSequences_);
      ackSequences_.Add(other.ackSequences_);
      if (other.NextChannelSequence != 0UL) {
        NextChannelSequence = other.NextChannelSequence;
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
            channels_.AddEntriesFrom(input, _repeated_channels_codec);
            break;
          }
          case 18: {
            acknowledgements_.AddEntriesFrom(input, _repeated_acknowledgements_codec);
            break;
          }
          case 26: {
            commitments_.AddEntriesFrom(input, _repeated_commitments_codec);
            break;
          }
          case 34: {
            receipts_.AddEntriesFrom(input, _repeated_receipts_codec);
            break;
          }
          case 42: {
            sendSequences_.AddEntriesFrom(input, _repeated_sendSequences_codec);
            break;
          }
          case 50: {
            recvSequences_.AddEntriesFrom(input, _repeated_recvSequences_codec);
            break;
          }
          case 58: {
            ackSequences_.AddEntriesFrom(input, _repeated_ackSequences_codec);
            break;
          }
          case 64: {
            NextChannelSequence = input.ReadUInt64();
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
            channels_.AddEntriesFrom(ref input, _repeated_channels_codec);
            break;
          }
          case 18: {
            acknowledgements_.AddEntriesFrom(ref input, _repeated_acknowledgements_codec);
            break;
          }
          case 26: {
            commitments_.AddEntriesFrom(ref input, _repeated_commitments_codec);
            break;
          }
          case 34: {
            receipts_.AddEntriesFrom(ref input, _repeated_receipts_codec);
            break;
          }
          case 42: {
            sendSequences_.AddEntriesFrom(ref input, _repeated_sendSequences_codec);
            break;
          }
          case 50: {
            recvSequences_.AddEntriesFrom(ref input, _repeated_recvSequences_codec);
            break;
          }
          case 58: {
            ackSequences_.AddEntriesFrom(ref input, _repeated_ackSequences_codec);
            break;
          }
          case 64: {
            NextChannelSequence = input.ReadUInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// PacketSequence defines the genesis type necessary to retrieve and store
  /// next send and receive sequences.
  /// </summary>
  public sealed partial class PacketSequence : pb::IMessage<PacketSequence>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PacketSequence> _parser = new pb::MessageParser<PacketSequence>(() => new PacketSequence());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PacketSequence> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Ibc.Core.Channel.V1.GenesisReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PacketSequence() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PacketSequence(PacketSequence other) : this() {
      portId_ = other.portId_;
      channelId_ = other.channelId_;
      sequence_ = other.sequence_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PacketSequence Clone() {
      return new PacketSequence(this);
    }

    /// <summary>Field number for the "port_id" field.</summary>
    public const int PortIdFieldNumber = 1;
    private string portId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PortId {
      get { return portId_; }
      set {
        portId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "channel_id" field.</summary>
    public const int ChannelIdFieldNumber = 2;
    private string channelId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ChannelId {
      get { return channelId_; }
      set {
        channelId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sequence" field.</summary>
    public const int SequenceFieldNumber = 3;
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
      return Equals(other as PacketSequence);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PacketSequence other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PortId != other.PortId) return false;
      if (ChannelId != other.ChannelId) return false;
      if (Sequence != other.Sequence) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PortId.Length != 0) hash ^= PortId.GetHashCode();
      if (ChannelId.Length != 0) hash ^= ChannelId.GetHashCode();
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
      if (PortId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PortId);
      }
      if (ChannelId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ChannelId);
      }
      if (Sequence != 0UL) {
        output.WriteRawTag(24);
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
      if (PortId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PortId);
      }
      if (ChannelId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ChannelId);
      }
      if (Sequence != 0UL) {
        output.WriteRawTag(24);
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
      if (PortId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PortId);
      }
      if (ChannelId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ChannelId);
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
    public void MergeFrom(PacketSequence other) {
      if (other == null) {
        return;
      }
      if (other.PortId.Length != 0) {
        PortId = other.PortId;
      }
      if (other.ChannelId.Length != 0) {
        ChannelId = other.ChannelId;
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
            PortId = input.ReadString();
            break;
          }
          case 18: {
            ChannelId = input.ReadString();
            break;
          }
          case 24: {
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
            PortId = input.ReadString();
            break;
          }
          case 18: {
            ChannelId = input.ReadString();
            break;
          }
          case 24: {
            Sequence = input.ReadUInt64();
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
