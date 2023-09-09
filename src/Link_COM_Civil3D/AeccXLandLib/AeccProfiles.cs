namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfiles 
	{
		public AeccXLandLib.IAeccProfiles _i;
		internal AeccProfiles(object AeccProfiles_object) 
		{
			this._i = AeccProfiles_object as AeccXLandLib.IAeccProfiles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Item(object Index) 
		{
			return this._i.Item(Index);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFromSurface(string Name,AeccXLandLib.AeccProfileType ProfileType,object ProfileStyle,object Surface,double SampleStartStation,double SampleEndStation,string LayerName) 
		{
			return this._i.AddFromSurface(Name,ProfileType,ProfileStyle,Surface,SampleStartStation,SampleEndStation,LayerName);
		}

		///<summary>
		///
		///</summary>
		public dynamic Add(string Name,AeccXLandLib.AeccProfileType ProfileType,object ProfileStyle) 
		{
			return this._i.Add(Name,ProfileType,ProfileStyle);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object Name) 
		{
			this._i.Remove(Name);
		}
	}
}
