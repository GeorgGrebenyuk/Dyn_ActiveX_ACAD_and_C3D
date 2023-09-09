namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileEntity 
	{
		public AeccXLandLib.IAeccProfileEntity _i;
		internal AeccProfileEntity(object AeccProfileEntity_object) 
		{
			this._i = AeccProfileEntity_object as AeccXLandLib.IAeccProfileEntity;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public dynamic Id => this._i.Id;

		///<summary>
		///
		///</summary>
		public dynamic EntityConstraint => this._i.EntityConstraint;

		///<summary>
		///
		///</summary>
		public dynamic EntityBefore => this._i.EntityBefore;

		///<summary>
		///
		///</summary>
		public dynamic EntityAfter => this._i.EntityAfter;

		///<summary>
		///
		///</summary>
		public dynamic VerticalConstraint => this._i.VerticalConstraint;
	}
}
