namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadBlockReference 
	{
		public AXDBLib.IAcadBlockReference _i;
		internal AcadBlockReference(object AcadBlockReference_object) 
		{
			this._i = AcadBlockReference_object as AXDBLib.IAcadBlockReference;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public object InsertionPoint => this._i.InsertionPoint;

		///<summary>
		///
		///</summary>
		public void Set_InsertionPoint(object insPoint) 
		{
			this._i.InsertionPoint = insPoint;
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

		///<summary>
		///
		///</summary>
		public object Normal => this._i.Normal;

		///<summary>
		///
		///</summary>
		public void Set_Normal(object Normal) 
		{
			this._i.Normal = Normal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Rotation => this._i.Rotation;

		///<summary>
		///
		///</summary>
		public void Set_Rotation(dynamic rotAngle) 
		{
			this._i.Rotation = rotAngle;
		}

		///<summary>
		///
		///</summary>
		public dynamic XScaleFactor => this._i.XScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_XScaleFactor(dynamic ScaleFactor) 
		{
			this._i.XScaleFactor = ScaleFactor;
		}

		///<summary>
		///
		///</summary>
		public dynamic YScaleFactor => this._i.YScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_YScaleFactor(dynamic ScaleFactor) 
		{
			this._i.YScaleFactor = ScaleFactor;
		}

		///<summary>
		///
		///</summary>
		public dynamic ZScaleFactor => this._i.ZScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_ZScaleFactor(dynamic ScaleFactor) 
		{
			this._i.ZScaleFactor = ScaleFactor;
		}

		///<summary>
		///
		///</summary>
		public object Explode => this._i.Explode;

		///<summary>
		///
		///</summary>
		public object GetAttributes => this._i.GetAttributes;

		///<summary>
		///
		///</summary>
		public object GetConstantAttributes => this._i.GetConstantAttributes;

		///<summary>
		///
		///</summary>
		public bool HasAttributes => this._i.HasAttributes;

		///<summary>
		///
		///</summary>
		public string EffectiveName => this._i.EffectiveName;

		///<summary>
		///
		///</summary>
		public bool IsDynamicBlock => this._i.IsDynamicBlock;

		///<summary>
		///
		///</summary>
		public object GetDynamicBlockProperties => this._i.GetDynamicBlockProperties;

		///<summary>
		///
		///</summary>
		public void ResetBlock() 
		{
			this._i.ResetBlock();
		}

		///<summary>
		///
		///</summary>
		public void ConvertToAnonymousBlock() 
		{
			this._i.ConvertToAnonymousBlock();
		}

		///<summary>
		///
		///</summary>
		public void ConvertToStaticBlock(string newBlockName) 
		{
			this._i.ConvertToStaticBlock(newBlockName);
		}

		///<summary>
		///
		///</summary>
		public dynamic XEffectiveScaleFactor => this._i.XEffectiveScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_XEffectiveScaleFactor(dynamic ScaleFactor) 
		{
			this._i.XEffectiveScaleFactor = ScaleFactor;
		}

		///<summary>
		///
		///</summary>
		public dynamic YEffectiveScaleFactor => this._i.YEffectiveScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_YEffectiveScaleFactor(dynamic ScaleFactor) 
		{
			this._i.YEffectiveScaleFactor = ScaleFactor;
		}

		///<summary>
		///
		///</summary>
		public dynamic ZEffectiveScaleFactor => this._i.ZEffectiveScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_ZEffectiveScaleFactor(dynamic ScaleFactor) 
		{
			this._i.ZEffectiveScaleFactor = ScaleFactor;
		}

		///<summary>
		///
		///</summary>
		public string InsUnits => this._i.InsUnits;

		///<summary>
		///
		///</summary>
		public double InsUnitsFactor => this._i.InsUnitsFactor;
	}
}
