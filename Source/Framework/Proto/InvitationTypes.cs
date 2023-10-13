// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: bgs/low/pb/client/invitation_types.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Bgs.Protocol {

  /// <summary>Holder for reflection information generated from bgs/low/pb/client/invitation_types.proto</summary>
  public static partial class InvitationTypesReflection {

    #region Descriptor
    /// <summary>File descriptor for bgs/low/pb/client/invitation_types.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InvitationTypesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihiZ3MvbG93L3BiL2NsaWVudC9pbnZpdGF0aW9uX3R5cGVzLnByb3RvEgxi",
            "Z3MucHJvdG9jb2waJGJncy9sb3cvcGIvY2xpZW50L2VudGl0eV90eXBlcy5w",
            "cm90byL7AQoKSW52aXRhdGlvbhIKCgJpZBgBIAIoBhIwChBpbnZpdGVyX2lk",
            "ZW50aXR5GAIgAigLMhYuYmdzLnByb3RvY29sLklkZW50aXR5EjAKEGludml0",
            "ZWVfaWRlbnRpdHkYAyACKAsyFi5iZ3MucHJvdG9jb2wuSWRlbnRpdHkSFAoM",
            "aW52aXRlcl9uYW1lGAQgASgJEhQKDGludml0ZWVfbmFtZRgFIAEoCRIaChJp",
            "bnZpdGF0aW9uX21lc3NhZ2UYBiABKAkSFQoNY3JlYXRpb25fdGltZRgHIAEo",
            "BBIXCg9leHBpcmF0aW9uX3RpbWUYCCABKAQqBQhkEJFOIlIKEEludml0YXRp",
            "b25QYXJhbXMSHgoSaW52aXRhdGlvbl9tZXNzYWdlGAEgASgJQgIYARIXCg9l",
            "eHBpcmF0aW9uX3RpbWUYAiABKAQqBQhkEJFOKoYCChdJbnZpdGF0aW9uUmVt",
            "b3ZlZFJlYXNvbhImCiJJTlZJVEFUSU9OX1JFTU9WRURfUkVBU09OX0FDQ0VQ",
            "VEVEEAASJgoiSU5WSVRBVElPTl9SRU1PVkVEX1JFQVNPTl9ERUNMSU5FRBAB",
            "EiUKIUlOVklUQVRJT05fUkVNT1ZFRF9SRUFTT05fUkVWT0tFRBACEiUKIUlO",
            "VklUQVRJT05fUkVNT1ZFRF9SRUFTT05fSUdOT1JFRBADEiUKIUlOVklUQVRJ",
            "T05fUkVNT1ZFRF9SRUFTT05fRVhQSVJFRBAEEiYKIklOVklUQVRJT05fUkVN",
            "T1ZFRF9SRUFTT05fQ0FOQ0VMRUQQBSq4AQoXU3VnZ2VzdGlvblJlbW92ZWRS",
            "ZWFzb24SJgoiU1VHR0VTVElPTl9SRU1PVkVEX1JFQVNPTl9BUFBST1ZFRBAA",
            "EiYKIlNVR0dFU1RJT05fUkVNT1ZFRF9SRUFTT05fREVDTElORUQQARIlCiFT",
            "VUdHRVNUSU9OX1JFTU9WRURfUkVBU09OX0VYUElSRUQQAhImCiJTVUdHRVNU",
            "SU9OX1JFTU9WRURfUkVBU09OX0NBTkNFTEVEEANCJAoMYmdzLnByb3RvY29s",
            "QhRJbnZpdGF0aW9uVHlwZXNQcm90bw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Bgs.Protocol.EntityTypesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Bgs.Protocol.InvitationRemovedReason), typeof(global::Bgs.Protocol.SuggestionRemovedReason), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.Invitation), global::Bgs.Protocol.Invitation.Parser, new[]{ "Id", "InviterIdentity", "InviteeIdentity", "InviterName", "InviteeName", "InvitationMessage", "CreationTime", "ExpirationTime" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.InvitationParams), global::Bgs.Protocol.InvitationParams.Parser, new[]{ "InvitationMessage", "ExpirationTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum InvitationRemovedReason {
    [pbr::OriginalName("INVITATION_REMOVED_REASON_ACCEPTED")] Accepted = 0,
    [pbr::OriginalName("INVITATION_REMOVED_REASON_DECLINED")] Declined = 1,
    [pbr::OriginalName("INVITATION_REMOVED_REASON_REVOKED")] Revoked = 2,
    [pbr::OriginalName("INVITATION_REMOVED_REASON_IGNORED")] Ignored = 3,
    [pbr::OriginalName("INVITATION_REMOVED_REASON_EXPIRED")] Expired = 4,
    [pbr::OriginalName("INVITATION_REMOVED_REASON_CANCELED")] Canceled = 5,
  }

  public enum SuggestionRemovedReason {
    [pbr::OriginalName("SUGGESTION_REMOVED_REASON_APPROVED")] Approved = 0,
    [pbr::OriginalName("SUGGESTION_REMOVED_REASON_DECLINED")] Declined = 1,
    [pbr::OriginalName("SUGGESTION_REMOVED_REASON_EXPIRED")] Expired = 2,
    [pbr::OriginalName("SUGGESTION_REMOVED_REASON_CANCELED")] Canceled = 3,
  }

  #endregion

  #region Messages
  public sealed partial class Invitation : pb::IExtendableMessage<Invitation> {
    private static readonly pb::MessageParser<Invitation> _parser = new pb::MessageParser<Invitation>(() => new Invitation());
    private pb::UnknownFieldSet _unknownFields;
    private pb::ExtensionSet<Invitation> _extensions;
    private pb::ExtensionSet<Invitation> _Extensions => _extensions;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Invitation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.InvitationTypesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Invitation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Invitation(Invitation other) : this() {
      _hasBits0 = other._hasBits0;
      id_ = other.id_;
      inviterIdentity_ = other.HasInviterIdentity ? other.inviterIdentity_.Clone() : null;
      inviteeIdentity_ = other.HasInviteeIdentity ? other.inviteeIdentity_.Clone() : null;
      inviterName_ = other.inviterName_;
      inviteeName_ = other.inviteeName_;
      invitationMessage_ = other.invitationMessage_;
      creationTime_ = other.creationTime_;
      expirationTime_ = other.expirationTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
      _extensions = pb::ExtensionSet.Clone(other._extensions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Invitation Clone() {
      return new Invitation(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private readonly static ulong IdDefaultValue = 0UL;

    private ulong id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Id {
      get { if ((_hasBits0 & 1) != 0) { return id_; } else { return IdDefaultValue; } }
      set {
        _hasBits0 |= 1;
        id_ = value;
      }
    }
    /// <summary>Gets whether the "id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasId {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearId() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "inviter_identity" field.</summary>
    public const int InviterIdentityFieldNumber = 2;
    private global::Bgs.Protocol.Identity inviterIdentity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Bgs.Protocol.Identity InviterIdentity {
      get { return inviterIdentity_; }
      set {
        inviterIdentity_ = value;
      }
    }
    /// <summary>Gets whether the inviter_identity field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasInviterIdentity {
      get { return inviterIdentity_ != null; }
    }
    /// <summary>Clears the value of the inviter_identity field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearInviterIdentity() {
      inviterIdentity_ = null;
    }

    /// <summary>Field number for the "invitee_identity" field.</summary>
    public const int InviteeIdentityFieldNumber = 3;
    private global::Bgs.Protocol.Identity inviteeIdentity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Bgs.Protocol.Identity InviteeIdentity {
      get { return inviteeIdentity_; }
      set {
        inviteeIdentity_ = value;
      }
    }
    /// <summary>Gets whether the invitee_identity field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasInviteeIdentity {
      get { return inviteeIdentity_ != null; }
    }
    /// <summary>Clears the value of the invitee_identity field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearInviteeIdentity() {
      inviteeIdentity_ = null;
    }

    /// <summary>Field number for the "inviter_name" field.</summary>
    public const int InviterNameFieldNumber = 4;
    private readonly static string InviterNameDefaultValue = "";

    private string inviterName_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string InviterName {
      get { return inviterName_ ?? InviterNameDefaultValue; }
      set {
        inviterName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "inviter_name" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasInviterName {
      get { return inviterName_ != null; }
    }
    /// <summary>Clears the value of the "inviter_name" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearInviterName() {
      inviterName_ = null;
    }

    /// <summary>Field number for the "invitee_name" field.</summary>
    public const int InviteeNameFieldNumber = 5;
    private readonly static string InviteeNameDefaultValue = "";

    private string inviteeName_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string InviteeName {
      get { return inviteeName_ ?? InviteeNameDefaultValue; }
      set {
        inviteeName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "invitee_name" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasInviteeName {
      get { return inviteeName_ != null; }
    }
    /// <summary>Clears the value of the "invitee_name" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearInviteeName() {
      inviteeName_ = null;
    }

    /// <summary>Field number for the "invitation_message" field.</summary>
    public const int InvitationMessageFieldNumber = 6;
    private readonly static string InvitationMessageDefaultValue = "";

    private string invitationMessage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string InvitationMessage {
      get { return invitationMessage_ ?? InvitationMessageDefaultValue; }
      set {
        invitationMessage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "invitation_message" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasInvitationMessage {
      get { return invitationMessage_ != null; }
    }
    /// <summary>Clears the value of the "invitation_message" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearInvitationMessage() {
      invitationMessage_ = null;
    }

    /// <summary>Field number for the "creation_time" field.</summary>
    public const int CreationTimeFieldNumber = 7;
    private readonly static ulong CreationTimeDefaultValue = 0UL;

    private ulong creationTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong CreationTime {
      get { if ((_hasBits0 & 2) != 0) { return creationTime_; } else { return CreationTimeDefaultValue; } }
      set {
        _hasBits0 |= 2;
        creationTime_ = value;
      }
    }
    /// <summary>Gets whether the "creation_time" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasCreationTime {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "creation_time" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearCreationTime() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "expiration_time" field.</summary>
    public const int ExpirationTimeFieldNumber = 8;
    private readonly static ulong ExpirationTimeDefaultValue = 0UL;

    private ulong expirationTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong ExpirationTime {
      get { if ((_hasBits0 & 4) != 0) { return expirationTime_; } else { return ExpirationTimeDefaultValue; } }
      set {
        _hasBits0 |= 4;
        expirationTime_ = value;
      }
    }
    /// <summary>Gets whether the "expiration_time" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasExpirationTime {
      get { return (_hasBits0 & 4) != 0; }
    }
    /// <summary>Clears the value of the "expiration_time" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearExpirationTime() {
      _hasBits0 &= ~4;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Invitation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Invitation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (!object.Equals(InviterIdentity, other.InviterIdentity)) return false;
      if (!object.Equals(InviteeIdentity, other.InviteeIdentity)) return false;
      if (InviterName != other.InviterName) return false;
      if (InviteeName != other.InviteeName) return false;
      if (InvitationMessage != other.InvitationMessage) return false;
      if (CreationTime != other.CreationTime) return false;
      if (ExpirationTime != other.ExpirationTime) return false;
      if (!Equals(_extensions, other._extensions)) {
        return false;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HasId) hash ^= Id.GetHashCode();
      if (HasInviterIdentity) hash ^= InviterIdentity.GetHashCode();
      if (HasInviteeIdentity) hash ^= InviteeIdentity.GetHashCode();
      if (HasInviterName) hash ^= InviterName.GetHashCode();
      if (HasInviteeName) hash ^= InviteeName.GetHashCode();
      if (HasInvitationMessage) hash ^= InvitationMessage.GetHashCode();
      if (HasCreationTime) hash ^= CreationTime.GetHashCode();
      if (HasExpirationTime) hash ^= ExpirationTime.GetHashCode();
      if (_extensions != null) {
        hash ^= _extensions.GetHashCode();
      }
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
      if (HasId) {
        output.WriteRawTag(9);
        output.WriteFixed64(Id);
      }
      if (HasInviterIdentity) {
        output.WriteRawTag(18);
        output.WriteMessage(InviterIdentity);
      }
      if (HasInviteeIdentity) {
        output.WriteRawTag(26);
        output.WriteMessage(InviteeIdentity);
      }
      if (HasInviterName) {
        output.WriteRawTag(34);
        output.WriteString(InviterName);
      }
      if (HasInviteeName) {
        output.WriteRawTag(42);
        output.WriteString(InviteeName);
      }
      if (HasInvitationMessage) {
        output.WriteRawTag(50);
        output.WriteString(InvitationMessage);
      }
      if (HasCreationTime) {
        output.WriteRawTag(56);
        output.WriteUInt64(CreationTime);
      }
      if (HasExpirationTime) {
        output.WriteRawTag(64);
        output.WriteUInt64(ExpirationTime);
      }
      if (_extensions != null) {
        _extensions.WriteTo(output);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HasId) {
        size += 1 + 8;
      }
      if (HasInviterIdentity) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(InviterIdentity);
      }
      if (HasInviteeIdentity) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(InviteeIdentity);
      }
      if (HasInviterName) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(InviterName);
      }
      if (HasInviteeName) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(InviteeName);
      }
      if (HasInvitationMessage) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(InvitationMessage);
      }
      if (HasCreationTime) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(CreationTime);
      }
      if (HasExpirationTime) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ExpirationTime);
      }
      if (_extensions != null) {
        size += _extensions.CalculateSize();
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Invitation other) {
      if (other == null) {
        return;
      }
      if (other.HasId) {
        Id = other.Id;
      }
      if (other.HasInviterIdentity) {
        if (!HasInviterIdentity) {
          InviterIdentity = new global::Bgs.Protocol.Identity();
        }
        InviterIdentity.MergeFrom(other.InviterIdentity);
      }
      if (other.HasInviteeIdentity) {
        if (!HasInviteeIdentity) {
          InviteeIdentity = new global::Bgs.Protocol.Identity();
        }
        InviteeIdentity.MergeFrom(other.InviteeIdentity);
      }
      if (other.HasInviterName) {
        InviterName = other.InviterName;
      }
      if (other.HasInviteeName) {
        InviteeName = other.InviteeName;
      }
      if (other.HasInvitationMessage) {
        InvitationMessage = other.InvitationMessage;
      }
      if (other.HasCreationTime) {
        CreationTime = other.CreationTime;
      }
      if (other.HasExpirationTime) {
        ExpirationTime = other.ExpirationTime;
      }
      pb::ExtensionSet.MergeFrom(ref _extensions, other._extensions);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            if (!pb::ExtensionSet.TryMergeFieldFrom(ref _extensions, input)) {
              _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            }
            break;
          case 9: {
            Id = input.ReadFixed64();
            break;
          }
          case 18: {
            if (!HasInviterIdentity) {
              InviterIdentity = new global::Bgs.Protocol.Identity();
            }
            input.ReadMessage(InviterIdentity);
            break;
          }
          case 26: {
            if (!HasInviteeIdentity) {
              InviteeIdentity = new global::Bgs.Protocol.Identity();
            }
            input.ReadMessage(InviteeIdentity);
            break;
          }
          case 34: {
            InviterName = input.ReadString();
            break;
          }
          case 42: {
            InviteeName = input.ReadString();
            break;
          }
          case 50: {
            InvitationMessage = input.ReadString();
            break;
          }
          case 56: {
            CreationTime = input.ReadUInt64();
            break;
          }
          case 64: {
            ExpirationTime = input.ReadUInt64();
            break;
          }
        }
      }
    }

    public TValue GetExtension<TValue>(pb::Extension<Invitation, TValue> extension) {
      return pb::ExtensionSet.Get(ref _extensions, extension);
    }
    public pbc::RepeatedField<TValue> GetExtension<TValue>(pb::RepeatedExtension<Invitation, TValue> extension) {
      return pb::ExtensionSet.Get(ref _extensions, extension);
    }
    public pbc::RepeatedField<TValue> GetOrInitializeExtension<TValue>(pb::RepeatedExtension<Invitation, TValue> extension) {
      return pb::ExtensionSet.GetOrInitialize(ref _extensions, extension);
    }
    public void SetExtension<TValue>(pb::Extension<Invitation, TValue> extension, TValue value) {
      pb::ExtensionSet.Set(ref _extensions, extension, value);
    }
    public bool HasExtension<TValue>(pb::Extension<Invitation, TValue> extension) {
      return pb::ExtensionSet.Has(ref _extensions, extension);
    }
    public void ClearExtension<TValue>(pb::Extension<Invitation, TValue> extension) {
      pb::ExtensionSet.Clear(ref _extensions, extension);
    }
    public void ClearExtension<TValue>(pb::RepeatedExtension<Invitation, TValue> extension) {
      pb::ExtensionSet.Clear(ref _extensions, extension);
    }

  }

  public sealed partial class InvitationParams : pb::IExtendableMessage<InvitationParams> {
    private static readonly pb::MessageParser<InvitationParams> _parser = new pb::MessageParser<InvitationParams>(() => new InvitationParams());
    private pb::UnknownFieldSet _unknownFields;
    private pb::ExtensionSet<InvitationParams> _extensions;
    private pb::ExtensionSet<InvitationParams> _Extensions => _extensions;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InvitationParams> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.InvitationTypesReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InvitationParams() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InvitationParams(InvitationParams other) : this() {
      _hasBits0 = other._hasBits0;
      invitationMessage_ = other.invitationMessage_;
      expirationTime_ = other.expirationTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
      _extensions = pb::ExtensionSet.Clone(other._extensions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InvitationParams Clone() {
      return new InvitationParams(this);
    }

    /// <summary>Field number for the "invitation_message" field.</summary>
    public const int InvitationMessageFieldNumber = 1;
    private readonly static string InvitationMessageDefaultValue = "";

    private string invitationMessage_;
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string InvitationMessage {
      get { return invitationMessage_ ?? InvitationMessageDefaultValue; }
      set {
        invitationMessage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "invitation_message" field is set</summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasInvitationMessage {
      get { return invitationMessage_ != null; }
    }
    /// <summary>Clears the value of the "invitation_message" field</summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearInvitationMessage() {
      invitationMessage_ = null;
    }

    /// <summary>Field number for the "expiration_time" field.</summary>
    public const int ExpirationTimeFieldNumber = 2;
    private readonly static ulong ExpirationTimeDefaultValue = 0UL;

    private ulong expirationTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong ExpirationTime {
      get { if ((_hasBits0 & 1) != 0) { return expirationTime_; } else { return ExpirationTimeDefaultValue; } }
      set {
        _hasBits0 |= 1;
        expirationTime_ = value;
      }
    }
    /// <summary>Gets whether the "expiration_time" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasExpirationTime {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "expiration_time" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearExpirationTime() {
      _hasBits0 &= ~1;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InvitationParams);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InvitationParams other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (InvitationMessage != other.InvitationMessage) return false;
      if (ExpirationTime != other.ExpirationTime) return false;
      if (!Equals(_extensions, other._extensions)) {
        return false;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HasInvitationMessage) hash ^= InvitationMessage.GetHashCode();
      if (HasExpirationTime) hash ^= ExpirationTime.GetHashCode();
      if (_extensions != null) {
        hash ^= _extensions.GetHashCode();
      }
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
      if (HasInvitationMessage) {
        output.WriteRawTag(10);
        output.WriteString(InvitationMessage);
      }
      if (HasExpirationTime) {
        output.WriteRawTag(16);
        output.WriteUInt64(ExpirationTime);
      }
      if (_extensions != null) {
        _extensions.WriteTo(output);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HasInvitationMessage) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(InvitationMessage);
      }
      if (HasExpirationTime) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ExpirationTime);
      }
      if (_extensions != null) {
        size += _extensions.CalculateSize();
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InvitationParams other) {
      if (other == null) {
        return;
      }
      if (other.HasInvitationMessage) {
        InvitationMessage = other.InvitationMessage;
      }
      if (other.HasExpirationTime) {
        ExpirationTime = other.ExpirationTime;
      }
      pb::ExtensionSet.MergeFrom(ref _extensions, other._extensions);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            if (!pb::ExtensionSet.TryMergeFieldFrom(ref _extensions, input)) {
              _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            }
            break;
          case 10: {
            InvitationMessage = input.ReadString();
            break;
          }
          case 16: {
            ExpirationTime = input.ReadUInt64();
            break;
          }
        }
      }
    }

    public TValue GetExtension<TValue>(pb::Extension<InvitationParams, TValue> extension) {
      return pb::ExtensionSet.Get(ref _extensions, extension);
    }
    public pbc::RepeatedField<TValue> GetExtension<TValue>(pb::RepeatedExtension<InvitationParams, TValue> extension) {
      return pb::ExtensionSet.Get(ref _extensions, extension);
    }
    public pbc::RepeatedField<TValue> GetOrInitializeExtension<TValue>(pb::RepeatedExtension<InvitationParams, TValue> extension) {
      return pb::ExtensionSet.GetOrInitialize(ref _extensions, extension);
    }
    public void SetExtension<TValue>(pb::Extension<InvitationParams, TValue> extension, TValue value) {
      pb::ExtensionSet.Set(ref _extensions, extension, value);
    }
    public bool HasExtension<TValue>(pb::Extension<InvitationParams, TValue> extension) {
      return pb::ExtensionSet.Has(ref _extensions, extension);
    }
    public void ClearExtension<TValue>(pb::Extension<InvitationParams, TValue> extension) {
      pb::ExtensionSet.Clear(ref _extensions, extension);
    }
    public void ClearExtension<TValue>(pb::RepeatedExtension<InvitationParams, TValue> extension) {
      pb::ExtensionSet.Clear(ref _extensions, extension);
    }

  }

  #endregion

}

#endregion Designer generated code
