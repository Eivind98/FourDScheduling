// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class SigmaFile
{

    private bool recalculateField;

    private SigmaFileBuildInfo buildInfoField;

    private SigmaFileProjectSettings projectSettingsField;

    private SigmaFileProjectData projectDataField;

    private string fileTypeField;

    private string fileSaveVersionField;

    /// <remarks/>
    public bool Recalculate
    {
        get
        {
            return this.recalculateField;
        }
        set
        {
            this.recalculateField = value;
        }
    }

    /// <remarks/>
    public SigmaFileBuildInfo BuildInfo
    {
        get
        {
            return this.buildInfoField;
        }
        set
        {
            this.buildInfoField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectSettings ProjectSettings
    {
        get
        {
            return this.projectSettingsField;
        }
        set
        {
            this.projectSettingsField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectData ProjectData
    {
        get
        {
            return this.projectDataField;
        }
        set
        {
            this.projectDataField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FileType
    {
        get
        {
            return this.fileTypeField;
        }
        set
        {
            this.fileTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FileSaveVersion
    {
        get
        {
            return this.fileSaveVersionField;
        }
        set
        {
            this.fileSaveVersionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileBuildInfo
{

    private System.DateTime dateTimeField;

    private string sigmaLanguageField;

    private ushort buildNumberField;

    private string sigmaVersionField;

    private string windowsUserField;

    private string sourceField;

    /// <remarks/>
    public System.DateTime DateTime
    {
        get
        {
            return this.dateTimeField;
        }
        set
        {
            this.dateTimeField = value;
        }
    }

    /// <remarks/>
    public string SigmaLanguage
    {
        get
        {
            return this.sigmaLanguageField;
        }
        set
        {
            this.sigmaLanguageField = value;
        }
    }

    /// <remarks/>
    public ushort BuildNumber
    {
        get
        {
            return this.buildNumberField;
        }
        set
        {
            this.buildNumberField = value;
        }
    }

    /// <remarks/>
    public string SigmaVersion
    {
        get
        {
            return this.sigmaVersionField;
        }
        set
        {
            this.sigmaVersionField = value;
        }
    }

    /// <remarks/>
    public string WindowsUser
    {
        get
        {
            return this.windowsUserField;
        }
        set
        {
            this.windowsUserField = value;
        }
    }

    /// <remarks/>
    public string Source
    {
        get
        {
            return this.sourceField;
        }
        set
        {
            this.sourceField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectSettings
{

    private SigmaFileProjectSettingsEncryption encryptionField;

    private SigmaFileProjectSettingsQuickLibrarySettings quickLibrarySettingsField;

    private SigmaFileProjectSettingsFileActivation fileActivationField;

    private bool showSuccessiveField;

    private string treeViewTextField;

    private bool quantityFormulasField;

    private bool doAutoCalcField;

    private SigmaFileProjectSettingsExportToProjectSettings exportToProjectSettingsField;

    private SigmaFileProjectSettingsApproval approvalField;

    private SigmaFileProjectSettingsTemplateUpdateOptions templateUpdateOptionsField;

    private object featuresField;

    private string treeWidthField;

    private bool showTreeField;

    private SigmaFileProjectSettingsContentsSheet contentsSheetField;

    private SigmaFileProjectSettingsEndSheet endSheetField;

    private SigmaFileProjectSettingsSumSheet sumSheetField;

    private SigmaFileProjectSettingsActivitiesSheet activitiesSheetField;

    private SigmaFileProjectSettingsActivityView[] activityViewListField;

    private SigmaFileProjectSettingsCalcSheet calcSheetField;

    /// <remarks/>
    public SigmaFileProjectSettingsEncryption Encryption
    {
        get
        {
            return this.encryptionField;
        }
        set
        {
            this.encryptionField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectSettingsQuickLibrarySettings QuickLibrarySettings
    {
        get
        {
            return this.quickLibrarySettingsField;
        }
        set
        {
            this.quickLibrarySettingsField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectSettingsFileActivation FileActivation
    {
        get
        {
            return this.fileActivationField;
        }
        set
        {
            this.fileActivationField = value;
        }
    }

    /// <remarks/>
    public bool ShowSuccessive
    {
        get
        {
            return this.showSuccessiveField;
        }
        set
        {
            this.showSuccessiveField = value;
        }
    }

    /// <remarks/>
    public string TreeViewText
    {
        get
        {
            return this.treeViewTextField;
        }
        set
        {
            this.treeViewTextField = value;
        }
    }

    /// <remarks/>
    public bool QuantityFormulas
    {
        get
        {
            return this.quantityFormulasField;
        }
        set
        {
            this.quantityFormulasField = value;
        }
    }

    /// <remarks/>
    public bool DoAutoCalc
    {
        get
        {
            return this.doAutoCalcField;
        }
        set
        {
            this.doAutoCalcField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectSettingsExportToProjectSettings ExportToProjectSettings
    {
        get
        {
            return this.exportToProjectSettingsField;
        }
        set
        {
            this.exportToProjectSettingsField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectSettingsApproval Approval
    {
        get
        {
            return this.approvalField;
        }
        set
        {
            this.approvalField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectSettingsTemplateUpdateOptions TemplateUpdateOptions
    {
        get
        {
            return this.templateUpdateOptionsField;
        }
        set
        {
            this.templateUpdateOptionsField = value;
        }
    }

    /// <remarks/>
    public object Features
    {
        get
        {
            return this.featuresField;
        }
        set
        {
            this.featuresField = value;
        }
    }

    /// <remarks/>
    public string TreeWidth
    {
        get
        {
            return this.treeWidthField;
        }
        set
        {
            this.treeWidthField = value;
        }
    }

    /// <remarks/>
    public bool ShowTree
    {
        get
        {
            return this.showTreeField;
        }
        set
        {
            this.showTreeField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectSettingsContentsSheet ContentsSheet
    {
        get
        {
            return this.contentsSheetField;
        }
        set
        {
            this.contentsSheetField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectSettingsEndSheet EndSheet
    {
        get
        {
            return this.endSheetField;
        }
        set
        {
            this.endSheetField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectSettingsSumSheet SumSheet
    {
        get
        {
            return this.sumSheetField;
        }
        set
        {
            this.sumSheetField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectSettingsActivitiesSheet ActivitiesSheet
    {
        get
        {
            return this.activitiesSheetField;
        }
        set
        {
            this.activitiesSheetField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("ActivityView", IsNullable = false)]
    public SigmaFileProjectSettingsActivityView[] ActivityViewList
    {
        get
        {
            return this.activityViewListField;
        }
        set
        {
            this.activityViewListField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectSettingsCalcSheet CalcSheet
    {
        get
        {
            return this.calcSheetField;
        }
        set
        {
            this.calcSheetField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectSettingsEncryption
{

    private bool encryptedField;

    /// <remarks/>
    public bool Encrypted
    {
        get
        {
            return this.encryptedField;
        }
        set
        {
            this.encryptedField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectSettingsQuickLibrarySettings
{

    private bool autoloadField;

    private string colorField;

    private string listtypeField;

    /// <remarks/>
    public bool Autoload
    {
        get
        {
            return this.autoloadField;
        }
        set
        {
            this.autoloadField = value;
        }
    }

    /// <remarks/>
    public string Color
    {
        get
        {
            return this.colorField;
        }
        set
        {
            this.colorField = value;
        }
    }

    /// <remarks/>
    public string Listtype
    {
        get
        {
            return this.listtypeField;
        }
        set
        {
            this.listtypeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectSettingsFileActivation
{

    private string activationMethodVersionField;

    private object vendorIdField;

    private object idField;

    private object vendorField;

    private object webPathField;

    private object nameField;

    /// <remarks/>
    public string ActivationMethodVersion
    {
        get
        {
            return this.activationMethodVersionField;
        }
        set
        {
            this.activationMethodVersionField = value;
        }
    }

    /// <remarks/>
    public object VendorId
    {
        get
        {
            return this.vendorIdField;
        }
        set
        {
            this.vendorIdField = value;
        }
    }

    /// <remarks/>
    public object ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    public object Vendor
    {
        get
        {
            return this.vendorField;
        }
        set
        {
            this.vendorField = value;
        }
    }

    /// <remarks/>
    public object WebPath
    {
        get
        {
            return this.webPathField;
        }
        set
        {
            this.webPathField = value;
        }
    }

    /// <remarks/>
    public object Name
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectSettingsExportToProjectSettings
{

    private string categoriesField;

    private bool allCategoriesField;

    private bool useOperationsField;

    private decimal workHoursField;

    private bool assignFixedCostField;

    private string dependenciesField;

    private string levelsField;

    private bool exportFromRootField;

    private SigmaFileProjectSettingsExportToProjectSettingsItem[] structureField;

    private bool sortedField;

    private bool includeZeroQuantityComponentsField;

    private bool includeComponentsWithoutResourcesField;

    private bool updateField;

    private object updatePathField;

    private object externalDataField;

    /// <remarks/>
    public string Categories
    {
        get
        {
            return this.categoriesField;
        }
        set
        {
            this.categoriesField = value;
        }
    }

    /// <remarks/>
    public bool AllCategories
    {
        get
        {
            return this.allCategoriesField;
        }
        set
        {
            this.allCategoriesField = value;
        }
    }

    /// <remarks/>
    public bool UseOperations
    {
        get
        {
            return this.useOperationsField;
        }
        set
        {
            this.useOperationsField = value;
        }
    }

    /// <remarks/>
    public decimal WorkHours
    {
        get
        {
            return this.workHoursField;
        }
        set
        {
            this.workHoursField = value;
        }
    }

    /// <remarks/>
    public bool AssignFixedCost
    {
        get
        {
            return this.assignFixedCostField;
        }
        set
        {
            this.assignFixedCostField = value;
        }
    }

    /// <remarks/>
    public string Dependencies
    {
        get
        {
            return this.dependenciesField;
        }
        set
        {
            this.dependenciesField = value;
        }
    }

    /// <remarks/>
    public string Levels
    {
        get
        {
            return this.levelsField;
        }
        set
        {
            this.levelsField = value;
        }
    }

    /// <remarks/>
    public bool ExportFromRoot
    {
        get
        {
            return this.exportFromRootField;
        }
        set
        {
            this.exportFromRootField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Item", IsNullable = false)]
    public SigmaFileProjectSettingsExportToProjectSettingsItem[] Structure
    {
        get
        {
            return this.structureField;
        }
        set
        {
            this.structureField = value;
        }
    }

    /// <remarks/>
    public bool Sorted
    {
        get
        {
            return this.sortedField;
        }
        set
        {
            this.sortedField = value;
        }
    }

    /// <remarks/>
    public bool IncludeZeroQuantityComponents
    {
        get
        {
            return this.includeZeroQuantityComponentsField;
        }
        set
        {
            this.includeZeroQuantityComponentsField = value;
        }
    }

    /// <remarks/>
    public bool IncludeComponentsWithoutResources
    {
        get
        {
            return this.includeComponentsWithoutResourcesField;
        }
        set
        {
            this.includeComponentsWithoutResourcesField = value;
        }
    }

    /// <remarks/>
    public bool Update
    {
        get
        {
            return this.updateField;
        }
        set
        {
            this.updateField = value;
        }
    }

    /// <remarks/>
    public object UpdatePath
    {
        get
        {
            return this.updatePathField;
        }
        set
        {
            this.updatePathField = value;
        }
    }

    /// <remarks/>
    public object ExternalData
    {
        get
        {
            return this.externalDataField;
        }
        set
        {
            this.externalDataField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectSettingsExportToProjectSettingsItem
{

    private string itemTypeField;

    private string subItemTypeField;

    private string treeCompIndexField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ItemType
    {
        get
        {
            return this.itemTypeField;
        }
        set
        {
            this.itemTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SubItemType
    {
        get
        {
            return this.subItemTypeField;
        }
        set
        {
            this.subItemTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TreeCompIndex
    {
        get
        {
            return this.treeCompIndexField;
        }
        set
        {
            this.treeCompIndexField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectSettingsApproval
{

    private object rolesField;

    /// <remarks/>
    public object Roles
    {
        get
        {
            return this.rolesField;
        }
        set
        {
            this.rolesField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectSettingsTemplateUpdateOptions
{

    private string updateConstantsFromQuickListField;

    /// <remarks/>
    public string UpdateConstantsFromQuickList
    {
        get
        {
            return this.updateConstantsFromQuickListField;
        }
        set
        {
            this.updateConstantsFromQuickListField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectSettingsContentsSheet
{

    private SigmaFileProjectSettingsContentsSheetColumns columnsField;

    private object customFieldsField;

    private bool showDefaultContSheetKeyfiguresField;

    private string[] contentKeyFiguresField;

    /// <remarks/>
    public SigmaFileProjectSettingsContentsSheetColumns Columns
    {
        get
        {
            return this.columnsField;
        }
        set
        {
            this.columnsField = value;
        }
    }

    /// <remarks/>
    public object CustomFields
    {
        get
        {
            return this.customFieldsField;
        }
        set
        {
            this.customFieldsField = value;
        }
    }

    /// <remarks/>
    public bool ShowDefaultContSheetKeyfigures
    {
        get
        {
            return this.showDefaultContSheetKeyfiguresField;
        }
        set
        {
            this.showDefaultContSheetKeyfiguresField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Item", IsNullable = false)]
    public string[] ContentKeyFigures
    {
        get
        {
            return this.contentKeyFiguresField;
        }
        set
        {
            this.contentKeyFiguresField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectSettingsContentsSheetColumns
{

    private string positionField;

    private string damagePercentageSelectedField;

    private string numberField;

    private string nameField;

    private string dependencyField;

    private string noteMarkField;

    private string operationField;

    private string categoryField;

    private string unitField;

    private string noteField;

    private string quantityUnregulatedField;

    private string quantityRegulationField;

    private string amountMinField;

    private string amountTypField;

    private string amountMaxField;

    private string amountField;

    private string productionRateField;

    private string productionUnitField;

    private string absoluteQuantityUnregulatedField;

    private string absoluteQuantityField;

    private string currencyField;

    private string unitPriceMinField;

    private string unitPriceTypField;

    private string unitPriceMaxField;

    private string unitPriceField;

    private string productionUnitPriceField;

    private string costPriceField;

    private string itemPriceField;

    private string regCostPriceField;

    private string absoluteRegCostPriceField;

    private string stdSpreadField;

    private string compareUnitPriceField;

    private string compareSalesPriceField;

    private string absoluteComparePriceField;

    private string regulationField;

    private string costPriceContribution1Field;

    private string costPriceContribution2Field;

    private string costPriceContribution3Field;

    private string costPriceContribution4Field;

    private string costPriceContribution5Field;

    private string costPriceWithContributionField;

    private string absoluteCostPriceWithContributionField;

    private string salesPriceContribution1Field;

    private string salesPriceContribution2Field;

    private string salesPriceContribution3Field;

    private string salesPriceContribution4Field;

    private string salesPriceContribution5Field;

    private string incomeField;

    private string reallocatedIncomeField;

    private string salesPriceBeforeDiscountField;

    private string absoluteSalesPriceBeforeDiscountField;

    private string discountContribution1Field;

    private string discountContribution2Field;

    private string discountContribution3Field;

    private string discountContribution4Field;

    private string discountContribution5Field;

    private string discountContributionPercentageField;

    private string discountContributionAdjustmentField;

    private string totalDiscountPercentageField;

    private string totalDiscountAmountField;

    private string roundingField;

    private string unitIncomeField;

    private string unitSalesPriceField;

    private string salesPriceField;

    private string absoluteSalesPriceField;

    private string totalIncomeField;

    private string absoluteTotalIncomeField;

    private string totalProfitMarginField;

    private string prioritetField;

    private string nowValueFollowPercentageField;

    private string nowValuePercentageField;

    private string nowValueField;

    private string remainPercentageField;

    private string remainField;

    private string damagePercentageField;

    private string damageQuantityField;

    private string damageField;

    private string damageNowValueField;

    private string damageBaseField;

    private string damageBaseNowValueField;

    private string legalCostPercentageField;

    private string legalCostField;

    private string flagsField;

    private string keyWordsField;

    private string serviceUnitPriceField;

    private string serviceTotalPriceField;

    private string unitTimeField;

    private string totalTimeField;

    /// <remarks/>
    public string Position
    {
        get
        {
            return this.positionField;
        }
        set
        {
            this.positionField = value;
        }
    }

    /// <remarks/>
    public string DamagePercentageSelected
    {
        get
        {
            return this.damagePercentageSelectedField;
        }
        set
        {
            this.damagePercentageSelectedField = value;
        }
    }

    /// <remarks/>
    public string Number
    {
        get
        {
            return this.numberField;
        }
        set
        {
            this.numberField = value;
        }
    }

    /// <remarks/>
    public string Name
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
    public string Dependency
    {
        get
        {
            return this.dependencyField;
        }
        set
        {
            this.dependencyField = value;
        }
    }

    /// <remarks/>
    public string NoteMark
    {
        get
        {
            return this.noteMarkField;
        }
        set
        {
            this.noteMarkField = value;
        }
    }

    /// <remarks/>
    public string Operation
    {
        get
        {
            return this.operationField;
        }
        set
        {
            this.operationField = value;
        }
    }

    /// <remarks/>
    public string Category
    {
        get
        {
            return this.categoryField;
        }
        set
        {
            this.categoryField = value;
        }
    }

    /// <remarks/>
    public string Unit
    {
        get
        {
            return this.unitField;
        }
        set
        {
            this.unitField = value;
        }
    }

    /// <remarks/>
    public string Note
    {
        get
        {
            return this.noteField;
        }
        set
        {
            this.noteField = value;
        }
    }

    /// <remarks/>
    public string QuantityUnregulated
    {
        get
        {
            return this.quantityUnregulatedField;
        }
        set
        {
            this.quantityUnregulatedField = value;
        }
    }

    /// <remarks/>
    public string QuantityRegulation
    {
        get
        {
            return this.quantityRegulationField;
        }
        set
        {
            this.quantityRegulationField = value;
        }
    }

    /// <remarks/>
    public string AmountMin
    {
        get
        {
            return this.amountMinField;
        }
        set
        {
            this.amountMinField = value;
        }
    }

    /// <remarks/>
    public string AmountTyp
    {
        get
        {
            return this.amountTypField;
        }
        set
        {
            this.amountTypField = value;
        }
    }

    /// <remarks/>
    public string AmountMax
    {
        get
        {
            return this.amountMaxField;
        }
        set
        {
            this.amountMaxField = value;
        }
    }

    /// <remarks/>
    public string Amount
    {
        get
        {
            return this.amountField;
        }
        set
        {
            this.amountField = value;
        }
    }

    /// <remarks/>
    public string ProductionRate
    {
        get
        {
            return this.productionRateField;
        }
        set
        {
            this.productionRateField = value;
        }
    }

    /// <remarks/>
    public string ProductionUnit
    {
        get
        {
            return this.productionUnitField;
        }
        set
        {
            this.productionUnitField = value;
        }
    }

    /// <remarks/>
    public string AbsoluteQuantityUnregulated
    {
        get
        {
            return this.absoluteQuantityUnregulatedField;
        }
        set
        {
            this.absoluteQuantityUnregulatedField = value;
        }
    }

    /// <remarks/>
    public string AbsoluteQuantity
    {
        get
        {
            return this.absoluteQuantityField;
        }
        set
        {
            this.absoluteQuantityField = value;
        }
    }

    /// <remarks/>
    public string Currency
    {
        get
        {
            return this.currencyField;
        }
        set
        {
            this.currencyField = value;
        }
    }

    /// <remarks/>
    public string UnitPriceMin
    {
        get
        {
            return this.unitPriceMinField;
        }
        set
        {
            this.unitPriceMinField = value;
        }
    }

    /// <remarks/>
    public string UnitPriceTyp
    {
        get
        {
            return this.unitPriceTypField;
        }
        set
        {
            this.unitPriceTypField = value;
        }
    }

    /// <remarks/>
    public string UnitPriceMax
    {
        get
        {
            return this.unitPriceMaxField;
        }
        set
        {
            this.unitPriceMaxField = value;
        }
    }

    /// <remarks/>
    public string UnitPrice
    {
        get
        {
            return this.unitPriceField;
        }
        set
        {
            this.unitPriceField = value;
        }
    }

    /// <remarks/>
    public string ProductionUnitPrice
    {
        get
        {
            return this.productionUnitPriceField;
        }
        set
        {
            this.productionUnitPriceField = value;
        }
    }

    /// <remarks/>
    public string CostPrice
    {
        get
        {
            return this.costPriceField;
        }
        set
        {
            this.costPriceField = value;
        }
    }

    /// <remarks/>
    public string ItemPrice
    {
        get
        {
            return this.itemPriceField;
        }
        set
        {
            this.itemPriceField = value;
        }
    }

    /// <remarks/>
    public string RegCostPrice
    {
        get
        {
            return this.regCostPriceField;
        }
        set
        {
            this.regCostPriceField = value;
        }
    }

    /// <remarks/>
    public string AbsoluteRegCostPrice
    {
        get
        {
            return this.absoluteRegCostPriceField;
        }
        set
        {
            this.absoluteRegCostPriceField = value;
        }
    }

    /// <remarks/>
    public string StdSpread
    {
        get
        {
            return this.stdSpreadField;
        }
        set
        {
            this.stdSpreadField = value;
        }
    }

    /// <remarks/>
    public string CompareUnitPrice
    {
        get
        {
            return this.compareUnitPriceField;
        }
        set
        {
            this.compareUnitPriceField = value;
        }
    }

    /// <remarks/>
    public string CompareSalesPrice
    {
        get
        {
            return this.compareSalesPriceField;
        }
        set
        {
            this.compareSalesPriceField = value;
        }
    }

    /// <remarks/>
    public string AbsoluteComparePrice
    {
        get
        {
            return this.absoluteComparePriceField;
        }
        set
        {
            this.absoluteComparePriceField = value;
        }
    }

    /// <remarks/>
    public string Regulation
    {
        get
        {
            return this.regulationField;
        }
        set
        {
            this.regulationField = value;
        }
    }

    /// <remarks/>
    public string CostPriceContribution1
    {
        get
        {
            return this.costPriceContribution1Field;
        }
        set
        {
            this.costPriceContribution1Field = value;
        }
    }

    /// <remarks/>
    public string CostPriceContribution2
    {
        get
        {
            return this.costPriceContribution2Field;
        }
        set
        {
            this.costPriceContribution2Field = value;
        }
    }

    /// <remarks/>
    public string CostPriceContribution3
    {
        get
        {
            return this.costPriceContribution3Field;
        }
        set
        {
            this.costPriceContribution3Field = value;
        }
    }

    /// <remarks/>
    public string CostPriceContribution4
    {
        get
        {
            return this.costPriceContribution4Field;
        }
        set
        {
            this.costPriceContribution4Field = value;
        }
    }

    /// <remarks/>
    public string CostPriceContribution5
    {
        get
        {
            return this.costPriceContribution5Field;
        }
        set
        {
            this.costPriceContribution5Field = value;
        }
    }

    /// <remarks/>
    public string CostPriceWithContribution
    {
        get
        {
            return this.costPriceWithContributionField;
        }
        set
        {
            this.costPriceWithContributionField = value;
        }
    }

    /// <remarks/>
    public string AbsoluteCostPriceWithContribution
    {
        get
        {
            return this.absoluteCostPriceWithContributionField;
        }
        set
        {
            this.absoluteCostPriceWithContributionField = value;
        }
    }

    /// <remarks/>
    public string SalesPriceContribution1
    {
        get
        {
            return this.salesPriceContribution1Field;
        }
        set
        {
            this.salesPriceContribution1Field = value;
        }
    }

    /// <remarks/>
    public string SalesPriceContribution2
    {
        get
        {
            return this.salesPriceContribution2Field;
        }
        set
        {
            this.salesPriceContribution2Field = value;
        }
    }

    /// <remarks/>
    public string SalesPriceContribution3
    {
        get
        {
            return this.salesPriceContribution3Field;
        }
        set
        {
            this.salesPriceContribution3Field = value;
        }
    }

    /// <remarks/>
    public string SalesPriceContribution4
    {
        get
        {
            return this.salesPriceContribution4Field;
        }
        set
        {
            this.salesPriceContribution4Field = value;
        }
    }

    /// <remarks/>
    public string SalesPriceContribution5
    {
        get
        {
            return this.salesPriceContribution5Field;
        }
        set
        {
            this.salesPriceContribution5Field = value;
        }
    }

    /// <remarks/>
    public string Income
    {
        get
        {
            return this.incomeField;
        }
        set
        {
            this.incomeField = value;
        }
    }

    /// <remarks/>
    public string ReallocatedIncome
    {
        get
        {
            return this.reallocatedIncomeField;
        }
        set
        {
            this.reallocatedIncomeField = value;
        }
    }

    /// <remarks/>
    public string SalesPriceBeforeDiscount
    {
        get
        {
            return this.salesPriceBeforeDiscountField;
        }
        set
        {
            this.salesPriceBeforeDiscountField = value;
        }
    }

    /// <remarks/>
    public string AbsoluteSalesPriceBeforeDiscount
    {
        get
        {
            return this.absoluteSalesPriceBeforeDiscountField;
        }
        set
        {
            this.absoluteSalesPriceBeforeDiscountField = value;
        }
    }

    /// <remarks/>
    public string DiscountContribution1
    {
        get
        {
            return this.discountContribution1Field;
        }
        set
        {
            this.discountContribution1Field = value;
        }
    }

    /// <remarks/>
    public string DiscountContribution2
    {
        get
        {
            return this.discountContribution2Field;
        }
        set
        {
            this.discountContribution2Field = value;
        }
    }

    /// <remarks/>
    public string DiscountContribution3
    {
        get
        {
            return this.discountContribution3Field;
        }
        set
        {
            this.discountContribution3Field = value;
        }
    }

    /// <remarks/>
    public string DiscountContribution4
    {
        get
        {
            return this.discountContribution4Field;
        }
        set
        {
            this.discountContribution4Field = value;
        }
    }

    /// <remarks/>
    public string DiscountContribution5
    {
        get
        {
            return this.discountContribution5Field;
        }
        set
        {
            this.discountContribution5Field = value;
        }
    }

    /// <remarks/>
    public string DiscountContributionPercentage
    {
        get
        {
            return this.discountContributionPercentageField;
        }
        set
        {
            this.discountContributionPercentageField = value;
        }
    }

    /// <remarks/>
    public string DiscountContributionAdjustment
    {
        get
        {
            return this.discountContributionAdjustmentField;
        }
        set
        {
            this.discountContributionAdjustmentField = value;
        }
    }

    /// <remarks/>
    public string TotalDiscountPercentage
    {
        get
        {
            return this.totalDiscountPercentageField;
        }
        set
        {
            this.totalDiscountPercentageField = value;
        }
    }

    /// <remarks/>
    public string TotalDiscountAmount
    {
        get
        {
            return this.totalDiscountAmountField;
        }
        set
        {
            this.totalDiscountAmountField = value;
        }
    }

    /// <remarks/>
    public string Rounding
    {
        get
        {
            return this.roundingField;
        }
        set
        {
            this.roundingField = value;
        }
    }

    /// <remarks/>
    public string UnitIncome
    {
        get
        {
            return this.unitIncomeField;
        }
        set
        {
            this.unitIncomeField = value;
        }
    }

    /// <remarks/>
    public string UnitSalesPrice
    {
        get
        {
            return this.unitSalesPriceField;
        }
        set
        {
            this.unitSalesPriceField = value;
        }
    }

    /// <remarks/>
    public string SalesPrice
    {
        get
        {
            return this.salesPriceField;
        }
        set
        {
            this.salesPriceField = value;
        }
    }

    /// <remarks/>
    public string AbsoluteSalesPrice
    {
        get
        {
            return this.absoluteSalesPriceField;
        }
        set
        {
            this.absoluteSalesPriceField = value;
        }
    }

    /// <remarks/>
    public string TotalIncome
    {
        get
        {
            return this.totalIncomeField;
        }
        set
        {
            this.totalIncomeField = value;
        }
    }

    /// <remarks/>
    public string AbsoluteTotalIncome
    {
        get
        {
            return this.absoluteTotalIncomeField;
        }
        set
        {
            this.absoluteTotalIncomeField = value;
        }
    }

    /// <remarks/>
    public string TotalProfitMargin
    {
        get
        {
            return this.totalProfitMarginField;
        }
        set
        {
            this.totalProfitMarginField = value;
        }
    }

    /// <remarks/>
    public string Prioritet
    {
        get
        {
            return this.prioritetField;
        }
        set
        {
            this.prioritetField = value;
        }
    }

    /// <remarks/>
    public string NowValueFollowPercentage
    {
        get
        {
            return this.nowValueFollowPercentageField;
        }
        set
        {
            this.nowValueFollowPercentageField = value;
        }
    }

    /// <remarks/>
    public string NowValuePercentage
    {
        get
        {
            return this.nowValuePercentageField;
        }
        set
        {
            this.nowValuePercentageField = value;
        }
    }

    /// <remarks/>
    public string NowValue
    {
        get
        {
            return this.nowValueField;
        }
        set
        {
            this.nowValueField = value;
        }
    }

    /// <remarks/>
    public string RemainPercentage
    {
        get
        {
            return this.remainPercentageField;
        }
        set
        {
            this.remainPercentageField = value;
        }
    }

    /// <remarks/>
    public string Remain
    {
        get
        {
            return this.remainField;
        }
        set
        {
            this.remainField = value;
        }
    }

    /// <remarks/>
    public string DamagePercentage
    {
        get
        {
            return this.damagePercentageField;
        }
        set
        {
            this.damagePercentageField = value;
        }
    }

    /// <remarks/>
    public string DamageQuantity
    {
        get
        {
            return this.damageQuantityField;
        }
        set
        {
            this.damageQuantityField = value;
        }
    }

    /// <remarks/>
    public string Damage
    {
        get
        {
            return this.damageField;
        }
        set
        {
            this.damageField = value;
        }
    }

    /// <remarks/>
    public string DamageNowValue
    {
        get
        {
            return this.damageNowValueField;
        }
        set
        {
            this.damageNowValueField = value;
        }
    }

    /// <remarks/>
    public string DamageBase
    {
        get
        {
            return this.damageBaseField;
        }
        set
        {
            this.damageBaseField = value;
        }
    }

    /// <remarks/>
    public string DamageBaseNowValue
    {
        get
        {
            return this.damageBaseNowValueField;
        }
        set
        {
            this.damageBaseNowValueField = value;
        }
    }

    /// <remarks/>
    public string LegalCostPercentage
    {
        get
        {
            return this.legalCostPercentageField;
        }
        set
        {
            this.legalCostPercentageField = value;
        }
    }

    /// <remarks/>
    public string LegalCost
    {
        get
        {
            return this.legalCostField;
        }
        set
        {
            this.legalCostField = value;
        }
    }

    /// <remarks/>
    public string Flags
    {
        get
        {
            return this.flagsField;
        }
        set
        {
            this.flagsField = value;
        }
    }

    /// <remarks/>
    public string KeyWords
    {
        get
        {
            return this.keyWordsField;
        }
        set
        {
            this.keyWordsField = value;
        }
    }

    /// <remarks/>
    public string ServiceUnitPrice
    {
        get
        {
            return this.serviceUnitPriceField;
        }
        set
        {
            this.serviceUnitPriceField = value;
        }
    }

    /// <remarks/>
    public string ServiceTotalPrice
    {
        get
        {
            return this.serviceTotalPriceField;
        }
        set
        {
            this.serviceTotalPriceField = value;
        }
    }

    /// <remarks/>
    public string UnitTime
    {
        get
        {
            return this.unitTimeField;
        }
        set
        {
            this.unitTimeField = value;
        }
    }

    /// <remarks/>
    public string TotalTime
    {
        get
        {
            return this.totalTimeField;
        }
        set
        {
            this.totalTimeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectSettingsEndSheet
{

    private SigmaFileProjectSettingsEndSheetColumns columnsField;

    private SigmaFileProjectSettingsEndSheetCalcSheet calcSheetField;

    /// <remarks/>
    public SigmaFileProjectSettingsEndSheetColumns Columns
    {
        get
        {
            return this.columnsField;
        }
        set
        {
            this.columnsField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectSettingsEndSheetCalcSheet CalcSheet
    {
        get
        {
            return this.calcSheetField;
        }
        set
        {
            this.calcSheetField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectSettingsEndSheetColumns
{

    private string positionField;

    private string damagePercentageSelectedField;

    private string numberField;

    private string nameField;

    private string noteMarkField;

    private string operationField;

    private string categoryField;

    private string unitField;

    private string noteField;

    private string quantityUnregulatedField;

    private string amountMinField;

    private string amountTypField;

    private string amountMaxField;

    private string amountField;

    private string productionRateField;

    private string productionUnitField;

    private string currencyField;

    private string unitPriceMinField;

    private string unitPriceTypField;

    private string unitPriceMaxField;

    private string unitPriceField;

    private string productionUnitPriceField;

    private string costPriceField;

    private string itemPriceField;

    private string regCostPriceField;

    private string stdSpreadField;

    private string regulationField;

    private string compareUnitPriceField;

    private string compareSalesPriceField;

    private string costPriceContribution1Field;

    private string costPriceContribution2Field;

    private string costPriceContribution3Field;

    private string costPriceContribution4Field;

    private string costPriceContribution5Field;

    private string costPriceWithContributionField;

    private string salesPriceContribution1Field;

    private string salesPriceContribution2Field;

    private string salesPriceContribution3Field;

    private string salesPriceContribution4Field;

    private string salesPriceContribution5Field;

    private string incomeField;

    private string salesPriceBeforeDiscountField;

    private string discountContribution1Field;

    private string discountContribution2Field;

    private string discountContribution3Field;

    private string discountContribution4Field;

    private string discountContribution5Field;

    private string discountContributionPercentageField;

    private string discountContributionAdjustmentField;

    private string reallocatedIncomeField;

    private string roundingField;

    private string prioritetField;

    private string flagsField;

    private string unitSalesPriceField;

    private string salesPriceField;

    private string totalProfitMarginField;

    private string totalIncomeField;

    private string totalDiscountPercentageField;

    private string totalDiscountAmountField;

    private string remainPercentageField;

    private string remainField;

    private string nowValueFollowPercentageField;

    private string nowValuePercentageField;

    private string nowValueField;

    private string damageQuantityField;

    private string damagePercentageField;

    private string damageField;

    private string damageNowValueField;

    private string damageBaseField;

    private string damageBaseNowValueField;

    private string legalCostPercentageField;

    private string legalCostField;

    private string serviceUnitPriceField;

    private string serviceTotalPriceField;

    private string unitTimeField;

    private string totalTimeField;

    /// <remarks/>
    public string Position
    {
        get
        {
            return this.positionField;
        }
        set
        {
            this.positionField = value;
        }
    }

    /// <remarks/>
    public string DamagePercentageSelected
    {
        get
        {
            return this.damagePercentageSelectedField;
        }
        set
        {
            this.damagePercentageSelectedField = value;
        }
    }

    /// <remarks/>
    public string Number
    {
        get
        {
            return this.numberField;
        }
        set
        {
            this.numberField = value;
        }
    }

    /// <remarks/>
    public string Name
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
    public string NoteMark
    {
        get
        {
            return this.noteMarkField;
        }
        set
        {
            this.noteMarkField = value;
        }
    }

    /// <remarks/>
    public string Operation
    {
        get
        {
            return this.operationField;
        }
        set
        {
            this.operationField = value;
        }
    }

    /// <remarks/>
    public string Category
    {
        get
        {
            return this.categoryField;
        }
        set
        {
            this.categoryField = value;
        }
    }

    /// <remarks/>
    public string Unit
    {
        get
        {
            return this.unitField;
        }
        set
        {
            this.unitField = value;
        }
    }

    /// <remarks/>
    public string Note
    {
        get
        {
            return this.noteField;
        }
        set
        {
            this.noteField = value;
        }
    }

    /// <remarks/>
    public string QuantityUnregulated
    {
        get
        {
            return this.quantityUnregulatedField;
        }
        set
        {
            this.quantityUnregulatedField = value;
        }
    }

    /// <remarks/>
    public string AmountMin
    {
        get
        {
            return this.amountMinField;
        }
        set
        {
            this.amountMinField = value;
        }
    }

    /// <remarks/>
    public string AmountTyp
    {
        get
        {
            return this.amountTypField;
        }
        set
        {
            this.amountTypField = value;
        }
    }

    /// <remarks/>
    public string AmountMax
    {
        get
        {
            return this.amountMaxField;
        }
        set
        {
            this.amountMaxField = value;
        }
    }

    /// <remarks/>
    public string Amount
    {
        get
        {
            return this.amountField;
        }
        set
        {
            this.amountField = value;
        }
    }

    /// <remarks/>
    public string ProductionRate
    {
        get
        {
            return this.productionRateField;
        }
        set
        {
            this.productionRateField = value;
        }
    }

    /// <remarks/>
    public string ProductionUnit
    {
        get
        {
            return this.productionUnitField;
        }
        set
        {
            this.productionUnitField = value;
        }
    }

    /// <remarks/>
    public string Currency
    {
        get
        {
            return this.currencyField;
        }
        set
        {
            this.currencyField = value;
        }
    }

    /// <remarks/>
    public string UnitPriceMin
    {
        get
        {
            return this.unitPriceMinField;
        }
        set
        {
            this.unitPriceMinField = value;
        }
    }

    /// <remarks/>
    public string UnitPriceTyp
    {
        get
        {
            return this.unitPriceTypField;
        }
        set
        {
            this.unitPriceTypField = value;
        }
    }

    /// <remarks/>
    public string UnitPriceMax
    {
        get
        {
            return this.unitPriceMaxField;
        }
        set
        {
            this.unitPriceMaxField = value;
        }
    }

    /// <remarks/>
    public string UnitPrice
    {
        get
        {
            return this.unitPriceField;
        }
        set
        {
            this.unitPriceField = value;
        }
    }

    /// <remarks/>
    public string ProductionUnitPrice
    {
        get
        {
            return this.productionUnitPriceField;
        }
        set
        {
            this.productionUnitPriceField = value;
        }
    }

    /// <remarks/>
    public string CostPrice
    {
        get
        {
            return this.costPriceField;
        }
        set
        {
            this.costPriceField = value;
        }
    }

    /// <remarks/>
    public string ItemPrice
    {
        get
        {
            return this.itemPriceField;
        }
        set
        {
            this.itemPriceField = value;
        }
    }

    /// <remarks/>
    public string RegCostPrice
    {
        get
        {
            return this.regCostPriceField;
        }
        set
        {
            this.regCostPriceField = value;
        }
    }

    /// <remarks/>
    public string StdSpread
    {
        get
        {
            return this.stdSpreadField;
        }
        set
        {
            this.stdSpreadField = value;
        }
    }

    /// <remarks/>
    public string Regulation
    {
        get
        {
            return this.regulationField;
        }
        set
        {
            this.regulationField = value;
        }
    }

    /// <remarks/>
    public string CompareUnitPrice
    {
        get
        {
            return this.compareUnitPriceField;
        }
        set
        {
            this.compareUnitPriceField = value;
        }
    }

    /// <remarks/>
    public string CompareSalesPrice
    {
        get
        {
            return this.compareSalesPriceField;
        }
        set
        {
            this.compareSalesPriceField = value;
        }
    }

    /// <remarks/>
    public string CostPriceContribution1
    {
        get
        {
            return this.costPriceContribution1Field;
        }
        set
        {
            this.costPriceContribution1Field = value;
        }
    }

    /// <remarks/>
    public string CostPriceContribution2
    {
        get
        {
            return this.costPriceContribution2Field;
        }
        set
        {
            this.costPriceContribution2Field = value;
        }
    }

    /// <remarks/>
    public string CostPriceContribution3
    {
        get
        {
            return this.costPriceContribution3Field;
        }
        set
        {
            this.costPriceContribution3Field = value;
        }
    }

    /// <remarks/>
    public string CostPriceContribution4
    {
        get
        {
            return this.costPriceContribution4Field;
        }
        set
        {
            this.costPriceContribution4Field = value;
        }
    }

    /// <remarks/>
    public string CostPriceContribution5
    {
        get
        {
            return this.costPriceContribution5Field;
        }
        set
        {
            this.costPriceContribution5Field = value;
        }
    }

    /// <remarks/>
    public string CostPriceWithContribution
    {
        get
        {
            return this.costPriceWithContributionField;
        }
        set
        {
            this.costPriceWithContributionField = value;
        }
    }

    /// <remarks/>
    public string SalesPriceContribution1
    {
        get
        {
            return this.salesPriceContribution1Field;
        }
        set
        {
            this.salesPriceContribution1Field = value;
        }
    }

    /// <remarks/>
    public string SalesPriceContribution2
    {
        get
        {
            return this.salesPriceContribution2Field;
        }
        set
        {
            this.salesPriceContribution2Field = value;
        }
    }

    /// <remarks/>
    public string SalesPriceContribution3
    {
        get
        {
            return this.salesPriceContribution3Field;
        }
        set
        {
            this.salesPriceContribution3Field = value;
        }
    }

    /// <remarks/>
    public string SalesPriceContribution4
    {
        get
        {
            return this.salesPriceContribution4Field;
        }
        set
        {
            this.salesPriceContribution4Field = value;
        }
    }

    /// <remarks/>
    public string SalesPriceContribution5
    {
        get
        {
            return this.salesPriceContribution5Field;
        }
        set
        {
            this.salesPriceContribution5Field = value;
        }
    }

    /// <remarks/>
    public string Income
    {
        get
        {
            return this.incomeField;
        }
        set
        {
            this.incomeField = value;
        }
    }

    /// <remarks/>
    public string SalesPriceBeforeDiscount
    {
        get
        {
            return this.salesPriceBeforeDiscountField;
        }
        set
        {
            this.salesPriceBeforeDiscountField = value;
        }
    }

    /// <remarks/>
    public string DiscountContribution1
    {
        get
        {
            return this.discountContribution1Field;
        }
        set
        {
            this.discountContribution1Field = value;
        }
    }

    /// <remarks/>
    public string DiscountContribution2
    {
        get
        {
            return this.discountContribution2Field;
        }
        set
        {
            this.discountContribution2Field = value;
        }
    }

    /// <remarks/>
    public string DiscountContribution3
    {
        get
        {
            return this.discountContribution3Field;
        }
        set
        {
            this.discountContribution3Field = value;
        }
    }

    /// <remarks/>
    public string DiscountContribution4
    {
        get
        {
            return this.discountContribution4Field;
        }
        set
        {
            this.discountContribution4Field = value;
        }
    }

    /// <remarks/>
    public string DiscountContribution5
    {
        get
        {
            return this.discountContribution5Field;
        }
        set
        {
            this.discountContribution5Field = value;
        }
    }

    /// <remarks/>
    public string DiscountContributionPercentage
    {
        get
        {
            return this.discountContributionPercentageField;
        }
        set
        {
            this.discountContributionPercentageField = value;
        }
    }

    /// <remarks/>
    public string DiscountContributionAdjustment
    {
        get
        {
            return this.discountContributionAdjustmentField;
        }
        set
        {
            this.discountContributionAdjustmentField = value;
        }
    }

    /// <remarks/>
    public string ReallocatedIncome
    {
        get
        {
            return this.reallocatedIncomeField;
        }
        set
        {
            this.reallocatedIncomeField = value;
        }
    }

    /// <remarks/>
    public string Rounding
    {
        get
        {
            return this.roundingField;
        }
        set
        {
            this.roundingField = value;
        }
    }

    /// <remarks/>
    public string Prioritet
    {
        get
        {
            return this.prioritetField;
        }
        set
        {
            this.prioritetField = value;
        }
    }

    /// <remarks/>
    public string Flags
    {
        get
        {
            return this.flagsField;
        }
        set
        {
            this.flagsField = value;
        }
    }

    /// <remarks/>
    public string UnitSalesPrice
    {
        get
        {
            return this.unitSalesPriceField;
        }
        set
        {
            this.unitSalesPriceField = value;
        }
    }

    /// <remarks/>
    public string SalesPrice
    {
        get
        {
            return this.salesPriceField;
        }
        set
        {
            this.salesPriceField = value;
        }
    }

    /// <remarks/>
    public string TotalProfitMargin
    {
        get
        {
            return this.totalProfitMarginField;
        }
        set
        {
            this.totalProfitMarginField = value;
        }
    }

    /// <remarks/>
    public string TotalIncome
    {
        get
        {
            return this.totalIncomeField;
        }
        set
        {
            this.totalIncomeField = value;
        }
    }

    /// <remarks/>
    public string TotalDiscountPercentage
    {
        get
        {
            return this.totalDiscountPercentageField;
        }
        set
        {
            this.totalDiscountPercentageField = value;
        }
    }

    /// <remarks/>
    public string TotalDiscountAmount
    {
        get
        {
            return this.totalDiscountAmountField;
        }
        set
        {
            this.totalDiscountAmountField = value;
        }
    }

    /// <remarks/>
    public string RemainPercentage
    {
        get
        {
            return this.remainPercentageField;
        }
        set
        {
            this.remainPercentageField = value;
        }
    }

    /// <remarks/>
    public string Remain
    {
        get
        {
            return this.remainField;
        }
        set
        {
            this.remainField = value;
        }
    }

    /// <remarks/>
    public string NowValueFollowPercentage
    {
        get
        {
            return this.nowValueFollowPercentageField;
        }
        set
        {
            this.nowValueFollowPercentageField = value;
        }
    }

    /// <remarks/>
    public string NowValuePercentage
    {
        get
        {
            return this.nowValuePercentageField;
        }
        set
        {
            this.nowValuePercentageField = value;
        }
    }

    /// <remarks/>
    public string NowValue
    {
        get
        {
            return this.nowValueField;
        }
        set
        {
            this.nowValueField = value;
        }
    }

    /// <remarks/>
    public string DamageQuantity
    {
        get
        {
            return this.damageQuantityField;
        }
        set
        {
            this.damageQuantityField = value;
        }
    }

    /// <remarks/>
    public string DamagePercentage
    {
        get
        {
            return this.damagePercentageField;
        }
        set
        {
            this.damagePercentageField = value;
        }
    }

    /// <remarks/>
    public string Damage
    {
        get
        {
            return this.damageField;
        }
        set
        {
            this.damageField = value;
        }
    }

    /// <remarks/>
    public string DamageNowValue
    {
        get
        {
            return this.damageNowValueField;
        }
        set
        {
            this.damageNowValueField = value;
        }
    }

    /// <remarks/>
    public string DamageBase
    {
        get
        {
            return this.damageBaseField;
        }
        set
        {
            this.damageBaseField = value;
        }
    }

    /// <remarks/>
    public string DamageBaseNowValue
    {
        get
        {
            return this.damageBaseNowValueField;
        }
        set
        {
            this.damageBaseNowValueField = value;
        }
    }

    /// <remarks/>
    public string LegalCostPercentage
    {
        get
        {
            return this.legalCostPercentageField;
        }
        set
        {
            this.legalCostPercentageField = value;
        }
    }

    /// <remarks/>
    public string LegalCost
    {
        get
        {
            return this.legalCostField;
        }
        set
        {
            this.legalCostField = value;
        }
    }

    /// <remarks/>
    public string ServiceUnitPrice
    {
        get
        {
            return this.serviceUnitPriceField;
        }
        set
        {
            this.serviceUnitPriceField = value;
        }
    }

    /// <remarks/>
    public string ServiceTotalPrice
    {
        get
        {
            return this.serviceTotalPriceField;
        }
        set
        {
            this.serviceTotalPriceField = value;
        }
    }

    /// <remarks/>
    public string UnitTime
    {
        get
        {
            return this.unitTimeField;
        }
        set
        {
            this.unitTimeField = value;
        }
    }

    /// <remarks/>
    public string TotalTime
    {
        get
        {
            return this.totalTimeField;
        }
        set
        {
            this.totalTimeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectSettingsEndSheetCalcSheet
{

    private object calcRowsField;

    private string displayColumnField;

    /// <remarks/>
    public object CalcRows
    {
        get
        {
            return this.calcRowsField;
        }
        set
        {
            this.calcRowsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DisplayColumn
    {
        get
        {
            return this.displayColumnField;
        }
        set
        {
            this.displayColumnField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectSettingsSumSheet
{

    private SigmaFileProjectSettingsSumSheetColumns columnsField;

    private bool categoriesShowAllField;

    private object resourceCategoriesField;

    private bool operationsShowAllField;

    private object resourceOperationsField;

    /// <remarks/>
    public SigmaFileProjectSettingsSumSheetColumns Columns
    {
        get
        {
            return this.columnsField;
        }
        set
        {
            this.columnsField = value;
        }
    }

    /// <remarks/>
    public bool CategoriesShowAll
    {
        get
        {
            return this.categoriesShowAllField;
        }
        set
        {
            this.categoriesShowAllField = value;
        }
    }

    /// <remarks/>
    public object ResourceCategories
    {
        get
        {
            return this.resourceCategoriesField;
        }
        set
        {
            this.resourceCategoriesField = value;
        }
    }

    /// <remarks/>
    public bool OperationsShowAll
    {
        get
        {
            return this.operationsShowAllField;
        }
        set
        {
            this.operationsShowAllField = value;
        }
    }

    /// <remarks/>
    public object ResourceOperations
    {
        get
        {
            return this.resourceOperationsField;
        }
        set
        {
            this.resourceOperationsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectSettingsSumSheetColumns
{

    private string positionField;

    private string damagePercentageSelectedField;

    private string numberField;

    private string nameField;

    private string noteMarkField;

    private string operationField;

    private string categoryField;

    private string unitField;

    private string quantityUnregulatedField;

    private string quantityRegulationField;

    private string amountMinField;

    private string amountTypField;

    private string amountMaxField;

    private string amountField;

    private string productionUnitField;

    private string productionRateField;

    private string currencyField;

    private string unitPriceMinField;

    private string unitPriceTypField;

    private string unitPriceMaxField;

    private string unitPriceField;

    private string productionUnitPriceField;

    private string costPriceField;

    private string itemPriceField;

    private string regCostPriceField;

    private string regulationField;

    private string compareUnitPriceField;

    private string compareSalesPriceField;

    private string stdSpreadField;

    private string prioritetField;

    private string nowValueFollowPercentageField;

    private string nowValuePercentageField;

    private string nowValueField;

    private string remainPercentageField;

    private string remainField;

    private string damageQuantityField;

    private string damagePercentageField;

    private string damageField;

    private string damageNowValueField;

    private string damageBaseField;

    private string damageBaseNowValueField;

    private string legalCostPercentageField;

    private string legalCostField;

    private string incomeField;

    private string discountContributionPercentageField;

    private string discountContributionAdjustmentField;

    private string flagsField;

    private string noteField;

    private string serviceUnitPriceField;

    private string serviceTotalPriceField;

    private string unitTimeField;

    private string totalTimeField;

    private string costPriceContribution1Field;

    private string costPriceContribution2Field;

    private string costPriceContribution3Field;

    private string costPriceWithContributionField;

    private string reallocatedIncomeField;

    private string unitSalesPriceField;

    private string salesPriceField;

    private string totalIncomeField;

    private string totalProfitMarginField;

    /// <remarks/>
    public string Position
    {
        get
        {
            return this.positionField;
        }
        set
        {
            this.positionField = value;
        }
    }

    /// <remarks/>
    public string DamagePercentageSelected
    {
        get
        {
            return this.damagePercentageSelectedField;
        }
        set
        {
            this.damagePercentageSelectedField = value;
        }
    }

    /// <remarks/>
    public string Number
    {
        get
        {
            return this.numberField;
        }
        set
        {
            this.numberField = value;
        }
    }

    /// <remarks/>
    public string Name
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
    public string NoteMark
    {
        get
        {
            return this.noteMarkField;
        }
        set
        {
            this.noteMarkField = value;
        }
    }

    /// <remarks/>
    public string Operation
    {
        get
        {
            return this.operationField;
        }
        set
        {
            this.operationField = value;
        }
    }

    /// <remarks/>
    public string Category
    {
        get
        {
            return this.categoryField;
        }
        set
        {
            this.categoryField = value;
        }
    }

    /// <remarks/>
    public string Unit
    {
        get
        {
            return this.unitField;
        }
        set
        {
            this.unitField = value;
        }
    }

    /// <remarks/>
    public string QuantityUnregulated
    {
        get
        {
            return this.quantityUnregulatedField;
        }
        set
        {
            this.quantityUnregulatedField = value;
        }
    }

    /// <remarks/>
    public string QuantityRegulation
    {
        get
        {
            return this.quantityRegulationField;
        }
        set
        {
            this.quantityRegulationField = value;
        }
    }

    /// <remarks/>
    public string AmountMin
    {
        get
        {
            return this.amountMinField;
        }
        set
        {
            this.amountMinField = value;
        }
    }

    /// <remarks/>
    public string AmountTyp
    {
        get
        {
            return this.amountTypField;
        }
        set
        {
            this.amountTypField = value;
        }
    }

    /// <remarks/>
    public string AmountMax
    {
        get
        {
            return this.amountMaxField;
        }
        set
        {
            this.amountMaxField = value;
        }
    }

    /// <remarks/>
    public string Amount
    {
        get
        {
            return this.amountField;
        }
        set
        {
            this.amountField = value;
        }
    }

    /// <remarks/>
    public string ProductionUnit
    {
        get
        {
            return this.productionUnitField;
        }
        set
        {
            this.productionUnitField = value;
        }
    }

    /// <remarks/>
    public string ProductionRate
    {
        get
        {
            return this.productionRateField;
        }
        set
        {
            this.productionRateField = value;
        }
    }

    /// <remarks/>
    public string Currency
    {
        get
        {
            return this.currencyField;
        }
        set
        {
            this.currencyField = value;
        }
    }

    /// <remarks/>
    public string UnitPriceMin
    {
        get
        {
            return this.unitPriceMinField;
        }
        set
        {
            this.unitPriceMinField = value;
        }
    }

    /// <remarks/>
    public string UnitPriceTyp
    {
        get
        {
            return this.unitPriceTypField;
        }
        set
        {
            this.unitPriceTypField = value;
        }
    }

    /// <remarks/>
    public string UnitPriceMax
    {
        get
        {
            return this.unitPriceMaxField;
        }
        set
        {
            this.unitPriceMaxField = value;
        }
    }

    /// <remarks/>
    public string UnitPrice
    {
        get
        {
            return this.unitPriceField;
        }
        set
        {
            this.unitPriceField = value;
        }
    }

    /// <remarks/>
    public string ProductionUnitPrice
    {
        get
        {
            return this.productionUnitPriceField;
        }
        set
        {
            this.productionUnitPriceField = value;
        }
    }

    /// <remarks/>
    public string CostPrice
    {
        get
        {
            return this.costPriceField;
        }
        set
        {
            this.costPriceField = value;
        }
    }

    /// <remarks/>
    public string ItemPrice
    {
        get
        {
            return this.itemPriceField;
        }
        set
        {
            this.itemPriceField = value;
        }
    }

    /// <remarks/>
    public string RegCostPrice
    {
        get
        {
            return this.regCostPriceField;
        }
        set
        {
            this.regCostPriceField = value;
        }
    }

    /// <remarks/>
    public string Regulation
    {
        get
        {
            return this.regulationField;
        }
        set
        {
            this.regulationField = value;
        }
    }

    /// <remarks/>
    public string CompareUnitPrice
    {
        get
        {
            return this.compareUnitPriceField;
        }
        set
        {
            this.compareUnitPriceField = value;
        }
    }

    /// <remarks/>
    public string CompareSalesPrice
    {
        get
        {
            return this.compareSalesPriceField;
        }
        set
        {
            this.compareSalesPriceField = value;
        }
    }

    /// <remarks/>
    public string StdSpread
    {
        get
        {
            return this.stdSpreadField;
        }
        set
        {
            this.stdSpreadField = value;
        }
    }

    /// <remarks/>
    public string Prioritet
    {
        get
        {
            return this.prioritetField;
        }
        set
        {
            this.prioritetField = value;
        }
    }

    /// <remarks/>
    public string NowValueFollowPercentage
    {
        get
        {
            return this.nowValueFollowPercentageField;
        }
        set
        {
            this.nowValueFollowPercentageField = value;
        }
    }

    /// <remarks/>
    public string NowValuePercentage
    {
        get
        {
            return this.nowValuePercentageField;
        }
        set
        {
            this.nowValuePercentageField = value;
        }
    }

    /// <remarks/>
    public string NowValue
    {
        get
        {
            return this.nowValueField;
        }
        set
        {
            this.nowValueField = value;
        }
    }

    /// <remarks/>
    public string RemainPercentage
    {
        get
        {
            return this.remainPercentageField;
        }
        set
        {
            this.remainPercentageField = value;
        }
    }

    /// <remarks/>
    public string Remain
    {
        get
        {
            return this.remainField;
        }
        set
        {
            this.remainField = value;
        }
    }

    /// <remarks/>
    public string DamageQuantity
    {
        get
        {
            return this.damageQuantityField;
        }
        set
        {
            this.damageQuantityField = value;
        }
    }

    /// <remarks/>
    public string DamagePercentage
    {
        get
        {
            return this.damagePercentageField;
        }
        set
        {
            this.damagePercentageField = value;
        }
    }

    /// <remarks/>
    public string Damage
    {
        get
        {
            return this.damageField;
        }
        set
        {
            this.damageField = value;
        }
    }

    /// <remarks/>
    public string DamageNowValue
    {
        get
        {
            return this.damageNowValueField;
        }
        set
        {
            this.damageNowValueField = value;
        }
    }

    /// <remarks/>
    public string DamageBase
    {
        get
        {
            return this.damageBaseField;
        }
        set
        {
            this.damageBaseField = value;
        }
    }

    /// <remarks/>
    public string DamageBaseNowValue
    {
        get
        {
            return this.damageBaseNowValueField;
        }
        set
        {
            this.damageBaseNowValueField = value;
        }
    }

    /// <remarks/>
    public string LegalCostPercentage
    {
        get
        {
            return this.legalCostPercentageField;
        }
        set
        {
            this.legalCostPercentageField = value;
        }
    }

    /// <remarks/>
    public string LegalCost
    {
        get
        {
            return this.legalCostField;
        }
        set
        {
            this.legalCostField = value;
        }
    }

    /// <remarks/>
    public string Income
    {
        get
        {
            return this.incomeField;
        }
        set
        {
            this.incomeField = value;
        }
    }

    /// <remarks/>
    public string DiscountContributionPercentage
    {
        get
        {
            return this.discountContributionPercentageField;
        }
        set
        {
            this.discountContributionPercentageField = value;
        }
    }

    /// <remarks/>
    public string DiscountContributionAdjustment
    {
        get
        {
            return this.discountContributionAdjustmentField;
        }
        set
        {
            this.discountContributionAdjustmentField = value;
        }
    }

    /// <remarks/>
    public string Flags
    {
        get
        {
            return this.flagsField;
        }
        set
        {
            this.flagsField = value;
        }
    }

    /// <remarks/>
    public string Note
    {
        get
        {
            return this.noteField;
        }
        set
        {
            this.noteField = value;
        }
    }

    /// <remarks/>
    public string ServiceUnitPrice
    {
        get
        {
            return this.serviceUnitPriceField;
        }
        set
        {
            this.serviceUnitPriceField = value;
        }
    }

    /// <remarks/>
    public string ServiceTotalPrice
    {
        get
        {
            return this.serviceTotalPriceField;
        }
        set
        {
            this.serviceTotalPriceField = value;
        }
    }

    /// <remarks/>
    public string UnitTime
    {
        get
        {
            return this.unitTimeField;
        }
        set
        {
            this.unitTimeField = value;
        }
    }

    /// <remarks/>
    public string TotalTime
    {
        get
        {
            return this.totalTimeField;
        }
        set
        {
            this.totalTimeField = value;
        }
    }

    /// <remarks/>
    public string CostPriceContribution1
    {
        get
        {
            return this.costPriceContribution1Field;
        }
        set
        {
            this.costPriceContribution1Field = value;
        }
    }

    /// <remarks/>
    public string CostPriceContribution2
    {
        get
        {
            return this.costPriceContribution2Field;
        }
        set
        {
            this.costPriceContribution2Field = value;
        }
    }

    /// <remarks/>
    public string CostPriceContribution3
    {
        get
        {
            return this.costPriceContribution3Field;
        }
        set
        {
            this.costPriceContribution3Field = value;
        }
    }

    /// <remarks/>
    public string CostPriceWithContribution
    {
        get
        {
            return this.costPriceWithContributionField;
        }
        set
        {
            this.costPriceWithContributionField = value;
        }
    }

    /// <remarks/>
    public string ReallocatedIncome
    {
        get
        {
            return this.reallocatedIncomeField;
        }
        set
        {
            this.reallocatedIncomeField = value;
        }
    }

    /// <remarks/>
    public string UnitSalesPrice
    {
        get
        {
            return this.unitSalesPriceField;
        }
        set
        {
            this.unitSalesPriceField = value;
        }
    }

    /// <remarks/>
    public string SalesPrice
    {
        get
        {
            return this.salesPriceField;
        }
        set
        {
            this.salesPriceField = value;
        }
    }

    /// <remarks/>
    public string TotalIncome
    {
        get
        {
            return this.totalIncomeField;
        }
        set
        {
            this.totalIncomeField = value;
        }
    }

    /// <remarks/>
    public string TotalProfitMargin
    {
        get
        {
            return this.totalProfitMarginField;
        }
        set
        {
            this.totalProfitMarginField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectSettingsActivitiesSheet
{

    private SigmaFileProjectSettingsActivitiesSheetColumns columnsField;

    /// <remarks/>
    public SigmaFileProjectSettingsActivitiesSheetColumns Columns
    {
        get
        {
            return this.columnsField;
        }
        set
        {
            this.columnsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectSettingsActivitiesSheetColumns
{

    private string numberField;

    private string nameField;

    private string operationField;

    private string categoryField;

    private string unitField;

    private string noteField;

    private string quantityUnregulatedField;

    private string quantityRegulationField;

    private string amountField;

    private string itemPriceField;

    private string regCostPriceField;

    private string compareUnitPriceField;

    private string compareSalesPriceField;

    private string positionField;

    private string productionRateField;

    private string productionUnitField;

    private string productionUnitPriceField;

    private string costPriceContribution1Field;

    private string costPriceContribution2Field;

    private string costPriceContribution3Field;

    private string costPriceContribution4Field;

    private string costPriceContribution5Field;

    private string costPriceWithContributionField;

    private string salesPriceContribution1Field;

    private string salesPriceContribution2Field;

    private string salesPriceContribution3Field;

    private string salesPriceContribution4Field;

    private string salesPriceContribution5Field;

    private string unitSalesPriceField;

    private string salesPriceField;

    private string totalIncomeField;

    private string totalProfitMarginField;

    private string reallocatedIncomeField;

    private string salesPriceBeforeDiscountField;

    private string discountContribution1Field;

    private string discountContribution2Field;

    private string discountContribution3Field;

    private string discountContribution4Field;

    private string discountContribution5Field;

    private string discountContributionAdjustmentField;

    private string totalDiscountAmountField;

    /// <remarks/>
    public string Number
    {
        get
        {
            return this.numberField;
        }
        set
        {
            this.numberField = value;
        }
    }

    /// <remarks/>
    public string Name
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
    public string Operation
    {
        get
        {
            return this.operationField;
        }
        set
        {
            this.operationField = value;
        }
    }

    /// <remarks/>
    public string Category
    {
        get
        {
            return this.categoryField;
        }
        set
        {
            this.categoryField = value;
        }
    }

    /// <remarks/>
    public string Unit
    {
        get
        {
            return this.unitField;
        }
        set
        {
            this.unitField = value;
        }
    }

    /// <remarks/>
    public string Note
    {
        get
        {
            return this.noteField;
        }
        set
        {
            this.noteField = value;
        }
    }

    /// <remarks/>
    public string QuantityUnregulated
    {
        get
        {
            return this.quantityUnregulatedField;
        }
        set
        {
            this.quantityUnregulatedField = value;
        }
    }

    /// <remarks/>
    public string QuantityRegulation
    {
        get
        {
            return this.quantityRegulationField;
        }
        set
        {
            this.quantityRegulationField = value;
        }
    }

    /// <remarks/>
    public string Amount
    {
        get
        {
            return this.amountField;
        }
        set
        {
            this.amountField = value;
        }
    }

    /// <remarks/>
    public string ItemPrice
    {
        get
        {
            return this.itemPriceField;
        }
        set
        {
            this.itemPriceField = value;
        }
    }

    /// <remarks/>
    public string RegCostPrice
    {
        get
        {
            return this.regCostPriceField;
        }
        set
        {
            this.regCostPriceField = value;
        }
    }

    /// <remarks/>
    public string CompareUnitPrice
    {
        get
        {
            return this.compareUnitPriceField;
        }
        set
        {
            this.compareUnitPriceField = value;
        }
    }

    /// <remarks/>
    public string CompareSalesPrice
    {
        get
        {
            return this.compareSalesPriceField;
        }
        set
        {
            this.compareSalesPriceField = value;
        }
    }

    /// <remarks/>
    public string Position
    {
        get
        {
            return this.positionField;
        }
        set
        {
            this.positionField = value;
        }
    }

    /// <remarks/>
    public string ProductionRate
    {
        get
        {
            return this.productionRateField;
        }
        set
        {
            this.productionRateField = value;
        }
    }

    /// <remarks/>
    public string ProductionUnit
    {
        get
        {
            return this.productionUnitField;
        }
        set
        {
            this.productionUnitField = value;
        }
    }

    /// <remarks/>
    public string ProductionUnitPrice
    {
        get
        {
            return this.productionUnitPriceField;
        }
        set
        {
            this.productionUnitPriceField = value;
        }
    }

    /// <remarks/>
    public string CostPriceContribution1
    {
        get
        {
            return this.costPriceContribution1Field;
        }
        set
        {
            this.costPriceContribution1Field = value;
        }
    }

    /// <remarks/>
    public string CostPriceContribution2
    {
        get
        {
            return this.costPriceContribution2Field;
        }
        set
        {
            this.costPriceContribution2Field = value;
        }
    }

    /// <remarks/>
    public string CostPriceContribution3
    {
        get
        {
            return this.costPriceContribution3Field;
        }
        set
        {
            this.costPriceContribution3Field = value;
        }
    }

    /// <remarks/>
    public string CostPriceContribution4
    {
        get
        {
            return this.costPriceContribution4Field;
        }
        set
        {
            this.costPriceContribution4Field = value;
        }
    }

    /// <remarks/>
    public string CostPriceContribution5
    {
        get
        {
            return this.costPriceContribution5Field;
        }
        set
        {
            this.costPriceContribution5Field = value;
        }
    }

    /// <remarks/>
    public string CostPriceWithContribution
    {
        get
        {
            return this.costPriceWithContributionField;
        }
        set
        {
            this.costPriceWithContributionField = value;
        }
    }

    /// <remarks/>
    public string SalesPriceContribution1
    {
        get
        {
            return this.salesPriceContribution1Field;
        }
        set
        {
            this.salesPriceContribution1Field = value;
        }
    }

    /// <remarks/>
    public string SalesPriceContribution2
    {
        get
        {
            return this.salesPriceContribution2Field;
        }
        set
        {
            this.salesPriceContribution2Field = value;
        }
    }

    /// <remarks/>
    public string SalesPriceContribution3
    {
        get
        {
            return this.salesPriceContribution3Field;
        }
        set
        {
            this.salesPriceContribution3Field = value;
        }
    }

    /// <remarks/>
    public string SalesPriceContribution4
    {
        get
        {
            return this.salesPriceContribution4Field;
        }
        set
        {
            this.salesPriceContribution4Field = value;
        }
    }

    /// <remarks/>
    public string SalesPriceContribution5
    {
        get
        {
            return this.salesPriceContribution5Field;
        }
        set
        {
            this.salesPriceContribution5Field = value;
        }
    }

    /// <remarks/>
    public string UnitSalesPrice
    {
        get
        {
            return this.unitSalesPriceField;
        }
        set
        {
            this.unitSalesPriceField = value;
        }
    }

    /// <remarks/>
    public string SalesPrice
    {
        get
        {
            return this.salesPriceField;
        }
        set
        {
            this.salesPriceField = value;
        }
    }

    /// <remarks/>
    public string TotalIncome
    {
        get
        {
            return this.totalIncomeField;
        }
        set
        {
            this.totalIncomeField = value;
        }
    }

    /// <remarks/>
    public string TotalProfitMargin
    {
        get
        {
            return this.totalProfitMarginField;
        }
        set
        {
            this.totalProfitMarginField = value;
        }
    }

    /// <remarks/>
    public string ReallocatedIncome
    {
        get
        {
            return this.reallocatedIncomeField;
        }
        set
        {
            this.reallocatedIncomeField = value;
        }
    }

    /// <remarks/>
    public string SalesPriceBeforeDiscount
    {
        get
        {
            return this.salesPriceBeforeDiscountField;
        }
        set
        {
            this.salesPriceBeforeDiscountField = value;
        }
    }

    /// <remarks/>
    public string DiscountContribution1
    {
        get
        {
            return this.discountContribution1Field;
        }
        set
        {
            this.discountContribution1Field = value;
        }
    }

    /// <remarks/>
    public string DiscountContribution2
    {
        get
        {
            return this.discountContribution2Field;
        }
        set
        {
            this.discountContribution2Field = value;
        }
    }

    /// <remarks/>
    public string DiscountContribution3
    {
        get
        {
            return this.discountContribution3Field;
        }
        set
        {
            this.discountContribution3Field = value;
        }
    }

    /// <remarks/>
    public string DiscountContribution4
    {
        get
        {
            return this.discountContribution4Field;
        }
        set
        {
            this.discountContribution4Field = value;
        }
    }

    /// <remarks/>
    public string DiscountContribution5
    {
        get
        {
            return this.discountContribution5Field;
        }
        set
        {
            this.discountContribution5Field = value;
        }
    }

    /// <remarks/>
    public string DiscountContributionAdjustment
    {
        get
        {
            return this.discountContributionAdjustmentField;
        }
        set
        {
            this.discountContributionAdjustmentField = value;
        }
    }

    /// <remarks/>
    public string TotalDiscountAmount
    {
        get
        {
            return this.totalDiscountAmountField;
        }
        set
        {
            this.totalDiscountAmountField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectSettingsActivityView
{

    private string viewNameField;

    private SigmaFileProjectSettingsActivityViewViewSetup viewSetupField;

    /// <remarks/>
    public string ViewName
    {
        get
        {
            return this.viewNameField;
        }
        set
        {
            this.viewNameField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectSettingsActivityViewViewSetup ViewSetup
    {
        get
        {
            return this.viewSetupField;
        }
        set
        {
            this.viewSetupField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectSettingsActivityViewViewSetup
{

    private SigmaFileProjectSettingsActivityViewViewSetupRBSetup rBSetupField;

    private SigmaFileProjectSettingsActivityViewViewSetupInsightViewSetup insightViewSetupField;

    /// <remarks/>
    public SigmaFileProjectSettingsActivityViewViewSetupRBSetup RBSetup
    {
        get
        {
            return this.rBSetupField;
        }
        set
        {
            this.rBSetupField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectSettingsActivityViewViewSetupInsightViewSetup InsightViewSetup
    {
        get
        {
            return this.insightViewSetupField;
        }
        set
        {
            this.insightViewSetupField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectSettingsActivityViewViewSetupRBSetup
{

    private bool includeCustomFieldsField;

    private bool includeZeroQuantityComponentsField;

    private bool includeComponentsWithoutResourcesField;

    private bool sortedField;

    private string sortByFieldField;

    private string sortOrderField;

    private SigmaFileProjectSettingsActivityViewViewSetupRBSetupItem[] structureField;

    private SigmaFileProjectSettingsActivityViewViewSetupRBSetupColumns columnsField;

    private string expandToLevelField;

    private string remarksField;

    /// <remarks/>
    public bool IncludeCustomFields
    {
        get
        {
            return this.includeCustomFieldsField;
        }
        set
        {
            this.includeCustomFieldsField = value;
        }
    }

    /// <remarks/>
    public bool IncludeZeroQuantityComponents
    {
        get
        {
            return this.includeZeroQuantityComponentsField;
        }
        set
        {
            this.includeZeroQuantityComponentsField = value;
        }
    }

    /// <remarks/>
    public bool IncludeComponentsWithoutResources
    {
        get
        {
            return this.includeComponentsWithoutResourcesField;
        }
        set
        {
            this.includeComponentsWithoutResourcesField = value;
        }
    }

    /// <remarks/>
    public bool Sorted
    {
        get
        {
            return this.sortedField;
        }
        set
        {
            this.sortedField = value;
        }
    }

    /// <remarks/>
    public string SortByField
    {
        get
        {
            return this.sortByFieldField;
        }
        set
        {
            this.sortByFieldField = value;
        }
    }

    /// <remarks/>
    public string SortOrder
    {
        get
        {
            return this.sortOrderField;
        }
        set
        {
            this.sortOrderField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Item", IsNullable = false)]
    public SigmaFileProjectSettingsActivityViewViewSetupRBSetupItem[] Structure
    {
        get
        {
            return this.structureField;
        }
        set
        {
            this.structureField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectSettingsActivityViewViewSetupRBSetupColumns Columns
    {
        get
        {
            return this.columnsField;
        }
        set
        {
            this.columnsField = value;
        }
    }

    /// <remarks/>
    public string ExpandToLevel
    {
        get
        {
            return this.expandToLevelField;
        }
        set
        {
            this.expandToLevelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Remarks
    {
        get
        {
            return this.remarksField;
        }
        set
        {
            this.remarksField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectSettingsActivityViewViewSetupRBSetupItem
{

    private string itemTypeField;

    private string subItemTypeField;

    private string treeCompIndexField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ItemType
    {
        get
        {
            return this.itemTypeField;
        }
        set
        {
            this.itemTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SubItemType
    {
        get
        {
            return this.subItemTypeField;
        }
        set
        {
            this.subItemTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TreeCompIndex
    {
        get
        {
            return this.treeCompIndexField;
        }
        set
        {
            this.treeCompIndexField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectSettingsActivityViewViewSetupRBSetupColumns
{

    private string nameField;

    private string positionField;

    private string numberField;

    private string operationField;

    private string categoryField;

    private string unitField;

    private string noteField;

    private string quantityUnregulatedField;

    private string quantityRegulationField;

    private string amountField;

    private string productionRateField;

    private string productionUnitField;

    private string productionUnitPriceField;

    private string itemPriceField;

    private string regCostPriceField;

    private string compareUnitPriceField;

    private string compareSalesPriceField;

    private string costPriceContribution1Field;

    private string costPriceContribution2Field;

    private string costPriceContribution3Field;

    private string costPriceContribution4Field;

    private string costPriceContribution5Field;

    private string costPriceWithContributionField;

    private string salesPriceContribution1Field;

    private string salesPriceContribution2Field;

    private string salesPriceContribution3Field;

    private string salesPriceContribution4Field;

    private string salesPriceContribution5Field;

    private string reallocatedIncomeField;

    private string salesPriceBeforeDiscountField;

    private string discountContribution1Field;

    private string discountContribution2Field;

    private string discountContribution3Field;

    private string discountContribution4Field;

    private string discountContribution5Field;

    private string discountContributionAdjustmentField;

    private string totalDiscountAmountField;

    private string unitSalesPriceField;

    private string salesPriceField;

    private string totalIncomeField;

    private string totalProfitMarginField;

    /// <remarks/>
    public string Name
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
    public string Position
    {
        get
        {
            return this.positionField;
        }
        set
        {
            this.positionField = value;
        }
    }

    /// <remarks/>
    public string Number
    {
        get
        {
            return this.numberField;
        }
        set
        {
            this.numberField = value;
        }
    }

    /// <remarks/>
    public string Operation
    {
        get
        {
            return this.operationField;
        }
        set
        {
            this.operationField = value;
        }
    }

    /// <remarks/>
    public string Category
    {
        get
        {
            return this.categoryField;
        }
        set
        {
            this.categoryField = value;
        }
    }

    /// <remarks/>
    public string Unit
    {
        get
        {
            return this.unitField;
        }
        set
        {
            this.unitField = value;
        }
    }

    /// <remarks/>
    public string Note
    {
        get
        {
            return this.noteField;
        }
        set
        {
            this.noteField = value;
        }
    }

    /// <remarks/>
    public string QuantityUnregulated
    {
        get
        {
            return this.quantityUnregulatedField;
        }
        set
        {
            this.quantityUnregulatedField = value;
        }
    }

    /// <remarks/>
    public string QuantityRegulation
    {
        get
        {
            return this.quantityRegulationField;
        }
        set
        {
            this.quantityRegulationField = value;
        }
    }

    /// <remarks/>
    public string Amount
    {
        get
        {
            return this.amountField;
        }
        set
        {
            this.amountField = value;
        }
    }

    /// <remarks/>
    public string ProductionRate
    {
        get
        {
            return this.productionRateField;
        }
        set
        {
            this.productionRateField = value;
        }
    }

    /// <remarks/>
    public string ProductionUnit
    {
        get
        {
            return this.productionUnitField;
        }
        set
        {
            this.productionUnitField = value;
        }
    }

    /// <remarks/>
    public string ProductionUnitPrice
    {
        get
        {
            return this.productionUnitPriceField;
        }
        set
        {
            this.productionUnitPriceField = value;
        }
    }

    /// <remarks/>
    public string ItemPrice
    {
        get
        {
            return this.itemPriceField;
        }
        set
        {
            this.itemPriceField = value;
        }
    }

    /// <remarks/>
    public string RegCostPrice
    {
        get
        {
            return this.regCostPriceField;
        }
        set
        {
            this.regCostPriceField = value;
        }
    }

    /// <remarks/>
    public string CompareUnitPrice
    {
        get
        {
            return this.compareUnitPriceField;
        }
        set
        {
            this.compareUnitPriceField = value;
        }
    }

    /// <remarks/>
    public string CompareSalesPrice
    {
        get
        {
            return this.compareSalesPriceField;
        }
        set
        {
            this.compareSalesPriceField = value;
        }
    }

    /// <remarks/>
    public string CostPriceContribution1
    {
        get
        {
            return this.costPriceContribution1Field;
        }
        set
        {
            this.costPriceContribution1Field = value;
        }
    }

    /// <remarks/>
    public string CostPriceContribution2
    {
        get
        {
            return this.costPriceContribution2Field;
        }
        set
        {
            this.costPriceContribution2Field = value;
        }
    }

    /// <remarks/>
    public string CostPriceContribution3
    {
        get
        {
            return this.costPriceContribution3Field;
        }
        set
        {
            this.costPriceContribution3Field = value;
        }
    }

    /// <remarks/>
    public string CostPriceContribution4
    {
        get
        {
            return this.costPriceContribution4Field;
        }
        set
        {
            this.costPriceContribution4Field = value;
        }
    }

    /// <remarks/>
    public string CostPriceContribution5
    {
        get
        {
            return this.costPriceContribution5Field;
        }
        set
        {
            this.costPriceContribution5Field = value;
        }
    }

    /// <remarks/>
    public string CostPriceWithContribution
    {
        get
        {
            return this.costPriceWithContributionField;
        }
        set
        {
            this.costPriceWithContributionField = value;
        }
    }

    /// <remarks/>
    public string SalesPriceContribution1
    {
        get
        {
            return this.salesPriceContribution1Field;
        }
        set
        {
            this.salesPriceContribution1Field = value;
        }
    }

    /// <remarks/>
    public string SalesPriceContribution2
    {
        get
        {
            return this.salesPriceContribution2Field;
        }
        set
        {
            this.salesPriceContribution2Field = value;
        }
    }

    /// <remarks/>
    public string SalesPriceContribution3
    {
        get
        {
            return this.salesPriceContribution3Field;
        }
        set
        {
            this.salesPriceContribution3Field = value;
        }
    }

    /// <remarks/>
    public string SalesPriceContribution4
    {
        get
        {
            return this.salesPriceContribution4Field;
        }
        set
        {
            this.salesPriceContribution4Field = value;
        }
    }

    /// <remarks/>
    public string SalesPriceContribution5
    {
        get
        {
            return this.salesPriceContribution5Field;
        }
        set
        {
            this.salesPriceContribution5Field = value;
        }
    }

    /// <remarks/>
    public string ReallocatedIncome
    {
        get
        {
            return this.reallocatedIncomeField;
        }
        set
        {
            this.reallocatedIncomeField = value;
        }
    }

    /// <remarks/>
    public string SalesPriceBeforeDiscount
    {
        get
        {
            return this.salesPriceBeforeDiscountField;
        }
        set
        {
            this.salesPriceBeforeDiscountField = value;
        }
    }

    /// <remarks/>
    public string DiscountContribution1
    {
        get
        {
            return this.discountContribution1Field;
        }
        set
        {
            this.discountContribution1Field = value;
        }
    }

    /// <remarks/>
    public string DiscountContribution2
    {
        get
        {
            return this.discountContribution2Field;
        }
        set
        {
            this.discountContribution2Field = value;
        }
    }

    /// <remarks/>
    public string DiscountContribution3
    {
        get
        {
            return this.discountContribution3Field;
        }
        set
        {
            this.discountContribution3Field = value;
        }
    }

    /// <remarks/>
    public string DiscountContribution4
    {
        get
        {
            return this.discountContribution4Field;
        }
        set
        {
            this.discountContribution4Field = value;
        }
    }

    /// <remarks/>
    public string DiscountContribution5
    {
        get
        {
            return this.discountContribution5Field;
        }
        set
        {
            this.discountContribution5Field = value;
        }
    }

    /// <remarks/>
    public string DiscountContributionAdjustment
    {
        get
        {
            return this.discountContributionAdjustmentField;
        }
        set
        {
            this.discountContributionAdjustmentField = value;
        }
    }

    /// <remarks/>
    public string TotalDiscountAmount
    {
        get
        {
            return this.totalDiscountAmountField;
        }
        set
        {
            this.totalDiscountAmountField = value;
        }
    }

    /// <remarks/>
    public string UnitSalesPrice
    {
        get
        {
            return this.unitSalesPriceField;
        }
        set
        {
            this.unitSalesPriceField = value;
        }
    }

    /// <remarks/>
    public string SalesPrice
    {
        get
        {
            return this.salesPriceField;
        }
        set
        {
            this.salesPriceField = value;
        }
    }

    /// <remarks/>
    public string TotalIncome
    {
        get
        {
            return this.totalIncomeField;
        }
        set
        {
            this.totalIncomeField = value;
        }
    }

    /// <remarks/>
    public string TotalProfitMargin
    {
        get
        {
            return this.totalProfitMarginField;
        }
        set
        {
            this.totalProfitMarginField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectSettingsActivityViewViewSetupInsightViewSetup
{

    private SigmaFileProjectSettingsActivityViewViewSetupInsightViewSetupInsightViewItem[] insightViewItemsField;

    private string expandToLevelField;

    private string roundingNoOfLevelsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("InsightViewItem", IsNullable = false)]
    public SigmaFileProjectSettingsActivityViewViewSetupInsightViewSetupInsightViewItem[] InsightViewItems
    {
        get
        {
            return this.insightViewItemsField;
        }
        set
        {
            this.insightViewItemsField = value;
        }
    }

    /// <remarks/>
    public string ExpandToLevel
    {
        get
        {
            return this.expandToLevelField;
        }
        set
        {
            this.expandToLevelField = value;
        }
    }

    /// <remarks/>
    public string RoundingNoOfLevels
    {
        get
        {
            return this.roundingNoOfLevelsField;
        }
        set
        {
            this.roundingNoOfLevelsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectSettingsActivityViewViewSetupInsightViewSetupInsightViewItem
{

    private string sortByFieldField;

    private string sortOrderField;

    private object filtersField;

    private bool includeZeroQuantityComponentsField;

    private bool includeComponentsWithoutResourcesField;

    private SigmaFileProjectSettingsActivityViewViewSetupInsightViewSetupInsightViewItemColumn[] columnsField;

    private string itemTypeField;

    private string subItemTypeField;

    private string treeCompIndexField;

    /// <remarks/>
    public string SortByField
    {
        get
        {
            return this.sortByFieldField;
        }
        set
        {
            this.sortByFieldField = value;
        }
    }

    /// <remarks/>
    public string SortOrder
    {
        get
        {
            return this.sortOrderField;
        }
        set
        {
            this.sortOrderField = value;
        }
    }

    /// <remarks/>
    public object Filters
    {
        get
        {
            return this.filtersField;
        }
        set
        {
            this.filtersField = value;
        }
    }

    /// <remarks/>
    public bool IncludeZeroQuantityComponents
    {
        get
        {
            return this.includeZeroQuantityComponentsField;
        }
        set
        {
            this.includeZeroQuantityComponentsField = value;
        }
    }

    /// <remarks/>
    public bool IncludeComponentsWithoutResources
    {
        get
        {
            return this.includeComponentsWithoutResourcesField;
        }
        set
        {
            this.includeComponentsWithoutResourcesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Column", IsNullable = false)]
    public SigmaFileProjectSettingsActivityViewViewSetupInsightViewSetupInsightViewItemColumn[] Columns
    {
        get
        {
            return this.columnsField;
        }
        set
        {
            this.columnsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ItemType
    {
        get
        {
            return this.itemTypeField;
        }
        set
        {
            this.itemTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SubItemType
    {
        get
        {
            return this.subItemTypeField;
        }
        set
        {
            this.subItemTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TreeCompIndex
    {
        get
        {
            return this.treeCompIndexField;
        }
        set
        {
            this.treeCompIndexField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectSettingsActivityViewViewSetupInsightViewSetupInsightViewItemColumn
{

    private string treeCompIndexField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TreeCompIndex
    {
        get
        {
            return this.treeCompIndexField;
        }
        set
        {
            this.treeCompIndexField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectSettingsCalcSheet
{

    private SigmaFileProjectSettingsCalcSheetItem[] calcRowsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Item", IsNullable = false)]
    public SigmaFileProjectSettingsCalcSheetItem[] CalcRows
    {
        get
        {
            return this.calcRowsField;
        }
        set
        {
            this.calcRowsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectSettingsCalcSheetItem
{

    private string nameField;

    private string indexField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Index
    {
        get
        {
            return this.indexField;
        }
        set
        {
            this.indexField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectData
{

    private object variablesField;

    private SigmaFileProjectDataValueFormating valueFormatingField;

    private SigmaFileProjectDataProjectInfo projectInfoField;

    private SigmaFileProjectDataRounding roundingField;

    private string dBTypeField;

    private SigmaFileProjectDataItem[] constantsField;

    private SigmaFileProjectDataReportModule reportModuleField;

    private SigmaFileProjectDataTopPercentageModule topPercentageModuleField;

    private SigmaFileProjectDataRessourceDBValues ressourceDBValuesField;

    private SigmaFileProjectDataEndSheetContributions endSheetContributionsField;

    private SigmaFileProjectDataRedistributeModule redistributeModuleField;

    private SigmaFileProjectDataCurrency currencyField;

    private object pictureListModuleField;

    private SigmaFileProjectDataCustomFieldDefinition[] customFieldDefinitionsField;

    private SigmaFileProjectDataInternalLists internalListsField;

    private SigmaFileProjectDataComponentData componentDataField;

    private object externalDataSourcesField;

    /// <remarks/>
    public object Variables
    {
        get
        {
            return this.variablesField;
        }
        set
        {
            this.variablesField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectDataValueFormating ValueFormating
    {
        get
        {
            return this.valueFormatingField;
        }
        set
        {
            this.valueFormatingField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectDataProjectInfo ProjectInfo
    {
        get
        {
            return this.projectInfoField;
        }
        set
        {
            this.projectInfoField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectDataRounding Rounding
    {
        get
        {
            return this.roundingField;
        }
        set
        {
            this.roundingField = value;
        }
    }

    /// <remarks/>
    public string DBType
    {
        get
        {
            return this.dBTypeField;
        }
        set
        {
            this.dBTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Item", IsNullable = false)]
    public SigmaFileProjectDataItem[] Constants
    {
        get
        {
            return this.constantsField;
        }
        set
        {
            this.constantsField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectDataReportModule ReportModule
    {
        get
        {
            return this.reportModuleField;
        }
        set
        {
            this.reportModuleField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectDataTopPercentageModule TopPercentageModule
    {
        get
        {
            return this.topPercentageModuleField;
        }
        set
        {
            this.topPercentageModuleField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectDataRessourceDBValues RessourceDBValues
    {
        get
        {
            return this.ressourceDBValuesField;
        }
        set
        {
            this.ressourceDBValuesField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectDataEndSheetContributions EndSheetContributions
    {
        get
        {
            return this.endSheetContributionsField;
        }
        set
        {
            this.endSheetContributionsField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectDataRedistributeModule RedistributeModule
    {
        get
        {
            return this.redistributeModuleField;
        }
        set
        {
            this.redistributeModuleField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectDataCurrency Currency
    {
        get
        {
            return this.currencyField;
        }
        set
        {
            this.currencyField = value;
        }
    }

    /// <remarks/>
    public object PictureListModule
    {
        get
        {
            return this.pictureListModuleField;
        }
        set
        {
            this.pictureListModuleField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("CustomFieldDefinition", IsNullable = false)]
    public SigmaFileProjectDataCustomFieldDefinition[] CustomFieldDefinitions
    {
        get
        {
            return this.customFieldDefinitionsField;
        }
        set
        {
            this.customFieldDefinitionsField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectDataInternalLists InternalLists
    {
        get
        {
            return this.internalListsField;
        }
        set
        {
            this.internalListsField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectDataComponentData ComponentData
    {
        get
        {
            return this.componentDataField;
        }
        set
        {
            this.componentDataField = value;
        }
    }

    /// <remarks/>
    public object ExternalDataSources
    {
        get
        {
            return this.externalDataSourcesField;
        }
        set
        {
            this.externalDataSourcesField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataValueFormating
{

    private string shownPercentageDecimalsField;

    private string shownQuantityDecimalsField;

    private string shownFloatDecimalsField;

    /// <remarks/>
    public string ShownPercentageDecimals
    {
        get
        {
            return this.shownPercentageDecimalsField;
        }
        set
        {
            this.shownPercentageDecimalsField = value;
        }
    }

    /// <remarks/>
    public string ShownQuantityDecimals
    {
        get
        {
            return this.shownQuantityDecimalsField;
        }
        set
        {
            this.shownQuantityDecimalsField = value;
        }
    }

    /// <remarks/>
    public string ShownFloatDecimals
    {
        get
        {
            return this.shownFloatDecimalsField;
        }
        set
        {
            this.shownFloatDecimalsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataProjectInfo
{

    private SigmaFileProjectDataProjectInfoProperties propertiesField;

    private SigmaFileProjectDataProjectInfoItem[] keyFiguresField;

    private string projectNameField;

    private string projectIdField;

    private object companyNameField;

    private string authorNameField;

    private object projectCommentField;

    private string templateFileNameField;

    private string projectFileNameField;

    private string vATField;

    private bool useVATField;

    private object customerNameField;

    private object customerNumberField;

    private object projectNumberField;

    private object sTARKOrderNumberField;

    private string languageField;

    private string calculationIndexField;

    private bool spellCheckLimitField;

    private string spellCheckLevelsField;

    private bool roundingEnabledField;

    private string roundingNoOfDigitsField;

    private string roundingNoOfLevelsField;

    private string roundingColumnField;

    private string roundingDiffField;

    private bool allowEditEndSheetField;

    private bool allowEditResourceGridField;

    /// <remarks/>
    public SigmaFileProjectDataProjectInfoProperties Properties
    {
        get
        {
            return this.propertiesField;
        }
        set
        {
            this.propertiesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Item", IsNullable = false)]
    public SigmaFileProjectDataProjectInfoItem[] KeyFigures
    {
        get
        {
            return this.keyFiguresField;
        }
        set
        {
            this.keyFiguresField = value;
        }
    }

    /// <remarks/>
    public string ProjectName
    {
        get
        {
            return this.projectNameField;
        }
        set
        {
            this.projectNameField = value;
        }
    }

    /// <remarks/>
    public string ProjectId
    {
        get
        {
            return this.projectIdField;
        }
        set
        {
            this.projectIdField = value;
        }
    }

    /// <remarks/>
    public object CompanyName
    {
        get
        {
            return this.companyNameField;
        }
        set
        {
            this.companyNameField = value;
        }
    }

    /// <remarks/>
    public string AuthorName
    {
        get
        {
            return this.authorNameField;
        }
        set
        {
            this.authorNameField = value;
        }
    }

    /// <remarks/>
    public object ProjectComment
    {
        get
        {
            return this.projectCommentField;
        }
        set
        {
            this.projectCommentField = value;
        }
    }

    /// <remarks/>
    public string TemplateFileName
    {
        get
        {
            return this.templateFileNameField;
        }
        set
        {
            this.templateFileNameField = value;
        }
    }

    /// <remarks/>
    public string ProjectFileName
    {
        get
        {
            return this.projectFileNameField;
        }
        set
        {
            this.projectFileNameField = value;
        }
    }

    /// <remarks/>
    public string VAT
    {
        get
        {
            return this.vATField;
        }
        set
        {
            this.vATField = value;
        }
    }

    /// <remarks/>
    public bool UseVAT
    {
        get
        {
            return this.useVATField;
        }
        set
        {
            this.useVATField = value;
        }
    }

    /// <remarks/>
    public object CustomerName
    {
        get
        {
            return this.customerNameField;
        }
        set
        {
            this.customerNameField = value;
        }
    }

    /// <remarks/>
    public object CustomerNumber
    {
        get
        {
            return this.customerNumberField;
        }
        set
        {
            this.customerNumberField = value;
        }
    }

    /// <remarks/>
    public object ProjectNumber
    {
        get
        {
            return this.projectNumberField;
        }
        set
        {
            this.projectNumberField = value;
        }
    }

    /// <remarks/>
    public object STARKOrderNumber
    {
        get
        {
            return this.sTARKOrderNumberField;
        }
        set
        {
            this.sTARKOrderNumberField = value;
        }
    }

    /// <remarks/>
    public string Language
    {
        get
        {
            return this.languageField;
        }
        set
        {
            this.languageField = value;
        }
    }

    /// <remarks/>
    public string CalculationIndex
    {
        get
        {
            return this.calculationIndexField;
        }
        set
        {
            this.calculationIndexField = value;
        }
    }

    /// <remarks/>
    public bool SpellCheckLimit
    {
        get
        {
            return this.spellCheckLimitField;
        }
        set
        {
            this.spellCheckLimitField = value;
        }
    }

    /// <remarks/>
    public string SpellCheckLevels
    {
        get
        {
            return this.spellCheckLevelsField;
        }
        set
        {
            this.spellCheckLevelsField = value;
        }
    }

    /// <remarks/>
    public bool RoundingEnabled
    {
        get
        {
            return this.roundingEnabledField;
        }
        set
        {
            this.roundingEnabledField = value;
        }
    }

    /// <remarks/>
    public string RoundingNoOfDigits
    {
        get
        {
            return this.roundingNoOfDigitsField;
        }
        set
        {
            this.roundingNoOfDigitsField = value;
        }
    }

    /// <remarks/>
    public string RoundingNoOfLevels
    {
        get
        {
            return this.roundingNoOfLevelsField;
        }
        set
        {
            this.roundingNoOfLevelsField = value;
        }
    }

    /// <remarks/>
    public string RoundingColumn
    {
        get
        {
            return this.roundingColumnField;
        }
        set
        {
            this.roundingColumnField = value;
        }
    }

    /// <remarks/>
    public string RoundingDiff
    {
        get
        {
            return this.roundingDiffField;
        }
        set
        {
            this.roundingDiffField = value;
        }
    }

    /// <remarks/>
    public bool AllowEditEndSheet
    {
        get
        {
            return this.allowEditEndSheetField;
        }
        set
        {
            this.allowEditEndSheetField = value;
        }
    }

    /// <remarks/>
    public bool AllowEditResourceGrid
    {
        get
        {
            return this.allowEditResourceGridField;
        }
        set
        {
            this.allowEditResourceGridField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataProjectInfoProperties
{

    private SigmaFileProjectDataProjectInfoPropertiesPropertySet propertySetField;

    /// <remarks/>
    public SigmaFileProjectDataProjectInfoPropertiesPropertySet PropertySet
    {
        get
        {
            return this.propertySetField;
        }
        set
        {
            this.propertySetField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataProjectInfoPropertiesPropertySet
{

    private string nameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataProjectInfoItem
{

    private string nameField;

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataRounding
{

    private string roundingNodeField;

    private string roundingValueField;

    /// <remarks/>
    public string RoundingNode
    {
        get
        {
            return this.roundingNodeField;
        }
        set
        {
            this.roundingNodeField = value;
        }
    }

    /// <remarks/>
    public string RoundingValue
    {
        get
        {
            return this.roundingValueField;
        }
        set
        {
            this.roundingValueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataItem
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataReportModule
{

    private object reportConstantsField;

    /// <remarks/>
    public object ReportConstants
    {
        get
        {
            return this.reportConstantsField;
        }
        set
        {
            this.reportConstantsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataTopPercentageModule
{

    private bool includeOtherField;

    private bool useSalesPriceField;

    private object percentageRowsField;

    /// <remarks/>
    public bool IncludeOther
    {
        get
        {
            return this.includeOtherField;
        }
        set
        {
            this.includeOtherField = value;
        }
    }

    /// <remarks/>
    public bool UseSalesPrice
    {
        get
        {
            return this.useSalesPriceField;
        }
        set
        {
            this.useSalesPriceField = value;
        }
    }

    /// <remarks/>
    public object PercentageRows
    {
        get
        {
            return this.percentageRowsField;
        }
        set
        {
            this.percentageRowsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataRessourceDBValues
{

    private SigmaFileProjectDataRessourceDBValuesResDBItem[] resDBItemField;

    private SigmaFileProjectDataRessourceDBValuesNoCatDBItem noCatDBItemField;

    private SigmaFileProjectDataRessourceDBValuesOtherCatDBItem otherCatDBItemField;

    private string heading1Field;

    private string heading2Field;

    private object heading3Field;

    private bool useCol1Field;

    private bool useCol2Field;

    private bool useCol3Field;

    private bool useResDBField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ResDBItem")]
    public SigmaFileProjectDataRessourceDBValuesResDBItem[] ResDBItem
    {
        get
        {
            return this.resDBItemField;
        }
        set
        {
            this.resDBItemField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectDataRessourceDBValuesNoCatDBItem NoCatDBItem
    {
        get
        {
            return this.noCatDBItemField;
        }
        set
        {
            this.noCatDBItemField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectDataRessourceDBValuesOtherCatDBItem OtherCatDBItem
    {
        get
        {
            return this.otherCatDBItemField;
        }
        set
        {
            this.otherCatDBItemField = value;
        }
    }

    /// <remarks/>
    public string Heading1
    {
        get
        {
            return this.heading1Field;
        }
        set
        {
            this.heading1Field = value;
        }
    }

    /// <remarks/>
    public string Heading2
    {
        get
        {
            return this.heading2Field;
        }
        set
        {
            this.heading2Field = value;
        }
    }

    /// <remarks/>
    public object Heading3
    {
        get
        {
            return this.heading3Field;
        }
        set
        {
            this.heading3Field = value;
        }
    }

    /// <remarks/>
    public bool UseCol1
    {
        get
        {
            return this.useCol1Field;
        }
        set
        {
            this.useCol1Field = value;
        }
    }

    /// <remarks/>
    public bool UseCol2
    {
        get
        {
            return this.useCol2Field;
        }
        set
        {
            this.useCol2Field = value;
        }
    }

    /// <remarks/>
    public bool UseCol3
    {
        get
        {
            return this.useCol3Field;
        }
        set
        {
            this.useCol3Field = value;
        }
    }

    /// <remarks/>
    public bool UseResDB
    {
        get
        {
            return this.useResDBField;
        }
        set
        {
            this.useResDBField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataRessourceDBValuesResDBItem
{

    private string nameField;

    private decimal dG1Field;

    private decimal dG2Field;

    private string dG3Field;

    /// <remarks/>
    public string Name
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
    public decimal DG1
    {
        get
        {
            return this.dG1Field;
        }
        set
        {
            this.dG1Field = value;
        }
    }

    /// <remarks/>
    public decimal DG2
    {
        get
        {
            return this.dG2Field;
        }
        set
        {
            this.dG2Field = value;
        }
    }

    /// <remarks/>
    public string DG3
    {
        get
        {
            return this.dG3Field;
        }
        set
        {
            this.dG3Field = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataRessourceDBValuesNoCatDBItem
{

    private string dG1Field;

    private decimal dG2Field;

    private string dG3Field;

    /// <remarks/>
    public string DG1
    {
        get
        {
            return this.dG1Field;
        }
        set
        {
            this.dG1Field = value;
        }
    }

    /// <remarks/>
    public decimal DG2
    {
        get
        {
            return this.dG2Field;
        }
        set
        {
            this.dG2Field = value;
        }
    }

    /// <remarks/>
    public string DG3
    {
        get
        {
            return this.dG3Field;
        }
        set
        {
            this.dG3Field = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataRessourceDBValuesOtherCatDBItem
{

    private string dG1Field;

    private decimal dG2Field;

    private string dG3Field;

    /// <remarks/>
    public string DG1
    {
        get
        {
            return this.dG1Field;
        }
        set
        {
            this.dG1Field = value;
        }
    }

    /// <remarks/>
    public decimal DG2
    {
        get
        {
            return this.dG2Field;
        }
        set
        {
            this.dG2Field = value;
        }
    }

    /// <remarks/>
    public string DG3
    {
        get
        {
            return this.dG3Field;
        }
        set
        {
            this.dG3Field = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataEndSheetContributions
{

    private bool enabledField;

    private SigmaFileProjectDataEndSheetContributionsCostPriceContributions costPriceContributionsField;

    private SigmaFileProjectDataEndSheetContributionsSalesPriceContributions salesPriceContributionsField;

    private SigmaFileProjectDataEndSheetContributionsDiscountContributions discountContributionsField;

    /// <remarks/>
    public bool Enabled
    {
        get
        {
            return this.enabledField;
        }
        set
        {
            this.enabledField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectDataEndSheetContributionsCostPriceContributions CostPriceContributions
    {
        get
        {
            return this.costPriceContributionsField;
        }
        set
        {
            this.costPriceContributionsField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectDataEndSheetContributionsSalesPriceContributions SalesPriceContributions
    {
        get
        {
            return this.salesPriceContributionsField;
        }
        set
        {
            this.salesPriceContributionsField = value;
        }
    }

    /// <remarks/>
    public SigmaFileProjectDataEndSheetContributionsDiscountContributions DiscountContributions
    {
        get
        {
            return this.discountContributionsField;
        }
        set
        {
            this.discountContributionsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataEndSheetContributionsCostPriceContributions
{

    private SigmaFileProjectDataEndSheetContributionsCostPriceContributionsDefinition[] definitionsField;

    private SigmaFileProjectDataEndSheetContributionsCostPriceContributionsValue[] valuesField;

    private bool enabledField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Definition", IsNullable = false)]
    public SigmaFileProjectDataEndSheetContributionsCostPriceContributionsDefinition[] Definitions
    {
        get
        {
            return this.definitionsField;
        }
        set
        {
            this.definitionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Value", IsNullable = false)]
    public SigmaFileProjectDataEndSheetContributionsCostPriceContributionsValue[] Values
    {
        get
        {
            return this.valuesField;
        }
        set
        {
            this.valuesField = value;
        }
    }

    /// <remarks/>
    public bool Enabled
    {
        get
        {
            return this.enabledField;
        }
        set
        {
            this.enabledField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataEndSheetContributionsCostPriceContributionsDefinition
{

    private string idField;

    private string nameField;

    private string relativeToField;

    private string defaultValueField;

    private object defaultValueFormulaField;

    /// <remarks/>
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    public string Name
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
    public string RelativeTo
    {
        get
        {
            return this.relativeToField;
        }
        set
        {
            this.relativeToField = value;
        }
    }

    /// <remarks/>
    public string DefaultValue
    {
        get
        {
            return this.defaultValueField;
        }
        set
        {
            this.defaultValueField = value;
        }
    }

    /// <remarks/>
    public object DefaultValueFormula
    {
        get
        {
            return this.defaultValueFormulaField;
        }
        set
        {
            this.defaultValueFormulaField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataEndSheetContributionsCostPriceContributionsValue
{

    private string categoryNameField;

    private string definitionIdField;

    private decimal valueField;

    private object valueFormulaField;

    /// <remarks/>
    public string CategoryName
    {
        get
        {
            return this.categoryNameField;
        }
        set
        {
            this.categoryNameField = value;
        }
    }

    /// <remarks/>
    public string DefinitionId
    {
        get
        {
            return this.definitionIdField;
        }
        set
        {
            this.definitionIdField = value;
        }
    }

    /// <remarks/>
    public decimal Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    public object ValueFormula
    {
        get
        {
            return this.valueFormulaField;
        }
        set
        {
            this.valueFormulaField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataEndSheetContributionsSalesPriceContributions
{

    private SigmaFileProjectDataEndSheetContributionsSalesPriceContributionsDefinitions definitionsField;

    private SigmaFileProjectDataEndSheetContributionsSalesPriceContributionsValue[] valuesField;

    private string baseValueField;

    private bool enabledField;

    /// <remarks/>
    public SigmaFileProjectDataEndSheetContributionsSalesPriceContributionsDefinitions Definitions
    {
        get
        {
            return this.definitionsField;
        }
        set
        {
            this.definitionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Value", IsNullable = false)]
    public SigmaFileProjectDataEndSheetContributionsSalesPriceContributionsValue[] Values
    {
        get
        {
            return this.valuesField;
        }
        set
        {
            this.valuesField = value;
        }
    }

    /// <remarks/>
    public string BaseValue
    {
        get
        {
            return this.baseValueField;
        }
        set
        {
            this.baseValueField = value;
        }
    }

    /// <remarks/>
    public bool Enabled
    {
        get
        {
            return this.enabledField;
        }
        set
        {
            this.enabledField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataEndSheetContributionsSalesPriceContributionsDefinitions
{

    private SigmaFileProjectDataEndSheetContributionsSalesPriceContributionsDefinitionsDefinition definitionField;

    /// <remarks/>
    public SigmaFileProjectDataEndSheetContributionsSalesPriceContributionsDefinitionsDefinition Definition
    {
        get
        {
            return this.definitionField;
        }
        set
        {
            this.definitionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataEndSheetContributionsSalesPriceContributionsDefinitionsDefinition
{

    private string idField;

    private string nameField;

    private string relativeToField;

    private string defaultValueField;

    private object defaultValueFormulaField;

    /// <remarks/>
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    public string Name
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
    public string RelativeTo
    {
        get
        {
            return this.relativeToField;
        }
        set
        {
            this.relativeToField = value;
        }
    }

    /// <remarks/>
    public string DefaultValue
    {
        get
        {
            return this.defaultValueField;
        }
        set
        {
            this.defaultValueField = value;
        }
    }

    /// <remarks/>
    public object DefaultValueFormula
    {
        get
        {
            return this.defaultValueFormulaField;
        }
        set
        {
            this.defaultValueFormulaField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataEndSheetContributionsSalesPriceContributionsValue
{

    private string categoryNameField;

    private string definitionIdField;

    private decimal valueField;

    private object valueFormulaField;

    /// <remarks/>
    public string CategoryName
    {
        get
        {
            return this.categoryNameField;
        }
        set
        {
            this.categoryNameField = value;
        }
    }

    /// <remarks/>
    public string DefinitionId
    {
        get
        {
            return this.definitionIdField;
        }
        set
        {
            this.definitionIdField = value;
        }
    }

    /// <remarks/>
    public decimal Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    public object ValueFormula
    {
        get
        {
            return this.valueFormulaField;
        }
        set
        {
            this.valueFormulaField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataEndSheetContributionsDiscountContributions
{

    private object definitionsField;

    private object valuesField;

    private bool enabledField;

    /// <remarks/>
    public object Definitions
    {
        get
        {
            return this.definitionsField;
        }
        set
        {
            this.definitionsField = value;
        }
    }

    /// <remarks/>
    public object Values
    {
        get
        {
            return this.valuesField;
        }
        set
        {
            this.valuesField = value;
        }
    }

    /// <remarks/>
    public bool Enabled
    {
        get
        {
            return this.enabledField;
        }
        set
        {
            this.enabledField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataRedistributeModule
{

    private bool useRedistributeField;

    /// <remarks/>
    public bool UseRedistribute
    {
        get
        {
            return this.useRedistributeField;
        }
        set
        {
            this.useRedistributeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataCurrency
{

    private SigmaFileProjectDataCurrencyDefaultKey defaultKeyField;

    /// <remarks/>
    public SigmaFileProjectDataCurrencyDefaultKey DefaultKey
    {
        get
        {
            return this.defaultKeyField;
        }
        set
        {
            this.defaultKeyField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataCurrencyDefaultKey
{

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataCustomFieldDefinition
{

    private string idField;

    private string displayNameField;

    private string descriptionField;

    private bool requiredField;

    private bool inheritedFromParentField;

    private bool allowFreeTextField;

    private string fieldTypeField;

    private string listField;

    private string addConventionField;

    private bool addConventionFieldSpecified;

    private string externalNameField;

    private string delimiterField;

    /// <remarks/>
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    public string DisplayName
    {
        get
        {
            return this.displayNameField;
        }
        set
        {
            this.displayNameField = value;
        }
    }

    /// <remarks/>
    public string Description
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
    public bool Required
    {
        get
        {
            return this.requiredField;
        }
        set
        {
            this.requiredField = value;
        }
    }

    /// <remarks/>
    public bool InheritedFromParent
    {
        get
        {
            return this.inheritedFromParentField;
        }
        set
        {
            this.inheritedFromParentField = value;
        }
    }

    /// <remarks/>
    public bool AllowFreeText
    {
        get
        {
            return this.allowFreeTextField;
        }
        set
        {
            this.allowFreeTextField = value;
        }
    }

    /// <remarks/>
    public string FieldType
    {
        get
        {
            return this.fieldTypeField;
        }
        set
        {
            this.fieldTypeField = value;
        }
    }

    /// <remarks/>
    public string List
    {
        get
        {
            return this.listField;
        }
        set
        {
            this.listField = value;
        }
    }

    /// <remarks/>
    public string AddConvention
    {
        get
        {
            return this.addConventionField;
        }
        set
        {
            this.addConventionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AddConventionSpecified
    {
        get
        {
            return this.addConventionFieldSpecified;
        }
        set
        {
            this.addConventionFieldSpecified = value;
        }
    }

    /// <remarks/>
    public string ExternalName
    {
        get
        {
            return this.externalNameField;
        }
        set
        {
            this.externalNameField = value;
        }
    }

    /// <remarks/>
    public string Delimiter
    {
        get
        {
            return this.delimiterField;
        }
        set
        {
            this.delimiterField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataInternalLists
{

    private SigmaFileProjectDataInternalListsInternalList internalListField;

    /// <remarks/>
    public SigmaFileProjectDataInternalListsInternalList InternalList
    {
        get
        {
            return this.internalListField;
        }
        set
        {
            this.internalListField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataInternalListsInternalList
{

    private string idField;

    private string addConventionField;

    /// <remarks/>
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    public string AddConvention
    {
        get
        {
            return this.addConventionField;
        }
        set
        {
            this.addConventionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SigmaFileProjectDataComponentData
{

    private Component[] componentField;

    /// <remarks/>
    public Component[] Component
    {
        get
        {
            return this.componentField;
        }
        set
        {
            this.componentField = value;
        }
    }
}

// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class Component
{

    private string levelField;

    private string numberField;

    private string damagePercentageSelectedField;

    private string nameField;

    private object operationField;

    private object categoryField;

    private string unitField;

    private object noteField;

    private object noteMarkField;

    private string quantityUnregulatedField;

    private string quantityRegulationField;

    private string amountField;

    private string amountMinField;

    private string amountTypField;

    private string amountMaxField;

    private string unitPriceField;

    private string unitPriceMinField;

    private string unitPriceTypField;

    private string unitPriceMaxField;

    private string costPriceField;

    private string itemPriceField;

    private string regCostPriceField;

    private string regulationField;

    private string incomeField;

    private string salesPriceContributionAdjustmentField;

    private string unitIncomeField;

    private string unitSalesPriceContributionAdjustmentField;

    private string stdSpreadField;

    private string prioritetField;

    private string remainField;

    private string remainPercentageField;

    private string nowValueField;

    private string nowValuePercentageField;

    private string legalCostField;

    private string legalCostPercentageField;

    private object currencyField;

    private string compareUnitPriceField;

    private string compareSalesPriceField;

    private string positionField;

    private object flagsField;

    private string productionRateField;

    private object productionUnitField;

    private string productionUnitPriceField;

    private object keyWordsField;

    private string damageField;

    private string damagePercentageField;

    private string damageQuantityField;

    private string nowValueFollowPercentageField;

    private string damageNowValueField;

    private string damageBaseField;

    private string damageBaseNowValueField;

    private string serviceUnitPriceField;

    private string serviceTotalPriceField;

    private string unitTimeField;

    private string totalTimeField;

    private string costPriceContribution1Field;

    private string costPriceContribution2Field;

    private string costPriceContribution3Field;

    private string costPriceContribution4Field;

    private string costPriceContribution5Field;

    private string costPriceWithContributionField;

    private string salesPriceContribution1Field;

    private string salesPriceContribution2Field;

    private string salesPriceContribution3Field;

    private string salesPriceContribution4Field;

    private string salesPriceContribution5Field;

    private string unitSalesPriceField;

    private string salesPriceField;

    private string totalIncomeField;

    private string totalProfitMarginField;

    private string reallocatedIncomeField;

    private string roundingField;

    private string salesPriceBeforeDiscountField;

    private string discountContribution1Field;

    private string discountContribution2Field;

    private string discountContribution3Field;

    private string discountContribution4Field;

    private string discountContribution5Field;

    private string discountContributionPercentageField;

    private string discountContributionAdjustmentField;

    private string totalDiscountPercentageField;

    private string totalDiscountAmountField;

    private string profitField;

    private bool disabledField;

    private string unregulatedQuantityFactorField;

    private string quantityFactorField;

    private string priceFactorField;

    private ComponentComponentView componentViewField;

    private ComponentReAllocateInfo reAllocateInfoField;

    private ComponentPricePerCategoryCollection pricePerCategoryCollectionField;

    private ComponentReadOnly readOnlyField;

    private string idField;

    private Component[] componentField;

    private string name1Field;

    /// <remarks/>
    public string Level
    {
        get
        {
            return this.levelField;
        }
        set
        {
            this.levelField = value;
        }
    }

    /// <remarks/>
    public string Number
    {
        get
        {
            return this.numberField;
        }
        set
        {
            this.numberField = value;
        }
    }

    /// <remarks/>
    public string DamagePercentageSelected
    {
        get
        {
            return this.damagePercentageSelectedField;
        }
        set
        {
            this.damagePercentageSelectedField = value;
        }
    }

    /// <remarks/>
    public string Name
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
    public object Operation
    {
        get
        {
            return this.operationField;
        }
        set
        {
            this.operationField = value;
        }
    }

    /// <remarks/>
    public object Category
    {
        get
        {
            return this.categoryField;
        }
        set
        {
            this.categoryField = value;
        }
    }

    /// <remarks/>
    public string Unit
    {
        get
        {
            return this.unitField;
        }
        set
        {
            this.unitField = value;
        }
    }

    /// <remarks/>
    public object Note
    {
        get
        {
            return this.noteField;
        }
        set
        {
            this.noteField = value;
        }
    }

    /// <remarks/>
    public object NoteMark
    {
        get
        {
            return this.noteMarkField;
        }
        set
        {
            this.noteMarkField = value;
        }
    }

    /// <remarks/>
    public string QuantityUnregulated
    {
        get
        {
            return this.quantityUnregulatedField;
        }
        set
        {
            this.quantityUnregulatedField = value;
        }
    }

    /// <remarks/>
    public string QuantityRegulation
    {
        get
        {
            return this.quantityRegulationField;
        }
        set
        {
            this.quantityRegulationField = value;
        }
    }

    /// <remarks/>
    public string Amount
    {
        get
        {
            return this.amountField;
        }
        set
        {
            this.amountField = value;
        }
    }

    /// <remarks/>
    public string AmountMin
    {
        get
        {
            return this.amountMinField;
        }
        set
        {
            this.amountMinField = value;
        }
    }

    /// <remarks/>
    public string AmountTyp
    {
        get
        {
            return this.amountTypField;
        }
        set
        {
            this.amountTypField = value;
        }
    }

    /// <remarks/>
    public string AmountMax
    {
        get
        {
            return this.amountMaxField;
        }
        set
        {
            this.amountMaxField = value;
        }
    }

    /// <remarks/>
    public string UnitPrice
    {
        get
        {
            return this.unitPriceField;
        }
        set
        {
            this.unitPriceField = value;
        }
    }

    /// <remarks/>
    public string UnitPriceMin
    {
        get
        {
            return this.unitPriceMinField;
        }
        set
        {
            this.unitPriceMinField = value;
        }
    }

    /// <remarks/>
    public string UnitPriceTyp
    {
        get
        {
            return this.unitPriceTypField;
        }
        set
        {
            this.unitPriceTypField = value;
        }
    }

    /// <remarks/>
    public string UnitPriceMax
    {
        get
        {
            return this.unitPriceMaxField;
        }
        set
        {
            this.unitPriceMaxField = value;
        }
    }

    /// <remarks/>
    public string CostPrice
    {
        get
        {
            return this.costPriceField;
        }
        set
        {
            this.costPriceField = value;
        }
    }

    /// <remarks/>
    public string ItemPrice
    {
        get
        {
            return this.itemPriceField;
        }
        set
        {
            this.itemPriceField = value;
        }
    }

    /// <remarks/>
    public string RegCostPrice
    {
        get
        {
            return this.regCostPriceField;
        }
        set
        {
            this.regCostPriceField = value;
        }
    }

    /// <remarks/>
    public string Regulation
    {
        get
        {
            return this.regulationField;
        }
        set
        {
            this.regulationField = value;
        }
    }

    /// <remarks/>
    public string Income
    {
        get
        {
            return this.incomeField;
        }
        set
        {
            this.incomeField = value;
        }
    }

    /// <remarks/>
    public string SalesPriceContributionAdjustment
    {
        get
        {
            return this.salesPriceContributionAdjustmentField;
        }
        set
        {
            this.salesPriceContributionAdjustmentField = value;
        }
    }

    /// <remarks/>
    public string UnitIncome
    {
        get
        {
            return this.unitIncomeField;
        }
        set
        {
            this.unitIncomeField = value;
        }
    }

    /// <remarks/>
    public string UnitSalesPriceContributionAdjustment
    {
        get
        {
            return this.unitSalesPriceContributionAdjustmentField;
        }
        set
        {
            this.unitSalesPriceContributionAdjustmentField = value;
        }
    }

    /// <remarks/>
    public string StdSpread
    {
        get
        {
            return this.stdSpreadField;
        }
        set
        {
            this.stdSpreadField = value;
        }
    }

    /// <remarks/>
    public string Prioritet
    {
        get
        {
            return this.prioritetField;
        }
        set
        {
            this.prioritetField = value;
        }
    }

    /// <remarks/>
    public string Remain
    {
        get
        {
            return this.remainField;
        }
        set
        {
            this.remainField = value;
        }
    }

    /// <remarks/>
    public string RemainPercentage
    {
        get
        {
            return this.remainPercentageField;
        }
        set
        {
            this.remainPercentageField = value;
        }
    }

    /// <remarks/>
    public string NowValue
    {
        get
        {
            return this.nowValueField;
        }
        set
        {
            this.nowValueField = value;
        }
    }

    /// <remarks/>
    public string NowValuePercentage
    {
        get
        {
            return this.nowValuePercentageField;
        }
        set
        {
            this.nowValuePercentageField = value;
        }
    }

    /// <remarks/>
    public string LegalCost
    {
        get
        {
            return this.legalCostField;
        }
        set
        {
            this.legalCostField = value;
        }
    }

    /// <remarks/>
    public string LegalCostPercentage
    {
        get
        {
            return this.legalCostPercentageField;
        }
        set
        {
            this.legalCostPercentageField = value;
        }
    }

    /// <remarks/>
    public object Currency
    {
        get
        {
            return this.currencyField;
        }
        set
        {
            this.currencyField = value;
        }
    }

    /// <remarks/>
    public string CompareUnitPrice
    {
        get
        {
            return this.compareUnitPriceField;
        }
        set
        {
            this.compareUnitPriceField = value;
        }
    }

    /// <remarks/>
    public string CompareSalesPrice
    {
        get
        {
            return this.compareSalesPriceField;
        }
        set
        {
            this.compareSalesPriceField = value;
        }
    }

    /// <remarks/>
    public string Position
    {
        get
        {
            return this.positionField;
        }
        set
        {
            this.positionField = value;
        }
    }

    /// <remarks/>
    public object Flags
    {
        get
        {
            return this.flagsField;
        }
        set
        {
            this.flagsField = value;
        }
    }

    /// <remarks/>
    public string ProductionRate
    {
        get
        {
            return this.productionRateField;
        }
        set
        {
            this.productionRateField = value;
        }
    }

    /// <remarks/>
    public object ProductionUnit
    {
        get
        {
            return this.productionUnitField;
        }
        set
        {
            this.productionUnitField = value;
        }
    }

    /// <remarks/>
    public string ProductionUnitPrice
    {
        get
        {
            return this.productionUnitPriceField;
        }
        set
        {
            this.productionUnitPriceField = value;
        }
    }

    /// <remarks/>
    public object KeyWords
    {
        get
        {
            return this.keyWordsField;
        }
        set
        {
            this.keyWordsField = value;
        }
    }

    /// <remarks/>
    public string Damage
    {
        get
        {
            return this.damageField;
        }
        set
        {
            this.damageField = value;
        }
    }

    /// <remarks/>
    public string DamagePercentage
    {
        get
        {
            return this.damagePercentageField;
        }
        set
        {
            this.damagePercentageField = value;
        }
    }

    /// <remarks/>
    public string DamageQuantity
    {
        get
        {
            return this.damageQuantityField;
        }
        set
        {
            this.damageQuantityField = value;
        }
    }

    /// <remarks/>
    public string NowValueFollowPercentage
    {
        get
        {
            return this.nowValueFollowPercentageField;
        }
        set
        {
            this.nowValueFollowPercentageField = value;
        }
    }

    /// <remarks/>
    public string DamageNowValue
    {
        get
        {
            return this.damageNowValueField;
        }
        set
        {
            this.damageNowValueField = value;
        }
    }

    /// <remarks/>
    public string DamageBase
    {
        get
        {
            return this.damageBaseField;
        }
        set
        {
            this.damageBaseField = value;
        }
    }

    /// <remarks/>
    public string DamageBaseNowValue
    {
        get
        {
            return this.damageBaseNowValueField;
        }
        set
        {
            this.damageBaseNowValueField = value;
        }
    }

    /// <remarks/>
    public string ServiceUnitPrice
    {
        get
        {
            return this.serviceUnitPriceField;
        }
        set
        {
            this.serviceUnitPriceField = value;
        }
    }

    /// <remarks/>
    public string ServiceTotalPrice
    {
        get
        {
            return this.serviceTotalPriceField;
        }
        set
        {
            this.serviceTotalPriceField = value;
        }
    }

    /// <remarks/>
    public string UnitTime
    {
        get
        {
            return this.unitTimeField;
        }
        set
        {
            this.unitTimeField = value;
        }
    }

    /// <remarks/>
    public string TotalTime
    {
        get
        {
            return this.totalTimeField;
        }
        set
        {
            this.totalTimeField = value;
        }
    }

    /// <remarks/>
    public string CostPriceContribution1
    {
        get
        {
            return this.costPriceContribution1Field;
        }
        set
        {
            this.costPriceContribution1Field = value;
        }
    }

    /// <remarks/>
    public string CostPriceContribution2
    {
        get
        {
            return this.costPriceContribution2Field;
        }
        set
        {
            this.costPriceContribution2Field = value;
        }
    }

    /// <remarks/>
    public string CostPriceContribution3
    {
        get
        {
            return this.costPriceContribution3Field;
        }
        set
        {
            this.costPriceContribution3Field = value;
        }
    }

    /// <remarks/>
    public string CostPriceContribution4
    {
        get
        {
            return this.costPriceContribution4Field;
        }
        set
        {
            this.costPriceContribution4Field = value;
        }
    }

    /// <remarks/>
    public string CostPriceContribution5
    {
        get
        {
            return this.costPriceContribution5Field;
        }
        set
        {
            this.costPriceContribution5Field = value;
        }
    }

    /// <remarks/>
    public string CostPriceWithContribution
    {
        get
        {
            return this.costPriceWithContributionField;
        }
        set
        {
            this.costPriceWithContributionField = value;
        }
    }

    /// <remarks/>
    public string SalesPriceContribution1
    {
        get
        {
            return this.salesPriceContribution1Field;
        }
        set
        {
            this.salesPriceContribution1Field = value;
        }
    }

    /// <remarks/>
    public string SalesPriceContribution2
    {
        get
        {
            return this.salesPriceContribution2Field;
        }
        set
        {
            this.salesPriceContribution2Field = value;
        }
    }

    /// <remarks/>
    public string SalesPriceContribution3
    {
        get
        {
            return this.salesPriceContribution3Field;
        }
        set
        {
            this.salesPriceContribution3Field = value;
        }
    }

    /// <remarks/>
    public string SalesPriceContribution4
    {
        get
        {
            return this.salesPriceContribution4Field;
        }
        set
        {
            this.salesPriceContribution4Field = value;
        }
    }

    /// <remarks/>
    public string SalesPriceContribution5
    {
        get
        {
            return this.salesPriceContribution5Field;
        }
        set
        {
            this.salesPriceContribution5Field = value;
        }
    }

    /// <remarks/>
    public string UnitSalesPrice
    {
        get
        {
            return this.unitSalesPriceField;
        }
        set
        {
            this.unitSalesPriceField = value;
        }
    }

    /// <remarks/>
    public string SalesPrice
    {
        get
        {
            return this.salesPriceField;
        }
        set
        {
            this.salesPriceField = value;
        }
    }

    /// <remarks/>
    public string TotalIncome
    {
        get
        {
            return this.totalIncomeField;
        }
        set
        {
            this.totalIncomeField = value;
        }
    }

    /// <remarks/>
    public string TotalProfitMargin
    {
        get
        {
            return this.totalProfitMarginField;
        }
        set
        {
            this.totalProfitMarginField = value;
        }
    }

    /// <remarks/>
    public string ReallocatedIncome
    {
        get
        {
            return this.reallocatedIncomeField;
        }
        set
        {
            this.reallocatedIncomeField = value;
        }
    }

    /// <remarks/>
    public string Rounding
    {
        get
        {
            return this.roundingField;
        }
        set
        {
            this.roundingField = value;
        }
    }

    /// <remarks/>
    public string SalesPriceBeforeDiscount
    {
        get
        {
            return this.salesPriceBeforeDiscountField;
        }
        set
        {
            this.salesPriceBeforeDiscountField = value;
        }
    }

    /// <remarks/>
    public string DiscountContribution1
    {
        get
        {
            return this.discountContribution1Field;
        }
        set
        {
            this.discountContribution1Field = value;
        }
    }

    /// <remarks/>
    public string DiscountContribution2
    {
        get
        {
            return this.discountContribution2Field;
        }
        set
        {
            this.discountContribution2Field = value;
        }
    }

    /// <remarks/>
    public string DiscountContribution3
    {
        get
        {
            return this.discountContribution3Field;
        }
        set
        {
            this.discountContribution3Field = value;
        }
    }

    /// <remarks/>
    public string DiscountContribution4
    {
        get
        {
            return this.discountContribution4Field;
        }
        set
        {
            this.discountContribution4Field = value;
        }
    }

    /// <remarks/>
    public string DiscountContribution5
    {
        get
        {
            return this.discountContribution5Field;
        }
        set
        {
            this.discountContribution5Field = value;
        }
    }

    /// <remarks/>
    public string DiscountContributionPercentage
    {
        get
        {
            return this.discountContributionPercentageField;
        }
        set
        {
            this.discountContributionPercentageField = value;
        }
    }

    /// <remarks/>
    public string DiscountContributionAdjustment
    {
        get
        {
            return this.discountContributionAdjustmentField;
        }
        set
        {
            this.discountContributionAdjustmentField = value;
        }
    }

    /// <remarks/>
    public string TotalDiscountPercentage
    {
        get
        {
            return this.totalDiscountPercentageField;
        }
        set
        {
            this.totalDiscountPercentageField = value;
        }
    }

    /// <remarks/>
    public string TotalDiscountAmount
    {
        get
        {
            return this.totalDiscountAmountField;
        }
        set
        {
            this.totalDiscountAmountField = value;
        }
    }

    /// <remarks/>
    public string Profit
    {
        get
        {
            return this.profitField;
        }
        set
        {
            this.profitField = value;
        }
    }

    /// <remarks/>
    public bool Disabled
    {
        get
        {
            return this.disabledField;
        }
        set
        {
            this.disabledField = value;
        }
    }

    /// <remarks/>
    public string UnregulatedQuantityFactor
    {
        get
        {
            return this.unregulatedQuantityFactorField;
        }
        set
        {
            this.unregulatedQuantityFactorField = value;
        }
    }

    /// <remarks/>
    public string QuantityFactor
    {
        get
        {
            return this.quantityFactorField;
        }
        set
        {
            this.quantityFactorField = value;
        }
    }

    /// <remarks/>
    public string PriceFactor
    {
        get
        {
            return this.priceFactorField;
        }
        set
        {
            this.priceFactorField = value;
        }
    }

    /// <remarks/>
    public ComponentComponentView ComponentView
    {
        get
        {
            return this.componentViewField;
        }
        set
        {
            this.componentViewField = value;
        }
    }

    /// <remarks/>
    public ComponentReAllocateInfo ReAllocateInfo
    {
        get
        {
            return this.reAllocateInfoField;
        }
        set
        {
            this.reAllocateInfoField = value;
        }
    }

    /// <remarks/>
    public ComponentPricePerCategoryCollection PricePerCategoryCollection
    {
        get
        {
            return this.pricePerCategoryCollectionField;
        }
        set
        {
            this.pricePerCategoryCollectionField = value;
        }
    }

    /// <remarks/>
    public ComponentReadOnly ReadOnly
    {
        get
        {
            return this.readOnlyField;
        }
        set
        {
            this.readOnlyField = value;
        }
    }

    /// <remarks/>
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Component")]
    public Component[] Component1
    {
        get
        {
            return this.componentField;
        }
        set
        {
            this.componentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("Name")]
    public string Name1
    {
        get
        {
            return this.name1Field;
        }
        set
        {
            this.name1Field = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ComponentComponentView
{

    private string typeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ComponentReAllocateInfo
{

    private bool enabledField;

    private string maxPercentField;

    /// <remarks/>
    public bool Enabled
    {
        get
        {
            return this.enabledField;
        }
        set
        {
            this.enabledField = value;
        }
    }

    /// <remarks/>
    public string MaxPercent
    {
        get
        {
            return this.maxPercentField;
        }
        set
        {
            this.maxPercentField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ComponentPricePerCategoryCollection
{

    private ComponentPricePerCategoryCollectionPricePerCategory pricePerCategoryField;

    /// <remarks/>
    public ComponentPricePerCategoryCollectionPricePerCategory PricePerCategory
    {
        get
        {
            return this.pricePerCategoryField;
        }
        set
        {
            this.pricePerCategoryField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ComponentPricePerCategoryCollectionPricePerCategory
{

    private string categoryField;

    private string regCostPriceField;

    private string quantityField;

    private string quantityUnregulatedField;

    private string unitsField;

    private bool unitAgreeField;

    /// <remarks/>
    public string Category
    {
        get
        {
            return this.categoryField;
        }
        set
        {
            this.categoryField = value;
        }
    }

    /// <remarks/>
    public string RegCostPrice
    {
        get
        {
            return this.regCostPriceField;
        }
        set
        {
            this.regCostPriceField = value;
        }
    }

    /// <remarks/>
    public string Quantity
    {
        get
        {
            return this.quantityField;
        }
        set
        {
            this.quantityField = value;
        }
    }

    /// <remarks/>
    public string QuantityUnregulated
    {
        get
        {
            return this.quantityUnregulatedField;
        }
        set
        {
            this.quantityUnregulatedField = value;
        }
    }

    /// <remarks/>
    public string Units
    {
        get
        {
            return this.unitsField;
        }
        set
        {
            this.unitsField = value;
        }
    }

    /// <remarks/>
    public bool UnitAgree
    {
        get
        {
            return this.unitAgreeField;
        }
        set
        {
            this.unitAgreeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ComponentReadOnly
{

    private bool preventDeletionField;

    /// <remarks/>
    public bool PreventDeletion
    {
        get
        {
            return this.preventDeletionField;
        }
        set
        {
            this.preventDeletionField = value;
        }
    }
}