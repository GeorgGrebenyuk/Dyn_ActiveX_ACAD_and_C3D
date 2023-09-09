namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPointGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccPointGroup _i;
		internal AeccPointGroup(object AeccPointGroup_object) 
		{
			this._i = AeccPointGroup_object as Autodesk.AECC.Interop.Land.IAeccPointGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic PointStyle => this._i.PointStyle;

		///<summary>
		///
		///</summary>
		public void Set_PointStyle(object pVal) 
		{
			this._i.PointStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic PointLabelStyle => this._i.PointLabelStyle;

		///<summary>
		///
		///</summary>
		public void Set_PointLabelStyle(object pVal) 
		{
			this._i.PointLabelStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool OverrideRawDescription => this._i.OverrideRawDescription;

		///<summary>
		///
		///</summary>
		public void Set_OverrideRawDescription(bool pVal) 
		{
			this._i.OverrideRawDescription = pVal;
		}

		///<summary>
		///
		///</summary>
		public string RawDescription => this._i.RawDescription;

		///<summary>
		///
		///</summary>
		public void Set_RawDescription(string pVal) 
		{
			this._i.RawDescription = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool OverrideElevation => this._i.OverrideElevation;

		///<summary>
		///
		///</summary>
		public void Set_OverrideElevation(bool pVal) 
		{
			this._i.OverrideElevation = pVal;
		}

		///<summary>
		///
		///</summary>
		public double Elevation => this._i.Elevation;

		///<summary>
		///
		///</summary>
		public void Set_Elevation(double pVal) 
		{
			this._i.Elevation = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool OverridePointStyle => this._i.OverridePointStyle;

		///<summary>
		///
		///</summary>
		public void Set_OverridePointStyle(bool pVal) 
		{
			this._i.OverridePointStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool OverridePointLabelStyle => this._i.OverridePointLabelStyle;

		///<summary>
		///
		///</summary>
		public void Set_OverridePointLabelStyle(bool pVal) 
		{
			this._i.OverridePointLabelStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic QueryBuilder => this._i.QueryBuilder;

		///<summary>
		///
		///</summary>
		public object Points => this._i.Points;

		///<summary>
		///
		///</summary>
		public int PointCount => this._i.PointCount;

		///<summary>
		///
		///</summary>
		public bool ContainsPoint(dynamic PointNumber) 
		{
			return this._i.ContainsPoint(PointNumber);
		}

		///<summary>
		///
		///</summary>
		public dynamic DrawPriority => this._i.DrawPriority;

		///<summary>
		///
		///</summary>
		public dynamic GetUserDefinedPropertyClassification(out Autodesk.AECC.Interop.Land.AeccUDPClassificationApplyWay classificationApplyWay) 
		{
			return this._i.GetUserDefinedPropertyClassification(out classificationApplyWay);
		}

		///<summary>
		///
		///</summary>
		public void SetUserDefinedPropertyClassification(Autodesk.AECC.Interop.Land.AeccUDPClassificationApplyWay classificationApplyWay,object Classification) 
		{
			this._i.SetUserDefinedPropertyClassification(classificationApplyWay,Classification);
		}

		///<summary>
		///
		///</summary>
		public void Update() 
		{
			this._i.Update();
		}

		///<summary>
		///
		///</summary>
		public bool IsUpToDate => this._i.IsUpToDate;
	}
}
