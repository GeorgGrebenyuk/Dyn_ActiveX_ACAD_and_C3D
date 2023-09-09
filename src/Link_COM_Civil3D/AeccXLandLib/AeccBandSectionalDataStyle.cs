namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccBandSectionalDataStyle 
	{
		public AeccXLandLib.IAeccBandSectionalDataStyle _i;
		internal AeccBandSectionalDataStyle(object AeccBandSectionalDataStyle_object) 
		{
			this._i = AeccBandSectionalDataStyle_object as AeccXLandLib.IAeccBandSectionalDataStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
