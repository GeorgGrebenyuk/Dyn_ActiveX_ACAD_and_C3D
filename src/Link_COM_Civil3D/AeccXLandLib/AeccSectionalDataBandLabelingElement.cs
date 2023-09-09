namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionalDataBandLabelingElement 
	{
		public AeccXLandLib.IAeccSectionalDataBandLabelingElement _i;
		internal AeccSectionalDataBandLabelingElement(object AeccSectionalDataBandLabelingElement_object) 
		{
			this._i = AeccSectionalDataBandLabelingElement_object as AeccXLandLib.IAeccSectionalDataBandLabelingElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
