// <auto-generated/>
// Contents of: hl7.fhir.r5.expansions#5.0.0, hl7.fhir.r5.core#5.0.0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Utility;
using Hl7.Fhir.Validation;
using SystemPrimitive = Hl7.Fhir.ElementModel.Types;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  
*/

namespace Hl7.Fhir.Model
{
  /// <summary>
  /// This resource reflects an instance of a biologically derived product
  /// </summary>
  /// <remarks>
  /// This resource reflects an instance of a biologically derived product. A material substance originating from a biological entity intended to be transplanted or infused
  /// into another (possibly the same) biological entity.
  /// Substances include, but are not limited to: whole blood, bone marrow, organs, and manipulated blood cells.
  /// </remarks>
  [Serializable]
  [DataContract]
  [FhirType("BiologicallyDerivedProduct","http://hl7.org/fhir/StructureDefinition/BiologicallyDerivedProduct", IsResource=true)]
  public partial class BiologicallyDerivedProduct : Hl7.Fhir.Model.DomainResource, IIdentifiable<List<Identifier>>
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "BiologicallyDerivedProduct"; } }

    /// <summary>
    /// How this product was collected
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("BiologicallyDerivedProduct#Collection", IsNestedType=true)]
    [BackboneType("BiologicallyDerivedProduct.collection")]
    public partial class CollectionComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "BiologicallyDerivedProduct#Collection"; } }

      /// <summary>
      /// Individual performing collection
      /// </summary>
      [FhirElement("collector", Order=40)]
      [CLSCompliant(false)]
      [References("Practitioner","PractitionerRole")]
      [DataMember]
      public Hl7.Fhir.Model.ResourceReference Collector
      {
        get { return _Collector; }
        set { _Collector = value; OnPropertyChanged("Collector"); }
      }

      private Hl7.Fhir.Model.ResourceReference _Collector;

      /// <summary>
      /// The patient who underwent the medical procedure to collect the product or the organization that facilitated the collection
      /// </summary>
      [FhirElement("source", Order=50)]
      [CLSCompliant(false)]
      [References("Patient","Organization")]
      [DataMember]
      public Hl7.Fhir.Model.ResourceReference Source
      {
        get { return _Source; }
        set { _Source = value; OnPropertyChanged("Source"); }
      }

      private Hl7.Fhir.Model.ResourceReference _Source;

      /// <summary>
      /// Time of product collection
      /// </summary>
      [FhirElement("collected", Order=60, Choice=ChoiceType.DatatypeChoice)]
      [CLSCompliant(false)]
      [AllowedTypes(typeof(Hl7.Fhir.Model.FhirDateTime),typeof(Hl7.Fhir.Model.Period))]
      [DataMember]
      public Hl7.Fhir.Model.DataType Collected
      {
        get { return _Collected; }
        set { _Collected = value; OnPropertyChanged("Collected"); }
      }

      private Hl7.Fhir.Model.DataType _Collected;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as CollectionComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Collector != null) dest.Collector = (Hl7.Fhir.Model.ResourceReference)Collector.DeepCopy();
        if(Source != null) dest.Source = (Hl7.Fhir.Model.ResourceReference)Source.DeepCopy();
        if(Collected != null) dest.Collected = (Hl7.Fhir.Model.DataType)Collected.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new CollectionComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as CollectionComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Collector, otherT.Collector)) return false;
        if( !DeepComparable.Matches(Source, otherT.Source)) return false;
        if( !DeepComparable.Matches(Collected, otherT.Collected)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as CollectionComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Collector, otherT.Collector)) return false;
        if( !DeepComparable.IsExactly(Source, otherT.Source)) return false;
        if( !DeepComparable.IsExactly(Collected, otherT.Collected)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Collector != null) yield return Collector;
          if (Source != null) yield return Source;
          if (Collected != null) yield return Collected;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Collector != null) yield return new ElementValue("collector", Collector);
          if (Source != null) yield return new ElementValue("source", Source);
          if (Collected != null) yield return new ElementValue("collected", Collected);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "collector":
            value = Collector;
            return Collector is not null;
          case "source":
            value = Source;
            return Source is not null;
          case "collected":
            value = Collected;
            return Collected is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Collector is not null) yield return new KeyValuePair<string,object>("collector",Collector);
        if (Source is not null) yield return new KeyValuePair<string,object>("source",Source);
        if (Collected is not null) yield return new KeyValuePair<string,object>("collected",Collected);
      }

    }

    /// <summary>
    /// A property that is specific to this BiologicallyDerviedProduct instance
    /// </summary>
    /// <remarks>
    /// Property can be used to provide information on a wide range of additional information specific to a particular biologicallyDerivedProduct.
    /// </remarks>
    [Serializable]
    [DataContract]
    [FhirType("BiologicallyDerivedProduct#Property", IsNestedType=true)]
    [BackboneType("BiologicallyDerivedProduct.property")]
    public partial class PropertyComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "BiologicallyDerivedProduct#Property"; } }

      /// <summary>
      /// Code that specifies the property
      /// </summary>
      [FhirElement("type", Order=40)]
      [Binding("BiologicallyDerivedProductPropertyTypeCodes")]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Type
      {
        get { return _Type; }
        set { _Type = value; OnPropertyChanged("Type"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Type;

      /// <summary>
      /// Property values
      /// </summary>
      [FhirElement("value", Order=50, Choice=ChoiceType.DatatypeChoice)]
      [CLSCompliant(false)]
      [AllowedTypes(typeof(Hl7.Fhir.Model.FhirBoolean),typeof(Hl7.Fhir.Model.Integer),typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Hl7.Fhir.Model.Period),typeof(Hl7.Fhir.Model.Quantity),typeof(Hl7.Fhir.Model.Range),typeof(Hl7.Fhir.Model.Ratio),typeof(Hl7.Fhir.Model.FhirString),typeof(Hl7.Fhir.Model.Attachment))]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.DataType Value
      {
        get { return _Value; }
        set { _Value = value; OnPropertyChanged("Value"); }
      }

      private Hl7.Fhir.Model.DataType _Value;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as PropertyComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
        if(Value != null) dest.Value = (Hl7.Fhir.Model.DataType)Value.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new PropertyComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as PropertyComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Type, otherT.Type)) return false;
        if( !DeepComparable.Matches(Value, otherT.Value)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as PropertyComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
        if( !DeepComparable.IsExactly(Value, otherT.Value)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Type != null) yield return Type;
          if (Value != null) yield return Value;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Type != null) yield return new ElementValue("type", Type);
          if (Value != null) yield return new ElementValue("value", Value);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "type":
            value = Type;
            return Type is not null;
          case "value":
            value = Value;
            return Value is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Type is not null) yield return new KeyValuePair<string,object>("type",Type);
        if (Value is not null) yield return new KeyValuePair<string,object>("value",Value);
      }

    }

    /// <summary>
    /// organ | tissue | fluid | cells | biologicalAgent
    /// </summary>
    [FhirElement("productCategory", Order=90)]
    [Binding("BiologicallyDerivedProductCategory")]
    [DataMember]
    public Hl7.Fhir.Model.Coding ProductCategory
    {
      get { return _ProductCategory; }
      set { _ProductCategory = value; OnPropertyChanged("ProductCategory"); }
    }

    private Hl7.Fhir.Model.Coding _ProductCategory;

    /// <summary>
    /// A code that identifies the kind of this biologically derived product
    /// </summary>
    [FhirElement("productCode", Order=100)]
    [Binding("BiologicallyDerivedProductCodes")]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept ProductCode
    {
      get { return _ProductCode; }
      set { _ProductCode = value; OnPropertyChanged("ProductCode"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _ProductCode;

    /// <summary>
    /// The parent biologically-derived product
    /// </summary>
    [FhirElement("parent", Order=110)]
    [CLSCompliant(false)]
    [References("BiologicallyDerivedProduct")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Parent
    {
      get { if(_Parent==null) _Parent = new List<Hl7.Fhir.Model.ResourceReference>(); return _Parent; }
      set { _Parent = value; OnPropertyChanged("Parent"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Parent;

    /// <summary>
    /// Request to obtain and/or infuse this product
    /// </summary>
    [FhirElement("request", Order=120)]
    [CLSCompliant(false)]
    [References("ServiceRequest")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Request
    {
      get { if(_Request==null) _Request = new List<Hl7.Fhir.Model.ResourceReference>(); return _Request; }
      set { _Request = value; OnPropertyChanged("Request"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Request;

    /// <summary>
    /// Instance identifier
    /// </summary>
    [FhirElement("identifier", InSummary=true, Order=130, FiveWs="FiveWs.identifier")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Identifier> Identifier
    {
      get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
      set { _Identifier = value; OnPropertyChanged("Identifier"); }
    }

    private List<Hl7.Fhir.Model.Identifier> _Identifier;

    /// <summary>
    /// An identifier that supports traceability to the event during which material in this product from one or more biological entities was obtained or pooled
    /// </summary>
    [FhirElement("biologicalSourceEvent", InSummary=true, Order=140, FiveWs="FiveWs.identifier")]
    [DataMember]
    public Hl7.Fhir.Model.Identifier BiologicalSourceEvent
    {
      get { return _BiologicalSourceEvent; }
      set { _BiologicalSourceEvent = value; OnPropertyChanged("BiologicalSourceEvent"); }
    }

    private Hl7.Fhir.Model.Identifier _BiologicalSourceEvent;

    /// <summary>
    /// Processing facilities responsible for the labeling and distribution of this biologically derived product
    /// </summary>
    [FhirElement("processingFacility", Order=150)]
    [CLSCompliant(false)]
    [References("Organization")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> ProcessingFacility
    {
      get { if(_ProcessingFacility==null) _ProcessingFacility = new List<Hl7.Fhir.Model.ResourceReference>(); return _ProcessingFacility; }
      set { _ProcessingFacility = value; OnPropertyChanged("ProcessingFacility"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _ProcessingFacility;

    /// <summary>
    /// A unique identifier for an aliquot of a product
    /// </summary>
    [FhirElement("division", Order=160)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString DivisionElement
    {
      get { return _DivisionElement; }
      set { _DivisionElement = value; OnPropertyChanged("DivisionElement"); }
    }

    private Hl7.Fhir.Model.FhirString _DivisionElement;

    /// <summary>
    /// A unique identifier for an aliquot of a product
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Division
    {
      get { return DivisionElement != null ? DivisionElement.Value : null; }
      set
      {
        if (value == null)
          DivisionElement = null;
        else
          DivisionElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Division");
      }
    }

    /// <summary>
    /// available | unavailable
    /// </summary>
    [FhirElement("productStatus", Order=170)]
    [Binding("BiologicallyDerivedProductStatus")]
    [DataMember]
    public Hl7.Fhir.Model.Coding ProductStatus
    {
      get { return _ProductStatus; }
      set { _ProductStatus = value; OnPropertyChanged("ProductStatus"); }
    }

    private Hl7.Fhir.Model.Coding _ProductStatus;

    /// <summary>
    /// Date, and where relevant time, of expiration
    /// </summary>
    [FhirElement("expirationDate", Order=180)]
    [DataMember]
    public Hl7.Fhir.Model.FhirDateTime ExpirationDateElement
    {
      get { return _ExpirationDateElement; }
      set { _ExpirationDateElement = value; OnPropertyChanged("ExpirationDateElement"); }
    }

    private Hl7.Fhir.Model.FhirDateTime _ExpirationDateElement;

    /// <summary>
    /// Date, and where relevant time, of expiration
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string ExpirationDate
    {
      get { return ExpirationDateElement != null ? ExpirationDateElement.Value : null; }
      set
      {
        if (value == null)
          ExpirationDateElement = null;
        else
          ExpirationDateElement = new Hl7.Fhir.Model.FhirDateTime(value);
        OnPropertyChanged("ExpirationDate");
      }
    }

    /// <summary>
    /// How this product was collected
    /// </summary>
    [FhirElement("collection", Order=190)]
    [DataMember]
    public Hl7.Fhir.Model.BiologicallyDerivedProduct.CollectionComponent Collection
    {
      get { return _Collection; }
      set { _Collection = value; OnPropertyChanged("Collection"); }
    }

    private Hl7.Fhir.Model.BiologicallyDerivedProduct.CollectionComponent _Collection;

    /// <summary>
    /// Product storage temperature requirements
    /// </summary>
    [FhirElement("storageTempRequirements", Order=200)]
    [DataMember]
    public Hl7.Fhir.Model.Range StorageTempRequirements
    {
      get { return _StorageTempRequirements; }
      set { _StorageTempRequirements = value; OnPropertyChanged("StorageTempRequirements"); }
    }

    private Hl7.Fhir.Model.Range _StorageTempRequirements;

    /// <summary>
    /// A property that is specific to this BiologicallyDerviedProduct instance
    /// </summary>
    [FhirElement("property", Order=210)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.BiologicallyDerivedProduct.PropertyComponent> Property
    {
      get { if(_Property==null) _Property = new List<Hl7.Fhir.Model.BiologicallyDerivedProduct.PropertyComponent>(); return _Property; }
      set { _Property = value; OnPropertyChanged("Property"); }
    }

    private List<Hl7.Fhir.Model.BiologicallyDerivedProduct.PropertyComponent> _Property;

    List<Identifier> IIdentifiable<List<Identifier>>.Identifier { get => Identifier; set => Identifier = value; }

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as BiologicallyDerivedProduct;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(ProductCategory != null) dest.ProductCategory = (Hl7.Fhir.Model.Coding)ProductCategory.DeepCopy();
      if(ProductCode != null) dest.ProductCode = (Hl7.Fhir.Model.CodeableConcept)ProductCode.DeepCopy();
      if(Parent.Any()) dest.Parent = new List<Hl7.Fhir.Model.ResourceReference>(Parent.DeepCopy());
      if(Request.Any()) dest.Request = new List<Hl7.Fhir.Model.ResourceReference>(Request.DeepCopy());
      if(Identifier.Any()) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(BiologicalSourceEvent != null) dest.BiologicalSourceEvent = (Hl7.Fhir.Model.Identifier)BiologicalSourceEvent.DeepCopy();
      if(ProcessingFacility.Any()) dest.ProcessingFacility = new List<Hl7.Fhir.Model.ResourceReference>(ProcessingFacility.DeepCopy());
      if(DivisionElement != null) dest.DivisionElement = (Hl7.Fhir.Model.FhirString)DivisionElement.DeepCopy();
      if(ProductStatus != null) dest.ProductStatus = (Hl7.Fhir.Model.Coding)ProductStatus.DeepCopy();
      if(ExpirationDateElement != null) dest.ExpirationDateElement = (Hl7.Fhir.Model.FhirDateTime)ExpirationDateElement.DeepCopy();
      if(Collection != null) dest.Collection = (Hl7.Fhir.Model.BiologicallyDerivedProduct.CollectionComponent)Collection.DeepCopy();
      if(StorageTempRequirements != null) dest.StorageTempRequirements = (Hl7.Fhir.Model.Range)StorageTempRequirements.DeepCopy();
      if(Property.Any()) dest.Property = new List<Hl7.Fhir.Model.BiologicallyDerivedProduct.PropertyComponent>(Property.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new BiologicallyDerivedProduct());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as BiologicallyDerivedProduct;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(ProductCategory, otherT.ProductCategory)) return false;
      if( !DeepComparable.Matches(ProductCode, otherT.ProductCode)) return false;
      if( !DeepComparable.Matches(Parent, otherT.Parent)) return false;
      if( !DeepComparable.Matches(Request, otherT.Request)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(BiologicalSourceEvent, otherT.BiologicalSourceEvent)) return false;
      if( !DeepComparable.Matches(ProcessingFacility, otherT.ProcessingFacility)) return false;
      if( !DeepComparable.Matches(DivisionElement, otherT.DivisionElement)) return false;
      if( !DeepComparable.Matches(ProductStatus, otherT.ProductStatus)) return false;
      if( !DeepComparable.Matches(ExpirationDateElement, otherT.ExpirationDateElement)) return false;
      if( !DeepComparable.Matches(Collection, otherT.Collection)) return false;
      if( !DeepComparable.Matches(StorageTempRequirements, otherT.StorageTempRequirements)) return false;
      if( !DeepComparable.Matches(Property, otherT.Property)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as BiologicallyDerivedProduct;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(ProductCategory, otherT.ProductCategory)) return false;
      if( !DeepComparable.IsExactly(ProductCode, otherT.ProductCode)) return false;
      if( !DeepComparable.IsExactly(Parent, otherT.Parent)) return false;
      if( !DeepComparable.IsExactly(Request, otherT.Request)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(BiologicalSourceEvent, otherT.BiologicalSourceEvent)) return false;
      if( !DeepComparable.IsExactly(ProcessingFacility, otherT.ProcessingFacility)) return false;
      if( !DeepComparable.IsExactly(DivisionElement, otherT.DivisionElement)) return false;
      if( !DeepComparable.IsExactly(ProductStatus, otherT.ProductStatus)) return false;
      if( !DeepComparable.IsExactly(ExpirationDateElement, otherT.ExpirationDateElement)) return false;
      if( !DeepComparable.IsExactly(Collection, otherT.Collection)) return false;
      if( !DeepComparable.IsExactly(StorageTempRequirements, otherT.StorageTempRequirements)) return false;
      if( !DeepComparable.IsExactly(Property, otherT.Property)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        if (ProductCategory != null) yield return ProductCategory;
        if (ProductCode != null) yield return ProductCode;
        foreach (var elem in Parent) { if (elem != null) yield return elem; }
        foreach (var elem in Request) { if (elem != null) yield return elem; }
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        if (BiologicalSourceEvent != null) yield return BiologicalSourceEvent;
        foreach (var elem in ProcessingFacility) { if (elem != null) yield return elem; }
        if (DivisionElement != null) yield return DivisionElement;
        if (ProductStatus != null) yield return ProductStatus;
        if (ExpirationDateElement != null) yield return ExpirationDateElement;
        if (Collection != null) yield return Collection;
        if (StorageTempRequirements != null) yield return StorageTempRequirements;
        foreach (var elem in Property) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        if (ProductCategory != null) yield return new ElementValue("productCategory", ProductCategory);
        if (ProductCode != null) yield return new ElementValue("productCode", ProductCode);
        foreach (var elem in Parent) { if (elem != null) yield return new ElementValue("parent", elem); }
        foreach (var elem in Request) { if (elem != null) yield return new ElementValue("request", elem); }
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        if (BiologicalSourceEvent != null) yield return new ElementValue("biologicalSourceEvent", BiologicalSourceEvent);
        foreach (var elem in ProcessingFacility) { if (elem != null) yield return new ElementValue("processingFacility", elem); }
        if (DivisionElement != null) yield return new ElementValue("division", DivisionElement);
        if (ProductStatus != null) yield return new ElementValue("productStatus", ProductStatus);
        if (ExpirationDateElement != null) yield return new ElementValue("expirationDate", ExpirationDateElement);
        if (Collection != null) yield return new ElementValue("collection", Collection);
        if (StorageTempRequirements != null) yield return new ElementValue("storageTempRequirements", StorageTempRequirements);
        foreach (var elem in Property) { if (elem != null) yield return new ElementValue("property", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "productCategory":
          value = ProductCategory;
          return ProductCategory is not null;
        case "productCode":
          value = ProductCode;
          return ProductCode is not null;
        case "parent":
          value = Parent;
          return Parent?.Any() == true;
        case "request":
          value = Request;
          return Request?.Any() == true;
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "biologicalSourceEvent":
          value = BiologicalSourceEvent;
          return BiologicalSourceEvent is not null;
        case "processingFacility":
          value = ProcessingFacility;
          return ProcessingFacility?.Any() == true;
        case "division":
          value = DivisionElement;
          return DivisionElement is not null;
        case "productStatus":
          value = ProductStatus;
          return ProductStatus is not null;
        case "expirationDate":
          value = ExpirationDateElement;
          return ExpirationDateElement is not null;
        case "collection":
          value = Collection;
          return Collection is not null;
        case "storageTempRequirements":
          value = StorageTempRequirements;
          return StorageTempRequirements is not null;
        case "property":
          value = Property;
          return Property?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (ProductCategory is not null) yield return new KeyValuePair<string,object>("productCategory",ProductCategory);
      if (ProductCode is not null) yield return new KeyValuePair<string,object>("productCode",ProductCode);
      if (Parent?.Any() == true) yield return new KeyValuePair<string,object>("parent",Parent);
      if (Request?.Any() == true) yield return new KeyValuePair<string,object>("request",Request);
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (BiologicalSourceEvent is not null) yield return new KeyValuePair<string,object>("biologicalSourceEvent",BiologicalSourceEvent);
      if (ProcessingFacility?.Any() == true) yield return new KeyValuePair<string,object>("processingFacility",ProcessingFacility);
      if (DivisionElement is not null) yield return new KeyValuePair<string,object>("division",DivisionElement);
      if (ProductStatus is not null) yield return new KeyValuePair<string,object>("productStatus",ProductStatus);
      if (ExpirationDateElement is not null) yield return new KeyValuePair<string,object>("expirationDate",ExpirationDateElement);
      if (Collection is not null) yield return new KeyValuePair<string,object>("collection",Collection);
      if (StorageTempRequirements is not null) yield return new KeyValuePair<string,object>("storageTempRequirements",StorageTempRequirements);
      if (Property?.Any() == true) yield return new KeyValuePair<string,object>("property",Property);
    }

  }

}

// end of file
