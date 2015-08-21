namespace LeaveProject {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://LeaveProject.LeaveRequestSchema",@"LeaveRequest")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Int32), "Details.NoOfDays", XPath = @"/*[local-name()='LeaveRequest' and namespace-uri()='http://LeaveProject.LeaveRequestSchema']/*[local-name()='Details' and namespace-uri()='']/*[local-name()='NoOfDays' and namespace-uri()='']", XsdType = @"int")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::LeaveProject.CR_RequestID), XPath = @"/*[local-name()='LeaveRequest' and namespace-uri()='http://LeaveProject.LeaveRequestSchema']/*[local-name()='Header' and namespace-uri()='']/*[local-name()='RequestID' and namespace-uri()='']", XsdType = @"int")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Details.Reason", XPath = @"/*[local-name()='LeaveRequest' and namespace-uri()='http://LeaveProject.LeaveRequestSchema']/*[local-name()='Details' and namespace-uri()='']/*[local-name()='Reason' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"LeaveRequest"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"LeaveProject.CRPropertySchema", typeof(global::LeaveProject.CRPropertySchema))]
    public sealed class LeaveRequestSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://LeaveProject.LeaveRequestSchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://LeaveProject.CRPropertySchema"" targetNamespace=""http://LeaveProject.LeaveRequestSchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://LeaveProject.CRPropertySchema"" location=""LeaveProject.CRPropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""LeaveRequest"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='LeaveRequest' and namespace-uri()='http://LeaveProject.LeaveRequestSchema']/*[local-name()='Details' and namespace-uri()='']/*[local-name()='NoOfDays' and namespace-uri()='']"" />
          <b:property name=""ns0:CR_RequestID"" xpath=""/*[local-name()='LeaveRequest' and namespace-uri()='http://LeaveProject.LeaveRequestSchema']/*[local-name()='Header' and namespace-uri()='']/*[local-name()='RequestID' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='LeaveRequest' and namespace-uri()='http://LeaveProject.LeaveRequestSchema']/*[local-name()='Details' and namespace-uri()='']/*[local-name()='Reason' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Header"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""RequestID"" type=""xs:int"" />
              <xs:element name=""RequestDate"" type=""xs:date"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Details"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""EmpID"" type=""xs:int"" />
              <xs:element name=""NoOfDays"" type=""xs:int"" />
              <xs:element default=""WelCome Break"" name=""Reason"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public LeaveRequestSchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "LeaveRequest";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
