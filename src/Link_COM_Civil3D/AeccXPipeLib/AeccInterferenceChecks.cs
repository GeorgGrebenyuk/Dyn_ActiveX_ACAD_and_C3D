namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccInterferenceChecks 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccInterferenceChecks _i;
		internal AeccInterferenceChecks(object AeccInterferenceChecks_object) 
		{
			this._i = AeccInterferenceChecks_object as Autodesk.AECC.Interop.Pipe.IAeccInterferenceChecks;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic GetDefaultCreationData => this._i.GetDefaultCreationData;

		///<summary>
		///
		///</summary>
		public dynamic Create(dynamic piCreationData) 
		{
			return this._i.Create(piCreationData);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object varIndexOrName) 
		{
			this._i.Remove(varIndexOrName);
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Item(object varIndex) 
		{
			return this._i.Item(varIndex);
		}
	}
}
