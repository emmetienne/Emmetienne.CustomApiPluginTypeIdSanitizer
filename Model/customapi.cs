
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class customapi
{

    private byte allowedcustomprocessingsteptypeField;

    private byte bindingtypeField;

    private customapiDescription descriptionField;

    private customapiDisplayname displaynameField;

    private byte iscustomizableField;

    private byte isfunctionField;

    private byte isprivateField;

    private string nameField;

    private customapiPlugintypeid plugintypeidField;

    private byte workflowsdkstepenabledField;

    private string uniquenameField;

    /// <remarks/>
    public byte allowedcustomprocessingsteptype
    {
        get
        {
            return this.allowedcustomprocessingsteptypeField;
        }
        set
        {
            this.allowedcustomprocessingsteptypeField = value;
        }
    }

    /// <remarks/>
    public byte bindingtype
    {
        get
        {
            return this.bindingtypeField;
        }
        set
        {
            this.bindingtypeField = value;
        }
    }

    /// <remarks/>
    public customapiDescription description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <remarks/>
    public customapiDisplayname displayname
    {
        get
        {
            return this.displaynameField;
        }
        set
        {
            this.displaynameField = value;
        }
    }

    /// <remarks/>
    public byte iscustomizable
    {
        get
        {
            return this.iscustomizableField;
        }
        set
        {
            this.iscustomizableField = value;
        }
    }

    /// <remarks/>
    public byte isfunction
    {
        get
        {
            return this.isfunctionField;
        }
        set
        {
            this.isfunctionField = value;
        }
    }

    /// <remarks/>
    public byte isprivate
    {
        get
        {
            return this.isprivateField;
        }
        set
        {
            this.isprivateField = value;
        }
    }

    /// <remarks/>
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public customapiPlugintypeid plugintypeid
    {
        get
        {
            return this.plugintypeidField;
        }
        set
        {
            this.plugintypeidField = value;
        }
    }

    /// <remarks/>
    public byte workflowsdkstepenabled
    {
        get
        {
            return this.workflowsdkstepenabledField;
        }
        set
        {
            this.workflowsdkstepenabledField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string uniquename
    {
        get
        {
            return this.uniquenameField;
        }
        set
        {
            this.uniquenameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class customapiDescription
{

    private customapiDescriptionLabel labelField;

    private string defaultField;

    /// <remarks/>
    public customapiDescriptionLabel label
    {
        get
        {
            return this.labelField;
        }
        set
        {
            this.labelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string @default
    {
        get
        {
            return this.defaultField;
        }
        set
        {
            this.defaultField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class customapiDescriptionLabel
{

    private string descriptionField;

    private ushort languagecodeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort languagecode
    {
        get
        {
            return this.languagecodeField;
        }
        set
        {
            this.languagecodeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class customapiDisplayname
{

    private customapiDisplaynameLabel labelField;

    private string defaultField;

    /// <remarks/>
    public customapiDisplaynameLabel label
    {
        get
        {
            return this.labelField;
        }
        set
        {
            this.labelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string @default
    {
        get
        {
            return this.defaultField;
        }
        set
        {
            this.defaultField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class customapiDisplaynameLabel
{

    private string descriptionField;

    private ushort languagecodeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort languagecode
    {
        get
        {
            return this.languagecodeField;
        }
        set
        {
            this.languagecodeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class customapiPlugintypeid
{

    private string plugintypeexportkeyField;

    /// <remarks/>
    public string plugintypeexportkey
    {
        get
        {
            return this.plugintypeexportkeyField;
        }
        set
        {
            this.plugintypeexportkeyField = value;
        }
    }
}

