namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionalDataBandLabelingElement 
	{
		public Autodesk.AECC.Interop.Land.IAeccSectionalDataBandLabelingElement _i;
		internal AeccSectionalDataBandLabelingElement(object AeccSectionalDataBandLabelingElement_object) 
		{
			this._i = AeccSectionalDataBandLabelingElement_object as Autodesk.AECC.Interop.Land.IAeccSectionalDataBandLabelingElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
