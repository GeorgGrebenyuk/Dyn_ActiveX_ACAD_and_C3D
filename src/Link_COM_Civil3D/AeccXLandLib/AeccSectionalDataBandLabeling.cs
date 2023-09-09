namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionalDataBandLabeling 
	{
		public AeccXLandLib.IAeccSectionalDataBandLabeling _i;
		internal AeccSectionalDataBandLabeling(object AeccSectionalDataBandLabeling_object) 
		{
			this._i = AeccSectionalDataBandLabeling_object as AeccXLandLib.IAeccSectionalDataBandLabeling;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
