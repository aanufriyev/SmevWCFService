﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17379
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ServiceModel;
using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://smev.gosuslugi.ru/rev120315")]
[System.Xml.Serialization.XmlRootAttribute("Header", Namespace="http://smev.gosuslugi.ru/rev120315", IsNullable=false)]
public partial class HeaderType {
    
    private string nodeIdField;
    
    private string messageIdField;
    
    private System.DateTime timeStampField;
    
    private MessageClassType messageClassField;
    
    private PacketIdType[] packetIdsField;
    
    private string actorField;
    
    /// <remarks/>
    public string NodeId {
        get {
            return this.nodeIdField;
        }
        set {
            this.nodeIdField = value;
        }
    }
    
    /// <remarks/>
    public string MessageId {
        get {
            return this.messageIdField;
        }
        set {
            this.messageIdField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime TimeStamp {
        get {
            return this.timeStampField;
        }
        set {
            this.timeStampField = value;
        }
    }
    
    /// <remarks/>
    public MessageClassType MessageClass {
        get {
            return this.messageClassField;
        }
        set {
            this.messageClassField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Id", IsNullable=false)]
    public PacketIdType[] PacketIds {
        get {
            return this.packetIdsField;
        }
        set {
            this.packetIdsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string actor {
        get {
            return this.actorField;
        }
        set {
            this.actorField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://smev.gosuslugi.ru/rev120315")]
[System.Xml.Serialization.XmlRootAttribute("MessageClass", Namespace="http://smev.gosuslugi.ru/rev120315", IsNullable=false)]
public enum MessageClassType {
    
    /// <remarks/>
    REQUEST,
    
    /// <remarks/>
    RESPONSE,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://smev.gosuslugi.ru/rev120315")]
[System.Xml.Serialization.XmlRootAttribute("Id", Namespace="http://smev.gosuslugi.ru/rev120315", IsNullable=false)]
public partial class PacketIdType {
    
    private string messageIdField;
    
    private string subRequestNumberField;
    
    /// <remarks/>
    public string MessageId {
        get {
            return this.messageIdField;
        }
        set {
            this.messageIdField = value;
        }
    }
    
    /// <remarks/>
    public string SubRequestNumber {
        get {
            return this.subRequestNumberField;
        }
        set {
            this.subRequestNumberField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://smev.gosuslugi.ru/rev120315")]
[System.Xml.Serialization.XmlRootAttribute("BaseMessage", Namespace="http://smev.gosuslugi.ru/rev120315", IsNullable=false)]
public partial class BaseMessageType {
    
    private MessageType messageField;
    
    private MessageDataType messageDataField;
    
    /// <remarks/>
    public MessageType Message {
        get {
            return this.messageField;
        }
        set {
            this.messageField = value;
        }
    }
    
    /// <remarks/>
    public MessageDataType MessageData {
        get {
            return this.messageDataField;
        }
        set {
            this.messageDataField = value;
        }
    }
}

/// <remarks/>
[MessageContract]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://smev.gosuslugi.ru/rev120315")]
[System.Xml.Serialization.XmlRootAttribute("Message", Namespace="http://smev.gosuslugi.ru/rev120315", IsNullable=false)]
public partial class MessageType {
    
    private orgExternalType senderField;
    
    private orgExternalType recipientField;
    
    private orgExternalType originatorField;
    
    private TypeCodeType typeCodeField;
    
    private StatusType statusField;
    
    private System.DateTime dateField;
    
    private string exchangeTypeField;
    
    private string requestIdRefField;
    
    private string originRequestIdRefField;
    
    private string serviceCodeField;
    
    private string caseNumberField;
    
    private SubMessageType[] subMessagesField;
    
    private string testMsgField;
    
    /// <remarks/>
    public orgExternalType Sender {
        get {
            return this.senderField;
        }
        set {
            this.senderField = value;
        }
    }
    
    /// <remarks/>
    public orgExternalType Recipient {
        get {
            return this.recipientField;
        }
        set {
            this.recipientField = value;
        }
    }
    
    /// <remarks/>
    public orgExternalType Originator {
        get {
            return this.originatorField;
        }
        set {
            this.originatorField = value;
        }
    }
    
    /// <remarks/>
    public TypeCodeType TypeCode {
        get {
            return this.typeCodeField;
        }
        set {
            this.typeCodeField = value;
        }
    }
    
    /// <remarks/>
    public StatusType Status {
        get {
            return this.statusField;
        }
        set {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime Date {
        get {
            return this.dateField;
        }
        set {
            this.dateField = value;
        }
    }
    
    /// <remarks/>
    public string ExchangeType {
        get {
            return this.exchangeTypeField;
        }
        set {
            this.exchangeTypeField = value;
        }
    }
    
    /// <remarks/>
    public string RequestIdRef {
        get {
            return this.requestIdRefField;
        }
        set {
            this.requestIdRefField = value;
        }
    }
    
    /// <remarks/>
    public string OriginRequestIdRef {
        get {
            return this.originRequestIdRefField;
        }
        set {
            this.originRequestIdRefField = value;
        }
    }
    
    /// <remarks/>
    public string ServiceCode {
        get {
            return this.serviceCodeField;
        }
        set {
            this.serviceCodeField = value;
        }
    }
    
    /// <remarks/>
    public string CaseNumber {
        get {
            return this.caseNumberField;
        }
        set {
            this.caseNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("SubMessage", IsNullable=false)]
    public SubMessageType[] SubMessages {
        get {
            return this.subMessagesField;
        }
        set {
            this.subMessagesField = value;
        }
    }
    
    /// <remarks/>
    public string TestMsg {
        get {
            return this.testMsgField;
        }
        set {
            this.testMsgField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://smev.gosuslugi.ru/rev120315")]
[System.Xml.Serialization.XmlRootAttribute("Sender", Namespace="http://smev.gosuslugi.ru/rev120315", IsNullable=false)]
public partial class orgExternalType {
    
    private string codeField;
    
    private string nameField;
    
    /// <remarks/>
    public string Code {
        get {
            return this.codeField;
        }
        set {
            this.codeField = value;
        }
    }
    
    /// <remarks/>
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://smev.gosuslugi.ru/rev120315")]
[System.Xml.Serialization.XmlRootAttribute("TypeCode", Namespace="http://smev.gosuslugi.ru/rev120315", IsNullable=false)]
public enum TypeCodeType {
    
    /// <remarks/>
    GSRV,
    
    /// <remarks/>
    GFNC,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://smev.gosuslugi.ru/rev120315")]
[System.Xml.Serialization.XmlRootAttribute("Status", Namespace="http://smev.gosuslugi.ru/rev120315", IsNullable=false)]
public enum StatusType {
    
    /// <remarks/>
    REQUEST,
    
    /// <remarks/>
    RESULT,
    
    /// <remarks/>
    REJECT,
    
    /// <remarks/>
    INVALID,
    
    /// <remarks/>
    ACCEPT,
    
    /// <remarks/>
    PING,
    
    /// <remarks/>
    PROCESS,
    
    /// <remarks/>
    NOTIFY,
    
    /// <remarks/>
    FAILURE,
    
    /// <remarks/>
    CANCEL,
    
    /// <remarks/>
    STATE,
    
    /// <remarks/>
    PACKET,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://smev.gosuslugi.ru/rev120315")]
[System.Xml.Serialization.XmlRootAttribute("SubMessage", Namespace="http://smev.gosuslugi.ru/rev120315", IsNullable=false)]
public partial class SubMessageType {
    
    private string subRequestNumberField;
    
    private StatusType statusField;
    
    private orgExternalType originatorField;
    
    private System.DateTime dateField;
    
    private string requestIdRefField;
    
    private string originRequestIdRefField;
    
    private string serviceCodeField;
    
    private string caseNumberField;
    
    /// <remarks/>
    public string SubRequestNumber {
        get {
            return this.subRequestNumberField;
        }
        set {
            this.subRequestNumberField = value;
        }
    }
    
    /// <remarks/>
    public StatusType Status {
        get {
            return this.statusField;
        }
        set {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    public orgExternalType Originator {
        get {
            return this.originatorField;
        }
        set {
            this.originatorField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime Date {
        get {
            return this.dateField;
        }
        set {
            this.dateField = value;
        }
    }
    
    /// <remarks/>
    public string RequestIdRef {
        get {
            return this.requestIdRefField;
        }
        set {
            this.requestIdRefField = value;
        }
    }
    
    /// <remarks/>
    public string OriginRequestIdRef {
        get {
            return this.originRequestIdRefField;
        }
        set {
            this.originRequestIdRefField = value;
        }
    }
    
    /// <remarks/>
    public string ServiceCode {
        get {
            return this.serviceCodeField;
        }
        set {
            this.serviceCodeField = value;
        }
    }
    
    /// <remarks/>
    public string CaseNumber {
        get {
            return this.caseNumberField;
        }
        set {
            this.caseNumberField = value;
        }
    }
}

/// <remarks/>
[MessageContract]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://smev.gosuslugi.ru/rev120315")]
[System.Xml.Serialization.XmlRootAttribute("MessageData", Namespace="http://smev.gosuslugi.ru/rev120315", IsNullable=false)]
public partial class MessageDataType {
    
    private AppDataType appDataField;
    
    private AppDocumentType appDocumentField;
    
    /// <remarks/>
    public AppDataType AppData {
        get {
            return this.appDataField;
        }
        set {
            this.appDataField = value;
        }
    }
    
    /// <remarks/>
    public AppDocumentType AppDocument {
        get {
            return this.appDocumentField;
        }
        set {
            this.appDocumentField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://smev.gosuslugi.ru/rev120315")]
[System.Xml.Serialization.XmlRootAttribute("AppData", Namespace="http://smev.gosuslugi.ru/rev120315", IsNullable=false)]
public partial class AppDataType
{
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool errorCodeSpecified;

    private int? errorCodeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("errorCode", IsNullable = true)]
    public int? errorCode
    {
        get
        {
            return this.errorCodeField;
        }
        set
        {
            this.errorCodeField = value;
        }
    }



    private RequestType requestField;

    private ResponceType responceField;

    public RequestType Request
    {
        get
        {
            return this.requestField;
        }
        set
        {
            this.requestField = value;
        }
    }

    /// <remarks/>
    public ResponceType Responce
    {
        get
        {
            return this.responceField;
        }
        set
        {
            this.responceField = value;
        }
    }

    /* private System.Xml.XmlElement[] anyField;
    
    private System.Xml.XmlAttribute[] anyAttrField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Any {
        get {
            return this.anyField;
        }
        set {
            this.anyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyAttributeAttribute()]
    public System.Xml.XmlAttribute[] AnyAttr {
        get {
            return this.anyAttrField;
        }
        set {
            this.anyAttrField = value;
        }
    }*/
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://test")]
[System.Xml.Serialization.XmlRootAttribute("Request", Namespace = "http://test", IsNullable = false)]
public class RequestType
{
    public string request { get; set; }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://test")]
[System.Xml.Serialization.XmlRootAttribute("Responce", Namespace = "http://test", IsNullable = false)]
public class ResponceType
{
    public string responce { get; set; }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://smev.gosuslugi.ru/rev120315")]
[System.Xml.Serialization.XmlRootAttribute("AppDocument", Namespace="http://smev.gosuslugi.ru/rev120315", IsNullable=false)]
public partial class AppDocumentType {
    
    private string requestCodeField;
    
    private object[] itemsField;
    
    private ItemsChoiceType[] itemsElementNameField;
    
    /// <remarks/>
    public string RequestCode {
        get {
            return this.requestCodeField;
        }
        set {
            this.requestCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BinaryData", typeof(byte[]), DataType="base64Binary")]
    [System.Xml.Serialization.XmlElementAttribute("DigestValue", typeof(byte[]), DataType="base64Binary")]
    [System.Xml.Serialization.XmlElementAttribute("Reference", typeof(ReferenceType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType[] ItemsElementName {
        get {
            return this.itemsElementNameField;
        }
        set {
            this.itemsElementNameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://smev.gosuslugi.ru/rev120315")]
[System.Xml.Serialization.XmlRootAttribute("Reference", Namespace="http://smev.gosuslugi.ru/rev120315", IsNullable=false)]
public partial class ReferenceType {
    
    private Include includeField;
    
    private string[] textField;
    
    /// <remarks/>
    public Include Include {
        get {
            return this.includeField;
        }
        set {
            this.includeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text {
        get {
            return this.textField;
        }
        set {
            this.textField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://smev.gosuslugi.ru/rev120315")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://smev.gosuslugi.ru/rev120315", IsNullable=false)]
public partial class Include {
    
    private System.Xml.XmlElement[] anyField;
    
    private string hrefField;
    
    private System.Xml.XmlAttribute[] anyAttrField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Any {
        get {
            return this.anyField;
        }
        set {
            this.anyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string href {
        get {
            return this.hrefField;
        }
        set {
            this.hrefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyAttributeAttribute()]
    public System.Xml.XmlAttribute[] AnyAttr {
        get {
            return this.anyAttrField;
        }
        set {
            this.anyAttrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://smev.gosuslugi.ru/rev120315", IncludeInSchema=false)]
public enum ItemsChoiceType {
    
    /// <remarks/>
    BinaryData,
    
    /// <remarks/>
    DigestValue,
    
    /// <remarks/>
    Reference,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://smev.gosuslugi.ru/rev120315")]
[System.Xml.Serialization.XmlRootAttribute("SubMessages", Namespace="http://smev.gosuslugi.ru/rev120315", IsNullable=false)]
public partial class SubMessagesType {
    
    private SubMessageType[] subMessageField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SubMessage")]
    public SubMessageType[] SubMessage {
        get {
            return this.subMessageField;
        }
        set {
            this.subMessageField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://smev.gosuslugi.ru/rev120315")]
[System.Xml.Serialization.XmlRootAttribute("PacketIds", Namespace="http://smev.gosuslugi.ru/rev120315", IsNullable=false)]
public partial class PacketIdsType {
    
    private PacketIdType[] idField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Id")]
    public PacketIdType[] Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}
