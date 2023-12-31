﻿namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceDirectionStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfaceDirectionStyle _i;
		internal AeccSurfaceDirectionStyle(object AeccSurfaceDirectionStyle_object) 
		{
			this._i = AeccSurfaceDirectionStyle_object as Autodesk.AECC.Interop.Land.IAeccSurfaceDirectionStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic GroupValuesBy => this._i.GroupValuesBy;

		///<summary>
		///
		///</summary>
		public void Set_GroupValuesBy(Autodesk.AECC.Interop.Land.AeccGroupValuesByType pVal) 
		{
			this._i.GroupValuesBy = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic NumberOfRanges => this._i.NumberOfRanges;

		///<summary>
		///
		///</summary>
		public void Set_NumberOfRanges(dynamic pVal) 
		{
			this._i.NumberOfRanges = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic RangePrecision => this._i.RangePrecision;

		///<summary>
		///
		///</summary>
		public void Set_RangePrecision(Autodesk.AECC.Interop.Land.AeccPrecisionRangeType pVal) 
		{
			this._i.RangePrecision = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayType => this._i.DisplayType;

		///<summary>
		///
		///</summary>
		public void Set_DisplayType(Autodesk.AECC.Interop.Land.AeccDisplayType pVal) 
		{
			this._i.DisplayType = pVal;
		}

		///<summary>
		///
		///</summary>
		public string Scheme => this._i.Scheme;

		///<summary>
		///
		///</summary>
		public void Set_Scheme(string pVal) 
		{
			this._i.Scheme = pVal;
		}

		///<summary>
		///
		///</summary>
		public string LegendStyle => this._i.LegendStyle;

		///<summary>
		///
		///</summary>
		public void Set_LegendStyle(string pVal) 
		{
			this._i.LegendStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyle2d => this._i.DisplayStyle2d;

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyle3d => this._i.DisplayStyle3d;

		///<summary>
		///
		///</summary>
		public dynamic DisplayStylePlan => this._i.DisplayStylePlan;

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyleModel => this._i.DisplayStyleModel;
	}
}
