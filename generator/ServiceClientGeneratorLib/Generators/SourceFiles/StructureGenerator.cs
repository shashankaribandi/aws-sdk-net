﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.SourceFiles
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class StructureGenerator : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

	AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing System.Xml.Serialization;" +
                    "\r\nusing System.Text;\r\nusing System.IO;\r\n\r\nusing Amazon.Runtime;\r\nusing Amazon.Ru" +
                    "ntime.Internal;\r\n\r\nnamespace ");
            
            #line 18 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model\r\n{\r\n");
            
            #line 20 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

	if(this.StructureType == StructureType.Request)
		this.FormatOperationRequestDocumentation(this.Operation);
	else if (this.Operation != null && GeneratorHelpers.HasSuppressedResult(this.Operation))
		this.FormatVoidResultDocumentation(this.Operation.Name);
	else
	    this.FormatClassDocumentation(this.Structure);  

            
            #line default
            #line hidden
            this.Write("\tpublic partial class ");
            
            #line 28 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.ClassName));
            
            #line default
            #line hidden
            
            #line 28 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.BaseClassString));
            
            #line default
            #line hidden
            this.Write("\r\n\t{\r\n");
            
            #line 30 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

        if(this.Structure != null)
        {
            if(this.IsWrapped)
            {

            
            #line default
            #line hidden
            this.Write("        private ");
            
            #line 36 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write(" _response;\r\n");
            
            #line 37 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

            }
            else
            {
		        foreach(var member in this.Structure.Members)
                {
					if (member.IsExcluded)
						continue;

            
            #line default
            #line hidden
            this.Write("        private ");
            
            #line 46 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.DetermineType()));
            
            #line default
            #line hidden
            
            #line 46 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.IsNullable ? "?" : ""));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 46 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            
            #line 46 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.ShouldInstantiate ? string.Format(" = new {0}();", member.DetermineType()) : ";"));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 47 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                }
            }
        }

            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 53 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

        if(this.Structure != null)
        {
            if(this.IsWrapped)
            {

            
            #line default
            #line hidden
            this.Write("        public ");
            
            #line 59 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 59 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write("\r\n        {\r\n            get { return this._response; }\r\n            set { this._" +
                    "response = value; }\r\n        }\r\n");
            
            #line 64 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

            }
            else
            {
        AddSimpleRequestConstructors(this.ClassName, this.Structure, this.Config.Namespace);
		        foreach(var member in this.Structure.Members)
                {
					if (member.IsExcluded)
						continue;

            
            #line default
            #line hidden
            
            #line 74 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
 this.FormatPropertyDocumentation(member); 
            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 75 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.AccessModifier));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 75 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.DetermineType()));
            
            #line default
            #line hidden
            
            #line 75 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.UseNullable ? "?" : ""));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 75 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write("\r\n        {\r\n");
            
            #line 77 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    if(member.IsNullable && !member.UseNullable)
                    {

            
            #line default
            #line hidden
            this.Write("            get { return this.");
            
            #line 81 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(".GetValueOrDefault(); }\r\n");
            
            #line 82 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    }
                    else
                    {

            
            #line default
            #line hidden
            this.Write("            get { return this.");
            
            #line 87 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write("; }\r\n");
            
            #line 88 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    }

            
            #line default
            #line hidden
            this.Write("            set { this.");
            
            #line 91 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(" = value; }\r\n        }\r\n\r\n");
            
            #line 94 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    if (member.EmitIsSetProperties)
                    {

            
            #line default
            #line hidden
            this.Write("        /// <summary>\r\n        /// This property is set to true if the property <" +
                    "seealso cref=\"");
            
            #line 99 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write(@"""/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool Is");
            
            #line 108 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write("Set\r\n        {\r\n            get\r\n            {\r\n                return Amazon.Uti" +
                    "l.Internal.InternalSDKUtils.GetIsSet(this.");
            
            #line 112 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(");\r\n            }\r\n            set\r\n            {\r\n                Amazon.Util.In" +
                    "ternal.InternalSDKUtils.SetIsSet(value, ref this.");
            
            #line 116 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(");\r\n            }\r\n        }\r\n\r\n");
            
            #line 120 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    }

            
            #line default
            #line hidden
            this.Write("        // Check to see if ");
            
            #line 123 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write(" property is set\r\n        internal bool IsSet");
            
            #line 124 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write("()\r\n        {\r\n");
            
            #line 126 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    if (member.EmitIsSetProperties)
                    {

            
            #line default
            #line hidden
            this.Write("            return this.Is");
            
            #line 130 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write("Set; \r\n");
            
            #line 131 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    }
                    else if (member.IsNullable)
                    {

            
            #line default
            #line hidden
            this.Write("            return this.");
            
            #line 136 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(".HasValue; \r\n");
            
            #line 137 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    }
                    else if (member.IsMap || member.IsList)
                    {

            
            #line default
            #line hidden
            this.Write("            return this.");
            
            #line 142 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(" != null && this.");
            
            #line 142 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(".Count > 0; \r\n");
            
            #line 143 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    }
                    else
                    {

            
            #line default
            #line hidden
            this.Write("            return this.");
            
            #line 148 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.VariableName));
            
            #line default
            #line hidden
            this.Write(" != null;\r\n");
            
            #line 149 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                    }

            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n");
            
            #line 154 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

                }
            }
        }

            
            #line default
            #line hidden
            this.Write("    }\r\n}\r\n\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 163 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\StructureGenerator.tt"

    // Set to true when the service model specifies a shape that should be wrapped in a response. ElastiCache CreateCacheCluster is an example of this.
    public bool IsWrapped { get; set; }

	public Operation Operation { get; set; }
    public string ClassName { get; set; }
    public string BaseClass { get; set; }
    public Shape Structure { get; set; }
	public StructureType StructureType { get; set; }

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}