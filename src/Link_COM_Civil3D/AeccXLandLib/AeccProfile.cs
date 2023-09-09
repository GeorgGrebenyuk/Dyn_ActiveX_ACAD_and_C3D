namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfile 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfile _i;
		internal AeccProfile(object AeccProfile_object) 
		{
			this._i = AeccProfile_object as Autodesk.AECC.Interop.Land.IAeccProfile;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string StyleName => this._i.StyleName;

		///<summary>
		///
		///</summary>
		public dynamic Style => this._i.Style;

		///<summary>
		///
		///</summary>
		public void Set_Style(object Style) 
		{
			this._i.Style = Style;
		}

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public void Set_Type(Autodesk.AECC.Interop.Land.AeccProfileType Type) 
		{
			this._i.Type = Type;
		}

		///<summary>
		///
		///</summary>
		public double SampledStartingStation => this._i.SampledStartingStation;

		///<summary>
		///
		///</summary>
		public double SampledEndingStation => this._i.SampledEndingStation;

		///<summary>
		///
		///</summary>
		public double StartingStation => this._i.StartingStation;

		///<summary>
		///
		///</summary>
		public double EndingStation => this._i.EndingStation;

		///<summary>
		///
		///</summary>
		public double Offset => this._i.Offset;

		///<summary>
		///
		///</summary>
		public void Set_Offset(double Elevation) 
		{
			this._i.Offset = Elevation;
		}

		///<summary>
		///
		///</summary>
		public double Length => this._i.Length;

		///<summary>
		///
		///</summary>
		public bool ShowLabels => this._i.ShowLabels;

		///<summary>
		///
		///</summary>
		public void Set_ShowLabels(bool pVal) 
		{
			this._i.ShowLabels = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Alignment => this._i.Alignment;

		///<summary>
		///
		///</summary>
		public bool Dynamic => this._i.Dynamic;

		///<summary>
		///
		///</summary>
		public void Set_Dynamic(bool pVal) 
		{
			this._i.Dynamic = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic PVIs => this._i.PVIs;

		///<summary>
		///
		///</summary>
		public double ElevationAt(double Station) 
		{
			return this._i.ElevationAt(Station);
		}

		///<summary>
		///
		///</summary>
		public void InstantGrade(double Station,out double Grade) 
		{
			this._i.InstantGrade(Station,out Grade);
		}

		///<summary>
		///
		///</summary>
		public double WeedGradeFactor => this._i.WeedGradeFactor;

		///<summary>
		///
		///</summary>
		public dynamic Surface => this._i.Surface;

		///<summary>
		///
		///</summary>
		public bool IsReverseStationing => this._i.IsReverseStationing;

		///<summary>
		///
		///</summary>
		public double ElevationMin => this._i.ElevationMin;

		///<summary>
		///
		///</summary>
		public double ElevationMax => this._i.ElevationMax;

		///<summary>
		///
		///</summary>
		public bool Plinegen => this._i.Plinegen;

		///<summary>
		///
		///</summary>
		public void Set_Plinegen(bool pVal) 
		{
			this._i.Plinegen = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Entities => this._i.Entities;

		///<summary>
		///
		///</summary>
		public dynamic LabelGroups(object ProfileView) 
		{
			return this._i.LabelGroups(ProfileView);
		}

		///<summary>
		///
		///</summary>
		public bool DesignSpeedBased => this._i.DesignSpeedBased;

		///<summary>
		///
		///</summary>
		public void Set_DesignSpeedBased(bool pValue) 
		{
			this._i.DesignSpeedBased = pValue;
		}

		///<summary>
		///
		///</summary>
		public bool UseDesignCriteriaFile => this._i.UseDesignCriteriaFile;

		///<summary>
		///
		///</summary>
		public void Set_UseDesignCriteriaFile(bool pValue) 
		{
			this._i.UseDesignCriteriaFile = pValue;
		}

		///<summary>
		///
		///</summary>
		public bool UseDesignCheckSet => this._i.UseDesignCheckSet;

		///<summary>
		///
		///</summary>
		public void Set_UseDesignCheckSet(bool pValue) 
		{
			this._i.UseDesignCheckSet = pValue;
		}
	}
}
