// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: bgs/low/pb/client/global_extensions/message_options.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Bgs.Protocol {

  /// <summary>Holder for reflection information generated from bgs/low/pb/client/global_extensions/message_options.proto</summary>
  public static partial class MessageOptionsReflection {

    #region Descriptor
    /// <summary>File descriptor for bgs/low/pb/client/global_extensions/message_options.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessageOptionsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjliZ3MvbG93L3BiL2NsaWVudC9nbG9iYWxfZXh0ZW5zaW9ucy9tZXNzYWdl",
            "X29wdGlvbnMucHJvdG8SDGJncy5wcm90b2NvbBogZ29vZ2xlL3Byb3RvYnVm",
            "L2Rlc2NyaXB0b3IucHJvdG8iSgoRQkdTTWVzc2FnZU9wdGlvbnMSGwoTY3Vz",
            "dG9tX3NlbGVjdF9zaGFyZBgBIAEoCBIYChBjdXN0b21fdmFsaWRhdG9yGAIg",
            "ASgIOlsKD21lc3NhZ2Vfb3B0aW9ucxIfLmdvb2dsZS5wcm90b2J1Zi5NZXNz",
            "YWdlT3B0aW9ucxiQvwUgASgLMh8uYmdzLnByb3RvY29sLkJHU01lc3NhZ2VP",
            "cHRpb25zQiMKDGJncy5wcm90b2NvbEITTWVzc2FnZU9wdGlvbnNQcm90bw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.DescriptorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pb::Extension[] { MessageOptionsExtensions.MessageOptions_ }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.BGSMessageOptions), global::Bgs.Protocol.BGSMessageOptions.Parser, new[]{ "CustomSelectShard", "CustomValidator" }, null, null, null, null)
          }));
    }
    #endregion

  }
  /// <summary>Holder for extension identifiers generated from the top level of bgs/low/pb/client/global_extensions/message_options.proto</summary>
  public static partial class MessageOptionsExtensions {
    public static readonly pb::Extension<global::Google.Protobuf.MessageOptions, global::Bgs.Protocol.BGSMessageOptions> MessageOptions_ =
      new pb::Extension<global::Google.Protobuf.MessageOptions, global::Bgs.Protocol.BGSMessageOptions>(90000, pb::FieldCodec.ForMessage(720002, global::Bgs.Protocol.BGSMessageOptions.Parser));
  }

  #region Messages
  public sealed partial class BGSMessageOptions : pb::IMessage<BGSMessageOptions> {
    private static readonly pb::MessageParser<BGSMessageOptions> _parser = new pb::MessageParser<BGSMessageOptions>(() => new BGSMessageOptions());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BGSMessageOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.MessageOptionsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BGSMessageOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BGSMessageOptions(BGSMessageOptions other) : this() {
      _hasBits0 = other._hasBits0;
      customSelectShard_ = other.customSelectShard_;
      customValidator_ = other.customValidator_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BGSMessageOptions Clone() {
      return new BGSMessageOptions(this);
    }

    /// <summary>Field number for the "custom_select_shard" field.</summary>
    public const int CustomSelectShardFieldNumber = 1;
    private readonly static bool CustomSelectShardDefaultValue = false;

    private bool customSelectShard_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool CustomSelectShard {
      get { if ((_hasBits0 & 1) != 0) { return customSelectShard_; } else { return CustomSelectShardDefaultValue; } }
      set {
        _hasBits0 |= 1;
        customSelectShard_ = value;
      }
    }
    /// <summary>Gets whether the "custom_select_shard" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasCustomSelectShard {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "custom_select_shard" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearCustomSelectShard() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "custom_validator" field.</summary>
    public const int CustomValidatorFieldNumber = 2;
    private readonly static bool CustomValidatorDefaultValue = false;

    private bool customValidator_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool CustomValidator {
      get { if ((_hasBits0 & 2) != 0) { return customValidator_; } else { return CustomValidatorDefaultValue; } }
      set {
        _hasBits0 |= 2;
        customValidator_ = value;
      }
    }
    /// <summary>Gets whether the "custom_validator" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasCustomValidator {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "custom_validator" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearCustomValidator() {
      _hasBits0 &= ~2;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BGSMessageOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BGSMessageOptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CustomSelectShard != other.CustomSelectShard) return false;
      if (CustomValidator != other.CustomValidator) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HasCustomSelectShard) hash ^= CustomSelectShard.GetHashCode();
      if (HasCustomValidator) hash ^= CustomValidator.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (HasCustomSelectShard) {
        output.WriteRawTag(8);
        output.WriteBool(CustomSelectShard);
      }
      if (HasCustomValidator) {
        output.WriteRawTag(16);
        output.WriteBool(CustomValidator);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HasCustomSelectShard) {
        size += 1 + 1;
      }
      if (HasCustomValidator) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BGSMessageOptions other) {
      if (other == null) {
        return;
      }
      if (other.HasCustomSelectShard) {
        CustomSelectShard = other.CustomSelectShard;
      }
      if (other.HasCustomValidator) {
        CustomValidator = other.CustomValidator;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            CustomSelectShard = input.ReadBool();
            break;
          }
          case 16: {
            CustomValidator = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
