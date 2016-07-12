using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V28.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V28.Group
{
///<summary>
///Represents the EHC_E10_PSGPSLADJ Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: PSG (Product/Service Group) </li>
///<li>1: EHC_E10_PRODUCT_SERVICE_LINE_INFO (a Group object) repeating</li>
///</ol>
///</summary>
[Serializable]
public class EHC_E10_PSGPSLADJ : AbstractGroup {

	///<summary> 
	/// Creates a new EHC_E10_PSGPSLADJ Group.
	///</summary>
	public EHC_E10_PSGPSLADJ(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(PSG), true, false);
	      this.add(typeof(EHC_E10_PRODUCT_SERVICE_LINE_INFO), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating EHC_E10_PSGPSLADJ - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns PSG (Product/Service Group) - creates it if necessary
	///</summary>
	public PSG PSG { 
get{
	   PSG ret = null;
	   try {
	      ret = (PSG)this.GetStructure("PSG");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of EHC_E10_PRODUCT_SERVICE_LINE_INFO (a Group object) - creates it if necessary
	///</summary>
	public EHC_E10_PRODUCT_SERVICE_LINE_INFO GetPRODUCT_SERVICE_LINE_INFO() {
	   EHC_E10_PRODUCT_SERVICE_LINE_INFO ret = null;
	   try {
	      ret = (EHC_E10_PRODUCT_SERVICE_LINE_INFO)this.GetStructure("PRODUCT_SERVICE_LINE_INFO");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of EHC_E10_PRODUCT_SERVICE_LINE_INFO
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public EHC_E10_PRODUCT_SERVICE_LINE_INFO GetPRODUCT_SERVICE_LINE_INFO(int rep) { 
	   return (EHC_E10_PRODUCT_SERVICE_LINE_INFO)this.GetStructure("PRODUCT_SERVICE_LINE_INFO", rep);
	}

	/** 
	 * Returns the number of existing repetitions of EHC_E10_PRODUCT_SERVICE_LINE_INFO 
	 */ 
	public int PRODUCT_SERVICE_LINE_INFORepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PRODUCT_SERVICE_LINE_INFO").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

}
}