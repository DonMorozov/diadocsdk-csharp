//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Registration/RegistrationRequest.proto
namespace Diadoc.Api.Proto.Registration
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RegistrationRequest")]
  public partial class RegistrationRequest : global::ProtoBuf.IExtensible
  {
    public RegistrationRequest() {}
    

    private byte[] _CertificateContent = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"CertificateContent", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] CertificateContent
    {
      get { return _CertificateContent; }
      set { _CertificateContent = value; }
    }

    private string _Thumbprint = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Thumbprint", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Thumbprint
    {
      get { return _Thumbprint; }
      set { _Thumbprint = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RegistrationResponse")]
  public partial class RegistrationResponse : global::ProtoBuf.IExtensible
  {
    public RegistrationResponse() {}
    
    private Diadoc.Api.Proto.Registration.RegistrationStatus _RegistrationStatus;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"RegistrationStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Diadoc.Api.Proto.Registration.RegistrationStatus RegistrationStatus
    {
      get { return _RegistrationStatus; }
      set { _RegistrationStatus = value; }
    }

    private string _BoxId = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"BoxId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string BoxId
    {
      get { return _BoxId; }
      set { _BoxId = value; }
    }

    private byte[] _DataToSign = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"DataToSign", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] DataToSign
    {
      get { return _DataToSign; }
      set { _DataToSign = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RegistrationConfirmRequest")]
  public partial class RegistrationConfirmRequest : global::ProtoBuf.IExtensible
  {
    public RegistrationConfirmRequest() {}
    

    private byte[] _CertificateContent = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"CertificateContent", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] CertificateContent
    {
      get { return _CertificateContent; }
      set { _CertificateContent = value; }
    }

    private string _Thumbprint = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Thumbprint", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Thumbprint
    {
      get { return _Thumbprint; }
      set { _Thumbprint = value; }
    }
    private byte[] _DataToSign;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"DataToSign", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] DataToSign
    {
      get { return _DataToSign; }
      set { _DataToSign = value; }
    }
    private byte[] _Signature;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Signature", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] Signature
    {
      get { return _Signature; }
      set { _Signature = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"RegistrationStatus")]
    public enum RegistrationStatus
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"Unknown", Value=0)]
      Unknown = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AccessIsDenied", Value=1)]
      AccessIsDenied = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AccessRequestIsRejected", Value=2)]
      AccessRequestIsRejected = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CertificateOwnershipProofIsRequired", Value=3)]
      CertificateOwnershipProofIsRequired = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CertificateIsNotQualified", Value=4)]
      CertificateIsNotQualified = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RegistrationIsCompleted", Value=5)]
      RegistrationIsCompleted = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RegistrationIsInProgress", Value=6)]
      RegistrationIsInProgress = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RegistrationInBranchIsForbidden", Value=7)]
      RegistrationInBranchIsForbidden = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"AccessRequestIsPending", Value=8)]
      AccessRequestIsPending = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OrganizationNotFound", Value=9)]
      OrganizationNotFound = 9
    }
  
}