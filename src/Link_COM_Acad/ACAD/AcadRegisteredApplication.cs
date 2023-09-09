namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadRegisteredApplication 
	{
		public AXDBLib.IAcadRegisteredApplication _i;
		internal AcadRegisteredApplication(object AcadRegisteredApplication_object) 
		{
			this._i = AcadRegisteredApplication_object as AXDBLib.IAcadRegisteredApplication;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public void Set_Name(string bstrName) 
		{
			this._i.Name = bstrName;
		}
	}
}
