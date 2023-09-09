namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccBandSectionalDataStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccBandSectionalDataStyle _i;
		internal AeccBandSectionalDataStyle(object AeccBandSectionalDataStyle_object) 
		{
			this._i = AeccBandSectionalDataStyle_object as Autodesk.AECC.Interop.Land.IAeccBandSectionalDataStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
