namespace DynAeccXLandLib 
{

	///<summary>
	///IAeccProperty Interface
	///</summary>
	public class AeccProperty 
	{
		public AeccXLandLib.IAeccProperty _i;
		internal AeccProperty(object AeccProperty_object) 
		{
			this._i = AeccProperty_object as AeccXLandLib.IAeccProperty;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Locked(bool pVal) 
		{
			this._i.Locked = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool Locked => this._i.Locked;

		///<summary>
		///
		///</summary>
		public void Set_Overridden(bool pVal) 
		{
			this._i.Overridden = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool Overridden => this._i.Overridden;

		///<summary>
		///
		///</summary>
		public bool Overrideable => this._i.Overrideable;

		///<summary>
		///
		///</summary>
		public bool ReadOnly => this._i.ReadOnly;
	}
}
