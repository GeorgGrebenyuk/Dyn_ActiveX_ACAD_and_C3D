namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentEntity 
	{
		public AeccXLandLib.IAeccAlignmentEntity _i;
		internal AeccAlignmentEntity(object AeccAlignmentEntity_object) 
		{
			this._i = AeccAlignmentEntity_object as AeccXLandLib.IAeccAlignmentEntity;
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
		public dynamic Constraint => this._i.Constraint;

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
		public dynamic SubEntityCount => this._i.SubEntityCount;

		///<summary>
		///
		///</summary>
		public dynamic SubEntity(dynamic lIndex) 
		{
			return this._i.SubEntity(lIndex);
		}
	}
}
