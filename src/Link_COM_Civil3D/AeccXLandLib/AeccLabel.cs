namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabel 
	{
		public AeccXLandLib.IAeccLabel _i;
		internal AeccLabel(object AeccLabel_object) 
		{
			this._i = AeccLabel_object as AeccXLandLib.IAeccLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic LabelStyle => this._i.LabelStyle;

		///<summary>
		///
		///</summary>
		public void Set_LabelStyle(object ppVal) 
		{
			this._i.LabelStyle = ppVal;
		}

		///<summary>
		///
		///</summary>
		public void Set_Flipped(bool pVal) 
		{
			this._i.Flipped = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool Flipped => this._i.Flipped;

		///<summary>
		///
		///</summary>
		public void Set_Reversed(bool pVal) 
		{
			this._i.Reversed = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool Reversed => this._i.Reversed;

		///<summary>
		///
		///</summary>
		public void Set_Pinned(bool pVal) 
		{
			this._i.Pinned = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool Pinned => this._i.Pinned;
	}
}
