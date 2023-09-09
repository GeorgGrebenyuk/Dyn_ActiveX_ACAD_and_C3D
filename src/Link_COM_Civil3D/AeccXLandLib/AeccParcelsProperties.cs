namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParcelsProperties 
	{
		public Autodesk.AECC.Interop.Land.IAeccParcelsProperties _i;
		internal AeccParcelsProperties(object AeccParcelsProperties_object) 
		{
			this._i = AeccParcelsProperties_object as Autodesk.AECC.Interop.Land.IAeccParcelsProperties;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AreaLabelStyle => this._i.AreaLabelStyle;

		///<summary>
		///
		///</summary>
		public void Put_AreaLabelStyle(dynamic pVal) 
		{
			this._i.AreaLabelStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic SegmentDisplayOrder => this._i.SegmentDisplayOrder;

		///<summary>
		///
		///</summary>
		public dynamic SiteParcelStyle => this._i.SiteParcelStyle;

		///<summary>
		///
		///</summary>
		public void Put_SiteParcelStyle(dynamic pVal) 
		{
			this._i.SiteParcelStyle = pVal;
		}

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
	}
}
