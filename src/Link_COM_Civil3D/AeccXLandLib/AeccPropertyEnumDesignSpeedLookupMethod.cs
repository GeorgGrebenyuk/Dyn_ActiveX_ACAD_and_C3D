namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumDesignSpeedLookupMethod 
	{
		public AeccXLandLib.IAeccPropertyEnumDesignSpeedLookupMethod _i;
		internal AeccPropertyEnumDesignSpeedLookupMethod(object AeccPropertyEnumDesignSpeedLookupMethod_object) 
		{
			this._i = AeccPropertyEnumDesignSpeedLookupMethod_object as AeccXLandLib.IAeccPropertyEnumDesignSpeedLookupMethod;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccDesignSpeedLookupMethodType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
