﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3603
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.42.
// 
namespace Ola.RestClient.NUnitTests {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class inventoryItemListResponse {
        
        private inventoryItemListResponseInventoryItemList[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("inventoryItemList", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public inventoryItemListResponseInventoryItemList[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class inventoryItemListResponseInventoryItemList {
        
        private inventoryItemListResponseInventoryItemListInventoryItemListItem[] inventoryItemListItemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("inventoryItemListItem", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public inventoryItemListResponseInventoryItemListInventoryItemListItem[] inventoryItemListItem {
            get {
                return this.inventoryItemListItemField;
            }
            set {
                this.inventoryItemListItemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class inventoryItemListResponseInventoryItemListInventoryItemListItem {
        
        private string inventoryItemUidField;
        
        private string utcFirstCreatedField;
        
        private string utcLastModifiedField;
        
        private string lastUpdatedUidField;
        
        private string codeField;
        
        private string descriptionField;
        
        private string isActiveField;
        
        private string stockOnHandField;
        
        private string currentValueField;
        
        private string averageCostField;
        
        private string rrpInclTaxField;
        
        private string sellingPriceField;
        
        private string isSellingPriceIncTaxField;
        
        private string buyingPriceField;
        
        private string isBuyingPriceIncTaxField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string inventoryItemUid {
            get {
                return this.inventoryItemUidField;
            }
            set {
                this.inventoryItemUidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string utcFirstCreated {
            get {
                return this.utcFirstCreatedField;
            }
            set {
                this.utcFirstCreatedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string utcLastModified {
            get {
                return this.utcLastModifiedField;
            }
            set {
                this.utcLastModifiedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string lastUpdatedUid {
            get {
                return this.lastUpdatedUidField;
            }
            set {
                this.lastUpdatedUidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string isActive {
            get {
                return this.isActiveField;
            }
            set {
                this.isActiveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string stockOnHand {
            get {
                return this.stockOnHandField;
            }
            set {
                this.stockOnHandField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string currentValue {
            get {
                return this.currentValueField;
            }
            set {
                this.currentValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string averageCost {
            get {
                return this.averageCostField;
            }
            set {
                this.averageCostField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string rrpInclTax {
            get {
                return this.rrpInclTaxField;
            }
            set {
                this.rrpInclTaxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string sellingPrice {
            get {
                return this.sellingPriceField;
            }
            set {
                this.sellingPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string isSellingPriceIncTax {
            get {
                return this.isSellingPriceIncTaxField;
            }
            set {
                this.isSellingPriceIncTaxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string buyingPrice {
            get {
                return this.buyingPriceField;
            }
            set {
                this.buyingPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string isBuyingPriceIncTax {
            get {
                return this.isBuyingPriceIncTaxField;
            }
            set {
                this.isBuyingPriceIncTaxField = value;
            }
        }
    }
}
