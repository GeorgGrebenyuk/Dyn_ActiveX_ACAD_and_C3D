namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionalDataBandLabeling 
	{
		public Autodesk.AECC.Interop.Land.IAeccSectionalDataBandLabeling _i;
		internal AeccSectionalDataBandLabeling(object AeccSectionalDataBandLabeling_object) 
		{
			this._i = AeccSectionalDataBandLabeling_object as Autodesk.AECC.Interop.Land.IAeccSectionalDataBandLabeling;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
