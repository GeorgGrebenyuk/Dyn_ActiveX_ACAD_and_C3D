namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsVACriteriaBasedDesignOptions 
	{
		public AeccXLandLib.IAeccSettingsVACriteriaBasedDesignOptions _i;
		internal AeccSettingsVACriteriaBasedDesignOptions(object AeccSettingsVACriteriaBasedDesignOptions_object) 
		{
			this._i = AeccSettingsVACriteriaBasedDesignOptions_object as AeccXLandLib.IAeccSettingsVACriteriaBasedDesignOptions;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic UseDesignCriteriaFileOption => this._i.UseDesignCriteriaFileOption;

		///<summary>
		///
		///</summary>
		public dynamic UseDesignChecksOption => this._i.UseDesignChecksOption;

		///<summary>
		///
		///</summary>
		public dynamic DefaultDesignCheckSet => this._i.DefaultDesignCheckSet;
	}
}
