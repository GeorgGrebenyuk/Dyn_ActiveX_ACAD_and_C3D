namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAbbreviationSuperelevation 
	{
		public AeccXLandLib.IAeccSettingsAbbreviationSuperelevation _i;
		internal AeccSettingsAbbreviationSuperelevation(object AeccSettingsAbbreviationSuperelevation_object) 
		{
			this._i = AeccSettingsAbbreviationSuperelevation_object as AeccXLandLib.IAeccSettingsAbbreviationSuperelevation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Manual(string pVal) 
		{
			this._i.Manual = pVal;
		}

		///<summary>
		///
		///</summary>
		public string Manual => this._i.Manual;

		///<summary>
		///
		///</summary>
		public void Set_EndOfAlignment(string pVal) 
		{
			this._i.EndOfAlignment = pVal;
		}

		///<summary>
		///
		///</summary>
		public string EndOfAlignment => this._i.EndOfAlignment;

		///<summary>
		///
		///</summary>
		public void Set_BeginNormalCrown(string pVal) 
		{
			this._i.BeginNormalCrown = pVal;
		}

		///<summary>
		///
		///</summary>
		public string BeginNormalCrown => this._i.BeginNormalCrown;

		///<summary>
		///
		///</summary>
		public void Set_EndNormalCrown(string pVal) 
		{
			this._i.EndNormalCrown = pVal;
		}

		///<summary>
		///
		///</summary>
		public string EndNormalCrown => this._i.EndNormalCrown;

		///<summary>
		///
		///</summary>
		public void Set_BeginFullSuper(string pVal) 
		{
			this._i.BeginFullSuper = pVal;
		}

		///<summary>
		///
		///</summary>
		public string BeginFullSuper => this._i.BeginFullSuper;

		///<summary>
		///
		///</summary>
		public void Set_BeginOfAlignment(string pVal) 
		{
			this._i.BeginOfAlignment = pVal;
		}

		///<summary>
		///
		///</summary>
		public string BeginOfAlignment => this._i.BeginOfAlignment;

		///<summary>
		///
		///</summary>
		public void Set_EndFullSuper(string pVal) 
		{
			this._i.EndFullSuper = pVal;
		}

		///<summary>
		///
		///</summary>
		public string EndFullSuper => this._i.EndFullSuper;

		///<summary>
		///
		///</summary>
		public void Set_BeginNormalShoulder(string pVal) 
		{
			this._i.BeginNormalShoulder = pVal;
		}

		///<summary>
		///
		///</summary>
		public string BeginNormalShoulder => this._i.BeginNormalShoulder;

		///<summary>
		///
		///</summary>
		public void Set_EndNormalShoulder(string pVal) 
		{
			this._i.EndNormalShoulder = pVal;
		}

		///<summary>
		///
		///</summary>
		public string EndNormalShoulder => this._i.EndNormalShoulder;

		///<summary>
		///
		///</summary>
		public void Set_LevelCrown(string pVal) 
		{
			this._i.LevelCrown = pVal;
		}

		///<summary>
		///
		///</summary>
		public string LevelCrown => this._i.LevelCrown;

		///<summary>
		///
		///</summary>
		public void Set_LowShoulderMatch(string pVal) 
		{
			this._i.LowShoulderMatch = pVal;
		}

		///<summary>
		///
		///</summary>
		public string LowShoulderMatch => this._i.LowShoulderMatch;

		///<summary>
		///
		///</summary>
		public void Set_ReverseCrown(string pVal) 
		{
			this._i.ReverseCrown = pVal;
		}

		///<summary>
		///
		///</summary>
		public string ReverseCrown => this._i.ReverseCrown;

		///<summary>
		///
		///</summary>
		public void Set_ShoulderBreakover(string pVal) 
		{
			this._i.ShoulderBreakover = pVal;
		}

		///<summary>
		///
		///</summary>
		public string ShoulderBreakover => this._i.ShoulderBreakover;
	}
}
