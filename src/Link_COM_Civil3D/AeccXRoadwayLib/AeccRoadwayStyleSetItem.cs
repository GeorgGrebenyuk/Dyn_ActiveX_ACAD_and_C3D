namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccRoadwayStyleSetItem 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccRoadwayStyleSetItem _i;
		internal AeccRoadwayStyleSetItem(object AeccRoadwayStyleSetItem_object) 
		{
			this._i = AeccRoadwayStyleSetItem_object as Autodesk.AECC.Interop.Roadway.IAeccRoadwayStyleSetItem;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Code(string pVal) 
		{
			this._i.Code = pVal;
		}

		///<summary>
		///
		///</summary>
		public string Code => this._i.Code;

		///<summary>
		///
		///</summary>
		public void Set_CodeStyle(dynamic pVal) 
		{
			this._i.CodeStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic CodeStyle => this._i.CodeStyle;

		///<summary>
		///
		///</summary>
		public void Set_Description(string pVal) 
		{
			this._i.Description = pVal;
		}

		///<summary>
		///
		///</summary>
		public string Description => this._i.Description;

		///<summary>
		///
		///</summary>
		public dynamic StyleType => this._i.StyleType;

		///<summary>
		///
		///</summary>
		public dynamic ItemType => this._i.ItemType;
	}
}
