namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccDesignSpeed 
	{
		public AeccXLandLib.IAeccDesignSpeed _i;
		internal AeccDesignSpeed(object AeccDesignSpeed_object) 
		{
			this._i = AeccDesignSpeed_object as AeccXLandLib.IAeccDesignSpeed;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SpeedNumber => this._i.SpeedNumber;

		///<summary>
		///
		///</summary>
		public double Station => this._i.Station;

		///<summary>
		///
		///</summary>
		public double Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(double Number) 
		{
			this._i.Value = Number;
		}

		///<summary>
		///
		///</summary>
		public string Comment => this._i.Comment;

		///<summary>
		///
		///</summary>
		public void Set_Comment(string Comment) 
		{
			this._i.Comment = Comment;
		}
	}
}
