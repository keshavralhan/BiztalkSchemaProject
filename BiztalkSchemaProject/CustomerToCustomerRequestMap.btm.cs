namespace BiztalkSchemaProject {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BiztalkSchemaProject.Customer", typeof(global::BiztalkSchemaProject.Customer))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BiztalkSchemaProject.CustomerRequest", typeof(global::BiztalkSchemaProject.CustomerRequest))]
    public sealed class CustomerToCustomerRequestMap : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://schemas.project.com/customerrequest"" xmlns:s0=""http://schemas.project.com/customer"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Customer"" />
  </xsl:template>
  <xsl:template match=""/s0:Customer"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(string(FirstName/text()) , string(LastName/text()))"" />
    <ns0:CustomerRequest>
      <CustomerName>
        <xsl:value-of select=""$var:v1"" />
      </CustomerName>
      <MiddleName>
        <xsl:value-of select=""MiddleName/text()"" />
      </MiddleName>
      <Age>
        <xsl:value-of select=""Age/text()"" />
      </Age>
      <EmpID>
        <xsl:value-of select=""EmpID/text()"" />
      </EmpID>
    </ns0:CustomerRequest>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1)
{
   return param0 + param1;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BiztalkSchemaProject.Customer";
        
        private const string _strTrgSchemasList0 = @"BiztalkSchemaProject.CustomerRequest";
        
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
                _SrcSchemas[0] = @"BiztalkSchemaProject.Customer";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BiztalkSchemaProject.CustomerRequest";
                return _TrgSchemas;
            }
        }
    }
}
