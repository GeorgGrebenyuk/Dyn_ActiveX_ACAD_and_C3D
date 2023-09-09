namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsPointCreation 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsPointCreation _i;
		internal AeccSettingsPointCreation(object AeccSettingsPointCreation_object) 
		{
			this._i = AeccSettingsPointCreation_object as Autodesk.AECC.Interop.Land.IAeccSettingsPointCreation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic NextPointNumber => this._i.NextPointNumber;

		///<summary>
		///
		///</summary>
		public dynamic UseSequentialNumbering => this._i.UseSequentialNumbering;
	}
}
