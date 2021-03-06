﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;

namespace DocumentFormat.OpenXml.Office2010.Drawing.LegacyCompatibility
{
/// <summary>
/// <para>Defines the CompatibilityShape Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is com14:compatSp.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
[SchemaAttr(63, "compatSp")]
public partial class CompatibilityShape : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13208;
    /// <inheritdoc/>
    public override string LocalName => "compatSp";
    internal override byte NamespaceId => 63;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;

    
    
        /// <summary>
    /// <para> spid.</para>
    /// <para>Represents the following attribute in the schema: spid </para>
    /// </summary>
    [SchemaAttr(0, "spid", 0)]
    public StringValue ShapeId { get; set; }

    /// <summary>
    /// Initializes a new instance of the CompatibilityShape class.
    /// </summary>
    public CompatibilityShape():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CompatibilityShape>(deep);

}
}
 
 
