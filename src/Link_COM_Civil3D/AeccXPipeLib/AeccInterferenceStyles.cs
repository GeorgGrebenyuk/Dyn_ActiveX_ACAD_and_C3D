namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccInterferenceStyles 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccInterferenceStyles _i;
		internal AeccInterferenceStyles(object AeccInterferenceStyles_object) 
		{
			this._i = AeccInterferenceStyles_object as Autodesk.AECC.Interop.Pipe.IAeccInterferenceStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Add(string bstrName) 
		{
			return this._i.Add(bstrName);
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
		public dynamic Item(object varIndexOrName) 
		{
			return this._i.Item(varIndexOrName);
		}
	}
}
