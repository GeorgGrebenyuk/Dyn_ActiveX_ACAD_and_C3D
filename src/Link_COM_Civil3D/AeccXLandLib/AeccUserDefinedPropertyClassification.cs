namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccUserDefinedPropertyClassification 
	{
		public AeccXLandLib.IAeccUserDefinedPropertyClassification _i;
		internal AeccUserDefinedPropertyClassification(object AeccUserDefinedPropertyClassification_object) 
		{
			this._i = AeccUserDefinedPropertyClassification_object as AeccXLandLib.IAeccUserDefinedPropertyClassification;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic UserDefinedProperties => this._i.UserDefinedProperties;

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public bool IsPointClassification => this._i.IsPointClassification;
	}
}
