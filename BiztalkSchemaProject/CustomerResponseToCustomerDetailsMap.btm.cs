namespace BiztalkSchemaProject {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BiztalkSchemaProject.CustomerResponse", typeof(global::BiztalkSchemaProject.CustomerResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BiztalkSchemaProject.CustomerDetails", typeof(global::BiztalkSchemaProject.CustomerDetails))]
    public sealed class CustomerResponseToCustomerDetailsMap : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://schemas.project.com/customerdetails"" xmlns:s0=""http://schemas.project.com/customerresponse"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:CustomerResponse"" />
  </xsl:template>
  <xsl:template match=""/s0:CustomerResponse"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(string(FullName/text()) , &quot;ResponseToDetail&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(string(Age/text()) , &quot;DetailAge&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(string(EmpID/text()) , &quot;DetailEmpID&quot;)"" />
    <ns0:CustomerDetails>
      <FullName>
        <xsl:value-of select=""$var:v1"" />
      </FullName>
      <Age>
        <xsl:value-of select=""$var:v2"" />
      </Age>
      <EmpID>
        <xsl:value-of select=""$var:v3"" />
      </EmpID>
    </ns0:CustomerDetails>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1)
{
   return param0 + param1;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BiztalkSchemaProject.CustomerResponse";
        
        private const string _strTrgSchemasList0 = @"BiztalkSchemaProject.CustomerDetails";
        
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
                _SrcSchemas[0] = @"BiztalkSchemaProject.CustomerResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BiztalkSchemaProject.CustomerDetails";
                return _TrgSchemas;
            }
        }
    }
}
