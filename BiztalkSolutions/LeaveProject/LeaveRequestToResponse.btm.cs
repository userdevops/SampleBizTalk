namespace LeaveProject {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"LeaveProject.LeaveRequestSchema", typeof(global::LeaveProject.LeaveRequestSchema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"LeaveProject.LeaveResponseSchema", typeof(global::LeaveProject.LeaveResponseSchema))]
    public sealed class LeaveRequestToResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://LeaveProject.LeaveResponseSchema"" xmlns:s0=""http://LeaveProject.LeaveRequestSchema"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:LeaveRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:LeaveRequest"">
    <xsl:variable name=""var:v1"" select=""userCSharp:DateCurrentDate()"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;No Of Days of Leave  Requested       &quot; , string(Details/NoOfDays/text()) , &quot;  is greater then 21&quot;)"" />
    <ns0:LeaveResponse>
      <RequestID>
        <xsl:value-of select=""Header/RequestID/text()"" />
      </RequestID>
      <DateOFProcessing>
        <xsl:value-of select=""$var:v1"" />
      </DateOFProcessing>
      <EmpID>
        <xsl:value-of select=""Details/EmpID/text()"" />
      </EmpID>
      <Reason>
        <xsl:value-of select=""$var:v2"" />
      </Reason>
    </ns0:LeaveResponse>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string DateCurrentDate()
{
	DateTime dt = DateTime.Now;
	return dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
}


public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"LeaveProject.LeaveRequestSchema";
        
        private const global::LeaveProject.LeaveRequestSchema _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"LeaveProject.LeaveResponseSchema";
        
        private const global::LeaveProject.LeaveResponseSchema _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"LeaveProject.LeaveRequestSchema";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"LeaveProject.LeaveResponseSchema";
                return _TrgSchemas;
            }
        }
    }
}
