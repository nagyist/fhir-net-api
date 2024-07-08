// <auto-generated/>
// Contents of: hl7.fhir.r4b.expansions#4.3.0, hl7.fhir.r4b.core#4.3.0

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
  /// The shelf-life and storage information for a medicinal product item or container can be described using this class
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("ProductShelfLife","http://hl7.org/fhir/StructureDefinition/ProductShelfLife")]
  public partial class ProductShelfLife : Hl7.Fhir.Model.BackboneType
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "ProductShelfLife"; } }

    /// <summary>
    /// Unique identifier for the packaged Medicinal Product
    /// </summary>
    [FhirElement("identifier", InSummary=true, Order=40)]
    [DataMember]
    public Hl7.Fhir.Model.Identifier Identifier
    {
      get { return _Identifier; }
      set { _Identifier = value; OnPropertyChanged("Identifier"); }
    }

    private Hl7.Fhir.Model.Identifier _Identifier;

    /// <summary>
    /// This describes the shelf life, taking into account various scenarios such as shelf life of the packaged Medicinal Product itself, shelf life after transformation where necessary and shelf life after the first opening of a bottle, etc. The shelf life type shall be specified using an appropriate controlled vocabulary The controlled term and the controlled term identifier shall be specified
    /// </summary>
    [FhirElement("type", InSummary=true, Order=50)]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Type
    {
      get { return _Type; }
      set { _Type = value; OnPropertyChanged("Type"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Type;

    /// <summary>
    /// The shelf life time period can be specified using a numerical value for the period of time and its unit of time measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used
    /// </summary>
    [FhirElement("period", InSummary=true, Order=60)]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.Quantity Period
    {
      get { return _Period; }
      set { _Period = value; OnPropertyChanged("Period"); }
    }

    private Hl7.Fhir.Model.Quantity _Period;

    /// <summary>
    /// Special precautions for storage, if any, can be specified using an appropriate controlled vocabulary The controlled term and the controlled term identifier shall be specified
    /// </summary>
    [FhirElement("specialPrecautionsForStorage", InSummary=true, Order=70)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> SpecialPrecautionsForStorage
    {
      get { if(_SpecialPrecautionsForStorage==null) _SpecialPrecautionsForStorage = new List<Hl7.Fhir.Model.CodeableConcept>(); return _SpecialPrecautionsForStorage; }
      set { _SpecialPrecautionsForStorage = value; OnPropertyChanged("SpecialPrecautionsForStorage"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _SpecialPrecautionsForStorage;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as ProductShelfLife;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.Identifier)Identifier.DeepCopy();
      if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
      if(Period != null) dest.Period = (Hl7.Fhir.Model.Quantity)Period.DeepCopy();
      if(SpecialPrecautionsForStorage != null) dest.SpecialPrecautionsForStorage = new List<Hl7.Fhir.Model.CodeableConcept>(SpecialPrecautionsForStorage.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new ProductShelfLife());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as ProductShelfLife;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(Type, otherT.Type)) return false;
      if( !DeepComparable.Matches(Period, otherT.Period)) return false;
      if( !DeepComparable.Matches(SpecialPrecautionsForStorage, otherT.SpecialPrecautionsForStorage)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as ProductShelfLife;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
      if( !DeepComparable.IsExactly(Period, otherT.Period)) return false;
      if( !DeepComparable.IsExactly(SpecialPrecautionsForStorage, otherT.SpecialPrecautionsForStorage)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        if (Identifier != null) yield return Identifier;
        if (Type != null) yield return Type;
        if (Period != null) yield return Period;
        foreach (var elem in SpecialPrecautionsForStorage) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        if (Identifier != null) yield return new ElementValue("identifier", Identifier);
        if (Type != null) yield return new ElementValue("type", Type);
        if (Period != null) yield return new ElementValue("period", Period);
        foreach (var elem in SpecialPrecautionsForStorage) { if (elem != null) yield return new ElementValue("specialPrecautionsForStorage", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "identifier":
          value = Identifier;
          return Identifier is not null;
        case "type":
          value = Type;
          return Type is not null;
        case "period":
          value = Period;
          return Period is not null;
        case "specialPrecautionsForStorage":
          value = SpecialPrecautionsForStorage;
          return SpecialPrecautionsForStorage?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier is not null) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (Type is not null) yield return new KeyValuePair<string,object>("type",Type);
      if (Period is not null) yield return new KeyValuePair<string,object>("period",Period);
      if (SpecialPrecautionsForStorage?.Any() == true) yield return new KeyValuePair<string,object>("specialPrecautionsForStorage",SpecialPrecautionsForStorage);
    }

  }

}

// end of file
