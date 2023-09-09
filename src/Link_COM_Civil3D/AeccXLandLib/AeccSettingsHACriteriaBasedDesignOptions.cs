namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsHACriteriaBasedDesignOptions 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsHACriteriaBasedDesignOptions _i;
		internal AeccSettingsHACriteriaBasedDesignOptions(object AeccSettingsHACriteriaBasedDesignOptions_object) 
		{
			this._i = AeccSettingsHACriteriaBasedDesignOptions_object as Autodesk.AECC.Interop.Land.IAeccSettingsHACriteriaBasedDesignOptions;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic DesignSpeed => this._i.DesignSpeed;

		///<summary>
		///
		///</summary>
		public dynamic CriteriaBasedDesignOption => this._i.CriteriaBasedDesignOption;

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

		///<summary>
		///
		///</summary>
		public dynamic DesignSpeedLookupMethod => this._i.DesignSpeedLookupMethod;

		///<summary>
		///
		///</summary>
		public dynamic RadiusLookupMethod => this._i.RadiusLookupMethod;
	}
}
